'Patient Form

Imports System.IO

Public Class FrmPatient
    'check for fill
    Private Function CheckTools()
        If String.IsNullOrWhiteSpace(TextBox1.Text) Or String.IsNullOrWhiteSpace(ComboBox1.Text) Or String.IsNullOrWhiteSpace(ComboBox2.Text) _
             Or String.IsNullOrWhiteSpace(ComboBox3.Text) Or String.IsNullOrWhiteSpace(ComboBox4.Text) Or String.IsNullOrWhiteSpace(TextBox2.Text) _
              Or String.IsNullOrWhiteSpace(TextBox3.Text) Or String.IsNullOrWhiteSpace(TextBox4.Text) Or String.IsNullOrWhiteSpace(TextBox5.Text) _
              Or String.IsNullOrWhiteSpace(TextBox6.Text) Or String.IsNullOrWhiteSpace(TextBox7.Text) Or String.IsNullOrWhiteSpace(TextBox8.Text) Then
            MessageBox.Show("Please make sure all data has been entered.", "Hospital Manager", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
        End If
        Return True
    End Function

    'Add new patient
    Private Sub AddPatient()
        If CheckTools() Then
            'Write patient to file
            Dim pathPatient As String = FrmMain.pathPatients & TextBox8.Text & " - " & TextBox1.Text & "\"
            My.Computer.FileSystem.CreateDirectory(pathPatient)
            Dim interactiveControls() As Control = {TextBox1, TextBox8, ComboBox1, ComboBox2, ComboBox3, ComboBox4, TextBox2, TextBox3, TextBox4, TextBox5, TextBox6, TextBox7}
            Dim sWriter As New StreamWriter(pathPatient & "patientInfo.txt")
            For Each ctrl As Control In interactiveControls
                If ctrl Is ComboBox2 Or ctrl Is ComboBox3 Then
                    sWriter.Write(ctrl.Text & "/")
                Else
                    sWriter.WriteLine(ctrl.Text)
                End If
            Next
            sWriter.Close()
            PictureBox1.Image.Save(pathPatient & "imgPatient.png", Imaging.ImageFormat.Png)
            sWriter = New StreamWriter(FrmMain.pathGeneric & "PID.txt")
            sWriter.Write(FrmMain.PID + 1)
            sWriter.Close()

            ' patient view update
            FrmMain.UpdateFPanel2()
            Close()
        End If
    End Sub

    'on load
    Private Sub FrmPatient_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Location = New Point(FrmMain.Left + 25, FrmMain.Top + 45)
        For x = 1 To 31
            ComboBox2.Items.Add(x)
            If x < 13 Then
                ComboBox3.Items.Add(x)
            End If
        Next
        For x = 1900 To Date.UtcNow.Year
            ComboBox4.Items.Add(x)
        Next
        FrmMain.LoadGeneric()
        TextBox8.Text = FrmMain.PID
        PictureBox1.Image = My.Resources.iconPatient72
    End Sub

    'esc/enter press
    Private Sub FrmPatient_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Close()
        ElseIf e.KeyCode = Keys.Enter Then
            AddPatient()
        End If
    End Sub

    'add button
    Private Sub btnAdd_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnAdd.Click
        AddPatient()
    End Sub

    'close form
    Private Sub btnClose_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnClose.Click
        Close()
    End Sub

    'clear text
    Private Sub btnClear_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnClear.Click
        Dim msgReply = MessageBox.Show("Clear the patient data?", "Hospital Manager", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        Dim intControls() As Control = {TextBox1, ComboBox1, ComboBox2, ComboBox3, ComboBox4, TextBox2, TextBox3, TextBox4, TextBox5, TextBox6, TextBox7}
        If msgReply = Windows.Forms.DialogResult.Yes Then
            For Each ctrl As Control In intControls
                ctrl.Text = ""
            Next
            PictureBox1.SizeMode = PictureBoxSizeMode.CenterImage
            PictureBox1.Image = My.Resources.iconPatient72
        End If
    End Sub

    'text mod
    Private Sub TextBox8_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles TextBox8.TextChanged
        TextBox8.Text = FrmMain.PID
    End Sub

    'press picture to add 
    Private Sub PictureBox1_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles PictureBox1.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
                PictureBox1.Load(OpenFileDialog1.FileName)
            End If
        End If
    End Sub

End Class