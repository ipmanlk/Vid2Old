﻿Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.ComponentModel
Imports System.Drawing.Text

''' <summary>
''' Valley Theme
''' Created by Earn
''' from HackForums.net
''' </summary>
''' <remarks></remarks>


#Region "Properties"

#Region " Mouse States"

Enum MouseState As Byte
    None = 0
    Over = 1
    Down = 2
    Block = 3
End Enum

#End Region

#End Region

Class ValleyTheme
    Inherits ContainerControl

#Region "Variables"
    Private Cap As Boolean = False
    Private MousePoint As New Point(0, 0)
    Private MoveHeight = 36
#End Region

#Region "Properties"

    Public WriteOnly Property TransparencyKey As Color
        Set(ByVal value As Color)
            value = Color.Fuchsia
        End Set
    End Property

    Protected Overrides Sub OnCreateControl()
        MyBase.OnCreateControl()
        ParentForm.FormBorderStyle = FormBorderStyle.None
        ParentForm.AllowTransparency = False
        ParentForm.TransparencyKey = Color.Fuchsia
        ParentForm.FindForm.StartPosition = FormStartPosition.CenterScreen
        Dock = DockStyle.Fill
        Invalidate()
    End Sub

    Protected Overrides Sub OnMouseDown(e As MouseEventArgs)
        MyBase.OnMouseDown(e)
        If e.Button = Windows.Forms.MouseButtons.Left And New Rectangle(0, 0, Width, MoveHeight).Contains(e.Location) Then
            Cap = True
            MousePoint = e.Location
        End If
    End Sub


    Protected Overrides Sub OnMouseUp(e As MouseEventArgs)
        MyBase.OnMouseUp(e) : Cap = False
    End Sub

    Protected Overrides Sub OnMouseMove(e As MouseEventArgs)
        MyBase.OnMouseMove(e)
        If Cap Then
            Parent.Location = MousePosition - MousePoint
        End If
    End Sub
#End Region

    Sub New()
        SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.UserPaint Or ControlStyles.ResizeRedraw Or ControlStyles.OptimizedDoubleBuffer, True)
        DoubleBuffered = True
        BackColor = Color.FromArgb(242, 242, 242)
        Font = New Font("Segoe UI", 9)
    End Sub

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        Dim G = e.Graphics

        G.Clear(Color.FromArgb(22, 22, 22))
        G.DrawRectangle(New Pen(Color.FromArgb(38, 38, 38)), New Rectangle(0, 0, Width - 1, Height - 1))
        G.FillRectangle(New LinearGradientBrush(New Point(0, 0), New Point(0, 36), Color.FromArgb(50, 50, 50), Color.FromArgb(47, 47, 47)), New Rectangle(1, 1, Width - 2, 36))
        G.FillRectangle(New LinearGradientBrush(New Point(0, 0), New Point(0, Height), Color.FromArgb(45, 45, 45), Color.FromArgb(23, 23, 23)), New Rectangle(1, 36, Width - 2, Height - 46))

        G.DrawRectangle(New Pen(Color.FromArgb(38, 38, 38)), New Rectangle(9, 35, Width - 19, Height - 45))
        G.FillRectangle(New SolidBrush(BackColor), New Rectangle(10, 36, Width - 20, Height - 46))

        G.FillRectangle(New SolidBrush(Color.FromArgb(47, 47, 47)), New Rectangle(9, 35, 1, 1))
        G.FillRectangle(New SolidBrush(Color.FromArgb(47, 47, 47)), New Rectangle(Width - 10, 35, 1, 1))

        G.FillRectangle(New SolidBrush(Color.Fuchsia), New Rectangle(0, 0, 1, 1))
        G.FillRectangle(New SolidBrush(Color.Fuchsia), New Rectangle(Width - 1, 0, 1, 1))
        G.FillRectangle(New SolidBrush(Color.Fuchsia), New Rectangle(0, Height - 1, 1, 1))
        G.FillRectangle(New SolidBrush(Color.Fuchsia), New Rectangle(Width - 1, Height - 1, 1, 1))

        G.DrawString(FindForm.Text, New Font("Segoe UI", 10), New SolidBrush(Color.FromArgb(242, 242, 242)), New Point(12, 6))
        MyBase.OnPaint(e)
    End Sub
End Class

Class ValleyButton
    Inherits Control

#Region "Variables"
    Private State As MouseState = MouseState.None
#End Region

#Region "Properties"

#Region " Mouse States"

    Protected Overrides Sub OnMouseDown(e As MouseEventArgs)
        MyBase.OnMouseDown(e)
        State = MouseState.Down : Invalidate()
    End Sub
    Protected Overrides Sub OnMouseUp(e As MouseEventArgs)
        MyBase.OnMouseUp(e)
        State = MouseState.Over : Invalidate()
    End Sub
    Protected Overrides Sub OnMouseEnter(e As EventArgs)
        MyBase.OnMouseEnter(e)
        State = MouseState.Over : Invalidate()
    End Sub
    Protected Overrides Sub OnMouseLeave(e As EventArgs)
        MyBase.OnMouseLeave(e)
        State = MouseState.None : Invalidate()
    End Sub

#End Region

#End Region

    Sub New()
        Size = New Size(150, 50)
    End Sub

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        Dim G = e.Graphics

        G.Clear(Color.FromArgb(34, 122, 247))
        G.DrawRectangle(New Pen(Color.FromArgb(42, 59, 252)), New Rectangle(0, 0, Width - 1, Height - 1))

        Select Case State
            Case MouseState.Over
                G.FillRectangle(New SolidBrush(Color.FromArgb(20, Color.White)), New Rectangle(1, 1, Width - 2, Height - 2))
            Case MouseState.Down
                G.FillRectangle(New SolidBrush(Color.FromArgb(20, Color.Black)), New Rectangle(1, 1, Width - 2, Height - 2))
        End Select

        G.FillRectangle(New SolidBrush(BackColor), New Rectangle(0, 0, 1, 1))
        G.FillRectangle(New SolidBrush(Color.FromArgb(134, 144, 253)), New Rectangle(0, 1, 1, 1))
        G.FillRectangle(New SolidBrush(Color.FromArgb(134, 144, 253)), New Rectangle(1, 0, 1, 1))
        G.FillRectangle(New SolidBrush(Color.FromArgb(56, 72, 251)), New Rectangle(0, 2, 1, 1))
        G.FillRectangle(New SolidBrush(Color.FromArgb(56, 72, 251)), New Rectangle(2, 0, 1, 1))
        G.FillRectangle(New SolidBrush(Color.FromArgb(62, 107, 249)), New Rectangle(1, 1, 1, 1))
        G.FillRectangle(New SolidBrush(BackColor), New Rectangle(Width - 1, 0, 1, 1))
        G.FillRectangle(New SolidBrush(Color.FromArgb(134, 144, 253)), New Rectangle(Width - 1, 1, 1, 1))
        G.FillRectangle(New SolidBrush(Color.FromArgb(134, 144, 253)), New Rectangle(Width - 2, 0, 1, 1))
        G.FillRectangle(New SolidBrush(Color.FromArgb(56, 72, 251)), New Rectangle(Width - 1, 2, 1, 1))
        G.FillRectangle(New SolidBrush(Color.FromArgb(56, 72, 251)), New Rectangle(Width - 3, 0, 1, 1))
        G.FillRectangle(New SolidBrush(Color.FromArgb(62, 107, 249)), New Rectangle(Width - 2, 1, 1, 1))
        G.FillRectangle(New SolidBrush(BackColor), New Rectangle(0, Height - 1, 1, 1))
        G.FillRectangle(New SolidBrush(Color.FromArgb(134, 144, 253)), New Rectangle(0, Height - 2, 1, 1))
        G.FillRectangle(New SolidBrush(Color.FromArgb(134, 144, 253)), New Rectangle(1, Height - 1, 1, 1))
        G.FillRectangle(New SolidBrush(Color.FromArgb(56, 72, 251)), New Rectangle(0, Height - 3, 1, 1))
        G.FillRectangle(New SolidBrush(Color.FromArgb(56, 72, 251)), New Rectangle(2, Height - 1, 1, 1))
        G.FillRectangle(New SolidBrush(Color.FromArgb(62, 107, 249)), New Rectangle(1, Height - 2, 1, 1))
        G.FillRectangle(New SolidBrush(BackColor), New Rectangle(Width - 1, Height - 1, 1, 1))
        G.FillRectangle(New SolidBrush(Color.FromArgb(134, 144, 253)), New Rectangle(Width - 1, Height - 2, 1, 1))
        G.FillRectangle(New SolidBrush(Color.FromArgb(134, 144, 253)), New Rectangle(Width - 2, Height - 1, 1, 1))
        G.FillRectangle(New SolidBrush(Color.FromArgb(56, 72, 251)), New Rectangle(Width - 1, Height - 3, 1, 1))
        G.FillRectangle(New SolidBrush(Color.FromArgb(56, 72, 251)), New Rectangle(Width - 3, Height - 1, 1, 1))
        G.FillRectangle(New SolidBrush(Color.FromArgb(62, 107, 249)), New Rectangle(Width - 2, Height - 2, 1, 1))

        G.DrawString(Text, Font, Brushes.White, New Point((Width / 2) - (TextRenderer.MeasureText(Text, Font).Width / 2), (Height / 2) - (TextRenderer.MeasureText(Text, Font).Height / 2)))

        MyBase.OnPaint(e)
    End Sub

End Class

<DefaultEvent("CheckedChanged")>
Class ValleyRadioButton
    Inherits Control

#Region " Variables"

    Private State As MouseState = MouseState.None
    Private W, H As Integer
    Private _Checked As Boolean

#End Region

#Region " Properties"
    Property Checked() As Boolean
        Get
            Return _Checked
        End Get
        Set(value As Boolean)
            _Checked = value
            InvalidateControls()
            RaiseEvent CheckedChanged(Me)
            Invalidate()
        End Set
    End Property
    Event CheckedChanged(ByVal sender As Object)
    Protected Overrides Sub OnClick(e As EventArgs)
        If Not _Checked Then Checked = True
        MyBase.OnClick(e)
    End Sub
    Private Sub InvalidateControls()
        If Not IsHandleCreated OrElse Not _Checked Then Return
        For Each C As Control In Parent.Controls
            If C IsNot Me AndAlso TypeOf C Is ValleyRadioButton Then
                DirectCast(C, ValleyRadioButton).Checked = False
                Invalidate()
            End If
        Next
    End Sub
    Protected Overrides Sub OnCreateControl()
        MyBase.OnCreateControl()
        InvalidateControls()
    End Sub


    Protected Overrides Sub OnResize(e As EventArgs)
        MyBase.OnResize(e)
        Height = 16
    End Sub

#Region " Mouse States"

    Protected Overrides Sub OnMouseDown(e As MouseEventArgs)
        MyBase.OnMouseDown(e)
        State = MouseState.Down : Invalidate()
    End Sub
    Protected Overrides Sub OnMouseUp(e As MouseEventArgs)
        MyBase.OnMouseUp(e)
        State = MouseState.Over : Invalidate()
    End Sub
    Protected Overrides Sub OnMouseEnter(e As EventArgs)
        MyBase.OnMouseEnter(e)
        State = MouseState.Over : Invalidate()
    End Sub
    Protected Overrides Sub OnMouseLeave(e As EventArgs)
        MyBase.OnMouseLeave(e)
        State = MouseState.None : Invalidate()
    End Sub

#End Region
#End Region

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        Dim G = e.Graphics

        G.SmoothingMode = 2
        G.TextRenderingHint = 5
        G.Clear(BackColor)

        G.DrawEllipse(New Pen(Color.FromArgb(191, 191, 191)), New Rectangle(0, 0, 15, 15))

        Select Case State
            Case MouseState.Over
                G.DrawEllipse(New Pen(Color.FromArgb(160, 160, 160)), New Rectangle(0, 0, 15, 15))
        End Select

        If Checked Then
            G.FillEllipse(New SolidBrush(Color.FromArgb(56, 56, 56)), New Rectangle(4, 4, 7, 7))
        End If

        G.DrawString(Text, Font, New SolidBrush(Color.FromArgb(131, 131, 131)), New Point(18, -3))
        MyBase.OnPaint(e)
    End Sub

End Class

<DefaultEvent("CheckedChanged")>
Class ValleyCheckBox
    Inherits Control

#Region "Variables"
    Private W, H As Integer
    Private State As MouseState = MouseState.None
    Private _Checked As Boolean
#End Region

#Region " Properties"
    Protected Overrides Sub OnTextChanged(ByVal e As System.EventArgs)
        MyBase.OnTextChanged(e)
        Invalidate()
    End Sub

    Property Checked() As Boolean
        Get
            Return _Checked
        End Get
        Set(ByVal value As Boolean)
            _Checked = value
            Invalidate()
        End Set
    End Property

    Event CheckedChanged(ByVal sender As Object)
    Protected Overrides Sub OnClick(ByVal e As System.EventArgs)
        _Checked = Not _Checked
        RaiseEvent CheckedChanged(Me)
        MyBase.OnClick(e)
    End Sub

    Protected Overrides Sub OnResize(e As EventArgs)
        MyBase.OnResize(e)
        Height = 16
    End Sub

#End Region

#Region " Mouse States"

    Protected Overrides Sub OnMouseDown(e As MouseEventArgs)
        MyBase.OnMouseDown(e)
        State = MouseState.Down : Invalidate()
    End Sub
    Protected Overrides Sub OnMouseUp(e As MouseEventArgs)
        MyBase.OnMouseUp(e)
        State = MouseState.Over : Invalidate()
    End Sub
    Protected Overrides Sub OnMouseEnter(e As EventArgs)
        MyBase.OnMouseEnter(e)
        State = MouseState.Over : Invalidate()
    End Sub
    Protected Overrides Sub OnMouseLeave(e As EventArgs)
        MyBase.OnMouseLeave(e)
        State = MouseState.None : Invalidate()
    End Sub

#End Region

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        Dim G = e.Graphics
        G.Clear(BackColor)

        G.DrawRectangle(New Pen(Color.FromArgb(192, 192, 192)), New Rectangle(0, 0, 15, 15))

        Select Case State
            Case MouseState.Over
                G.DrawRectangle(New Pen(Color.FromArgb(160, 160, 160)), New Rectangle(0, 0, 15, 15))
        End Select

        If Checked Then
            G.DrawString("ü", New Font("Wingdings", 9), New SolidBrush(Color.FromArgb(56, 56, 56)), New Point(0, 2))
        End If

        G.FillRectangle(New SolidBrush(BackColor), New Rectangle(0, 0, 1, 1))
        G.FillRectangle(New SolidBrush(BackColor), New Rectangle(15, 15, 1, 1))
        G.FillRectangle(New SolidBrush(BackColor), New Rectangle(0, 15, 1, 1))
        G.FillRectangle(New SolidBrush(BackColor), New Rectangle(15, 0, 1, 1))

        G.DrawString(Text, Font, New SolidBrush(Color.FromArgb(131, 131, 131)), New Point(18, -3))

        MyBase.OnPaint(e)
    End Sub
End Class

Class ValleyProgressbar
    Inherits Control

#Region " Variables"

    Private W, H As Integer
    Private _Value As Integer = 0
    Private _Maximum As Integer = 100

#End Region

#Region " Control"
    <Category("Control")>
    Public Property Maximum() As Integer
        Get
            Return _Maximum
        End Get
        Set(V As Integer)
            Select Case V
                Case Is < _Value
                    _Value = V
            End Select
            _Maximum = V
            Invalidate()
        End Set
    End Property

    <Category("Control")>
    Public Property Value() As Integer
        Get
            Select Case _Value
                Case 0
                    Return 0
                    Invalidate()
                Case Else
                    Return _Value
                    Invalidate()
            End Select
        End Get
        Set(V As Integer)
            Select Case V
                Case Is > _Maximum
                    V = _Maximum
                    Invalidate()
            End Select
            _Value = V
            Invalidate()
        End Set
    End Property
#End Region

#Region "Events"
    Protected Overrides Sub OnResize(e As EventArgs)
        MyBase.OnResize(e)
        Height = 25
    End Sub

    Protected Overrides Sub CreateHandle()
        MyBase.CreateHandle()
        Height = 25
    End Sub

    Public Sub Increment(ByVal Amount As Integer)
        Value += Amount
    End Sub
#End Region

    Sub New()
        SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.UserPaint Or _
                 ControlStyles.ResizeRedraw Or ControlStyles.OptimizedDoubleBuffer, True)
        DoubleBuffered = True
    End Sub

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        Dim G = e.Graphics

        G.TextRenderingHint = TextRenderingHint.ClearTypeGridFit
        G.SmoothingMode = SmoothingMode.HighQuality
        G.PixelOffsetMode = PixelOffsetMode.HighQuality
        G.Clear(Color.FromArgb(223, 223, 223))
        Dim ProgVal As Integer = CInt(_Value / _Maximum * Width)
        Select Case Value
            Case 0
                G.FillRectangle(New SolidBrush(Color.FromArgb(223, 223, 223)), New Rectangle(0, 0, Width, Height))
                G.FillRectangle(New SolidBrush(Color.FromArgb(50, 124, 244)), New Rectangle(0, 0, ProgVal - 1, Height))
            Case _Maximum
                G.FillRectangle(New SolidBrush(Color.FromArgb(223, 223, 223)), New Rectangle(0, 0, Width, Height))
                G.FillRectangle(New SolidBrush(Color.FromArgb(50, 124, 244)), New Rectangle(0, 0, ProgVal - 1, Height))
            Case Else
                G.FillRectangle(New SolidBrush(Color.FromArgb(223, 223, 223)), New Rectangle(0, 0, Width, Height))
                G.FillRectangle(New SolidBrush(Color.FromArgb(50, 124, 244)), New Rectangle(0, 0, ProgVal - 1, Height))
        End Select
        G.InterpolationMode = CType(7, InterpolationMode)
        MyBase.OnPaint(e)
    End Sub
End Class

<DefaultEvent("TextChanged")>
Class ValleyTextBox
    Inherits Control

#Region " Variables"

    Private W, H As Integer
    Private State As MouseState = MouseState.None
    Private WithEvents TB As Windows.Forms.TextBox

#End Region

#Region " Properties"

#Region " TextBox Properties"

    Private _TextAlign As HorizontalAlignment = HorizontalAlignment.Left
    <Category("Options")> _
    Property TextAlign() As HorizontalAlignment
        Get
            Return _TextAlign
        End Get
        Set(ByVal value As HorizontalAlignment)
            _TextAlign = value
            If TB IsNot Nothing Then
                TB.TextAlign = value
            End If
        End Set
    End Property
    Private _MaxLength As Integer = 32767
    <Category("Options")> _
    Property MaxLength() As Integer
        Get
            Return _MaxLength
        End Get
        Set(ByVal value As Integer)
            _MaxLength = value
            If TB IsNot Nothing Then
                TB.MaxLength = value
            End If
        End Set
    End Property
    Private _ReadOnly As Boolean
    <Category("Options")> _
    Property [ReadOnly]() As Boolean
        Get
            Return _ReadOnly
        End Get
        Set(ByVal value As Boolean)
            _ReadOnly = value
            If TB IsNot Nothing Then
                TB.ReadOnly = value
            End If
        End Set
    End Property
    Private _UseSystemPasswordChar As Boolean
    <Category("Options")> _
    Property UseSystemPasswordChar() As Boolean
        Get
            Return _UseSystemPasswordChar
        End Get
        Set(ByVal value As Boolean)
            _UseSystemPasswordChar = value
            If TB IsNot Nothing Then
                TB.UseSystemPasswordChar = value
            End If
        End Set
    End Property
    Private _Multiline As Boolean
    <Category("Options")> _
    Property Multiline() As Boolean
        Get
            Return _Multiline
        End Get
        Set(ByVal value As Boolean)
            _Multiline = value
            If TB IsNot Nothing Then
                TB.Multiline = value

                If value Then
                    TB.Height = Height - 11
                Else
                    Height = TB.Height + 11
                End If

            End If
        End Set
    End Property
    <Category("Options")> _
    Overrides Property Text As String
        Get
            Return MyBase.Text
        End Get
        Set(ByVal value As String)
            MyBase.Text = value
            If TB IsNot Nothing Then
                TB.Text = value
            End If
        End Set
    End Property
    <Category("Options")> _
    Overrides Property Font As Font
        Get
            Return MyBase.Font
        End Get
        Set(ByVal value As Font)
            MyBase.Font = value
            If TB IsNot Nothing Then
                TB.Font = value
                TB.Location = New Point(3, 5)
                TB.Width = Width - 6

                If Not _Multiline Then
                    Height = TB.Height + 11
                End If
            End If
        End Set
    End Property

    Protected Overrides Sub OnCreateControl()
        MyBase.OnCreateControl()
        If Not Controls.Contains(TB) Then
            Controls.Add(TB)
        End If
    End Sub
    Private Sub OnBaseTextChanged(ByVal s As Object, ByVal e As EventArgs)
        Text = TB.Text
    End Sub
    Private Sub OnBaseKeyDown(ByVal s As Object, ByVal e As KeyEventArgs)
        If e.Control AndAlso e.KeyCode = Keys.A Then
            TB.SelectAll()
            e.SuppressKeyPress = True
        End If
        If e.Control AndAlso e.KeyCode = Keys.C Then
            TB.Copy()
            e.SuppressKeyPress = True
        End If
    End Sub
    Protected Overrides Sub OnResize(ByVal e As EventArgs)
        TB.Location = New Point(5, 5)
        TB.Width = Width - 10

        If _Multiline Then
            TB.Height = Height - 11
        Else
            Height = TB.Height + 11
        End If

        MyBase.OnResize(e)
    End Sub

#End Region

#Region " Colors"

    <Category("Colors")> _
    Public Property TextColor As Color
        Get
            Return _TextColor
        End Get
        Set(value As Color)
            _TextColor = value
        End Set
    End Property

    Public Overrides Property ForeColor() As Color
        Get
            Return _TextColor
        End Get
        Set(value As Color)
            _TextColor = value
        End Set
    End Property

#End Region

#Region " Mouse States"

    Protected Overrides Sub OnMouseDown(e As MouseEventArgs)
        MyBase.OnMouseDown(e)
        State = MouseState.Down : Invalidate()
    End Sub
    Protected Overrides Sub OnMouseUp(e As MouseEventArgs)
        MyBase.OnMouseUp(e)
        State = MouseState.Over : TB.Focus() : Invalidate()
    End Sub
    Protected Overrides Sub OnMouseEnter(e As EventArgs)
        MyBase.OnMouseEnter(e)
        State = MouseState.Over : TB.Focus() : Invalidate()
    End Sub
    Protected Overrides Sub OnMouseLeave(e As EventArgs)
        MyBase.OnMouseLeave(e)
        State = MouseState.None : Invalidate()
    End Sub

#End Region

#End Region

#Region " Colors"

    Private _BaseColor As Color = BackColor
    Private _TextColor As Color = Color.FromArgb(131, 131, 131)
    Private _BorderColor As Color = Color.FromArgb(191, 191, 191)

#End Region

    Sub New()
        SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.UserPaint Or _
                 ControlStyles.ResizeRedraw Or ControlStyles.OptimizedDoubleBuffer Or _
                 ControlStyles.SupportsTransparentBackColor, True)
        DoubleBuffered = True

        BackColor = Color.Transparent

        TB = New Windows.Forms.TextBox
        TB.Font = Font
        TB.Text = Text
        TB.BackColor = _BaseColor
        TB.ForeColor = _TextColor
        TB.MaxLength = _MaxLength
        TB.Multiline = _Multiline
        TB.ReadOnly = _ReadOnly
        TB.UseSystemPasswordChar = _UseSystemPasswordChar
        TB.BorderStyle = BorderStyle.None
        TB.Location = New Point(5, 5)
        TB.Width = Width - 10

        TB.Cursor = Cursors.IBeam

        If _Multiline Then
            TB.Height = Height - 11
        Else
            Height = TB.Height + 11
        End If

        AddHandler TB.TextChanged, AddressOf OnBaseTextChanged
        AddHandler TB.KeyDown, AddressOf OnBaseKeyDown
    End Sub

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        Dim G = e.Graphics
        G.Clear(Color.FromArgb(242, 242, 242))
        G.DrawRectangle(New Pen(_BorderColor), New Rectangle(0, 0, Width - 1, Height - 1))
        MyBase.OnPaint(e)
    End Sub

End Class

Class ValleyClose
    Inherits Control

#Region " Variables"

    Private State As MouseState = MouseState.None
    Private x As Integer

#End Region

#Region " Properties"

#Region " Mouse States"

    Protected Overrides Sub OnMouseEnter(e As EventArgs)
        MyBase.OnMouseEnter(e)
        State = MouseState.Over : Invalidate()
    End Sub
    Protected Overrides Sub OnMouseDown(e As MouseEventArgs)
        MyBase.OnMouseDown(e)
        State = MouseState.Down : Invalidate()
    End Sub
    Protected Overrides Sub OnMouseLeave(e As EventArgs)
        MyBase.OnMouseLeave(e)
        State = MouseState.None : Invalidate()
    End Sub
    Protected Overrides Sub OnMouseUp(e As MouseEventArgs)
        MyBase.OnMouseUp(e)
        State = MouseState.Over : Invalidate()
    End Sub
    Protected Overrides Sub OnMouseMove(e As MouseEventArgs)
        MyBase.OnMouseMove(e)
        x = e.X : Invalidate()
    End Sub

    Protected Overrides Sub OnClick(e As EventArgs)
        MyBase.OnClick(e)
        Environment.Exit(0)
    End Sub

#End Region

    Protected Overrides Sub OnResize(e As EventArgs)
        MyBase.OnResize(e)
        Size = New Size(16, 16)
    End Sub
#End Region

    Sub New()
        SetStyle(ControlStyles.SupportsTransparentBackColor, True)
        SetStyle(ControlStyles.Opaque, True)
        Anchor = AnchorStyles.Top Or AnchorStyles.Right
    End Sub
    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        Dim G = e.Graphics
        G.Clear(Color.FromArgb(49, 49, 49))
        G.SmoothingMode = SmoothingMode.HighQuality
        G.FillEllipse(New SolidBrush(Color.FromArgb(39, 39, 39)), New Rectangle(0, 0, 15, 15))
        G.FillEllipse(New SolidBrush(Color.FromArgb(254, 97, 82)), New Rectangle(2, 2, 11, 11))

        Select Case State
            Case MouseState.Over
                G.FillEllipse(New SolidBrush(Color.FromArgb(40, Color.White)), New Rectangle(2, 2, 11, 11))
            Case MouseState.Down
                G.FillEllipse(New SolidBrush(Color.FromArgb(40, Color.Black)), New Rectangle(2, 2, 11, 11))

        End Select
        MyBase.OnPaint(e)
    End Sub
End Class

Class ValleyMax
    Inherits Control

#Region " Variables"

    Private State As MouseState = MouseState.None
    Private x As Integer

#End Region

#Region " Properties"

#Region " Mouse States"

    Protected Overrides Sub OnMouseEnter(e As EventArgs)
        MyBase.OnMouseEnter(e)
        State = MouseState.Over : Invalidate()
    End Sub
    Protected Overrides Sub OnMouseDown(e As MouseEventArgs)
        MyBase.OnMouseDown(e)
        State = MouseState.Down : Invalidate()
    End Sub
    Protected Overrides Sub OnMouseLeave(e As EventArgs)
        MyBase.OnMouseLeave(e)
        State = MouseState.None : Invalidate()
    End Sub
    Protected Overrides Sub OnMouseUp(e As MouseEventArgs)
        MyBase.OnMouseUp(e)
        State = MouseState.Over : Invalidate()
    End Sub
    Protected Overrides Sub OnMouseMove(e As MouseEventArgs)
        MyBase.OnMouseMove(e)
        x = e.X : Invalidate()
    End Sub

    Protected Overrides Sub OnClick(e As EventArgs)
        MyBase.OnClick(e)
        Select Case FindForm.WindowState
            Case FormWindowState.Maximized
                FindForm.WindowState = FormWindowState.Normal
            Case FormWindowState.Normal
                FindForm.WindowState = FormWindowState.Maximized
        End Select
    End Sub

#End Region

    Protected Overrides Sub OnResize(e As EventArgs)
        MyBase.OnResize(e)
        Size = New Size(16, 16)
    End Sub
#End Region

    Sub New()
        SetStyle(ControlStyles.SupportsTransparentBackColor, True)
        SetStyle(ControlStyles.Opaque, True)
        Anchor = AnchorStyles.Top Or AnchorStyles.Right
    End Sub
    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        Dim G = e.Graphics
        G.Clear(Color.FromArgb(49, 49, 49))
        G.SmoothingMode = SmoothingMode.HighQuality
        G.FillEllipse(New SolidBrush(Color.FromArgb(39, 39, 39)), New Rectangle(0, 0, 15, 15))
        G.FillEllipse(New SolidBrush(Color.FromArgb(254, 190, 4)), New Rectangle(2, 2, 11, 11))

        Select Case State
            Case MouseState.Over
                G.FillEllipse(New SolidBrush(Color.FromArgb(40, Color.White)), New Rectangle(2, 2, 11, 11))
            Case MouseState.Down
                G.FillEllipse(New SolidBrush(Color.FromArgb(40, Color.Black)), New Rectangle(2, 2, 11, 11))

        End Select
        MyBase.OnPaint(e)
    End Sub
End Class

Class ValleyMini
    Inherits Control

#Region " Variables"

    Private State As MouseState = MouseState.None
    Private x As Integer

#End Region

#Region " Properties"

#Region " Mouse States"

    Protected Overrides Sub OnMouseEnter(e As EventArgs)
        MyBase.OnMouseEnter(e)
        State = MouseState.Over : Invalidate()
    End Sub
    Protected Overrides Sub OnMouseDown(e As MouseEventArgs)
        MyBase.OnMouseDown(e)
        State = MouseState.Down : Invalidate()
    End Sub
    Protected Overrides Sub OnMouseLeave(e As EventArgs)
        MyBase.OnMouseLeave(e)
        State = MouseState.None : Invalidate()
    End Sub
    Protected Overrides Sub OnMouseUp(e As MouseEventArgs)
        MyBase.OnMouseUp(e)
        State = MouseState.Over : Invalidate()
    End Sub
    Protected Overrides Sub OnMouseMove(e As MouseEventArgs)
        MyBase.OnMouseMove(e)
        x = e.X : Invalidate()
    End Sub

    Protected Overrides Sub OnClick(e As EventArgs)
        MyBase.OnClick(e)
        Select Case FindForm.WindowState
            Case FormWindowState.Normal
                FindForm.WindowState = FormWindowState.Minimized
            Case FormWindowState.Maximized
                FindForm.WindowState = FormWindowState.Minimized
        End Select
    End Sub

#End Region

    Protected Overrides Sub OnResize(e As EventArgs)
        MyBase.OnResize(e)
        Size = New Size(16, 16)
    End Sub
#End Region

    Sub New()
        SetStyle(ControlStyles.SupportsTransparentBackColor, True)
        SetStyle(ControlStyles.Opaque, True)
        Anchor = AnchorStyles.Top Or AnchorStyles.Right
    End Sub
    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        Dim G = e.Graphics
        G.Clear(Color.FromArgb(49, 49, 49))
        G.SmoothingMode = SmoothingMode.HighQuality
        G.FillEllipse(New SolidBrush(Color.FromArgb(39, 39, 39)), New Rectangle(0, 0, 15, 15))
        G.FillEllipse(New SolidBrush(Color.FromArgb(23, 205, 58)), New Rectangle(2, 2, 11, 11))

        Select Case State
            Case MouseState.Over
                G.FillEllipse(New SolidBrush(Color.FromArgb(40, Color.White)), New Rectangle(2, 2, 11, 11))
            Case MouseState.Down
                G.FillEllipse(New SolidBrush(Color.FromArgb(40, Color.Black)), New Rectangle(2, 2, 11, 11))

        End Select
        MyBase.OnPaint(e)
    End Sub
End Class