Imports System.Data.OleDb
Public Class Logs

    Dim CnString As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Asus\source\repos\CentroMedicoDSR\CentroMedicoDSR\bin\Debug\try.mdb"
    Dim Con As New OleDbConnection(CnString)
    Dim DataSet1 As New DataSet
    Dim DataAdapter1 As OleDbDataAdapter
    Dim CMD As New OleDbCommand

    Public Sub FillDGV1()
        DataAdapter1 = New OleDbDataAdapter("Select  * From Status", Con)
        DataSet1.Clear()
        DataAdapter1.Fill(DataSet1, "Status")

        DataGridView1.DataSource = DataSet1
        DataGridView1.DataMember = "Status"
        DataGridView1.Refresh()
    End Sub

    Private Sub BtnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        Call FillDGV1()

        Search.Clear()
        lblRecords.Text = DataGridView1.RowCount
    End Sub

    Private Sub Logs_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        Con.Open()
        Call FillDGV1()

        txtID.DataBindings.Add("Text", DataSet1, "Status.ID")
        User.DataBindings.Add("Text", DataSet1, "Status.user")
        TextBox1.DataBindings.Add("Text", DataSet1, "Status.status")
        Place.DataBindings.Add("Text", DataSet1, "Status.place")
        textDate.DataBindings.Add("Text", DataSet1, "Status.date")
        Time.DataBindings.Add("Text", DataSet1, "Status.time")

        DataGridView1.Columns(0).Visible = False
        DataGridView1.Columns(1).HeaderText = "User"
        DataGridView1.Columns(2).HeaderText = "Status"
        DataGridView1.Columns(3).HeaderText = "Place"
        DataGridView1.Columns(4).HeaderText = "Date"
        DataGridView1.Columns(5).HeaderText = "Time"

        DataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridView1.MultiSelect = False

        ComboBox1.Items.Add("User")
        ComboBox1.Items.Add("Place")
        ComboBox1.Items.Add("Date")

        ComboBox2.Items.Add("user")
        ComboBox2.Items.Add("place")
        ComboBox2.Items.Add("date")

        ComboBox1.SelectedIndex = 0
        ComboBox2.Visible = False

        txtID.Visible = False

        CMD.CommandType = CommandType.Text
        CMD.Connection = Con

        lblRecords.Text = DataGridView1.RowCount
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        ComboBox2.SelectedIndex = ComboBox1.SelectedIndex
    End Sub

    Private Sub Search_TextChanged(sender As Object, e As EventArgs) Handles Search.TextChanged
        If Trim(Search.Text) <> "" Then

            DataAdapter1 = New OleDbDataAdapter("Select * From Status Where " & ComboBox2.Text & " Like '%" & Trim$(Search.Text) & "%'", Con)

            DataSet1.Clear()
            DataAdapter1.Fill(DataSet1, "Status")

            DataGridView1.DataSource = DataSet1
            DataGridView1.DataMember = "Status"
            DataGridView1.Refresh()

            lblRecords.Text = DataGridView1.RowCount

        Else
            Call FillDGV1()
            lblRecords.Text = DataGridView1.RowCount
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        SuperAdminHomepage.Show()
        Me.Close()
    End Sub

    Private Sub LblRecords_Click(sender As Object, e As EventArgs) Handles lblRecords.Click

    End Sub
End Class