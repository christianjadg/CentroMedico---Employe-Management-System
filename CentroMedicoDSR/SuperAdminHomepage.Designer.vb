<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SuperAdminHomepage
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SuperAdminHomepage))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripLabel6 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripLabel7 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripLabel5 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripLabel8 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripLabel4 = New System.Windows.Forms.ToolStripLabel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Time = New System.Windows.Forms.TextBox()
        Me.Place = New System.Windows.Forms.TextBox()
        Me.Status = New System.Windows.Forms.TextBox()
        Me.User = New System.Windows.Forms.TextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabelAdmin = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripLabel3 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripLabel9 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Panel1.Location = New System.Drawing.Point(152, 48)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(512, 184)
        Me.Panel1.TabIndex = 8
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.Azure
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.ToolStripLabel6, Me.ToolStripLabel2, Me.ToolStripLabel7, Me.ToolStripLabel5, Me.ToolStripLabel8, Me.ToolStripLabel4, Me.ToolStripLabel3, Me.ToolStripLabel9})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(800, 25)
        Me.ToolStrip1.TabIndex = 6
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold)
        Me.ToolStripLabel1.Image = CType(resources.GetObject("ToolStripLabel1.Image"), System.Drawing.Image)
        Me.ToolStripLabel1.IsLink = True
        Me.ToolStripLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.ToolStripLabel1.LinkColor = System.Drawing.Color.Black
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(62, 22)
        Me.ToolStripLabel1.Text = "Logs"
        '
        'ToolStripLabel6
        '
        Me.ToolStripLabel6.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold)
        Me.ToolStripLabel6.Name = "ToolStripLabel6"
        Me.ToolStripLabel6.Size = New System.Drawing.Size(14, 22)
        Me.ToolStripLabel6.Text = "|"
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold)
        Me.ToolStripLabel2.Image = CType(resources.GetObject("ToolStripLabel2.Image"), System.Drawing.Image)
        Me.ToolStripLabel2.IsLink = True
        Me.ToolStripLabel2.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.ToolStripLabel2.LinkColor = System.Drawing.Color.Black
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(189, 22)
        Me.ToolStripLabel2.Text = "Adding of Employee"
        '
        'ToolStripLabel7
        '
        Me.ToolStripLabel7.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold)
        Me.ToolStripLabel7.Name = "ToolStripLabel7"
        Me.ToolStripLabel7.Size = New System.Drawing.Size(14, 22)
        Me.ToolStripLabel7.Text = "|"
        '
        'ToolStripLabel5
        '
        Me.ToolStripLabel5.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold)
        Me.ToolStripLabel5.Image = CType(resources.GetObject("ToolStripLabel5.Image"), System.Drawing.Image)
        Me.ToolStripLabel5.IsLink = True
        Me.ToolStripLabel5.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.ToolStripLabel5.LinkColor = System.Drawing.Color.Black
        Me.ToolStripLabel5.Name = "ToolStripLabel5"
        Me.ToolStripLabel5.Size = New System.Drawing.Size(59, 22)
        Me.ToolStripLabel5.Text = "Edit"
        '
        'ToolStripLabel8
        '
        Me.ToolStripLabel8.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold)
        Me.ToolStripLabel8.Name = "ToolStripLabel8"
        Me.ToolStripLabel8.Size = New System.Drawing.Size(14, 22)
        Me.ToolStripLabel8.Text = "|"
        '
        'ToolStripLabel4
        '
        Me.ToolStripLabel4.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold)
        Me.ToolStripLabel4.Image = CType(resources.GetObject("ToolStripLabel4.Image"), System.Drawing.Image)
        Me.ToolStripLabel4.IsLink = True
        Me.ToolStripLabel4.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.ToolStripLabel4.LinkColor = System.Drawing.Color.Black
        Me.ToolStripLabel4.Name = "ToolStripLabel4"
        Me.ToolStripLabel4.Size = New System.Drawing.Size(91, 22)
        Me.ToolStripLabel4.Text = "Records"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox2.Controls.Add(Me.Time)
        Me.GroupBox2.Controls.Add(Me.Place)
        Me.GroupBox2.Controls.Add(Me.Status)
        Me.GroupBox2.Controls.Add(Me.User)
        Me.GroupBox2.Location = New System.Drawing.Point(-256, 232)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 184)
        Me.GroupBox2.TabIndex = 117
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "GroupBox2"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "MM/dd/yyyy"
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(40, 136)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(104, 20)
        Me.DateTimePicker1.TabIndex = 4
        '
        'Time
        '
        Me.Time.Location = New System.Drawing.Point(40, 160)
        Me.Time.Name = "Time"
        Me.Time.Size = New System.Drawing.Size(100, 20)
        Me.Time.TabIndex = 3
        '
        'Place
        '
        Me.Place.Location = New System.Drawing.Point(40, 112)
        Me.Place.Name = "Place"
        Me.Place.Size = New System.Drawing.Size(100, 20)
        Me.Place.TabIndex = 2
        '
        'Status
        '
        Me.Status.Location = New System.Drawing.Point(40, 80)
        Me.Status.Name = "Status"
        Me.Status.Size = New System.Drawing.Size(100, 20)
        Me.Status.TabIndex = 1
        '
        'User
        '
        Me.User.Location = New System.Drawing.Point(40, 48)
        Me.User.Name = "User"
        Me.User.Size = New System.Drawing.Size(100, 20)
        Me.User.TabIndex = 0
        '
        'Timer1
        '
        Me.Timer1.Interval = 1
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.Azure
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabelAdmin})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 428)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(800, 22)
        Me.StatusStrip1.TabIndex = 118
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabelAdmin
        '
        Me.ToolStripStatusLabelAdmin.Name = "ToolStripStatusLabelAdmin"
        Me.ToolStripStatusLabelAdmin.Size = New System.Drawing.Size(39, 17)
        Me.ToolStripStatusLabelAdmin.Text = "Status"
        '
        'ToolStripLabel3
        '
        Me.ToolStripLabel3.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold)
        Me.ToolStripLabel3.Name = "ToolStripLabel3"
        Me.ToolStripLabel3.Size = New System.Drawing.Size(14, 22)
        Me.ToolStripLabel3.Text = "|"
        '
        'ToolStripLabel9
        '
        Me.ToolStripLabel9.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold)
        Me.ToolStripLabel9.Image = CType(resources.GetObject("ToolStripLabel9.Image"), System.Drawing.Image)
        Me.ToolStripLabel9.IsLink = True
        Me.ToolStripLabel9.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.ToolStripLabel9.LinkColor = System.Drawing.Color.Black
        Me.ToolStripLabel9.Name = "ToolStripLabel9"
        Me.ToolStripLabel9.Size = New System.Drawing.Size(89, 22)
        Me.ToolStripLabel9.Text = "Log Out"
        '
        'SuperAdminHomepage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "SuperAdminHomepage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SuperAdminHomepage"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
    Friend WithEvents ToolStripLabel4 As ToolStripLabel
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Time As TextBox
    Friend WithEvents Place As TextBox
    Friend WithEvents Status As TextBox
    Friend WithEvents User As TextBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents ToolStripLabel5 As ToolStripLabel
    Friend WithEvents ToolStripLabel6 As ToolStripLabel
    Friend WithEvents ToolStripLabel7 As ToolStripLabel
    Friend WithEvents ToolStripLabel8 As ToolStripLabel
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabelAdmin As ToolStripStatusLabel
    Friend WithEvents ToolStripLabel3 As ToolStripLabel
    Friend WithEvents ToolStripLabel9 As ToolStripLabel
End Class
