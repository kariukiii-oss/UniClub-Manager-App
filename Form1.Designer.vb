<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        pnlLeftSide = New Panel()
        lblAppName = New Label()
        pnlOnButtonEvents = New Panel()
        btnEvents = New Button()
        pnlOnButtonAttendance = New Panel()
        btnAttendance = New Button()
        pnlOnButtonRegister = New Panel()
        btnRegister = New Button()
        pnlTopSide = New Panel()
        Panel1 = New Panel()
        picMinimize = New PictureBox()
        picMaximize = New PictureBox()
        picClose = New PictureBox()
        pnlDashboard = New Panel()
        DateTimePicker1 = New DateTimePicker()
        lblWelcome = New Label()
        lblMemberCount = New Label()
        FlowLayoutPanel1 = New FlowLayoutPanel()
        PictureBox1 = New PictureBox()
        lblEvent = New Label()
        PictureBox2 = New PictureBox()
        FlowLayoutPanel2 = New FlowLayoutPanel()
        lblEventCount = New Label()
        dgvRecentMembers = New DataGridView()
        lblRecentEntries = New Label()
        pnlMain = New Panel()
        Label3 = New Label()
        pnlLeftSide.SuspendLayout()
        pnlTopSide.SuspendLayout()
        Panel1.SuspendLayout()
        CType(picMinimize, ComponentModel.ISupportInitialize).BeginInit()
        CType(picMaximize, ComponentModel.ISupportInitialize).BeginInit()
        CType(picClose, ComponentModel.ISupportInitialize).BeginInit()
        FlowLayoutPanel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        FlowLayoutPanel2.SuspendLayout()
        CType(dgvRecentMembers, ComponentModel.ISupportInitialize).BeginInit()
        pnlMain.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnlLeftSide
        ' 
        pnlLeftSide.BackColor = SystemColors.Highlight
        pnlLeftSide.Controls.Add(lblAppName)
        pnlLeftSide.Controls.Add(pnlOnButtonEvents)
        pnlLeftSide.Controls.Add(btnEvents)
        pnlLeftSide.Controls.Add(pnlOnButtonAttendance)
        pnlLeftSide.Controls.Add(btnAttendance)
        pnlLeftSide.Controls.Add(pnlOnButtonRegister)
        pnlLeftSide.Controls.Add(btnRegister)
        pnlLeftSide.Dock = DockStyle.Left
        pnlLeftSide.Location = New Point(0, 0)
        pnlLeftSide.Margin = New Padding(4, 4, 4, 4)
        pnlLeftSide.Name = "pnlLeftSide"
        pnlLeftSide.Size = New Size(312, 566)
        pnlLeftSide.TabIndex = 0
        ' 
        ' lblAppName
        ' 
        lblAppName.AutoSize = True
        lblAppName.Font = New Font("Imprint MT Shadow", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblAppName.ForeColor = SystemColors.HighlightText
        lblAppName.Location = New Point(15, 54)
        lblAppName.Margin = New Padding(4, 0, 4, 0)
        lblAppName.Name = "lblAppName"
        lblAppName.Size = New Size(263, 94)
        lblAppName.TabIndex = 8
        lblAppName.Text = "UniClub" & vbCrLf & "Manager App" & vbCrLf
        lblAppName.TextAlign = ContentAlignment.TopCenter
        ' 
        ' pnlOnButtonEvents
        ' 
        pnlOnButtonEvents.BackColor = Color.SkyBlue
        pnlOnButtonEvents.Location = New Point(0, 352)
        pnlOnButtonEvents.Margin = New Padding(4, 4, 4, 4)
        pnlOnButtonEvents.Name = "pnlOnButtonEvents"
        pnlOnButtonEvents.Size = New Size(26, 59)
        pnlOnButtonEvents.TabIndex = 6
        ' 
        ' btnEvents
        ' 
        btnEvents.FlatAppearance.BorderSize = 0
        btnEvents.FlatStyle = FlatStyle.Flat
        btnEvents.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnEvents.ForeColor = SystemColors.Window
        btnEvents.Image = CType(resources.GetObject("btnEvents.Image"), Image)
        btnEvents.ImageAlign = ContentAlignment.MiddleLeft
        btnEvents.Location = New Point(30, 352)
        btnEvents.Margin = New Padding(4, 4, 4, 4)
        btnEvents.Name = "btnEvents"
        btnEvents.Size = New Size(279, 59)
        btnEvents.TabIndex = 5
        btnEvents.Text = " Events"
        btnEvents.TextAlign = ContentAlignment.MiddleRight
        btnEvents.TextImageRelation = TextImageRelation.ImageBeforeText
        btnEvents.UseVisualStyleBackColor = True
        ' 
        ' pnlOnButtonAttendance
        ' 
        pnlOnButtonAttendance.BackColor = Color.SkyBlue
        pnlOnButtonAttendance.Location = New Point(0, 269)
        pnlOnButtonAttendance.Margin = New Padding(4, 4, 4, 4)
        pnlOnButtonAttendance.Name = "pnlOnButtonAttendance"
        pnlOnButtonAttendance.Size = New Size(26, 59)
        pnlOnButtonAttendance.TabIndex = 4
        ' 
        ' btnAttendance
        ' 
        btnAttendance.FlatAppearance.BorderSize = 0
        btnAttendance.FlatStyle = FlatStyle.Flat
        btnAttendance.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnAttendance.ForeColor = SystemColors.Window
        btnAttendance.Image = My.Resources.Resources.verify
        btnAttendance.ImageAlign = ContentAlignment.MiddleLeft
        btnAttendance.Location = New Point(34, 269)
        btnAttendance.Margin = New Padding(4, 4, 4, 4)
        btnAttendance.Name = "btnAttendance"
        btnAttendance.Size = New Size(279, 59)
        btnAttendance.TabIndex = 3
        btnAttendance.Text = " Attendance"
        btnAttendance.TextAlign = ContentAlignment.MiddleRight
        btnAttendance.TextImageRelation = TextImageRelation.ImageBeforeText
        btnAttendance.UseVisualStyleBackColor = True
        ' 
        ' pnlOnButtonRegister
        ' 
        pnlOnButtonRegister.BackColor = Color.SkyBlue
        pnlOnButtonRegister.Location = New Point(0, 185)
        pnlOnButtonRegister.Margin = New Padding(4, 4, 4, 4)
        pnlOnButtonRegister.Name = "pnlOnButtonRegister"
        pnlOnButtonRegister.Size = New Size(26, 59)
        pnlOnButtonRegister.TabIndex = 2
        ' 
        ' btnRegister
        ' 
        btnRegister.FlatAppearance.BorderSize = 0
        btnRegister.FlatStyle = FlatStyle.Flat
        btnRegister.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnRegister.ForeColor = SystemColors.Window
        btnRegister.Image = My.Resources.Resources.add_user
        btnRegister.ImageAlign = ContentAlignment.MiddleLeft
        btnRegister.Location = New Point(34, 185)
        btnRegister.Margin = New Padding(4, 4, 4, 4)
        btnRegister.Name = "btnRegister"
        btnRegister.Size = New Size(275, 59)
        btnRegister.TabIndex = 2
        btnRegister.Text = " Register"
        btnRegister.TextImageRelation = TextImageRelation.ImageBeforeText
        btnRegister.UseVisualStyleBackColor = True
        ' 
        ' pnlTopSide
        ' 
        pnlTopSide.BackColor = Color.LightSkyBlue
        pnlTopSide.Controls.Add(Panel1)
        pnlTopSide.Controls.Add(pnlDashboard)
        pnlTopSide.Dock = DockStyle.Top
        pnlTopSide.Location = New Point(312, 0)
        pnlTopSide.Margin = New Padding(4, 4, 4, 4)
        pnlTopSide.Name = "pnlTopSide"
        pnlTopSide.Size = New Size(772, 55)
        pnlTopSide.TabIndex = 1
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(picMinimize)
        Panel1.Controls.Add(picMaximize)
        Panel1.Controls.Add(picClose)
        Panel1.Location = New Point(645, 11)
        Panel1.Margin = New Padding(4, 4, 4, 4)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(122, 35)
        Panel1.TabIndex = 9
        ' 
        ' picMinimize
        ' 
        picMinimize.BackgroundImageLayout = ImageLayout.Zoom
        picMinimize.Image = CType(resources.GetObject("picMinimize.Image"), Image)
        picMinimize.Location = New Point(4, 0)
        picMinimize.Margin = New Padding(4, 4, 4, 4)
        picMinimize.Name = "picMinimize"
        picMinimize.Size = New Size(30, 30)
        picMinimize.TabIndex = 12
        picMinimize.TabStop = False
        ' 
        ' picMaximize
        ' 
        picMaximize.BackgroundImageLayout = ImageLayout.Zoom
        picMaximize.Image = CType(resources.GetObject("picMaximize.Image"), Image)
        picMaximize.Location = New Point(42, 0)
        picMaximize.Margin = New Padding(4, 4, 4, 4)
        picMaximize.Name = "picMaximize"
        picMaximize.Size = New Size(32, 35)
        picMaximize.TabIndex = 13
        picMaximize.TabStop = False
        ' 
        ' picClose
        ' 
        picClose.BackgroundImageLayout = ImageLayout.Zoom
        picClose.Image = My.Resources.Resources.cross
        picClose.Location = New Point(82, 0)
        picClose.Margin = New Padding(4, 4, 4, 4)
        picClose.Name = "picClose"
        picClose.Size = New Size(32, 35)
        picClose.TabIndex = 11
        picClose.TabStop = False
        ' 
        ' pnlDashboard
        ' 
        pnlDashboard.Location = New Point(0, 54)
        pnlDashboard.Margin = New Padding(4, 4, 4, 4)
        pnlDashboard.Name = "pnlDashboard"
        pnlDashboard.Size = New Size(768, 512)
        pnlDashboard.TabIndex = 2
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Location = New Point(470, 0)
        DateTimePicker1.Margin = New Padding(4, 4, 4, 4)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(296, 31)
        DateTimePicker1.TabIndex = 3
        ' 
        ' lblWelcome
        ' 
        lblWelcome.AutoSize = True
        lblWelcome.Font = New Font("Imprint MT Shadow", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblWelcome.ForeColor = SystemColors.Highlight
        lblWelcome.Location = New Point(34, 46)
        lblWelcome.Margin = New Padding(4, 0, 4, 0)
        lblWelcome.Name = "lblWelcome"
        lblWelcome.Size = New Size(640, 47)
        lblWelcome.TabIndex = 8
        lblWelcome.Text = "Welcome to the UniClub Manager"
        ' 
        ' lblMemberCount
        ' 
        lblMemberCount.AutoSize = True
        lblMemberCount.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblMemberCount.ForeColor = SystemColors.Control
        lblMemberCount.Location = New Point(4, 0)
        lblMemberCount.Margin = New Padding(4, 0, 4, 0)
        lblMemberCount.Name = "lblMemberCount"
        lblMemberCount.Size = New Size(117, 64)
        lblMemberCount.TabIndex = 9
        lblMemberCount.Text = "Member Count"
        ' 
        ' FlowLayoutPanel1
        ' 
        FlowLayoutPanel1.BackColor = SystemColors.MenuHighlight
        FlowLayoutPanel1.Controls.Add(lblMemberCount)
        FlowLayoutPanel1.Location = New Point(170, 166)
        FlowLayoutPanel1.Margin = New Padding(4, 4, 4, 4)
        FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        FlowLayoutPanel1.Size = New Size(126, 75)
        FlowLayoutPanel1.TabIndex = 11
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.group
        PictureBox1.Location = New Point(90, 166)
        PictureBox1.Margin = New Padding(4, 4, 4, 4)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(80, 80)
        PictureBox1.TabIndex = 12
        PictureBox1.TabStop = False
        ' 
        ' lblEvent
        ' 
        lblEvent.AutoSize = True
        lblEvent.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblEvent.Location = New Point(409, 128)
        lblEvent.Margin = New Padding(4, 0, 4, 0)
        lblEvent.Name = "lblEvent"
        lblEvent.Size = New Size(172, 32)
        lblEvent.TabIndex = 13
        lblEvent.Text = "EVENT COUNT"
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(409, 166)
        PictureBox2.Margin = New Padding(4, 4, 4, 4)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(80, 80)
        PictureBox2.TabIndex = 14
        PictureBox2.TabStop = False
        ' 
        ' FlowLayoutPanel2
        ' 
        FlowLayoutPanel2.BackColor = SystemColors.MenuHighlight
        FlowLayoutPanel2.Controls.Add(lblEventCount)
        FlowLayoutPanel2.Location = New Point(496, 166)
        FlowLayoutPanel2.Margin = New Padding(4, 4, 4, 4)
        FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        FlowLayoutPanel2.Size = New Size(126, 75)
        FlowLayoutPanel2.TabIndex = 16
        ' 
        ' lblEventCount
        ' 
        lblEventCount.AutoSize = True
        lblEventCount.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblEventCount.ForeColor = SystemColors.Control
        lblEventCount.Location = New Point(4, 0)
        lblEventCount.Margin = New Padding(4, 0, 4, 0)
        lblEventCount.Name = "lblEventCount"
        lblEventCount.Size = New Size(84, 64)
        lblEventCount.TabIndex = 9
        lblEventCount.Text = "Event Count"
        ' 
        ' dgvRecentMembers
        ' 
        dgvRecentMembers.AllowUserToAddRows = False
        dgvRecentMembers.AllowUserToDeleteRows = False
        dgvRecentMembers.BackgroundColor = SystemColors.Control
        dgvRecentMembers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvRecentMembers.Location = New Point(90, 324)
        dgvRecentMembers.Margin = New Padding(4, 4, 4, 4)
        dgvRecentMembers.Name = "dgvRecentMembers"
        dgvRecentMembers.ReadOnly = True
        dgvRecentMembers.RowHeadersVisible = False
        dgvRecentMembers.RowHeadersWidth = 51
        dgvRecentMembers.Size = New Size(550, 146)
        dgvRecentMembers.TabIndex = 17
        ' 
        ' lblRecentEntries
        ' 
        lblRecentEntries.AutoSize = True
        lblRecentEntries.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblRecentEntries.Location = New Point(226, 285)
        lblRecentEntries.Margin = New Padding(4, 0, 4, 0)
        lblRecentEntries.Name = "lblRecentEntries"
        lblRecentEntries.Size = New Size(269, 32)
        lblRecentEntries.TabIndex = 18
        lblRecentEntries.Text = "MOST RECENT ENTRIES"
        ' 
        ' pnlMain
        ' 
        pnlMain.Controls.Add(Label3)
        pnlMain.Controls.Add(lblRecentEntries)
        pnlMain.Controls.Add(dgvRecentMembers)
        pnlMain.Controls.Add(FlowLayoutPanel2)
        pnlMain.Controls.Add(PictureBox2)
        pnlMain.Controls.Add(lblEvent)
        pnlMain.Controls.Add(PictureBox1)
        pnlMain.Controls.Add(FlowLayoutPanel1)
        pnlMain.Controls.Add(lblWelcome)
        pnlMain.Controls.Add(DateTimePicker1)
        pnlMain.Dock = DockStyle.Fill
        pnlMain.Location = New Point(312, 55)
        pnlMain.Margin = New Padding(4, 4, 4, 4)
        pnlMain.Name = "pnlMain"
        pnlMain.Size = New Size(772, 511)
        pnlMain.TabIndex = 19
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(90, 128)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(200, 32)
        Label3.TabIndex = 19
        Label3.Text = "MEMBER COUNT"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1084, 566)
        Controls.Add(pnlMain)
        Controls.Add(pnlTopSide)
        Controls.Add(pnlLeftSide)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(4, 4, 4, 4)
        Name = "Form1"
        Text = "Form1"
        pnlLeftSide.ResumeLayout(False)
        pnlLeftSide.PerformLayout()
        pnlTopSide.ResumeLayout(False)
        Panel1.ResumeLayout(False)
        CType(picMinimize, ComponentModel.ISupportInitialize).EndInit()
        CType(picMaximize, ComponentModel.ISupportInitialize).EndInit()
        CType(picClose, ComponentModel.ISupportInitialize).EndInit()
        FlowLayoutPanel1.ResumeLayout(False)
        FlowLayoutPanel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        FlowLayoutPanel2.ResumeLayout(False)
        FlowLayoutPanel2.PerformLayout()
        CType(dgvRecentMembers, ComponentModel.ISupportInitialize).EndInit()
        pnlMain.ResumeLayout(False)
        pnlMain.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnlLeftSide As Panel
    Friend WithEvents btnRegister As Button
    Friend WithEvents pnlTopSide As Panel
    Friend WithEvents pnlOnButtonRegister As Panel
    Friend WithEvents pnlOnButtonAttendance As Panel
    Friend WithEvents btnAttendance As Button
    Friend WithEvents pnlOnButtonEvents As Panel
    Friend WithEvents btnEvents As Button
    Friend WithEvents pnlDashboard As Panel
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents lblAppName As Label
    Friend WithEvents lblWelcome As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents picClose As PictureBox
    Friend WithEvents picMinimize As PictureBox
    Friend WithEvents picMaximize As PictureBox
    Friend WithEvents lblMemberCount As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblEvent As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
    Friend WithEvents lblEventCount As Label
    Friend WithEvents dgvRecentMembers As DataGridView
    Friend WithEvents lblRecentEntries As Label
    Friend WithEvents pnlMain As Panel
    Friend WithEvents Label3 As Label

End Class
