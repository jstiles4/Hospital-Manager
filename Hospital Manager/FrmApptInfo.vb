'Appointment info form

Imports System.IO

Public Class FrmApptInfo
    Public selectedAppointment As String = Nothing

    'Remove appt.
    Private Sub DeleteAppointment()
        Dim msgReply = MessageBox.Show("Remove this appointment?", "Hospital Manager", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If msgReply = Windows.Forms.DialogResult.Yes Then
            Dim pathToRemove As String = FrmMain.pathAppointments & lblPatientName.Text & " - " & lblCaseType.Text
            My.Computer.FileSystem.DeleteDirectory(pathToRemove, FileIO.DeleteDirectoryOption.DeleteAllContents)
            FrmMain.FlowLayoutPanel3.Controls.Clear()
            FrmMain.LoadAppointments()
            Close()
        End If
    End Sub

    'on load
    Private Sub FrmApptInfo_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Location = New Point(FrmMain.Left + 25, FrmMain.Top + 45)
    End Sub

    'Shown on main
    Private Sub FrmApptInfo_Shown(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Shown
        'Load data
        Dim sReader As New StreamReader(FrmMain.pathAppointments & selectedAppointment & "\appointmentData.txt")
        Dim lbData As New ListBox
        While sReader.Peek <> -1
            lbData.Items.Add(sReader.ReadLine)
        End While
        sReader.Close()

        'populate data
        lblPatientName.Text = lbData.Items(1)
        lblCaseType.Text = lbData.Items(0)
        lblDate.Text = lbData.Items(2)
        lblTime.Text = lbData.Items(3) & ":" & lbData.Items(4)
        lblAppointmentFor.Text = lbData.Items(5)
        lblLocation.Text = lbData.Items(6)
    End Sub

    'esc/enter press
    Private Sub FrmApptInfo_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Close()
        ElseIf e.KeyCode = Keys.Delete Then
            DeleteAppointment()
        End If
    End Sub

    'edit button
    Private Sub btnEdit_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnEdit.Click
        Dim dataControls() As Control = {FrmAppt.TextBox1, FrmAppt.lblPatientName, FrmAppt.DateTimePicker1, FrmAppt.ComboBox1, FrmAppt.ComboBox2, FrmAppt.TextBox2, FrmAppt.TextBox3}
        Dim sReader As New StreamReader(FrmMain.pathAppointments & selectedAppointment & "\appointmentData.txt")
        For Each ctrl As Control In dataControls
            ctrl.Text = sReader.ReadLine
        Next
        sReader.Close()
        Close()
        If FrmAppt.Visible = False Then FrmAppt.Show(FrmMain)
        FrmAppt.isNewAppointment = False
    End Sub

    'remove button
    Private Sub btnRemove_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnRemove.Click
        DeleteAppointment()
    End Sub

    'close form button
    Private Sub btnClose_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnClose.Click
        Close()
    End Sub

End Class