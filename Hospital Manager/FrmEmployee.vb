'Employee (pharm, lab, admit, nurse) add form

Imports System.IO

Public Class FrmEmployee
    'vars
    Public selectedPerson As String = Nothing
    Public selectedButton As String = Nothing
    Dim selectedID As Integer = 0
    Dim strID As String = Nothing


    Private Sub AddCategory()
        'Check if all filled
        Dim allFilled As Boolean = True
        For Each ctrl In GroupBox1.Controls
            If TypeOf ctrl Is TextBox Then
                If String.IsNullOrWhiteSpace(ctrl.Text) Then
                    allFilled = False
                End If
            End If
        Next
        'continue adding after fill check
        If allFilled Then
            If Not String.IsNullOrWhiteSpace(selectedPerson) Then
                Dim oldDirectory As String = FrmMain.pathStorage & selectedButton & "\" & selectedPerson
                My.Computer.FileSystem.DeleteDirectory(oldDirectory, FileIO.DeleteDirectoryOption.DeleteAllContents)
            End If
            Dim dirPath As String = FrmMain.pathStorage & selectedButton & "\" & TextBox1.Text & " - " & TextBox2.Text & "\"
            My.Computer.FileSystem.CreateDirectory(dirPath)
            Dim sWriter As New StreamWriter(dirPath & selectedButton.ToLower & "Info.txt")
            For Each ctrl In GroupBox1.Controls
                If TypeOf ctrl Is TextBox Then
                    sWriter.WriteLine(ctrl.Text)
                End If
            Next
            sWriter.Close()
            IncrementID()
            FrmMain.UpdateFPanel2()
            Close()
        Else
            'prompt
            MessageBox.Show("Please make sure data has been entered.", "Hospital Manager", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    'del cat
    Private Sub RemoveCategory()
        Dim msgReply = MessageBox.Show("Remove this " & selectedButton.ToLower & "?", "Hospital Manager", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If msgReply = Windows.Forms.DialogResult.Yes Then
            Dim readPath As String = FrmMain.pathStorage & selectedButton & "\" & selectedPerson
            My.Computer.FileSystem.DeleteDirectory(readPath, FileIO.DeleteDirectoryOption.DeleteAllContents)
            Close()
            FrmMain.UpdateFPanel2()
        End If
    End Sub

    'retrive ID
    Private Sub GetID()
        FrmMain.LoadGeneric()
        If selectedButton = "Pharmacist" Then
            selectedID = FrmMain.PHID
            strID = "PHID"
            Icon = My.Resources.Pharmacist2
        ElseIf selectedButton = "Nursing" Then
            selectedID = FrmMain.NID
            Icon = My.Resources.Nurse2
            strID = "NID"
        ElseIf selectedButton = "Laboratory" Then
            selectedID = FrmMain.LID
            Icon = My.Resources.Laboratorist2
            strID = "LID"
        ElseIf selectedButton = "Admitting" Then
            selectedID = FrmMain.AID
            Icon = My.Resources.Laboratorist2

            strID = "AID"
        End If
        If String.IsNullOrWhiteSpace(selectedPerson) Then
            TextBox1.Text = selectedID
        End If
    End Sub

    'each ID is incremented when adding new 
    Private Sub IncrementID()
        Dim sWriter As New StreamWriter(FrmMain.pathGeneric & strID & ".txt")
        If selectedButton = "Pharmacist" Then
            sWriter.WriteLine(FrmMain.PHID + 1)
        ElseIf selectedButton = "Nursing" Then
            sWriter.WriteLine(FrmMain.NID + 1)
        ElseIf selectedButton = "Laboratory" Then
            sWriter.WriteLine(FrmMain.LID + 1)
        ElseIf selectedButton = "Admitting" Then
            sWriter.WriteLine(FrmMain.AID + 1)
        End If
        sWriter.Close()
    End Sub

    'on load
    Private Sub FrmEmployee_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Location = New Point(FrmMain.Left + 25, FrmMain.Top + 45)
    End Sub

    'when show main form
    Private Sub FrmEmployee_Shown(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Shown
        If String.IsNullOrWhiteSpace(selectedPerson) Then
            Text = "Add " & selectedButton
        Else
            Text = "Edit " & selectedButton
            btnAdd.Text = "Save"
            btnClear.Text = "Remove"
            '\s?
            Dim readPath As String = FrmMain.pathStorage & selectedButton & "\" & selectedPerson & "\" & selectedButton.ToLower & "Info.txt"
            Dim sReader As New IO.StreamReader(readPath)
            For Each ctrl In GroupBox1.Controls
                If TypeOf ctrl Is TextBox Then
                    ctrl.Text = sReader.ReadLine()
                End If
            Next
            sReader.Close()
        End If
        GroupBox1.Text = selectedButton & " information:"
        GetID()
    End Sub

    'esc/enter/del keypress
    Private Sub FrmEmployee_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Close()
        ElseIf e.KeyCode = Keys.Enter Then
            AddCategory()
        ElseIf e.KeyCode = Keys.Delete Then
            RemoveCategory()
        End If
    End Sub

    'text mod
    Private Sub TextBox1_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles TextBox1.TextChanged
        If String.IsNullOrWhiteSpace(selectedPerson) Then
            TextBox1.Text = selectedID
        End If
    End Sub

    'button add
    Private Sub btnAdd_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnAdd.Click
        AddCategory()
    End Sub

    'clear text
    Private Sub btnClear_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnClear.Click
        If btnClear.Text = "Clear" Then
            For Each ctrl In GroupBox1.Controls
                If TypeOf ctrl Is TextBox Then
                    ctrl.Clear()
                End If
            Next
        Else
            RemoveCategory()
        End If
    End Sub

    'close form
    Private Sub btnClose_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnClose.Click
        Close()
    End Sub
End Class