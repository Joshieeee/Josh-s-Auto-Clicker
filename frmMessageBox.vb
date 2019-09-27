Imports System.Runtime.InteropServices
Public Class frmMessageBox
    Dim MsgSender As String
    Public Const WM_NCLBUTTONDOWN As Integer = 161
    Public Const HT_CAPTION As Integer = 2
    <DllImport("User32")> Private Shared Function SendMessage(hWnd As IntPtr, Msg As Integer, wParam As Integer, lParam As Integer) As Integer
    End Function
    <DllImport("User32")> Private Shared Function ReleaseCapture() As Boolean
    End Function
    Private Sub frmMessageBox_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnMessageOK.Select()
        If Application.OpenForms().OfType(Of frmSetUp).Any Then
            Me.Location = New Point(frmSetUp.Location.X + frmSetUp.Width / 2 - Me.Width / 2, frmSetUp.Location.Y + frmSetUp.Height / 2 - Me.Height / 2)
        ElseIf Application.OpenForms().OfType(Of frmSettings).Any Then
            Me.Location = New Point(frmSettings.Location.X + frmSettings.Width / 2 - Me.Width / 2, frmSettings.Location.Y + frmSettings.Height / 2 - Me.Height / 2)
        ElseIf Application.OpenForms().OfType(Of frmMain).Any Then
            Me.Location = New Point(frmMain.Location.X + frmMain.Width / 2 - Me.Width / 2, frmMain.Location.Y + frmMain.Height / 2 - Me.Height / 2)
        End If
    End Sub
    Private Sub pnlHeader_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pnlHeader.MouseDown
        If (e.Button = MouseButtons.Left) Then
            ReleaseCapture()
            SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0)
        End If
    End Sub
    Private Sub lblHeader_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lblHeader.MouseDown
        If (e.Button = MouseButtons.Left) Then
            ReleaseCapture()
            SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0)
        End If
    End Sub
    Private Sub btnMessageOK_Click(sender As Object, e As EventArgs) Handles btnMessageOK.Click
    End Sub
    Private Sub btnMessageCancel_Click(sender As Object, e As EventArgs) Handles btnMessageCancel.Click
    End Sub
End Class