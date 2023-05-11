<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMain))
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnAddPharm = New System.Windows.Forms.Button()
        Me.btnAddNurse = New System.Windows.Forms.Button()
        Me.btnAddLab = New System.Windows.Forms.Button()
        Me.btnAddAdmit = New System.Windows.Forms.Button()
        Me.btnAddAppt = New System.Windows.Forms.Button()
        Me.btnAbout = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel3 = New System.Windows.Forms.FlowLayoutPanel()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripTextBox2 = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton5 = New System.Windows.Forms.ToolStripButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.FlowLayoutPanel4 = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnShowPatients = New System.Windows.Forms.Button()
        Me.btnShowDoctors = New System.Windows.Forms.Button()
        Me.btnShowPharm = New System.Windows.Forms.Button()
        Me.btnShowNurses = New System.Windows.Forms.Button()
        Me.btnShowLab = New System.Windows.Forms.Button()
        Me.btnShowAdmit = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnAddPatient = New System.Windows.Forms.Button()
        Me.btnAddDoctor = New System.Windows.Forms.Button()
        Me.FlowLayoutPanel1.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.ToolStrip2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.FlowLayoutPanel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.FlowLayoutPanel1.Controls.Add(Me.btnAddPatient)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnAddDoctor)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnAddPharm)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnAddNurse)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnAddLab)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnAddAdmit)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnAddAppt)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnAbout)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnExit)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel1.Margin = New System.Windows.Forms.Padding(4)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(1309, 142)
        Me.FlowLayoutPanel1.TabIndex = 0
        '
        'btnAddPharm
        '
        Me.btnAddPharm.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnAddPharm.FlatAppearance.BorderSize = 0
        Me.btnAddPharm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddPharm.Image = Global.Hospital_Manager.My.Resources.Resources.iconPharmacist
        Me.btnAddPharm.Location = New System.Drawing.Point(293, 12)
        Me.btnAddPharm.Margin = New System.Windows.Forms.Padding(0, 12, 13, 12)
        Me.btnAddPharm.Name = "btnAddPharm"
        Me.btnAddPharm.Size = New System.Drawing.Size(127, 117)
        Me.btnAddPharm.TabIndex = 2
        Me.btnAddPharm.Tag = "Pharmacist"
        Me.btnAddPharm.Text = "Add Pharmacy"
        Me.btnAddPharm.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnAddPharm.UseVisualStyleBackColor = False
        '
        'btnAddNurse
        '
        Me.btnAddNurse.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnAddNurse.FlatAppearance.BorderSize = 0
        Me.btnAddNurse.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddNurse.Image = Global.Hospital_Manager.My.Resources.Resources.iconNurse
        Me.btnAddNurse.Location = New System.Drawing.Point(433, 12)
        Me.btnAddNurse.Margin = New System.Windows.Forms.Padding(0, 12, 13, 12)
        Me.btnAddNurse.Name = "btnAddNurse"
        Me.btnAddNurse.Size = New System.Drawing.Size(127, 117)
        Me.btnAddNurse.TabIndex = 3
        Me.btnAddNurse.Tag = "Nursing"
        Me.btnAddNurse.Text = "Add Nursing"
        Me.btnAddNurse.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnAddNurse.UseVisualStyleBackColor = False
        '
        'btnAddLab
        '
        Me.btnAddLab.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnAddLab.FlatAppearance.BorderSize = 0
        Me.btnAddLab.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddLab.Image = Global.Hospital_Manager.My.Resources.Resources.Laboratorist
        Me.btnAddLab.Location = New System.Drawing.Point(573, 12)
        Me.btnAddLab.Margin = New System.Windows.Forms.Padding(0, 12, 13, 12)
        Me.btnAddLab.Name = "btnAddLab"
        Me.btnAddLab.Size = New System.Drawing.Size(127, 117)
        Me.btnAddLab.TabIndex = 4
        Me.btnAddLab.Tag = "Laboratory"
        Me.btnAddLab.Text = "Add Laboratory"
        Me.btnAddLab.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnAddLab.UseVisualStyleBackColor = False
        '
        'btnAddAdmit
        '
        Me.btnAddAdmit.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnAddAdmit.FlatAppearance.BorderSize = 0
        Me.btnAddAdmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddAdmit.Image = Global.Hospital_Manager.My.Resources.Resources.Patient
        Me.btnAddAdmit.Location = New System.Drawing.Point(713, 12)
        Me.btnAddAdmit.Margin = New System.Windows.Forms.Padding(0, 12, 13, 12)
        Me.btnAddAdmit.Name = "btnAddAdmit"
        Me.btnAddAdmit.Size = New System.Drawing.Size(127, 117)
        Me.btnAddAdmit.TabIndex = 5
        Me.btnAddAdmit.Tag = "Admitting"
        Me.btnAddAdmit.Text = "Add Admitting"
        Me.btnAddAdmit.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnAddAdmit.UseVisualStyleBackColor = False
        '
        'btnAddAppt
        '
        Me.btnAddAppt.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnAddAppt.FlatAppearance.BorderSize = 0
        Me.btnAddAppt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddAppt.Image = Global.Hospital_Manager.My.Resources.Resources.iconAppointment48
        Me.btnAddAppt.Location = New System.Drawing.Point(853, 12)
        Me.btnAddAppt.Margin = New System.Windows.Forms.Padding(0, 12, 13, 12)
        Me.btnAddAppt.Name = "btnAddAppt"
        Me.btnAddAppt.Size = New System.Drawing.Size(127, 117)
        Me.btnAddAppt.TabIndex = 6
        Me.btnAddAppt.Text = "Add Appointment"
        Me.btnAddAppt.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnAddAppt.UseVisualStyleBackColor = False
        '
        'btnAbout
        '
        Me.btnAbout.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnAbout.FlatAppearance.BorderSize = 0
        Me.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAbout.Image = Global.Hospital_Manager.My.Resources.Resources.question
        Me.btnAbout.Location = New System.Drawing.Point(993, 12)
        Me.btnAbout.Margin = New System.Windows.Forms.Padding(0, 12, 13, 12)
        Me.btnAbout.Name = "btnAbout"
        Me.btnAbout.Size = New System.Drawing.Size(127, 117)
        Me.btnAbout.TabIndex = 7
        Me.btnAbout.Text = "About"
        Me.btnAbout.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnAbout.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnExit.FlatAppearance.BorderSize = 0
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Image = Global.Hospital_Manager.My.Resources.Resources.exitdoor
        Me.btnExit.Location = New System.Drawing.Point(1133, 12)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(0, 12, 13, 12)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(127, 117)
        Me.btnExit.TabIndex = 8
        Me.btnExit.Text = "Exit"
        Me.btnExit.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer1.Location = New System.Drawing.Point(320, 149)
        Me.SplitContainer1.Margin = New System.Windows.Forms.Padding(4)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.Panel1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.Panel2)
        Me.SplitContainer1.Size = New System.Drawing.Size(973, 615)
        Me.SplitContainer1.SplitterDistance = 316
        Me.SplitContainer1.SplitterWidth = 5
        Me.SplitContainer1.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.Panel1.Controls.Add(Me.FlowLayoutPanel2)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.ToolStrip1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(316, 615)
        Me.Panel1.TabIndex = 0
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.AutoScroll = True
        Me.FlowLayoutPanel2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.FlowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(0, 31)
        Me.FlowLayoutPanel2.Margin = New System.Windows.Forms.Padding(4)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(316, 547)
        Me.FlowLayoutPanel2.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Label3.Location = New System.Drawing.Point(0, 578)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(316, 6)
        Me.Label3.TabIndex = 3
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ToolStrip1
        '
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.ToolStripTextBox1, Me.ToolStripButton1, Me.ToolStripSeparator2, Me.ToolStripButton2})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(316, 31)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(113, 28)
        Me.ToolStripLabel1.Text = "Search patients:"
        '
        'ToolStripTextBox1
        '
        Me.ToolStripTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ToolStripTextBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ToolStripTextBox1.Name = "ToolStripTextBox1"
        Me.ToolStripTextBox1.Size = New System.Drawing.Size(173, 31)
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(29, 4)
        Me.ToolStripButton1.Text = "Search"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 27)
        Me.ToolStripSeparator2.Visible = False
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(29, 4)
        Me.ToolStripButton2.Text = "Cancel search"
        Me.ToolStripButton2.Visible = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 584)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(316, 31)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Patients (0)"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.FlowLayoutPanel3)
        Me.Panel2.Controls.Add(Me.ToolStrip2)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(652, 615)
        Me.Panel2.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.Control
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Label4.Location = New System.Drawing.Point(0, 578)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(652, 6)
        Me.Label4.TabIndex = 4
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FlowLayoutPanel3
        '
        Me.FlowLayoutPanel3.AutoScroll = True
        Me.FlowLayoutPanel3.BackColor = System.Drawing.SystemColors.ControlLight
        Me.FlowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel3.Location = New System.Drawing.Point(0, 31)
        Me.FlowLayoutPanel3.Margin = New System.Windows.Forms.Padding(4)
        Me.FlowLayoutPanel3.Name = "FlowLayoutPanel3"
        Me.FlowLayoutPanel3.Size = New System.Drawing.Size(652, 553)
        Me.FlowLayoutPanel3.TabIndex = 1
        '
        'ToolStrip2
        '
        Me.ToolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip2.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel2, Me.ToolStripTextBox2, Me.ToolStripButton4, Me.ToolStripSeparator1, Me.ToolStripButton5})
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(652, 31)
        Me.ToolStrip2.TabIndex = 0
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(152, 28)
        Me.ToolStripLabel2.Text = "Search appointments:"
        '
        'ToolStripTextBox2
        '
        Me.ToolStripTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ToolStripTextBox2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ToolStripTextBox2.Name = "ToolStripTextBox2"
        Me.ToolStripTextBox2.Size = New System.Drawing.Size(173, 31)
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.Size = New System.Drawing.Size(29, 28)
        Me.ToolStripButton4.Text = "Search"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        Me.ToolStripSeparator1.Visible = False
        '
        'ToolStripButton5
        '
        Me.ToolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton5.Name = "ToolStripButton5"
        Me.ToolStripButton5.Size = New System.Drawing.Size(29, 22)
        Me.ToolStripButton5.Text = "Cancel search"
        Me.ToolStripButton5.Visible = False
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Label2.Location = New System.Drawing.Point(0, 584)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(652, 31)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Appointments (0)"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel3.Controls.Add(Me.FlowLayoutPanel4)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Location = New System.Drawing.Point(16, 149)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(300, 615)
        Me.Panel3.TabIndex = 2
        '
        'FlowLayoutPanel4
        '
        Me.FlowLayoutPanel4.BackColor = System.Drawing.SystemColors.ControlLight
        Me.FlowLayoutPanel4.Controls.Add(Me.btnShowPatients)
        Me.FlowLayoutPanel4.Controls.Add(Me.btnShowDoctors)
        Me.FlowLayoutPanel4.Controls.Add(Me.btnShowPharm)
        Me.FlowLayoutPanel4.Controls.Add(Me.btnShowNurses)
        Me.FlowLayoutPanel4.Controls.Add(Me.btnShowLab)
        Me.FlowLayoutPanel4.Controls.Add(Me.btnShowAdmit)
        Me.FlowLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel4.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel4.Margin = New System.Windows.Forms.Padding(4)
        Me.FlowLayoutPanel4.Name = "FlowLayoutPanel4"
        Me.FlowLayoutPanel4.Size = New System.Drawing.Size(300, 578)
        Me.FlowLayoutPanel4.TabIndex = 0
        '
        'btnShowPatients
        '
        Me.btnShowPatients.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnShowPatients.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnShowPatients.FlatAppearance.BorderSize = 0
        Me.btnShowPatients.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnShowPatients.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnShowPatients.Image = Global.Hospital_Manager.My.Resources.Resources.Patient2
        Me.btnShowPatients.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnShowPatients.Location = New System.Drawing.Point(4, 4)
        Me.btnShowPatients.Margin = New System.Windows.Forms.Padding(4, 4, 4, 1)
        Me.btnShowPatients.Name = "btnShowPatients"
        Me.btnShowPatients.Size = New System.Drawing.Size(292, 49)
        Me.btnShowPatients.TabIndex = 0
        Me.btnShowPatients.Text = "Patients"
        Me.btnShowPatients.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnShowPatients.UseVisualStyleBackColor = False
        '
        'btnShowDoctors
        '
        Me.btnShowDoctors.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnShowDoctors.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnShowDoctors.FlatAppearance.BorderSize = 0
        Me.btnShowDoctors.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnShowDoctors.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnShowDoctors.Image = Global.Hospital_Manager.My.Resources.Resources.Doctor1
        Me.btnShowDoctors.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnShowDoctors.Location = New System.Drawing.Point(4, 55)
        Me.btnShowDoctors.Margin = New System.Windows.Forms.Padding(4, 1, 4, 1)
        Me.btnShowDoctors.Name = "btnShowDoctors"
        Me.btnShowDoctors.Size = New System.Drawing.Size(292, 49)
        Me.btnShowDoctors.TabIndex = 1
        Me.btnShowDoctors.Text = "Doctors"
        Me.btnShowDoctors.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnShowDoctors.UseVisualStyleBackColor = False
        '
        'btnShowPharm
        '
        Me.btnShowPharm.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnShowPharm.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnShowPharm.FlatAppearance.BorderSize = 0
        Me.btnShowPharm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnShowPharm.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnShowPharm.Image = Global.Hospital_Manager.My.Resources.Resources.Pharmacist1
        Me.btnShowPharm.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnShowPharm.Location = New System.Drawing.Point(4, 106)
        Me.btnShowPharm.Margin = New System.Windows.Forms.Padding(4, 1, 4, 1)
        Me.btnShowPharm.Name = "btnShowPharm"
        Me.btnShowPharm.Size = New System.Drawing.Size(292, 49)
        Me.btnShowPharm.TabIndex = 2
        Me.btnShowPharm.Text = "Pharmacist"
        Me.btnShowPharm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnShowPharm.UseVisualStyleBackColor = False
        '
        'btnShowNurses
        '
        Me.btnShowNurses.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnShowNurses.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnShowNurses.FlatAppearance.BorderSize = 0
        Me.btnShowNurses.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnShowNurses.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnShowNurses.Image = Global.Hospital_Manager.My.Resources.Resources.Nurse1
        Me.btnShowNurses.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnShowNurses.Location = New System.Drawing.Point(4, 157)
        Me.btnShowNurses.Margin = New System.Windows.Forms.Padding(4, 1, 4, 1)
        Me.btnShowNurses.Name = "btnShowNurses"
        Me.btnShowNurses.Size = New System.Drawing.Size(292, 49)
        Me.btnShowNurses.TabIndex = 3
        Me.btnShowNurses.Text = "Nursing"
        Me.btnShowNurses.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnShowNurses.UseVisualStyleBackColor = False
        '
        'btnShowLab
        '
        Me.btnShowLab.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnShowLab.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnShowLab.FlatAppearance.BorderSize = 0
        Me.btnShowLab.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnShowLab.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnShowLab.Image = Global.Hospital_Manager.My.Resources.Resources.Laboratorist1
        Me.btnShowLab.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnShowLab.Location = New System.Drawing.Point(4, 208)
        Me.btnShowLab.Margin = New System.Windows.Forms.Padding(4, 1, 4, 1)
        Me.btnShowLab.Name = "btnShowLab"
        Me.btnShowLab.Size = New System.Drawing.Size(292, 49)
        Me.btnShowLab.TabIndex = 4
        Me.btnShowLab.Text = "Laboratory"
        Me.btnShowLab.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnShowLab.UseVisualStyleBackColor = False
        '
        'btnShowAdmit
        '
        Me.btnShowAdmit.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnShowAdmit.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnShowAdmit.FlatAppearance.BorderSize = 0
        Me.btnShowAdmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnShowAdmit.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnShowAdmit.Image = Global.Hospital_Manager.My.Resources.Resources.Patient2
        Me.btnShowAdmit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnShowAdmit.Location = New System.Drawing.Point(4, 259)
        Me.btnShowAdmit.Margin = New System.Windows.Forms.Padding(4, 1, 4, 1)
        Me.btnShowAdmit.Name = "btnShowAdmit"
        Me.btnShowAdmit.Size = New System.Drawing.Size(292, 49)
        Me.btnShowAdmit.TabIndex = 5
        Me.btnShowAdmit.Text = "Admitting"
        Me.btnShowAdmit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnShowAdmit.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.SystemColors.Control
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Label6.Location = New System.Drawing.Point(0, 578)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(300, 6)
        Me.Label6.TabIndex = 8
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Label5.Location = New System.Drawing.Point(0, 584)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(300, 31)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Current selection: Patients"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnAddPatient
        '
        Me.btnAddPatient.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnAddPatient.FlatAppearance.BorderSize = 0
        Me.btnAddPatient.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddPatient.Image = Global.Hospital_Manager.My.Resources.Resources.Patient
        Me.btnAddPatient.Location = New System.Drawing.Point(13, 12)
        Me.btnAddPatient.Margin = New System.Windows.Forms.Padding(13, 12, 13, 12)
        Me.btnAddPatient.Name = "btnAddPatient"
        Me.btnAddPatient.Size = New System.Drawing.Size(127, 117)
        Me.btnAddPatient.TabIndex = 0
        Me.btnAddPatient.Text = "Add Patient"
        Me.btnAddPatient.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnAddPatient.UseVisualStyleBackColor = False
        '
        'btnAddDoctor
        '
        Me.btnAddDoctor.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnAddDoctor.FlatAppearance.BorderSize = 0
        Me.btnAddDoctor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddDoctor.Image = Global.Hospital_Manager.My.Resources.Resources.iconDoctor
        Me.btnAddDoctor.Location = New System.Drawing.Point(153, 12)
        Me.btnAddDoctor.Margin = New System.Windows.Forms.Padding(0, 12, 13, 12)
        Me.btnAddDoctor.Name = "btnAddDoctor"
        Me.btnAddDoctor.Size = New System.Drawing.Size(127, 117)
        Me.btnAddDoctor.TabIndex = 1
        Me.btnAddDoctor.Text = "Add Doctor"
        Me.btnAddDoctor.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnAddDoctor.UseVisualStyleBackColor = False
        '
        'FrmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(1309, 779)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MinimumSize = New System.Drawing.Size(1327, 826)
        Me.Name = "FrmMain"
        Me.Text = "Hospital Manager"
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.FlowLayoutPanel4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents btnAddPatient As System.Windows.Forms.Button
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents FlowLayoutPanel2 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents FlowLayoutPanel3 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripLabel2 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripTextBox2 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripButton4 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton5 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripTextBox1 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnAddAppt As System.Windows.Forms.Button
    Friend WithEvents btnAbout As System.Windows.Forms.Button
    Friend WithEvents btnAddDoctor As System.Windows.Forms.Button
    Friend WithEvents btnAddPharm As System.Windows.Forms.Button
    Friend WithEvents btnAddNurse As System.Windows.Forms.Button
    Friend WithEvents btnAddLab As System.Windows.Forms.Button
    Friend WithEvents btnAddAdmit As System.Windows.Forms.Button
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents FlowLayoutPanel4 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents btnShowAdmit As System.Windows.Forms.Button
    Friend WithEvents btnShowLab As System.Windows.Forms.Button
    Friend WithEvents btnShowNurses As System.Windows.Forms.Button
    Friend WithEvents btnShowPharm As System.Windows.Forms.Button
    Friend WithEvents btnShowDoctors As System.Windows.Forms.Button
    Friend WithEvents btnShowPatients As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnExit As Button
End Class
