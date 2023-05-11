'Patient search form

Public Class FrmSelectPatient
    Dim fPanel As FlowLayoutPanel

    'controls
    Private Sub SearchPatient()
        For Each ctrl As Button In fPanel.Controls
            If ctrl.Text.ToLower.Contains(ToolStripTextBox1.Text.ToLower) Then
                ctrl.Visible = True
            Else
                ctrl.Visible = False
            End If
        Next
    End Sub

    'clear/cancel searching
    Private Sub CancelSearch()
        ToolStripTextBox1.Clear()
        ToolStripSeparator1.Visible = False
        ToolStripButton2.Visible = False
        For Each ctrl As Button In fPanel.Controls
            ctrl.Visible = True
        Next
    End Sub

    'on load
    Private Sub FrmSelectPatient_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Location = New Point(FrmMain.Left + 25, FrmMain.Top + 45)
    End Sub

    'form show
    Private Sub FrmSelectPatient_Shown(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Shown
        Dim newPanel As New FlowLayoutPanel With {
            .BackColor = SystemColors.GradientInactiveCaption,
            .AutoScroll = True,
            .Dock = DockStyle.Fill
        }
        For Each dirFound As String In My.Computer.FileSystem.GetDirectories(FrmMain.pathPatients)
            Dim newPatient As New Patient With {.Text = dirFound.Replace(FrmMain.pathPatients, "")}
            newPanel.Controls.Add(newPatient)
        Next
        Controls.Add(newPanel)
        newPanel.BringToFront()
        fPanel = newPanel
        ToolStripTextBox1.Focus()
    End Sub

    'esc press to close
    Private Sub FrmSelectPatient_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Close()
        End If
    End Sub

    'text mod
    Private Sub ToolStripTextBox1_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ToolStripTextBox1.TextChanged
        If ToolStripTextBox1.TextLength = 0 Then
            CancelSearch()
        Else
            ToolStripSeparator1.Visible = True
            ToolStripButton2.Visible = True
        End If
    End Sub

    'enter press to search
    Private Sub ToolStripTextBox1_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles ToolStripTextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            SearchPatient()
        End If
    End Sub

    'cancel
    Private Sub ToolStripButton2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ToolStripButton2.Click
        CancelSearch()
    End Sub
End Class