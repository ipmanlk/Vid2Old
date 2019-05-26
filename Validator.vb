'
' Created by SharpDevelop.
' User: IP-Man
' Date: 11/1/2017
' Time: 1:00 PM
' 
Public Module Validator
	Function DoValidate()
		If String.IsNullOrEmpty(MainForm.input_txt.Text) or String.IsNullOrEmpty(MainForm.output_txt.Text)Then
			Return False
		Else
			Return True
		End If
	End Function
End Module
