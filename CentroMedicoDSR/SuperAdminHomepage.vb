Imports System.Data.OleDb
Public Class SuperAdminHomepage
    Dim CnString As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Asus\source\repos\CentroMedicoDSR\CentroMedicoDSR\bin\Debug\try.mdb"
    Dim Con As New OleDbConnection(CnString)
    Dim DataSet1 As New DataSet
    Dim DataAdapter1 As OleDbDataAdapter
    Dim CMD As New OleDbCommand

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
    Private Sub ToolStripLabel1_Click(sender As Object, e As EventArgs) Handles ToolStripLabel1.Click
        Logs.Show()
    End Sub

    Private Sub ToolStripLabel2_Click(sender As Object, e As EventArgs) Handles ToolStripLabel2.Click
        EmployeeAdd.Show()

    End Sub



    Private Sub ToolStripLabel4_Click(sender As Object, e As EventArgs) Handles ToolStripLabel4.Click
        Records.Show()

    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Time.Text = TimeString
    End Sub

    Private Sub SuperAdminHomepage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        User.Text = "SuperAdmin"
        Place.Text = "Logged out"
        Timer1.Start()
    End Sub

    Private Sub ToolStripLabel5_Click(sender As Object, e As EventArgs) Handles ToolStripLabel5.Click
        EditEmployee.Show()
    End Sub

    Private Sub ToolStripStatusLabel1_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub ToolStripLabel9_Click(sender As Object, e As EventArgs) Handles ToolStripLabel9.Click
        Dim result As Integer = MsgBox("Are you sure you want to Log Out?", MsgBoxStyle.YesNo)
        If result = DialogResult.No Then
        ElseIf result = DialogResult.Yes Then
            Status.Text = "LOGGED OUT"

            SaveStus()
            LoginForm.Show()
            Me.Close()
        End If
    End Sub
End Class