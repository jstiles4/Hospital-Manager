﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPatientInfo
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPatientInfo))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblBirthDate = New System.Windows.Forms.Label()
        Me.lblGender = New System.Windows.Forms.Label()
        Me.lblID = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblEmailAddress = New System.Windows.Forms.Label()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.lblContactNumber = New System.Windows.Forms.Label()
        Me.lblPostalCode = New System.Windows.Forms.Label()
        Me.lblCity = New System.Windows.Forms.Label()
        Me.lblCountry = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblBirthDate)
        Me.GroupBox2.Controls.Add(Me.lblGender)
        Me.GroupBox2.Controls.Add(Me.lblID)
        Me.GroupBox2.Controls.Add(Me.lblName)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Location = New System.Drawing.Point(16, 15)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox2.Size = New System.Drawing.Size(405, 180)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "General information:"
        '
        'lblBirthDate
        '
        Me.lblBirthDate.AutoSize = True
        Me.lblBirthDate.Location = New System.Drawing.Point(139, 117)
        Me.lblBirthDate.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblBirthDate.Name = "lblBirthDate"
        Me.lblBirthDate.Size = New System.Drawing.Size(62, 16)
        Me.lblBirthDate.TabIndex = 17
        Me.lblBirthDate.Text = "birth date"
        '
        'lblGender
        '
        Me.lblGender.AutoSize = True
        Me.lblGender.Location = New System.Drawing.Point(139, 91)
        Me.lblGender.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblGender.Name = "lblGender"
        Me.lblGender.Size = New System.Drawing.Size(50, 16)
        Me.lblGender.TabIndex = 16
        Me.lblGender.Text = "gender"
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Location = New System.Drawing.Point(139, 65)
        Me.lblID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(18, 16)
        Me.lblID.TabIndex = 15
        Me.lblID.Text = "id"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(139, 39)
        Me.lblName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(41, 16)
        Me.lblName.TabIndex = 14
        Me.lblName.Text = "name"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(55, 65)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(67, 16)
        Me.Label13.TabIndex = 2
        Me.Label13.Text = "Patient ID:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(57, 117)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 16)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Birth date:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(35, 39)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Patient name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(71, 91)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 16)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Gender:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblEmailAddress)
        Me.GroupBox1.Controls.Add(Me.lblAddress)
        Me.GroupBox1.Controls.Add(Me.lblContactNumber)
        Me.GroupBox1.Controls.Add(Me.lblPostalCode)
        Me.GroupBox1.Controls.Add(Me.lblCity)
        Me.GroupBox1.Controls.Add(Me.lblCountry)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 202)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(565, 204)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Contact details:"
        '
        'lblEmailAddress
        '
        Me.lblEmailAddress.AutoSize = True
        Me.lblEmailAddress.Location = New System.Drawing.Point(139, 159)
        Me.lblEmailAddress.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEmailAddress.Name = "lblEmailAddress"
        Me.lblEmailAddress.Size = New System.Drawing.Size(93, 16)
        Me.lblEmailAddress.TabIndex = 23
        Me.lblEmailAddress.Text = "email address"
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Location = New System.Drawing.Point(139, 133)
        Me.lblAddress.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(57, 16)
        Me.lblAddress.TabIndex = 22
        Me.lblAddress.Text = "address"
        '
        'lblContactNumber
        '
        Me.lblContactNumber.AutoSize = True
        Me.lblContactNumber.Location = New System.Drawing.Point(139, 107)
        Me.lblContactNumber.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblContactNumber.Name = "lblContactNumber"
        Me.lblContactNumber.Size = New System.Drawing.Size(98, 16)
        Me.lblContactNumber.TabIndex = 21
        Me.lblContactNumber.Text = "contact number"
        '
        'lblPostalCode
        '
        Me.lblPostalCode.AutoSize = True
        Me.lblPostalCode.Location = New System.Drawing.Point(139, 81)
        Me.lblPostalCode.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPostalCode.Name = "lblPostalCode"
        Me.lblPostalCode.Size = New System.Drawing.Size(78, 16)
        Me.lblPostalCode.TabIndex = 20
        Me.lblPostalCode.Text = "postal code"
        '
        'lblCity
        '
        Me.lblCity.AutoSize = True
        Me.lblCity.Location = New System.Drawing.Point(139, 55)
        Me.lblCity.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCity.Name = "lblCity"
        Me.lblCity.Size = New System.Drawing.Size(27, 16)
        Me.lblCity.TabIndex = 19
        Me.lblCity.Text = "city"
        '
        'lblCountry
        '
        Me.lblCountry.AutoSize = True
        Me.lblCountry.Location = New System.Drawing.Point(139, 30)
        Me.lblCountry.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCountry.Name = "lblCountry"
        Me.lblCountry.Size = New System.Drawing.Size(50, 16)
        Me.lblCountry.TabIndex = 18
        Me.lblCountry.Text = "country"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(31, 159)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(97, 16)
        Me.Label12.TabIndex = 12
        Me.Label12.Text = "Email address:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(17, 107)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(103, 16)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "Contact number:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(67, 133)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(61, 16)
        Me.Label10.TabIndex = 8
        Me.Label10.Text = "Address:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(43, 81)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(82, 16)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "Postal code:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(95, 55)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(32, 16)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "City:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(69, 30)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 16)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Country:"
        '
        'btnClose
        '
        Me.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Image = Global.Hospital_Manager.My.Resources.Resources.iconClose
        Me.btnClose.Location = New System.Drawing.Point(461, 414)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(120, 34)
        Me.btnClose.TabIndex = 7
        Me.btnClose.Text = "Close"
        Me.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnRemove
        '
        Me.btnRemove.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRemove.Image = Global.Hospital_Manager.My.Resources.Resources.iconRemove
        Me.btnRemove.Location = New System.Drawing.Point(144, 414)
        Me.btnRemove.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(120, 34)
        Me.btnRemove.TabIndex = 6
        Me.btnRemove.Text = "Remove"
        Me.btnRemove.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEdit.Image = Global.Hospital_Manager.My.Resources.Resources.iconEdit
        Me.btnEdit.Location = New System.Drawing.Point(16, 414)
        Me.btnEdit.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(120, 34)
        Me.btnEdit.TabIndex = 5
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Default
        Me.PictureBox1.Image = Global.Hospital_Manager.My.Resources.Resources.iconPatient72
        Me.PictureBox1.Location = New System.Drawing.Point(429, 22)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(152, 172)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 13
        Me.PictureBox1.TabStop = False
        '
        'FrmPatientInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(597, 463)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.Name = "FrmPatientInfo"
        Me.Text = "Patient Information"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lblBirthDate As System.Windows.Forms.Label
    Friend WithEvents lblGender As System.Windows.Forms.Label
    Friend WithEvents lblID As System.Windows.Forms.Label
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents lblEmailAddress As System.Windows.Forms.Label
    Friend WithEvents lblAddress As System.Windows.Forms.Label
    Friend WithEvents lblContactNumber As System.Windows.Forms.Label
    Friend WithEvents lblPostalCode As System.Windows.Forms.Label
    Friend WithEvents lblCity As System.Windows.Forms.Label
    Friend WithEvents lblCountry As System.Windows.Forms.Label
    Friend WithEvents btnRemove As System.Windows.Forms.Button
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
End Class
