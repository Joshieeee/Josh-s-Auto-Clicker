Imports System.IO
Imports System.Runtime.InteropServices
Public Class frmInputBox
    Public Const WM_NCLBUTTONDOWN As Integer = 161
    Public Const HT_CAPTION As Integer = 2
    <DllImport("User32")> Private Shared Function SendMessage(hWnd As IntPtr, Msg As Integer, wParam As Integer, lParam As Integer) As Integer
    End Function
    <DllImport("User32")> Private Shared Function ReleaseCapture() As Boolean
    End Function
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
    Private Sub frmInputBox_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Location = New Point(Me.Location.X, Me.Location.Y + 40)
        txtInputEntry.Clear()
        btnInputOK.Enabled = False
        txtInputEntry.Select()
    End Sub
    Private Sub txtDialogInput_TextChanged(sender As Object, e As EventArgs) Handles txtInputEntry.TextChanged
        ValidateInfo()
    End Sub
    Private Sub txtDialogInput_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtInputEntry.KeyPress
        If btnInputOK.Enabled = True And frmMain.GetAsyncKeyState(Keys.Return) <> 0 Then
            btnInputOK.PerformClick()
        End If
    End Sub
    Sub ValidateInfo()
        If lblHeader.Text = "Program Set-Up" Then
            If Integer.TryParse(txtInputEntry.Text, 1) = False And txtInputEntry.Text <> "" Then
                txtInputEntry.ForeColor = Color.Red
                btnInputOK.Enabled = False
            Else
                If txtInputEntry.Text <> "" Then
                    If txtInputEntry.Text > 0 Then
                        txtInputEntry.ForeColor = Color.Black
                        btnInputOK.Enabled = True
                    Else
                        txtInputEntry.ForeColor = Color.Red
                        btnInputOK.Enabled = False
                    End If
                End If
            End If
        ElseIf lblHeader.Text = "New Program Set-Up" Then
            If txtInputEntry.Text <> "" Then
                If FilenameIsOK(txtInputEntry.Text) = False Or txtInputEntry.Text.Contains("<") Or txtInputEntry.Text.Contains(">") Or
                    txtInputEntry.Text.Contains(":") Or txtInputEntry.Text.Contains("/") Or txtInputEntry.Text.Contains("\") Or txtInputEntry.Text.Contains("|") Or
                    txtInputEntry.Text.Contains("?") Or txtInputEntry.Text.Contains("*") Then
                    txtInputEntry.ForeColor = Color.Red
                    btnInputOK.Enabled = False
                Else
                    txtInputEntry.ForeColor = Color.Black
                    btnInputOK.Enabled = True
                End If
            End If
        ElseIf lblHeader.text = "Update Game Timer" Then
            If txtInputEntry.Text.Length = 7 Then
                If Integer.TryParse(txtInputEntry.Text.Substring(0, 1), 1) = False Or txtInputEntry.Text.Substring(1, 1) <> ":" Or
                Integer.TryParse(txtInputEntry.Text.Substring(2, 1), 1) = False Or Integer.TryParse(txtInputEntry.Text.Substring(3, 1), 1) = False Or
                txtInputEntry.Text.Substring(4, 1) <> ":" Or Integer.TryParse(txtInputEntry.Text.Substring(5, 1), 1) = False Or
                Integer.TryParse(txtInputEntry.Text.Substring(6, 1), 1) = False Then
                    txtInputEntry.ForeColor = Color.Red
                    btnInputOK.Enabled = False
                Else
                    txtInputEntry.ForeColor = Color.Black
                    btnInputOK.Enabled = True
                End If
            Else
                txtInputEntry.ForeColor = Color.Red
                btnInputOK.Enabled = False
            End If
        End If
    End Sub
    Public Shared Function FilenameIsOK(ByVal fileName As String) As Boolean
        Try
            Dim file As String = Path.GetFileName(fileName)
            Dim directory As String = Path.GetDirectoryName(fileName)
            Return Not (file.Intersect(Path.GetInvalidFileNameChars()).Any() _
                        OrElse
                        directory.Intersect(Path.GetInvalidPathChars()).Any())
        Catch ex As Exception
            Return False
        End Try
    End Function

    Private Sub lblInputText_Click(sender As Object, e As EventArgs) Handles lblInputText.Click

    End Sub
End Class