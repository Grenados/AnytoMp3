<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits MetroSet_UI.Forms.MetroSetForm

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.StyleManager1 = New MetroSet_UI.StyleManager()
        Me.txb_Input_Link = New MetroSet_UI.Controls.MetroSetTextBox()
        Me.MetroSetBadge1 = New MetroSet_UI.Controls.MetroSetBadge()
        Me.MetroSetControlBox1 = New MetroSet_UI.Controls.MetroSetControlBox()
        Me.MetroSetLabel2 = New MetroSet_UI.Controls.MetroSetLabel()
        Me.btn_add_to_list = New MetroSet_UI.Controls.MetroSetEllipse()
        Me.pn_haupt = New MetroSet_UI.Controls.MetroSetPanel()
        Me.MetroSetProgressBar1 = New MetroSet_UI.Controls.MetroSetProgressBar()
        Me.MetroSetButton1 = New MetroSet_UI.Controls.MetroSetButton()
        Me.MetroSetLabel1 = New MetroSet_UI.Controls.MetroSetLabel()
        Me.MetroSetTrackBar1 = New MetroSet_UI.Controls.MetroSetTrackBar()
        Me.OpenFileDialog2 = New System.Windows.Forms.OpenFileDialog()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(691, 389)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Convert"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'StyleManager1
        '
        Me.StyleManager1.CustomTheme = "C:\Users\marti\AppData\Roaming\Microsoft\Windows\Templates\ThemeFile.xml"
        Me.StyleManager1.MetroForm = Me
        Me.StyleManager1.Style = MetroSet_UI.Design.Style.Dark
        Me.StyleManager1.ThemeAuthor = "Narwin"
        Me.StyleManager1.ThemeName = "MetroDark"
        '
        'txb_Input_Link
        '
        Me.txb_Input_Link.AutoCompleteCustomSource = Nothing
        Me.txb_Input_Link.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.txb_Input_Link.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.txb_Input_Link.BorderColor = System.Drawing.Color.FromArgb(CType(CType(110, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.txb_Input_Link.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.txb_Input_Link.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txb_Input_Link.DisabledForeColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txb_Input_Link.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txb_Input_Link.HoverColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.txb_Input_Link.Image = Nothing
        Me.txb_Input_Link.Lines = Nothing
        Me.txb_Input_Link.Location = New System.Drawing.Point(12, 73)
        Me.txb_Input_Link.MaxLength = 32767
        Me.txb_Input_Link.Multiline = False
        Me.txb_Input_Link.Name = "txb_Input_Link"
        Me.txb_Input_Link.ReadOnly = False
        Me.txb_Input_Link.Size = New System.Drawing.Size(715, 30)
        Me.txb_Input_Link.Style = MetroSet_UI.Design.Style.Dark
        Me.txb_Input_Link.StyleManager = Me.StyleManager1
        Me.txb_Input_Link.TabIndex = 11
        Me.txb_Input_Link.Text = "https://www.youtube.com/watch?v=j0lSpNtjPM8&"
        Me.txb_Input_Link.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txb_Input_Link.ThemeAuthor = "Narwin"
        Me.txb_Input_Link.ThemeName = "MetroDark"
        Me.txb_Input_Link.UseSystemPasswordChar = False
        Me.txb_Input_Link.WatermarkText = ""
        '
        'MetroSetBadge1
        '
        Me.MetroSetBadge1.BackColor = System.Drawing.Color.Transparent
        Me.MetroSetBadge1.BadgeAlignment = MetroSet_UI.Enums.BadgeAlign.TopRight
        Me.MetroSetBadge1.BadgeText = "3"
        Me.MetroSetBadge1.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.MetroSetBadge1.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.MetroSetBadge1.DisabledForeColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.MetroSetBadge1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.MetroSetBadge1.HoverBadgeColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.MetroSetBadge1.HoverBadgeTextColor = System.Drawing.Color.White
        Me.MetroSetBadge1.HoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.MetroSetBadge1.HoverColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.MetroSetBadge1.HoverTextColor = System.Drawing.Color.White
        Me.MetroSetBadge1.Location = New System.Drawing.Point(85, 421)
        Me.MetroSetBadge1.Name = "MetroSetBadge1"
        Me.MetroSetBadge1.NormalBadgeColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.MetroSetBadge1.NormalBadgeTextColor = System.Drawing.Color.White
        Me.MetroSetBadge1.NormalBorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.MetroSetBadge1.NormalColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.MetroSetBadge1.NormalTextColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.MetroSetBadge1.PressBadgeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.MetroSetBadge1.PressBadgeTextColor = System.Drawing.Color.White
        Me.MetroSetBadge1.PressBorderColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.MetroSetBadge1.PressColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.MetroSetBadge1.PressTextColor = System.Drawing.Color.White
        Me.MetroSetBadge1.Size = New System.Drawing.Size(135, 77)
        Me.MetroSetBadge1.Style = MetroSet_UI.Design.Style.Dark
        Me.MetroSetBadge1.StyleManager = Me.StyleManager1
        Me.MetroSetBadge1.TabIndex = 13
        Me.MetroSetBadge1.Text = "MetroSetBadge1"
        Me.MetroSetBadge1.ThemeAuthor = "Narwin"
        Me.MetroSetBadge1.ThemeName = "MetroDark"
        '
        'MetroSetControlBox1
        '
        Me.MetroSetControlBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroSetControlBox1.CloseHoverBackColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.MetroSetControlBox1.CloseHoverForeColor = System.Drawing.Color.White
        Me.MetroSetControlBox1.CloseNormalForeColor = System.Drawing.Color.Gray
        Me.MetroSetControlBox1.DisabledForeColor = System.Drawing.Color.Silver
        Me.MetroSetControlBox1.Location = New System.Drawing.Point(691, 3)
        Me.MetroSetControlBox1.MaximizeBox = True
        Me.MetroSetControlBox1.MaximizeHoverBackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.MetroSetControlBox1.MaximizeHoverForeColor = System.Drawing.Color.Gray
        Me.MetroSetControlBox1.MaximizeNormalForeColor = System.Drawing.Color.Gray
        Me.MetroSetControlBox1.MinimizeBox = True
        Me.MetroSetControlBox1.MinimizeHoverBackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.MetroSetControlBox1.MinimizeHoverForeColor = System.Drawing.Color.Gray
        Me.MetroSetControlBox1.MinimizeNormalForeColor = System.Drawing.Color.Gray
        Me.MetroSetControlBox1.Name = "MetroSetControlBox1"
        Me.MetroSetControlBox1.Size = New System.Drawing.Size(100, 25)
        Me.MetroSetControlBox1.Style = MetroSet_UI.Design.Style.Dark
        Me.MetroSetControlBox1.StyleManager = Me.StyleManager1
        Me.MetroSetControlBox1.TabIndex = 15
        Me.MetroSetControlBox1.Text = "MetroSetControlBox1"
        Me.MetroSetControlBox1.ThemeAuthor = "Narwin"
        Me.MetroSetControlBox1.ThemeName = "MetroDark"
        '
        'MetroSetLabel2
        '
        Me.MetroSetLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.MetroSetLabel2.Location = New System.Drawing.Point(645, 442)
        Me.MetroSetLabel2.Name = "MetroSetLabel2"
        Me.MetroSetLabel2.Size = New System.Drawing.Size(100, 23)
        Me.MetroSetLabel2.Style = MetroSet_UI.Design.Style.Dark
        Me.MetroSetLabel2.StyleManager = Me.StyleManager1
        Me.MetroSetLabel2.TabIndex = 16
        Me.MetroSetLabel2.Text = "MetroSetLabel2"
        Me.MetroSetLabel2.ThemeAuthor = "Narwin"
        Me.MetroSetLabel2.ThemeName = "MetroDark"
        '
        'btn_add_to_list
        '
        Me.btn_add_to_list.BorderThickness = 7
        Me.btn_add_to_list.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.btn_add_to_list.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.btn_add_to_list.DisabledForeColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.btn_add_to_list.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.btn_add_to_list.HoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btn_add_to_list.HoverColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btn_add_to_list.HoverTextColor = System.Drawing.Color.White
        Me.btn_add_to_list.Image = Global.AnytoMp3.My.Resources.Resources.icons8_add_64px
        Me.btn_add_to_list.ImageSize = New System.Drawing.Size(40, 40)
        Me.btn_add_to_list.Location = New System.Drawing.Point(733, 62)
        Me.btn_add_to_list.Name = "btn_add_to_list"
        Me.btn_add_to_list.NormalBorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_add_to_list.NormalColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.btn_add_to_list.NormalTextColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btn_add_to_list.PressBorderColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.btn_add_to_list.PressColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.btn_add_to_list.PressTextColor = System.Drawing.Color.White
        Me.btn_add_to_list.Size = New System.Drawing.Size(52, 52)
        Me.btn_add_to_list.Style = MetroSet_UI.Design.Style.Dark
        Me.btn_add_to_list.StyleManager = Me.StyleManager1
        Me.btn_add_to_list.TabIndex = 14
        Me.btn_add_to_list.ThemeAuthor = "Narwin"
        Me.btn_add_to_list.ThemeName = "MetroDark"
        '
        'pn_haupt
        '
        Me.pn_haupt.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.pn_haupt.BorderColor = System.Drawing.Color.FromArgb(CType(CType(110, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.pn_haupt.BorderThickness = 1
        Me.pn_haupt.Location = New System.Drawing.Point(12, 109)
        Me.pn_haupt.Name = "pn_haupt"
        Me.pn_haupt.Size = New System.Drawing.Size(715, 264)
        Me.pn_haupt.Style = MetroSet_UI.Design.Style.Dark
        Me.pn_haupt.StyleManager = Me.StyleManager1
        Me.pn_haupt.TabIndex = 17
        Me.pn_haupt.ThemeAuthor = "Narwin"
        Me.pn_haupt.ThemeName = "MetroDark"
        '
        'MetroSetProgressBar1
        '
        Me.MetroSetProgressBar1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.MetroSetProgressBar1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.MetroSetProgressBar1.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.MetroSetProgressBar1.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.MetroSetProgressBar1.DisabledProgressColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.MetroSetProgressBar1.Location = New System.Drawing.Point(300, 405)
        Me.MetroSetProgressBar1.Maximum = 100
        Me.MetroSetProgressBar1.Minimum = 0
        Me.MetroSetProgressBar1.Name = "MetroSetProgressBar1"
        Me.MetroSetProgressBar1.Orientation = MetroSet_UI.Enums.ProgressOrientation.Horizontal
        Me.MetroSetProgressBar1.ProgressColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.MetroSetProgressBar1.Size = New System.Drawing.Size(75, 23)
        Me.MetroSetProgressBar1.Style = MetroSet_UI.Design.Style.Dark
        Me.MetroSetProgressBar1.StyleManager = Me.StyleManager1
        Me.MetroSetProgressBar1.TabIndex = 18
        Me.MetroSetProgressBar1.Text = "MetroSetProgressBar1"
        Me.MetroSetProgressBar1.ThemeAuthor = "Narwin"
        Me.MetroSetProgressBar1.ThemeName = "MetroDark"
        Me.MetroSetProgressBar1.Value = 0
        '
        'MetroSetButton1
        '
        Me.MetroSetButton1.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.MetroSetButton1.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.MetroSetButton1.DisabledForeColor = System.Drawing.Color.Gray
        Me.MetroSetButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.MetroSetButton1.HoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MetroSetButton1.HoverColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MetroSetButton1.HoverTextColor = System.Drawing.Color.White
        Me.MetroSetButton1.Location = New System.Drawing.Point(502, 404)
        Me.MetroSetButton1.Name = "MetroSetButton1"
        Me.MetroSetButton1.NormalBorderColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.MetroSetButton1.NormalColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.MetroSetButton1.NormalTextColor = System.Drawing.Color.White
        Me.MetroSetButton1.PressBorderColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.MetroSetButton1.PressColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.MetroSetButton1.PressTextColor = System.Drawing.Color.White
        Me.MetroSetButton1.Size = New System.Drawing.Size(75, 23)
        Me.MetroSetButton1.Style = MetroSet_UI.Design.Style.Dark
        Me.MetroSetButton1.StyleManager = Me.StyleManager1
        Me.MetroSetButton1.TabIndex = 19
        Me.MetroSetButton1.Text = "Play"
        Me.MetroSetButton1.ThemeAuthor = "Narwin"
        Me.MetroSetButton1.ThemeName = "MetroDark"
        '
        'MetroSetLabel1
        '
        Me.MetroSetLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.MetroSetLabel1.Location = New System.Drawing.Point(427, 442)
        Me.MetroSetLabel1.Name = "MetroSetLabel1"
        Me.MetroSetLabel1.Size = New System.Drawing.Size(100, 23)
        Me.MetroSetLabel1.Style = MetroSet_UI.Design.Style.Dark
        Me.MetroSetLabel1.StyleManager = Me.StyleManager1
        Me.MetroSetLabel1.TabIndex = 20
        Me.MetroSetLabel1.Text = "MetroSetLabel1"
        Me.MetroSetLabel1.ThemeAuthor = "Narwin"
        Me.MetroSetLabel1.ThemeName = "MetroDark"
        '
        'MetroSetTrackBar1
        '
        Me.MetroSetTrackBar1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.MetroSetTrackBar1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MetroSetTrackBar1.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.MetroSetTrackBar1.DisabledBorderColor = System.Drawing.Color.Empty
        Me.MetroSetTrackBar1.DisabledHandlerColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.MetroSetTrackBar1.DisabledValueColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.MetroSetTrackBar1.HandlerColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.MetroSetTrackBar1.Location = New System.Drawing.Point(427, 468)
        Me.MetroSetTrackBar1.Maximum = 100
        Me.MetroSetTrackBar1.Minimum = 0
        Me.MetroSetTrackBar1.Name = "MetroSetTrackBar1"
        Me.MetroSetTrackBar1.Size = New System.Drawing.Size(189, 16)
        Me.MetroSetTrackBar1.Style = MetroSet_UI.Design.Style.Dark
        Me.MetroSetTrackBar1.StyleManager = Me.StyleManager1
        Me.MetroSetTrackBar1.TabIndex = 21
        Me.MetroSetTrackBar1.Text = "MetroSetTrackBar1"
        Me.MetroSetTrackBar1.ThemeAuthor = "Narwin"
        Me.MetroSetTrackBar1.ThemeName = "MetroDark"
        Me.MetroSetTrackBar1.Value = 0
        Me.MetroSetTrackBar1.ValueColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(225, Byte), Integer))
        '
        'OpenFileDialog2
        '
        Me.OpenFileDialog2.FileName = "OpenFileDialog2"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 539)
        Me.Controls.Add(Me.MetroSetTrackBar1)
        Me.Controls.Add(Me.MetroSetLabel1)
        Me.Controls.Add(Me.MetroSetButton1)
        Me.Controls.Add(Me.MetroSetProgressBar1)
        Me.Controls.Add(Me.pn_haupt)
        Me.Controls.Add(Me.MetroSetLabel2)
        Me.Controls.Add(Me.MetroSetControlBox1)
        Me.Controls.Add(Me.btn_add_to_list)
        Me.Controls.Add(Me.MetroSetBadge1)
        Me.Controls.Add(Me.txb_Input_Link)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Style = MetroSet_UI.Design.Style.Dark
        Me.StyleManager = Me.StyleManager1
        Me.Text = "Youtube Download Manager"
        Me.TextColor = System.Drawing.Color.White
        Me.ThemeName = "MetroDark"
        Me.TransparencyKey = System.Drawing.Color.Aqua
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents StyleManager1 As MetroSet_UI.StyleManager
    Friend WithEvents btn_add_to_list As MetroSet_UI.Controls.MetroSetEllipse
    Friend WithEvents MetroSetBadge1 As MetroSet_UI.Controls.MetroSetBadge
    Friend WithEvents txb_Input_Link As MetroSet_UI.Controls.MetroSetTextBox
    Friend WithEvents MetroSetControlBox1 As MetroSet_UI.Controls.MetroSetControlBox
    Friend WithEvents MetroSetLabel2 As MetroSet_UI.Controls.MetroSetLabel
    Friend WithEvents pn_haupt As MetroSet_UI.Controls.MetroSetPanel
    Friend WithEvents MetroSetProgressBar1 As MetroSet_UI.Controls.MetroSetProgressBar
    Friend WithEvents MetroSetTrackBar1 As MetroSet_UI.Controls.MetroSetTrackBar
    Friend WithEvents MetroSetLabel1 As MetroSet_UI.Controls.MetroSetLabel
    Friend WithEvents MetroSetButton1 As MetroSet_UI.Controls.MetroSetButton
    Friend WithEvents OpenFileDialog2 As OpenFileDialog
End Class
