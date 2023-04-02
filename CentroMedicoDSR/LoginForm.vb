Option Explicit On
Imports System.Data.OleDb
Public Class LoginForm

    Dim CnString As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Asus\source\repos\CentroMedicoDSR\CentroMedicoDSR\bin\Debug\try.mdb"
    Dim Con As New OleDbConnection(CnString)
    Dim DataSet1 As New DataSet
    Dim DataAdapter1 As OleDbDataAdapter
    Dim CMD As New OleDbCommand

    ' TODO: Insert code to perform custom authentication using the provided username and password 
    ' (See https://go.microsoft.com/fwlink/?LinkId=35339).  
    ' The custom principal can then be attached to the current thread's principal as follows: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
    ' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    ' such as the username, display name, etc.

    Private Sub SaveStus()
        Con.Open()
        Dim cmd As New OleDbCommand("INSERT INTO Status ([user], [status], [place], [date], [time]) VALUES(@User, @Status, @Place, @DateTimePicker1, @Time)", Con)
        With cmd.Parameters
            .AddWithValue("@user", User.Text)
            .AddWithValue("@status", Status.Text)
            .AddWithValue("@place", Place.Text)
            .AddWithValue("@date", DateTimePicker1.Text)
            .AddWithValue("@time", Time.Text)
        End With

        cmd.ExecuteNonQuery()
        cmd.Dispose()
        Con.Close()

    End Sub

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        If UsernameTextBox.Text = My.Settings.SuperAdminUser And PasswordTextBox.Text = My.Settings.SuperAdminPass Then
            Call adminLogin()
            User.Text = "SuperAdmin"
            Status.Text = "SuperAdmin has Logged IN"
            Place.Text = "In"
            SaveStus()

        ElseIf UsernameTextBox.Text = My.Settings.AdminUser And PasswordTextBox.Text = My.Settings.AdminPass Then
            Call userLogin()
            User.Text = "Admin"
            Status.Text = "Admin has Logged IN"
            Place.Text = "In"
            SaveStus()

        ElseIf UsernameTextBox.Text & PasswordTextBox.Text = "" Then
            MsgBox("Fill all the textboxes!", MessageBoxIcon.Error)
            UsernameTextBox.Focus()

        ElseIf UsernameTextBox.Text <> My.Settings.SuperAdminUser And UsernameTextBox.Text <> My.Settings.AdminUser Then
            MsgBox("Username Wrong!", MessageBoxIcon.Warning)

            UsernameTextBox.SelectAll()
            UsernameTextBox.Focus()

            Return
        Else
            MsgBox("Password Wrong!", MessageBoxIcon.Warning)


        End If
        UsernameTextBox.Clear()
        PasswordTextBox.Clear()
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Application.Exit()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If (Me.CheckBox1.Checked = True) Then
            Me.PasswordTextBox.PasswordChar = ""
        Else
            Me.PasswordTextBox.PasswordChar = "*"c
        End If
    End Sub

    Public Sub clearControls()
        If (Me.UsernameTextBox.CanSelect) Then
            Me.UsernameTextBox.Clear()
            Me.PasswordTextBox.Clear()
            Me.UsernameTextBox.Select()
        End If

        If (Me.CheckBox1.Checked = True) Then Me.CheckBox1.Checked = False

    End Sub
    Private Sub adminLogin()
        SuperAdminHomepage.Show()
        Me.Hide()
        'User.Text = "SuperAdmin"
        'Place.Text = "Employee Adding"
        SuperAdminHomepage.ToolStripStatusLabelAdmin.Text = Me.UsernameTextBox.Text
    End Sub

    Private Sub userLogin()
        Homepage.Show()
        Me.Hide()
        'User.Text = "Admin"
        'Place.Text = "Employee Adding"
        'Homepage.ToolStrip1.Visible = False
        'Homepage.ToolStripLabel2.Visible = False
        Homepage.ToolStripStatusLabel1.Text = Me.UsernameTextBox.Text

    End Sub

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        'If UsernameTextBox.Text = "SuperAdmin" Then
        '    User.Text = "SuperAdmin"
        '    Place.Text = "IN"
        '    ' Timer1.Start()
        'ElseIf UsernameTextBox.Text = "Admin" Then
        '    User.Text = "Admin"
        '    Place.Text = "IN"

        'End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Time.Text = TimeString
    End Sub


End Class
