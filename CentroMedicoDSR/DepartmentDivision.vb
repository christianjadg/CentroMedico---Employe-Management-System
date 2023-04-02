Imports System.Data.OleDb
Public Class DepartmentDivision


    Private Sub CrystalReportViewer1_Load(sender As Object, e As EventArgs) Handles CrystalReportViewer1.Load
        Dim ds As New CentroMedicoDSRDataSet
        Dim ad As New CentroMedicoDSRDataSetTableAdapters.EmployeeDetailsTableAdapter
        ad.Fill(ds.EmployeeDetails)
        Dim rpt As New CrystalReportDepartmentDivision
        rpt.SetDataSource(ds)
        CrystalReportViewer1.ReportSource = rpt

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim con As New OleDbConnection
        con.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Asus\source\repos\CentroMedicoDSR\CentroMedicoDSR.mdb"
        con.Open()
        Dim da As New OleDbDataAdapter("select * from EmployeeDetails where [Department] OR [Division]='" + ComboBox1.Text + "'", con)
        Dim DS As New DataSet
        da.Fill(DS)
        CrystalReportViewer1.RefreshReport()
        CrystalReportViewer1.SelectionFormula = "{EmployeeDetails.Department}='" & ComboBox1.Text & "'OR{EmployeeDetails.Division}='" & ComboBox1.Text & "'"

        CrystalReportViewer1.RefreshReport()
        con.Close()




    End Sub
End Class