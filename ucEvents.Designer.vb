<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucEvents
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
        FlowLayoutPanel1 = New FlowLayoutPanel()
        lblFullName = New Label()
        txtEventName = New TextBox()
        lblEmail = New Label()
        txtVenue = New TextBox()
        lblSpeaker = New Label()
        txtLocation = New TextBox()
        Label1 = New Label()
        DateTimePicker1 = New DateTimePicker()
        btnAddEvent = New Button()
        btnClear = New Button()
        lblRegisterMember = New Label()
        FlowLayoutPanel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' FlowLayoutPanel1
        ' 
        FlowLayoutPanel1.BackColor = SystemColors.MenuHighlight
        FlowLayoutPanel1.Controls.Add(lblFullName)
        FlowLayoutPanel1.Controls.Add(txtEventName)
        FlowLayoutPanel1.Controls.Add(lblEmail)
        FlowLayoutPanel1.Controls.Add(txtVenue)
        FlowLayoutPanel1.Controls.Add(lblSpeaker)
        FlowLayoutPanel1.Controls.Add(txtLocation)
        FlowLayoutPanel1.Controls.Add(Label1)
        FlowLayoutPanel1.Controls.Add(DateTimePicker1)
        FlowLayoutPanel1.Location = New Point(103, 51)
        FlowLayoutPanel1.Margin = New Padding(4)
        FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        FlowLayoutPanel1.Size = New Size(435, 341)
        FlowLayoutPanel1.TabIndex = 22
        ' 
        ' lblFullName
        ' 
        lblFullName.AutoSize = True
        lblFullName.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblFullName.ForeColor = SystemColors.Control
        lblFullName.Location = New Point(4, 0)
        lblFullName.Margin = New Padding(4, 0, 4, 0)
        lblFullName.Name = "lblFullName"
        lblFullName.Size = New Size(151, 32)
        lblFullName.TabIndex = 9
        lblFullName.Text = "Event Name"
        ' 
        ' txtEventName
        ' 
        txtEventName.Location = New Point(4, 36)
        txtEventName.Margin = New Padding(4)
        txtEventName.Name = "txtEventName"
        txtEventName.Size = New Size(398, 31)
        txtEventName.TabIndex = 17
        ' 
        ' lblEmail
        ' 
        lblEmail.AutoSize = True
        lblEmail.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblEmail.ForeColor = SystemColors.Control
        lblEmail.Location = New Point(4, 71)
        lblEmail.Margin = New Padding(4, 0, 4, 0)
        lblEmail.Name = "lblEmail"
        lblEmail.Size = New Size(84, 32)
        lblEmail.TabIndex = 18
        lblEmail.Text = "Venue"
        ' 
        ' txtVenue
        ' 
        txtVenue.Location = New Point(4, 107)
        txtVenue.Margin = New Padding(4)
        txtVenue.Name = "txtVenue"
        txtVenue.Size = New Size(398, 31)
        txtVenue.TabIndex = 16
        ' 
        ' lblSpeaker
        ' 
        lblSpeaker.AutoSize = True
        lblSpeaker.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblSpeaker.ForeColor = SystemColors.Control
        lblSpeaker.Location = New Point(4, 142)
        lblSpeaker.Margin = New Padding(4, 0, 4, 0)
        lblSpeaker.Name = "lblSpeaker"
        lblSpeaker.Size = New Size(112, 32)
        lblSpeaker.TabIndex = 19
        lblSpeaker.Text = "Location"
        ' 
        ' txtLocation
        ' 
        txtLocation.Location = New Point(4, 178)
        txtLocation.Margin = New Padding(4)
        txtLocation.Name = "txtLocation"
        txtLocation.Size = New Size(398, 31)
        txtLocation.TabIndex = 20
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.Control
        Label1.Location = New Point(4, 213)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(67, 32)
        Label1.TabIndex = 21
        Label1.Text = "Date"
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Location = New Point(3, 248)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(399, 31)
        DateTimePicker1.TabIndex = 20
        ' 
        ' btnAddEvent
        ' 
        btnAddEvent.Location = New Point(171, 399)
        btnAddEvent.Name = "btnAddEvent"
        btnAddEvent.Size = New Size(112, 34)
        btnAddEvent.TabIndex = 21
        btnAddEvent.Text = "ADD"
        btnAddEvent.UseVisualStyleBackColor = True
        ' 
        ' btnClear
        ' 
        btnClear.Location = New Point(315, 399)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(112, 34)
        btnClear.TabIndex = 22
        btnClear.Text = "CLEAR"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' lblRegisterMember
        ' 
        lblRegisterMember.AutoSize = True
        lblRegisterMember.Font = New Font("Imprint MT Shadow", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblRegisterMember.ForeColor = SystemColors.Highlight
        lblRegisterMember.Location = New Point(236, 5)
        lblRegisterMember.Margin = New Padding(4, 0, 4, 0)
        lblRegisterMember.Name = "lblRegisterMember"
        lblRegisterMember.Size = New Size(155, 42)
        lblRegisterMember.TabIndex = 23
        lblRegisterMember.Text = "EVENT"
        lblRegisterMember.TextAlign = ContentAlignment.TopCenter
        ' 
        ' ucEvents
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(lblRegisterMember)
        Controls.Add(FlowLayoutPanel1)
        Controls.Add(btnClear)
        Controls.Add(btnAddEvent)
        Name = "ucEvents"
        Size = New Size(771, 461)
        FlowLayoutPanel1.ResumeLayout(False)
        FlowLayoutPanel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents lblFullName As Label
    Friend WithEvents txtEventName As TextBox
    Friend WithEvents lblEmail As Label
    Friend WithEvents txtVenue As TextBox
    Friend WithEvents lblSpeaker As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents btnAddEvent As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents txtLocation As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblRegisterMember As Label

End Class
