Public Class Form1
    Private Declare Function apimouse_event Lib "user32.dll" Alias "mouse_event" (ByVal dwFlags As Int32, ByVal dX As Int32, ByVal dY As Int32, ByVal cButtons As Int32, ByVal dwExtraInfo As Int32) As Boolean
    Public Const MOUSEEVENTF_ABSOLUTE = &H8000
    Public Const MOUSEEVENTF_LEFTDOWN = &H2
    Public Const MOUSEEVENTF_LEFTUP = &H4
    Public Const MOUSEEVENTF_MIDDLEDOWN = &H20
    Public Const MOUSEEVENTF_MIDDLEUP = &H40
    Public Const MOUSEEVENTF_MOVE = &H1
    Public Const MOUSEEVENTF_RIGHTDOWN = &H8
    Public Const MOUSEEVENTF_RIGHTUP = &H10
    Public Const MOUSEEVENTF_XDOWN = &H80
    Public Const MOUSEEVENTF_XUP = &H100
    Public Const MOUSEEVENTF_WHEEL = &H800
    Public Const MOUSEEVENTF_HWHEEL = &H1000
    Dim toggle As Integer
    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs)

    End Sub

    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs) Handles TrackBar1.Scroll
        Label3.Text = TrackBar1.Value.ToString





    End Sub

    Private Sub TrackBar2_Scroll(sender As Object, e As EventArgs) Handles TrackBar2.Scroll
        Label4.Text = TrackBar2.Value.ToString

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Timer1.Start()


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Timer1.Stop()


    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Randomize()
        Dim rnd As New Random
        Dim minval As Integer
        Dim maxval As Integer

        minval = 1000 / TrackBar2.Value
        maxval = 1000 / TrackBar1.Value

        Timer1.Interval = rnd.Next(maxval, minval)

        If MouseButtons = MouseButtons.Left Then
            apimouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0)
            apimouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0)
        ElseIf MouseButtons = MouseButtons.Right Then
            apimouse_event(MOUSEEVENTF_RIGHTUP, 0, 0, 0, 0)
            apimouse_event(MOUSEEVENTF_RIGHTDOWN, 0, 0, 0, 0)
        End If
    End Sub








    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Application.Exit()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        WindowState = FormWindowState.Minimized


    End Sub
End Class
