<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucDashboard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucDashboard))
        pnlMain = New Panel()
        Label3 = New Label()
        lblRecentEntries = New Label()
        dgvRecentMembers = New DataGridView()
        FlowLayoutPanel2 = New FlowLayoutPanel()
        lblEventCount = New Label()
        PictureBox2 = New PictureBox()
        lblEvent = New Label()
        PictureBox1 = New PictureBox()
        FlowLayoutPanel1 = New FlowLayoutPanel()
        lblMemberCount = New Label()
        lblWelcome = New Label()
        DateTimePicker1 = New DateTimePicker()
        pnlMain.SuspendLayout()
        CType(dgvRecentMembers, ComponentModel.ISupportInitialize).BeginInit()
        FlowLayoutPanel2.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        FlowLayoutPanel1.SuspendLayout()
        SuspendLayout()
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
        pnlMain.Location = New Point(0, 0)
        pnlMain.Name = "pnlMain"
        pnlMain.Size = New Size(617, 409)
        pnlMain.TabIndex = 20
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(72, 102)
        Label3.Name = "Label3"
        Label3.Size = New Size(165, 28)
        Label3.TabIndex = 19
        Label3.Text = "MEMBER COUNT"
        ' 
        ' lblRecentEntries
        ' 
        lblRecentEntries.AutoSize = True
        lblRecentEntries.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblRecentEntries.Location = New Point(181, 228)
        lblRecentEntries.Name = "lblRecentEntries"
        lblRecentEntries.Size = New Size(224, 28)
        lblRecentEntries.TabIndex = 18
        lblRecentEntries.Text = "MOST RECENT ENTRIES"
        ' 
        ' dgvRecentMembers
        ' 
        dgvRecentMembers.AllowUserToAddRows = False
        dgvRecentMembers.AllowUserToDeleteRows = False
        dgvRecentMembers.BackgroundColor = SystemColors.Control
        dgvRecentMembers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvRecentMembers.Location = New Point(72, 259)
        dgvRecentMembers.Name = "dgvRecentMembers"
        dgvRecentMembers.ReadOnly = True
        dgvRecentMembers.RowHeadersVisible = False
        dgvRecentMembers.RowHeadersWidth = 51
        dgvRecentMembers.Size = New Size(440, 117)
        dgvRecentMembers.TabIndex = 17
        ' 
        ' FlowLayoutPanel2
        ' 
        FlowLayoutPanel2.BackColor = SystemColors.MenuHighlight
        FlowLayoutPanel2.Controls.Add(lblEventCount)
        FlowLayoutPanel2.Location = New Point(397, 133)
        FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        FlowLayoutPanel2.Size = New Size(101, 60)
        FlowLayoutPanel2.TabIndex = 16
        ' 
        ' lblEventCount
        ' 
        lblEventCount.AutoSize = True
        lblEventCount.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblEventCount.ForeColor = SystemColors.Control
        lblEventCount.Location = New Point(3, 0)
        lblEventCount.Name = "lblEventCount"
        lblEventCount.Size = New Size(71, 56)
        lblEventCount.TabIndex = 9
        lblEventCount.Text = "Event Count"
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(327, 133)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(64, 64)
        PictureBox2.TabIndex = 14
        PictureBox2.TabStop = False
        ' 
        ' lblEvent
        ' 
        lblEvent.AutoSize = True
        lblEvent.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblEvent.Location = New Point(327, 102)
        lblEvent.Name = "lblEvent"
        lblEvent.Size = New Size(144, 28)
        lblEvent.TabIndex = 13
        lblEvent.Text = "EVENT COUNT"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.group
        PictureBox1.Location = New Point(72, 133)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(64, 64)
        PictureBox1.TabIndex = 12
        PictureBox1.TabStop = False
        ' 
        ' FlowLayoutPanel1
        ' 
        FlowLayoutPanel1.BackColor = SystemColors.MenuHighlight
        FlowLayoutPanel1.Controls.Add(lblMemberCount)
        FlowLayoutPanel1.Location = New Point(136, 133)
        FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        FlowLayoutPanel1.Size = New Size(101, 60)
        FlowLayoutPanel1.TabIndex = 11
        ' 
        ' lblMemberCount
        ' 
        lblMemberCount.AutoSize = True
        lblMemberCount.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblMemberCount.ForeColor = SystemColors.Control
        lblMemberCount.Location = New Point(3, 0)
        lblMemberCount.Name = "lblMemberCount"
        lblMemberCount.Size = New Size(91, 56)
        lblMemberCount.TabIndex = 9
        lblMemberCount.Text = "Member Count"
        ' 
        ' lblWelcome
        ' 
        lblWelcome.AutoSize = True
        lblWelcome.Font = New Font("Imprint MT Shadow", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblWelcome.ForeColor = SystemColors.Highlight
        lblWelcome.Location = New Point(27, 37)
        lblWelcome.Name = "lblWelcome"
        lblWelcome.Size = New Size(546, 40)
        lblWelcome.TabIndex = 8
        lblWelcome.Text = "Welcome to the UniClub Manager"
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Location = New Point(376, 0)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(238, 27)
        DateTimePicker1.TabIndex = 3
        ' 
        ' ucDashboard
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(pnlMain)
        Name = "ucDashboard"
        Size = New Size(617, 409)
        pnlMain.ResumeLayout(False)
        pnlMain.PerformLayout()
        CType(dgvRecentMembers, ComponentModel.ISupportInitialize).EndInit()
        FlowLayoutPanel2.ResumeLayout(False)
        FlowLayoutPanel2.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        FlowLayoutPanel1.ResumeLayout(False)
        FlowLayoutPanel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnlMain As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents lblRecentEntries As Label
    Friend WithEvents dgvRecentMembers As DataGridView
    Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
    Friend WithEvents lblEventCount As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents lblEvent As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents lblMemberCount As Label
    Friend WithEvents lblWelcome As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker

End Class
