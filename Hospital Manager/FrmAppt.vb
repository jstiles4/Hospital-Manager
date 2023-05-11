'appointmnt form

Public Class FrmAppt
    Public isNewAppointment As Boolean = True


    Private Sub SetAppointment()
        'check info
        If String.IsNullOrWhiteSpace(TextBox1.Text) Or lblPatientName.Text = "unknown" Or String.IsNullOrWhiteSpace(ComboBox1.Text) Or String.IsNullOrWhiteSpace(ComboBox2.Text) Or
            String.IsNullOrWhiteSpace(TextBox2.Text) Or String.IsNullOrWhiteSpace(TextBox3.Text) Then
            MessageBox.Show("Please make sure all data has been entered.", "Hospital Manager", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            'Write appointment to file
            Dim pathAppointment As String = FrmMain.pathAppointments & lblPatientName.Text & " - " & TextBox1.Text
            My.Computer.FileSystem.CreateDirectory(pathAppointment)
            Dim sWriter As New IO.StreamWriter(pathAppointment & "\appointmentData.txt")
            Dim dataControls() As Control = {TextBox1, lblPatientName, DateTimePicker1, ComboBox1, ComboBox2, TextBox2, TextBox3}
            For Each ctrl As Control In dataControls
                sWriter.WriteLine(ctrl.Text)
            Next
            sWriter.Close()
            FrmMain.FlowLayoutPanel3.Controls.Clear()
            FrmMain.LoadAppointments()

            If isNewAppointment = False Then
                FrmApptInfo.selectedAppointment = lblPatientName.Text & " - " & TextBox1.Text
                FrmApptInfo.Show(FrmMain)
            End If
            Close()
        End If
    End Sub

    'add appt.
    Public Sub AddAppointment(ByVal appointmentName As String)
        Dim newAppointment As New Appointment With {.Text = appointmentName}
        FrmMain.FlowLayoutPanel3.Controls.Add(newAppointment)
    End Sub

    'load appt. form
    Private Sub FrmAppt_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Location = New Point(FrmMain.Left + 25, FrmMain.Top + 45)
        For x = 0 To 59
            Dim xValue As String = x
            If xValue.Length = 1 Then xValue = "0" & xValue
            If x < 24 Then
                ComboBox1.Items.Add(xValue)
            End If
            ComboBox2.Items.Add(xValue)
        Next
    End Sub

    'keypress enter/esc
    Private Sub FrmAppt_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Close()
        ElseIf e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            SetAppointment()
        End If
    End Sub

    'add button
    Private Sub btnAdd_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnAdd.Click
        SetAppointment()
    End Sub

    'close form
    Private Sub btnClose_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnClose.Click
        Close()
    End Sub

    'browse/lookup button
    Private Sub btnBrowse_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnBrowse.Click
        If My.Computer.FileSystem.GetDirectories(FrmMain.pathPatients).Count > 0 Then
            FrmSelectPatient.Show(FrmMain)
        Else
            MessageBox.Show("No patients found.", "Hospital Manager", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

End Class