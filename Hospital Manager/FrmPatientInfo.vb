'Patient info form

Public Class FrmPatientInfo
    Public selectedPatient As String = Nothing

    'del patient info
    Private Sub DeletePatient()
        Dim msgReply = MessageBox.Show("Remove this patient?", "Hospital Manager", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If msgReply = Windows.Forms.DialogResult.Yes Then
            Close()
            My.Computer.FileSystem.DeleteDirectory(FrmMain.pathPatients & selectedPatient, FileIO.DeleteDirectoryOption.DeleteAllContents)
            FrmMain.FlowLayoutPanel2.Controls.Clear()
            FrmMain.LoadPatients()
        End If
    End Sub

    Private Sub FrmPatientInfo_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Location = New Point(FrmMain.Left + 25, FrmMain.Top + 45)
    End Sub

    'show patient info main
    Private Sub FrmPatientInfo_Shown(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Shown
        Dim lblControls() As Label = {lblName, lblID, lblGender, lblBirthDate, lblCountry, lblCity, lblPostalCode, lblContactNumber, lblAddress, lblEmailAddress}
        Dim sReader As New IO.StreamReader(FrmMain.pathStorage & "Patients\" & selectedPatient & "\patientInfo.txt")
        Dim strValues(11) As String
        Dim counter As Integer = 0
        While sReader.Peek <> -1
            strValues(counter) = sReader.ReadLine
            counter += 1
        End While
        counter = 0
        For Each lbl As Label In lblControls
            lbl.Text = strValues(counter)
            counter += 1
        Next
        sReader.Close()

        PictureBox1.Load(FrmMain.pathStorage & "Patients\" & selectedPatient & "\imgPatient.png")
        If (PictureBox1.Image.Size.Width > PictureBox1.Size.Width) And (PictureBox1.Image.Size.Height > PictureBox1.Size.Height) Then
            PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
            FrmEditPatient.PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        Else
            PictureBox1.SizeMode = PictureBoxSizeMode.CenterImage
            FrmEditPatient.PictureBox1.SizeMode = PictureBoxSizeMode.CenterImage
        End If
    End Sub

    'esc/emter press
    Private Sub Form3_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Close()
        ElseIf e.KeyCode = Keys.Delete Then
            DeletePatient()
        End If
    End Sub


    'Edit button click
    Private Sub btnEdit_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnEdit.Click
        'Edit patient
        Dim counter As Integer = 0 : Dim tempMemory As String = Nothing : Dim slashesFound As Integer = 0 : Dim bDay As String = Nothing : Dim bMonth As String = Nothing : Dim bYear As String = Nothing
        For x = 0 To lblBirthDate.Text.Length - 1
            If lblBirthDate.Text.Substring(x, 1) = "/" Then
                If slashesFound = 0 Then
                    bDay = tempMemory
                    slashesFound += 1
                ElseIf slashesFound = 1 Then
                    bMonth = tempMemory
                    bYear = lblBirthDate.Text.Substring(x + 1, 4)
                End If
                tempMemory = ""
            Else
                tempMemory &= lblBirthDate.Text.Substring(x, 1)
            End If
        Next
        Dim allControls() As Control = {FrmEditPatient.TextBox1, FrmEditPatient.TextBox8, FrmEditPatient.ComboBox1, FrmEditPatient.ComboBox2, FrmEditPatient.ComboBox3, FrmEditPatient.ComboBox4, FrmEditPatient.TextBox2, FrmEditPatient.TextBox3, FrmEditPatient.TextBox4, FrmEditPatient.TextBox5, FrmEditPatient.TextBox6, FrmEditPatient.TextBox7}
        Dim allData() As String = {lblName.Text, lblID.Text, lblGender.Text, bDay, bMonth, bYear, lblCountry.Text, lblCity.Text, lblPostalCode.Text, lblContactNumber.Text, lblAddress.Text, lblEmailAddress.Text}
        For Each ctrl As Control In allControls
            ctrl.Text = allData(counter) : counter += 1
        Next
        FrmEditPatient.PictureBox1.Image = PictureBox1.Image.Clone
        FrmEditPatient.selectedPatient = lblID.Text & " - " & lblName.Text
        FrmEditPatient.TextBox1.SelectionStart = FrmEditPatient.TextBox1.TextLength : FrmEditPatient.Show(FrmMain) : Close()
    End Sub

    'remove button
    Private Sub btnRemove_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnRemove.Click
        DeletePatient()
    End Sub

    'close form
    Private Sub btnClose_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnClose.Click
        Close()
    End Sub

End Class