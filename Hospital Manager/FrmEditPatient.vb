'Edit patient info form

Public Class FrmEditPatient
    Public selectedPatient As String = Nothing

    'open file then save
    Private Sub SaveChanges()
        My.Computer.FileSystem.DeleteDirectory(FrmMain.pathPatients & selectedPatient, FileIO.DeleteDirectoryOption.DeleteAllContents)
        Dim pathPatient As String = FrmMain.pathPatients & TextBox8.Text & " - " & TextBox1.Text & "\"
        My.Computer.FileSystem.CreateDirectory(pathPatient)
        Dim interactiveControls() As Control = {TextBox1, TextBox8, ComboBox1, ComboBox2, ComboBox3, ComboBox4, TextBox2, TextBox3, TextBox4, TextBox5, TextBox6, TextBox7}
        Dim sWriter As New IO.StreamWriter(pathPatient & "patientInfo.txt")
        For Each ctrl As Control In interactiveControls
            If ctrl Is ComboBox2 Or ctrl Is ComboBox3 Then
                sWriter.Write(ctrl.Text & "/")
            Else
                sWriter.WriteLine(ctrl.Text)
            End If
        Next
        sWriter.Close()
        PictureBox1.Image.Save(pathPatient & "imgPatient.png", Imaging.ImageFormat.Png)
        FrmMain.FlowLayoutPanel2.Controls.Clear()
        FrmMain.LoadPatients()
        FrmPatientInfo.Show(FrmMain)
        FrmPatientInfo.selectedPatient = TextBox8.Text & " - " & TextBox1.Text
        Close()
    End Sub

    'on load
    Private Sub FrmEditPatient_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
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
    End Sub

    'esc/enter key press
    Private Sub FrmEditPatient_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Close()
        ElseIf e.KeyCode = Keys.Enter Then
            SaveChanges()
        End If
    End Sub

    'when picture box is clicked to load new pic
    Private Sub PictureBox1_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles PictureBox1.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                PictureBox1.Load(OpenFileDialog1.FileName)
                If (PictureBox1.Image.Size.Width > PictureBox1.Size.Width) And (PictureBox1.Image.Size.Height > PictureBox1.Size.Height) Then
                    PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
                Else
                    PictureBox1.SizeMode = PictureBoxSizeMode.CenterImage
                End If
            End If
        End If
    End Sub

    'save button
    Private Sub btnSave_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSave.Click
        SaveChanges()
    End Sub

    'close form
    Private Sub btnClose_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnClose.Click
        Close()
    End Sub
End Class