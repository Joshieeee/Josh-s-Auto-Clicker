<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSetUp
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSetUp))
        Me.cmbClickNmbr = New System.Windows.Forms.ComboBox()
        Me.lblClickNmbr = New System.Windows.Forms.Label()
        Me.btnGetClickCoords = New System.Windows.Forms.Button()
        Me.btnAddClick = New System.Windows.Forms.Button()
        Me.txtXLeft = New System.Windows.Forms.TextBox()
        Me.txtYUp = New System.Windows.Forms.TextBox()
        Me.txtYDown = New System.Windows.Forms.TextBox()
        Me.txtXRight = New System.Windows.Forms.TextBox()
        Me.lblX1 = New System.Windows.Forms.Label()
        Me.lblX2 = New System.Windows.Forms.Label()
        Me.lblY1 = New System.Windows.Forms.Label()
        Me.lblY2 = New System.Windows.Forms.Label()
        Me.btnDeleteClick = New System.Windows.Forms.Button()
        Me.btnSaveClick = New System.Windows.Forms.Button()
        Me.cbDropInv = New System.Windows.Forms.CheckBox()
        Me.cbHealingItem = New System.Windows.Forms.CheckBox()
        Me.cbPrayerPotion = New System.Windows.Forms.CheckBox()
        Me.cbRightClick = New System.Windows.Forms.CheckBox()
        Me.cbPictureVerify = New System.Windows.Forms.CheckBox()
        Me.cmbStartCondition = New System.Windows.Forms.ComboBox()
        Me.lblStartCondition = New System.Windows.Forms.Label()
        Me.lblEndCondition = New System.Windows.Forms.Label()
        Me.cmbEndCondition = New System.Windows.Forms.ComboBox()
        Me.txtDelayHexStart = New System.Windows.Forms.TextBox()
        Me.txtBufferRangeStart = New System.Windows.Forms.TextBox()
        Me.lblDelayHexStart = New System.Windows.Forms.Label()
        Me.lblBufferRangeStart = New System.Windows.Forms.Label()
        Me.txtDelayHexEnd = New System.Windows.Forms.TextBox()
        Me.txtBufferRangeEnd = New System.Windows.Forms.TextBox()
        Me.lblDelayHexEnd = New System.Windows.Forms.Label()
        Me.lblBufferRangeEnd = New System.Windows.Forms.Label()
        Me.btnSaveProgram = New System.Windows.Forms.Button()
        Me.btnCancelProg = New System.Windows.Forms.Button()
        Me.btnGetHexEnd = New System.Windows.Forms.Button()
        Me.btnGetHexStart = New System.Windows.Forms.Button()
        Me.ToolTipHelp = New System.Windows.Forms.ToolTip(Me.components)
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.pnlTopBorder = New System.Windows.Forms.Panel()
        Me.pnlLeftBorder = New System.Windows.Forms.Panel()
        Me.pnlBottomBorder = New System.Windows.Forms.Panel()
        Me.pnlRightBorder = New System.Windows.Forms.Panel()
        Me.pnlHeader.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmbClickNmbr
        '
        Me.cmbClickNmbr.DropDownHeight = 98
        Me.cmbClickNmbr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbClickNmbr.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbClickNmbr.FormattingEnabled = True
        Me.cmbClickNmbr.IntegralHeight = False
        Me.cmbClickNmbr.Location = New System.Drawing.Point(6, 52)
        Me.cmbClickNmbr.MaxDropDownItems = 100
        Me.cmbClickNmbr.Name = "cmbClickNmbr"
        Me.cmbClickNmbr.Size = New System.Drawing.Size(81, 24)
        Me.cmbClickNmbr.TabIndex = 0
        '
        'lblClickNmbr
        '
        Me.lblClickNmbr.AutoSize = True
        Me.lblClickNmbr.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClickNmbr.Location = New System.Drawing.Point(9, 33)
        Me.lblClickNmbr.Name = "lblClickNmbr"
        Me.lblClickNmbr.Size = New System.Drawing.Size(77, 16)
        Me.lblClickNmbr.TabIndex = 1
        Me.lblClickNmbr.Text = "Click Number"
        '
        'btnGetClickCoords
        '
        Me.btnGetClickCoords.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGetClickCoords.Location = New System.Drawing.Point(5, 83)
        Me.btnGetClickCoords.Name = "btnGetClickCoords"
        Me.btnGetClickCoords.Size = New System.Drawing.Size(83, 45)
        Me.btnGetClickCoords.TabIndex = 14
        Me.btnGetClickCoords.Text = "Get" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Coordinates"
        Me.ToolTipHelp.SetToolTip(Me.btnGetClickCoords, "Click to obtain coordinates for selected Click.")
        Me.btnGetClickCoords.UseVisualStyleBackColor = True
        '
        'btnAddClick
        '
        Me.btnAddClick.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddClick.Location = New System.Drawing.Point(263, 119)
        Me.btnAddClick.Name = "btnAddClick"
        Me.btnAddClick.Size = New System.Drawing.Size(57, 40)
        Me.btnAddClick.TabIndex = 15
        Me.btnAddClick.Text = "Add Click"
        Me.ToolTipHelp.SetToolTip(Me.btnAddClick, "Click to Add an additional Click to Program.")
        Me.btnAddClick.UseVisualStyleBackColor = True
        '
        'txtXLeft
        '
        Me.txtXLeft.AcceptsReturn = True
        Me.txtXLeft.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtXLeft.Location = New System.Drawing.Point(265, 53)
        Me.txtXLeft.Name = "txtXLeft"
        Me.txtXLeft.Size = New System.Drawing.Size(55, 22)
        Me.txtXLeft.TabIndex = 16
        Me.txtXLeft.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtYUp
        '
        Me.txtYUp.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtYUp.Location = New System.Drawing.Point(265, 94)
        Me.txtYUp.Name = "txtYUp"
        Me.txtYUp.Size = New System.Drawing.Size(55, 22)
        Me.txtYUp.TabIndex = 17
        Me.txtYUp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtYDown
        '
        Me.txtYDown.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtYDown.Location = New System.Drawing.Point(326, 94)
        Me.txtYDown.Name = "txtYDown"
        Me.txtYDown.Size = New System.Drawing.Size(55, 22)
        Me.txtYDown.TabIndex = 19
        Me.txtYDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtXRight
        '
        Me.txtXRight.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtXRight.Location = New System.Drawing.Point(326, 53)
        Me.txtXRight.Name = "txtXRight"
        Me.txtXRight.Size = New System.Drawing.Size(55, 22)
        Me.txtXRight.TabIndex = 18
        Me.txtXRight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblX1
        '
        Me.lblX1.AutoSize = True
        Me.lblX1.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblX1.Location = New System.Drawing.Point(265, 33)
        Me.lblX1.Name = "lblX1"
        Me.lblX1.Size = New System.Drawing.Size(56, 16)
        Me.lblX1.TabIndex = 20
        Me.lblX1.Text = "X1 Coord"
        '
        'lblX2
        '
        Me.lblX2.AutoSize = True
        Me.lblX2.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblX2.Location = New System.Drawing.Point(326, 33)
        Me.lblX2.Name = "lblX2"
        Me.lblX2.Size = New System.Drawing.Size(56, 16)
        Me.lblX2.TabIndex = 21
        Me.lblX2.Text = "X2 Coord"
        '
        'lblY1
        '
        Me.lblY1.AutoSize = True
        Me.lblY1.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblY1.Location = New System.Drawing.Point(264, 78)
        Me.lblY1.Name = "lblY1"
        Me.lblY1.Size = New System.Drawing.Size(56, 16)
        Me.lblY1.TabIndex = 22
        Me.lblY1.Text = "Y1 Coord"
        '
        'lblY2
        '
        Me.lblY2.AutoSize = True
        Me.lblY2.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblY2.Location = New System.Drawing.Point(325, 78)
        Me.lblY2.Name = "lblY2"
        Me.lblY2.Size = New System.Drawing.Size(56, 16)
        Me.lblY2.TabIndex = 23
        Me.lblY2.Text = "Y2 Coord"
        '
        'btnDeleteClick
        '
        Me.btnDeleteClick.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeleteClick.Location = New System.Drawing.Point(5, 134)
        Me.btnDeleteClick.Name = "btnDeleteClick"
        Me.btnDeleteClick.Size = New System.Drawing.Size(83, 25)
        Me.btnDeleteClick.TabIndex = 24
        Me.btnDeleteClick.Text = "Delete Click"
        Me.ToolTipHelp.SetToolTip(Me.btnDeleteClick, "Click to Delete selected Click.")
        Me.btnDeleteClick.UseVisualStyleBackColor = True
        '
        'btnSaveClick
        '
        Me.btnSaveClick.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveClick.Location = New System.Drawing.Point(326, 119)
        Me.btnSaveClick.Name = "btnSaveClick"
        Me.btnSaveClick.Size = New System.Drawing.Size(55, 40)
        Me.btnSaveClick.TabIndex = 25
        Me.btnSaveClick.Text = "Save Click"
        Me.ToolTipHelp.SetToolTip(Me.btnSaveClick, "Click to Save selected Click.")
        Me.btnSaveClick.UseVisualStyleBackColor = True
        '
        'cbDropInv
        '
        Me.cbDropInv.AutoSize = True
        Me.cbDropInv.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbDropInv.Location = New System.Drawing.Point(387, 50)
        Me.cbDropInv.Name = "cbDropInv"
        Me.cbDropInv.Size = New System.Drawing.Size(105, 20)
        Me.cbDropInv.TabIndex = 26
        Me.cbDropInv.Text = "Drop Inventory"
        Me.ToolTipHelp.SetToolTip(Me.cbDropInv, "Select to drop selected Inventory after selected Click.")
        Me.cbDropInv.UseVisualStyleBackColor = True
        '
        'cbHealingItem
        '
        Me.cbHealingItem.AutoSize = True
        Me.cbHealingItem.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbHealingItem.Location = New System.Drawing.Point(387, 72)
        Me.cbHealingItem.Name = "cbHealingItem"
        Me.cbHealingItem.Size = New System.Drawing.Size(90, 20)
        Me.cbHealingItem.TabIndex = 27
        Me.cbHealingItem.Text = "Healing Item"
        Me.ToolTipHelp.SetToolTip(Me.cbHealingItem, "Select to use Healing Item after selected Click." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(If necessary)")
        Me.cbHealingItem.UseVisualStyleBackColor = True
        '
        'cbPrayerPotion
        '
        Me.cbPrayerPotion.AutoSize = True
        Me.cbPrayerPotion.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbPrayerPotion.Location = New System.Drawing.Point(387, 94)
        Me.cbPrayerPotion.Name = "cbPrayerPotion"
        Me.cbPrayerPotion.Size = New System.Drawing.Size(96, 20)
        Me.cbPrayerPotion.TabIndex = 28
        Me.cbPrayerPotion.Text = "Prayer Potion"
        Me.ToolTipHelp.SetToolTip(Me.cbPrayerPotion, "Select to use Prayer Potion after selected Click." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(If necessary)")
        Me.cbPrayerPotion.UseVisualStyleBackColor = True
        '
        'cbRightClick
        '
        Me.cbRightClick.AutoSize = True
        Me.cbRightClick.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbRightClick.Location = New System.Drawing.Point(387, 116)
        Me.cbRightClick.Name = "cbRightClick"
        Me.cbRightClick.Size = New System.Drawing.Size(82, 20)
        Me.cbRightClick.TabIndex = 29
        Me.cbRightClick.Text = "Right-Click"
        Me.ToolTipHelp.SetToolTip(Me.cbRightClick, "Select if this click will be a Right Mouse Click.")
        Me.cbRightClick.UseVisualStyleBackColor = True
        '
        'cbPictureVerify
        '
        Me.cbPictureVerify.AutoSize = True
        Me.cbPictureVerify.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbPictureVerify.Location = New System.Drawing.Point(387, 138)
        Me.cbPictureVerify.Name = "cbPictureVerify"
        Me.cbPictureVerify.Size = New System.Drawing.Size(96, 20)
        Me.cbPictureVerify.TabIndex = 30
        Me.cbPictureVerify.Text = "Verify Picture"
        Me.ToolTipHelp.SetToolTip(Me.cbPictureVerify, "Select to verify screen before selected Click.")
        Me.cbPictureVerify.UseVisualStyleBackColor = True
        '
        'cmbStartCondition
        '
        Me.cmbStartCondition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbStartCondition.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbStartCondition.FormattingEnabled = True
        Me.cmbStartCondition.Location = New System.Drawing.Point(94, 52)
        Me.cmbStartCondition.Name = "cmbStartCondition"
        Me.cmbStartCondition.Size = New System.Drawing.Size(81, 24)
        Me.cmbStartCondition.TabIndex = 2
        Me.ToolTipHelp.SetToolTip(Me.cmbStartCondition, "Auto: Click starts automatically." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Time: Click starts after a set amount of time." &
        "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Pixel: Click starts when it observes the defined pixel color.")
        '
        'lblStartCondition
        '
        Me.lblStartCondition.AutoSize = True
        Me.lblStartCondition.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStartCondition.Location = New System.Drawing.Point(93, 33)
        Me.lblStartCondition.Name = "lblStartCondition"
        Me.lblStartCondition.Size = New System.Drawing.Size(82, 16)
        Me.lblStartCondition.TabIndex = 3
        Me.lblStartCondition.Text = "Start Condition"
        Me.ToolTipHelp.SetToolTip(Me.lblStartCondition, "Auto: Click starts automatically." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Time: Click starts after a set amount of time." &
        "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Pixel: Click starts when it observes the defined pixel color." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
        '
        'lblEndCondition
        '
        Me.lblEndCondition.AutoSize = True
        Me.lblEndCondition.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEndCondition.Location = New System.Drawing.Point(180, 33)
        Me.lblEndCondition.Name = "lblEndCondition"
        Me.lblEndCondition.Size = New System.Drawing.Size(79, 16)
        Me.lblEndCondition.TabIndex = 4
        Me.lblEndCondition.Text = "End Condition"
        Me.ToolTipHelp.SetToolTip(Me.lblEndCondition, "Time: Click ends after a set amount of time." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Pixel: Click ends when it observes " &
        "the defined pixel color.")
        '
        'cmbEndCondition
        '
        Me.cmbEndCondition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbEndCondition.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbEndCondition.FormattingEnabled = True
        Me.cmbEndCondition.Location = New System.Drawing.Point(179, 52)
        Me.cmbEndCondition.Name = "cmbEndCondition"
        Me.cmbEndCondition.Size = New System.Drawing.Size(81, 24)
        Me.cmbEndCondition.TabIndex = 5
        Me.ToolTipHelp.SetToolTip(Me.cmbEndCondition, "Time: Click ends after a set amount of time." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Pixel: Click ends when it observes " &
        "the defined pixel color.")
        '
        'txtDelayHexStart
        '
        Me.txtDelayHexStart.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDelayHexStart.Location = New System.Drawing.Point(97, 94)
        Me.txtDelayHexStart.Name = "txtDelayHexStart"
        Me.txtDelayHexStart.Size = New System.Drawing.Size(76, 22)
        Me.txtDelayHexStart.TabIndex = 6
        Me.txtDelayHexStart.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtBufferRangeStart
        '
        Me.txtBufferRangeStart.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBufferRangeStart.Location = New System.Drawing.Point(96, 137)
        Me.txtBufferRangeStart.Name = "txtBufferRangeStart"
        Me.txtBufferRangeStart.Size = New System.Drawing.Size(76, 22)
        Me.txtBufferRangeStart.TabIndex = 7
        Me.txtBufferRangeStart.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblDelayHexStart
        '
        Me.lblDelayHexStart.AutoSize = True
        Me.lblDelayHexStart.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDelayHexStart.Location = New System.Drawing.Point(100, 78)
        Me.lblDelayHexStart.Name = "lblDelayHexStart"
        Me.lblDelayHexStart.Size = New System.Drawing.Size(68, 16)
        Me.lblDelayHexStart.TabIndex = 8
        Me.lblDelayHexStart.Text = "Delay / Hex"
        Me.ToolTipHelp.SetToolTip(Me.lblDelayHexStart, "Click to re-evaluate Hex Code values." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Only enabled in Pixel Condition.")
        '
        'lblBufferRangeStart
        '
        Me.lblBufferRangeStart.AutoSize = True
        Me.lblBufferRangeStart.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBufferRangeStart.Location = New System.Drawing.Point(95, 121)
        Me.lblBufferRangeStart.Name = "lblBufferRangeStart"
        Me.lblBufferRangeStart.Size = New System.Drawing.Size(78, 16)
        Me.lblBufferRangeStart.TabIndex = 9
        Me.lblBufferRangeStart.Text = "Buffer / Range"
        '
        'txtDelayHexEnd
        '
        Me.txtDelayHexEnd.CausesValidation = False
        Me.txtDelayHexEnd.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDelayHexEnd.Location = New System.Drawing.Point(181, 94)
        Me.txtDelayHexEnd.Name = "txtDelayHexEnd"
        Me.txtDelayHexEnd.Size = New System.Drawing.Size(76, 22)
        Me.txtDelayHexEnd.TabIndex = 10
        Me.txtDelayHexEnd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtBufferRangeEnd
        '
        Me.txtBufferRangeEnd.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBufferRangeEnd.Location = New System.Drawing.Point(181, 137)
        Me.txtBufferRangeEnd.Name = "txtBufferRangeEnd"
        Me.txtBufferRangeEnd.Size = New System.Drawing.Size(76, 22)
        Me.txtBufferRangeEnd.TabIndex = 11
        Me.txtBufferRangeEnd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblDelayHexEnd
        '
        Me.lblDelayHexEnd.AutoSize = True
        Me.lblDelayHexEnd.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDelayHexEnd.Location = New System.Drawing.Point(185, 78)
        Me.lblDelayHexEnd.Name = "lblDelayHexEnd"
        Me.lblDelayHexEnd.Size = New System.Drawing.Size(68, 16)
        Me.lblDelayHexEnd.TabIndex = 12
        Me.lblDelayHexEnd.Text = "Delay / Hex"
        Me.ToolTipHelp.SetToolTip(Me.lblDelayHexEnd, "Click to re-evaluate Hex Code values.")
        '
        'lblBufferRangeEnd
        '
        Me.lblBufferRangeEnd.AutoSize = True
        Me.lblBufferRangeEnd.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBufferRangeEnd.Location = New System.Drawing.Point(180, 121)
        Me.lblBufferRangeEnd.Name = "lblBufferRangeEnd"
        Me.lblBufferRangeEnd.Size = New System.Drawing.Size(78, 16)
        Me.lblBufferRangeEnd.TabIndex = 13
        Me.lblBufferRangeEnd.Text = "Buffer / Range"
        '
        'btnSaveProgram
        '
        Me.btnSaveProgram.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveProgram.Location = New System.Drawing.Point(5, 165)
        Me.btnSaveProgram.Name = "btnSaveProgram"
        Me.btnSaveProgram.Size = New System.Drawing.Size(376, 23)
        Me.btnSaveProgram.TabIndex = 31
        Me.btnSaveProgram.Text = "Save Program && Exit Set-Up"
        Me.ToolTipHelp.SetToolTip(Me.btnSaveProgram, "Click to Save Program & Exit Set-Up.")
        Me.btnSaveProgram.UseVisualStyleBackColor = True
        '
        'btnCancelProg
        '
        Me.btnCancelProg.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelProg.Location = New System.Drawing.Point(387, 165)
        Me.btnCancelProg.Name = "btnCancelProg"
        Me.btnCancelProg.Size = New System.Drawing.Size(96, 23)
        Me.btnCancelProg.TabIndex = 32
        Me.btnCancelProg.Text = "Cancel"
        Me.ToolTipHelp.SetToolTip(Me.btnCancelProg, "Click to Cancel & Delete new Program.")
        Me.btnCancelProg.UseVisualStyleBackColor = True
        '
        'btnGetHexEnd
        '
        Me.btnGetHexEnd.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGetHexEnd.Location = New System.Drawing.Point(181, 93)
        Me.btnGetHexEnd.Name = "btnGetHexEnd"
        Me.btnGetHexEnd.Size = New System.Drawing.Size(76, 23)
        Me.btnGetHexEnd.TabIndex = 36
        Me.btnGetHexEnd.Text = "Get Hex"
        Me.btnGetHexEnd.UseVisualStyleBackColor = True
        '
        'btnGetHexStart
        '
        Me.btnGetHexStart.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGetHexStart.Location = New System.Drawing.Point(97, 93)
        Me.btnGetHexStart.Name = "btnGetHexStart"
        Me.btnGetHexStart.Size = New System.Drawing.Size(76, 23)
        Me.btnGetHexStart.TabIndex = 35
        Me.btnGetHexStart.Text = "Get Hex"
        Me.btnGetHexStart.UseVisualStyleBackColor = True
        '
        'pnlHeader
        '
        Me.pnlHeader.BackColor = System.Drawing.Color.Maroon
        Me.pnlHeader.Controls.Add(Me.btnExit)
        Me.pnlHeader.Controls.Add(Me.lblHeader)
        Me.pnlHeader.Location = New System.Drawing.Point(3, 3)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(488, 27)
        Me.pnlHeader.TabIndex = 37
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Palatino Linotype", 6.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(464, 3)
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
        Me.lblHeader.Size = New System.Drawing.Size(154, 20)
        Me.lblHeader.TabIndex = 0
        Me.lblHeader.Text = "New Program Set-Up"
        '
        'pnlTopBorder
        '
        Me.pnlTopBorder.BackColor = System.Drawing.Color.Black
        Me.pnlTopBorder.Location = New System.Drawing.Point(0, 0)
        Me.pnlTopBorder.Name = "pnlTopBorder"
        Me.pnlTopBorder.Size = New System.Drawing.Size(494, 1)
        Me.pnlTopBorder.TabIndex = 38
        '
        'pnlLeftBorder
        '
        Me.pnlLeftBorder.BackColor = System.Drawing.Color.Black
        Me.pnlLeftBorder.Location = New System.Drawing.Point(0, 1)
        Me.pnlLeftBorder.Name = "pnlLeftBorder"
        Me.pnlLeftBorder.Size = New System.Drawing.Size(1, 192)
        Me.pnlLeftBorder.TabIndex = 39
        '
        'pnlBottomBorder
        '
        Me.pnlBottomBorder.BackColor = System.Drawing.Color.Black
        Me.pnlBottomBorder.Location = New System.Drawing.Point(1, 192)
        Me.pnlBottomBorder.Name = "pnlBottomBorder"
        Me.pnlBottomBorder.Size = New System.Drawing.Size(492, 1)
        Me.pnlBottomBorder.TabIndex = 40
        '
        'pnlRightBorder
        '
        Me.pnlRightBorder.BackColor = System.Drawing.Color.Black
        Me.pnlRightBorder.Location = New System.Drawing.Point(493, 1)
        Me.pnlRightBorder.Name = "pnlRightBorder"
        Me.pnlRightBorder.Size = New System.Drawing.Size(1, 192)
        Me.pnlRightBorder.TabIndex = 41
        '
        'frmSetUp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.ClientSize = New System.Drawing.Size(494, 193)
        Me.Controls.Add(Me.pnlRightBorder)
        Me.Controls.Add(Me.pnlBottomBorder)
        Me.Controls.Add(Me.pnlLeftBorder)
        Me.Controls.Add(Me.pnlTopBorder)
        Me.Controls.Add(Me.pnlHeader)
        Me.Controls.Add(Me.btnGetHexEnd)
        Me.Controls.Add(Me.btnGetHexStart)
        Me.Controls.Add(Me.btnCancelProg)
        Me.Controls.Add(Me.btnSaveProgram)
        Me.Controls.Add(Me.cbPictureVerify)
        Me.Controls.Add(Me.cbRightClick)
        Me.Controls.Add(Me.cbPrayerPotion)
        Me.Controls.Add(Me.cbHealingItem)
        Me.Controls.Add(Me.cbDropInv)
        Me.Controls.Add(Me.btnSaveClick)
        Me.Controls.Add(Me.btnDeleteClick)
        Me.Controls.Add(Me.lblY2)
        Me.Controls.Add(Me.lblY1)
        Me.Controls.Add(Me.lblX2)
        Me.Controls.Add(Me.lblX1)
        Me.Controls.Add(Me.txtYDown)
        Me.Controls.Add(Me.txtXRight)
        Me.Controls.Add(Me.txtYUp)
        Me.Controls.Add(Me.txtXLeft)
        Me.Controls.Add(Me.btnAddClick)
        Me.Controls.Add(Me.btnGetClickCoords)
        Me.Controls.Add(Me.lblBufferRangeEnd)
        Me.Controls.Add(Me.lblDelayHexEnd)
        Me.Controls.Add(Me.txtBufferRangeEnd)
        Me.Controls.Add(Me.txtDelayHexEnd)
        Me.Controls.Add(Me.lblBufferRangeStart)
        Me.Controls.Add(Me.lblDelayHexStart)
        Me.Controls.Add(Me.txtBufferRangeStart)
        Me.Controls.Add(Me.txtDelayHexStart)
        Me.Controls.Add(Me.cmbEndCondition)
        Me.Controls.Add(Me.lblEndCondition)
        Me.Controls.Add(Me.lblStartCondition)
        Me.Controls.Add(Me.cmbStartCondition)
        Me.Controls.Add(Me.lblClickNmbr)
        Me.Controls.Add(Me.cmbClickNmbr)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmSetUp"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Set-Up"
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmbClickNmbr As ComboBox
    Friend WithEvents lblClickNmbr As Label
    Friend WithEvents btnGetClickCoords As Button
    Friend WithEvents btnAddClick As Button
    Friend WithEvents txtXLeft As TextBox
    Friend WithEvents txtYUp As TextBox
    Friend WithEvents txtYDown As TextBox
    Friend WithEvents txtXRight As TextBox
    Friend WithEvents lblX1 As Label
    Friend WithEvents lblX2 As Label
    Friend WithEvents lblY1 As Label
    Friend WithEvents lblY2 As Label
    Friend WithEvents btnDeleteClick As Button
    Friend WithEvents btnSaveClick As Button
    Friend WithEvents cbDropInv As CheckBox
    Friend WithEvents cbHealingItem As CheckBox
    Friend WithEvents cbPrayerPotion As CheckBox
    Friend WithEvents cbRightClick As CheckBox
    Friend WithEvents cbPictureVerify As CheckBox
    Friend WithEvents cmbStartCondition As ComboBox
    Friend WithEvents lblStartCondition As Label
    Friend WithEvents lblEndCondition As Label
    Friend WithEvents cmbEndCondition As ComboBox
    Friend WithEvents txtDelayHexStart As TextBox
    Friend WithEvents txtBufferRangeStart As TextBox
    Friend WithEvents lblDelayHexStart As Label
    Friend WithEvents lblBufferRangeStart As Label
    Friend WithEvents txtDelayHexEnd As TextBox
    Friend WithEvents txtBufferRangeEnd As TextBox
    Friend WithEvents lblDelayHexEnd As Label
    Friend WithEvents lblBufferRangeEnd As Label
    Friend WithEvents btnSaveProgram As Button
    Friend WithEvents btnCancelProg As Button
    Friend WithEvents btnGetHexEnd As Button
    Friend WithEvents btnGetHexStart As Button
    Friend WithEvents ToolTipHelp As ToolTip
    Friend WithEvents pnlHeader As Panel
    Friend WithEvents lblHeader As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents pnlTopBorder As Panel
    Friend WithEvents pnlLeftBorder As Panel
    Friend WithEvents pnlBottomBorder As Panel
    Friend WithEvents pnlRightBorder As Panel
End Class
