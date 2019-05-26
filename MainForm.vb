'
' Created by SharpDevelop.
' User: IP-Man
' Date: 10/31/2017
' Time: 8:48 AM
' 
Imports System.IO.Path
Public Partial Class MainForm
	Public Sub New()
		' The Me.InitializeComponent call is required for Windows Forms designer support.
		Me.InitializeComponent()
		
		'
		' TODO : Add constructor code after InitializeComponents
		'
	End Sub
	
	Sub Select_btnClick(sender As Object, e As EventArgs)
		input_dialog.ShowDialog()
		If Not (String.IsNullOrEmpty(input_dialog.FileName)) Then
			input_txt.Text=input_dialog.FileName
			SetOutputPathText(input_txt.Text)
		End If
	End Sub
	
	Sub Setoutput_btnClick(sender As Object, e As EventArgs)
		output_dialog.ShowDialog()
		If String.IsNullOrEmpty(output_dialog.FileName) Then
			MsgBox("Output file name can't be empty.",vbExclamation,"error")
		Else
			output_txt.Text=output_dialog.FileName
		End If	
	End Sub
	
	'Auto generate output path
	Sub SetOutputPathText(input_path As String)
		output_txt.Text=GetDirectoryName(input_path) & "\converted_" & (GetFileName(input_path)).Replace(GetExtension(input_path),".mp4")
		output_dialog.FileName="converted_" & (GetFileName(input_path)).Replace(GetExtension(input_path),".mp4")
	End Sub
	
	Sub MainFormLoad(sender As Object, e As EventArgs)
		Call Assigner() 'Assign variables
		'Default options
		preset_combo.SelectedIndex=5
		aencoder_combo.SelectedIndex=2
		amixdown_combo.SelectedIndex=1
		'Disable maximize
		Me.MaximumSize = New Size (Me.Width,Me.Height)
		Me.MinimumSize  = me.MaximumSize 
		me.maximizebox = false
		Me.minimizebox = False
		encoderpath="bin\encoder_cli.exe"
	End Sub
	
	Sub Vidquality_txtTextChanged(sender As Object, e As EventArgs)
		vidquality_txt.Text=(Decimal.Parse(vidquality_txt.Text)).ToString("N1")
	End Sub
	
	Sub Start_btnClick(sender As Object, e As EventArgs)		
		If DoValidate=True Then
			Call MakeCode() 'in Generator.vb
			If runcmd_check.Checked=False Then
				StartEncoding() 'start encoder.exe
				tabControl.SelectedIndex=3
				stop_btn.Visible=True
				stop_btn.Enabled=True
				EnableDisable(False)
				If advan_check.Checked=False Then
					tabControl.Enabled=True	
				End If
			Else
				Shell(encoderpath & code)
			End If
		Else
			MsgBox("Inputs are missing!",vbExclamation,"error")
		End If
	End Sub
	
	Sub Stop_btnClick(sender As Object, e As EventArgs)
		If IsProcessRunning("encoder_cli.exe") Then
			Process.GetProcessesByName("encoder_cli")(0).Kill()
			MsgBox("Operation Cancelled!",vbInformation,"Sorry")
			EnableDisable(True)
			stop_btn.Visible=False
			stop_btn.Enabled=False
			If runcmd_check.Checked=False Then
				outputbox.Items.Clear()
				tabControl.SelectedIndex=0
				customcode=0
			End If
			If advan_check.Checked=False Then
				tabControl.Enabled=False	
			End If
		End If
	End Sub
	
	Sub EnableDisable(st As Boolean)
		start_btn.Enabled=st
		input_txt.Enabled=st
		output_txt.Enabled=st
		select_btn.Enabled=st
		setoutput_btn.Enabled=st
	End Sub
	
	#Region "Encoding and CLI output redirection"
	Delegate Sub UpdateProgressBoxDelg(ByVal text As String)
	Public myDelegate As UpdateProgressBoxDelg = New UpdateProgressBoxDelg(AddressOf UpdateProgressBox)
	
	Public Sub UpdateProgressBox(ByVal text As String) 
		outputbox.Items.Add(text)
		outputbox.SelectedIndex=outputbox.Items.Count-1
	End Sub
	
	Public Sub proc_OutputDataReceived(ByVal sender As Object, ByVal e As DataReceivedEventArgs)
		On Error Resume Next
		If Me.InvokeRequired = True Then
			Me.Invoke(myDelegate, e.Data)
		Else
			UpdateProgressBox(e.Data)
		End If
		
	End Sub
	
	Private Sub StartEncoding()
		Dim Proc = New Process()
		Proc.StartInfo.FileName = encoderpath
		Proc.StartInfo.Arguments = code
		Proc.StartInfo.RedirectStandardOutput = True
		Proc.StartInfo.RedirectStandardError = True
		Proc.EnableRaisingEvents = True
		Application.DoEvents()
		Proc.StartInfo.CreateNoWindow = True
		Proc.StartInfo.UseShellExecute = False
		AddHandler Proc.ErrorDataReceived, AddressOf proc_OutputDataReceived
		AddHandler Proc.OutputDataReceived, AddressOf proc_OutputDataReceived
		Proc.Start()
		Proc.BeginErrorReadLine()
		Proc.BeginOutputReadLine()
		'Proc.WaitForExit()
	End Sub 
	
	'Check handbrake cli is running in the background
	Function IsProcessRunning(ByVal process As String)
		Dim objList As Object
		objList = GetObject("winmgmts:") _
			.ExecQuery("select * from win32_process where name='" & process & "'")
		
		If objList.Count > 0 Then
			IsProcessRunning = True
		Else
			
			IsProcessRunning = False
		End If
	End Function
	#End Region
	
	'Check encoding is completed
	Sub OutputboxSelectedIndexChanged(sender As Object, e As EventArgs)
		If outputbox.SelectedItem.ToString.Contains("HandBrake has exited.") Then
			stop_btn.Visible=False
			stop_btn.Enabled=False
			EnableDisable(True)
			MsgBox("The operation completed successfully!",vbInformation,"Done!")
			tabControl.SelectedIndex=0
			customcode=0
			outputbox.Items.Clear()
			If advan_check.Checked=False Then
				tabControl.Enabled=False	
			End If
		End If
	End Sub
	
	Sub AboutToolStripMenuItemClick(sender As Object, e As EventArgs)
		MsgBox("Developed By Navinda Pramod Dissanayake" & vbNewLine & "Website : www.navinda.xyz" & vbNewLine & "E-Mail : navilk@zoho.com" & vbNewLine & vbNewLine & "Handbrake CLI version : 1.2.2",vbOKOnly,"About")
	End Sub
	
	Sub Advan_checkCheckedChanged(sender As Object, e As EventArgs)
		If advan_check.Checked=True Then
			tabControl.Enabled=True
		Else
			tabControl.Enabled=False
		End If
	End Sub
	
	'Drag files
	Sub SkinDragEnter(sender As Object, e As DragEventArgs)
		If (e.Data.GetDataPresent(DataFormats.FileDrop)) Then
			e.Effect = DragDropEffects.Move
		Else
			e.Effect = DragDropEffects.None
		End If
	End Sub
	
	'Drag and drop files
	Sub SkinDragDrop(sender As Object, e As DragEventArgs)
		Dim drop_input() As String = e.Data.GetData(DataFormats.FileDrop)
		Dim drop_file_path As String = GetFullPath(drop_input(0))
		input_txt.Text=drop_file_path
		SetOutputPathText(drop_file_path)
	End Sub
	
	Sub TabPage4Enter(sender As Object, e As EventArgs)
		If DoValidate=True Then
			If customcode=0 Then Call MakeCode()
			settings_txt.Text=code
		Else
			MsgBox("Please select input & output paths!",vbExclamation,"error")
			tabControl.SelectedIndex=0
		End If
	End Sub
	
	Sub Settings_txtKeyPress(sender As Object, e As KeyPressEventArgs)
		code=settings_txt.Text
		customsettings_check.Checked=True
	End Sub
	
	Sub Customsettings_checkCheckedChanged(sender As Object, e As EventArgs)
		If customsettings_check.Checked=True Then
			customcode=1
		Else
			customcode=0
		End If
	End Sub
	
	Sub ReportBugsToolStripMenuItemClick(sender As Object, e As EventArgs)
		Process.Start("https://sourceforge.net/p/vid2old/tickets/?source=navbar")
	End Sub
	
	Sub SkinClick(sender As Object, e As EventArgs)
		
	End Sub
	
	Sub PictureBox1Click(sender As Object, e As EventArgs)
		Process.Start("https://www.patreon.com/ipmanlk")
	End Sub
End Class
