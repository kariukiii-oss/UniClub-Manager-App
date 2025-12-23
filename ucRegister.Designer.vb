<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucRegister
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        picRegisterIcon = New PictureBox()
        txtFullName = New TextBox()
        txtEmail = New TextBox()
        lblRegisterMember = New Label()
        btnSubmitRegistration = New Button()
        btnCancelRegistration = New Button()
        FlowLayoutPanel1 = New FlowLayoutPanel()
        lblFullName = New Label()
        lblEmail = New Label()
        lblCourse = New Label()
        txtCourse = New TextBox()
        lblDepartment = New Label()
        txtDepartment = New TextBox()
        CType(picRegisterIcon, ComponentModel.ISupportInitialize).BeginInit()
        FlowLayoutPanel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' picRegisterIcon
        ' 
        picRegisterIcon.Image = My.Resources.Resources.user
        picRegisterIcon.Location = New Point(129, 19)
        picRegisterIcon.Name = "picRegisterIcon"
        picRegisterIcon.Size = New Size(58, 35)
        picRegisterIcon.SizeMode = PictureBoxSizeMode.Zoom
        picRegisterIcon.TabIndex = 0
        picRegisterIcon.TabStop = False
        ' 
        ' txtFullName
        ' 
        txtFullName.Location = New Point(3, 31)
        txtFullName.Name = "txtFullName"
        txtFullName.Size = New Size(319, 27)
        txtFullName.TabIndex = 17
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(3, 92)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(319, 27)
        txtEmail.TabIndex = 16
        ' 
        ' lblRegisterMember
        ' 
        lblRegisterMember.AutoSize = True
        lblRegisterMember.Font = New Font("Imprint MT Shadow", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblRegisterMember.ForeColor = SystemColors.Highlight
        lblRegisterMember.Location = New Point(193, 19)
        lblRegisterMember.Name = "lblRegisterMember"
        lblRegisterMember.Size = New Size(250, 35)
        lblRegisterMember.TabIndex = 18
        lblRegisterMember.Text = "Register Member"
        lblRegisterMember.TextAlign = ContentAlignment.TopCenter
        ' 
        ' btnSubmitRegistration
        ' 
        btnSubmitRegistration.BackColor = Color.SkyBlue
        btnSubmitRegistration.FlatStyle = FlatStyle.Popup
        btnSubmitRegistration.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSubmitRegistration.Location = New Point(151, 343)
        btnSubmitRegistration.Name = "btnSubmitRegistration"
        btnSubmitRegistration.Size = New Size(132, 44)
        btnSubmitRegistration.TabIndex = 19
        btnSubmitRegistration.Text = "Submit"
        btnSubmitRegistration.UseVisualStyleBackColor = False
        ' 
        ' btnCancelRegistration
        ' 
        btnCancelRegistration.BackColor = SystemColors.ButtonFace
        btnCancelRegistration.FlatStyle = FlatStyle.Popup
        btnCancelRegistration.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnCancelRegistration.Location = New Point(306, 343)
        btnCancelRegistration.Name = "btnCancelRegistration"
        btnCancelRegistration.Size = New Size(137, 44)
        btnCancelRegistration.TabIndex = 20
        btnCancelRegistration.Text = "Cancel"
        btnCancelRegistration.UseVisualStyleBackColor = False
        ' 
        ' FlowLayoutPanel1
        ' 
        FlowLayoutPanel1.BackColor = SystemColors.MenuHighlight
        FlowLayoutPanel1.Controls.Add(lblFullName)
        FlowLayoutPanel1.Controls.Add(txtFullName)
        FlowLayoutPanel1.Controls.Add(lblEmail)
        FlowLayoutPanel1.Controls.Add(txtEmail)
        FlowLayoutPanel1.Controls.Add(lblCourse)
        FlowLayoutPanel1.Controls.Add(txtCourse)
        FlowLayoutPanel1.Controls.Add(lblDepartment)
        FlowLayoutPanel1.Controls.Add(txtDepartment)
        FlowLayoutPanel1.Location = New Point(129, 70)
        FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        FlowLayoutPanel1.Size = New Size(332, 254)
        FlowLayoutPanel1.TabIndex = 21
        ' 
        ' lblFullName
        ' 
        lblFullName.AutoSize = True
        lblFullName.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblFullName.ForeColor = SystemColors.Control
        lblFullName.Location = New Point(3, 0)
        lblFullName.Name = "lblFullName"
        lblFullName.Size = New Size(68, 28)
        lblFullName.TabIndex = 9
        lblFullName.Text = "Name"
        ' 
        ' lblEmail
        ' 
        lblEmail.AutoSize = True
        lblEmail.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblEmail.ForeColor = SystemColors.Control
        lblEmail.Location = New Point(3, 61)
        lblEmail.Name = "lblEmail"
        lblEmail.Size = New Size(64, 28)
        lblEmail.TabIndex = 18
        lblEmail.Text = "Email"
        ' 
        ' lblCourse
        ' 
        lblCourse.AutoSize = True
        lblCourse.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblCourse.ForeColor = SystemColors.Control
        lblCourse.Location = New Point(3, 122)
        lblCourse.Name = "lblCourse"
        lblCourse.Size = New Size(76, 28)
        lblCourse.TabIndex = 19
        lblCourse.Text = "Course"
        ' 
        ' txtCourse
        ' 
        txtCourse.Location = New Point(3, 153)
        txtCourse.Name = "txtCourse"
        txtCourse.Size = New Size(319, 27)
        txtCourse.TabIndex = 22
        ' 
        ' lblDepartment
        ' 
        lblDepartment.AutoSize = True
        lblDepartment.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblDepartment.ForeColor = SystemColors.Control
        lblDepartment.Location = New Point(3, 183)
        lblDepartment.Name = "lblDepartment"
        lblDepartment.Size = New Size(127, 28)
        lblDepartment.TabIndex = 23
        lblDepartment.Text = "Department"
        ' 
        ' txtDepartment
        ' 
        txtDepartment.Location = New Point(3, 214)
        txtDepartment.Name = "txtDepartment"
        txtDepartment.Size = New Size(319, 27)
        txtDepartment.TabIndex = 24
        ' 
        ' ucRegister
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Control
        Controls.Add(FlowLayoutPanel1)
        Controls.Add(btnCancelRegistration)
        Controls.Add(btnSubmitRegistration)
        Controls.Add(lblRegisterMember)
        Controls.Add(picRegisterIcon)
        Name = "ucRegister"
        Size = New Size(617, 418)
        CType(picRegisterIcon, ComponentModel.ISupportInitialize).EndInit()
        FlowLayoutPanel1.ResumeLayout(False)
        FlowLayoutPanel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents picRegisterIcon As PictureBox
    Friend WithEvents txtFullName As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents lblRegisterMember As Label
    Friend WithEvents btnSubmitRegistration As Button
    Friend WithEvents btnCancelRegistration As Button
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents lblFullName As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblCourse As Label
    Friend WithEvents txtCourse As TextBox
    Friend WithEvents lblDepartment As Label
    Friend WithEvents txtDepartment As TextBox

End Class
