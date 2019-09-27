Imports System.Runtime.InteropServices
Public Class frmInventorySlots
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
    Private Sub frmInventorySlots_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Location = New Point(frmSettings.Location.X + frmSettings.Width + 10, frmSettings.Location.Y + frmSettings.Height / 2 - Me.Height / 2)
        frmSettings.Enabled = False
    End Sub
    Private Sub btnSaveInventory_Click(sender As Object, e As EventArgs) Handles btnSaveInventory.Click
        Dim File As System.IO.StreamWriter
        Dim InventoryArray(27) As String
        For Each Ctrl As Control In Me.Controls
            If TypeOf Ctrl Is CheckBox Then
                If DirectCast(Ctrl, CheckBox).CheckState = CheckState.Checked Then
                    InventoryArray(Ctrl.TabIndex) = "True"
                Else
                    InventoryArray(Ctrl.TabIndex) = "False"
                End If
            End If
        Next
        If System.IO.File.Exists(frmMain.DriveLetter & "RSAutoClicker\Inventory.csv") = True Then
            My.Computer.FileSystem.DeleteFile(frmMain.DriveLetter & "RSAutoClicker\Inventory.csv")
        End If
        File = My.Computer.FileSystem.OpenTextFileWriter(frmMain.DriveLetter & "RSAutoClicker\Inventory.csv", True)
        For i = 0 To 27
            File.WriteLine(InventoryArray(i))
        Next
        File.Close()
        If Application.OpenForms().OfType(Of frmSetUp).Any Then
            frmSetUp.Show()
        Else
            frmSettings.Show()
        End If
        frmSettings.Enabled = True
        Me.Close()
    End Sub
    Private Sub btnCheckAll_Click(sender As Object, e As EventArgs) Handles btnCheckAll.Click
        For Each Ctrl As Control In Me.Controls
            If TypeOf Ctrl Is CheckBox Then
                DirectCast(Ctrl, CheckBox).Checked = True
            End If
        Next
    End Sub
    Private Sub FrmInventorySlots_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.Closing
        frmSettings.Show()
    End Sub
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        frmSettings.Enabled = True
        Me.Close()
        Exit Sub
    End Sub
End Class