'John Stiles. Final Project. 5/7/23
'Hospital Manager
'Spring 2023 ADVANCED VISUAL BASIC PROGRAMMING (IT-46308-201)

Imports System.IO

Public Class FrmMain

    'Public storage path variables, incrementing "ID's" for adding staff
#Region "Variables"
    Public pathStorage As String = "C:\HospitalManager\Data\"
    Public pathPatients As String = pathStorage & "Patients\"
    Public pathDoctors As String = pathStorage & "Doctors\"
    Public pathPharmacist As String = pathStorage & "Pharmacist\"
    Public pathNursing As String = pathStorage & "Nursing\"
    Public pathLaboratory As String = pathStorage & "Laboratory\"
    Public pathAdmitting As String = pathStorage & "Admitting\"
    Public pathAppointments As String = pathStorage & "Appointments\"
    Public pathGeneric As String = pathStorage & "Generic\"
    Public allPaths() As String = {pathAppointments, pathGeneric, pathPatients, pathDoctors, pathPharmacist, pathNursing, pathLaboratory, pathAdmitting}
    Public PID As Integer = Nothing : Public DID As Integer = Nothing : Public PHID As Integer = Nothing : Public NID As Integer = Nothing : Public LID As Integer = Nothing : Public AID As Integer = Nothing
    Public allIDs() As String = {"PID.txt", "DID.txt", "PHID.txt", "NID.txt", "LID.txt", "AID.txt"}
    Public selectedCategory As String = "Patients"
#End Region

    'All things loading into form if avaliable, ID's, appointments, employees
#Region "Load"
    'loading existing appts if any
    Public Sub LoadAppointments()
        For Each fileFound As String In My.Computer.FileSystem.GetDirectories(pathAppointments)
            FrmAppt.AddAppointment(fileFound.Replace(pathAppointments, ""))
        Next
        Label2.Text = "Appointments (" & FlowLayoutPanel3.Controls.Count & ")"
    End Sub

    'loading ID's
    Public Sub LoadGeneric()
        Dim sReader As New StreamReader(pathGeneric & "PID.txt")
        PID = Integer.Parse(sReader.ReadToEnd)
        sReader.Close()
        sReader = New StreamReader(pathGeneric & "DID.txt")
        DID = Integer.Parse(sReader.ReadToEnd)
        sReader.Close()
        sReader = New StreamReader(pathGeneric & "PHID.txt")
        PHID = Integer.Parse(sReader.ReadToEnd)
        sReader.Close()
        sReader = New StreamReader(pathGeneric & "NID.txt")
        NID = Integer.Parse(sReader.ReadToEnd)
        sReader.Close()
        sReader = New StreamReader(pathGeneric & "LID.txt")
        LID = Integer.Parse(sReader.ReadToEnd)
        sReader.Close()
        sReader = New StreamReader(pathGeneric & "AID.txt")
        AID = Integer.Parse(sReader.ReadToEnd)
        sReader.Close()
    End Sub

    'load current patients into form
    Public Sub LoadPatients()
        FlowLayoutPanel2.Controls.Clear()
        For Each fileFound As String In My.Computer.FileSystem.GetDirectories(pathPatients)
            Dim newPatient As New Patient With {.Text = fileFound.Replace(pathPatients, "")}
            FlowLayoutPanel2.Controls.Add(newPatient)
        Next
        Label1.Text = "Patients (" & FlowLayoutPanel2.Controls.Count & ")"
    End Sub

    'load doctors into form
    Public Sub LoadDoctors()
        FlowLayoutPanel2.Controls.Clear()
        For Each fileFound As String In My.Computer.FileSystem.GetDirectories(pathDoctors)
            Dim newDoctor As New Patient With {.Text = fileFound.Replace(pathDoctors, "")}
            FlowLayoutPanel2.Controls.Add(newDoctor)
        Next
        Label1.Text = "Doctors (" & FlowLayoutPanel2.Controls.Count & ")"
    End Sub

    'load pharm staff into form
    Public Sub LoadPharmacist()
        FlowLayoutPanel2.Controls.Clear()
        For Each fileFound As String In My.Computer.FileSystem.GetDirectories(pathPharmacist)
            Dim newPharmacist As New Patient With {.Text = fileFound.Replace(pathPharmacist, "")}
            FlowLayoutPanel2.Controls.Add(newPharmacist)
        Next
        Label1.Text = "Pharmacist (" & FlowLayoutPanel2.Controls.Count & ")"
    End Sub

    'load nursing staff into form
    Public Sub LoadNurses()
        FlowLayoutPanel2.Controls.Clear()
        For Each fileFound As String In My.Computer.FileSystem.GetDirectories(pathNursing)
            Dim newNurse As New Patient With {.Text = fileFound.Replace(pathNursing, "")}
            FlowLayoutPanel2.Controls.Add(newNurse)
        Next
        Label1.Text = "Nursing (" & FlowLayoutPanel2.Controls.Count & ")"
    End Sub

    'load lab staff into form
    Public Sub LoadLaboratorists()
        FlowLayoutPanel2.Controls.Clear()
        For Each fileFound As String In My.Computer.FileSystem.GetDirectories(pathLaboratory)
            Dim newLaboratory As New Patient With {.Text = fileFound.Replace(pathLaboratory, "")}
            FlowLayoutPanel2.Controls.Add(newLaboratory)
        Next
        Label1.Text = "Laboratory (" & FlowLayoutPanel2.Controls.Count & ")"
    End Sub

    'load admitting staff into form
    Public Sub LoadAdmitting()
        FlowLayoutPanel2.Controls.Clear()
        For Each fileFound As String In My.Computer.FileSystem.GetDirectories(pathAdmitting)
            Dim newAdmitting As New Patient With {.Text = fileFound.Replace(pathAdmitting, "")}
            FlowLayoutPanel2.Controls.Add(newAdmitting)
        Next
        Label1.Text = "Admitting (" & FlowLayoutPanel2.Controls.Count & ")"
    End Sub

    'refresh form with info
    Public Sub UpdateFPanel2()
        If selectedCategory = "Patients" Then
            LoadPatients()
        ElseIf selectedCategory = "Doctors" Then
            LoadDoctors()
        ElseIf selectedCategory = "Pharmacist" Then
            LoadPharmacist()
        ElseIf selectedCategory = "Nursing" Then
            LoadNurses()
        ElseIf selectedCategory = "Laboratory" Then
            LoadLaboratorists()
        ElseIf selectedCategory = "Admitting" Then
            LoadAdmitting()
        End If
    End Sub

    'lookup patient
    Private Sub SearchPatient()
        For Each btn As Button In FlowLayoutPanel2.Controls
            btn.Visible = False
        Next
        For Each btn As Button In FlowLayoutPanel2.Controls
            If btn.Text.ToLower.Contains(ToolStripTextBox1.Text.ToLower) Then
                btn.Visible = True
            End If
        Next
    End Sub

    'look up appt
    Private Sub SearchAppointment()
        For Each btn As Button In FlowLayoutPanel3.Controls
            btn.Visible = False
        Next
        For Each btn As Button In FlowLayoutPanel3.Controls
            If btn.Text.ToLower.Contains(ToolStripTextBox2.Text.ToLower) Then
                btn.Visible = True
            End If
        Next
    End Sub
#End Region

    'Main form load
    Private Sub FrmMain_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        'load info from "load" region
        If My.Computer.FileSystem.DirectoryExists(pathStorage) Then
            LoadAppointments()
            LoadGeneric()
            LoadPatients()
        Else
            'Creating paths
            For Each path As String In allPaths
                My.Computer.FileSystem.CreateDirectory(path)
            Next
            For Each id As String In allIDs
                Dim sWriter As New StreamWriter(pathGeneric & id)
                sWriter.Write("1")
                sWriter.Close()
            Next
        End If
    End Sub

    'close out if esc press
    Private Sub FrmMain_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Close()
        End If
    End Sub

    'search if enter is pressed
    Private Sub ToolStripTextBox1_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles ToolStripTextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            SearchPatient()
        End If
    End Sub

    'text change mod
    Private Sub ToolStripTextBox1_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ToolStripTextBox1.TextChanged
        If ToolStripTextBox1.TextLength = 0 Then
            For Each btn As Button In FlowLayoutPanel2.Controls
                btn.Visible = True
            Next
            ToolStripButton2.Visible = False
            ToolStripSeparator2.Visible = False
        Else
            ToolStripButton2.Visible = True
            ToolStripSeparator2.Visible = True
        End If
    End Sub

    'text change mod
    Private Sub ToolStripTextBox2_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ToolStripTextBox2.TextChanged
        If ToolStripTextBox2.TextLength = 0 Then
            For Each btn As Button In FlowLayoutPanel3.Controls
                btn.Visible = True
            Next
            ToolStripButton5.Visible = False
            ToolStripSeparator1.Visible = False
        Else
            ToolStripButton5.Visible = True
            ToolStripSeparator1.Visible = True
        End If
    End Sub

    'keypress enter
    Private Sub ToolStripTextBox2_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles ToolStripTextBox2.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            SearchAppointment()
        End If
    End Sub

    'SHow form to add new patient
    Private Sub btnAddPatient_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnAddPatient.Click
        FrmPatient.Show(Me)
    End Sub

    'show form to add/edit appointments
    Private Sub btnAddAppt_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnAddAppt.Click
        FrmAppt.Show(Me)
    End Sub

    'about info message box popup
    Private Sub btnAbout_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnAbout.Click
        MessageBox.Show("Final Project: Hospital Manager" & vbNewLine & vbNewLine & "Version: 1.0" & vbNewLine & vbNewLine & "Spring 2023 ADVANCED VISUAL BASIC PROGRAMMING (IT-46308-201)" & vbNewLine & vbNewLine & "John Stiles" & vbNewLine & vbNewLine & "Description: Hospital Manager for use with coordinating a hospital's staff, patients, and appointments.")
    End Sub

    'add doc form show
    Private Sub btnAddDoctor_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnAddDoctor.Click
        FrmAddDoctor.Show(Me)
    End Sub

    'add employee form load based on tag (pharm, lab, admit, nurse)
    Private Sub addButtons_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnAddPharm.Click, btnAddAdmit.Click, btnAddLab.Click, btnAddNurse.Click
        FrmEmployee.Show(Me)
        Dim cButton As Button = TryCast(sender, Object)
        FrmEmployee.selectedButton = cButton.Tag
    End Sub

    'show search
    Private Sub ToolStripButton1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ToolStripButton1.Click
        SearchPatient()
    End Sub

    'clear text
    Private Sub ToolStripButton2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ToolStripButton2.Click
        ToolStripTextBox1.Clear()
        ToolStripSeparator2.Visible = False
        ToolStripButton2.Visible = False
    End Sub

    'appt lookup
    Private Sub ToolStripButton4_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ToolStripButton4.Click
        SearchAppointment()
    End Sub

    'clear text
    Private Sub ToolStripButton5_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ToolStripButton5.Click
        ToolStripTextBox2.Clear()
        ToolStripSeparator1.Visible = False
        ToolStripButton5.Visible = False
    End Sub

    'Left Panel buttons
    Private Sub LeftPanelButtons_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnShowAdmit.Click, btnShowPatients.Click, btnShowLab.Click, btnShowNurses.Click, btnShowPharm.Click, btnShowDoctors.Click
        'Initiliaze selection
        Dim cButton As Button = TryCast(sender, Object)
        FlowLayoutPanel2.Controls.Clear()

        'Load selection data
        If cButton.Text = "Patients" Then
            LoadPatients()
        ElseIf cButton.Text = "Doctors" Then
            LoadDoctors()
        ElseIf cButton.Text = "Pharmacist" Then
            LoadPharmacist()
        ElseIf cButton.Text = "Nursing" Then
            LoadNurses()
        ElseIf cButton.Text = "Laboratory" Then
            LoadLaboratorists()
        ElseIf cButton.Text = "Admitting" Then
            LoadAdmitting()
        End If

        'Init labels
        ToolStripLabel1.Text = "Search " & cButton.Text.ToLower & ":"
        Label1.Text = cButton.Text & " (" & FlowLayoutPanel2.Controls.Count & ")"
        Label5.Text = "Current selection: " & cButton.Text
        selectedCategory = cButton.Text
    End Sub

    'close application
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub
End Class


Public Class Patient
    Inherits Button

    Public Sub New()
        AutoSize = False
        Dock = DockStyle.Top
        FlatStyle = FlatStyle.Flat
        FlatAppearance.BorderSize = 0
        Margin = New Padding(7, 7, 7, 0)
        Size = New Size(280, 50)
        Font = New Font("Segoe UI", 9)
    End Sub

    Private Sub WhenClicked() Handles Me.Click
        If Me.Parent.GetContainerControl Is FrmSelectPatient Then
            FrmAppt.lblPatientName.Text = Text
            FrmSelectPatient.Close()
        ElseIf Me.Parent.GetContainerControl Is FrmMain.SplitContainer1 Then
            'Show proper form
            If FrmMain.selectedCategory = "Patients" Then
                FrmPatientInfo.Show(FrmMain)
                FrmPatientInfo.selectedPatient = Me.Text
            ElseIf FrmMain.selectedCategory = "Doctors" Then
                FrmAddDoctor.Show(FrmMain)
                FrmAddDoctor.selectedDoctor = Me.Text
            Else
                FrmEmployee.selectedButton = FrmMain.selectedCategory.Substring(0, FrmMain.selectedCategory.Length - 1)
                FrmEmployee.Show(FrmMain)
                FrmEmployee.selectedPerson = Me.Text
            End If
        End If
    End Sub
End Class

Public Class Appointment
    Inherits Button

    Public Sub New()
        AutoSize = False
        Dock = DockStyle.Top
        FlatStyle = FlatStyle.Flat
        FlatAppearance.BorderSize = 0
        Margin = New Padding(10, 10, 10, 10)
        Size = New Size(160, 160)
        TextAlign = ContentAlignment.BottomCenter
        Font = New Font("Segoe UI", 9)
        'Image = My.Resources.iconAppointment64
    End Sub

    Private Sub WhenClicked() Handles Me.Click
        'Load data
        Dim sReader As New StreamReader(FrmMain.pathAppointments & Text & "\appointmentData.txt")
        Dim lbData As New ListBox
        While sReader.Peek <> -1
            lbData.Items.Add(sReader.ReadLine)
        End While
        sReader.Close()

        'Visualize data
        FrmApptInfo.lblPatientName.Text = lbData.Items(1)
        FrmApptInfo.lblCaseType.Text = lbData.Items(0)
        FrmApptInfo.lblDate.Text = lbData.Items(2)
        FrmApptInfo.lblTime.Text = lbData.Items(3) & ":" & lbData.Items(4)
        FrmApptInfo.lblAppointmentFor.Text = lbData.Items(5)
        FrmApptInfo.lblLocation.Text = lbData.Items(6)

        FrmApptInfo.Show(FrmMain)
        FrmApptInfo.selectedAppointment = Text
    End Sub
End Class