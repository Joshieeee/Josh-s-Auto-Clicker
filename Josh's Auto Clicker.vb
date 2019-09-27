'3,400 TOTAL LINES OF CODE!!!! :O
'BUG: MOVING LABEL/PANEL TOO FAST MINIMIZES ALL TABS
'DISABLE MOUSE WHILE CLICK IS OCCURING
'AUTOMATED PICTURE CALIBRATION
Option Explicit On
Imports Microsoft.VisualBasic.FileIO.TextFieldParser
Imports System.IO.DriveInfo
Imports System.Runtime.InteropServices
Imports System.IO
Imports Microsoft.Win32
Public Class frmMain
    Private stopwatch As New Stopwatch

    'Private Declare Function BlockInput Lib "user32" (ByVal fBlock As Boolean) As Boolean
    'Private Declare Function BlockInput Lib "user32" Alias "BlockInput" (ByVal fBlock As Boolean) As Boolean

    <DllImport("user32.dll", EntryPoint:="BlockInput")>
    Private Shared Function BlockInput(<MarshalAs(UnmanagedType.Bool)> ByVal fBlockIt As Boolean) As <MarshalAs(UnmanagedType.Bool)> Boolean
    End Function

    'Private Declare Function BlockInput Lib "user32" Alias "BlockInput" (ByVal fBlock As Integer) As Integer

    Public Declare Auto Function SetCursorPos Lib "User32.dll" (ByVal X As Integer, ByVal Y As Integer) As Integer
    Public Declare Auto Function GetCursorPos Lib "User32.dll" (ByRef lpPoint As Point) As Integer
    Public Declare Function GetAsyncKeyState Lib "User32.dll" (ByVal vkey As Keys) As Integer
    Public Declare Sub mouse_event Lib "User32" Alias "mouse_event" (ByVal dwFlags As Integer, ByVal dx As Integer, ByVal dy As Integer, ByVal cButtons As Integer, ByVal dwExtraInfo As Integer)
    Public Const WM_NCLBUTTONDOWN As Integer = 161
    Public Const HT_CAPTION As Integer = 2
    Public Const KEYEVENTF_KEYDOWN As Integer = &H0
    Public Const KEYEVENTF_KEYUP As Integer = &H2
    <DllImport("user32.dll", EntryPoint:="keybd_event")>
    Public Shared Sub keybd_event(ByVal bVk As Byte, ByVal bScan As Byte, ByVal dwFlags As UInteger, ByVal dwExtraInfo As UInteger)
    End Sub
    <DllImport("User32")> Private Shared Function SendMessage(hWnd As IntPtr, Msg As Integer, wParam As Integer, lParam As Integer) As Integer
    End Function
    <DllImport("User32")> Private Shared Function ReleaseCapture() As Boolean
    End Function
    Public Const MOUSEEVENTF_ABSOLUTE = &H8000
    Public Const MOUSEEVENTF_LEFTDOWN = &H2
    Public Const MOUSEEVENTF_LEFTUP = &H4
    Public Const MOUSEEVENTF_MIDDLEDOWN = &H20
    Public Const MOUSEEVENTF_MIDDLEUP = &H40
    Public Const MOUSEEVENTF_RIGHTDOWN = &H8
    Public Const MOUSEEVENTF_RIGHTUP = &H10
    Public MousePoint As Point
    Public File As System.IO.StreamWriter
    Public DriveList(10) As String
    Public DriveCount As Integer
    Public DriveLetter As String
    Dim Bmp As New Bitmap(1, 1)
    Dim g As Graphics = Graphics.FromImage(Bmp)
    Dim Home(1) As Integer
    Dim RandomTime As New Random, RandomCoord As New Random
    Dim Abort As Integer, Restart As Integer, Pause As Integer
    Dim ProgramPaused As Boolean = False
    Dim ProgramExecuting As Boolean = False
    Dim PauseFlag As Integer
    Public VarName As String
    Public XY As Integer
    Dim Value As Integer = 0
    Dim ScreenX As Integer, ScreenY As Integer
    Dim OriginalMousePointX As Integer
    Dim OriginalMousePointY As Integer
    Dim GameTimer As Integer = 0
    Dim ProgramDuration As Integer
    Public ProgramCounter As Integer
    Public ExitCoordsLoaded As Integer
    Public GameScreenLoaded As Integer
    Dim TimerDONE As Boolean
    Dim SixHourGameTimer As TimeSpan = TimeSpan.FromHours(6)
    Dim UpdateGameTimerHours As TimeSpan
    Dim UpdateGameTimerMinutes As TimeSpan
    Dim UpdateGameTimerSeconds As TimeSpan
    Dim elapsed As TimeSpan
    Dim Exc As Exception
    Public ProgramCounterOk As Boolean = False
    Dim IncrementOK As Boolean = False
    Dim XY_OK As Boolean = False
    Dim Array_OK As Boolean = False
    Dim Flag As Integer = 0
    Public AlwaysOnTopEnabled As Boolean
    Public ExitCoordsEnabled As Boolean
    'Dim RGBSize As Integer
    'Dim RGB As Color
    'Dim Hex As String
    'Dim HexCSV() As String
    'Dim RgbCSV() As Color
    'Dim ItemColorsLoaded As Integer
#Region "Form1 Load"
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'My.Settings.Reset()
        'My.Settings.Save()
        CenterToScreen()
        If My.Settings.ActiveDrive <> "" Then
            DriveLetter = My.Settings.ActiveDrive
            txtEventLog.Text = "Active Drive Letter: " & "'" & My.Settings.ActiveDrive & "'"
        End If
        GameTmr.Start()
        Me.stopwatch.Start()
        For Each drive In System.IO.DriveInfo.GetDrives()
            Dim i As Integer
            If drive.DriveType <> IO.DriveType.CDRom Then
                DriveList(i) = drive.ToString
                i = i + 1
                DriveCount += 1
                frmSettings.cbDriveList.Items.Add(drive.ToString)
            End If
        Next
        If My.Settings.ActiveDrive <> "" Then
            For Each Folder In My.Computer.FileSystem.GetDirectories(DriveLetter & "RSAutoClicker")
                Folder = Mid(Folder, 18)
                If cmbLoadProgram.Items.Contains(Folder) = False Then
                    cmbLoadProgram.Items.Add(Folder)
                End If
            Next
        End If
    End Sub
    Private Sub pnlHeader_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pnlHeader.MouseDown
        If (e.Button = MouseButtons.Left) Then
            ReleaseCapture()
            SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0)
        End If
    End Sub
    Private Sub lblProgramTitle_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lblProgramTitle.MouseDown
        If (e.Button = MouseButtons.Left) Then
            ReleaseCapture()
            SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0)
        End If
    End Sub
#End Region
#Region "Timers"
    Sub delay(ByVal DelayDuration)
        'Allows program to remain responsive during delays
        DelayTimer.Interval = DelayDuration
        TimerDONE = False
        DelayTimer.Enabled = True
        Do
            Application.DoEvents()
        Loop Until TimerDONE
    End Sub
    Private Sub DelayTimer_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DelayTimer.Tick
        TimerDONE = True
        DelayTimer.Enabled = False
    End Sub
#End Region
#Region "Abort/Restart/Pause"
    Private Sub btnAbort_Click(sender As Object, e As EventArgs) Handles btnAbort.Click
        If ProgramExecuting = True Then
            frmMessageBox.lblHeader.Text = "Abort Program?"
            frmMessageBox.lblMessageText.Text = "Are you sure you want to abort the program?"
            Abort = frmMessageBox.ShowDialog()
            If Abort = DialogResult.OK Then
                If txtEventLog.Text = "" Then
                    txtEventLog.Text &= TimeOfDay & ": Program '" & cmbLoadProgram.SelectedItem & "' is aborting. Please wait..."
                    txtEventLog.SelectionStart = txtEventLog.TextLength
                    txtEventLog.ScrollToCaret()
                Else
                    txtEventLog.Text &= Environment.NewLine & TimeOfDay & ": Program '" & cmbLoadProgram.SelectedItem & "' is aborting. Please wait..."
                    txtEventLog.SelectionStart = txtEventLog.TextLength
                    txtEventLog.ScrollToCaret()
                End If
            End If
        End If
    End Sub
    Private Sub btnPauseResume_Click(sender As Object, e As EventArgs) Handles btnPauseResume.Click
        PauseFlag = 0
        If ProgramExecuting = True Then
            If btnPauseResume.Text = "Pause" Then
                btnPauseResume.Text = "Resume"
                PauseFlag = 1
                'btnPauseResume.ForeColor = Color.DarkGreen
                If txtEventLog.Text = "" Then
                    txtEventLog.Text &= TimeOfDay & ": Program " & CStr(cmbLoadProgram.SelectedItem) & " has been paused."
                    txtEventLog.SelectionStart = txtEventLog.TextLength
                    txtEventLog.ScrollToCaret()
                Else
                    txtEventLog.Text &= Environment.NewLine & TimeOfDay & ": Program " & CStr(cmbLoadProgram.SelectedItem) & " has been paused."
                    txtEventLog.SelectionStart = txtEventLog.TextLength
                    txtEventLog.ScrollToCaret()
                End If
            End If
            If btnPauseResume.Text = "Resume" And PauseFlag = 0 Then
                btnPauseResume.Text = "Pause"
                'btnPauseResume.ForeColor = Color.Yellow
                If txtEventLog.Text = "" Then
                    txtEventLog.Text &= TimeOfDay & ": Program " & CStr(cmbLoadProgram.SelectedItem) & " has been resumed."
                    txtEventLog.SelectionStart = txtEventLog.TextLength
                    txtEventLog.ScrollToCaret()
                Else
                    txtEventLog.Text &= Environment.NewLine & TimeOfDay & ": Program " & CStr(cmbLoadProgram.SelectedItem) & " has been resumed."
                    txtEventLog.SelectionStart = txtEventLog.TextLength
                    txtEventLog.ScrollToCaret()
                End If
            End If
        End If
    End Sub
#End Region
#Region "Run Program"
    Private Sub btnRunProgram_Click(sender As Object, e As EventArgs) Handles btnRunProgram.Click
        Dim ClickArray(0) As Integer
        Dim StartConditionArray(0) As String
        Dim EndConditionArray(0) As String
        Dim DelayHexCodeArray(0) As String
        Dim BufferHexRangeArray(0) As String
        Dim DropInvArray(0) As String
        Dim HealItemArray(0) As String
        Dim PrayerItemArray(0) As String
        Dim RightClickArray(0) As String
        Dim VerifyPicArray(0) As String
        Dim LoopCounter As Integer = 0
        Dim PixelMatchCount As Integer
        Dim TotalPixels As Integer = 0
        Dim VerifyFailed As Boolean
        Dim a As Bitmap
        Dim b As Bitmap
        Dim CurrentRow As String()
        Dim ArrayCell As Integer = 1
        Dim Count As Integer
        If DriveLetter = "" Then
            If cmbLoadProgram.SelectedItem = "" Then
                frmMessageBox.lblHeader.Text = "Run Program Set-Up"
                frmMessageBox.lblMessageText.Text = "No Drive Selected!"
                frmMessageBox.ShowDialog()
                Exit Sub
            End If
        End If
        If cmbLoadProgram.SelectedItem <> "" And System.IO.File.Exists(DriveLetter & "RSAutoClicker\" & cmbLoadProgram.SelectedItem & "\" & cmbLoadProgram.SelectedItem & ".csv") = True Then
            VarName = cmbLoadProgram.SelectedItem
        ElseIf cmbLoadProgram.SelectedItem <> "" And System.IO.File.Exists(DriveLetter & "RSAutoClicker\" & cmbLoadProgram.SelectedItem & "\" & cmbLoadProgram.SelectedItem & ".csv") = False Then
            frmMessageBox.lblHeader.Text = "Run Program Set-Up"
            frmMessageBox.lblMessageText.Text = "No CSV File Found!"
            frmMessageBox.ShowDialog()
            Exit Sub
        Else
            If cmbLoadProgram.SelectedItem = "" Then
                frmMessageBox.lblHeader.Text = "Run Program Set-Up"
                frmMessageBox.lblMessageText.Text = "No Program Selected!"
                frmMessageBox.ShowDialog()
                Exit Sub
            End If
        End If

        Value = 1
        Using MyReader As New Microsoft.VisualBasic.FileIO.TextFieldParser(DriveLetter & "RSAutoClicker\" & VarName & "\" & VarName & ".csv")
            MyReader.TextFieldType = FileIO.FieldType.Delimited
            MyReader.SetDelimiters(",")
            While Not MyReader.EndOfData
                CurrentRow = MyReader.ReadFields()
                Dim CurrentField As String
                For Each CurrentField In CurrentRow
                    Count = Count + 1
                Next
            End While
            Array.Resize(StartConditionArray, Count * (1 / 21))
            Array.Resize(EndConditionArray, Count * (1 / 21))
            Array.Resize(DelayHexCodeArray, Count * (2 / 21))
            Array.Resize(BufferHexRangeArray, Count * (8 / 21))
            Array.Resize(ClickArray, Count * (4 / 21))
            Array.Resize(DropInvArray, Count * (1 / 21))
            Array.Resize(HealItemArray, Count * (1 / 21))
            Array.Resize(PrayerItemArray, Count * (1 / 21))
            Array.Resize(RightClickArray, Count * (1 / 21))
            Array.Resize(VerifyPicArray, Count * (1 / 21))
        End Using
        Using MyReader As New Microsoft.VisualBasic.FileIO.TextFieldParser(DriveLetter & "RSAutoClicker\" & VarName & "\" & VarName & ".csv")
            MyReader.TextFieldType = FileIO.FieldType.Delimited
            MyReader.SetDelimiters(",")
            Dim FieldNumber As Integer = 1
            Dim ArrayFlag = 0
            While Not MyReader.EndOfData
                CurrentRow = MyReader.ReadFields()
                Dim CurrentField As String
                For Each CurrentField In CurrentRow
                    If FieldNumber Mod 21 = 1 And ArrayFlag = 0 Then
                        Dim i As Integer
                        StartConditionArray(i) = CurrentField
                        i += 1
                        ArrayFlag = 1
                    End If
                    If FieldNumber Mod 21 = 2 And ArrayFlag = 0 Then
                        Dim i As Integer
                        DelayHexCodeArray(i) = CurrentField
                        i += 2
                        ArrayFlag = 1
                    End If
                    If FieldNumber Mod 21 = 3 And ArrayFlag = 0 Then
                        Dim i As Integer
                        BufferHexRangeArray(i) = CurrentField
                        i += 8
                        ArrayFlag = 1
                    End If
                    If FieldNumber Mod 21 = 4 And ArrayFlag = 0 Then
                        Dim i As Integer
                        BufferHexRangeArray(i + 1) = CurrentField
                        i += 8
                        ArrayFlag = 1
                    End If
                    If FieldNumber Mod 21 = 5 And ArrayFlag = 0 Then
                        Dim i As Integer
                        BufferHexRangeArray(i + 2) = CurrentField
                        i += 8
                        ArrayFlag = 1
                    End If
                    If FieldNumber Mod 21 = 6 And ArrayFlag = 0 Then
                        Dim i As Integer
                        BufferHexRangeArray(i + 3) = CurrentField
                        i += 8
                        ArrayFlag = 1
                    End If
                    If FieldNumber Mod 21 = 7 And ArrayFlag = 0 Then
                        Dim i As Integer
                        EndConditionArray(i) = CurrentField
                        i += 1
                        ArrayFlag = 1
                    End If
                    If FieldNumber Mod 21 = 8 And ArrayFlag = 0 Then
                        Dim i As Integer
                        DelayHexCodeArray(i + 1) = CurrentField
                        i += 2
                        ArrayFlag = 1
                    End If
                    If FieldNumber Mod 21 = 9 And ArrayFlag = 0 Then
                        Dim i As Integer
                        BufferHexRangeArray(i + 4) = CurrentField
                        i += 8
                        ArrayFlag = 1
                    End If
                    If FieldNumber Mod 21 = 10 And ArrayFlag = 0 Then
                        Dim i As Integer
                        BufferHexRangeArray(i + 5) = CurrentField
                        i += 8
                        ArrayFlag = 1
                    End If
                    If FieldNumber Mod 21 = 11 And ArrayFlag = 0 Then
                        Dim i As Integer
                        BufferHexRangeArray(i + 6) = CurrentField
                        i += 8
                        ArrayFlag = 1
                    End If
                    If FieldNumber Mod 21 = 12 And ArrayFlag = 0 Then
                        Dim i As Integer
                        BufferHexRangeArray(i + 7) = CurrentField
                        i += 8
                        ArrayFlag = 1
                    End If
                    If FieldNumber Mod 21 = 13 And ArrayFlag = 0 Then
                        Dim i As Integer
                        ClickArray(i) = CurrentField
                        i += 4
                        ArrayFlag = 1
                    End If
                    If FieldNumber Mod 21 = 14 And ArrayFlag = 0 Then
                        Dim i As Integer
                        ClickArray(i + 1) = CurrentField
                        i += 4
                        ArrayFlag = 1
                    End If
                    If FieldNumber Mod 21 = 15 And ArrayFlag = 0 Then
                        Dim i As Integer
                        ClickArray(i + 2) = CurrentField
                        i += 4
                        ArrayFlag = 1
                    End If
                    If FieldNumber Mod 21 = 16 And ArrayFlag = 0 Then
                        Dim i As Integer
                        ClickArray(i + 3) = CurrentField
                        i += 4
                        ArrayFlag = 1
                    End If
                    If FieldNumber Mod 21 = 17 And ArrayFlag = 0 Then
                        Dim i As Integer
                        DropInvArray(i) = CurrentField
                        i += 1
                        ArrayFlag = 1
                    End If
                    If FieldNumber Mod 21 = 18 And ArrayFlag = 0 Then
                        Dim i As Integer
                        HealItemArray(i) = CurrentField
                        i += 1
                        ArrayFlag = 1
                    End If
                    If FieldNumber Mod 21 = 19 And ArrayFlag = 0 Then
                        Dim i As Integer
                        PrayerItemArray(i) = CurrentField
                        i += 1
                        ArrayFlag = 1
                    End If
                    If FieldNumber Mod 21 = 20 And ArrayFlag = 0 Then
                        Dim i As Integer
                        RightClickArray(i) = CurrentField
                        i += 1
                        ArrayFlag = 1
                    End If
                    If FieldNumber Mod 21 = 0 And ArrayFlag = 0 Then
                        Dim i As Integer
                        VerifyPicArray(i) = CurrentField
                        i += 1
                        ArrayFlag = 1
                    End If
                    ArrayFlag = 0
                    FieldNumber += 1
                Next
            End While
        End Using
        For i = 0 To Count / 21 - 1
            If System.IO.File.Exists(DriveLetter & "RSAutoClicker\Inventory.csv") = False Or My.Settings.InventoryXR = 0 And DropInvArray(i) = True Then
                frmMessageBox.lblHeader.Text = "Inventory Set-Up Error!"
                frmMessageBox.lblMessageText.Text = "Complete Inventory Set-Up or Disable Inventory Drop."
                frmMessageBox.ShowDialog()
                Exit Sub
            End If
        Next
        For i = 0 To Count / 21 - 1
            If (System.IO.File.Exists(DriveLetter & "RSAutoClicker\Healing.csv") = False Or My.Settings.HealTriggerX = 0) And HealItemArray(i) = True Then
                frmMessageBox.lblHeader.Text = "Healing Set-Up Error!"
                frmMessageBox.lblMessageText.Text = "Complete Healing Set-Up or Disable Healing."
                frmMessageBox.ShowDialog()
                Exit Sub
            End If
        Next
        For i = 0 To Count / 21 - 1
            If (System.IO.File.Exists(DriveLetter & "RSAutoClicker\Prayer.csv") = False Or My.Settings.PrayerTriggerX = 0) And PrayerItemArray(i) = True Then
                frmMessageBox.lblHeader.Text = "Prayer Set-Up Error!"
                frmMessageBox.lblMessageText.Text = "Complete Prayer Set-Up or Disable Prayer."
                frmMessageBox.ShowDialog()
                Exit Sub
            End If
        Next
        For i = 0 To Count / 21 - 1
            If My.Settings.VerifyScreenXR = 0 And VerifyPicArray(i) = True Then
                frmMessageBox.lblHeader.Text = "Verify Screen Error!"
                frmMessageBox.lblMessageText.Text = "Complete Verify Screen Set-Up or Disable Screen Verify."
                frmMessageBox.ShowDialog()
                Exit Sub
            End If
        Next
        ProgramCounterOk = False

        frmInputBox.lblHeader.Text = "Program Set-Up"
        frmInputBox.lblInputText.Text = "Enter Number of times this program should be executed:"

        If frmInputBox.ShowDialog() = DialogResult.OK Then
            ProgramCounterOk = True
            ProgramCounter = frmInputBox.txtInputEntry.Text
        Else
            Exit Sub
        End If

        If ProgramCounter = 0 And ProgramCounterOk = True Then
            Exit Sub
        End If
        If txtEventLog.Text = "" Then
            txtEventLog.Text &= TimeOfDay & ": Program '" & CStr(cmbLoadProgram.SelectedItem) & "' has started running."
            txtEventLog.SelectionStart = txtEventLog.TextLength
            txtEventLog.ScrollToCaret()
        Else
            txtEventLog.Text &= Environment.NewLine & TimeOfDay & ": Program '" & CStr(cmbLoadProgram.SelectedItem) & "' has started running."
            txtEventLog.SelectionStart = txtEventLog.TextLength
            txtEventLog.ScrollToCaret()
        End If
        Dim InvTrigger As Integer
        Dim InvTriggerHex As String
        Dim InvSlot(27) As String
        Dim InvPositionX As Integer
        Dim InvPositionY As Integer
        Dim HealTriggerHex As String
        Dim HealItemCount(27) As Integer
        Dim PrayerTriggerHex As String
        Dim PrayerItemCount(27) As Integer
        While LoopCounter < ProgramCounter And elapsed < SixHourGameTimer
            For Each Ctrl As Control In Controls
                If TypeOf Ctrl Is Button And Ctrl.Name <> "btnAbort" And Ctrl.Name <> "btnPauseResume" And Ctrl.Name <> "btnTutorial" And
                    Ctrl.Name <> "btnHorSize" Then
                    Ctrl.Enabled = False
                End If
            Next
            ProgramExecuting = True
            If System.IO.File.Exists(DriveLetter & "RSAutoClicker\Inventory.csv") = True And LoopCounter = 0 Then
                Dim i As Integer
                Using MyReader As New Microsoft.VisualBasic.FileIO.TextFieldParser(DriveLetter & "RSAutoClicker\Inventory.csv")
                    MyReader.TextFieldType = FileIO.FieldType.Delimited
                    MyReader.SetDelimiters(",")
                    While Not MyReader.EndOfData
                        CurrentRow = MyReader.ReadFields()
                        Dim CurrentField As String
                        For Each CurrentField In CurrentRow
                            InvSlot(i) = CurrentField
                            If InvSlot(i) = "True" Then
                                InvTrigger = i
                            End If
                            i += 1
                        Next
                    End While
                End Using
                Dim X As Integer = My.Settings.InventoryXL + ((My.Settings.InventoryXR - My.Settings.InventoryXL) / 8) + ((My.Settings.InventoryXR - My.Settings.InventoryXL) / 4) * (InvTrigger Mod 4)
                Dim Y As Integer = My.Settings.InventoryYU + ((My.Settings.InventoryYD - My.Settings.InventoryYU) / 14) + ((My.Settings.InventoryYD - My.Settings.InventoryYU) / 7) * (Math.Floor(InvTrigger / 4) Mod 7)
                Dim XYLocation As New Point(X, Y)
                XYLocation.X = X
                XYLocation.Y = Y
                g.CopyFromScreen(XYLocation, Point.Empty, Bmp.Size)
                Dim PixelColor As Color = Bmp.GetPixel(0, 0)
                InvTriggerHex = ColorTranslator.ToHtml(PixelColor)
            End If

            If System.IO.File.Exists(DriveLetter & "RSAutoClicker\Healing.csv") = True And My.Settings.HealTriggerY <> 0 And LoopCounter = 0 Then
                Dim i As Integer
                Dim X As Integer
                Dim Y As Integer
                Using MyReader As New Microsoft.VisualBasic.FileIO.TextFieldParser(DriveLetter & "RSAutoClicker\Healing.csv")
                    MyReader.TextFieldType = FileIO.FieldType.Delimited
                    MyReader.SetDelimiters(",")
                    While Not MyReader.EndOfData
                        CurrentRow = MyReader.ReadFields()
                        Dim CurrentField As String
                        For Each CurrentField In CurrentRow
                            HealItemCount(i) = CurrentField
                            i += 1
                        Next
                    End While
                End Using
                Dim XYLocation As New Point(X, Y)
                X = My.Settings.HealTriggerX
                Y = My.Settings.HealTriggerY
                XYLocation.X = X
                XYLocation.Y = Y
                g.CopyFromScreen(XYLocation, Point.Empty, Bmp.Size)
                Dim PixelColor As Color = Bmp.GetPixel(0, 0)
                HealTriggerHex = ColorTranslator.ToHtml(PixelColor)
            End If
            If System.IO.File.Exists(DriveLetter & "RSAutoClicker\Prayer.csv") = True And My.Settings.PrayerTriggerY <> 0 And LoopCounter = 0 Then
                Dim i As Integer
                Dim X As Integer
                Dim Y As Integer
                Using MyReader As New Microsoft.VisualBasic.FileIO.TextFieldParser(DriveLetter & "RSAutoClicker\Prayer.csv")
                    MyReader.TextFieldType = FileIO.FieldType.Delimited
                    MyReader.SetDelimiters(",")
                    While Not MyReader.EndOfData
                        CurrentRow = MyReader.ReadFields()
                        Dim CurrentField As String
                        For Each CurrentField In CurrentRow
                            PrayerItemCount(i) = CurrentField
                            i += 1
                        Next
                    End While
                End Using
                Dim XYLocation As New Point(X, Y)
                X = My.Settings.PrayerTriggerX
                Y = My.Settings.PrayerTriggerY
                XYLocation.X = X
                XYLocation.Y = Y
                g.CopyFromScreen(XYLocation, Point.Empty, Bmp.Size)
                Dim PixelColor As Color = Bmp.GetPixel(0, 0)
                PrayerTriggerHex = ColorTranslator.ToHtml(PixelColor)
            End If
            If ProgramPaused = False Then
                Dim i As Integer
                For ClickNumber As Integer = 1 To (Count / 21)
                    If VerifyPicArray(i) = True And System.IO.File.Exists(DriveLetter & "RSAutoClicker\" & VarName & "\" & VarName & "Click" & CStr(ClickNumber) & ".bmp") = True Then
                        Dim Wdt As Integer = 0
                        For Each scr As Screen In Screen.AllScreens
                            Wdt += scr.Bounds.Width
                        Next
                        Dim ScreenSizeTotal As Size = New Size(Wdt, My.Computer.Screen.Bounds.Height)
                        Dim ScreenGrab1 As New Bitmap(Wdt, My.Computer.Screen.Bounds.Height)
                        Dim g As Graphics = Graphics.FromImage(ScreenGrab1)
                        g.CopyFromScreen(New Point(0, 0), New Point(0, 0), ScreenSizeTotal)
                        If System.IO.File.Exists(DriveLetter & "RSAutoClicker\" & "VerifyClick.bmp") = True Then
                            My.Computer.FileSystem.DeleteFile(DriveLetter & "RSAutoClicker\" & "VerifyClick.bmp")
                        End If
                        ScreenGrab1.Save(DriveLetter & "RSAutoClicker\" & "VerifyClick.bmp")
                        a = New Bitmap(DriveLetter & "RSAutoClicker\" & VarName & "\" & VarName & "Click" & CStr(ClickNumber) & ".bmp")
                        b = New Bitmap(DriveLetter & "RSAutoClicker\" & "VerifyClick.bmp")
                        Dim ScreenRegion As New Bitmap(b.Width, b.Height, System.Drawing.Imaging.PixelFormat.Format32bppPArgb)
                        For y As Integer = My.Settings.VerifyScreenYU To My.Settings.VerifyScreenYD - 1 Step My.Settings.VerifyResolution
                            For x = My.Settings.VerifyScreenXL To My.Settings.VerifyScreenXR - 1 Step My.Settings.VerifyResolution
                                Dim aColor As Color = a.GetPixel(x, y)
                                Dim bColor As Color = b.GetPixel(x, y)
                                If aColor.ToArgb() = bColor.ToArgb() Then
                                    PixelMatchCount += 1
                                End If
                                TotalPixels += 1
                            Next
                        Next
                        a.Dispose()
                        b.Dispose()
                        Dim PicMatchPercentage = PixelMatchCount / TotalPixels
                        txtPicMatchPercent.Text = String.Format("{0:0.0%}", PicMatchPercentage)
                        If (PixelMatchCount / TotalPixels) < 0.2 Then
                            If txtEventLog.Text <> "" Then
                                txtEventLog.Text &= Environment.NewLine
                            End If
                            txtEventLog.Text &= TimeOfDay & ": Program '" & CStr(cmbLoadProgram.SelectedItem) & "' failed picture verification on Loop # " & CStr(LoopCounter + 1) & " & Click # " & CStr(ClickNumber) & "."
                            txtEventLog.SelectionStart = txtEventLog.TextLength
                            txtEventLog.ScrollToCaret()
                            VerifyFailed = True
                            Exit While
                        End If
                        PixelMatchCount = 0
                        TotalPixels = 0
                        My.Computer.FileSystem.DeleteFile(DriveLetter & "RSAutoClicker\" & "VerifyClick.bmp")
                    End If
                    If StartConditionArray(i) = "Time" Then
                        delay(RandomTime.Next(CInt(DelayHexCodeArray(i * 2)), CInt(DelayHexCodeArray(i * 2)) + CInt(BufferHexRangeArray(i * 8))))
                    ElseIf StartConditionArray(i) = "Pixel" Then
                        Dim Flag As Integer = 0
                        Dim PixelStartCheck As TimeSpan = elapsed
                        While Flag = 0
                            For X As Integer = BufferHexRangeArray(i * 8) + (10 - My.Settings.HexRange) To BufferHexRangeArray(i * 8 + 1) - (10 - My.Settings.HexRange)
                                For Y As Integer = BufferHexRangeArray(i * 8 + 2) + (10 - My.Settings.HexRange) To BufferHexRangeArray(i * 8 + 3) - (10 - My.Settings.HexRange)
                                    Dim XYLocation As New Point(X, Y)
                                    XYLocation.X = X
                                    XYLocation.Y = Y
                                    g.CopyFromScreen(XYLocation, Point.Empty, Bmp.Size)
                                    Dim PixelColor As Color = Bmp.GetPixel(0, 0)
                                    Dim HexColor As String = ColorTranslator.ToHtml(PixelColor)
                                    If HexColor = DelayHexCodeArray(i * 2) Then
                                        Flag = 1
                                        Exit For
                                    End If
                                Next
                                If Flag = 1 Then
                                    delay(1000)
                                    Exit For
                                End If

                            Next
                            If Flag = 0 Then
                                delay(1000)
                            End If
                            If elapsed - PixelStartCheck > TimeSpan.FromSeconds(My.Settings.MaxCheckTime) Then
                                Exit While
                            End If
                        End While
                    End If
                    BlockInput(True)
                    ScreenX = RandomCoord.Next(Math.Min(ClickArray(i * 4), ClickArray(i * 4 + 1)), Math.Max(ClickArray(i * 4), ClickArray(i * 4 + 1)))
                    ScreenY = RandomCoord.Next(Math.Min(ClickArray(i * 4 + 2), ClickArray(i * 4 + 3)), Math.Max(ClickArray(i * 4 + 2), ClickArray(i * 4 + 3)))
                    GetCursorPos(MousePoint)
                    OriginalMousePointX = MousePoint.X
                    OriginalMousePointY = MousePoint.Y
                    SetCursorPos(ScreenX, ScreenY)
                    delay(20)
                    If RightClickArray(i) = False Then
                        mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0)
                        mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0)
                    Else
                        mouse_event(MOUSEEVENTF_RIGHTDOWN, 0, 0, 0, 0)
                        mouse_event(MOUSEEVENTF_RIGHTUP, 0, 0, 0, 0)
                    End If
                    delay(20)
                    SetCursorPos(OriginalMousePointX, OriginalMousePointY)
                    BlockInput(False)
                    If EndConditionArray(i) = "Time" Then
                        delay(RandomTime.Next(CInt(DelayHexCodeArray(i * 2 + 1)), CInt(DelayHexCodeArray(i * 2 + 1)) + CInt(BufferHexRangeArray(i * 8 + 4))))
                    ElseIf EndConditionArray(i) = "Pixel" Then
                        Dim Flag As Integer = 0
                        Dim PixelEndCheck As TimeSpan = elapsed
                        While Flag = 0
                            For X As Integer = BufferHexRangeArray(i * 8 + 4) To BufferHexRangeArray(i * 8 + 5)
                                For Y As Integer = BufferHexRangeArray(i * 8 + 6) To BufferHexRangeArray(i * 8 + 7)
                                    Dim XYLocation As New Point(X, Y)
                                    XYLocation.X = X
                                    XYLocation.Y = Y
                                    g.CopyFromScreen(XYLocation, Point.Empty, Bmp.Size)
                                    Dim PixelColor As Color = Bmp.GetPixel(0, 0)
                                    Dim HexColor As String = ColorTranslator.ToHtml(PixelColor)
                                    If HexColor = DelayHexCodeArray(i * 2 + 1) Then
                                        Flag = 1
                                        Exit For
                                    End If
                                Next
                                If Flag = 1 Then
                                    Exit For
                                End If
                            Next
                            If Flag = 0 Then
                                delay(1000)
                            End If
                            If elapsed - PixelEndCheck > TimeSpan.FromSeconds(My.Settings.MaxCheckTime) Then
                                Exit While
                            End If
                        End While
                    End If
                    If DropInvArray(i) = "True" And System.IO.File.Exists(DriveLetter & "RSAutoClicker\Inventory.csv") = True And Abort <> DialogResult.OK Then
                        Dim X As Integer = My.Settings.InventoryXL + ((My.Settings.InventoryXR - My.Settings.InventoryXL) / 8) +
                            ((My.Settings.InventoryXR - My.Settings.InventoryXL) / 4) * (InvTrigger Mod 4)
                        Dim Y As Integer = My.Settings.InventoryYU + ((My.Settings.InventoryYD - My.Settings.InventoryYU) / 14) +
                            ((My.Settings.InventoryYD - My.Settings.InventoryYU) / 7) * (Math.Floor(InvTrigger / 4) Mod 7)
                        Dim XYLocation As New Point(X, Y)
                        XYLocation.X = X
                        XYLocation.Y = Y
                        g.CopyFromScreen(XYLocation, Point.Empty, Bmp.Size)
                        Dim PixelColor As Color = Bmp.GetPixel(0, 0)
                        Dim InvHexCheck As String = ColorTranslator.ToHtml(PixelColor)
                        If InvHexCheck <> InvTriggerHex Then
                            GetCursorPos(MousePoint)
                            OriginalMousePointX = MousePoint.X
                            OriginalMousePointY = MousePoint.Y
                            For j = 0 To 27
                                If InvSlot(j) = "True" Then
                                    If (j + 1) Mod 8 = 5 Or (j + 1) Mod 8 = 6 Or (j + 1) Mod 8 = 7 Or (j + 1) Mod 8 = 0 Then
                                        InvPositionX = My.Settings.InventoryXR - ((My.Settings.InventoryXR - My.Settings.InventoryXL) / 8) -
                                        ((My.Settings.InventoryXR - My.Settings.InventoryXL) / 4) * (j Mod 4)
                                    Else
                                        InvPositionX = My.Settings.InventoryXL + ((My.Settings.InventoryXR - My.Settings.InventoryXL) / 8) +
                                        ((My.Settings.InventoryXR - My.Settings.InventoryXL) / 4) * (j Mod 4)
                                    End If
                                    InvPositionY = My.Settings.InventoryYU + ((My.Settings.InventoryYD - My.Settings.InventoryYU) / 14) +
                                        ((My.Settings.InventoryYD - My.Settings.InventoryYU) / 7) * (Math.Floor(j / 4) Mod 7)
                                    ScreenX = RandomCoord.Next(InvPositionX - 7, InvPositionX + 7)
                                    ScreenY = RandomCoord.Next(InvPositionY - 7, InvPositionY + 7)
                                    SetCursorPos(ScreenX, ScreenY)
                                    delay(20)
                                    keybd_event(CByte(Keys.ShiftKey), 0, KEYEVENTF_KEYDOWN, 0)
                                    mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0)
                                    mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0)
                                    delay(RandomTime.Next(350, 700))
                                End If
                            Next
                            keybd_event(CByte(Keys.ShiftKey), 0, KEYEVENTF_KEYUP, 0)
                            SetCursorPos(OriginalMousePointX, OriginalMousePointY)
                        End If
                    End If
                    If HealItemArray(i) = "True" And System.IO.File.Exists(DriveLetter & "RSAutoClicker\Healing.csv") = True And Abort <> DialogResult.OK Then
                        Dim X As Integer = My.Settings.HealTriggerX
                        Dim Y As Integer = My.Settings.HealTriggerY
                        Dim XYLocation As New Point(X, Y)
                        XYLocation.X = X
                        XYLocation.Y = Y
                        g.CopyFromScreen(XYLocation, Point.Empty, Bmp.Size)
                        Dim PixelColor As Color = Bmp.GetPixel(0, 0)
                        Dim HealHexCheck As String = ColorTranslator.ToHtml(PixelColor)
                        txtEventLog.Text &= Environment.NewLine & HealHexCheck & "/" & HealTriggerHex
                        If HealHexCheck <> HealTriggerHex Then
                            GetCursorPos(MousePoint)
                            OriginalMousePointX = MousePoint.X
                            OriginalMousePointY = MousePoint.Y
                            Dim Flag As Boolean = False
                            For j = 0 To 27
                                If HealItemCount(j) <> 0 And Flag = False Then
                                    InvPositionX = My.Settings.InventoryXL + ((My.Settings.InventoryXR - My.Settings.InventoryXL) / 8) +
                                        ((My.Settings.InventoryXR - My.Settings.InventoryXL) / 4) * (j Mod 4)
                                    InvPositionY = My.Settings.InventoryYU + ((My.Settings.InventoryYD - My.Settings.InventoryYU) / 14) +
                                        ((My.Settings.InventoryYD - My.Settings.InventoryYU) / 7) * (Math.Floor(j / 4) Mod 7)
                                    ScreenX = RandomCoord.Next(InvPositionX - 7, InvPositionX + 7)
                                    ScreenY = RandomCoord.Next(InvPositionY - 7, InvPositionY + 7)
                                    SetCursorPos(ScreenX, ScreenY)
                                    delay(20)
                                    mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0)
                                    mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0)
                                    delay(RandomTime.Next(350, 700))
                                    Flag = True
                                    HealItemCount(j) = HealItemCount(j) - 1
                                End If
                            Next
                            SetCursorPos(OriginalMousePointX, OriginalMousePointY)
                        End If
                    End If
                    If PrayerItemArray(i) = "True" And System.IO.File.Exists(DriveLetter & "RSAutoClicker\Prayer.csv") = True And Abort <> DialogResult.OK Then
                        Dim X As Integer = My.Settings.PrayerTriggerX
                        Dim Y As Integer = My.Settings.PrayerTriggerY
                        Dim XYLocation As New Point(X, Y)
                        XYLocation.X = X
                        XYLocation.Y = Y
                        g.CopyFromScreen(XYLocation, Point.Empty, Bmp.Size)
                        Dim PixelColor As Color = Bmp.GetPixel(0, 0)
                        Dim PrayerHexCheck As String = ColorTranslator.ToHtml(PixelColor)
                        txtEventLog.Text &= Environment.NewLine & PrayerHexCheck & "/" & PrayerTriggerHex
                        If PrayerHexCheck <> PrayerTriggerHex Then
                            GetCursorPos(MousePoint)
                            OriginalMousePointX = MousePoint.X
                            OriginalMousePointY = MousePoint.Y
                            Dim Flag As Boolean = False
                            For j = 0 To 27
                                If PrayerItemCount(j) <> 0 And Flag = False Then
                                    InvPositionX = My.Settings.InventoryXL + ((My.Settings.InventoryXR - My.Settings.InventoryXL) / 8) +
                                        ((My.Settings.InventoryXR - My.Settings.InventoryXL) / 4) * (j Mod 4)
                                    InvPositionY = My.Settings.InventoryYU + ((My.Settings.InventoryYD - My.Settings.InventoryYU) / 14) +
                                        ((My.Settings.InventoryYD - My.Settings.InventoryYU) / 7) * (Math.Floor(j / 4) Mod 7)
                                    ScreenX = RandomCoord.Next(InvPositionX - 7, InvPositionX + 7)
                                    ScreenY = RandomCoord.Next(InvPositionY - 7, InvPositionY + 7)
                                    SetCursorPos(ScreenX, ScreenY)
                                    delay(20)
                                    mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0)
                                    mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0)
                                    delay(RandomTime.Next(350, 700))
                                    Flag = True
                                    PrayerItemCount(j) = PrayerItemCount(j) - 1
                                End If
                            Next
                            SetCursorPos(OriginalMousePointX, OriginalMousePointY)
                        End If
                    End If
                    If btnPauseResume.Text = "Resume" Then
                        Do
                            delay(2000)
                            If Abort = DialogResult.OK Then
                                btnPauseResume.Text = "Pause"
                            End If
                        Loop Until btnPauseResume.Text = "Pause"
                    End If
                    If Abort = DialogResult.OK Then
                        ProgramExecuting = False
                        If txtEventLog.Text <> "" Then
                            txtEventLog.Text &= Environment.NewLine
                        End If
                        txtEventLog.Text &= TimeOfDay & ": Program '" & CStr(cmbLoadProgram.SelectedItem) & "' was aborted."
                        txtEventLog.SelectionStart = txtEventLog.TextLength
                        txtEventLog.ScrollToCaret()
                        Exit While
                    ElseIf Abort = DialogResult.Cancel Then
                        Abort = 0
                    End If
                    i += 1
                Next
                i = 0
            End If
            LoopCounter += 1
            If txtEventLog.Text <> "" Then
                txtEventLog.Text &= Environment.NewLine
            End If
            txtEventLog.Text &= TimeOfDay & ": Loop # " & LoopCounter & " / " & ProgramCounter & " completed."
            txtEventLog.SelectionStart = txtEventLog.TextLength
            txtEventLog.ScrollToCaret()
            ProgramExecuting = False
        End While
        For Each Ctrl As Control In Controls
            If TypeOf Ctrl Is Button And Ctrl.Name <> "btnAbort" And Ctrl.Name <> "btnPauseResume" And Ctrl.Name <> "btnHorSize" Then
                Ctrl.Enabled = True
            End If
        Next
        If Abort = 0 And VerifyFailed = False And LoopCounter = ProgramCounter Then
            If txtEventLog.Text <> "" Then
                txtEventLog.Text &= Environment.NewLine
            End If
            txtEventLog.Text &= TimeOfDay & ": Program '" & CStr(cmbLoadProgram.SelectedItem) & "' has completed successfully."
            txtEventLog.SelectionStart = txtEventLog.TextLength
            txtEventLog.ScrollToCaret()
        End If
        If Abort = 0 And VerifyFailed = False And elapsed > SixHourGameTimer Then
            If txtEventLog.Text <> "" Then
                txtEventLog.Text &= Environment.NewLine
            End If
            txtEventLog.Text &= TimeOfDay & ": Program '" & CStr(cmbLoadProgram.SelectedItem) & "' has exited due to 6-hour in-game limit after Loop # " & CStr(LoopCounter)
            txtEventLog.SelectionStart = txtEventLog.TextLength
            txtEventLog.ScrollToCaret()
        End If
        LoopCounter = 0
        Abort = 0
        VerifyFailed = False
        If ExitCoordsEnabled = True Then
            If txtEventLog.Text <> "" Then
                txtEventLog.Text &= Environment.NewLine
            End If
            txtEventLog.Text &= TimeOfDay & ": RuneScape client has been closed."
            txtEventLog.SelectionStart = txtEventLog.TextLength
            txtEventLog.ScrollToCaret()
            ExitGame()
        End If
    End Sub
#End Region
#Region "Misc."
    Dim Expanded As Boolean
    Private Sub btnExpandHor_Click(sender As Object, e As EventArgs) Handles btnHorSize.Click
        If Expanded = False Then
            Me.Width = 489
            Me.Height = 159
            btnHorSize.Text = "<"
            Expanded = True
            btnExit.Location = New Point(459, 3)
            pnlRightBorder.Location = New Point(488, 1)
            pnlHeader.Width = 483
        ElseIf Expanded = True Then
            Me.Width = 321
            Me.Height = 159
            btnHorSize.Text = ">"
            Expanded = False
            btnExit.Location = New Point(291, 3)
            pnlRightBorder.Location = New Point(320, 1)
            pnlHeader.Width = 315
        End If
    End Sub

    Private Sub lblCurrentGameTime_Click(sender As Object, e As EventArgs) Handles lblCurrentGameTime.Click
        frmInputBox.lblHeader.Text = "Update Game Timer"
        frmInputBox.lblInputText.Text = "Enter current game time in 0:00:00 format."
        If frmInputBox.ShowDialog() = DialogResult.OK Then
            Dim TimerString = Split(frmInputBox.txtInputEntry.Text, ":", 3)
            UpdateGameTimerHours = TimeSpan.FromHours(TimerString(0))
            UpdateGameTimerMinutes = TimeSpan.FromMinutes(TimerString(1))
            UpdateGameTimerSeconds = TimeSpan.FromSeconds(TimerString(2))
        Else
            Exit Sub
        End If
        Me.stopwatch.Reset()
        Me.stopwatch.Start()
    End Sub
    Private Sub GameTmr_Tick(sender As Object, e As EventArgs) Handles GameTmr.Tick
        elapsed = Me.stopwatch.Elapsed + UpdateGameTimerHours + UpdateGameTimerMinutes + UpdateGameTimerSeconds
        If elapsed <= TimeSpan.FromHours(6) Then
            lblCurrentGameTime.Text = String.Format("{0:0}:{1:00}:{2:00}", Math.Floor(elapsed.TotalHours), elapsed.Minutes, elapsed.Seconds)
        Else
            lblCurrentGameTime.Text = String.Format("{0:0}:{1:00}:{2:00}", 6, 0, 0)
        End If
    End Sub
    Private Sub lblGameTimer_Click(sender As Object, e As EventArgs) Handles lblGameTimer.Click
        frmMessageBox.lblHeader.Text = "Reset Game Timer?"
        frmMessageBox.lblMessageText.Text = "Reset in-game timer to 0:00:00?"
        If frmMessageBox.ShowDialog() = DialogResult.OK Then
            Me.stopwatch.Reset()
            UpdateGameTimerHours = TimeSpan.FromHours(0)
            UpdateGameTimerMinutes = TimeSpan.FromMinutes(0)
            UpdateGameTimerSeconds = TimeSpan.FromSeconds(0)
            Me.stopwatch.Start()
        End If
    End Sub
    Private Sub lblEventLog_Click(sender As Object, e As EventArgs) Handles lblEventLog.Click
        frmMessageBox.lblHeader.Text = "Event Log Set-Up"
        frmMessageBox.lblMessageText.Text = "Would You Like To Clear The Event Log?"
        If frmMessageBox.ShowDialog = DialogResult.OK Then
            txtEventLog.Clear()
        Else
            Exit Sub
        End If
    End Sub
    Private Sub btnSettings_Click(sender As Object, e As EventArgs) Handles btnSettings.Click
        frmSettings.Show()
    End Sub
    Private Sub btnEditProgram_Click(sender As Object, e As EventArgs) Handles btnEditProgram.Click
        Dim CurrentRow As String()
        Dim CurrentField As String
        Dim i As Integer = 0

        If cmbLoadProgram.SelectedItem = "" Then
            frmMessageBox.lblHeader.Text = "Edit Program Set-Up"
            frmMessageBox.lblMessageText.Text = "No Program Selected!"
            frmMessageBox.ShowDialog()
            Exit Sub
        End If
        If System.IO.File.Exists(DriveLetter & "RSAutoClicker\" & cmbLoadProgram.SelectedItem & "\" & cmbLoadProgram.SelectedItem & ".csv") = False Then
            frmMessageBox.lblHeader.Text = "Edit Program Set-Up"
            frmMessageBox.lblMessageText.Text = "No CSV File Found!"
            frmMessageBox.ShowDialog()
            Exit Sub
        End If
        frmSetUp.ButtonClicked = "btnEditProgram"
        Using MyReader As New Microsoft.VisualBasic.FileIO.TextFieldParser(DriveLetter & "RSAutoClicker\" & cmbLoadProgram.SelectedItem.ToString & "\" &
                                                                           cmbLoadProgram.SelectedItem.ToString & ".csv")
            MyReader.TextFieldType = FileIO.FieldType.Delimited
            MyReader.SetDelimiters(",")
            While Not MyReader.EndOfData
                CurrentRow = MyReader.ReadFields()
                For Each CurrentField In CurrentRow
                    Array.Resize(frmSetUp.NewProgram, i + 1)
                    frmSetUp.NewProgram(i) = CurrentField
                    i += 1
                Next
            End While
        End Using
        Me.Hide()
        frmSetUp.ProgramName = cmbLoadProgram.SelectedItem
        frmSetUp.Show()
    End Sub
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
    Private Sub btnMinimize_Click(sender As Object, e As EventArgs) Handles btnMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub cmbLoadProgram_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbLoadProgram.SelectedIndexChanged
        If System.IO.File.Exists(DriveLetter & "RSAutoClicker\" & cmbLoadProgram.SelectedItem & "\" & cmbLoadProgram.SelectedItem & "Click1.bmp") = False Then
            btnPictureTest.Enabled = False
        Else
            btnPictureTest.Enabled = True
        End If
    End Sub

    Private Sub btnTutorial_Click(sender As Object, e As EventArgs) Handles btnTutorial.Click
        delay(2000)
        mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0)
        delay(300000)
        mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0)
    End Sub

    Private Sub btnPictureTest_Click(sender As Object, e As EventArgs) Handles btnPictureTest.Click
        Dim TestProgram As String = cmbLoadProgram.SelectedItem
        Dim PixelMatchCount As Integer = 0
        Dim TotalPixels As Integer = 0
        Dim a As Bitmap
        Dim b As Bitmap
        Dim Wdt As Integer = 0
        If System.IO.File.Exists(DriveLetter & "RSAutoClicker\" & cmbLoadProgram.SelectedItem & "\" & cmbLoadProgram.SelectedItem & "Click1.bmp") = False Then
            btnPictureTest.Enabled = False
        Else
            btnPictureTest.Enabled = True
        End If
        If cmbLoadProgram.SelectedItem = "" Then
            If cmbLoadProgram.SelectedItem = "" Then
                frmMessageBox.lblHeader.Text = "Calibration Set-Up"
                frmMessageBox.lblMessageText.Text = "No Program Selected!"
                frmMessageBox.ShowDialog()
                Exit Sub
            End If
        End If
        If My.Settings.VerifyScreenXR = 0 Then
            frmMessageBox.lblHeader.Text = "Game Screen Set-Up Error"
            frmMessageBox.lblMessageText.Text = "This is not enabled until 'Verify Coords' is completed."
            frmMessageBox.ShowDialog()
            Exit Sub
        ElseIf My.Settings.VerifyScreenXR <> 0 Then
            For Each scr As Screen In Screen.AllScreens
                Wdt += scr.Bounds.Width
            Next
            Dim ScreenSizeTotal As Size = New Size(Wdt, My.Computer.Screen.Bounds.Height)
            Dim ScreenGrab1 As New Bitmap(Wdt, My.Computer.Screen.Bounds.Height)
            Dim g As Graphics = Graphics.FromImage(ScreenGrab1)
            g.CopyFromScreen(New Point(0, 0), New Point(0, 0), ScreenSizeTotal)
            If System.IO.File.Exists(DriveLetter & "RSAutoClicker\" & "TestClick.bmp") = True Then
                My.Computer.FileSystem.DeleteFile(DriveLetter & "RSAutoClicker\" & "TestClick.bmp")
            End If
            ScreenGrab1.Save(DriveLetter & "RSAutoClicker\" & "TestClick.bmp")
            a = New Bitmap(DriveLetter & "RSAutoClicker\" & TestProgram & "\" & TestProgram & "Click1.bmp")
            b = New Bitmap(DriveLetter & "RSAutoClicker\" & "TestClick.bmp")
            Dim ScreenRegion As New Bitmap(b.Width, b.Height, System.Drawing.Imaging.PixelFormat.Format32bppPArgb)
            For y As Integer = My.Settings.VerifyScreenYU To My.Settings.VerifyScreenYD - 1 Step 4
                For x = My.Settings.VerifyScreenXL To My.Settings.VerifyScreenXR - 1 Step 4
                    Dim aColor As Color = a.GetPixel(x, y)
                    Dim bColor As Color = b.GetPixel(x, y)
                    If aColor.ToArgb() = bColor.ToArgb() Then
                        PixelMatchCount += 1
                    End If
                    TotalPixels += 1
                Next
            Next
            a.Dispose()
            b.Dispose()
            Dim PicMatchPercentage = PixelMatchCount / TotalPixels
            txtPicMatchPercent.Text = String.Format("{0:0.0%}", PicMatchPercentage)
            My.Computer.FileSystem.DeleteFile(DriveLetter & "RSAutoClicker\" & "TestClick.bmp")
        End If
    End Sub
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If cmbLoadProgram.SelectedItem = "" Then
            frmMessageBox.lblHeader.Text = "Delete Program Set-Up"
            frmMessageBox.lblMessageText.Text = "No Program Selected!"
            frmMessageBox.ShowDialog()
            Exit Sub
        End If
        frmMessageBox.lblHeader.Text = "Delete Program Set-Up"
        frmMessageBox.lblMessageText.Text = "Are you absolutely sure you want to delete this program?"
        If frmMessageBox.ShowDialog() = DialogResult.OK Then
            If System.IO.Directory.Exists(DriveLetter & "RSAutoClicker\" & cmbLoadProgram.SelectedItem) = True Then
                For Each _file As String In System.IO.Directory.GetFiles(DriveLetter & "RSAutoClicker\" & cmbLoadProgram.SelectedItem)
                    System.IO.File.Delete(_file)
                Next
                System.IO.Directory.Delete(DriveLetter & "RSAutoClicker\" & cmbLoadProgram.SelectedItem)
            Else
                Exit Sub
            End If
            cmbLoadProgram.Items.Clear()
            For Each Folder In My.Computer.FileSystem.GetDirectories(DriveLetter & "RSAutoClicker")
                Folder = Mid(Folder, 18)
                cmbLoadProgram.Items.Add(Folder)
            Next
        End If
    End Sub
    Private Sub btnNewProgram_Click(sender As Object, e As EventArgs) Handles btnNewProgram.Click
        If DriveLetter <> "" Then
            frmSetUp.ButtonClicked = "btnNewProgram"
            frmSetUp.Show()
        Else
            If cmbLoadProgram.SelectedItem = "" Then
                frmMessageBox.lblHeader.Text = "New Program Set-Up"
                frmMessageBox.lblMessageText.Text = "No Drive Selected!"
                frmMessageBox.ShowDialog()
                Exit Sub
            End If
        End If
    End Sub
    Sub ExitGame()
        ScreenX = RandomCoord.Next(My.Settings.ExitScreenXL1, My.Settings.ExitScreenXR1)
        ScreenY = RandomCoord.Next(My.Settings.ExitScreenYU1, My.Settings.ExitScreenYD1)
        SetCursorPos(ScreenX, ScreenY)
        delay(50)
        mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0)
        mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0)
        delay(RandomTime.Next(2000, 4000))
        ScreenX = RandomCoord.Next(My.Settings.ExitScreenXL2, My.Settings.ExitScreenXR2)
        ScreenY = RandomCoord.Next(My.Settings.ExitScreenYU2, My.Settings.ExitScreenYD2)
        SetCursorPos(ScreenX, ScreenY)
        delay(50)
        mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0)
        mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0)
    End Sub
#End Region
End Class