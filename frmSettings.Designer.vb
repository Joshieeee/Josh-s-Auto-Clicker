<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSettings
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSettings))
        Me.btnEditVerifyScreen = New System.Windows.Forms.Button()
        Me.btnEditExitCoords = New System.Windows.Forms.Button()
        Me.cboxAlwaysTop = New System.Windows.Forms.CheckBox()
        Me.CBoxExit = New System.Windows.Forms.CheckBox()
        Me.cbDriveList = New System.Windows.Forms.ComboBox()
        Me.tbResolution = New System.Windows.Forms.TrackBar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnInvCoords = New System.Windows.Forms.Button()
        Me.btnHealItems = New System.Windows.Forms.Button()
        Me.btnPrayerItems = New System.Windows.Forms.Button()
        Me.lblDriveLetter = New System.Windows.Forms.Label()
        Me.btnPrayerCoords = New System.Windows.Forms.Button()
        Me.btnInvDropSlots = New System.Windows.Forms.Button()
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.pnlTBBack = New System.Windows.Forms.Panel()
        Me.lblhexRangeMax = New System.Windows.Forms.Label()
        Me.lblHexRangeMin = New System.Windows.Forms.Label()
        Me.lblHexTimeMax = New System.Windows.Forms.Label()
        Me.lblHexTimeMin = New System.Windows.Forms.Label()
        Me.lblOpacMax = New System.Windows.Forms.Label()
        Me.lblOpacMin = New System.Windows.Forms.Label()
        Me.lblResMin = New System.Windows.Forms.Label()
        Me.lblResMax = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblMaxCheckTime = New System.Windows.Forms.Label()
        Me.lblOpacity = New System.Windows.Forms.Label()
        Me.tbHexRange = New System.Windows.Forms.TrackBar()
        Me.tbMaxCheckTime = New System.Windows.Forms.TrackBar()
        Me.tbOpacity = New System.Windows.Forms.TrackBar()
        Me.pnlTBDivider = New System.Windows.Forms.Panel()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.pnlTopBorder = New System.Windows.Forms.Panel()
        Me.pnlLeftBorder = New System.Windows.Forms.Panel()
        Me.pnlBottomBorder = New System.Windows.Forms.Panel()
        Me.pnlRightBorder = New System.Windows.Forms.Panel()
        Me.btnHealItemCoords = New System.Windows.Forms.Button()
        CType(Me.tbResolution, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlHeader.SuspendLayout()
        Me.pnlTBBack.SuspendLayout()
        CType(Me.tbHexRange, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbMaxCheckTime, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbOpacity, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnEditVerifyScreen
        '
        Me.btnEditVerifyScreen.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.btnEditVerifyScreen.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditVerifyScreen.Location = New System.Drawing.Point(235, 65)
        Me.btnEditVerifyScreen.Name = "btnEditVerifyScreen"
        Me.btnEditVerifyScreen.Size = New System.Drawing.Size(107, 23)
        Me.btnEditVerifyScreen.TabIndex = 1021
        Me.btnEditVerifyScreen.Text = "Verify Coords"
        Me.ToolTip1.SetToolTip(Me.btnEditVerifyScreen, "Set-Up to enter coords for screen verification.")
        Me.btnEditVerifyScreen.UseVisualStyleBackColor = False
        '
        'btnEditExitCoords
        '
        Me.btnEditExitCoords.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.btnEditExitCoords.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditExitCoords.Location = New System.Drawing.Point(345, 65)
        Me.btnEditExitCoords.Name = "btnEditExitCoords"
        Me.btnEditExitCoords.Size = New System.Drawing.Size(107, 23)
        Me.btnEditExitCoords.TabIndex = 1022
        Me.btnEditExitCoords.Text = "Exit Coords"
        Me.ToolTip1.SetToolTip(Me.btnEditExitCoords, "Set-Up to enter coordinates to Exit Game")
        Me.btnEditExitCoords.UseVisualStyleBackColor = False
        '
        'cboxAlwaysTop
        '
        Me.cboxAlwaysTop.AutoSize = True
        Me.cboxAlwaysTop.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboxAlwaysTop.Location = New System.Drawing.Point(141, 98)
        Me.cboxAlwaysTop.Name = "cboxAlwaysTop"
        Me.cboxAlwaysTop.Size = New System.Drawing.Size(106, 20)
        Me.cboxAlwaysTop.TabIndex = 1052
        Me.cboxAlwaysTop.Text = "Always On Top"
        Me.ToolTip1.SetToolTip(Me.cboxAlwaysTop, "Only use while running a Program")
        Me.cboxAlwaysTop.UseVisualStyleBackColor = True
        '
        'CBoxExit
        '
        Me.CBoxExit.AutoSize = True
        Me.CBoxExit.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBoxExit.Location = New System.Drawing.Point(253, 98)
        Me.CBoxExit.Name = "CBoxExit"
        Me.CBoxExit.Size = New System.Drawing.Size(128, 20)
        Me.CBoxExit.TabIndex = 1053
        Me.CBoxExit.Text = "Exit When Complete"
        Me.ToolTip1.SetToolTip(Me.CBoxExit, "Exits game when Program completes")
        Me.CBoxExit.UseVisualStyleBackColor = True
        '
        'cbDriveList
        '
        Me.cbDriveList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbDriveList.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbDriveList.FormattingEnabled = True
        Me.cbDriveList.Location = New System.Drawing.Point(87, 96)
        Me.cbDriveList.Name = "cbDriveList"
        Me.cbDriveList.Size = New System.Drawing.Size(37, 24)
        Me.cbDriveList.TabIndex = 0
        '
        'tbResolution
        '
        Me.tbResolution.BackColor = System.Drawing.SystemColors.ControlDark
        Me.tbResolution.LargeChange = 1
        Me.tbResolution.Location = New System.Drawing.Point(12, 23)
        Me.tbResolution.Maximum = 6
        Me.tbResolution.Minimum = 1
        Me.tbResolution.Name = "tbResolution"
        Me.tbResolution.Size = New System.Drawing.Size(108, 45)
        Me.tbResolution.TabIndex = 1061
        Me.ToolTip1.SetToolTip(Me.tbResolution, "Determines how many pixels are checked during Screen Verification." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "1 = every pix" &
        "el." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "6 = every 36 pixels.")
        Me.tbResolution.Value = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Label1.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(36, 130)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 16)
        Me.Label1.TabIndex = 1062
        Me.Label1.Text = "Resolution"
        Me.ToolTip1.SetToolTip(Me.Label1, "Determines how many pixels are checked during Screen Verification." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "1 = every pix" &
        "el." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "6 = every 36 pixels.")
        '
        'btnInvCoords
        '
        Me.btnInvCoords.BackColor = System.Drawing.SystemColors.ControlDark
        Me.btnInvCoords.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInvCoords.Location = New System.Drawing.Point(9, 37)
        Me.btnInvCoords.Name = "btnInvCoords"
        Me.btnInvCoords.Size = New System.Drawing.Size(107, 23)
        Me.btnInvCoords.TabIndex = 1063
        Me.btnInvCoords.Text = "Inventory Coords"
        Me.ToolTip1.SetToolTip(Me.btnInvCoords, "Set-Up to enter coordinates of Player Inventory.")
        Me.btnInvCoords.UseVisualStyleBackColor = False
        '
        'btnHealItems
        '
        Me.btnHealItems.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.btnHealItems.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHealItems.Location = New System.Drawing.Point(345, 37)
        Me.btnHealItems.Name = "btnHealItems"
        Me.btnHealItems.Size = New System.Drawing.Size(107, 23)
        Me.btnHealItems.TabIndex = 1064
        Me.btnHealItems.Text = "Heal Item Slots"
        Me.ToolTip1.SetToolTip(Me.btnHealItems, "Set-Up to determine what item slots have Healing Items.")
        Me.btnHealItems.UseVisualStyleBackColor = False
        '
        'btnPrayerItems
        '
        Me.btnPrayerItems.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.btnPrayerItems.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrayerItems.Location = New System.Drawing.Point(122, 65)
        Me.btnPrayerItems.Name = "btnPrayerItems"
        Me.btnPrayerItems.Size = New System.Drawing.Size(107, 23)
        Me.btnPrayerItems.TabIndex = 1065
        Me.btnPrayerItems.Text = "Prayer Item Slots"
        Me.ToolTip1.SetToolTip(Me.btnPrayerItems, "Set-Up to determine what item slots have Prayer Potions.")
        Me.btnPrayerItems.UseVisualStyleBackColor = False
        '
        'lblDriveLetter
        '
        Me.lblDriveLetter.AutoSize = True
        Me.lblDriveLetter.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDriveLetter.Location = New System.Drawing.Point(9, 100)
        Me.lblDriveLetter.Name = "lblDriveLetter"
        Me.lblDriveLetter.Size = New System.Drawing.Size(71, 16)
        Me.lblDriveLetter.TabIndex = 1066
        Me.lblDriveLetter.Text = "Drive Letter:"
        Me.ToolTip1.SetToolTip(Me.lblDriveLetter, "Drive on Computer all Files will be saved to & loaded from.")
        '
        'btnPrayerCoords
        '
        Me.btnPrayerCoords.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.btnPrayerCoords.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrayerCoords.Location = New System.Drawing.Point(10, 65)
        Me.btnPrayerCoords.Name = "btnPrayerCoords"
        Me.btnPrayerCoords.Size = New System.Drawing.Size(107, 23)
        Me.btnPrayerCoords.TabIndex = 1067
        Me.btnPrayerCoords.Text = "Prayer Coords"
        Me.btnPrayerCoords.UseVisualStyleBackColor = False
        '
        'btnInvDropSlots
        '
        Me.btnInvDropSlots.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.btnInvDropSlots.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInvDropSlots.Location = New System.Drawing.Point(122, 37)
        Me.btnInvDropSlots.Name = "btnInvDropSlots"
        Me.btnInvDropSlots.Size = New System.Drawing.Size(107, 23)
        Me.btnInvDropSlots.TabIndex = 1068
        Me.btnInvDropSlots.Text = "Item Drop Slots"
        Me.ToolTip1.SetToolTip(Me.btnInvDropSlots, "Set-Up to determine what item slots should be dropped on full Inventory.")
        Me.btnInvDropSlots.UseVisualStyleBackColor = False
        '
        'pnlHeader
        '
        Me.pnlHeader.BackColor = System.Drawing.Color.Maroon
        Me.pnlHeader.Controls.Add(Me.btnExit)
        Me.pnlHeader.Controls.Add(Me.lblHeader)
        Me.pnlHeader.Location = New System.Drawing.Point(3, 3)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(462, 27)
        Me.pnlHeader.TabIndex = 1073
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Palatino Linotype", 6.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(438, 3)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(21, 21)
        Me.btnExit.TabIndex = 1
        Me.btnExit.Text = "X"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblHeader
        '
        Me.lblHeader.AutoSize = True
        Me.lblHeader.Font = New System.Drawing.Font("Palatino Linotype", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeader.Location = New System.Drawing.Point(3, 3)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(61, 20)
        Me.lblHeader.TabIndex = 0
        Me.lblHeader.Text = "Settings"
        '
        'pnlTBBack
        '
        Me.pnlTBBack.BackColor = System.Drawing.SystemColors.ControlDark
        Me.pnlTBBack.Controls.Add(Me.lblhexRangeMax)
        Me.pnlTBBack.Controls.Add(Me.lblHexRangeMin)
        Me.pnlTBBack.Controls.Add(Me.lblHexTimeMax)
        Me.pnlTBBack.Controls.Add(Me.lblHexTimeMin)
        Me.pnlTBBack.Controls.Add(Me.lblOpacMax)
        Me.pnlTBBack.Controls.Add(Me.lblOpacMin)
        Me.pnlTBBack.Controls.Add(Me.lblResMin)
        Me.pnlTBBack.Controls.Add(Me.lblResMax)
        Me.pnlTBBack.Controls.Add(Me.Label2)
        Me.pnlTBBack.Controls.Add(Me.lblMaxCheckTime)
        Me.pnlTBBack.Controls.Add(Me.lblOpacity)
        Me.pnlTBBack.Controls.Add(Me.tbHexRange)
        Me.pnlTBBack.Controls.Add(Me.tbMaxCheckTime)
        Me.pnlTBBack.Controls.Add(Me.tbResolution)
        Me.pnlTBBack.Controls.Add(Me.tbOpacity)
        Me.pnlTBBack.Location = New System.Drawing.Point(0, 125)
        Me.pnlTBBack.Name = "pnlTBBack"
        Me.pnlTBBack.Size = New System.Drawing.Size(468, 67)
        Me.pnlTBBack.TabIndex = 2000
        '
        'lblhexRangeMax
        '
        Me.lblhexRangeMax.AutoSize = True
        Me.lblhexRangeMax.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblhexRangeMax.Location = New System.Drawing.Point(432, 52)
        Me.lblhexRangeMax.Name = "lblhexRangeMax"
        Me.lblhexRangeMax.Size = New System.Drawing.Size(20, 16)
        Me.lblhexRangeMax.TabIndex = 1094
        Me.lblhexRangeMax.Text = "10"
        '
        'lblHexRangeMin
        '
        Me.lblHexRangeMin.AutoSize = True
        Me.lblHexRangeMin.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHexRangeMin.Location = New System.Drawing.Point(354, 52)
        Me.lblHexRangeMin.Name = "lblHexRangeMin"
        Me.lblHexRangeMin.Size = New System.Drawing.Size(14, 16)
        Me.lblHexRangeMin.TabIndex = 1093
        Me.lblHexRangeMin.Text = "1"
        '
        'lblHexTimeMax
        '
        Me.lblHexTimeMax.AutoSize = True
        Me.lblHexTimeMax.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHexTimeMax.Location = New System.Drawing.Point(322, 52)
        Me.lblHexTimeMax.Name = "lblHexTimeMax"
        Me.lblHexTimeMax.Size = New System.Drawing.Size(20, 16)
        Me.lblHexTimeMax.TabIndex = 1092
        Me.lblHexTimeMax.Text = "30"
        '
        'lblHexTimeMin
        '
        Me.lblHexTimeMin.AutoSize = True
        Me.lblHexTimeMin.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHexTimeMin.Location = New System.Drawing.Point(245, 52)
        Me.lblHexTimeMin.Name = "lblHexTimeMin"
        Me.lblHexTimeMin.Size = New System.Drawing.Size(14, 16)
        Me.lblHexTimeMin.TabIndex = 1091
        Me.lblHexTimeMin.Text = "5"
        '
        'lblOpacMax
        '
        Me.lblOpacMax.AutoSize = True
        Me.lblOpacMax.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOpacMax.Location = New System.Drawing.Point(197, 52)
        Me.lblOpacMax.Name = "lblOpacMax"
        Me.lblOpacMax.Size = New System.Drawing.Size(35, 16)
        Me.lblOpacMax.TabIndex = 1090
        Me.lblOpacMax.Text = "100%"
        '
        'lblOpacMin
        '
        Me.lblOpacMin.AutoSize = True
        Me.lblOpacMin.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOpacMin.Location = New System.Drawing.Point(119, 52)
        Me.lblOpacMin.Name = "lblOpacMin"
        Me.lblOpacMin.Size = New System.Drawing.Size(29, 16)
        Me.lblOpacMin.TabIndex = 1088
        Me.lblOpacMin.Text = "40%"
        '
        'lblResMin
        '
        Me.lblResMin.AutoSize = True
        Me.lblResMin.BackColor = System.Drawing.SystemColors.ControlDark
        Me.lblResMin.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResMin.Location = New System.Drawing.Point(18, 52)
        Me.lblResMin.Name = "lblResMin"
        Me.lblResMin.Size = New System.Drawing.Size(14, 16)
        Me.lblResMin.TabIndex = 1087
        Me.lblResMin.Text = "1"
        '
        'lblResMax
        '
        Me.lblResMax.AutoSize = True
        Me.lblResMax.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResMax.Location = New System.Drawing.Point(99, 52)
        Me.lblResMax.Name = "lblResMax"
        Me.lblResMax.Size = New System.Drawing.Size(14, 16)
        Me.lblResMax.TabIndex = 1089
        Me.lblResMax.Text = "6"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Label2.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(370, 5)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 16)
        Me.Label2.TabIndex = 1086
        Me.Label2.Text = "Hex Range"
        Me.ToolTip1.SetToolTip(Me.Label2, "Range Program searches for pixel change.")
        '
        'lblMaxCheckTime
        '
        Me.lblMaxCheckTime.AutoSize = True
        Me.lblMaxCheckTime.BackColor = System.Drawing.SystemColors.ControlDark
        Me.lblMaxCheckTime.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMaxCheckTime.Location = New System.Drawing.Point(264, 5)
        Me.lblMaxCheckTime.Name = "lblMaxCheckTime"
        Me.lblMaxCheckTime.Size = New System.Drawing.Size(56, 16)
        Me.lblMaxCheckTime.TabIndex = 1085
        Me.lblMaxCheckTime.Text = "Hex Time"
        Me.ToolTip1.SetToolTip(Me.lblMaxCheckTime, "Time Program searches for Hex change before continuing Program.")
        '
        'lblOpacity
        '
        Me.lblOpacity.AutoSize = True
        Me.lblOpacity.BackColor = System.Drawing.SystemColors.ControlDark
        Me.lblOpacity.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOpacity.Location = New System.Drawing.Point(151, 5)
        Me.lblOpacity.Name = "lblOpacity"
        Me.lblOpacity.Size = New System.Drawing.Size(47, 16)
        Me.lblOpacity.TabIndex = 1084
        Me.lblOpacity.Text = "Opacity"
        Me.ToolTip1.SetToolTip(Me.lblOpacity, "Alters opactiy of Program." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Recommended during New Program Set-Up.")
        '
        'tbHexRange
        '
        Me.tbHexRange.BackColor = System.Drawing.SystemColors.ControlDark
        Me.tbHexRange.LargeChange = 1
        Me.tbHexRange.Location = New System.Drawing.Point(347, 24)
        Me.tbHexRange.Minimum = 1
        Me.tbHexRange.Name = "tbHexRange"
        Me.tbHexRange.Size = New System.Drawing.Size(108, 45)
        Me.tbHexRange.TabIndex = 1083
        Me.ToolTip1.SetToolTip(Me.tbHexRange, "Range Program searches for pixel change.")
        Me.tbHexRange.Value = 10
        '
        'tbMaxCheckTime
        '
        Me.tbMaxCheckTime.BackColor = System.Drawing.SystemColors.ControlDark
        Me.tbMaxCheckTime.Location = New System.Drawing.Point(238, 23)
        Me.tbMaxCheckTime.Maximum = 30
        Me.tbMaxCheckTime.Minimum = 10
        Me.tbMaxCheckTime.Name = "tbMaxCheckTime"
        Me.tbMaxCheckTime.Size = New System.Drawing.Size(108, 45)
        Me.tbMaxCheckTime.SmallChange = 5
        Me.tbMaxCheckTime.TabIndex = 1082
        Me.tbMaxCheckTime.TickFrequency = 5
        Me.ToolTip1.SetToolTip(Me.tbMaxCheckTime, "Time Program searches for Hex change before continuing Program.")
        Me.tbMaxCheckTime.Value = 30
        '
        'tbOpacity
        '
        Me.tbOpacity.BackColor = System.Drawing.SystemColors.ControlDark
        Me.tbOpacity.LargeChange = 1
        Me.tbOpacity.Location = New System.Drawing.Point(120, 23)
        Me.tbOpacity.Minimum = 4
        Me.tbOpacity.Name = "tbOpacity"
        Me.tbOpacity.Size = New System.Drawing.Size(108, 45)
        Me.tbOpacity.TabIndex = 1081
        Me.ToolTip1.SetToolTip(Me.tbOpacity, "Alters opactiy of Program." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Recommended during New Program Set-Up.")
        Me.tbOpacity.Value = 10
        '
        'pnlTBDivider
        '
        Me.pnlTBDivider.BackColor = System.Drawing.Color.Maroon
        Me.pnlTBDivider.Location = New System.Drawing.Point(2, 125)
        Me.pnlTBDivider.Name = "pnlTBDivider"
        Me.pnlTBDivider.Size = New System.Drawing.Size(464, 1)
        Me.pnlTBDivider.TabIndex = 1075
        '
        'ToolTip1
        '
        Me.ToolTip1.AutoPopDelay = 20000
        Me.ToolTip1.InitialDelay = 500
        Me.ToolTip1.ReshowDelay = 100
        '
        'pnlTopBorder
        '
        Me.pnlTopBorder.BackColor = System.Drawing.Color.Black
        Me.pnlTopBorder.Location = New System.Drawing.Point(0, 0)
        Me.pnlTopBorder.Name = "pnlTopBorder"
        Me.pnlTopBorder.Size = New System.Drawing.Size(468, 1)
        Me.pnlTopBorder.TabIndex = 1076
        '
        'pnlLeftBorder
        '
        Me.pnlLeftBorder.BackColor = System.Drawing.Color.Black
        Me.pnlLeftBorder.Location = New System.Drawing.Point(0, 1)
        Me.pnlLeftBorder.Name = "pnlLeftBorder"
        Me.pnlLeftBorder.Size = New System.Drawing.Size(1, 193)
        Me.pnlLeftBorder.TabIndex = 1077
        '
        'pnlBottomBorder
        '
        Me.pnlBottomBorder.BackColor = System.Drawing.Color.Black
        Me.pnlBottomBorder.Location = New System.Drawing.Point(1, 193)
        Me.pnlBottomBorder.Name = "pnlBottomBorder"
        Me.pnlBottomBorder.Size = New System.Drawing.Size(467, 1)
        Me.pnlBottomBorder.TabIndex = 1078
        '
        'pnlRightBorder
        '
        Me.pnlRightBorder.BackColor = System.Drawing.Color.Black
        Me.pnlRightBorder.Location = New System.Drawing.Point(467, 1)
        Me.pnlRightBorder.Name = "pnlRightBorder"
        Me.pnlRightBorder.Size = New System.Drawing.Size(1, 192)
        Me.pnlRightBorder.TabIndex = 1079
        '
        'btnHealItemCoords
        '
        Me.btnHealItemCoords.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.btnHealItemCoords.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHealItemCoords.Location = New System.Drawing.Point(235, 37)
        Me.btnHealItemCoords.Name = "btnHealItemCoords"
        Me.btnHealItemCoords.Size = New System.Drawing.Size(107, 23)
        Me.btnHealItemCoords.TabIndex = 2001
        Me.btnHealItemCoords.Text = "Healing Coords."
        Me.btnHealItemCoords.UseVisualStyleBackColor = False
        '
        'frmSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.ClientSize = New System.Drawing.Size(468, 194)
        Me.Controls.Add(Me.btnHealItemCoords)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pnlRightBorder)
        Me.Controls.Add(Me.pnlBottomBorder)
        Me.Controls.Add(Me.pnlLeftBorder)
        Me.Controls.Add(Me.pnlTopBorder)
        Me.Controls.Add(Me.pnlTBDivider)
        Me.Controls.Add(Me.pnlHeader)
        Me.Controls.Add(Me.btnInvDropSlots)
        Me.Controls.Add(Me.btnPrayerCoords)
        Me.Controls.Add(Me.lblDriveLetter)
        Me.Controls.Add(Me.btnPrayerItems)
        Me.Controls.Add(Me.btnHealItems)
        Me.Controls.Add(Me.btnInvCoords)
        Me.Controls.Add(Me.cbDriveList)
        Me.Controls.Add(Me.CBoxExit)
        Me.Controls.Add(Me.cboxAlwaysTop)
        Me.Controls.Add(Me.btnEditExitCoords)
        Me.Controls.Add(Me.btnEditVerifyScreen)
        Me.Controls.Add(Me.pnlTBBack)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSettings"
        Me.Text = "Settings"
        CType(Me.tbResolution, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        Me.pnlTBBack.ResumeLayout(False)
        Me.pnlTBBack.PerformLayout()
        CType(Me.tbHexRange, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbMaxCheckTime, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbOpacity, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnEditVerifyScreen As Button
    Friend WithEvents btnEditExitCoords As Button
    Friend WithEvents cboxAlwaysTop As CheckBox
    Friend WithEvents CBoxExit As CheckBox
    Friend WithEvents cbDriveList As ComboBox
    Friend WithEvents tbResolution As TrackBar
    Friend WithEvents Label1 As Label
    Friend WithEvents btnInvCoords As Button
    Friend WithEvents btnHealItems As Button
    Friend WithEvents btnPrayerItems As Button
    Friend WithEvents lblDriveLetter As Label
    Friend WithEvents btnPrayerCoords As Button
    Friend WithEvents btnInvDropSlots As Button
    Friend WithEvents pnlHeader As Panel
    Friend WithEvents btnExit As Button
    Friend WithEvents lblHeader As Label
    Friend WithEvents pnlTBBack As Panel
    Friend WithEvents pnlTBDivider As Panel
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents pnlTopBorder As Panel
    Friend WithEvents pnlLeftBorder As Panel
    Friend WithEvents pnlBottomBorder As Panel
    Friend WithEvents pnlRightBorder As Panel
    Friend WithEvents lblHexTimeMin As Label
    Friend WithEvents lblOpacMax As Label
    Friend WithEvents lblOpacMin As Label
    Friend WithEvents lblResMin As Label
    Friend WithEvents lblResMax As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblMaxCheckTime As Label
    Friend WithEvents lblOpacity As Label
    Friend WithEvents tbHexRange As TrackBar
    Friend WithEvents tbMaxCheckTime As TrackBar
    Friend WithEvents tbOpacity As TrackBar
    Friend WithEvents lblhexRangeMax As Label
    Friend WithEvents lblHexRangeMin As Label
    Friend WithEvents lblHexTimeMax As Label
    Friend WithEvents btnHealItemCoords As Button
End Class
