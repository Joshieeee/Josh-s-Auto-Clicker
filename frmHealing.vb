Imports System.Runtime.InteropServices
Public Class frmHealing
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
    Private Sub frmHealing_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Location = New Point(frmSettings.Location.X + frmSettings.Width + 10, frmSettings.Location.Y + frmSettings.Height / 2 - Me.Height / 2)
        frmSettings.Enabled = False
    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim File As System.IO.StreamWriter
        Dim HealingArray(27) As String
        For Each Ctrl As Control In Me.Controls
            If TypeOf Ctrl Is TextBox Then
                If Ctrl.Text = "" Then
                    frmMessageBox.lblHeader.Text = "Healing Set-Up Error"
                    frmMessageBox.lblMessageText.Text = "Enter Values Into Each TextBox Before Saving!"
                    frmMessageBox.ShowDialog()
                    Exit Sub
                End If
            End If
        Next
        For Each Ctrl As Control In Me.Controls
            If TypeOf Ctrl Is TextBox Then
                HealingArray(Ctrl.TabIndex - 1) = Ctrl.Text
            End If
        Next
        If System.IO.File.Exists(frmMain.DriveLetter & "RSAutoClicker\Healing.csv") = True Then
            My.Computer.FileSystem.DeleteFile(frmMain.DriveLetter & "RSAutoClicker\Healing.csv")
        End If
        File = My.Computer.FileSystem.OpenTextFileWriter(frmMain.DriveLetter & "RSAutoClicker\Healing.csv", True)
        For i = 0 To 27
            File.WriteLine(HealingArray(i))
        Next
        File.Close()
        frmSettings.Enabled = True
        Me.Close()
    End Sub
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        frmSettings.Enabled = True
        Me.Close()
        Exit Sub
    End Sub
    Private Sub txtHeal1_TextChanged(sender As Object, e As EventArgs) Handles txtHeal1.TextChanged
        If Integer.TryParse(txtHeal1.Text, 1) = True And txtHeal1.Text <> "" Then
            If Convert.ToInt32(txtHeal1.Text) > 5 Or Convert.ToInt32(txtHeal1.Text) < 0 Then
                txtHeal1.ForeColor = Color.Red
                btnSave.Enabled = False
            Else
                txtHeal1.ForeColor = Color.Black
                btnSave.Enabled = True
            End If
        Else
            txtHeal1.ForeColor = Color.Red
            btnSave.Enabled = False
        End If
    End Sub

    Private Sub txtHeal2_TextChanged(sender As Object, e As EventArgs) Handles txtHeal2.TextChanged
        If Integer.TryParse(txtHeal2.Text, 1) = True And txtHeal2.Text <> "" Then
            If Convert.ToInt32(txtHeal2.Text) > 5 Or Convert.ToInt32(txtHeal2.Text) < 0 Then
                txtHeal2.ForeColor = Color.Red
                btnSave.Enabled = False
            Else
                txtHeal2.ForeColor = Color.Black
                btnSave.Enabled = True
            End If
        Else
            txtHeal2.ForeColor = Color.Red
            btnSave.Enabled = False
        End If
    End Sub

    Private Sub txtHeal3_TextChanged(sender As Object, e As EventArgs) Handles txtHeal3.TextChanged
        If Integer.TryParse(txtHeal3.Text, 1) = True And txtHeal3.Text <> "" Then
            If Convert.ToInt32(txtHeal3.Text) > 5 Or Convert.ToInt32(txtHeal3.Text) < 0 Then
                txtHeal3.ForeColor = Color.Red
                btnSave.Enabled = False
            Else
                txtHeal3.ForeColor = Color.Black
                btnSave.Enabled = True
            End If
        Else
            txtHeal3.ForeColor = Color.Red
            btnSave.Enabled = False
        End If
    End Sub

    Private Sub txtHeal4_TextChanged(sender As Object, e As EventArgs) Handles txtHeal4.TextChanged
        If Integer.TryParse(txtHeal4.Text, 1) = True And txtHeal4.Text <> "" Then
            If Convert.ToInt32(txtHeal4.Text) > 5 Or Convert.ToInt32(txtHeal4.Text) < 0 Then
                txtHeal4.ForeColor = Color.Red
                btnSave.Enabled = False
            Else
                txtHeal4.ForeColor = Color.Black
                btnSave.Enabled = True
            End If
        Else
            txtHeal4.ForeColor = Color.Red
            btnSave.Enabled = False
        End If
    End Sub

    Private Sub txtHeal5_TextChanged(sender As Object, e As EventArgs) Handles txtHeal5.TextChanged
        If Integer.TryParse(txtHeal5.Text, 1) = True And txtHeal5.Text <> "" Then
            If Convert.ToInt32(txtHeal5.Text) > 5 Or Convert.ToInt32(txtHeal5.Text) < 0 Then
                txtHeal5.ForeColor = Color.Red
                btnSave.Enabled = False
            Else
                txtHeal5.ForeColor = Color.Black
                btnSave.Enabled = True
            End If
        Else
            txtHeal5.ForeColor = Color.Red
            btnSave.Enabled = False
        End If
    End Sub

    Private Sub txtHeal6_TextChanged(sender As Object, e As EventArgs) Handles txtHeal6.TextChanged
        If Integer.TryParse(txtHeal6.Text, 1) = True And txtHeal6.Text <> "" Then
            If Convert.ToInt32(txtHeal6.Text) > 5 Or Convert.ToInt32(txtHeal6.Text) < 0 Then
                txtHeal6.ForeColor = Color.Red
                btnSave.Enabled = False
            Else
                txtHeal6.ForeColor = Color.Black
                btnSave.Enabled = True
            End If
        Else
            txtHeal6.ForeColor = Color.Red
            btnSave.Enabled = False
        End If
    End Sub

    Private Sub txtHeal7_TextChanged(sender As Object, e As EventArgs) Handles txtHeal7.TextChanged
        If Integer.TryParse(txtHeal7.Text, 1) = True And txtHeal7.Text <> "" Then
            If Convert.ToInt32(txtHeal7.Text) > 5 Or Convert.ToInt32(txtHeal7.Text) < 0 Then
                txtHeal7.ForeColor = Color.Red
                btnSave.Enabled = False
            Else
                txtHeal7.ForeColor = Color.Black
                btnSave.Enabled = True
            End If
        Else
            txtHeal7.ForeColor = Color.Red
            btnSave.Enabled = False
        End If
    End Sub

    Private Sub txtHeal8_TextChanged(sender As Object, e As EventArgs) Handles txtHeal8.TextChanged
        If Integer.TryParse(txtHeal8.Text, 1) = True And txtHeal8.Text <> "" Then
            If Convert.ToInt32(txtHeal8.Text) > 5 Or Convert.ToInt32(txtHeal8.Text) < 0 Then
                txtHeal8.ForeColor = Color.Red
                btnSave.Enabled = False
            Else
                txtHeal8.ForeColor = Color.Black
                btnSave.Enabled = True
            End If
        Else
            txtHeal8.ForeColor = Color.Red
            btnSave.Enabled = False
        End If
    End Sub

    Private Sub txtHeal9_TextChanged(sender As Object, e As EventArgs) Handles txtHeal9.TextChanged
        If Integer.TryParse(txtHeal9.Text, 1) = True And txtHeal9.Text <> "" Then
            If Convert.ToInt32(txtHeal9.Text) > 5 Or Convert.ToInt32(txtHeal9.Text) < 0 Then
                txtHeal9.ForeColor = Color.Red
                btnSave.Enabled = False
            Else
                txtHeal9.ForeColor = Color.Black
                btnSave.Enabled = True
            End If
        Else
            txtHeal9.ForeColor = Color.Red
            btnSave.Enabled = False
        End If
    End Sub

    Private Sub txtHeal10_TextChanged(sender As Object, e As EventArgs) Handles txtHeal10.TextChanged
        If Integer.TryParse(txtHeal10.Text, 1) = True And txtHeal10.Text <> "" Then
            If Convert.ToInt32(txtHeal10.Text) > 5 Or Convert.ToInt32(txtHeal10.Text) < 0 Then
                txtHeal10.ForeColor = Color.Red
                btnSave.Enabled = False
            Else
                txtHeal10.ForeColor = Color.Black
                btnSave.Enabled = True
            End If
        Else
            txtHeal10.ForeColor = Color.Red
            btnSave.Enabled = False
        End If
    End Sub

    Private Sub txtHeal11_TextChanged(sender As Object, e As EventArgs) Handles txtHeal11.TextChanged
        If Integer.TryParse(txtHeal11.Text, 1) = True And txtHeal11.Text <> "" Then
            If Convert.ToInt32(txtHeal11.Text) > 5 Or Convert.ToInt32(txtHeal11.Text) < 0 Then
                txtHeal11.ForeColor = Color.Red
                btnSave.Enabled = False
            Else
                txtHeal11.ForeColor = Color.Black
                btnSave.Enabled = True
            End If
        Else
            txtHeal11.ForeColor = Color.Red
            btnSave.Enabled = False
        End If
    End Sub

    Private Sub txtHeal12_TextChanged(sender As Object, e As EventArgs) Handles txtHeal12.TextChanged
        If Integer.TryParse(txtHeal12.Text, 1) = True And txtHeal12.Text <> "" Then
            If Convert.ToInt32(txtHeal12.Text) > 5 Or Convert.ToInt32(txtHeal12.Text) < 0 Then
                txtHeal12.ForeColor = Color.Red
                btnSave.Enabled = False
            Else
                txtHeal12.ForeColor = Color.Black
                btnSave.Enabled = True
            End If
        Else
            txtHeal12.ForeColor = Color.Red
            btnSave.Enabled = False
        End If
    End Sub

    Private Sub txtHeal13_TextChanged(sender As Object, e As EventArgs) Handles txtHeal13.TextChanged
        If Integer.TryParse(txtHeal13.Text, 1) = True And txtHeal13.Text <> "" Then
            If Convert.ToInt32(txtHeal13.Text) > 5 Or Convert.ToInt32(txtHeal13.Text) < 0 Then
                txtHeal13.ForeColor = Color.Red
                btnSave.Enabled = False
            Else
                txtHeal13.ForeColor = Color.Black
                btnSave.Enabled = True
            End If
        Else
            txtHeal13.ForeColor = Color.Red
            btnSave.Enabled = False
        End If
    End Sub

    Private Sub txtHeal14_TextChanged(sender As Object, e As EventArgs) Handles txtHeal14.TextChanged
        If Integer.TryParse(txtHeal14.Text, 1) = True And txtHeal14.Text <> "" Then
            If Convert.ToInt32(txtHeal14.Text) > 5 Or Convert.ToInt32(txtHeal14.Text) < 0 Then
                txtHeal14.ForeColor = Color.Red
                btnSave.Enabled = False
            Else
                txtHeal14.ForeColor = Color.Black
                btnSave.Enabled = True
            End If
        Else
            txtHeal14.ForeColor = Color.Red
            btnSave.Enabled = False
        End If
    End Sub

    Private Sub txtHeal15_TextChanged(sender As Object, e As EventArgs) Handles txtHeal15.TextChanged
        If Integer.TryParse(txtHeal15.Text, 1) = True And txtHeal15.Text <> "" Then
            If Convert.ToInt32(txtHeal15.Text) > 5 Or Convert.ToInt32(txtHeal15.Text) < 0 Then
                txtHeal15.ForeColor = Color.Red
                btnSave.Enabled = False
            Else
                txtHeal15.ForeColor = Color.Black
                btnSave.Enabled = True
            End If
        Else
            txtHeal15.ForeColor = Color.Red
            btnSave.Enabled = False
        End If
    End Sub

    Private Sub txtHeal16_TextChanged(sender As Object, e As EventArgs) Handles txtHeal16.TextChanged
        If Integer.TryParse(txtHeal16.Text, 1) = True And txtHeal16.Text <> "" Then
            If Convert.ToInt32(txtHeal16.Text) > 5 Or Convert.ToInt32(txtHeal16.Text) < 0 Then
                txtHeal16.ForeColor = Color.Red
                btnSave.Enabled = False
            Else
                txtHeal16.ForeColor = Color.Black
                btnSave.Enabled = True
            End If
        Else
            txtHeal16.ForeColor = Color.Red
            btnSave.Enabled = False
        End If
    End Sub

    Private Sub txtHeal17_TextChanged(sender As Object, e As EventArgs) Handles txtHeal17.TextChanged
        If Integer.TryParse(txtHeal17.Text, 1) = True And txtHeal17.Text <> "" Then
            If Convert.ToInt32(txtHeal17.Text) > 5 Or Convert.ToInt32(txtHeal17.Text) < 0 Then
                txtHeal17.ForeColor = Color.Red
                btnSave.Enabled = False
            Else
                txtHeal17.ForeColor = Color.Black
                btnSave.Enabled = True
            End If
        Else
            txtHeal17.ForeColor = Color.Red
            btnSave.Enabled = False
        End If
    End Sub

    Private Sub txtHeal18_TextChanged(sender As Object, e As EventArgs) Handles txtHeal18.TextChanged
        If Integer.TryParse(txtHeal18.Text, 1) = True And txtHeal18.Text <> "" Then
            If Convert.ToInt32(txtHeal18.Text) > 5 Or Convert.ToInt32(txtHeal18.Text) < 0 Then
                txtHeal18.ForeColor = Color.Red
                btnSave.Enabled = False
            Else
                txtHeal18.ForeColor = Color.Black
                btnSave.Enabled = True
            End If
        Else
            txtHeal18.ForeColor = Color.Red
            btnSave.Enabled = False
        End If
    End Sub

    Private Sub txtHeal19_TextChanged(sender As Object, e As EventArgs) Handles txtHeal19.TextChanged
        If Integer.TryParse(txtHeal19.Text, 1) = True And txtHeal19.Text <> "" Then
            If Convert.ToInt32(txtHeal19.Text) > 5 Or Convert.ToInt32(txtHeal19.Text) < 0 Then
                txtHeal19.ForeColor = Color.Red
                btnSave.Enabled = False
            Else
                txtHeal19.ForeColor = Color.Black
                btnSave.Enabled = True
            End If
        Else
            txtHeal19.ForeColor = Color.Red
            btnSave.Enabled = False
        End If
    End Sub

    Private Sub txtHeal20_TextChanged(sender As Object, e As EventArgs) Handles txtHeal20.TextChanged
        If Integer.TryParse(txtHeal20.Text, 1) = True And txtHeal20.Text <> "" Then
            If Convert.ToInt32(txtHeal20.Text) > 5 Or Convert.ToInt32(txtHeal20.Text) < 0 Then
                txtHeal20.ForeColor = Color.Red
                btnSave.Enabled = False
            Else
                txtHeal20.ForeColor = Color.Black
                btnSave.Enabled = True
            End If
        Else
            txtHeal20.ForeColor = Color.Red
            btnSave.Enabled = False
        End If
    End Sub

    Private Sub txtHeal21_TextChanged(sender As Object, e As EventArgs) Handles txtHeal21.TextChanged
        If Integer.TryParse(txtHeal21.Text, 1) = True And txtHeal21.Text <> "" Then
            If Convert.ToInt32(txtHeal21.Text) > 5 Or Convert.ToInt32(txtHeal21.Text) < 0 Then
                txtHeal21.ForeColor = Color.Red
                btnSave.Enabled = False
            Else
                txtHeal21.ForeColor = Color.Black
                btnSave.Enabled = True
            End If
        Else
            txtHeal21.ForeColor = Color.Red
            btnSave.Enabled = False
        End If
    End Sub

    Private Sub txtHeal22_TextChanged(sender As Object, e As EventArgs) Handles txtHeal22.TextChanged
        If Integer.TryParse(txtHeal22.Text, 1) = True And txtHeal22.Text <> "" Then
            If Convert.ToInt32(txtHeal22.Text) > 5 Or Convert.ToInt32(txtHeal22.Text) < 0 Then
                txtHeal22.ForeColor = Color.Red
                btnSave.Enabled = False
            Else
                txtHeal22.ForeColor = Color.Black
                btnSave.Enabled = True
            End If
        Else
            txtHeal22.ForeColor = Color.Red
            btnSave.Enabled = False
        End If
    End Sub

    Private Sub txtHeal23_TextChanged(sender As Object, e As EventArgs) Handles txtHeal23.TextChanged
        If Integer.TryParse(txtHeal23.Text, 1) = True And txtHeal23.Text <> "" Then
            If Convert.ToInt32(txtHeal23.Text) > 5 Or Convert.ToInt32(txtHeal23.Text) < 0 Then
                txtHeal23.ForeColor = Color.Red
                btnSave.Enabled = False
            Else
                txtHeal23.ForeColor = Color.Black
                btnSave.Enabled = True
            End If
        Else
            txtHeal23.ForeColor = Color.Red
            btnSave.Enabled = False
        End If
    End Sub

    Private Sub txtHeal24_TextChanged(sender As Object, e As EventArgs) Handles txtHeal24.TextChanged
        If Integer.TryParse(txtHeal24.Text, 1) = True And txtHeal24.Text <> "" Then
            If Convert.ToInt32(txtHeal24.Text) > 5 Or Convert.ToInt32(txtHeal24.Text) < 0 Then
                txtHeal24.ForeColor = Color.Red
                btnSave.Enabled = False
            Else
                txtHeal24.ForeColor = Color.Black
                btnSave.Enabled = True
            End If
        Else
            txtHeal24.ForeColor = Color.Red
            btnSave.Enabled = False
        End If
    End Sub

    Private Sub txtHeal25_TextChanged(sender As Object, e As EventArgs) Handles txtHeal25.TextChanged
        If Integer.TryParse(txtHeal25.Text, 1) = True And txtHeal25.Text <> "" Then
            If Convert.ToInt32(txtHeal25.Text) > 5 Or Convert.ToInt32(txtHeal25.Text) < 0 Then
                txtHeal25.ForeColor = Color.Red
                btnSave.Enabled = False
            Else
                txtHeal25.ForeColor = Color.Black
                btnSave.Enabled = True
            End If
        Else
            txtHeal25.ForeColor = Color.Red
            btnSave.Enabled = False
        End If
    End Sub

    Private Sub txtHeal26_TextChanged(sender As Object, e As EventArgs) Handles txtHeal26.TextChanged
        If Integer.TryParse(txtHeal26.Text, 1) = True And txtHeal26.Text <> "" Then
            If Convert.ToInt32(txtHeal26.Text) > 5 Or Convert.ToInt32(txtHeal26.Text) < 0 Then
                txtHeal26.ForeColor = Color.Red
                btnSave.Enabled = False
            Else
                txtHeal26.ForeColor = Color.Black
                btnSave.Enabled = True
            End If
        Else
            txtHeal26.ForeColor = Color.Red
            btnSave.Enabled = False
        End If
    End Sub

    Private Sub txtHeal27_TextChanged(sender As Object, e As EventArgs) Handles txtHeal27.TextChanged
        If Integer.TryParse(txtHeal27.Text, 1) = True And txtHeal27.Text <> "" Then
            If Convert.ToInt32(txtHeal27.Text) > 5 Or Convert.ToInt32(txtHeal27.Text) < 0 Then
                txtHeal27.ForeColor = Color.Red
                btnSave.Enabled = False
            Else
                txtHeal27.ForeColor = Color.Black
                btnSave.Enabled = True
            End If
        Else
            txtHeal27.ForeColor = Color.Red
            btnSave.Enabled = False
        End If
    End Sub

    Private Sub txtHeal28_TextChanged(sender As Object, e As EventArgs) Handles txtHeal28.TextChanged
        If Integer.TryParse(txtHeal28.Text, 1) = True And txtHeal28.Text <> "" Then
            If Convert.ToInt32(txtHeal28.Text) > 5 Or Convert.ToInt32(txtHeal28.Text) < 0 Then
                txtHeal28.ForeColor = Color.Red
                btnSave.Enabled = False
            Else
                txtHeal28.ForeColor = Color.Black
                btnSave.Enabled = True
            End If
        Else
            txtHeal28.ForeColor = Color.Red
            btnSave.Enabled = False
        End If
    End Sub

    Private Sub btnFill_Click(sender As Object, e As EventArgs) Handles btnFill.Click
        For Each Ctrl As Control In Me.Controls
            If TypeOf Ctrl Is TextBox And Ctrl.Text = "" Then
                Ctrl.Text = "0"
            End If
        Next
    End Sub
End Class