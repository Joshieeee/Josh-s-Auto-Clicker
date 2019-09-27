Imports System.Linq
Imports System.Runtime.InteropServices
Public Class frmSetUp
    'ADD CLICK AFTER SELECTED CLICK NUMBER
    Public Declare Auto Function SetCursorPos Lib "User32.dll" (ByVal X As Integer, ByVal Y As Integer) As Integer
    Public Declare Auto Function GetCursorPos Lib "User32.dll" (ByRef lpPoint As Point) As Integer
    Public Declare Function GetAsyncKeyState Lib "User32.dll" (ByVal vkey As Integer) As Integer
    Public Declare Sub mouse_event Lib "User32" Alias "mouse_event" (ByVal dwFlags As Integer, ByVal dx As Integer, ByVal dy As Integer, ByVal cButtons As Integer, ByVal dwExtraInfo As Integer)
    Public Const WM_NCLBUTTONDOWN As Integer = 161
    Public Const HT_CAPTION As Integer = 2
    <DllImport("User32")> Private Shared Function SendMessage(hWnd As IntPtr, Msg As Integer, wParam As Integer, lParam As Integer) As Integer
    End Function
    <DllImport("User32")> Private Shared Function ReleaseCapture() As Boolean
    End Function
    Public Const KEYEVENTF_KEYDOWN As Integer = &H0
    Public Const KEYEVENTF_KEYUP As Integer = &H2
    Public Const MOUSEEVENTF_LEFTDOWN = &H2
    Public Const MOUSEEVENTF_LEFTUP = &H4
    Public Const MOUSEEVENTF_MIDDLEDOWN = &H20
    Public Const MOUSEEVENTF_MIDDLEUP = &H40
    Public Const MOUSEEVENTF_RIGHTDOWN = &H8
    Public Const MOUSEEVENTF_RIGHTUP = &H10
    Public ButtonClicked As String
    Dim MousePoint As Point
    Dim Exc As Exception
    Dim File As System.IO.StreamWriter
    Public ProgramName As String = ""
    Public NewProgram(20) As String 'WAS 21
    Dim UploadComplete As Boolean
    Dim ClickNumber As Integer
    Dim ClickCount As Integer = 1
    Dim Clicks(ClickCount) As Integer
    Dim HexXLeftStart As Integer
    Dim HexXRightStart As Integer
    Dim HexYUpStart As Integer
    Dim HexYDownStart As Integer
    Dim HexXLeftEnd As Integer
    Dim HexXRightEnd As Integer
    Dim HexYUpEnd As Integer
    Dim HexYDownEnd As Integer
    Dim Bmp As New Bitmap(1, 1)
    Dim G As Graphics = Graphics.FromImage(Bmp)
    Public Shared Sub keybd_event(ByVal bVk As Byte, ByVal bScan As Byte, ByVal dwFlags As UInteger, ByVal dwExtraInfo As UInteger)
    End Sub
    Private Sub frmSetUp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If (Not System.IO.Directory.Exists(frmMain.DriveLetter & "RSAutoClicker")) Then
            System.IO.Directory.CreateDirectory(frmMain.DriveLetter & "RSAutoClicker")
        End If
        cmbClickNmbr.Items.Add(1)
        cmbStartCondition.Items.Add("Auto")
        cmbStartCondition.Items.Add("Time")
        cmbStartCondition.Items.Add("Pixel")
        cmbEndCondition.Items.Add("Time")
        cmbEndCondition.Items.Add("Pixel")
        btnGetHexStart.Visible = False
        btnGetHexEnd.Visible = False
        Dim NameOK As Boolean
        If frmMain.cmbLoadProgram.SelectedItem <> "" And ButtonClicked = "btnEditProgram" Then
            NameOK = True
        End If
        While NameOK = False
            frmInputBox.lblHeader.Text = "New Program Set-Up"
            frmInputBox.lblInputText.Text = "What would you like to call this program?"
            If frmInputBox.ShowDialog() = DialogResult.OK Then
                ProgramName = frmInputBox.txtInputEntry.Text
                If (Not System.IO.Directory.Exists(frmMain.DriveLetter & "RSAutoClicker\" & ProgramName)) Then
                    System.IO.Directory.CreateDirectory(frmMain.DriveLetter & "RSAutoClicker\" & ProgramName)
                    NameOK = True
                    frmMain.Hide()
                Else
                    frmMessageBox.lblHeader.Text = "Invalid Program Name"
                    frmMessageBox.lblMessageText.Text = "Name already taken. Please choose another."
                    frmMessageBox.ShowDialog()
                    ProgramName = ""
                    If frmMessageBox.DialogResult = DialogResult.Cancel Then
                        Exit While
                    ElseIf frmMessageBox.DialogResult = DialogResult.OK Then
                        NameOK = False
                    End If
                End If
            Else
                Exit While
            End If
        End While
        If NameOK = False Then
            Me.Close()
        End If
        btnDeleteClick.Enabled = False
        btnSaveClick.Enabled = False
        btnSaveProgram.Enabled = False
        cmbClickNmbr.SelectedItem = 1
        If System.IO.File.Exists(frmMain.DriveLetter & "RSAutoClicker\" & ProgramName & "\" & ProgramName & ".csv") Then
            UploadInfo()
        Else
            UploadComplete = True
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
    Private Sub cmbStartCondition_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbStartCondition.SelectedIndexChanged
        If UploadComplete = True Then
            txtDelayHexStart.Text = ""
            txtBufferRangeStart.Text = ""
        End If
        If cmbStartCondition.SelectedItem = "Time" Then
            lblDelayHexStart.Text = "Delay (ms)"
            lblBufferRangeStart.Text = "Buffer (ms)"
            txtDelayHexStart.Enabled = True
            txtDelayHexStart.Visible = True
            txtBufferRangeStart.Enabled = True
            txtBufferRangeStart.Visible = True
            btnGetHexStart.Visible = False
        ElseIf cmbStartCondition.SelectedItem = "Pixel" Then
            lblDelayHexStart.Text = "Hex Code"
            lblBufferRangeStart.Text = "Range"
            txtDelayHexStart.Enabled = False
            txtBufferRangeStart.Enabled = False
            If txtBufferRangeStart.Text = "" Then
                txtDelayHexStart.Visible = False
                txtBufferRangeStart.Visible = True
                btnGetHexStart.Visible = True
            Else
                txtDelayHexStart.Visible = True
                txtBufferRangeStart.Visible = True
                btnGetHexStart.Visible = False
            End If
        ElseIf cmbStartCondition.SelectedItem = "Auto" Then
            lblDelayHexStart.Text = "Delay / Hex"
            lblBufferRangeStart.Text = "Buffer / Range"
            txtDelayHexStart.Enabled = False
            txtDelayHexStart.Visible = True
            txtBufferRangeStart.Enabled = False
            txtBufferRangeStart.Visible = True
            btnGetHexStart.Visible = False
        End If
        lblBufferRangeStart.Location = New Point(txtBufferRangeStart.Location.X + txtBufferRangeStart.Width / 2 - lblBufferRangeStart.Width / 2, lblBufferRangeStart.Location.Y)
        lblDelayHexStart.Location = New Point(txtDelayHexStart.Location.X + txtDelayHexStart.Width / 2 - lblDelayHexStart.Width / 2, lblDelayHexStart.Location.Y)
        If UploadComplete = True Then
            ValidateInfo()
        End If
    End Sub
    Private Sub cmbEndCondition_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbEndCondition.SelectedIndexChanged
        If UploadComplete = True Then
            txtDelayHexEnd.Text = ""
            txtBufferRangeEnd.Text = ""
        End If
        If cmbEndCondition.SelectedItem = "Time" Then
            lblDelayHexEnd.Text = "Delay (ms)"
            lblBufferRangeEnd.Text = "Buffer (ms)"
            txtDelayHexEnd.Enabled = True
            txtDelayHexEnd.Visible = True
            txtBufferRangeEnd.Enabled = True
            txtBufferRangeEnd.Visible = True
            btnGetHexEnd.Visible = False
        ElseIf cmbEndCondition.SelectedItem = "Pixel" Then
            lblDelayHexEnd.Text = "Hex Code"
            lblBufferRangeEnd.Text = "Range"
            txtDelayHexEnd.Enabled = False
            txtBufferRangeEnd.Enabled = False
            If txtBufferRangeEnd.Text = "" Then
                txtDelayHexEnd.Visible = False
                txtBufferRangeEnd.Visible = True
                btnGetHexEnd.Visible = True
            Else
                txtDelayHexEnd.Visible = True
                txtBufferRangeEnd.Visible = True
                btnGetHexEnd.Visible = False
            End If
        End If
        lblBufferRangeEnd.Location = New Point(txtBufferRangeEnd.Location.X + txtBufferRangeEnd.Width / 2 - lblBufferRangeEnd.Width / 2, lblBufferRangeEnd.Location.Y)
        lblDelayHexEnd.Location = New Point(txtDelayHexEnd.Location.X + txtDelayHexEnd.Width / 2 - lblDelayHexEnd.Width / 2, lblDelayHexEnd.Location.Y)
        If UploadComplete = True Then
            ValidateInfo()
        End If
    End Sub
    Private Sub btnAddClick_Click(sender As Object, e As EventArgs) Handles btnAddClick.Click
        ClickCount = ClickCount + 1
        Array.Resize(Clicks, ClickCount)
        For i = 0 To ClickCount - 1
            Clicks(i) = i + 1
            cmbClickNmbr.Items.Remove(Clicks(i))
        Next
        For i = 0 To ClickCount - 1
            Clicks(i) = i + 1
            cmbClickNmbr.Items.Add(Clicks(i))
        Next
        If NewProgram.Count < cmbClickNmbr.Items.Count * 21 Then
            Array.Resize(NewProgram, cmbClickNmbr.Items.Count * 21)
        End If
        cmbClickNmbr.SelectedItem() = cmbClickNmbr.Items.Count
        txtXLeft.Clear()
        txtXRight.Clear()
        txtYUp.Clear()
        txtYDown.Clear()
        txtDelayHexStart.Clear()
        txtDelayHexEnd.Clear()
        txtBufferRangeStart.Clear()
        txtBufferRangeEnd.Clear()
        cmbStartCondition.SelectedIndex = -1
        cmbEndCondition.SelectedIndex = -1
        ValidateProgram()
        txtDelayHexStart.Enabled = True
        txtDelayHexEnd.Enabled = True
        txtBufferRangeStart.Enabled = True
        txtBufferRangeEnd.Enabled = True
    End Sub
    Private Sub btnGetClickCoords_Click(sender As Object, e As EventArgs) Handles btnGetClickCoords.Click
        Dim X1, X2, Y1, Y2 As Integer
        Me.Hide()
        For PopUp As Integer = 1 To 2
            Select Case PopUp
                Case 1
                    frmMessageBox.lblHeader.Text = "Coordinate Set-Up"
                    frmMessageBox.lblMessageText.Text = "Hover mouse over one corner of Click Area && press Enter."
                    If frmMessageBox.ShowDialog() = DialogResult.OK Then
                        If GetAsyncKeyState(Keys.Return) <> 0 Then
                            GetCursorPos(MousePoint)
                            X1 = MousePoint.X
                            Y1 = MousePoint.Y
                        End If
                    ElseIf frmMessageBox.DialogResult = DialogResult.Cancel Then
                        Me.Show()
                        Exit Sub
                    End If
                Case 2
                    frmMessageBox.lblHeader.Text = "Coordinate Set-Up"
                    frmMessageBox.lblMessageText.Text = "Hover mouse over the opposite corner of Click Area && press Enter."
                    If frmMessageBox.ShowDialog() = DialogResult.OK Then
                        If GetAsyncKeyState(Keys.Return) <> 0 Then
                            GetCursorPos(MousePoint)
                            X2 = MousePoint.X
                            Y2 = MousePoint.Y
                        End If
                    ElseIf frmMessageBox.DialogResult = DialogResult.Cancel Then
                        Me.Show()
                        Exit Sub
                    End If
            End Select
        Next
        frmMain.delay(50) 'Time required for messagebox to disappear
        Dim Wdt As Integer = 0
        For Each scr As Screen In Screen.AllScreens
            Wdt += scr.Bounds.Width
        Next
        Dim ScreenSizeTotal As Size = New Size(Wdt, My.Computer.Screen.Bounds.Height)
        Dim ScreenGrab1 As New Bitmap(Wdt, My.Computer.Screen.Bounds.Height)
        Dim g As Graphics = Graphics.FromImage(ScreenGrab1)
        g.CopyFromScreen(New Point(0, 0), New Point(0, 0), ScreenSizeTotal)
        If System.IO.File.Exists(frmMain.DriveLetter & "RSAutoClicker\" & ProgramName & "\" & ProgramName & "Click" & CStr(cmbClickNmbr.SelectedItem) & ".bmp") = True Then
            My.Computer.FileSystem.DeleteFile(frmMain.DriveLetter & "RSAutoClicker\" & ProgramName & "\" & ProgramName & "Click" & CStr(cmbClickNmbr.SelectedItem) & ".bmp")
        End If
        ScreenGrab1.Save(frmMain.DriveLetter & "RSAutoClicker\" & ProgramName & "\" & ProgramName & "Click" & CStr(cmbClickNmbr.SelectedItem) & ".bmp")
        txtXLeft.Text = Math.Min(X1, X2)
        txtXRight.Text = Math.Max(X1, X2)
        txtYUp.Text = Math.Min(Y1, Y2)
        txtYDown.Text = Math.Max(Y1, Y2)
        Me.Show()
    End Sub
    Private Sub txtDelayHexStart_TextChanged(sender As Object, e As EventArgs) Handles txtDelayHexStart.TextChanged
        If Integer.TryParse(txtDelayHexStart.Text, 1) = True Then
            txtBufferRangeStart.Text = Math.Ceiling(txtDelayHexStart.Text * 0.1)
        End If
        If UploadComplete = True Then
            ValidateInfo()
        End If
    End Sub
    Private Sub txtDelayHexEnd_TextChanged(sender As Object, e As EventArgs) Handles txtDelayHexEnd.TextChanged
        If Integer.TryParse(txtDelayHexEnd.Text, 1) = True Then
            txtBufferRangeEnd.Text = Math.Ceiling(txtDelayHexEnd.Text * 0.1)
        End If
        If UploadComplete = True Then
            ValidateInfo()
        End If
    End Sub
    Private Sub txtBufferRangeStart_TextChanged(sender As Object, e As EventArgs) Handles txtBufferRangeStart.TextChanged
        If UploadComplete = True Then
            ValidateInfo()
        End If
    End Sub
    Private Sub txtBufferRangeEnd_TextChanged(sender As Object, e As EventArgs) Handles txtBufferRangeEnd.TextChanged
        If UploadComplete = True Then
            ValidateInfo()
        End If
    End Sub
    Private Sub btnSaveClick_Click(sender As Object, e As EventArgs) Handles btnSaveClick.Click
        If cmbStartCondition.SelectedItem = "" Or cmbEndCondition.SelectedItem = "" Then
            frmMessageBox.lblHeader.Text = "Error!"
            frmMessageBox.lblMessageText.Text = "Error: Missing Start or End Condition!"
            frmMessageBox.ShowDialog()
            Exit Sub
        End If
        If txtXLeft.Text = "" Or txtXRight.Text = "" Or txtYUp.Text = "" Or txtYDown.Text = "" Then
            frmMessageBox.lblHeader.Text = "Error!"
            frmMessageBox.lblMessageText.Text = "Error: Missing Coordinate Values!"
            frmMessageBox.ShowDialog()
            Exit Sub
        End If
        Dim NewClick(21) As String
        Dim StartData1 As String = "Unused"
        Dim StartData2() As String = {"Unused", "Unused", "Unused", "Unused"}
        Dim EndData1 As String = "Unused"
        Dim EndData2() As String = {"Unused", "Unused", "Unused", "Unused"}
        Dim DropInventory As Boolean = cbDropInv.Checked
        Dim HealingItem As Boolean = cbHealingItem.Checked
        Dim PrayerPotion As Boolean = cbPrayerPotion.Checked
        Dim ItemPickup As Boolean = cbRightClick.Checked
        Dim PictureVerify As Boolean = cbPictureVerify.Checked
        Dim VariableObject As String = ""
        If txtBufferRangeStart.Text.Count(Function(x) x = " ") = 3 Then
            StartData2 = Split(txtBufferRangeStart.Text, " ", 4)
        ElseIf cmbStartCondition.SelectedItem = "Time" Then
            StartData2(0) = txtBufferRangeStart.Text
        End If
        If cmbStartCondition.SelectedItem.ToString <> "Auto" Then
            StartData1 = txtDelayHexStart.Text
        End If
        If txtBufferRangeEnd.Text.Count(Function(x) x = " ") = 3 Then
            EndData2 = Split(txtBufferRangeEnd.Text, " ", 4)
        ElseIf cmbEndCondition.SelectedItem = "Time" Then
            EndData2(0) = txtBufferRangeEnd.Text
        End If
        If cmbEndCondition.SelectedItem.ToString <> "Auto" Then
            EndData1 = txtDelayHexEnd.Text
        End If
        NewClick = {cmbStartCondition.SelectedItem.ToString, StartData1, StartData2(0), StartData2(1), StartData2(2), StartData2(3),
        cmbEndCondition.SelectedItem.ToString, EndData1, EndData2(0), EndData2(1), EndData2(2), EndData2(3), txtXLeft.Text, txtXRight.Text, txtYUp.Text,
        txtYDown.Text, DropInventory.ToString, HealingItem.ToString, PrayerPotion.ToString, ItemPickup.ToString, PictureVerify.ToString}
        For i = cmbClickNmbr.SelectedItem * 21 - 21 To (20 * cmbClickNmbr.SelectedItem + (cmbClickNmbr.SelectedItem - 1))
            NewProgram(i) = NewClick(i - Math.Floor(i / 21) * 21)
        Next
        ValidateProgram()
    End Sub

    Private Sub btnGetHexStart_Click(sender As Object, e As EventArgs) Handles btnGetHexStart.Click
        frmMessageBox.lblHeader.Text = "Hex Set-Up"
        frmMessageBox.lblMessageText.Text = "Hover mouse over desired pixel && press Enter!"
        Me.Hide()
        If frmMessageBox.ShowDialog() = DialogResult.OK Then
            If GetAsyncKeyState(Keys.Return) <> 0 Then
                GetCursorPos(MousePoint)
                G.CopyFromScreen(Cursor.Position, Point.Empty, Bmp.Size)
                Dim PixelColor As Color = Bmp.GetPixel(0, 0)
                Dim HexColor As String = ColorTranslator.ToHtml(PixelColor)
                txtDelayHexStart.Text = HexColor
                HexXLeftStart = MousePoint.X - 10
                HexXRightStart = MousePoint.X + 10
                HexYUpStart = MousePoint.Y - 10
                HexYDownStart = MousePoint.Y + 10
                Me.Show()
            Else
                Me.Show()
                Exit Sub
            End If
        ElseIf frmMessageBox.DialogResult = DialogResult.Cancel Then
            If txtBufferRangeStart.Text <> "" Then
                btnGetHexStart.Visible = False
            End If
            Me.Show()
            Exit Sub
        End If
        txtBufferRangeStart.Text = HexXLeftStart & " " & HexXRightStart & " " & HexYUpStart & " " & HexYDownStart
        txtDelayHexStart.Enabled = False
        txtDelayHexStart.Visible = True
        txtBufferRangeStart.Enabled = False
        txtBufferRangeStart.Visible = True
        btnGetHexStart.Visible = False
    End Sub
    Private Sub btnGetHexEnd_Click(sender As Object, e As EventArgs) Handles btnGetHexEnd.Click
        frmMessageBox.lblHeader.Text = "Hex Set-Up"
        frmMessageBox.lblMessageText.Text = "Hover mouse over desired pixel && press Enter!"
        Me.Hide()
        If frmMessageBox.ShowDialog() = DialogResult.OK Then
            If GetAsyncKeyState(Keys.Return) <> 0 Then
                GetCursorPos(MousePoint)
                G.CopyFromScreen(Cursor.Position, Point.Empty, Bmp.Size)
                Dim PixelColor As Color = Bmp.GetPixel(0, 0)
                Dim HexColor As String = ColorTranslator.ToHtml(PixelColor)
                txtDelayHexEnd.Text = HexColor
                HexXLeftEnd = MousePoint.X - 10
                HexXRightEnd = MousePoint.X + 10
                HexYUpEnd = MousePoint.Y - 10
                HexYDownEnd = MousePoint.Y + 10
                Me.Show()
            Else
                Me.Show()
                Exit Sub
            End If
        ElseIf frmMessageBox.DialogResult = DialogResult.Cancel Then
            If txtBufferRangeEnd.Text <> "" Then
                btnGetHexEnd.Visible = False
            End If
            Me.Show()
            Exit Sub
        End If
        txtBufferRangeEnd.Text = HexXLeftEnd & " " & HexXRightEnd & " " & HexYUpEnd & " " & HexYDownEnd
        txtDelayHexEnd.Enabled = False
        txtDelayHexEnd.Visible = True
        txtBufferRangeEnd.Enabled = False
        txtBufferRangeEnd.Visible = True
        btnGetHexEnd.Visible = False
    End Sub
    Private Sub btnSaveProgram_Click(sender As Object, e As EventArgs) Handles btnSaveProgram.Click
        If System.IO.File.Exists(frmMain.DriveLetter & "RSAutoClicker\" & ProgramName & "\" & ProgramName & ".csv") = True Then
            My.Computer.FileSystem.DeleteFile(frmMain.DriveLetter & "RSAutoClicker\" & ProgramName & "\" & ProgramName & ".csv")
        End If
        File = My.Computer.FileSystem.OpenTextFileWriter(frmMain.DriveLetter & "RSAutoClicker\" & ProgramName & "\" & ProgramName & ".csv", True)
        For i = 0 To (20 * cmbClickNmbr.Items.Count + (cmbClickNmbr.Items.Count - 1))
            File.WriteLine(NewProgram(i))
        Next
        File.Close()
        frmMain.Show()
        frmMain.cmbLoadProgram.Items.Clear()
        For Each Folder In My.Computer.FileSystem.GetDirectories(frmMain.DriveLetter & "RSAutoClicker")
            Dim Program() As String = Split(Folder, "\")
            frmMain.cmbLoadProgram.Items.Add(Program(2))
        Next
        Me.Close()
    End Sub
    Private Sub btnCancelProg_Click(sender As Object, e As EventArgs) Handles btnCancelProg.Click
        If System.IO.File.Exists(frmMain.DriveLetter & "RSAutoClicker\" & ProgramName & "\" & ProgramName & ".csv") = False Then
            For Each _file As String In System.IO.Directory.GetFiles(frmMain.DriveLetter & "RSAutoClicker\" & ProgramName)
                System.IO.File.Delete(_file)
            Next
            System.IO.Directory.Delete(frmMain.DriveLetter & "RSAutoClicker\" & ProgramName)
        End If
        frmMain.Show()
        Me.Close()
        Exit Sub
    End Sub
    Private Sub cmbClickNmbr_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbClickNmbr.SelectedIndexChanged
        If cmbClickNmbr.Items.Count > 0 And NewProgram((cmbClickNmbr.SelectedItem - 1) * 21) <> "" Then
            cmbStartCondition.SelectedItem = NewProgram(21 * (cmbClickNmbr.SelectedItem - 1))
            cmbEndCondition.SelectedItem = NewProgram(6 + 21 * (cmbClickNmbr.SelectedItem - 1))
            If cmbStartCondition.SelectedItem = "Auto" Then
                txtDelayHexStart.Text = ""
                txtBufferRangeStart.Text = ""
            ElseIf cmbStartCondition.SelectedItem = "Time" Then
                txtDelayHexStart.Text = NewProgram(1 + 21 * (cmbClickNmbr.SelectedItem - 1))
                txtBufferRangeStart.Text = NewProgram(2 + 21 * (cmbClickNmbr.SelectedItem - 1))
            Else
                btnGetHexStart.Visible = False
                txtDelayHexStart.Visible = True
                txtBufferRangeStart.Visible = True
                txtDelayHexStart.Text = NewProgram(1 + 21 * (cmbClickNmbr.SelectedItem - 1))
                txtBufferRangeStart.Text = NewProgram(2 + 21 * (cmbClickNmbr.SelectedItem - 1)) & " " & NewProgram(3 + 21 * (cmbClickNmbr.SelectedItem - 1)) & " " &
                NewProgram(4 + 21 * (cmbClickNmbr.SelectedItem - 1)) & " " & NewProgram(5 + 21 * (cmbClickNmbr.SelectedItem - 1))
            End If

            If cmbEndCondition.SelectedItem = "Time" Then
                txtDelayHexEnd.Text = NewProgram(7 + 21 * (cmbClickNmbr.SelectedItem - 1))
                txtBufferRangeEnd.Text = NewProgram(8 + 21 * (cmbClickNmbr.SelectedItem - 1))
            Else
                btnGetHexEnd.Visible = False
                txtDelayHexEnd.Visible = True
                txtBufferRangeEnd.Visible = True
                txtDelayHexEnd.Text = NewProgram(7 + 21 * (cmbClickNmbr.SelectedItem - 1))
                txtBufferRangeEnd.Text = NewProgram(8 + 21 * (cmbClickNmbr.SelectedItem - 1)) & " " & NewProgram(9 + 21 * (cmbClickNmbr.SelectedItem - 1)) & " " &
                NewProgram(10 + 21 * (cmbClickNmbr.SelectedItem - 1)) & " " & NewProgram(11 + 21 * (cmbClickNmbr.SelectedItem - 1))
            End If
            txtXLeft.Text = NewProgram(12 + 21 * (cmbClickNmbr.SelectedItem - 1))
            txtXRight.Text = NewProgram(13 + 21 * (cmbClickNmbr.SelectedItem - 1))
            txtYUp.Text = NewProgram(14 + 21 * (cmbClickNmbr.SelectedItem - 1))
            txtYDown.Text = NewProgram(15 + 21 * (cmbClickNmbr.SelectedItem - 1))
            cbDropInv.Checked = Convert.ToBoolean(NewProgram(16 + 21 * (cmbClickNmbr.SelectedItem - 1)))
            cbHealingItem.Checked = Convert.ToBoolean(NewProgram(17 + 21 * (cmbClickNmbr.SelectedItem - 1)))
            cbPrayerPotion.Checked = Convert.ToBoolean(NewProgram(18 + 21 * (cmbClickNmbr.SelectedItem - 1)))
            cbRightClick.Checked = Convert.ToBoolean(NewProgram(19 + 21 * (cmbClickNmbr.SelectedItem - 1)))
            cbPictureVerify.Checked = Convert.ToBoolean(NewProgram(20 + 21 * (cmbClickNmbr.SelectedItem - 1)))
        Else
            cmbStartCondition.SelectedIndex = -1
            cmbEndCondition.SelectedIndex = -1
            txtDelayHexStart.Clear()
            txtDelayHexEnd.Clear()
            txtBufferRangeStart.Clear()
            txtBufferRangeEnd.Clear()
            txtXLeft.Clear()
            txtXRight.Clear()
            txtYUp.Clear()
            txtYDown.Clear()
            txtDelayHexStart.Enabled = True
            txtDelayHexEnd.Enabled = True
            txtBufferRangeStart.Enabled = True
            txtBufferRangeEnd.Enabled = True
        End If
    End Sub
    Private Sub btnDeleteClick_Click(sender As Object, e As EventArgs) Handles btnDeleteClick.Click
        Dim j As Integer
        Dim TempArray(20 * (cmbClickNmbr.Items.Count - 1) + (cmbClickNmbr.Items.Count - 1)) As String
        Dim OrigClickNmbr As Integer

        frmMessageBox.lblHeader.Text = "Confirm Click Delete"
        frmMessageBox.lblMessageText.Text = "Are you sure you want to delete the selected click?"
        If frmMessageBox.ShowDialog() = DialogResult.OK Then
            OrigClickNmbr = cmbClickNmbr.SelectedItem
            For i = 1 To cmbClickNmbr.Items.Count
                cmbClickNmbr.SelectedItem = i
                btnSaveClick.PerformClick()
            Next
            cmbClickNmbr.SelectedItem = OrigClickNmbr
            For i = 0 To 20 * cmbClickNmbr.Items.Count + (cmbClickNmbr.Items.Count - 1)
                If i < ((cmbClickNmbr.SelectedItem - 1) * 20 + cmbClickNmbr.SelectedItem - 1) Or
                   i > ((cmbClickNmbr.SelectedItem - 0) * 20 + cmbClickNmbr.SelectedItem - 1) Then
                    TempArray(j) = NewProgram(i)
                    j += 1
                End If
            Next
            Array.Resize(NewProgram, 20 * (cmbClickNmbr.Items.Count - 1) + (cmbClickNmbr.Items.Count - 1))
            For i = 0 To 20 * (cmbClickNmbr.Items.Count - 1) + (cmbClickNmbr.Items.Count - 2)
                NewProgram(i) = TempArray(i)
            Next
            ClickCount = ClickCount - 1
            Array.Resize(Clicks, ClickCount)
            cmbClickNmbr.Items.Clear()
            For i = 0 To ClickCount - 1
                Clicks(i) = i + 1
                cmbClickNmbr.Items.Add(Clicks(i))
            Next
            cmbClickNmbr.SelectedItem() = cmbClickNmbr.Items.Count
        Else
            Exit Sub
        End If
    End Sub
    Private Sub txtXLeft_TextChanged(sender As Object, e As EventArgs) Handles txtXLeft.TextChanged
        If UploadComplete = True Then
            ValidateInfo()
        End If
    End Sub
    Private Sub txtXRight_TextChanged(sender As Object, e As EventArgs) Handles txtXRight.TextChanged
        If UploadComplete = True Then
            ValidateInfo()
        End If
    End Sub
    Private Sub txtYUp_TextChanged(sender As Object, e As EventArgs) Handles txtYUp.TextChanged
        If UploadComplete = True Then
            ValidateInfo()
        End If
    End Sub
    Private Sub txtYDown_TextChanged(sender As Object, e As EventArgs) Handles txtYDown.TextChanged
        If UploadComplete = True Then
            ValidateInfo()
        End If
    End Sub
    Sub ValidateInfo()
        Dim HexStringStart = txtDelayHexStart.Text
        Dim HexStringEnd = txtDelayHexEnd.Text
        Dim Wdt As Integer = 0
        Dim Hgt As Integer = 0
        If UploadComplete = True Then
            If cmbStartCondition.SelectedItem = "Time" Then
                If Integer.TryParse(txtDelayHexStart.Text, 1) = False Then
                    txtDelayHexStart.ForeColor = Color.Red
                Else
                    txtDelayHexStart.ForeColor = Color.Black
                End If
                If Integer.TryParse(txtBufferRangeStart.Text, 1) = False Then
                    txtBufferRangeStart.ForeColor = Color.Red
                Else
                    txtBufferRangeStart.ForeColor = Color.Black
                End If
            ElseIf cmbStartCondition.SelectedItem = "Pixel" Then
                If HexStringStart.StartsWith("#") And txtDelayHexStart.Text.Length = 7 Then
                    txtDelayHexStart.ForeColor = Color.Black
                    txtBufferRangeStart.ForeColor = Color.Black
                Else
                    txtDelayHexStart.ForeColor = Color.Red
                End If
            ElseIf cmbStartCondition.SelectedItem = "Auto" Then
                txtDelayHexStart.ForeColor = Color.Black
                txtBufferRangeStart.ForeColor = Color.Black
            End If
            If cmbEndCondition.SelectedItem = "Time" Then
                If Integer.TryParse(txtDelayHexEnd.Text, 1) = False Then
                    txtDelayHexEnd.ForeColor = Color.Red
                Else
                    txtDelayHexEnd.ForeColor = Color.Black
                End If

                If Integer.TryParse(txtBufferRangeEnd.Text, 1) = False Then
                    txtBufferRangeEnd.ForeColor = Color.Red
                Else
                    txtBufferRangeEnd.ForeColor = Color.Black
                End If
            ElseIf cmbEndCondition.SelectedItem = "Pixel" Then
                If HexStringEnd.StartsWith("#") And txtDelayHexEnd.Text.Length = 7 Then
                    txtDelayHexEnd.ForeColor = Color.Black
                    txtBufferRangeEnd.ForeColor = Color.Black
                Else
                    txtDelayHexEnd.ForeColor = Color.Red
                End If
            End If
            If Integer.TryParse(txtXLeft.Text, 1) = False Then
                txtXLeft.ForeColor = Color.Red
            Else
                txtXLeft.ForeColor = Color.Black
            End If
            If Integer.TryParse(txtXRight.Text, 1) = False Then
                txtXRight.ForeColor = Color.Red
            Else
                txtXRight.ForeColor = Color.Black
            End If
            If Integer.TryParse(txtXLeft.Text, 1) = True And Integer.TryParse(txtXRight.Text, 1) = True Then
                If Convert.ToInt32(txtXLeft.Text) > Convert.ToInt32(txtXRight.Text) Then
                    txtXLeft.ForeColor = Color.Red
                    txtXRight.ForeColor = Color.Red
                Else
                    txtXLeft.ForeColor = Color.Black
                    txtXRight.ForeColor = Color.Black
                End If
            End If
            If Integer.TryParse(txtYUp.Text, 1) = False Then
                txtYUp.ForeColor = Color.Red
            Else
                txtYUp.ForeColor = Color.Black
            End If
            If Integer.TryParse(txtYDown.Text, 1) = False Then
                txtYDown.ForeColor = Color.Red
            Else
                txtYDown.ForeColor = Color.Black
            End If
            If Integer.TryParse(txtYUp.Text, 1) = True And Integer.TryParse(txtYDown.Text, 1) = True Then
                If Convert.ToInt32(txtYUp.Text) > Convert.ToInt32(txtYDown.Text) Then
                    txtYUp.ForeColor = Color.Red
                    txtYDown.ForeColor = Color.Red
                Else
                    txtYUp.ForeColor = Color.Black
                    txtYDown.ForeColor = Color.Black
                End If
            End If
            For Each ctrl As Control In Controls
                Dim InvalidCount As Integer
                If ctrl.GetType Is GetType(TextBox) And ctrl.ForeColor = Color.Red Then
                    btnSaveClick.Enabled = False
                    InvalidCount += 1
                End If
                If InvalidCount = 0 Then
                    btnSaveClick.Enabled = True
                End If
            Next
        End If
    End Sub
    Sub ValidateProgram()
        If NewProgram.Count = cmbClickNmbr.Items.Count * 21 Then
            For i = 0 To 20 * cmbClickNmbr.Items.Count + (cmbClickNmbr.Items.Count - 1)
                Dim EmptyStringCount As Integer
                If NewProgram(i) = "" Then
                    btnSaveProgram.Enabled = False
                    btnDeleteClick.Enabled = False
                    EmptyStringCount += 1
                End If
                If EmptyStringCount = 0 Then
                    btnSaveProgram.Enabled = True
                    btnDeleteClick.Enabled = True
                End If
            Next
        Else
            btnSaveProgram.Enabled = False
            btnDeleteClick.Enabled = False
        End If
    End Sub
    Sub UploadInfo()
        UploadComplete = False
        Dim i As Integer
        For i = 0 To NewProgram.Count / 21 - 2
            btnAddClick.PerformClick()
        Next
        cmbClickNmbr.SelectedItem = 1
        UploadComplete = True
        ValidateInfo()
    End Sub
    Private Sub lblDelayHexStart_Click(sender As Object, e As EventArgs) Handles lblDelayHexStart.Click
        If btnGetHexStart.Visible = False And cmbStartCondition.SelectedItem = "Pixel" Then
            frmMessageBox.lblHeader.Text = "Hex Set-Up"
            frmMessageBox.lblMessageText.Text = "Reset Hex Code Data?"
            If frmMessageBox.ShowDialog() = DialogResult.OK Then
                btnGetHexStart.Visible = True
                btnGetHexStart.Enabled = True
                Me.Show()
                btnGetHexStart.PerformClick()
            Else
                Me.Show()
                Exit Sub
            End If
        End If
    End Sub
    Private Sub lblDelayHexEnd_Click(sender As Object, e As EventArgs) Handles lblDelayHexEnd.Click
        If btnGetHexEnd.Visible = False And cmbEndCondition.SelectedItem = "Pixel" Then
            frmMessageBox.lblHeader.Text = "Hex Set-Up"
            frmMessageBox.lblMessageText.Text = "Reset Hex Code Data?"
            If frmMessageBox.ShowDialog() = DialogResult.OK Then
                btnGetHexEnd.Visible = True
                btnGetHexEnd.Enabled = True
                Me.Show()
                btnGetHexEnd.PerformClick()
            Else
                Me.Show()
                Exit Sub
            End If
        End If
    End Sub
    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        If System.IO.File.Exists(frmMain.DriveLetter & "RSAutoClicker\" & ProgramName & "\" & ProgramName & ".csv") = False Then
            For Each _file As String In System.IO.Directory.GetFiles(frmMain.DriveLetter & "RSAutoClicker\" & ProgramName)
                System.IO.File.Delete(_file)
            Next
            System.IO.Directory.Delete(frmMain.DriveLetter & "RSAutoClicker\" & ProgramName)
        End If
        frmMain.Show()
        Me.Close()
        Exit Sub
    End Sub
End Class