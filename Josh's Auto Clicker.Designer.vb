<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.DelayTimer = New System.Windows.Forms.Timer(Me.components)
        Me.btnAbort = New System.Windows.Forms.Button()
        Me.btnPauseResume = New System.Windows.Forms.Button()
        Me.btnTutorial = New System.Windows.Forms.Button()
        Me.btnCustomProc = New System.Windows.Forms.Button()
        Me.txtEventLog = New System.Windows.Forms.TextBox()
        Me.lblEventLog = New System.Windows.Forms.Label()
        Me.btnHorSize = New System.Windows.Forms.Button()
        Me.lblGameTimer = New System.Windows.Forms.Label()
        Me.lblCurrentGameTime = New System.Windows.Forms.Label()
        Me.GameTmr = New System.Windows.Forms.Timer(Me.components)
        Me.txtPicMatchPercent = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnPictureTest = New System.Windows.Forms.Button()
        Me.btnNewProgram = New System.Windows.Forms.Button()
        Me.cmbLoadProgram = New System.Windows.Forms.ComboBox()
        Me.btnRunProgram = New System.Windows.Forms.Button()
        Me.btnEditProgram = New System.Windows.Forms.Button()
        Me.lblProgramName = New System.Windows.Forms.Label()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnSettings = New System.Windows.Forms.Button()
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.btnMinimize = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblProgramTitle = New System.Windows.Forms.Label()
        Me.pnlTopBorder = New System.Windows.Forms.Panel()
        Me.pnlLeftBorder = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.pnlRightBorder = New System.Windows.Forms.Panel()
        Me.pnlHeader.SuspendLayout()
        Me.SuspendLayout()
        '
        'DelayTimer
        '
        Me.DelayTimer.Interval = 1000
        '
        'btnAbort
        '
        Me.btnAbort.BackColor = System.Drawing.Color.LightGray
        Me.btnAbort.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnAbort.FlatAppearance.BorderColor = System.Drawing.Color.Maroon
        Me.btnAbort.FlatAppearance.BorderSize = 0
        Me.btnAbort.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAbort.ForeColor = System.Drawing.Color.Black
        Me.btnAbort.Location = New System.Drawing.Point(46, 36)
        Me.btnAbort.Name = "btnAbort"
        Me.btnAbort.Size = New System.Drawing.Size(79, 30)
        Me.btnAbort.TabIndex = 11
        Me.btnAbort.Text = "Abort"
        Me.ToolTip1.SetToolTip(Me.btnAbort, "Click to Abort selected Program.")
        Me.btnAbort.UseVisualStyleBackColor = False
        '
        'btnPauseResume
        '
        Me.btnPauseResume.BackColor = System.Drawing.Color.LightGray
        Me.btnPauseResume.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPauseResume.ForeColor = System.Drawing.Color.Black
        Me.btnPauseResume.Location = New System.Drawing.Point(131, 36)
        Me.btnPauseResume.Name = "btnPauseResume"
        Me.btnPauseResume.Size = New System.Drawing.Size(79, 30)
        Me.btnPauseResume.TabIndex = 15
        Me.btnPauseResume.Text = "Pause"
        Me.ToolTip1.SetToolTip(Me.btnPauseResume, "Click to Pause selected Program.")
        Me.btnPauseResume.UseVisualStyleBackColor = False
        '
        'btnTutorial
        '
        Me.btnTutorial.BackColor = System.Drawing.Color.LightGray
        Me.btnTutorial.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTutorial.ForeColor = System.Drawing.Color.Black
        Me.btnTutorial.Location = New System.Drawing.Point(216, 36)
        Me.btnTutorial.Name = "btnTutorial"
        Me.btnTutorial.Size = New System.Drawing.Size(79, 30)
        Me.btnTutorial.TabIndex = 1
        Me.btnTutorial.Text = "Tutorial"
        Me.btnTutorial.UseVisualStyleBackColor = False
        '
        'btnCustomProc
        '
        Me.btnCustomProc.Location = New System.Drawing.Point(18, 12)
        Me.btnCustomProc.Name = "btnCustomProc"
        Me.btnCustomProc.Size = New System.Drawing.Size(0, 0)
        Me.btnCustomProc.TabIndex = 1016
        Me.btnCustomProc.Text = "Button1"
        Me.btnCustomProc.UseVisualStyleBackColor = True
        '
        'txtEventLog
        '
        Me.txtEventLog.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEventLog.Location = New System.Drawing.Point(324, 56)
        Me.txtEventLog.MaxLength = 100
        Me.txtEventLog.Multiline = True
        Me.txtEventLog.Name = "txtEventLog"
        Me.txtEventLog.ReadOnly = True
        Me.txtEventLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtEventLog.Size = New System.Drawing.Size(158, 97)
        Me.txtEventLog.TabIndex = 1038
        '
        'lblEventLog
        '
        Me.lblEventLog.AutoSize = True
        Me.lblEventLog.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEventLog.Location = New System.Drawing.Point(362, 32)
        Me.lblEventLog.Name = "lblEventLog"
        Me.lblEventLog.Size = New System.Drawing.Size(82, 21)
        Me.lblEventLog.TabIndex = 1037
        Me.lblEventLog.Text = "Event Log"
        Me.ToolTip1.SetToolTip(Me.lblEventLog, "Clear Event Log?")
        '
        'btnHorSize
        '
        Me.btnHorSize.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHorSize.Location = New System.Drawing.Point(301, 37)
        Me.btnHorSize.Name = "btnHorSize"
        Me.btnHorSize.Size = New System.Drawing.Size(17, 116)
        Me.btnHorSize.TabIndex = 1038
        Me.btnHorSize.Text = ">"
        Me.btnHorSize.UseVisualStyleBackColor = True
        '
        'lblGameTimer
        '
        Me.lblGameTimer.AutoSize = True
        Me.lblGameTimer.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGameTimer.Location = New System.Drawing.Point(10, 132)
        Me.lblGameTimer.Name = "lblGameTimer"
        Me.lblGameTimer.Size = New System.Drawing.Size(84, 17)
        Me.lblGameTimer.TabIndex = 1039
        Me.lblGameTimer.Text = "Game Timer :"
        Me.ToolTip1.SetToolTip(Me.lblGameTimer, "Reset in-game timer?")
        '
        'lblCurrentGameTime
        '
        Me.lblCurrentGameTime.AutoSize = True
        Me.lblCurrentGameTime.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurrentGameTime.Location = New System.Drawing.Point(96, 133)
        Me.lblCurrentGameTime.Name = "lblCurrentGameTime"
        Me.lblCurrentGameTime.Size = New System.Drawing.Size(44, 16)
        Me.lblCurrentGameTime.TabIndex = 1040
        Me.lblCurrentGameTime.Text = "0:00:00"
        Me.ToolTip1.SetToolTip(Me.lblCurrentGameTime, "Update in-game timer?")
        '
        'GameTmr
        '
        Me.GameTmr.Interval = 1000
        '
        'txtPicMatchPercent
        '
        Me.txtPicMatchPercent.Enabled = False
        Me.txtPicMatchPercent.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPicMatchPercent.Location = New System.Drawing.Point(253, 129)
        Me.txtPicMatchPercent.Name = "txtPicMatchPercent"
        Me.txtPicMatchPercent.ReadOnly = True
        Me.txtPicMatchPercent.Size = New System.Drawing.Size(42, 22)
        Me.txtPicMatchPercent.TabIndex = 1044
        Me.txtPicMatchPercent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTip1.SetToolTip(Me.txtPicMatchPercent, "Shows Pixel Match % between Computer & selected Program Click #1.")
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(150, 132)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 17)
        Me.Label1.TabIndex = 1046
        Me.Label1.Text = "Picture Match % :"
        Me.ToolTip1.SetToolTip(Me.Label1, "Shows Pixel Match % between Computer & selected Program Click #1.")
        '
        'btnPictureTest
        '
        Me.btnPictureTest.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPictureTest.Location = New System.Drawing.Point(234, 100)
        Me.btnPictureTest.Name = "btnPictureTest"
        Me.btnPictureTest.Size = New System.Drawing.Size(61, 23)
        Me.btnPictureTest.TabIndex = 1062
        Me.btnPictureTest.Text = "Calibrate"
        Me.ToolTip1.SetToolTip(Me.btnPictureTest, "Click to Calibrate selected Program.")
        Me.btnPictureTest.UseVisualStyleBackColor = True
        '
        'btnNewProgram
        '
        Me.btnNewProgram.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNewProgram.Location = New System.Drawing.Point(10, 100)
        Me.btnNewProgram.Name = "btnNewProgram"
        Me.btnNewProgram.Size = New System.Drawing.Size(90, 23)
        Me.btnNewProgram.TabIndex = 1064
        Me.btnNewProgram.Text = "New Program"
        Me.ToolTip1.SetToolTip(Me.btnNewProgram, "Click to Create new Program.")
        Me.btnNewProgram.UseVisualStyleBackColor = True
        '
        'cmbLoadProgram
        '
        Me.cmbLoadProgram.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbLoadProgram.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbLoadProgram.FormattingEnabled = True
        Me.cmbLoadProgram.Location = New System.Drawing.Point(106, 70)
        Me.cmbLoadProgram.Name = "cmbLoadProgram"
        Me.cmbLoadProgram.Size = New System.Drawing.Size(139, 24)
        Me.cmbLoadProgram.TabIndex = 1065
        Me.ToolTip1.SetToolTip(Me.cmbLoadProgram, "Displays currently selected Program.")
        '
        'btnRunProgram
        '
        Me.btnRunProgram.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRunProgram.Location = New System.Drawing.Point(251, 71)
        Me.btnRunProgram.Name = "btnRunProgram"
        Me.btnRunProgram.Size = New System.Drawing.Size(44, 23)
        Me.btnRunProgram.TabIndex = 1066
        Me.btnRunProgram.Text = "Run"
        Me.ToolTip1.SetToolTip(Me.btnRunProgram, "Click to Run selected Program.")
        Me.btnRunProgram.UseVisualStyleBackColor = True
        '
        'btnEditProgram
        '
        Me.btnEditProgram.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditProgram.Location = New System.Drawing.Point(106, 100)
        Me.btnEditProgram.Name = "btnEditProgram"
        Me.btnEditProgram.Size = New System.Drawing.Size(57, 23)
        Me.btnEditProgram.TabIndex = 1067
        Me.btnEditProgram.Text = "Edit"
        Me.ToolTip1.SetToolTip(Me.btnEditProgram, "Click to Edit selected Program.")
        Me.btnEditProgram.UseVisualStyleBackColor = True
        '
        'lblProgramName
        '
        Me.lblProgramName.AutoSize = True
        Me.lblProgramName.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProgramName.Location = New System.Drawing.Point(7, 74)
        Me.lblProgramName.Name = "lblProgramName"
        Me.lblProgramName.Size = New System.Drawing.Size(93, 17)
        Me.lblProgramName.TabIndex = 1068
        Me.lblProgramName.Text = "Program Name:"
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.SystemColors.ControlDark
        Me.btnDelete.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(169, 100)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(59, 23)
        Me.btnDelete.TabIndex = 1069
        Me.btnDelete.Text = "Delete"
        Me.ToolTip1.SetToolTip(Me.btnDelete, "Click to Delete selected Program.")
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'ToolTip1
        '
        Me.ToolTip1.AutoPopDelay = 20000
        Me.ToolTip1.InitialDelay = 500
        Me.ToolTip1.ReshowDelay = 100
        '
        'btnSettings
        '
        Me.btnSettings.BackColor = System.Drawing.Color.LightGray
        Me.btnSettings.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSettings.ForeColor = System.Drawing.Color.Black
        Me.btnSettings.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSettings.Location = New System.Drawing.Point(8, 36)
        Me.btnSettings.Name = "btnSettings"
        Me.btnSettings.Size = New System.Drawing.Size(32, 30)
        Me.btnSettings.TabIndex = 1055
        Me.btnSettings.Text = "§"
        Me.ToolTip1.SetToolTip(Me.btnSettings, "Settings")
        Me.btnSettings.UseVisualStyleBackColor = False
        '
        'pnlHeader
        '
        Me.pnlHeader.BackColor = System.Drawing.Color.Maroon
        Me.pnlHeader.Controls.Add(Me.btnMinimize)
        Me.pnlHeader.Controls.Add(Me.btnExit)
        Me.pnlHeader.Controls.Add(Me.lblProgramTitle)
        Me.pnlHeader.Location = New System.Drawing.Point(3, 3)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(483, 27)
        Me.pnlHeader.TabIndex = 1070
        '
        'btnMinimize
        '
        Me.btnMinimize.Font = New System.Drawing.Font("Palatino Linotype", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMinimize.Location = New System.Drawing.Point(432, 3)
        Me.btnMinimize.Name = "btnMinimize"
        Me.btnMinimize.Size = New System.Drawing.Size(21, 21)
        Me.btnMinimize.TabIndex = 2
        Me.btnMinimize.Text = "_"
        Me.btnMinimize.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnMinimize.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Palatino Linotype", 6.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(459, 3)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(21, 21)
        Me.btnExit.TabIndex = 1
        Me.btnExit.Text = "X"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblProgramTitle
        '
        Me.lblProgramTitle.AutoSize = True
        Me.lblProgramTitle.Font = New System.Drawing.Font("Palatino Linotype", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProgramTitle.Location = New System.Drawing.Point(3, 2)
        Me.lblProgramTitle.Name = "lblProgramTitle"
        Me.lblProgramTitle.Size = New System.Drawing.Size(134, 20)
        Me.lblProgramTitle.TabIndex = 0
        Me.lblProgramTitle.Text = "Josh's Auto Clicker"
        '
        'pnlTopBorder
        '
        Me.pnlTopBorder.BackColor = System.Drawing.Color.Black
        Me.pnlTopBorder.Location = New System.Drawing.Point(0, 0)
        Me.pnlTopBorder.Name = "pnlTopBorder"
        Me.pnlTopBorder.Size = New System.Drawing.Size(489, 1)
        Me.pnlTopBorder.TabIndex = 1071
        '
        'pnlLeftBorder
        '
        Me.pnlLeftBorder.BackColor = System.Drawing.Color.Black
        Me.pnlLeftBorder.Location = New System.Drawing.Point(0, 1)
        Me.pnlLeftBorder.Name = "pnlLeftBorder"
        Me.pnlLeftBorder.Size = New System.Drawing.Size(1, 158)
        Me.pnlLeftBorder.TabIndex = 1072
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Location = New System.Drawing.Point(1, 158)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(488, 1)
        Me.Panel1.TabIndex = 1073
        '
        'pnlRightBorder
        '
        Me.pnlRightBorder.BackColor = System.Drawing.Color.Black
        Me.pnlRightBorder.Location = New System.Drawing.Point(488, 1)
        Me.pnlRightBorder.Name = "pnlRightBorder"
        Me.pnlRightBorder.Size = New System.Drawing.Size(1, 157)
        Me.pnlRightBorder.TabIndex = 1074
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.ClientSize = New System.Drawing.Size(489, 159)
        Me.Controls.Add(Me.pnlRightBorder)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.pnlLeftBorder)
        Me.Controls.Add(Me.pnlTopBorder)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.lblProgramName)
        Me.Controls.Add(Me.btnEditProgram)
        Me.Controls.Add(Me.btnRunProgram)
        Me.Controls.Add(Me.cmbLoadProgram)
        Me.Controls.Add(Me.btnNewProgram)
        Me.Controls.Add(Me.btnPictureTest)
        Me.Controls.Add(Me.btnSettings)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtPicMatchPercent)
        Me.Controls.Add(Me.lblCurrentGameTime)
        Me.Controls.Add(Me.lblGameTimer)
        Me.Controls.Add(Me.btnHorSize)
        Me.Controls.Add(Me.lblEventLog)
        Me.Controls.Add(Me.txtEventLog)
        Me.Controls.Add(Me.btnCustomProc)
        Me.Controls.Add(Me.btnTutorial)
        Me.Controls.Add(Me.btnPauseResume)
        Me.Controls.Add(Me.btnAbort)
        Me.Controls.Add(Me.pnlHeader)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.Text = "Josh's Auto Clicker"
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DelayTimer As Timer
    Friend WithEvents btnAbort As Button
    Friend WithEvents btnPauseResume As Button
    Friend WithEvents btnTutorial As Button
    Friend WithEvents btnCustomProc As Button
    Friend WithEvents txtEventLog As TextBox
    Friend WithEvents lblEventLog As Label
    Friend WithEvents btnHorSize As Button
    Friend WithEvents lblGameTimer As Label
    Friend WithEvents lblCurrentGameTime As Label
    Friend WithEvents GameTmr As Timer
    Friend WithEvents txtPicMatchPercent As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnSettings As Button
    Friend WithEvents btnPictureTest As Button
    Friend WithEvents btnNewProgram As Button
    Friend WithEvents cmbLoadProgram As ComboBox
    Friend WithEvents btnRunProgram As Button
    Friend WithEvents btnEditProgram As Button
    Friend WithEvents lblProgramName As Label
    Friend WithEvents btnDelete As Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents pnlHeader As Panel
    Friend WithEvents lblProgramTitle As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents pnlTopBorder As Panel
    Friend WithEvents pnlLeftBorder As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents pnlRightBorder As Panel
    Friend WithEvents btnMinimize As Button
End Class
