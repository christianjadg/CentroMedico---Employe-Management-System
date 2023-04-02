Imports System.Data.OleDb
Public Class Printf
    Private Sub Printf_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CentroMedicoDataSet1.EmployeeDetails' table. You can move, or remove it, as needed.
        Me.EmployeeDetailsTableAdapter.Fill(Me.CentroMedicoDSRDataSet.EmployeeDetails)

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If (System.IO.File.Exists(TextBox1.Text)) Then
            PictureBox1.Image = Image.FromFile(TextBox1.Text)
        End If
        If TextBox1.Text = "" Then
            PictureBox1.Hide()
        Else
            PictureBox1.Show()
        End If
    End Sub

    Private Sub ToolStripLabel1_Click(sender As Object, e As EventArgs) Handles ToolStripLabel1.Click


        Dim report1 As New CrystalReport1

        report1.SetParameterValue("Surname", Sname.Text)
        report1.SetParameterValue("Firstname", Fname.Text)
        report1.SetParameterValue("Middlename", Mname.Text)
        report1.SetParameterValue("Sex", Sex.Text)
        report1.SetParameterValue("Contactnumber", ContactNumber.Text)
        report1.SetParameterValue("Birthdate", PickerBirthday.Text)
        report1.SetParameterValue("Age", Age.Text)
        report1.SetParameterValue("CivilStatus", CivilStat.Text)
        report1.SetParameterValue("Email", Email.Text)
        report1.SetParameterValue("Homenumber", Hno.Text)
        report1.SetParameterValue("Street", Hst.Text)
        report1.SetParameterValue("Barangay", Hbar.Text)
        report1.SetParameterValue("Town", Htown.Text)
        report1.SetParameterValue("Province", Hprov.Text)
        report1.SetParameterValue("Zipcode", Hzip.Text)
        report1.SetParameterValue("CurrentHomeNumber", Cno.Text)
        report1.SetParameterValue("CurrentStreet", Cst.Text)
        report1.SetParameterValue("CurrentBarangay", Cbar.Text)
        report1.SetParameterValue("CurrentTown", Ctown.Text)
        report1.SetParameterValue("CurrentProvince", Cprov.Text)
        report1.SetParameterValue("CurrentZipcode", Czip.Text)
        report1.SetParameterValue("EducationalAttainment", EducAttain.Text)
        report1.SetParameterValue("UnivCollege", Univcol.Text)
        report1.SetParameterValue("Program", Program.Text)
        report1.SetParameterValue("Position", Position.Text)
        report1.SetParameterValue("Department", Department.Text)
        report1.SetParameterValue("Division", Division.Text)
        report1.SetParameterValue("Status", ComboStatus.Text)
        report1.SetParameterValue("LicenseNumber", Licenseno.Text)
        report1.SetParameterValue("CertificateNumber", Certno.Text)
        report1.SetParameterValue("ExamTaken", TextBox4.Text)
        report1.SetParameterValue("DateHired", PickerHired.Text)
        report1.SetParameterValue("PermanencyDate", PickerPermanency.Text)
        report1.SetParameterValue("LastDay", PickerLast.Text)
        report1.SetParameterValue("Reasonforleaving", Reason.Text)
        report1.SetParameterValue("UMID", WID.Text)
        report1.SetParameterValue("SSS", SSS.Text)
        report1.SetParameterValue("Philhealth", Philhealth.Text)
        report1.SetParameterValue("TIN", TIR.Text)
        report1.SetParameterValue("PAGIBIG", PAGIBIG.Text)
        report1.SetParameterValue("Evaluation", Evaluation.Text)
        report1.SetParameterValue("Picture", TextBox1.Text)
        report1.SetParameterValue("Smname", Msname.Text)
        report1.SetParameterValue("Fmname", Mfname.Text)
        report1.SetParameterValue("Mmname", Mmname.Text)
        report1.SetParameterValue("exp", exp.Text)
        report1.SetParameterValue("leavecred", leavecred.Text)
        report1.SetParameterValue("sanc", sanc.Text)
        report1.SetParameterValue("sickleave", sickleave.Text)
        report1.SetParameterValue("vacleave", vacleave.Text)
        report1.SetParameterValue("asof", asof.Text)
        report1.SetParameterValue("evalrat", evalrat.Text)
        report1.SetParameterValue("sanclong", sanclong.Text)
        report1.SetParameterValue("rat", rat.Text)


        printcrystal.CrystalReportViewer1.ReportSource = report1
        printcrystal.ShowDialog()





    End Sub

    Private Sub EducAttain_TextChanged(sender As Object, e As EventArgs)


    End Sub

    Private Sub Licenseno_TextChanged(sender As Object, e As EventArgs) Handles Licenseno.TextChanged

    End Sub

    Private Sub GroupBox5_Enter(sender As Object, e As EventArgs) Handles GroupBox5.Enter

    End Sub
End Class