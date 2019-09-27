<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMessageBox
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
        Me.lblMessageText = New System.Windows.Forms.Label()
        Me.btnMessageOK = New System.Windows.Forms.Button()
        Me.btnMessageCancel = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.pnlTopBorder = New System.Windows.Forms.Panel()
        Me.pnlLeftBorder = New System.Windows.Forms.Panel()
        Me.pnlRightBorder = New System.Windows.Forms.Panel()
        Me.pnlBottomBorder = New System.Windows.Forms.Panel()
        Me.pnlHeader.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblMessageText
        '
        Me.lblMessageText.Location = New System.Drawing.Point(12, 36)
        Me.lblMessageText.Name = "lblMessageText"
        Me.lblMessageText.Size = New System.Drawing.Size(179, 56)
        Me.lblMessageText.TabIndex = 2
        Me.lblMessageText.Text = "Enter Text Here:"
        Me.lblMessageText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnMessageOK
        '
        Me.btnMessageOK.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnMessageOK.Location = New System.Drawing.Point(12, 95)
        Me.btnMessageOK.Name = "btnMessageOK"
        Me.btnMessageOK.Size = New System.Drawing.Size(68, 28)
        Me.btnMessageOK.TabIndex = 0
        Me.btnMessageOK.Text = "OK"
        Me.btnMessageOK.UseVisualStyleBackColor = True
        '
        'btnMessageCancel
        '
        Me.btnMessageCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnMessageCancel.Location = New System.Drawing.Point(123, 95)
        Me.btnMessageCancel.Name = "btnMessageCancel"
        Me.btnMessageCancel.Size = New System.Drawing.Size(68, 28)
        Me.btnMessageCancel.TabIndex = 1
        Me.btnMessageCancel.Text = "Cancel"
        Me.btnMessageCancel.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 16)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Label1"
        '
        'pnlHeader
        '
        Me.pnlHeader.BackColor = System.Drawing.Color.Maroon
        Me.pnlHeader.Controls.Add(Me.lblHeader)
        Me.pnlHeader.Location = New System.Drawing.Point(3, 3)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(197, 27)
        Me.pnlHeader.TabIndex = 5
        '
        'lblHeader
        '
        Me.lblHeader.AutoSize = True
        Me.lblHeader.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeader.Location = New System.Drawing.Point(3, 3)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(88, 18)
        Me.lblHeader.TabIndex = 0
        Me.lblHeader.Text = "Message Title"
        '
        'pnlTopBorder
        '
        Me.pnlTopBorder.BackColor = System.Drawing.Color.Black
        Me.pnlTopBorder.Location = New System.Drawing.Point(0, 0)
        Me.pnlTopBorder.Name = "pnlTopBorder"
        Me.pnlTopBorder.Size = New System.Drawing.Size(203, 1)
        Me.pnlTopBorder.TabIndex = 6
        '
        'pnlLeftBorder
        '
        Me.pnlLeftBorder.BackColor = System.Drawing.Color.Black
        Me.pnlLeftBorder.Location = New System.Drawing.Point(0, 0)
        Me.pnlLeftBorder.Name = "pnlLeftBorder"
        Me.pnlLeftBorder.Size = New System.Drawing.Size(1, 126)
        Me.pnlLeftBorder.TabIndex = 7
        '
        'pnlRightBorder
        '
        Me.pnlRightBorder.BackColor = System.Drawing.Color.Black
        Me.pnlRightBorder.Location = New System.Drawing.Point(202, 0)
        Me.pnlRightBorder.Name = "pnlRightBorder"
        Me.pnlRightBorder.Size = New System.Drawing.Size(1, 126)
        Me.pnlRightBorder.TabIndex = 8
        '
        'pnlBottomBorder
        '
        Me.pnlBottomBorder.BackColor = System.Drawing.Color.Black
        Me.pnlBottomBorder.Location = New System.Drawing.Point(0, 125)
        Me.pnlBottomBorder.Name = "pnlBottomBorder"
        Me.pnlBottomBorder.Size = New System.Drawing.Size(203, 1)
        Me.pnlBottomBorder.TabIndex = 9
        '
        'frmMessageBox
        '
        Me.AcceptButton = Me.btnMessageOK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.CancelButton = Me.btnMessageCancel
        Me.ClientSize = New System.Drawing.Size(203, 126)
        Me.Controls.Add(Me.pnlBottomBorder)
        Me.Controls.Add(Me.pnlRightBorder)
        Me.Controls.Add(Me.pnlLeftBorder)
        Me.Controls.Add(Me.pnlTopBorder)
        Me.Controls.Add(Me.pnlHeader)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnMessageCancel)
        Me.Controls.Add(Me.btnMessageOK)
        Me.Controls.Add(Me.lblMessageText)
        Me.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmMessageBox"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frmMessageBox"
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblMessageText As Label
    Friend WithEvents btnMessageOK As Button
    Friend WithEvents btnMessageCancel As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents pnlHeader As Panel
    Friend WithEvents lblHeader As Label
    Friend WithEvents pnlTopBorder As Panel
    Friend WithEvents pnlLeftBorder As Panel
    Friend WithEvents pnlRightBorder As Panel
    Friend WithEvents pnlBottomBorder As Panel
End Class
