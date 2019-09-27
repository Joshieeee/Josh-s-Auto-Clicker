Imports System.Runtime.InteropServices
Public Class frmSettings
    Public Const WM_NCLBUTTONDOWN As Integer = 161
    Public Const HT_CAPTION As Integer = 2
    <DllImport("User32")> Private Shared Function SendMessage(hWnd As IntPtr, Msg As Integer, wParam As Integer, lParam As Integer) As Integer
    End Function
    <DllImport("User32")> Private Shared Function ReleaseCapture() As Boolean
    End Function
    Private Sub frmSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim i As Integer = 0
        Me.Location = New Point(frmMain.Location.X + frmMain.Width / 2 - Me.Width / 2, frmMain.Location.Y + frmMain.Height / 2 - Me.Height / 2)
        frmMain.Hide()
        Me.Opacity = frmMain.Opacity
        tbHexRange.Value = My.Settings.HexRange
        tbMaxCheckTime.Value = My.Settings.MaxCheckTime
        tbResolution.Value = My.Settings.VerifyResolution
        tbOpacity.Value = frmMain.Opacity * 10
        cbDriveList.Items.Clear()

        For Each drive In System.IO.DriveInfo.GetDrives()
            If drive.DriveType <> IO.DriveType.CDRom Then
                frmMain.DriveList(i) = drive.ToString
                i += 1
                frmMain.DriveCount += 1
                cbDriveList.Items.Add(drive.ToString)
            End If
        Next
        If frmMain.DriveLetter <> "" Then
            cbDriveList.SelectedItem = frmMain.DriveLetter
        End If
        If frmMain.AlwaysOnTopEnabled = True Then
            cboxAlwaysTop.Checked = True
        End If
        If frmMain.ExitCoordsEnabled = True Then
            CBoxExit.Checked = True
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
    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        frmMain.Show()
    End Sub
    Private Sub btnGetExitCoords_Click(sender As Object, e As EventArgs) Handles btnEditExitCoords.Click
        Dim X1, X2, X3, X4, Y1, Y2, Y3, Y4 As Integer
        Me.Hide()
        For PopUp As Integer = 1 To 2
            Select Case PopUp
                Case 1
                    frmMessageBox.lblHeader.Text = "Exit Coords. Set-Up"
                    frmMessageBox.lblMessageText.Text = "Hover mouse over one corner of clickable area of 'X' to exit game && press Enter."
                    If frmMessageBox.ShowDialog() = DialogResult.OK Then
                        If frmMain.GetAsyncKeyState(Keys.Return) <> 0 Then
                            frmMain.GetCursorPos(frmMain.MousePoint)
                            X1 = frmMain.MousePoint.X
                            Y1 = frmMain.MousePoint.Y
                        End If
                    ElseIf frmMessageBox.DialogResult = DialogResult.Cancel Then
                        Me.Show()
                        Exit Sub
                    End If
                Case 2
                    frmMessageBox.lblHeader.Text = "Exit Coords. Set-Up"
                    frmMessageBox.lblMessageText.Text = "Hover mouse over opposite corner of clickable area of 'X' to exit game && press Enter."
                    If frmMessageBox.ShowDialog() = DialogResult.OK Then
                        If frmMain.GetAsyncKeyState(Keys.Return) <> 0 Then
                            frmMain.GetCursorPos(frmMain.MousePoint)
                            X2 = frmMain.MousePoint.X
                            Y2 = frmMain.MousePoint.Y
                        End If
                    ElseIf frmMessageBox.DialogResult = DialogResult.Cancel Then
                        Me.Show()
                        Exit Sub
                    End If
            End Select
        Next
        frmMessageBox.lblHeader.Text = "Exit Coords. Set-Up"
        frmMessageBox.lblMessageText.Text = "Click on the 'X' to exit the game && click OK."
        frmMessageBox.ShowDialog()
        For PopUp As Integer = 1 To 2
            Select Case PopUp
                Case 1
                    frmMessageBox.lblHeader.Text = "Exit Coords. Set-Up"
                    frmMessageBox.lblMessageText.Text = "Hover mouse over one corner of 'OK' game button to exit game && press Enter."
                    If frmMessageBox.ShowDialog() = DialogResult.OK Then
                        If frmMain.GetAsyncKeyState(Keys.Return) <> 0 Then
                            frmMain.GetCursorPos(frmMain.MousePoint)
                            X3 = frmMain.MousePoint.X
                            Y3 = frmMain.MousePoint.Y
                        End If
                    ElseIf frmMessageBox.DialogResult = DialogResult.Cancel Then
                        Me.Show()
                        Exit Sub
                    End If
                Case 2
                    frmMessageBox.lblHeader.Text = "Exit Coords. Set-Up"
                    frmMessageBox.lblMessageText.Text = "Hover mouse over opposite corner of 'OK' game button to exit game && press Enter."
                    If frmMessageBox.ShowDialog() = DialogResult.OK Then
                        If frmMain.GetAsyncKeyState(Keys.Return) <> 0 Then
                            frmMain.GetCursorPos(frmMain.MousePoint)
                            X4 = frmMain.MousePoint.X
                            Y4 = frmMain.MousePoint.Y
                        End If
                    ElseIf frmMessageBox.DialogResult = DialogResult.Cancel Then
                        Me.Show()
                        Exit Sub
                    End If
            End Select
        Next
        My.Settings.ExitScreenXL1 = Math.Min(X1, X2)
        My.Settings.ExitScreenXR1 = Math.Max(X1, X2)
        My.Settings.ExitScreenYU1 = Math.Min(Y1, Y2)
        My.Settings.ExitScreenYD1 = Math.Max(Y1, Y2)
        My.Settings.ExitScreenXL2 = Math.Min(X3, X4)
        My.Settings.ExitScreenXR2 = Math.Max(X3, X4)
        My.Settings.ExitScreenYU2 = Math.Min(Y3, Y4)
        My.Settings.ExitScreenYD2 = Math.Max(Y3, Y4)
        Me.Show()
    End Sub
    Private Sub cbAlwaysTop_CheckedChanged(sender As Object, e As EventArgs) Handles cboxAlwaysTop.CheckedChanged
        If cboxAlwaysTop.Checked = True Then
            frmMain.TopMost = True
            frmMain.AlwaysOnTopEnabled = True
        Else
            frmMain.TopMost = False
            frmMain.AlwaysOnTopEnabled = False
        End If
    End Sub
    Private Sub cbDriveList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbDriveList.SelectedIndexChanged
        frmMain.txtEventLog.Text = "Active Drive Letter: " & "'" & cbDriveList.SelectedItem & "'"
        frmMain.DriveLetter = cbDriveList.SelectedItem
        My.Settings.ActiveDrive = cbDriveList.SelectedItem
        My.Settings.Save()
        If (Not System.IO.Directory.Exists(frmMain.DriveLetter & "RSAutoClicker")) Then
            System.IO.Directory.CreateDirectory(frmMain.DriveLetter & "RSAutoClicker")
        End If
        lblOpacity.Focus()
        frmMain.cmbLoadProgram.Items.Clear()
        For Each Folder In My.Computer.FileSystem.GetDirectories(My.Settings.ActiveDrive & "RSAutoClicker")
            Folder = Mid(Folder, 18)
            If frmMain.cmbLoadProgram.Items.Contains(Folder) = False Then
                frmMain.cmbLoadProgram.Items.Add(Folder)
            End If
        Next
    End Sub
    Private Sub CBoxExit_CheckedChanged(sender As Object, e As EventArgs) Handles CBoxExit.CheckedChanged
        If CBoxExit.Checked = True Then
            If My.Settings.ExitScreenXR2 <> 0 Then
                frmMain.ExitCoordsEnabled = True
            Else
                btnEditExitCoords.PerformClick()
            End If
        ElseIf CBoxExit.Checked = False Then
            frmMain.ExitCoordsEnabled = False
        End If
    End Sub
    Private Sub tbOpacity_Scroll(sender As Object, e As EventArgs)
        Me.Opacity = tbOpacity.Value / 10
        frmMain.Opacity = tbOpacity.Value / 10
        frmSetUp.Opacity = tbOpacity.Value / 10
        frmMessageBox.Opacity = tbOpacity.Value / 10
        frmInputBox.Opacity = tbOpacity.Value / 10
    End Sub
    Private Sub btnVerifyScreen_Click(sender As Object, e As EventArgs) Handles btnEditVerifyScreen.Click
        Dim X1, X2, Y1, Y2 As Integer
        Me.Hide()
        For PopUp As Integer = 1 To 2
            Select Case PopUp
                Case 1
                    frmMessageBox.lblHeader.Text = "Verify Screen Set-Up"
                    frmMessageBox.lblMessageText.Text = "Hover mouse over one corner of Game Screen && press Enter."
                    If frmMessageBox.ShowDialog() = DialogResult.OK Then
                        If frmMain.GetAsyncKeyState(Keys.Return) <> 0 Then
                            frmMain.GetCursorPos(frmMain.MousePoint)
                            X1 = frmMain.MousePoint.X
                            Y1 = frmMain.MousePoint.Y
                        End If
                    ElseIf frmMessageBox.DialogResult = DialogResult.Cancel Then
                        Me.Show()
                        Exit Sub
                    End If
                Case 2
                    frmMessageBox.lblHeader.Text = "Verify Screen Set-Up"
                    frmMessageBox.lblMessageText.Text = "Hover mouse over the opposite corner of Game Screen && press Enter."
                    If frmMessageBox.ShowDialog() = DialogResult.OK Then
                        If frmMain.GetAsyncKeyState(Keys.Return) <> 0 Then
                            frmMain.GetCursorPos(frmMain.MousePoint)
                            X2 = frmMain.MousePoint.X
                            Y2 = frmMain.MousePoint.Y
                        End If
                    ElseIf frmMessageBox.DialogResult = DialogResult.Cancel Then
                        Me.Show()
                        Exit Sub
                    End If
            End Select
        Next
        My.Settings.VerifyScreenXL = Math.Min(X1, X2)
        My.Settings.VerifyScreenXR = Math.Max(X1, X2)
        My.Settings.VerifyScreenYU = Math.Min(Y1, Y2)
        My.Settings.VerifyScreenYD = Math.Max(Y1, Y2)
        My.Settings.Save()
        Me.Show()
    End Sub
    Private Sub btnEditInvDropCoords_Click(sender As Object, e As EventArgs) Handles btnInvCoords.Click
        Dim X1, X2, Y1, Y2 As Integer
        Me.Hide()
        For PopUp As Integer = 1 To 2
            Select Case PopUp
                Case 1
                    frmMessageBox.lblHeader.Text = "Inventory Set-Up"
                    frmMessageBox.lblMessageText.Text = "Hover mouse over one corner of Inventory Tab && press Enter."
                    If frmMessageBox.ShowDialog() = DialogResult.OK Then
                        If frmMain.GetAsyncKeyState(Keys.Return) <> 0 Then
                            frmMain.GetCursorPos(frmMain.MousePoint)
                            X1 = frmMain.MousePoint.X
                            Y1 = frmMain.MousePoint.Y
                        End If
                    ElseIf frmMessageBox.DialogResult = DialogResult.Cancel Then
                        Me.Show()
                        Exit Sub
                    End If
                Case 2
                    frmMessageBox.lblHeader.Text = "Inventory Set-Up"
                    frmMessageBox.lblMessageText.Text = "Hover mouse over opposite corner of Inventory Tab && press Enter."
                    If frmMessageBox.ShowDialog() = DialogResult.OK Then
                        If frmMain.GetAsyncKeyState(Keys.Return) <> 0 Then
                            frmMain.GetCursorPos(frmMain.MousePoint)
                            X2 = frmMain.MousePoint.X
                            Y2 = frmMain.MousePoint.Y
                        End If
                    ElseIf frmMessageBox.DialogResult = DialogResult.Cancel Then
                        Me.Show()
                        Exit Sub
                    End If
            End Select
        Next
        My.Settings.InventoryXL = Math.Min(X1, X2)
        My.Settings.InventoryXR = Math.Max(X1, X2)
        My.Settings.InventoryYU = Math.Min(Y1, Y2)
        My.Settings.InventoryYD = Math.Max(Y1, Y2)
        My.Settings.Save()
        Me.Show()
    End Sub
    Private Sub btnInvDropSlots_Click(sender As Object, e As EventArgs) Handles btnInvDropSlots.Click
        If frmMain.DriveLetter <> "" Then
            frmInventorySlots.Show()
        Else
            frmMessageBox.lblHeader.Text = "Inventory Set-Up"
            frmMessageBox.lblMessageText.Text = "No Drive Selected!"
            frmMessageBox.ShowDialog()
        End If

    End Sub
    Private Sub tbMaxCheckTime_Scroll(sender As Object, e As EventArgs)
        My.Settings.MaxCheckTime = tbMaxCheckTime.Value
        My.Settings.Save()
    End Sub
    Private Sub tbResolution_Scroll(sender As Object, e As EventArgs) Handles tbResolution.Scroll
        My.Settings.VerifyResolution = tbResolution.Value
        My.Settings.Save()
    End Sub
    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs)
        My.Settings.HexRange = tbHexRange.Value
        My.Settings.Save()
    End Sub
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        frmMain.Show()
        Me.Close()
        Exit Sub
    End Sub
    Private Sub tbOpacity_Scroll_1(sender As Object, e As EventArgs) Handles tbOpacity.Scroll
        Me.Opacity = tbOpacity.Value * 0.1
        frmMain.Opacity = tbOpacity.Value * 0.1
        frmSetUp.Opacity = tbOpacity.Value * 0.1
        frmInputBox.Opacity = tbOpacity.Value * 0.1
        frmMessageBox.Opacity = tbOpacity.Value * 0.1
        frmInventorySlots.Opacity = tbOpacity.Value * 0.1
    End Sub
    Private Sub tbMaxCheckTime_Scroll_1(sender As Object, e As EventArgs) Handles tbMaxCheckTime.Scroll
        My.Settings.MaxCheckTime = tbMaxCheckTime.Value
        My.Settings.Save()
    End Sub
    Private Sub tbHexRange_Scroll(sender As Object, e As EventArgs) Handles tbHexRange.Scroll
        My.Settings.HexRange = tbHexRange.Value
        My.Settings.Save()
    End Sub
    Private Sub btnEditHeal_Click(sender As Object, e As EventArgs) Handles btnHealItems.Click
        If frmMain.DriveLetter <> "" Then
            frmHealing.Show()
        Else
            frmMessageBox.lblHeader.Text = "Healing Set-Up"
            frmMessageBox.lblMessageText.Text = "No Drive Selected!"
            frmMessageBox.ShowDialog()
        End If
    End Sub
    Private Sub btnHealItemCoords_Click(sender As Object, e As EventArgs) Handles btnHealItemCoords.Click
        Me.Hide()
        frmMessageBox.lblHeader.Text = "Healing Set-Up"
        frmMessageBox.lblMessageText.Text = "Hover mouse over Health threshhold && press Enter."
        If frmMessageBox.ShowDialog() = DialogResult.OK Then
            If frmMain.GetAsyncKeyState(Keys.Return) <> 0 Then
                frmMain.GetCursorPos(frmMain.MousePoint)
                My.Settings.HealTriggerX = frmMain.MousePoint.X
                My.Settings.HealTriggerY = frmMain.MousePoint.Y
            End If
        ElseIf frmMessageBox.DialogResult = DialogResult.Cancel Then
            Me.Show()
            Exit Sub
        End If
        My.Settings.Save()
        Me.Show()
    End Sub
    Private Sub btnEditPrayer_Click(sender As Object, e As EventArgs) Handles btnPrayerItems.Click
        If frmMain.DriveLetter <> "" Then
            frmPrayer.Show()
        Else
            frmMessageBox.lblHeader.Text = "Prayer Set-Up"
            frmMessageBox.lblMessageText.Text = "No Drive Selected!"
            frmMessageBox.ShowDialog()
        End If
    End Sub
    Private Sub btnPrayerCoords_Click(sender As Object, e As EventArgs) Handles btnPrayerCoords.Click
        Me.Hide()
        frmMessageBox.lblHeader.Text = "Prayer Coords Set-Up"
        frmMessageBox.lblMessageText.Text = "Hover mouse over Prayer threshhold && press Enter."
        If frmMessageBox.ShowDialog() = DialogResult.OK Then
            If frmMain.GetAsyncKeyState(Keys.Return) <> 0 Then
                frmMain.GetCursorPos(frmMain.MousePoint)
                My.Settings.PrayerTriggerX = frmMain.MousePoint.X
                My.Settings.PrayerTriggerY = frmMain.MousePoint.Y
            End If
        ElseIf frmMessageBox.DialogResult = DialogResult.Cancel Then
            Me.Show()
            Exit Sub
        End If
        My.Settings.Save()
        Me.Show()
    End Sub
End Class