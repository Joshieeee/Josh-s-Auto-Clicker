<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInputBox
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnInputOK = New System.Windows.Forms.Button()
        Me.btnInputCancel = New System.Windows.Forms.Button()
        Me.txtInputEntry = New System.Windows.Forms.TextBox()
        Me.lblInputText = New System.Windows.Forms.Label()
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.pnlTopBorder = New System.Windows.Forms.Panel()
        Me.pnlLeftBorder = New System.Windows.Forms.Panel()
        Me.pnlRightBorder = New System.Windows.Forms.Panel()
        Me.pnlBottomBorder = New System.Windows.Forms.Panel()
        Me.pnlHeader.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnInputOK
        '
        Me.btnInputOK.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnInputOK.Location = New System.Drawing.Point(15, 118)
        Me.btnInputOK.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnInputOK.Name = "btnInputOK"
        Me.btnInputOK.Size = New System.Drawing.Size(68, 28)
        Me.btnInputOK.TabIndex = 1
        Me.btnInputOK.Text = "OK"
        Me.btnInputOK.UseVisualStyleBackColor = True
        '
        'btnInputCancel
        '
        Me.btnInputCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnInputCancel.Location = New System.Drawing.Point(123, 118)
        Me.btnInputCancel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnInputCancel.Name = "btnInputCancel"
        Me.btnInputCancel.Size = New System.Drawing.Size(68, 28)
        Me.btnInputCancel.TabIndex = 2
        Me.btnInputCancel.Text = "Cancel"
        Me.btnInputCancel.UseVisualStyleBackColor = True
        '
        'txtInputEntry
        '
        Me.txtInputEntry.Location = New System.Drawing.Point(15, 88)
        Me.txtInputEntry.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtInputEntry.Name = "txtInputEntry"
        Me.txtInputEntry.Size = New System.Drawing.Size(176, 22)
        Me.txtInputEntry.TabIndex = 0
        '
        'lblInputText
        '
        Me.lblInputText.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInputText.Location = New System.Drawing.Point(12, 34)
        Me.lblInputText.Name = "lblInputText"
        Me.lblInputText.Size = New System.Drawing.Size(179, 50)
        Me.lblInputText.TabIndex = 3
        Me.lblInputText.Text = "Enter Text Here:"
        Me.lblInputText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pnlHeader
        '
        Me.pnlHeader.BackColor = System.Drawing.Color.Maroon
        Me.pnlHeader.Controls.Add(Me.lblHeader)
        Me.pnlHeader.Location = New System.Drawing.Point(3, 3)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(197, 27)
        Me.pnlHeader.TabIndex = 4
        '
        'lblHeader
        '
        Me.lblHeader.AutoSize = True
        Me.lblHeader.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeader.Location = New System.Drawing.Point(3, 3)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(69, 18)
        Me.lblHeader.TabIndex = 0
        Me.lblHeader.Text = "Input Title"
        '
        'pnlTopBorder
        '
        Me.pnlTopBorder.BackColor = System.Drawing.Color.Black
        Me.pnlTopBorder.Location = New System.Drawing.Point(0, 0)
        Me.pnlTopBorder.Name = "pnlTopBorder"
        Me.pnlTopBorder.Size = New System.Drawing.Size(203, 1)
        Me.pnlTopBorder.TabIndex = 5
        '
        'pnlLeftBorder
        '
        Me.pnlLeftBorder.BackColor = System.Drawing.Color.Black
        Me.pnlLeftBorder.Location = New System.Drawing.Point(0, 1)
        Me.pnlLeftBorder.Name = "pnlLeftBorder"
        Me.pnlLeftBorder.Size = New System.Drawing.Size(1, 155)
        Me.pnlLeftBorder.TabIndex = 6
        '
        'pnlRightBorder
        '
        Me.pnlRightBorder.BackColor = System.Drawing.Color.Black
        Me.pnlRightBorder.Location = New System.Drawing.Point(202, 1)
        Me.pnlRightBorder.Name = "pnlRightBorder"
        Me.pnlRightBorder.Size = New System.Drawing.Size(1, 155)
        Me.pnlRightBorder.TabIndex = 7
        '
        'pnlBottomBorder
        '
        Me.pnlBottomBorder.BackColor = System.Drawing.Color.Black
        Me.pnlBottomBorder.Location = New System.Drawing.Point(1, 155)
        Me.pnlBottomBorder.Name = "pnlBottomBorder"
        Me.pnlBottomBorder.Size = New System.Drawing.Size(201, 1)
        Me.pnlBottomBorder.TabIndex = 8
        '
        'frmInputBox
        '
        Me.AcceptButton = Me.btnInputOK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.CancelButton = Me.btnInputCancel
        Me.ClientSize = New System.Drawing.Size(203, 150)
        Me.Controls.Add(Me.pnlBottomBorder)
        Me.Controls.Add(Me.pnlRightBorder)
        Me.Controls.Add(Me.pnlLeftBorder)
        Me.Controls.Add(Me.pnlTopBorder)
        Me.Controls.Add(Me.pnlHeader)
        Me.Controls.Add(Me.lblInputText)
        Me.Controls.Add(Me.txtInputEntry)
        Me.Controls.Add(Me.btnInputCancel)
        Me.Controls.Add(Me.btnInputOK)
        Me.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmInputBox"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frmInputBox"
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnInputOK As Button
    Friend WithEvents btnInputCancel As Button
    Friend WithEvents txtInputEntry As TextBox
    Friend WithEvents lblInputText As Label
    Friend WithEvents pnlHeader As Panel
    Friend WithEvents lblHeader As Label
    Friend WithEvents pnlTopBorder As Panel
    Friend WithEvents pnlLeftBorder As Panel
    Friend WithEvents pnlRightBorder As Panel
    Friend WithEvents pnlBottomBorder As Panel
End Class
