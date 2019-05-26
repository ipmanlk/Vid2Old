'
' Created by SharpDevelop.
' User: IP-Man
' Date: 10/31/2017
' Time: 7:42 PM
' 
Public Module Generator	
	Dim Hinput,Houtput,HVheight,HVwidth,HVquality,HVratio,HVpreset,HAbitrate,HVtwopass,HAencoder,HAmixdown As String 'HA-Default handbrake commands
	Dim Vinput,Voutput,Vheight,Vwidth,Vquality,Vpreset,Abitrate,Vtwopass,Aencoder,Amixdown As String 'User inputs
	Public customcode As Boolean=0 'control code autogeneration when focus on expert tab
	Public code As String=" "
	Public encoderpath As String 
	
	Sub Assigner()
		Hinput=" -i " '-i <string>
		Houtput=" -o " '-o <string>
		HVheight=" -l " '-l <number in pixals>
		HVwidth=" -w " '-w <number in pixals>
		HVquality=" -q " '-q <float> ex:22.0
		HVratio=" --keep-display-aspect "
		HVtwopass=" -2 "
		HVpreset=" --encoder-preset " '--encoder-preset <string>
		HAbitrate=" -B " '-B <number> in kbit/s
		HAencoder=" -E " '-E <string>
		HAmixdown=" -6 " '-6 <string>
	End Sub
	
	Sub MakeCode()
		code=" "
		Vinput=MainForm.input_txt.Text
		Voutput=MainForm.output_txt.Text
		Vheight=MainForm.height_txt.Text
		Vwidth=MainForm.width_txt.Text
		Vquality=MainForm.vidquality_txt.Text
		Vpreset=MainForm.preset_combo.SelectedItem.ToString
		Abitrate=MainForm.abitrate_txt.Text
		Aencoder=MainForm.aencoder_combo.SelectedItem.ToString
		Amixdown=MainForm.amixdown_combo.SelectedItem.ToString
		
		'Set input and output
		code=code & Hinput & """" & Vinput & """" & Houtput & """" & Voutput & """"
		'Enable two pass
		If MainForm.twopass_check.Checked Then code=code & HVtwopass
		'Height Width
		If Vheight<>"original" And Vwidth<>"original" Then code=code & HVheight & Vheight & HVwidth & Vwidth
		'Video Quality
		code=code & HVquality &	Vquality 
		'Keep aspect ratio
		If MainForm.ratio_check.Checked Then code=code & HVratio
		'Video prest
		code=code & HVpreset & Vpreset
		'Audio bitrate
		code=code & HAbitrate & Abitrate
		'Audio Encoder
		If Aencoder<>"none" Then code=code & HAencoder & Aencoder
		'Audio Mixdown
		If Amixdown<>"none" Then code=code & HAmixdown & Amixdown
	End Sub
End Module
