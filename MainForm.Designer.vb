'
' Created by SharpDevelop.
' User: IP-Man
' Date: 10/31/2017
' Time: 8:48 AM
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Partial Class MainForm
	Inherits System.Windows.Forms.Form
	
	''' <summary>
	''' Designer variable used to keep track of non-visual components.
	''' </summary>
	Private components As System.ComponentModel.IContainer
	
	''' <summary>
	''' Disposes resources used by the form.
	''' </summary>
	''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		If disposing Then
			If components IsNot Nothing Then
				components.Dispose()
			End If
		End If
		MyBase.Dispose(disposing)
	End Sub
	
	''' <summary>
	''' This method is required for Windows Forms designer support.
	''' Do not change the method contents inside the source code editor. The Forms designer might
	''' not be able to load this method if it was changed manually.
	''' </summary>
	Private Sub InitializeComponent()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
		Me.skin = New H._65_to_H._64_Converter.ValleyTheme()
		Me.Close = New H._65_to_H._64_Converter.ValleyClose()
		Me.Mini = New H._65_to_H._64_Converter.ValleyMini()
		Me.Max = New H._65_to_H._64_Converter.ValleyMax()
		Me.MainGroup = New System.Windows.Forms.GroupBox()
		Me.pictureBox1 = New System.Windows.Forms.PictureBox()
		Me.advan_check = New System.Windows.Forms.CheckBox()
		Me.menuStrip1 = New System.Windows.Forms.MenuStrip()
		Me.aboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.reportBugsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.groupBox4 = New System.Windows.Forms.GroupBox()
		Me.tabControl = New System.Windows.Forms.TabControl()
		Me.tabPage2 = New System.Windows.Forms.TabPage()
		Me.twopass_check = New System.Windows.Forms.CheckBox()
		Me.preset_combo = New System.Windows.Forms.ComboBox()
		Me.label4 = New System.Windows.Forms.Label()
		Me.vidquality_txt = New System.Windows.Forms.TextBox()
		Me.width_txt = New System.Windows.Forms.TextBox()
		Me.height_txt = New System.Windows.Forms.TextBox()
		Me.label3 = New System.Windows.Forms.Label()
		Me.ratio_check = New System.Windows.Forms.CheckBox()
		Me.label2 = New System.Windows.Forms.Label()
		Me.label1 = New System.Windows.Forms.Label()
		Me.tabPage3 = New System.Windows.Forms.TabPage()
		Me.aencoder_combo = New System.Windows.Forms.ComboBox()
		Me.amixdown_combo = New System.Windows.Forms.ComboBox()
		Me.abitrate_txt = New System.Windows.Forms.TextBox()
		Me.label5 = New System.Windows.Forms.Label()
		Me.label6 = New System.Windows.Forms.Label()
		Me.label7 = New System.Windows.Forms.Label()
		Me.tabPage4 = New System.Windows.Forms.TabPage()
		Me.customsettings_check = New System.Windows.Forms.CheckBox()
		Me.settings_txt = New System.Windows.Forms.TextBox()
		Me.runcmd_check = New System.Windows.Forms.CheckBox()
		Me.label9 = New System.Windows.Forms.Label()
		Me.tabPage1 = New System.Windows.Forms.TabPage()
		Me.outputbox = New System.Windows.Forms.ListBox()
		Me.setoutput_btn = New H._65_to_H._64_Converter.ValleyButton()
		Me.stop_btn = New H._65_to_H._64_Converter.ValleyButton()
		Me.start_btn = New H._65_to_H._64_Converter.ValleyButton()
		Me.groupBox3 = New System.Windows.Forms.GroupBox()
		Me.output_txt = New System.Windows.Forms.TextBox()
		Me.groupBox2 = New System.Windows.Forms.GroupBox()
		Me.input_txt = New System.Windows.Forms.TextBox()
		Me.select_btn = New H._65_to_H._64_Converter.ValleyButton()
		Me.input_dialog = New System.Windows.Forms.OpenFileDialog()
		Me.output_dialog = New System.Windows.Forms.SaveFileDialog()
		Me.skin.SuspendLayout
		Me.MainGroup.SuspendLayout
		CType(Me.pictureBox1,System.ComponentModel.ISupportInitialize).BeginInit
		Me.menuStrip1.SuspendLayout
		Me.groupBox4.SuspendLayout
		Me.tabControl.SuspendLayout
		Me.tabPage2.SuspendLayout
		Me.tabPage3.SuspendLayout
		Me.tabPage4.SuspendLayout
		Me.tabPage1.SuspendLayout
		Me.groupBox3.SuspendLayout
		Me.groupBox2.SuspendLayout
		Me.SuspendLayout
		'
		'skin
		'
		Me.skin.AllowDrop = true
		Me.skin.BackColor = System.Drawing.Color.FromArgb(CType(CType(242,Byte),Integer), CType(CType(242,Byte),Integer), CType(CType(242,Byte),Integer))
		Me.skin.Controls.Add(Me.Close)
		Me.skin.Controls.Add(Me.Mini)
		Me.skin.Controls.Add(Me.Max)
		Me.skin.Controls.Add(Me.MainGroup)
		Me.skin.Dock = System.Windows.Forms.DockStyle.Fill
		Me.skin.Font = New System.Drawing.Font("Segoe UI", 9!)
		Me.skin.Location = New System.Drawing.Point(0, 0)
		Me.skin.Name = "skin"
		Me.skin.Size = New System.Drawing.Size(510, 490)
		Me.skin.TabIndex = 0
		AddHandler Me.skin.Click, AddressOf Me.SkinClick
		AddHandler Me.skin.DragDrop, AddressOf Me.SkinDragDrop
		AddHandler Me.skin.DragEnter, AddressOf Me.SkinDragEnter
		'
		'Close
		'
		Me.Close.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
		Me.Close.Location = New System.Drawing.Point(486, 5)
		Me.Close.Name = "Close"
		Me.Close.Size = New System.Drawing.Size(16, 16)
		Me.Close.TabIndex = 3
		Me.Close.Text = "valleyClose1"
		'
		'Mini
		'
		Me.Mini.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
		Me.Mini.Location = New System.Drawing.Point(442, 5)
		Me.Mini.Name = "Mini"
		Me.Mini.Size = New System.Drawing.Size(16, 16)
		Me.Mini.TabIndex = 2
		Me.Mini.Text = "valleyMini1"
		'
		'Max
		'
		Me.Max.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
		Me.Max.Enabled = false
		Me.Max.Location = New System.Drawing.Point(464, 5)
		Me.Max.Name = "Max"
		Me.Max.Size = New System.Drawing.Size(16, 16)
		Me.Max.TabIndex = 1
		Me.Max.Text = "valleyMax1"
		'
		'MainGroup
		'
		Me.MainGroup.Controls.Add(Me.pictureBox1)
		Me.MainGroup.Controls.Add(Me.advan_check)
		Me.MainGroup.Controls.Add(Me.menuStrip1)
		Me.MainGroup.Controls.Add(Me.groupBox4)
		Me.MainGroup.Controls.Add(Me.setoutput_btn)
		Me.MainGroup.Controls.Add(Me.stop_btn)
		Me.MainGroup.Controls.Add(Me.start_btn)
		Me.MainGroup.Controls.Add(Me.groupBox3)
		Me.MainGroup.Controls.Add(Me.groupBox2)
		Me.MainGroup.Controls.Add(Me.select_btn)
		Me.MainGroup.Location = New System.Drawing.Point(20, 40)
		Me.MainGroup.Name = "MainGroup"
		Me.MainGroup.Size = New System.Drawing.Size(472, 430)
		Me.MainGroup.TabIndex = 0
		Me.MainGroup.TabStop = false
		'
		'pictureBox1
		'
		Me.pictureBox1.Image = CType(resources.GetObject("pictureBox1.Image"),System.Drawing.Image)
		Me.pictureBox1.Location = New System.Drawing.Point(366, 10)
		Me.pictureBox1.Name = "pictureBox1"
		Me.pictureBox1.Size = New System.Drawing.Size(104, 58)
		Me.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
		Me.pictureBox1.TabIndex = 10
		Me.pictureBox1.TabStop = false
		AddHandler Me.pictureBox1.Click, AddressOf Me.PictureBox1Click
		'
		'advan_check
		'
		Me.advan_check.BackColor = System.Drawing.Color.Transparent
		Me.advan_check.Location = New System.Drawing.Point(15, 303)
		Me.advan_check.Name = "advan_check"
		Me.advan_check.Size = New System.Drawing.Size(114, 24)
		Me.advan_check.TabIndex = 9
		Me.advan_check.Text = "Advanced Mode"
		Me.advan_check.UseVisualStyleBackColor = false
		AddHandler Me.advan_check.CheckedChanged, AddressOf Me.Advan_checkCheckedChanged
		'
		'menuStrip1
		'
		Me.menuStrip1.Dock = System.Windows.Forms.DockStyle.Bottom
		Me.menuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.aboutToolStripMenuItem, Me.reportBugsToolStripMenuItem})
		Me.menuStrip1.Location = New System.Drawing.Point(3, 403)
		Me.menuStrip1.Name = "menuStrip1"
		Me.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
		Me.menuStrip1.Size = New System.Drawing.Size(466, 24)
		Me.menuStrip1.TabIndex = 4
		Me.menuStrip1.Text = "menuStrip1"
		'
		'aboutToolStripMenuItem
		'
		Me.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem"
		Me.aboutToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
		Me.aboutToolStripMenuItem.Text = "About"
		AddHandler Me.aboutToolStripMenuItem.Click, AddressOf Me.AboutToolStripMenuItemClick
		'
		'reportBugsToolStripMenuItem
		'
		Me.reportBugsToolStripMenuItem.Name = "reportBugsToolStripMenuItem"
		Me.reportBugsToolStripMenuItem.Size = New System.Drawing.Size(83, 20)
		Me.reportBugsToolStripMenuItem.Text = "Report Bugs"
		AddHandler Me.reportBugsToolStripMenuItem.Click, AddressOf Me.ReportBugsToolStripMenuItemClick
		'
		'groupBox4
		'
		Me.groupBox4.Controls.Add(Me.tabControl)
		Me.groupBox4.Location = New System.Drawing.Point(15, 123)
		Me.groupBox4.Name = "groupBox4"
		Me.groupBox4.Size = New System.Drawing.Size(440, 169)
		Me.groupBox4.TabIndex = 8
		Me.groupBox4.TabStop = false
		'
		'tabControl
		'
		Me.tabControl.Controls.Add(Me.tabPage2)
		Me.tabControl.Controls.Add(Me.tabPage3)
		Me.tabControl.Controls.Add(Me.tabPage4)
		Me.tabControl.Controls.Add(Me.tabPage1)
		Me.tabControl.Dock = System.Windows.Forms.DockStyle.Fill
		Me.tabControl.Enabled = false
		Me.tabControl.ItemSize = New System.Drawing.Size(20, 20)
		Me.tabControl.Location = New System.Drawing.Point(3, 19)
		Me.tabControl.Name = "tabControl"
		Me.tabControl.SelectedIndex = 0
		Me.tabControl.Size = New System.Drawing.Size(434, 147)
		Me.tabControl.TabIndex = 5
		'
		'tabPage2
		'
		Me.tabPage2.Controls.Add(Me.twopass_check)
		Me.tabPage2.Controls.Add(Me.preset_combo)
		Me.tabPage2.Controls.Add(Me.label4)
		Me.tabPage2.Controls.Add(Me.vidquality_txt)
		Me.tabPage2.Controls.Add(Me.width_txt)
		Me.tabPage2.Controls.Add(Me.height_txt)
		Me.tabPage2.Controls.Add(Me.label3)
		Me.tabPage2.Controls.Add(Me.ratio_check)
		Me.tabPage2.Controls.Add(Me.label2)
		Me.tabPage2.Controls.Add(Me.label1)
		Me.tabPage2.Location = New System.Drawing.Point(4, 24)
		Me.tabPage2.Name = "tabPage2"
		Me.tabPage2.Padding = New System.Windows.Forms.Padding(3)
		Me.tabPage2.Size = New System.Drawing.Size(426, 119)
		Me.tabPage2.TabIndex = 1
		Me.tabPage2.Text = "Video Settings"
		Me.tabPage2.UseVisualStyleBackColor = true
		'
		'twopass_check
		'
		Me.twopass_check.Location = New System.Drawing.Point(229, 85)
		Me.twopass_check.Name = "twopass_check"
		Me.twopass_check.Size = New System.Drawing.Size(172, 24)
		Me.twopass_check.TabIndex = 9
		Me.twopass_check.Text = "Two Pass"
		Me.twopass_check.UseVisualStyleBackColor = true
		'
		'preset_combo
		'
		Me.preset_combo.FormattingEnabled = true
		Me.preset_combo.Items.AddRange(New Object() {"Ultrafast", "Super Fast", "Very Fast", "Faster", "Fast", "Medium", "Slow", "Slower", "Very Slow", "Placebo"})
		Me.preset_combo.Location = New System.Drawing.Point(305, 48)
		Me.preset_combo.Name = "preset_combo"
		Me.preset_combo.Size = New System.Drawing.Size(100, 23)
		Me.preset_combo.TabIndex = 8
		'
		'label4
		'
		Me.label4.Location = New System.Drawing.Point(229, 51)
		Me.label4.Name = "label4"
		Me.label4.Size = New System.Drawing.Size(71, 23)
		Me.label4.TabIndex = 7
		Me.label4.Text = "x264 Preset : "
		'
		'vidquality_txt
		'
		Me.vidquality_txt.Location = New System.Drawing.Point(305, 18)
		Me.vidquality_txt.Name = "vidquality_txt"
		Me.vidquality_txt.Size = New System.Drawing.Size(100, 23)
		Me.vidquality_txt.TabIndex = 6
		Me.vidquality_txt.Text = "23.0"
		AddHandler Me.vidquality_txt.TextChanged, AddressOf Me.Vidquality_txtTextChanged
		'
		'width_txt
		'
		Me.width_txt.Location = New System.Drawing.Point(62, 48)
		Me.width_txt.Name = "width_txt"
		Me.width_txt.Size = New System.Drawing.Size(100, 23)
		Me.width_txt.TabIndex = 3
		Me.width_txt.Text = "original"
		'
		'height_txt
		'
		Me.height_txt.Location = New System.Drawing.Point(62, 18)
		Me.height_txt.Name = "height_txt"
		Me.height_txt.Size = New System.Drawing.Size(100, 23)
		Me.height_txt.TabIndex = 2
		Me.height_txt.Text = "original"
		'
		'label3
		'
		Me.label3.Location = New System.Drawing.Point(229, 21)
		Me.label3.Name = "label3"
		Me.label3.Size = New System.Drawing.Size(71, 23)
		Me.label3.TabIndex = 5
		Me.label3.Text = "Quality :"
		'
		'ratio_check
		'
		Me.ratio_check.Location = New System.Drawing.Point(15, 85)
		Me.ratio_check.Name = "ratio_check"
		Me.ratio_check.Size = New System.Drawing.Size(172, 24)
		Me.ratio_check.TabIndex = 4
		Me.ratio_check.Text = "Keep Original Aspect Ratio"
		Me.ratio_check.UseVisualStyleBackColor = true
		'
		'label2
		'
		Me.label2.Location = New System.Drawing.Point(11, 51)
		Me.label2.Name = "label2"
		Me.label2.Size = New System.Drawing.Size(51, 23)
		Me.label2.TabIndex = 1
		Me.label2.Text = "Width : "
		'
		'label1
		'
		Me.label1.Location = New System.Drawing.Point(11, 21)
		Me.label1.Name = "label1"
		Me.label1.Size = New System.Drawing.Size(51, 23)
		Me.label1.TabIndex = 0
		Me.label1.Text = "Height : "
		'
		'tabPage3
		'
		Me.tabPage3.Controls.Add(Me.aencoder_combo)
		Me.tabPage3.Controls.Add(Me.amixdown_combo)
		Me.tabPage3.Controls.Add(Me.abitrate_txt)
		Me.tabPage3.Controls.Add(Me.label5)
		Me.tabPage3.Controls.Add(Me.label6)
		Me.tabPage3.Controls.Add(Me.label7)
		Me.tabPage3.Location = New System.Drawing.Point(4, 24)
		Me.tabPage3.Name = "tabPage3"
		Me.tabPage3.Padding = New System.Windows.Forms.Padding(3)
		Me.tabPage3.Size = New System.Drawing.Size(426, 119)
		Me.tabPage3.TabIndex = 2
		Me.tabPage3.Text = "Audio Settings"
		Me.tabPage3.UseVisualStyleBackColor = true
		'
		'aencoder_combo
		'
		Me.aencoder_combo.FormattingEnabled = true
		Me.aencoder_combo.Items.AddRange(New Object() {"none", "av_aac", "ca_aac", "ca_haac", "copy:aac", "ac3", "copy:ac3", "eac3", "copy:eac3", "copy:truehd", "copy:dts", "copy:dtshd", "mp3", "copy:mp3", "vorbis", "flac16", "flac24", "copy:flac", "opus", "copy"})
		Me.aencoder_combo.Location = New System.Drawing.Point(75, 18)
		Me.aencoder_combo.Name = "aencoder_combo"
		Me.aencoder_combo.Size = New System.Drawing.Size(100, 23)
		Me.aencoder_combo.TabIndex = 14
		'
		'amixdown_combo
		'
		Me.amixdown_combo.FormattingEnabled = true
		Me.amixdown_combo.Items.AddRange(New Object() {"none", "mono", "left_only", "right_only", "stereo", "dpl1", "dpl2", "5point1", "6point1", "7point1", "5_2_lfe"})
		Me.amixdown_combo.Location = New System.Drawing.Point(75, 60)
		Me.amixdown_combo.Name = "amixdown_combo"
		Me.amixdown_combo.Size = New System.Drawing.Size(100, 23)
		Me.amixdown_combo.TabIndex = 13
		'
		'abitrate_txt
		'
		Me.abitrate_txt.Location = New System.Drawing.Point(307, 18)
		Me.abitrate_txt.Name = "abitrate_txt"
		Me.abitrate_txt.Size = New System.Drawing.Size(100, 23)
		Me.abitrate_txt.TabIndex = 12
		Me.abitrate_txt.Text = "320"
		'
		'label5
		'
		Me.label5.Location = New System.Drawing.Point(260, 21)
		Me.label5.Name = "label5"
		Me.label5.Size = New System.Drawing.Size(71, 20)
		Me.label5.TabIndex = 11
		Me.label5.Text = "Bitrate : "
		'
		'label6
		'
		Me.label6.Location = New System.Drawing.Point(11, 63)
		Me.label6.Name = "label6"
		Me.label6.Size = New System.Drawing.Size(62, 23)
		Me.label6.TabIndex = 8
		Me.label6.Text = "Mixdown : "
		'
		'label7
		'
		Me.label7.Location = New System.Drawing.Point(11, 21)
		Me.label7.Name = "label7"
		Me.label7.Size = New System.Drawing.Size(62, 23)
		Me.label7.TabIndex = 7
		Me.label7.Text = "Encoder : "
		'
		'tabPage4
		'
		Me.tabPage4.Controls.Add(Me.customsettings_check)
		Me.tabPage4.Controls.Add(Me.settings_txt)
		Me.tabPage4.Controls.Add(Me.runcmd_check)
		Me.tabPage4.Controls.Add(Me.label9)
		Me.tabPage4.Location = New System.Drawing.Point(4, 24)
		Me.tabPage4.Name = "tabPage4"
		Me.tabPage4.Padding = New System.Windows.Forms.Padding(3)
		Me.tabPage4.Size = New System.Drawing.Size(426, 119)
		Me.tabPage4.TabIndex = 4
		Me.tabPage4.Text = "Expert Settings"
		Me.tabPage4.UseVisualStyleBackColor = true
		AddHandler Me.tabPage4.Enter, AddressOf Me.TabPage4Enter
		'
		'customsettings_check
		'
		Me.customsettings_check.Location = New System.Drawing.Point(123, 10)
		Me.customsettings_check.Name = "customsettings_check"
		Me.customsettings_check.Size = New System.Drawing.Size(151, 24)
		Me.customsettings_check.TabIndex = 4
		Me.customsettings_check.Text = "Use Custom Settings"
		Me.customsettings_check.UseVisualStyleBackColor = true
		AddHandler Me.customsettings_check.CheckedChanged, AddressOf Me.Customsettings_checkCheckedChanged
		'
		'settings_txt
		'
		Me.settings_txt.Location = New System.Drawing.Point(10, 55)
		Me.settings_txt.Multiline = true
		Me.settings_txt.Name = "settings_txt"
		Me.settings_txt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
		Me.settings_txt.Size = New System.Drawing.Size(406, 56)
		Me.settings_txt.TabIndex = 3
		AddHandler Me.settings_txt.KeyPress, AddressOf Me.Settings_txtKeyPress
		'
		'runcmd_check
		'
		Me.runcmd_check.Location = New System.Drawing.Point(10, 10)
		Me.runcmd_check.Name = "runcmd_check"
		Me.runcmd_check.Size = New System.Drawing.Size(104, 24)
		Me.runcmd_check.TabIndex = 2
		Me.runcmd_check.Text = "Run on CMD"
		Me.runcmd_check.UseVisualStyleBackColor = true
		'
		'label9
		'
		Me.label9.Location = New System.Drawing.Point(7, 38)
		Me.label9.Name = "label9"
		Me.label9.Size = New System.Drawing.Size(155, 23)
		Me.label9.TabIndex = 1
		Me.label9.Text = "Settings (for encoder.exe) : "
		'
		'tabPage1
		'
		Me.tabPage1.Controls.Add(Me.outputbox)
		Me.tabPage1.Location = New System.Drawing.Point(4, 24)
		Me.tabPage1.Name = "tabPage1"
		Me.tabPage1.Padding = New System.Windows.Forms.Padding(3)
		Me.tabPage1.Size = New System.Drawing.Size(426, 119)
		Me.tabPage1.TabIndex = 3
		Me.tabPage1.Text = "Progress"
		Me.tabPage1.UseVisualStyleBackColor = true
		'
		'outputbox
		'
		Me.outputbox.Dock = System.Windows.Forms.DockStyle.Fill
		Me.outputbox.FormattingEnabled = true
		Me.outputbox.ItemHeight = 15
		Me.outputbox.Location = New System.Drawing.Point(3, 3)
		Me.outputbox.Name = "outputbox"
		Me.outputbox.Size = New System.Drawing.Size(420, 113)
		Me.outputbox.TabIndex = 8
		AddHandler Me.outputbox.SelectedIndexChanged, AddressOf Me.OutputboxSelectedIndexChanged
		'
		'setoutput_btn
		'
		Me.setoutput_btn.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.setoutput_btn.Location = New System.Drawing.Point(172, 22)
		Me.setoutput_btn.Name = "setoutput_btn"
		Me.setoutput_btn.Size = New System.Drawing.Size(151, 32)
		Me.setoutput_btn.TabIndex = 4
		Me.setoutput_btn.Text = "Set Output Path"
		AddHandler Me.setoutput_btn.Click, AddressOf Me.Setoutput_btnClick
		'
		'stop_btn
		'
		Me.stop_btn.Enabled = false
		Me.stop_btn.Font = New System.Drawing.Font("Segoe UI", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.stop_btn.Location = New System.Drawing.Point(292, 301)
		Me.stop_btn.Name = "stop_btn"
		Me.stop_btn.Size = New System.Drawing.Size(163, 37)
		Me.stop_btn.TabIndex = 7
		Me.stop_btn.Text = "Stop Converting"
		Me.stop_btn.Visible = false
		AddHandler Me.stop_btn.Click, AddressOf Me.Stop_btnClick
		'
		'start_btn
		'
		Me.start_btn.Font = New System.Drawing.Font("Segoe UI", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.start_btn.Location = New System.Drawing.Point(292, 301)
		Me.start_btn.Name = "start_btn"
		Me.start_btn.Size = New System.Drawing.Size(163, 37)
		Me.start_btn.TabIndex = 1
		Me.start_btn.Text = "Start Converting"
		AddHandler Me.start_btn.Click, AddressOf Me.Start_btnClick
		'
		'groupBox3
		'
		Me.groupBox3.Controls.Add(Me.output_txt)
		Me.groupBox3.Location = New System.Drawing.Point(15, 338)
		Me.groupBox3.Name = "groupBox3"
		Me.groupBox3.Size = New System.Drawing.Size(440, 59)
		Me.groupBox3.TabIndex = 3
		Me.groupBox3.TabStop = false
		Me.groupBox3.Text = "Output"
		'
		'output_txt
		'
		Me.output_txt.Location = New System.Drawing.Point(9, 22)
		Me.output_txt.Name = "output_txt"
		Me.output_txt.Size = New System.Drawing.Size(422, 23)
		Me.output_txt.TabIndex = 0
		'
		'groupBox2
		'
		Me.groupBox2.Controls.Add(Me.input_txt)
		Me.groupBox2.Location = New System.Drawing.Point(15, 63)
		Me.groupBox2.Name = "groupBox2"
		Me.groupBox2.Size = New System.Drawing.Size(440, 60)
		Me.groupBox2.TabIndex = 2
		Me.groupBox2.TabStop = false
		Me.groupBox2.Text = "Source"
		'
		'input_txt
		'
		Me.input_txt.Location = New System.Drawing.Point(9, 22)
		Me.input_txt.Name = "input_txt"
		Me.input_txt.Size = New System.Drawing.Size(422, 23)
		Me.input_txt.TabIndex = 0
		'
		'select_btn
		'
		Me.select_btn.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.select_btn.Location = New System.Drawing.Point(15, 22)
		Me.select_btn.Name = "select_btn"
		Me.select_btn.Size = New System.Drawing.Size(151, 32)
		Me.select_btn.TabIndex = 0
		Me.select_btn.Text = "Select File"
		AddHandler Me.select_btn.Click, AddressOf Me.Select_btnClick
		'
		'MainForm
		'
		Me.AllowDrop = true
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(510, 490)
		Me.Controls.Add(Me.skin)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
		Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
		Me.MainMenuStrip = Me.menuStrip1
		Me.Name = "MainForm"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Vid2Old - 0.4.0-beta"
		Me.TransparencyKey = System.Drawing.Color.Fuchsia
		AddHandler Load, AddressOf Me.MainFormLoad
		Me.skin.ResumeLayout(false)
		Me.MainGroup.ResumeLayout(false)
		Me.MainGroup.PerformLayout
		CType(Me.pictureBox1,System.ComponentModel.ISupportInitialize).EndInit
		Me.menuStrip1.ResumeLayout(false)
		Me.menuStrip1.PerformLayout
		Me.groupBox4.ResumeLayout(false)
		Me.tabControl.ResumeLayout(false)
		Me.tabPage2.ResumeLayout(false)
		Me.tabPage2.PerformLayout
		Me.tabPage3.ResumeLayout(false)
		Me.tabPage3.PerformLayout
		Me.tabPage4.ResumeLayout(false)
		Me.tabPage4.PerformLayout
		Me.tabPage1.ResumeLayout(false)
		Me.groupBox3.ResumeLayout(false)
		Me.groupBox3.PerformLayout
		Me.groupBox2.ResumeLayout(false)
		Me.groupBox2.PerformLayout
		Me.ResumeLayout(false)
	End Sub
	Private pictureBox1 As System.Windows.Forms.PictureBox
	Private reportBugsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private customsettings_check As System.Windows.Forms.CheckBox
	Private label9 As System.Windows.Forms.Label
	Private runcmd_check As System.Windows.Forms.CheckBox
	Private settings_txt As System.Windows.Forms.TextBox
	Private tabPage4 As System.Windows.Forms.TabPage
	Private advan_check As System.Windows.Forms.CheckBox
	Private aboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private menuStrip1 As System.Windows.Forms.MenuStrip
	Private groupBox4 As System.Windows.Forms.GroupBox
	Private tabPage1 As System.Windows.Forms.TabPage
	Private outputbox As System.Windows.Forms.ListBox
	Private stop_btn As H._65_to_H._64_Converter.ValleyButton
	Friend aencoder_combo As System.Windows.Forms.ComboBox
	Friend twopass_check As System.Windows.Forms.CheckBox
	Private output_dialog As System.Windows.Forms.SaveFileDialog
	Private input_dialog As System.Windows.Forms.OpenFileDialog
	Private Max As H._65_to_H._64_Converter.ValleyMax
	Private Mini As H._65_to_H._64_Converter.ValleyMini
	Private Close As H._65_to_H._64_Converter.ValleyClose
	Private label7 As System.Windows.Forms.Label
	Private label6 As System.Windows.Forms.Label
	Private label5 As System.Windows.Forms.Label
	Friend abitrate_txt As System.Windows.Forms.TextBox
	Friend amixdown_combo As System.Windows.Forms.ComboBox
	Private label3 As System.Windows.Forms.Label
	Friend vidquality_txt As System.Windows.Forms.TextBox
	Private label4 As System.Windows.Forms.Label
	Friend preset_combo As System.Windows.Forms.ComboBox
	Private label1 As System.Windows.Forms.Label
	Private label2 As System.Windows.Forms.Label
	Friend height_txt As System.Windows.Forms.TextBox
	Friend width_txt As System.Windows.Forms.TextBox
	Friend ratio_check As System.Windows.Forms.CheckBox
	Private tabPage3 As System.Windows.Forms.TabPage
	Private tabPage2 As System.Windows.Forms.TabPage
	Friend tabControl As System.Windows.Forms.TabControl
	Friend input_txt As System.Windows.Forms.TextBox
	Private groupBox2 As System.Windows.Forms.GroupBox
	Friend output_txt As System.Windows.Forms.TextBox
	Private groupBox3 As System.Windows.Forms.GroupBox
	Private setoutput_btn As H._65_to_H._64_Converter.ValleyButton
	Private start_btn As H._65_to_H._64_Converter.ValleyButton
	Private select_btn As H._65_to_H._64_Converter.ValleyButton
	Private MainGroup As System.Windows.Forms.GroupBox
	Private skin As H._65_to_H._64_Converter.ValleyTheme
End Class
