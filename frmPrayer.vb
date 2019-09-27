Imports System.Runtime.InteropServices
Public Class frmPrayer
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
    Private Sub frmPrayer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Location = New Point(frmSettings.Location.X + frmSettings.Width + 10, frmSettings.Location.Y + frmSettings.Height / 2 - Me.Height / 2)
        frmSettings.Enabled = False
    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim File As System.IO.StreamWriter
        Dim PrayerArray(27) As String
        For Each Ctrl As Control In Me.Controls
            If TypeOf Ctrl Is TextBox Then
                If Ctrl.Text = "" Then
                    frmMessageBox.lblHeader.Text = "Prayer Set-Up Error"
                    frmMessageBox.lblMessageText.Text = "Enter Values Into Each TextBox Before Saving!"
                    frmMessageBox.ShowDialog()
                    Exit Sub
                End If
            End If
        Next
        For Each Ctrl As Control In Me.Controls
            If TypeOf Ctrl Is TextBox Then
                PrayerArray(Ctrl.TabIndex - 1) = Ctrl.Text
            End If
        Next
        If System.IO.File.Exists(frmMain.DriveLetter & "RSAutoClicker\Prayer.csv") = True Then
            My.Computer.FileSystem.DeleteFile(frmMain.DriveLetter & "RSAutoClicker\Prayer.csv")
        End If
        File = My.Computer.FileSystem.OpenTextFileWriter(frmMain.DriveLetter & "RSAutoClicker\Prayer.csv", True)
        For i = 0 To 27
            File.WriteLine(PrayerArray(i))
        Next
        File.Close()
        frmSettings.Enabled = True
        Me.Close()
    End Sub
    Private Sub btnFill_Click(sender As Object, e As EventArgs) Handles btnFill.Click
        For Each Ctrl As Control In Me.Controls
            If TypeOf Ctrl Is TextBox And Ctrl.Text = "" Then
                Ctrl.Text = "0"
            End If
        Next
    End Sub
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        frmSettings.Enabled = True
        Me.Close()
        Exit Sub
    End Sub
    Private Sub txtPrayer1_TextChanged(sender As Object, e As EventArgs) Handles txtPrayer1.TextChanged
        If Integer.TryParse(txtPrayer1.Text, 1) = True And txtPrayer1.Text <> "" Then
            If Convert.ToInt32(txtPrayer1.Text) > 5 Or Convert.ToInt32(txtPrayer1.Text) < 0 Then
                txtPrayer1.ForeColor = Color.Red
                btnSave.Enabled = False
            Else
                txtPrayer1.ForeColor = Color.Black
                btnSave.Enabled = True
            End If
        Else
            txtPrayer1.ForeColor = Color.Red
            btnSave.Enabled = False
        End If
    End Sub
    Private Sub txtPrayer2_TextChanged(sender As Object, e As EventArgs) Handles txtPrayer2.TextChanged
        If Integer.TryParse(txtPrayer2.Text, 1) = True And txtPrayer2.Text <> "" Then
            If Convert.ToInt32(txtPrayer2.Text) > 5 Or Convert.ToInt32(txtPrayer2.Text) < 0 Then
                txtPrayer2.ForeColor = Color.Red
                btnSave.Enabled = False
            Else
                txtPrayer2.ForeColor = Color.Black
                btnSave.Enabled = True
            End If
        Else
            txtPrayer2.ForeColor = Color.Red
            btnSave.Enabled = False
        End If
    End Sub
    Private Sub txtPrayer3_TextChanged(sender As Object, e As EventArgs) Handles txtPrayer3.TextChanged
        If Integer.TryParse(txtPrayer3.Text, 1) = True And txtPrayer3.Text <> "" Then
            If Convert.ToInt32(txtPrayer3.Text) > 5 Or Convert.ToInt32(txtPrayer3.Text) < 0 Then
                txtPrayer3.ForeColor = Color.Red
                btnSave.Enabled = False
            Else
                txtPrayer3.ForeColor = Color.Black
                btnSave.Enabled = True
            End If
        Else
            txtPrayer3.ForeColor = Color.Red
            btnSave.Enabled = False
        End If
    End Sub
    Private Sub txtPrayer4_TextChanged(sender As Object, e As EventArgs) Handles txtPrayer4.TextChanged
        If Integer.TryParse(txtPrayer4.Text, 1) = True And txtPrayer4.Text <> "" Then
            If Convert.ToInt32(txtPrayer4.Text) > 5 Or Convert.ToInt32(txtPrayer4.Text) < 0 Then
                txtPrayer4.ForeColor = Color.Red
                btnSave.Enabled = False
            Else
                txtPrayer4.ForeColor = Color.Black
                btnSave.Enabled = True
            End If
        Else
            txtPrayer4.ForeColor = Color.Red
            btnSave.Enabled = False
        End If
    End Sub

    Private Sub txtPrayer5_TextChanged(sender As Object, e As EventArgs) Handles txtPrayer5.TextChanged
        If Integer.TryParse(txtPrayer5.Text, 1) = True And txtPrayer5.Text <> "" Then
            If Convert.ToInt32(txtPrayer5.Text) > 5 Or Convert.ToInt32(txtPrayer5.Text) < 0 Then
                txtPrayer5.ForeColor = Color.Red
                btnSave.Enabled = False
            Else
                txtPrayer5.ForeColor = Color.Black
                btnSave.Enabled = True
            End If
        Else
            txtPrayer5.ForeColor = Color.Red
            btnSave.Enabled = False
        End If
    End Sub

    Private Sub txtPrayer6_TextChanged(sender As Object, e As EventArgs) Handles txtPrayer6.TextChanged
        If Integer.TryParse(txtPrayer6.Text, 1) = True And txtPrayer6.Text <> "" Then
            If Convert.ToInt32(txtPrayer6.Text) > 5 Or Convert.ToInt32(txtPrayer6.Text) < 0 Then
                txtPrayer6.ForeColor = Color.Red
                btnSave.Enabled = False
            Else
                txtPrayer6.ForeColor = Color.Black
                btnSave.Enabled = True
            End If
        Else
            txtPrayer6.ForeColor = Color.Red
            btnSave.Enabled = False
        End If
    End Sub

    Private Sub txtPrayer7_TextChanged(sender As Object, e As EventArgs) Handles txtPrayer7.TextChanged
        If Integer.TryParse(txtPrayer7.Text, 1) = True And txtPrayer7.Text <> "" Then
            If Convert.ToInt32(txtPrayer7.Text) > 5 Or Convert.ToInt32(txtPrayer7.Text) < 0 Then
                txtPrayer7.ForeColor = Color.Red
                btnSave.Enabled = False
            Else
                txtPrayer7.ForeColor = Color.Black
                btnSave.Enabled = True
            End If
        Else
            txtPrayer7.ForeColor = Color.Red
            btnSave.Enabled = False
        End If
    End Sub

    Private Sub txtPrayer8_TextChanged(sender As Object, e As EventArgs) Handles txtPrayer8.TextChanged
        If Integer.TryParse(txtPrayer8.Text, 1) = True And txtPrayer8.Text <> "" Then
            If Convert.ToInt32(txtPrayer8.Text) > 5 Or Convert.ToInt32(txtPrayer8.Text) < 0 Then
                txtPrayer8.ForeColor = Color.Red
                btnSave.Enabled = False
            Else
                txtPrayer8.ForeColor = Color.Black
                btnSave.Enabled = True
            End If
        Else
            txtPrayer8.ForeColor = Color.Red
            btnSave.Enabled = False
        End If
    End Sub

    Private Sub txtPrayer9_TextChanged(sender As Object, e As EventArgs) Handles txtPrayer9.TextChanged
        If Integer.TryParse(txtPrayer9.Text, 1) = True And txtPrayer9.Text <> "" Then
            If Convert.ToInt32(txtPrayer9.Text) > 5 Or Convert.ToInt32(txtPrayer9.Text) < 0 Then
                txtPrayer9.ForeColor = Color.Red
                btnSave.Enabled = False
            Else
                txtPrayer9.ForeColor = Color.Black
                btnSave.Enabled = True
            End If
        Else
            txtPrayer9.ForeColor = Color.Red
            btnSave.Enabled = False
        End If
    End Sub

    Private Sub txtPrayer10_TextChanged(sender As Object, e As EventArgs) Handles txtPrayer10.TextChanged
        If Integer.TryParse(txtPrayer10.Text, 1) = True And txtPrayer10.Text <> "" Then
            If Convert.ToInt32(txtPrayer10.Text) > 5 Or Convert.ToInt32(txtPrayer10.Text) < 0 Then
                txtPrayer10.ForeColor = Color.Red
                btnSave.Enabled = False
            Else
                txtPrayer10.ForeColor = Color.Black
                btnSave.Enabled = True
            End If
        Else
            txtPrayer10.ForeColor = Color.Red
            btnSave.Enabled = False
        End If
    End Sub

    Private Sub txtPrayer11_TextChanged(sender As Object, e As EventArgs) Handles txtPrayer11.TextChanged
        If Integer.TryParse(txtPrayer11.Text, 1) = True And txtPrayer11.Text <> "" Then
            If Convert.ToInt32(txtPrayer11.Text) > 5 Or Convert.ToInt32(txtPrayer11.Text) < 0 Then
                txtPrayer11.ForeColor = Color.Red
                btnSave.Enabled = False
            Else
                txtPrayer11.ForeColor = Color.Black
                btnSave.Enabled = True
            End If
        Else
            txtPrayer11.ForeColor = Color.Red
            btnSave.Enabled = False
        End If
    End Sub

    Private Sub txtPrayer12_TextChanged(sender As Object, e As EventArgs) Handles txtPrayer12.TextChanged
        If Integer.TryParse(txtPrayer12.Text, 1) = True And txtPrayer12.Text <> "" Then
            If Convert.ToInt32(txtPrayer12.Text) > 5 Or Convert.ToInt32(txtPrayer12.Text) < 0 Then
                txtPrayer12.ForeColor = Color.Red
                btnSave.Enabled = False
            Else
                txtPrayer12.ForeColor = Color.Black
                btnSave.Enabled = True
            End If
        Else
            txtPrayer12.ForeColor = Color.Red
            btnSave.Enabled = False
        End If
    End Sub

    Private Sub txtPrayer13_TextChanged(sender As Object, e As EventArgs) Handles txtPrayer13.TextChanged
        If Integer.TryParse(txtPrayer13.Text, 1) = True And txtPrayer13.Text <> "" Then
            If Convert.ToInt32(txtPrayer13.Text) > 5 Or Convert.ToInt32(txtPrayer13.Text) < 0 Then
                txtPrayer13.ForeColor = Color.Red
                btnSave.Enabled = False
            Else
                txtPrayer13.ForeColor = Color.Black
                btnSave.Enabled = True
            End If
        Else
            txtPrayer13.ForeColor = Color.Red
            btnSave.Enabled = False
        End If
    End Sub

    Private Sub txtPrayer14_TextChanged(sender As Object, e As EventArgs) Handles txtPrayer14.TextChanged
        If Integer.TryParse(txtPrayer14.Text, 1) = True And txtPrayer14.Text <> "" Then
            If Convert.ToInt32(txtPrayer14.Text) > 5 Or Convert.ToInt32(txtPrayer14.Text) < 0 Then
                txtPrayer14.ForeColor = Color.Red
                btnSave.Enabled = False
            Else
                txtPrayer14.ForeColor = Color.Black
                btnSave.Enabled = True
            End If
        Else
            txtPrayer14.ForeColor = Color.Red
            btnSave.Enabled = False
        End If
    End Sub

    Private Sub txtPrayer15_TextChanged(sender As Object, e As EventArgs) Handles txtPrayer15.TextChanged
        If Integer.TryParse(txtPrayer15.Text, 1) = True And txtPrayer15.Text <> "" Then
            If Convert.ToInt32(txtPrayer15.Text) > 5 Or Convert.ToInt32(txtPrayer15.Text) < 0 Then
                txtPrayer15.ForeColor = Color.Red
                btnSave.Enabled = False
            Else
                txtPrayer15.ForeColor = Color.Black
                btnSave.Enabled = True
            End If
        Else
            txtPrayer15.ForeColor = Color.Red
            btnSave.Enabled = False
        End If
    End Sub

    Private Sub txtPrayer16_TextChanged(sender As Object, e As EventArgs) Handles txtPrayer16.TextChanged
        If Integer.TryParse(txtPrayer16.Text, 1) = True And txtPrayer16.Text <> "" Then
            If Convert.ToInt32(txtPrayer16.Text) > 5 Or Convert.ToInt32(txtPrayer16.Text) < 0 Then
                txtPrayer16.ForeColor = Color.Red
                btnSave.Enabled = False
            Else
                txtPrayer16.ForeColor = Color.Black
                btnSave.Enabled = True
            End If
        Else
            txtPrayer16.ForeColor = Color.Red
            btnSave.Enabled = False
        End If
    End Sub

    Private Sub txtPrayer17_TextChanged(sender As Object, e As EventArgs) Handles txtPrayer17.TextChanged
        If Integer.TryParse(txtPrayer17.Text, 1) = True And txtPrayer17.Text <> "" Then
            If Convert.ToInt32(txtPrayer17.Text) > 5 Or Convert.ToInt32(txtPrayer17.Text) < 0 Then
                txtPrayer17.ForeColor = Color.Red
                btnSave.Enabled = False
            Else
                txtPrayer17.ForeColor = Color.Black
                btnSave.Enabled = True
            End If
        Else
            txtPrayer17.ForeColor = Color.Red
            btnSave.Enabled = False
        End If
    End Sub

    Private Sub txtPrayer18_TextChanged(sender As Object, e As EventArgs) Handles txtPrayer18.TextChanged
        If Integer.TryParse(txtPrayer18.Text, 1) = True And txtPrayer18.Text <> "" Then
            If Convert.ToInt32(txtPrayer18.Text) > 5 Or Convert.ToInt32(txtPrayer18.Text) < 0 Then
                txtPrayer18.ForeColor = Color.Red
                btnSave.Enabled = False
            Else
                txtPrayer18.ForeColor = Color.Black
                btnSave.Enabled = True
            End If
        Else
            txtPrayer18.ForeColor = Color.Red
            btnSave.Enabled = False
        End If
    End Sub

    Private Sub txtPrayer19_TextChanged(sender As Object, e As EventArgs) Handles txtPrayer19.TextChanged
        If Integer.TryParse(txtPrayer19.Text, 1) = True And txtPrayer19.Text <> "" Then
            If Convert.ToInt32(txtPrayer19.Text) > 5 Or Convert.ToInt32(txtPrayer19.Text) < 0 Then
                txtPrayer19.ForeColor = Color.Red
                btnSave.Enabled = False
            Else
                txtPrayer19.ForeColor = Color.Black
                btnSave.Enabled = True
            End If
        Else
            txtPrayer19.ForeColor = Color.Red
            btnSave.Enabled = False
        End If
    End Sub

    Private Sub txtPrayer20_TextChanged(sender As Object, e As EventArgs) Handles txtPrayer20.TextChanged
        If Integer.TryParse(txtPrayer20.Text, 1) = True And txtPrayer20.Text <> "" Then
            If Convert.ToInt32(txtPrayer20.Text) > 5 Or Convert.ToInt32(txtPrayer20.Text) < 0 Then
                txtPrayer20.ForeColor = Color.Red
                btnSave.Enabled = False
            Else
                txtPrayer20.ForeColor = Color.Black
                btnSave.Enabled = True
            End If
        Else
            txtPrayer20.ForeColor = Color.Red
            btnSave.Enabled = False
        End If
    End Sub

    Private Sub txtPrayer21_TextChanged(sender As Object, e As EventArgs) Handles txtPrayer21.TextChanged
        If Integer.TryParse(txtPrayer21.Text, 1) = True And txtPrayer21.Text <> "" Then
            If Convert.ToInt32(txtPrayer21.Text) > 5 Or Convert.ToInt32(txtPrayer21.Text) < 0 Then
                txtPrayer21.ForeColor = Color.Red
                btnSave.Enabled = False
            Else
                txtPrayer21.ForeColor = Color.Black
                btnSave.Enabled = True
            End If
        Else
            txtPrayer21.ForeColor = Color.Red
            btnSave.Enabled = False
        End If
    End Sub

    Private Sub txtPrayer22_TextChanged(sender As Object, e As EventArgs) Handles txtPrayer22.TextChanged
        If Integer.TryParse(txtPrayer22.Text, 1) = True And txtPrayer22.Text <> "" Then
            If Convert.ToInt32(txtPrayer22.Text) > 5 Or Convert.ToInt32(txtPrayer22.Text) < 0 Then
                txtPrayer22.ForeColor = Color.Red
                btnSave.Enabled = False
            Else
                txtPrayer22.ForeColor = Color.Black
                btnSave.Enabled = True
            End If
        Else
            txtPrayer22.ForeColor = Color.Red
            btnSave.Enabled = False
        End If
    End Sub

    Private Sub txtPrayer23_TextChanged(sender As Object, e As EventArgs) Handles txtPrayer23.TextChanged
        If Integer.TryParse(txtPrayer23.Text, 1) = True And txtPrayer23.Text <> "" Then
            If Convert.ToInt32(txtPrayer23.Text) > 5 Or Convert.ToInt32(txtPrayer23.Text) < 0 Then
                txtPrayer23.ForeColor = Color.Red
                btnSave.Enabled = False
            Else
                txtPrayer23.ForeColor = Color.Black
                btnSave.Enabled = True
            End If
        Else
            txtPrayer23.ForeColor = Color.Red
            btnSave.Enabled = False
        End If
    End Sub

    Private Sub txtPrayer24_TextChanged(sender As Object, e As EventArgs) Handles txtPrayer24.TextChanged
        If Integer.TryParse(txtPrayer24.Text, 1) = True And txtPrayer24.Text <> "" Then
            If Convert.ToInt32(txtPrayer24.Text) > 5 Or Convert.ToInt32(txtPrayer24.Text) < 0 Then
                txtPrayer24.ForeColor = Color.Red
                btnSave.Enabled = False
            Else
                txtPrayer24.ForeColor = Color.Black
                btnSave.Enabled = True
            End If
        Else
            txtPrayer24.ForeColor = Color.Red
            btnSave.Enabled = False
        End If
    End Sub

    Private Sub txtPrayer25_TextChanged(sender As Object, e As EventArgs) Handles txtPrayer25.TextChanged
        If Integer.TryParse(txtPrayer25.Text, 1) = True And txtPrayer25.Text <> "" Then
            If Convert.ToInt32(txtPrayer25.Text) > 5 Or Convert.ToInt32(txtPrayer25.Text) < 0 Then
                txtPrayer25.ForeColor = Color.Red
                btnSave.Enabled = False
            Else
                txtPrayer25.ForeColor = Color.Black
                btnSave.Enabled = True
            End If
        Else
            txtPrayer25.ForeColor = Color.Red
            btnSave.Enabled = False
        End If
    End Sub

    Private Sub txtPrayer26_TextChanged(sender As Object, e As EventArgs) Handles txtPrayer26.TextChanged
        If Integer.TryParse(txtPrayer26.Text, 1) = True And txtPrayer26.Text <> "" Then
            If Convert.ToInt32(txtPrayer26.Text) > 5 Or Convert.ToInt32(txtPrayer26.Text) < 0 Then
                txtPrayer26.ForeColor = Color.Red
                btnSave.Enabled = False
            Else
                txtPrayer26.ForeColor = Color.Black
                btnSave.Enabled = True
            End If
        Else
            txtPrayer26.ForeColor = Color.Red
            btnSave.Enabled = False
        End If
    End Sub

    Private Sub txtPrayer27_TextChanged(sender As Object, e As EventArgs) Handles txtPrayer27.TextChanged
        If Integer.TryParse(txtPrayer27.Text, 1) = True And txtPrayer27.Text <> "" Then
            If Convert.ToInt32(txtPrayer27.Text) > 5 Or Convert.ToInt32(txtPrayer27.Text) < 0 Then
                txtPrayer27.ForeColor = Color.Red
                btnSave.Enabled = False
            Else
                txtPrayer27.ForeColor = Color.Black
                btnSave.Enabled = True
            End If
        Else
            txtPrayer27.ForeColor = Color.Red
            btnSave.Enabled = False
        End If
    End Sub

    Private Sub txtPrayer28_TextChanged(sender As Object, e As EventArgs) Handles txtPrayer28.TextChanged
        If Integer.TryParse(txtPrayer28.Text, 1) = True And txtPrayer28.Text <> "" Then
            If Convert.ToInt32(txtPrayer28.Text) > 5 Or Convert.ToInt32(txtPrayer28.Text) < 0 Then
                txtPrayer28.ForeColor = Color.Red
                btnSave.Enabled = False
            Else
                txtPrayer28.ForeColor = Color.Black
                btnSave.Enabled = True
            End If
        Else
            txtPrayer28.ForeColor = Color.Red
            btnSave.Enabled = False
        End If
    End Sub
End Class