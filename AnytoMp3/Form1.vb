Imports System.ComponentModel
Imports System.IO
Imports System.Security.Cryptography
Imports System.Threading
Imports Syncfusion.Windows.Forms.Tools
Imports MetroSet_UI.Controls
Imports Syncfusion.WinForms.Controls
Imports Xabe.FFmpeg
Imports Xabe.FFmpeg.Downloader
Imports YoutubeExplode
Imports YoutubeExplode.Videos
Imports YoutubeExplode.Videos.Streams
Imports Syncfusion.Windows.Forms.Tools.Win32API
Imports Stannieman.AudioPlayer

Public Class Form1
    Dim Filename As String

    Dim Trackinfo As New List(Of Titleinfo)


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        With OpenFileDialog1
            .ShowDialog()

            If .FileName.Length > 0 Then
                Filename = .FileName
                Dim tsk As New Thread(AddressOf Convert_Audio_From_File) With {.IsBackground = True}
                tsk.Start()
            End If
        End With
    End Sub

    Private Function Convert_Audio_From_File()

        Try

            Dim Output = Path.ChangeExtension(Filename, "mp3")

            Dim Vidinformation = FFmpeg.GetMediaInfo(Filename).Result

            Dim Convert_to_Mp3 = FFmpeg.Conversions.FromSnippet.ExtractAudio(Filename, Output).Result

            Convert_to_Mp3.Start()

        Catch ex As Exception
            Console.WriteLine(ex.StackTrace & ex.Message)
        End Try
    End Function



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        FFmpegDownloader.GetLatestVersion(FFmpegVersion.Official, "Settings")

        FFmpeg.SetExecutablesPath("Settings")
        Console.WriteLine(FFmpeg.ExecutablesPath)
    End Sub

    Private Sub btn_add_to_list_Click(sender As Object, e As EventArgs) Handles btn_add_to_list.Click

        Dim tst As New Thread(AddressOf Getytinfo) With {.IsBackground = True}
        tst.Start()

    End Sub

    Private Function Thumpbnail_Request() As Boolean
        Return False
    End Function
    Private Sub Getytinfo()
        Dim ytClient As New YoutubeClient
        Dim ytvidMeta = ytClient.Videos.GetAsync(txb_Input_Link.Text).Result

        Dim Randomgenerator As New Random

        Dim RdmNr = Randomgenerator.Next()

        Trackinfo.Add(New Titleinfo With {.ID = $"pn_{RdmNr}", .Link = txb_Input_Link.Text, .Video = ytvidMeta})


        Dim Panel_Location As New POINT

        If pn_haupt.Controls.Count = 0 Then
            Panel_Location = New POINT(0, 0)
        Else
            Panel_Location = New POINT(0, pn_haupt.Controls.Item(pn_haupt.Controls.Count - 1).Location.Y + 120)
        End If

        Dim NewSubPan As New GradientPanelExt With {.Name = $"pn_{RdmNr}", .Location = Panel_Location, .Size = New Drawing.Size(pn_haupt.Size.Width, 125)}
        Dim NewPicbox As New PictureBox With {.Name = $"picbx_{RdmNr}", .Location = New POINT(40, 0), .Size = New Drawing.Size(124, 124), .SizeMode = PictureBoxSizeMode.Zoom, .ImageLocation = ytvidMeta.Thumbnails.HighResUrl}
        Dim NewLbl_Title As New MetroSetLabel With {.Name = $"lbl_Title_{RdmNr}", .Location = New POINT(173, 15), .AutoSize = False, .Size = New Drawing.Size(400, 15), .AutoEllipsis = True, .Text = ytvidMeta.Title, .ForeColor = Color.White}
        Dim NewLbl_Author As New MetroSetLabel With {.Name = $"lbl_Author_{RdmNr}", .Location = New POINT(173, 35), .AutoSize = False, .Size = New Drawing.Size(400, 15), .AutoEllipsis = True, .Text = ytvidMeta.Author, .ForeColor = Color.White}
        Dim NewLbl_Duration As New MetroSetLabel With {.Name = $"lbl_Duration_{RdmNr}", .Location = New POINT(173, 55), .AutoSize = False, .Size = New Drawing.Size(400, 15), .AutoEllipsis = True, .Text = ytvidMeta.Duration.ToString}
        Dim NewBtn_Download As New MetroSetEllipse With {.Name = $"btn_Download_{RdmNr}", .Size = New Drawing.Size(64, 64), .Location = New POINT(630, NewSubPan.Height / 2 - 32), .Tag = ytvidMeta.Title, .Image = My.Resources.icons8_download_64px_1, .ImageSize = New Size(40, 40)}
        Dim Newprog_Status As New MetroSetProgressBar With {.Name = $"Progr_Status_{RdmNr}", .Location = New POINT(173, 75), .AutoSize = False, .Size = New Drawing.Size(150, 20), .Value = 0, .Style = MetroSet_UI.Design.Style.Dark}


        RemoveHandler NewSubPan.MouseMove, AddressOf NewSubPan_MouseMove
        AddHandler NewSubPan.MouseMove, AddressOf NewSubPan_MouseMove

        RemoveHandler NewBtn_Download.Click, AddressOf NewBtn_Download_Click
        AddHandler NewBtn_Download.Click, AddressOf NewBtn_Download_Click

        With NewSubPan.Controls
            .Add(NewPicbox)
            .Add(NewLbl_Title)
            .Add(NewLbl_Author)
            .Add(NewLbl_Duration)
            .Add(NewBtn_Download)
            .Add(Newprog_Status)
        End With


        Me.Invoke(Sub() pn_haupt.Controls.Add(NewSubPan))


    End Sub

    Private Sub NewSubPan_MouseMove(sender As Object, e As MouseEventArgs)
        Invoke(Sub() MetroSetLabel2.Text = $"X{e.X} Y: {e.Y}")
    End Sub

    Private Sub NewBtn_Download_Click(sender As Object, e As EventArgs)
        Dim curBtn = CType(sender, MetroSetEllipse)
        Dim thrd As New Thread(AddressOf Download_YT_as_Mp3) With {.IsBackground = True, .Name = $"Thread_{curBtn.Tag}"}

        Downloadname = curBtn.Tag

        For Each Untercontrols In curBtn.Parent.Controls

            If TypeOf Untercontrols Is MetroSetProgressBar Then

                Currentprog = CType(Untercontrols, MetroSetProgressBar)

            End If

        Next

        thrd.Start()

    End Sub

    Dim Downloadname As New Object
    Dim Currentprog As MetroSetProgressBar
    Dim Currentlbl_Status As Label
    Dim Download_prozent As Double = 0.0
    Private Async Sub Download_YT_as_Mp3()
        Dim ytClient As New YoutubeClient
        Dim StreamManifest = ytClient.Videos.Streams.GetManifestAsync(txb_Input_Link.Text).Result
        Dim Streaminfo = StreamManifest.GetAudioOnly.WithHighestBitrate

        Invoke(Sub() Currentprog.Maximum = Streaminfo.Size.TotalBytes)

        Await ytClient.Videos.Streams.DownloadAsync(Streaminfo, $"{Downloadname}.mp3")
        Download_prozent = Streaminfo.Size.TotalMegaBytes
        Dim t = New FileInfo($"{Downloadname}.mp3").Length

        Invoke(Sub() Currentprog.Value = t)








    End Sub



    Class Titleinfo
        Public Property Link
        Public Property Video As Video
        Public Property ID
    End Class


    Function Musikplayer(Filename As String)
        Try
            Dim Player As New BasicAudio.AudioPlayer

            Player.Filename = Filename
            Console.WriteLine(Player.FileSize)
            Player.Play()

        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try

    End Function



    Private Async Sub MetroSetButton1_Click(sender As Object, e As EventArgs) Handles MetroSetButton1.Click


        With OpenFileDialog2
            .ShowDialog()
            Musikplayer(.FileName)

        End With

            ' MetroSetProgressBar1.Value = Audiplayer.GetCurrentTrackPositionAsync()


        End Sub
    End Class



