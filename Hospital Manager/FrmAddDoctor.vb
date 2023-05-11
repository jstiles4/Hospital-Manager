'Form for adding doctor info

Public Class FrmAddDoctor
    'doc select var
    Public selectedDoctor As String = Nothing

    Private Sub AddDoctor()
        'Check for empty textboxes
        Dim allFilled As Boolean = True
        For Each ctrl In GroupBox1.Controls
            If TypeOf ctrl Is TextBox Then
                If String.IsNullOrWhiteSpace(ctrl.Text) Then
                    allFilled = False
                    Exit For
                End If
            End If
        Next

        'Write doctor to file
        If allFilled Then
            Dim dirPath As String = Nothing
            If String.IsNullOrWhiteSpace(selectedDoctor) Then
                dirPath = FrmMain.pathDoctors & TextBox1.Text & " - " & TextBox2.Text
            Else
                My.Computer.FileSystem.DeleteDirectory(FrmMain.pathDoctors & selectedDoctor, FileIO.DeleteDirectoryOption.DeleteAllContents)
                selectedDoctor = TextBox1.Text & " - " & TextBox2.Text
                dirPath = FrmMain.pathDoctors & selectedDoctor
            End If
            My.Computer.FileSystem.CreateDirectory(dirPath)
            Dim sWriter As New IO.StreamWriter(dirPath & "\doctorInfo.txt")
            For Each ctrl In GroupBox1.Controls
                If TypeOf ctrl Is TextBox Then
                    sWriter.WriteLine(ctrl.Text)
                End If
            Next
            sWriter.Close()

            'Update view doctors
            FrmMain.UpdateFPanel2()

            'Increment DID (doctor ID)
            If String.IsNullOrWhiteSpace(selectedDoctor) Then
                sWriter = New IO.StreamWriter(FrmMain.pathGeneric & "DID.txt")
                sWriter.Write(FrmMain.DID + 1)
                sWriter.Close()
            End If
            Close()
        Else
            MessageBox.Show("Please make sure all data have been entered.", "Hospital Manager", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    'delete doc from list
    Private Sub RemoveDoctor()
        Dim msgReply = MessageBox.Show("Remove this doctor?", "Hospital Manager", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If msgReply = Windows.Forms.DialogResult.Yes Then
            My.Computer.FileSystem.DeleteDirectory(FrmMain.pathDoctors & selectedDoctor, FileIO.DeleteDirectoryOption.DeleteAllContents)
            If FrmMain.selectedCategory = "Doctors" Then
                FrmMain.LoadDoctors()
            End If
            Close()
        End If
    End Sub

    'loading
    Private Sub FrmAddDoctor_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Location = New Point(FrmMain.Left + 25, FrmMain.Top + 45)
    End Sub

    'load form show
    Private Sub FrmAddDoctor_Shown(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Shown
        FrmMain.LoadGeneric()
        TextBox1.Text = FrmMain.DID
        TextBox2.Focus()

        'selected file location
        If Not String.IsNullOrWhiteSpace(selectedDoctor) Then
            Dim sReader As New IO.StreamReader(FrmMain.pathDoctors & selectedDoctor & "\doctorInfo.txt")
            For Each ctrl In GroupBox1.Controls
                If TypeOf ctrl Is TextBox Then
                    ctrl.Text = sReader.ReadLine()
                End If
            Next
            sReader.Close()
            Text = "Edit Doctor"
            btnAdd.Text = "Save"
            btnClear.Text = "Remove"
        End If
    End Sub

    'keypress esc, enter, del
    Private Sub FrmAddDoctor_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Close()
        ElseIf e.KeyCode = Keys.Enter Then
            AddDoctor()
        ElseIf e.KeyCode = Keys.Delete Then
            RemoveDoctor()
        End If
    End Sub

    'text mod
    Private Sub TextBox1_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles TextBox1.TextChanged
        If String.IsNullOrWhiteSpace(selectedDoctor) Then
            TextBox1.Text = FrmMain.DID
        End If
    End Sub

    'add button
    Private Sub btnAdd_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnAdd.Click
        AddDoctor()
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
            RemoveDoctor()
        End If
    End Sub

    'close form
    Private Sub btnClose_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnClose.Click
        Close()
    End Sub
End Class