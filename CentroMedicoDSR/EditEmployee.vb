Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports System.Configuration
Imports System.IO
Imports System.Drawing.Imaging
Imports System.String
Imports Microsoft.Office.Interop
Imports Microsoft.Office.Interop.Word

Public Class EditEmployee

    Dim oDocument As Object

    Private Sub EditEmployee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CentroMedicoDSRDataSet.EmployeeDetails' table. You can move, or remove it, as needed.
        Me.EmployeeDetailsTableAdapter.Fill(Me.CentroMedicoDSRDataSet.EmployeeDetails)

    End Sub

    Private Sub ButtonSave_Click(sender As Object, e As EventArgs) Handles ButtonSave.Click
        EmployeeDetailsBindingSource.EndEdit()
        EmployeeDetailsTableAdapter.Update(CentroMedicoDSRDataSet.EmployeeDetails)
        MsgBox("Records successfully UPDATED.", MsgBoxStyle.OkOnly)
        Exit Sub
    End Sub

    Private Sub HScrollBar1_Scroll(sender As Object, e As ScrollEventArgs) Handles HScrollBar1.Scroll
        rat.Text = HScrollBar1.Value
    End Sub

    Private Sub HScrollBar2_Scroll(sender As Object, e As ScrollEventArgs) Handles HScrollBar2.Scroll
        evalrat.Text = HScrollBar2.Value
    End Sub

    Private Sub Browse_Click(sender As Object, e As EventArgs) Handles Browse.Click
        OpenFileDialog1.Filter = "JPEG FILE | *.jpeg |PNG FILE |*.png|JPG FILE | *.JPG "
        OpenFileDialog1.ShowDialog()
        PictureBox.Text = OpenFileDialog1.FileName
    End Sub

    Private Sub PictureBox_TextChanged(sender As Object, e As EventArgs) Handles PictureBox.TextChanged
        If (System.IO.File.Exists(PictureBox.Text)) Then
            PictureBox2.Image = Image.FromFile(PictureBox.Text)
        End If
        If PictureBox.Text = "" Then
            PictureBox2.Hide()
        Else
            PictureBox2.Show()
        End If
    End Sub

    Private Sub Searchh_Click(sender As Object, e As EventArgs) Handles Searchh.Click
        If SearchBox.Text = "" Then
            Exit Sub
        Else
            Dim cantFind As String = SearchBox.Text


            EmployeeDetailsBindingSource.Filter = "(Convert(Employee_ID, 'System.String') LIKE'" & SearchBox.Text & "')" &
                "OR (Surname LIKE '" & SearchBox.Text & "') OR (Firstname LIKE '" & SearchBox.Text & "')" &
                 "OR (Middlename LIKE '" & SearchBox.Text & "') OR (HNo LIKE '" & SearchBox.Text & "')" &
                  "OR (HStreet LIKE '" & SearchBox.Text & "') OR (Hbarangay LIKE '" & SearchBox.Text & "')" &
                  "OR (HTown LIKE '" & SearchBox.Text & "') OR (HProvince LIKE '" & SearchBox.Text & "')" &
                  "OR (HZip LIKE '" & SearchBox.Text & "') OR (CNo LIKE '" & SearchBox.Text & "')" &
                  "OR (CStreet LIKE '" & SearchBox.Text & "') OR (Cbarangay LIKE '" & SearchBox.Text & "')" &
                  "OR (CTown LIKE '" & SearchBox.Text & "') OR (CProvince LIKE '" & SearchBox.Text & "')" &
                  "OR (CZip LIKE '" & SearchBox.Text & "') OR (Sex LIKE '" & SearchBox.Text & "')" &
                  "OR (Age LIKE '" & SearchBox.Text & "') OR (CivilStatus LIKE '" & SearchBox.Text & "')" &
                  "OR (Email LIKE '" & SearchBox.Text & "')" &
                  "OR (ContactNumber LIKE '" & SearchBox.Text & "') OR (Position LIKE '" & SearchBox.Text & "')" &
                  "OR (Department LIKE '" & SearchBox.Text & "') OR (Division LIKE '" & SearchBox.Text & "')" &
                  "OR (EducationalAttainment LIKE '" & SearchBox.Text & "') OR (University_College LIKE '" & SearchBox.Text & "')" &
                  "OR (Program LIKE '" & SearchBox.Text & "')" &
                  "OR (Status LIKE '" & SearchBox.Text & "')" &
                  "OR (ReasonForLeaving LIKE '" & SearchBox.Text & "')" &
                  "OR (LicenseNumber LIKE '" & SearchBox.Text & "')" &
                  "OR (ExamTaken LIKE '" & SearchBox.Text & "') OR (CertificateNumber LIKE '" & SearchBox.Text & "')" &
                  "OR (UMID LIKE '" & SearchBox.Text & "') OR (SSS LIKE '" & SearchBox.Text & "')" &
                  "OR (PhilHealth LIKE '" & SearchBox.Text & "') OR (TIN LIKE '" & SearchBox.Text & "')" &
                  "OR (PAGIBIG LIKE '" & SearchBox.Text & "') OR (Evaluation LIKE '" & SearchBox.Text & "')" &
                  "OR (Picture LIKE '" & SearchBox.Text & "') OR (MSurname LIKE '" & SearchBox.Text & "')" &
                  "OR (MFirstname LIKE '" & SearchBox.Text & "') OR (MMiddlename LIKE '" & SearchBox.Text & "')" &
                  "OR (Rating LIKE '" & SearchBox.Text & "') OR (EvaluationRating LIKE '" & SearchBox.Text & "')" &
                  "OR (Sanctions LIKE '" & SearchBox.Text & "') OR (SanctionsNo LIKE '" & SearchBox.Text & "')" &
                  "OR (SickLeave LIKE '" & SearchBox.Text & "')" &
                  "OR (VacationLeave LIKE '" & SearchBox.Text & "')" &
                  "OR (LeaveCredits LIKE '" & SearchBox.Text & "')"
            If EmployeeDetailsBindingSource.Count <> 0 Then
                With DataGridView1
                    .DataSource = EmployeeDetailsBindingSource
                End With

            Else

                MsgBox("  " & cantFind & vbNewLine &
                       "The Searched Data Was NOT Found",
MsgBoxStyle.Information, "Notice!")

                EmployeeDetailsBindingSource.Filter = Nothing

                With DataGridView1
                    .ClearSelection()
                    .ReadOnly = True
                    .MultiSelect = False
                    .DataSource = EmployeeDetailsBindingSource
                End With
            End If
        End If
    End Sub

    Private Sub SearchBox_TextChanged(sender As Object, e As EventArgs) Handles SearchBox.TextChanged

    End Sub

    Private Sub ButtonBack_Click(sender As Object, e As EventArgs) Handles ButtonBack.Click
        EmployeeAdd.Show()
        Me.Close()
    End Sub

    Private Sub PickerBirthday_ValueChanged(sender As Object, e As EventArgs) Handles PickerBirthday.ValueChanged
        Dim today, dob As Integer
        today = Date.Today.Year
        dob = PickerBirthday.Value.Year
        Age.Text = today - dob
    End Sub

    Private Sub Upload_Click(sender As Object, e As EventArgs) Handles upload.Click
        Dim file(2) As String
        file = Nothing
        OpenFileDialog2.ShowDialog()
        file = OpenFileDialog2.FileNames

        Attachbox1.Text = file(0)
        Try
            Attachbox2.Text = file(1)
        Catch ex As IndexOutOfRangeException
        End Try
        Try
            Attachbox3.Text = file(2)
        Catch ex As IndexOutOfRangeException
        End Try
    End Sub

    Private Sub Sortname_Click(sender As Object, e As EventArgs) Handles Sortname.Click

        If Sortbox.Text = "Name" Then
            DataGridView1.Columns(1).Visible = True
            DataGridView1.Columns(2).Visible = True
            DataGridView1.Columns(3).Visible = True

            DataGridView1.Columns(4).Visible = False
            DataGridView1.Columns(5).Visible = False
            DataGridView1.Columns(6).Visible = False
            DataGridView1.Columns(7).Visible = False
            DataGridView1.Columns(8).Visible = False
            DataGridView1.Columns(9).Visible = False
            DataGridView1.Columns(10).Visible = False
            DataGridView1.Columns(11).Visible = False
            DataGridView1.Columns(12).Visible = False
            DataGridView1.Columns(13).Visible = False
            DataGridView1.Columns(14).Visible = False
            DataGridView1.Columns(15).Visible = False
            DataGridView1.Columns(16).Visible = False
            DataGridView1.Columns(17).Visible = False
            DataGridView1.Columns(18).Visible = False
            DataGridView1.Columns(19).Visible = False
            DataGridView1.Columns(20).Visible = False
            DataGridView1.Columns(21).Visible = False
            DataGridView1.Columns(22).Visible = False
            DataGridView1.Columns(23).Visible = False
            DataGridView1.Columns(24).Visible = False
            DataGridView1.Columns(25).Visible = False
            DataGridView1.Columns(26).Visible = False
            DataGridView1.Columns(27).Visible = False
            DataGridView1.Columns(28).Visible = False
            DataGridView1.Columns(29).Visible = False
            DataGridView1.Columns(30).Visible = False
            DataGridView1.Columns(31).Visible = False
            DataGridView1.Columns(32).Visible = False
            DataGridView1.Columns(33).Visible = False
            DataGridView1.Columns(34).Visible = False
            DataGridView1.Columns(35).Visible = False
            DataGridView1.Columns(36).Visible = False
            DataGridView1.Columns(37).Visible = False
            DataGridView1.Columns(38).Visible = False
            DataGridView1.Columns(39).Visible = False
            DataGridView1.Columns(40).Visible = False
            DataGridView1.Columns(41).Visible = False
            DataGridView1.Columns(42).Visible = False
            DataGridView1.Columns(43).Visible = False
            DataGridView1.Columns(44).Visible = False
            DataGridView1.Columns(45).Visible = False
            DataGridView1.Columns(46).Visible = False
            DataGridView1.Columns(47).Visible = False
            DataGridView1.Columns(48).Visible = False
            DataGridView1.Columns(49).Visible = False
            DataGridView1.Columns(50).Visible = False
            DataGridView1.Columns(51).Visible = False
            DataGridView1.Columns(52).Visible = False
            DataGridView1.Columns(53).Visible = False
            DataGridView1.Columns(54).Visible = False
            DataGridView1.Columns(55).Visible = False


        ElseIf Sortbox.Text = "Home Number" Then
            DataGridView1.Columns(1).Visible = True
            DataGridView1.Columns(2).Visible = True
            DataGridView1.Columns(3).Visible = True

            DataGridView1.Columns(4).Visible = True
            DataGridView1.Columns(5).Visible = False
            DataGridView1.Columns(6).Visible = False
            DataGridView1.Columns(7).Visible = False
            DataGridView1.Columns(8).Visible = False
            DataGridView1.Columns(9).Visible = False
            DataGridView1.Columns(10).Visible = False
            DataGridView1.Columns(11).Visible = False
            DataGridView1.Columns(12).Visible = False
            DataGridView1.Columns(13).Visible = False
            DataGridView1.Columns(14).Visible = False
            DataGridView1.Columns(15).Visible = False
            DataGridView1.Columns(16).Visible = False
            DataGridView1.Columns(17).Visible = False
            DataGridView1.Columns(18).Visible = False
            DataGridView1.Columns(19).Visible = False
            DataGridView1.Columns(20).Visible = False
            DataGridView1.Columns(21).Visible = False
            DataGridView1.Columns(22).Visible = False
            DataGridView1.Columns(23).Visible = False
            DataGridView1.Columns(24).Visible = False
            DataGridView1.Columns(25).Visible = False
            DataGridView1.Columns(26).Visible = False
            DataGridView1.Columns(27).Visible = False
            DataGridView1.Columns(28).Visible = False
            DataGridView1.Columns(29).Visible = False
            DataGridView1.Columns(30).Visible = False
            DataGridView1.Columns(31).Visible = False
            DataGridView1.Columns(32).Visible = False
            DataGridView1.Columns(33).Visible = False
            DataGridView1.Columns(34).Visible = False
            DataGridView1.Columns(35).Visible = False
            DataGridView1.Columns(36).Visible = False
            DataGridView1.Columns(37).Visible = False
            DataGridView1.Columns(38).Visible = False
            DataGridView1.Columns(39).Visible = False
            DataGridView1.Columns(40).Visible = False
            DataGridView1.Columns(41).Visible = False
            DataGridView1.Columns(42).Visible = False
            DataGridView1.Columns(43).Visible = False
            DataGridView1.Columns(44).Visible = False
            DataGridView1.Columns(45).Visible = False
            DataGridView1.Columns(46).Visible = False
            DataGridView1.Columns(47).Visible = False
            DataGridView1.Columns(48).Visible = False
            DataGridView1.Columns(49).Visible = False
            DataGridView1.Columns(50).Visible = False
            DataGridView1.Columns(51).Visible = False
            DataGridView1.Columns(52).Visible = False
            DataGridView1.Columns(53).Visible = False
            DataGridView1.Columns(54).Visible = False
            DataGridView1.Columns(55).Visible = False


        ElseIf Sortbox.Text = "Street" Then
            DataGridView1.Columns(1).Visible = True
            DataGridView1.Columns(2).Visible = True
            DataGridView1.Columns(3).Visible = True

            DataGridView1.Columns(4).Visible = False
            DataGridView1.Columns(5).Visible = True
            DataGridView1.Columns(6).Visible = False
            DataGridView1.Columns(7).Visible = False
            DataGridView1.Columns(8).Visible = False
            DataGridView1.Columns(9).Visible = False
            DataGridView1.Columns(10).Visible = False
            DataGridView1.Columns(11).Visible = False
            DataGridView1.Columns(12).Visible = False
            DataGridView1.Columns(13).Visible = False
            DataGridView1.Columns(14).Visible = False
            DataGridView1.Columns(15).Visible = False
            DataGridView1.Columns(16).Visible = False
            DataGridView1.Columns(17).Visible = False
            DataGridView1.Columns(18).Visible = False
            DataGridView1.Columns(19).Visible = False
            DataGridView1.Columns(20).Visible = False
            DataGridView1.Columns(21).Visible = False
            DataGridView1.Columns(22).Visible = False
            DataGridView1.Columns(23).Visible = False
            DataGridView1.Columns(24).Visible = False
            DataGridView1.Columns(25).Visible = False
            DataGridView1.Columns(26).Visible = False
            DataGridView1.Columns(27).Visible = False
            DataGridView1.Columns(28).Visible = False
            DataGridView1.Columns(29).Visible = False
            DataGridView1.Columns(30).Visible = False
            DataGridView1.Columns(31).Visible = False
            DataGridView1.Columns(32).Visible = False
            DataGridView1.Columns(33).Visible = False
            DataGridView1.Columns(34).Visible = False
            DataGridView1.Columns(35).Visible = False
            DataGridView1.Columns(36).Visible = False
            DataGridView1.Columns(37).Visible = False
            DataGridView1.Columns(38).Visible = False
            DataGridView1.Columns(39).Visible = False
            DataGridView1.Columns(40).Visible = False
            DataGridView1.Columns(41).Visible = False
            DataGridView1.Columns(42).Visible = False
            DataGridView1.Columns(43).Visible = False
            DataGridView1.Columns(44).Visible = False
            DataGridView1.Columns(45).Visible = False
            DataGridView1.Columns(46).Visible = False
            DataGridView1.Columns(47).Visible = False
            DataGridView1.Columns(48).Visible = False
            DataGridView1.Columns(49).Visible = False
            DataGridView1.Columns(50).Visible = False
            DataGridView1.Columns(51).Visible = False
            DataGridView1.Columns(52).Visible = False
            DataGridView1.Columns(53).Visible = False
            DataGridView1.Columns(54).Visible = False
            DataGridView1.Columns(55).Visible = False


        ElseIf Sortbox.Text = "Home Barangay" Then
            DataGridView1.Columns(1).Visible = True
            DataGridView1.Columns(2).Visible = True
            DataGridView1.Columns(3).Visible = True

            DataGridView1.Columns(4).Visible = False
            DataGridView1.Columns(5).Visible = False
            DataGridView1.Columns(6).Visible = True
            DataGridView1.Columns(7).Visible = False
            DataGridView1.Columns(8).Visible = False
            DataGridView1.Columns(9).Visible = False
            DataGridView1.Columns(10).Visible = False
            DataGridView1.Columns(11).Visible = False
            DataGridView1.Columns(12).Visible = False
            DataGridView1.Columns(13).Visible = False
            DataGridView1.Columns(14).Visible = False
            DataGridView1.Columns(15).Visible = False
            DataGridView1.Columns(16).Visible = False
            DataGridView1.Columns(17).Visible = False
            DataGridView1.Columns(18).Visible = False
            DataGridView1.Columns(19).Visible = False
            DataGridView1.Columns(20).Visible = False
            DataGridView1.Columns(21).Visible = False
            DataGridView1.Columns(22).Visible = False
            DataGridView1.Columns(23).Visible = False
            DataGridView1.Columns(24).Visible = False
            DataGridView1.Columns(25).Visible = False
            DataGridView1.Columns(26).Visible = False
            DataGridView1.Columns(27).Visible = False
            DataGridView1.Columns(28).Visible = False
            DataGridView1.Columns(29).Visible = False
            DataGridView1.Columns(30).Visible = False
            DataGridView1.Columns(31).Visible = False
            DataGridView1.Columns(32).Visible = False
            DataGridView1.Columns(33).Visible = False
            DataGridView1.Columns(34).Visible = False
            DataGridView1.Columns(35).Visible = False
            DataGridView1.Columns(36).Visible = False
            DataGridView1.Columns(37).Visible = False
            DataGridView1.Columns(38).Visible = False
            DataGridView1.Columns(39).Visible = False
            DataGridView1.Columns(40).Visible = False
            DataGridView1.Columns(41).Visible = False
            DataGridView1.Columns(42).Visible = False
            DataGridView1.Columns(43).Visible = False
            DataGridView1.Columns(44).Visible = False
            DataGridView1.Columns(45).Visible = False
            DataGridView1.Columns(46).Visible = False
            DataGridView1.Columns(47).Visible = False
            DataGridView1.Columns(48).Visible = False
            DataGridView1.Columns(49).Visible = False
            DataGridView1.Columns(50).Visible = False
            DataGridView1.Columns(51).Visible = False
            DataGridView1.Columns(52).Visible = False
            DataGridView1.Columns(53).Visible = False
            DataGridView1.Columns(54).Visible = False
            DataGridView1.Columns(55).Visible = False



        ElseIf Sortbox.Text = "Home Town" Then
            DataGridView1.Columns(1).Visible = True
            DataGridView1.Columns(2).Visible = True
            DataGridView1.Columns(3).Visible = True

            DataGridView1.Columns(4).Visible = False
            DataGridView1.Columns(5).Visible = False
            DataGridView1.Columns(6).Visible = False
            DataGridView1.Columns(7).Visible = True
            DataGridView1.Columns(8).Visible = False
            DataGridView1.Columns(9).Visible = False
            DataGridView1.Columns(10).Visible = False
            DataGridView1.Columns(11).Visible = False
            DataGridView1.Columns(12).Visible = False
            DataGridView1.Columns(13).Visible = False
            DataGridView1.Columns(14).Visible = False
            DataGridView1.Columns(15).Visible = False
            DataGridView1.Columns(16).Visible = False
            DataGridView1.Columns(17).Visible = False
            DataGridView1.Columns(18).Visible = False
            DataGridView1.Columns(19).Visible = False
            DataGridView1.Columns(20).Visible = False
            DataGridView1.Columns(21).Visible = False
            DataGridView1.Columns(22).Visible = False
            DataGridView1.Columns(23).Visible = False
            DataGridView1.Columns(24).Visible = False
            DataGridView1.Columns(25).Visible = False
            DataGridView1.Columns(26).Visible = False
            DataGridView1.Columns(27).Visible = False
            DataGridView1.Columns(28).Visible = False
            DataGridView1.Columns(29).Visible = False
            DataGridView1.Columns(30).Visible = False
            DataGridView1.Columns(31).Visible = False
            DataGridView1.Columns(32).Visible = False
            DataGridView1.Columns(33).Visible = False
            DataGridView1.Columns(34).Visible = False
            DataGridView1.Columns(35).Visible = False
            DataGridView1.Columns(36).Visible = False
            DataGridView1.Columns(37).Visible = False
            DataGridView1.Columns(38).Visible = False
            DataGridView1.Columns(39).Visible = False
            DataGridView1.Columns(40).Visible = False
            DataGridView1.Columns(41).Visible = False
            DataGridView1.Columns(42).Visible = False
            DataGridView1.Columns(43).Visible = False
            DataGridView1.Columns(44).Visible = False
            DataGridView1.Columns(45).Visible = False
            DataGridView1.Columns(46).Visible = False
            DataGridView1.Columns(47).Visible = False
            DataGridView1.Columns(48).Visible = False
            DataGridView1.Columns(49).Visible = False
            DataGridView1.Columns(50).Visible = False
            DataGridView1.Columns(51).Visible = False
            DataGridView1.Columns(52).Visible = False
            DataGridView1.Columns(53).Visible = False
            DataGridView1.Columns(54).Visible = False
            DataGridView1.Columns(55).Visible = False


        ElseIf Sortbox.Text = "Home Province" Then
            DataGridView1.Columns(1).Visible = True
            DataGridView1.Columns(2).Visible = True
            DataGridView1.Columns(3).Visible = True

            DataGridView1.Columns(4).Visible = False
            DataGridView1.Columns(5).Visible = False
            DataGridView1.Columns(6).Visible = False
            DataGridView1.Columns(7).Visible = False
            DataGridView1.Columns(8).Visible = True
            DataGridView1.Columns(9).Visible = False
            DataGridView1.Columns(10).Visible = False
            DataGridView1.Columns(11).Visible = False
            DataGridView1.Columns(12).Visible = False
            DataGridView1.Columns(13).Visible = False
            DataGridView1.Columns(14).Visible = False
            DataGridView1.Columns(15).Visible = False
            DataGridView1.Columns(16).Visible = False
            DataGridView1.Columns(17).Visible = False
            DataGridView1.Columns(18).Visible = False
            DataGridView1.Columns(19).Visible = False
            DataGridView1.Columns(20).Visible = False
            DataGridView1.Columns(21).Visible = False
            DataGridView1.Columns(22).Visible = False
            DataGridView1.Columns(23).Visible = False
            DataGridView1.Columns(24).Visible = False
            DataGridView1.Columns(25).Visible = False
            DataGridView1.Columns(26).Visible = False
            DataGridView1.Columns(27).Visible = False
            DataGridView1.Columns(28).Visible = False
            DataGridView1.Columns(29).Visible = False
            DataGridView1.Columns(30).Visible = False
            DataGridView1.Columns(31).Visible = False
            DataGridView1.Columns(32).Visible = False
            DataGridView1.Columns(33).Visible = False
            DataGridView1.Columns(34).Visible = False
            DataGridView1.Columns(35).Visible = False
            DataGridView1.Columns(36).Visible = False
            DataGridView1.Columns(37).Visible = False
            DataGridView1.Columns(38).Visible = False
            DataGridView1.Columns(39).Visible = False
            DataGridView1.Columns(40).Visible = False
            DataGridView1.Columns(41).Visible = False
            DataGridView1.Columns(42).Visible = False
            DataGridView1.Columns(43).Visible = False
            DataGridView1.Columns(44).Visible = False
            DataGridView1.Columns(45).Visible = False
            DataGridView1.Columns(46).Visible = False
            DataGridView1.Columns(47).Visible = False
            DataGridView1.Columns(48).Visible = False
            DataGridView1.Columns(49).Visible = False
            DataGridView1.Columns(50).Visible = False
            DataGridView1.Columns(51).Visible = False
            DataGridView1.Columns(52).Visible = False
            DataGridView1.Columns(53).Visible = False
            DataGridView1.Columns(54).Visible = False
            DataGridView1.Columns(55).Visible = False



        ElseIf Sortbox.Text = "Home Zip Code" Then
            DataGridView1.Columns(1).Visible = True
            DataGridView1.Columns(2).Visible = True
            DataGridView1.Columns(3).Visible = True

            DataGridView1.Columns(4).Visible = False
            DataGridView1.Columns(5).Visible = False
            DataGridView1.Columns(6).Visible = False
            DataGridView1.Columns(7).Visible = False
            DataGridView1.Columns(8).Visible = False
            DataGridView1.Columns(9).Visible = True
            DataGridView1.Columns(10).Visible = False
            DataGridView1.Columns(11).Visible = False
            DataGridView1.Columns(12).Visible = False
            DataGridView1.Columns(13).Visible = False
            DataGridView1.Columns(14).Visible = False
            DataGridView1.Columns(15).Visible = False
            DataGridView1.Columns(16).Visible = False
            DataGridView1.Columns(17).Visible = False
            DataGridView1.Columns(18).Visible = False
            DataGridView1.Columns(19).Visible = False
            DataGridView1.Columns(20).Visible = False
            DataGridView1.Columns(21).Visible = False
            DataGridView1.Columns(22).Visible = False
            DataGridView1.Columns(23).Visible = False
            DataGridView1.Columns(24).Visible = False
            DataGridView1.Columns(25).Visible = False
            DataGridView1.Columns(26).Visible = False
            DataGridView1.Columns(27).Visible = False
            DataGridView1.Columns(28).Visible = False
            DataGridView1.Columns(29).Visible = False
            DataGridView1.Columns(30).Visible = False
            DataGridView1.Columns(31).Visible = False
            DataGridView1.Columns(32).Visible = False
            DataGridView1.Columns(33).Visible = False
            DataGridView1.Columns(34).Visible = False
            DataGridView1.Columns(35).Visible = False
            DataGridView1.Columns(36).Visible = False
            DataGridView1.Columns(37).Visible = False
            DataGridView1.Columns(38).Visible = False
            DataGridView1.Columns(39).Visible = False
            DataGridView1.Columns(40).Visible = False
            DataGridView1.Columns(41).Visible = False
            DataGridView1.Columns(42).Visible = False
            DataGridView1.Columns(43).Visible = False
            DataGridView1.Columns(44).Visible = False
            DataGridView1.Columns(45).Visible = False
            DataGridView1.Columns(46).Visible = False
            DataGridView1.Columns(47).Visible = False
            DataGridView1.Columns(48).Visible = False
            DataGridView1.Columns(49).Visible = False
            DataGridView1.Columns(50).Visible = False
            DataGridView1.Columns(51).Visible = False
            DataGridView1.Columns(52).Visible = False
            DataGridView1.Columns(53).Visible = False
            DataGridView1.Columns(54).Visible = False
            DataGridView1.Columns(55).Visible = False


        ElseIf Sortbox.Text = "Current Home Number" Then
            DataGridView1.Columns(1).Visible = True
            DataGridView1.Columns(2).Visible = True
            DataGridView1.Columns(3).Visible = True

            DataGridView1.Columns(4).Visible = False
            DataGridView1.Columns(5).Visible = False
            DataGridView1.Columns(6).Visible = False
            DataGridView1.Columns(7).Visible = False
            DataGridView1.Columns(8).Visible = False
            DataGridView1.Columns(9).Visible = False
            DataGridView1.Columns(10).Visible = True
            DataGridView1.Columns(11).Visible = False
            DataGridView1.Columns(12).Visible = False
            DataGridView1.Columns(13).Visible = False
            DataGridView1.Columns(14).Visible = False
            DataGridView1.Columns(15).Visible = False
            DataGridView1.Columns(16).Visible = False
            DataGridView1.Columns(17).Visible = False
            DataGridView1.Columns(18).Visible = False
            DataGridView1.Columns(19).Visible = False
            DataGridView1.Columns(20).Visible = False
            DataGridView1.Columns(21).Visible = False
            DataGridView1.Columns(22).Visible = False
            DataGridView1.Columns(23).Visible = False
            DataGridView1.Columns(24).Visible = False
            DataGridView1.Columns(25).Visible = False
            DataGridView1.Columns(26).Visible = False
            DataGridView1.Columns(27).Visible = False
            DataGridView1.Columns(28).Visible = False
            DataGridView1.Columns(29).Visible = False
            DataGridView1.Columns(30).Visible = False
            DataGridView1.Columns(31).Visible = False
            DataGridView1.Columns(32).Visible = False
            DataGridView1.Columns(33).Visible = False
            DataGridView1.Columns(34).Visible = False
            DataGridView1.Columns(35).Visible = False
            DataGridView1.Columns(36).Visible = False
            DataGridView1.Columns(37).Visible = False
            DataGridView1.Columns(38).Visible = False
            DataGridView1.Columns(39).Visible = False
            DataGridView1.Columns(40).Visible = False
            DataGridView1.Columns(41).Visible = False
            DataGridView1.Columns(42).Visible = False
            DataGridView1.Columns(43).Visible = False
            DataGridView1.Columns(44).Visible = False
            DataGridView1.Columns(45).Visible = False
            DataGridView1.Columns(46).Visible = False
            DataGridView1.Columns(47).Visible = False
            DataGridView1.Columns(48).Visible = False
            DataGridView1.Columns(49).Visible = False
            DataGridView1.Columns(50).Visible = False
            DataGridView1.Columns(51).Visible = False
            DataGridView1.Columns(52).Visible = False
            DataGridView1.Columns(53).Visible = False
            DataGridView1.Columns(54).Visible = False
            DataGridView1.Columns(55).Visible = False


        ElseIf Sortbox.Text = "Current Street" Then
            DataGridView1.Columns(1).Visible = True
            DataGridView1.Columns(2).Visible = True
            DataGridView1.Columns(3).Visible = True

            DataGridView1.Columns(4).Visible = False
            DataGridView1.Columns(5).Visible = False
            DataGridView1.Columns(6).Visible = False
            DataGridView1.Columns(7).Visible = False
            DataGridView1.Columns(8).Visible = False
            DataGridView1.Columns(9).Visible = False
            DataGridView1.Columns(10).Visible = False
            DataGridView1.Columns(11).Visible = True
            DataGridView1.Columns(12).Visible = False
            DataGridView1.Columns(13).Visible = False
            DataGridView1.Columns(14).Visible = False
            DataGridView1.Columns(15).Visible = False
            DataGridView1.Columns(16).Visible = False
            DataGridView1.Columns(17).Visible = False
            DataGridView1.Columns(18).Visible = False
            DataGridView1.Columns(19).Visible = False
            DataGridView1.Columns(20).Visible = False
            DataGridView1.Columns(21).Visible = False
            DataGridView1.Columns(22).Visible = False
            DataGridView1.Columns(23).Visible = False
            DataGridView1.Columns(24).Visible = False
            DataGridView1.Columns(25).Visible = False
            DataGridView1.Columns(26).Visible = False
            DataGridView1.Columns(27).Visible = False
            DataGridView1.Columns(28).Visible = False
            DataGridView1.Columns(29).Visible = False
            DataGridView1.Columns(30).Visible = False
            DataGridView1.Columns(31).Visible = False
            DataGridView1.Columns(32).Visible = False
            DataGridView1.Columns(33).Visible = False
            DataGridView1.Columns(34).Visible = False
            DataGridView1.Columns(35).Visible = False
            DataGridView1.Columns(36).Visible = False
            DataGridView1.Columns(37).Visible = False
            DataGridView1.Columns(38).Visible = False
            DataGridView1.Columns(39).Visible = False
            DataGridView1.Columns(40).Visible = False
            DataGridView1.Columns(41).Visible = False
            DataGridView1.Columns(42).Visible = False
            DataGridView1.Columns(43).Visible = False
            DataGridView1.Columns(44).Visible = False
            DataGridView1.Columns(45).Visible = False
            DataGridView1.Columns(46).Visible = False
            DataGridView1.Columns(47).Visible = False
            DataGridView1.Columns(48).Visible = False
            DataGridView1.Columns(49).Visible = False
            DataGridView1.Columns(50).Visible = False
            DataGridView1.Columns(51).Visible = False
            DataGridView1.Columns(52).Visible = False
            DataGridView1.Columns(53).Visible = False
            DataGridView1.Columns(54).Visible = False
            DataGridView1.Columns(55).Visible = False


        ElseIf Sortbox.Text = "Current Barangay" Then
            DataGridView1.Columns(1).Visible = True
            DataGridView1.Columns(2).Visible = True
            DataGridView1.Columns(3).Visible = True

            DataGridView1.Columns(4).Visible = False
            DataGridView1.Columns(5).Visible = False
            DataGridView1.Columns(6).Visible = False
            DataGridView1.Columns(7).Visible = False
            DataGridView1.Columns(8).Visible = False
            DataGridView1.Columns(9).Visible = False
            DataGridView1.Columns(10).Visible = False
            DataGridView1.Columns(11).Visible = False
            DataGridView1.Columns(12).Visible = True
            DataGridView1.Columns(13).Visible = False
            DataGridView1.Columns(14).Visible = False
            DataGridView1.Columns(15).Visible = False
            DataGridView1.Columns(16).Visible = False
            DataGridView1.Columns(17).Visible = False
            DataGridView1.Columns(18).Visible = False
            DataGridView1.Columns(19).Visible = False
            DataGridView1.Columns(20).Visible = False
            DataGridView1.Columns(21).Visible = False
            DataGridView1.Columns(22).Visible = False
            DataGridView1.Columns(23).Visible = False
            DataGridView1.Columns(24).Visible = False
            DataGridView1.Columns(25).Visible = False
            DataGridView1.Columns(26).Visible = False
            DataGridView1.Columns(27).Visible = False
            DataGridView1.Columns(28).Visible = False
            DataGridView1.Columns(29).Visible = False
            DataGridView1.Columns(30).Visible = False
            DataGridView1.Columns(31).Visible = False
            DataGridView1.Columns(32).Visible = False
            DataGridView1.Columns(33).Visible = False
            DataGridView1.Columns(34).Visible = False
            DataGridView1.Columns(35).Visible = False
            DataGridView1.Columns(36).Visible = False
            DataGridView1.Columns(37).Visible = False
            DataGridView1.Columns(38).Visible = False
            DataGridView1.Columns(39).Visible = False
            DataGridView1.Columns(40).Visible = False
            DataGridView1.Columns(41).Visible = False
            DataGridView1.Columns(42).Visible = False
            DataGridView1.Columns(43).Visible = False
            DataGridView1.Columns(44).Visible = False
            DataGridView1.Columns(45).Visible = False
            DataGridView1.Columns(46).Visible = False
            DataGridView1.Columns(47).Visible = False
            DataGridView1.Columns(48).Visible = False
            DataGridView1.Columns(49).Visible = False
            DataGridView1.Columns(50).Visible = False
            DataGridView1.Columns(51).Visible = False
            DataGridView1.Columns(52).Visible = False
            DataGridView1.Columns(53).Visible = False
            DataGridView1.Columns(54).Visible = False
            DataGridView1.Columns(55).Visible = False

        ElseIf Sortbox.Text = "Current Town" Then
            DataGridView1.Columns(1).Visible = True
            DataGridView1.Columns(2).Visible = True
            DataGridView1.Columns(3).Visible = True

            DataGridView1.Columns(4).Visible = False
            DataGridView1.Columns(5).Visible = False
            DataGridView1.Columns(6).Visible = False
            DataGridView1.Columns(7).Visible = False
            DataGridView1.Columns(8).Visible = False
            DataGridView1.Columns(9).Visible = False
            DataGridView1.Columns(10).Visible = False
            DataGridView1.Columns(11).Visible = False
            DataGridView1.Columns(12).Visible = False
            DataGridView1.Columns(13).Visible = True
            DataGridView1.Columns(14).Visible = False
            DataGridView1.Columns(15).Visible = False
            DataGridView1.Columns(16).Visible = False
            DataGridView1.Columns(17).Visible = False
            DataGridView1.Columns(18).Visible = False
            DataGridView1.Columns(19).Visible = False
            DataGridView1.Columns(20).Visible = False
            DataGridView1.Columns(21).Visible = False
            DataGridView1.Columns(22).Visible = False
            DataGridView1.Columns(23).Visible = False
            DataGridView1.Columns(24).Visible = False
            DataGridView1.Columns(25).Visible = False
            DataGridView1.Columns(26).Visible = False
            DataGridView1.Columns(27).Visible = False
            DataGridView1.Columns(28).Visible = False
            DataGridView1.Columns(29).Visible = False
            DataGridView1.Columns(30).Visible = False
            DataGridView1.Columns(31).Visible = False
            DataGridView1.Columns(32).Visible = False
            DataGridView1.Columns(33).Visible = False
            DataGridView1.Columns(34).Visible = False
            DataGridView1.Columns(35).Visible = False
            DataGridView1.Columns(36).Visible = False
            DataGridView1.Columns(37).Visible = False
            DataGridView1.Columns(38).Visible = False
            DataGridView1.Columns(39).Visible = False
            DataGridView1.Columns(40).Visible = False
            DataGridView1.Columns(41).Visible = False
            DataGridView1.Columns(42).Visible = False
            DataGridView1.Columns(43).Visible = False
            DataGridView1.Columns(44).Visible = False
            DataGridView1.Columns(45).Visible = False
            DataGridView1.Columns(46).Visible = False
            DataGridView1.Columns(47).Visible = False
            DataGridView1.Columns(48).Visible = False
            DataGridView1.Columns(49).Visible = False
            DataGridView1.Columns(50).Visible = False
            DataGridView1.Columns(51).Visible = False
            DataGridView1.Columns(52).Visible = False
            DataGridView1.Columns(53).Visible = False
            DataGridView1.Columns(54).Visible = False
            DataGridView1.Columns(55).Visible = False


        ElseIf Sortbox.Text = "Current Province" Then
            DataGridView1.Columns(1).Visible = True
            DataGridView1.Columns(2).Visible = True
            DataGridView1.Columns(3).Visible = True

            DataGridView1.Columns(4).Visible = False
            DataGridView1.Columns(5).Visible = False
            DataGridView1.Columns(6).Visible = False
            DataGridView1.Columns(7).Visible = False
            DataGridView1.Columns(8).Visible = False
            DataGridView1.Columns(9).Visible = False
            DataGridView1.Columns(10).Visible = False
            DataGridView1.Columns(11).Visible = False
            DataGridView1.Columns(12).Visible = False
            DataGridView1.Columns(13).Visible = False
            DataGridView1.Columns(14).Visible = True
            DataGridView1.Columns(15).Visible = False
            DataGridView1.Columns(16).Visible = False
            DataGridView1.Columns(17).Visible = False
            DataGridView1.Columns(18).Visible = False
            DataGridView1.Columns(19).Visible = False
            DataGridView1.Columns(20).Visible = False
            DataGridView1.Columns(21).Visible = False
            DataGridView1.Columns(22).Visible = False
            DataGridView1.Columns(23).Visible = False
            DataGridView1.Columns(24).Visible = False
            DataGridView1.Columns(25).Visible = False
            DataGridView1.Columns(26).Visible = False
            DataGridView1.Columns(27).Visible = False
            DataGridView1.Columns(28).Visible = False
            DataGridView1.Columns(29).Visible = False
            DataGridView1.Columns(30).Visible = False
            DataGridView1.Columns(31).Visible = False
            DataGridView1.Columns(32).Visible = False
            DataGridView1.Columns(33).Visible = False
            DataGridView1.Columns(34).Visible = False
            DataGridView1.Columns(35).Visible = False
            DataGridView1.Columns(36).Visible = False
            DataGridView1.Columns(37).Visible = False
            DataGridView1.Columns(38).Visible = False
            DataGridView1.Columns(39).Visible = False
            DataGridView1.Columns(40).Visible = False
            DataGridView1.Columns(41).Visible = False
            DataGridView1.Columns(42).Visible = False
            DataGridView1.Columns(43).Visible = False
            DataGridView1.Columns(44).Visible = False
            DataGridView1.Columns(45).Visible = False
            DataGridView1.Columns(46).Visible = False
            DataGridView1.Columns(47).Visible = False
            DataGridView1.Columns(48).Visible = False
            DataGridView1.Columns(49).Visible = False
            DataGridView1.Columns(50).Visible = False
            DataGridView1.Columns(51).Visible = False
            DataGridView1.Columns(52).Visible = False
            DataGridView1.Columns(53).Visible = False
            DataGridView1.Columns(54).Visible = False
            DataGridView1.Columns(55).Visible = False


        ElseIf Sortbox.Text = "Current Zip Code" Then
            DataGridView1.Columns(1).Visible = True
            DataGridView1.Columns(2).Visible = True
            DataGridView1.Columns(3).Visible = True

            DataGridView1.Columns(4).Visible = False
            DataGridView1.Columns(5).Visible = False
            DataGridView1.Columns(6).Visible = False
            DataGridView1.Columns(7).Visible = False
            DataGridView1.Columns(8).Visible = False
            DataGridView1.Columns(9).Visible = False
            DataGridView1.Columns(10).Visible = False
            DataGridView1.Columns(11).Visible = False
            DataGridView1.Columns(12).Visible = False
            DataGridView1.Columns(13).Visible = False
            DataGridView1.Columns(14).Visible = False
            DataGridView1.Columns(15).Visible = True
            DataGridView1.Columns(16).Visible = False
            DataGridView1.Columns(17).Visible = False
            DataGridView1.Columns(18).Visible = False
            DataGridView1.Columns(19).Visible = False
            DataGridView1.Columns(20).Visible = False
            DataGridView1.Columns(21).Visible = False
            DataGridView1.Columns(22).Visible = False
            DataGridView1.Columns(23).Visible = False
            DataGridView1.Columns(24).Visible = False
            DataGridView1.Columns(25).Visible = False
            DataGridView1.Columns(26).Visible = False
            DataGridView1.Columns(27).Visible = False
            DataGridView1.Columns(28).Visible = False
            DataGridView1.Columns(29).Visible = False
            DataGridView1.Columns(30).Visible = False
            DataGridView1.Columns(31).Visible = False
            DataGridView1.Columns(32).Visible = False
            DataGridView1.Columns(33).Visible = False
            DataGridView1.Columns(34).Visible = False
            DataGridView1.Columns(35).Visible = False
            DataGridView1.Columns(36).Visible = False
            DataGridView1.Columns(37).Visible = False
            DataGridView1.Columns(38).Visible = False
            DataGridView1.Columns(39).Visible = False
            DataGridView1.Columns(40).Visible = False
            DataGridView1.Columns(41).Visible = False
            DataGridView1.Columns(42).Visible = False
            DataGridView1.Columns(43).Visible = False
            DataGridView1.Columns(44).Visible = False
            DataGridView1.Columns(45).Visible = False
            DataGridView1.Columns(46).Visible = False
            DataGridView1.Columns(47).Visible = False
            DataGridView1.Columns(48).Visible = False
            DataGridView1.Columns(49).Visible = False
            DataGridView1.Columns(50).Visible = False
            DataGridView1.Columns(51).Visible = False
            DataGridView1.Columns(52).Visible = False
            DataGridView1.Columns(53).Visible = False
            DataGridView1.Columns(54).Visible = False
            DataGridView1.Columns(55).Visible = False


        ElseIf Sortbox.Text = "Sex" Then
            DataGridView1.Columns(1).Visible = True
            DataGridView1.Columns(2).Visible = True
            DataGridView1.Columns(3).Visible = True

            DataGridView1.Columns(4).Visible = False
            DataGridView1.Columns(5).Visible = False
            DataGridView1.Columns(6).Visible = False
            DataGridView1.Columns(7).Visible = False
            DataGridView1.Columns(8).Visible = False
            DataGridView1.Columns(9).Visible = False
            DataGridView1.Columns(10).Visible = False
            DataGridView1.Columns(11).Visible = False
            DataGridView1.Columns(12).Visible = False
            DataGridView1.Columns(13).Visible = False
            DataGridView1.Columns(14).Visible = False
            DataGridView1.Columns(15).Visible = False
            DataGridView1.Columns(16).Visible = True
            DataGridView1.Columns(17).Visible = False
            DataGridView1.Columns(18).Visible = False
            DataGridView1.Columns(19).Visible = False
            DataGridView1.Columns(20).Visible = False
            DataGridView1.Columns(21).Visible = False
            DataGridView1.Columns(22).Visible = False
            DataGridView1.Columns(23).Visible = False
            DataGridView1.Columns(24).Visible = False
            DataGridView1.Columns(25).Visible = False
            DataGridView1.Columns(26).Visible = False
            DataGridView1.Columns(27).Visible = False
            DataGridView1.Columns(28).Visible = False
            DataGridView1.Columns(29).Visible = False
            DataGridView1.Columns(30).Visible = False
            DataGridView1.Columns(31).Visible = False
            DataGridView1.Columns(32).Visible = False
            DataGridView1.Columns(33).Visible = False
            DataGridView1.Columns(34).Visible = False
            DataGridView1.Columns(35).Visible = False
            DataGridView1.Columns(36).Visible = False
            DataGridView1.Columns(37).Visible = False
            DataGridView1.Columns(38).Visible = False
            DataGridView1.Columns(39).Visible = False
            DataGridView1.Columns(40).Visible = False
            DataGridView1.Columns(41).Visible = False
            DataGridView1.Columns(42).Visible = False
            DataGridView1.Columns(43).Visible = False
            DataGridView1.Columns(44).Visible = False
            DataGridView1.Columns(45).Visible = False
            DataGridView1.Columns(46).Visible = False
            DataGridView1.Columns(47).Visible = False
            DataGridView1.Columns(48).Visible = False
            DataGridView1.Columns(49).Visible = False
            DataGridView1.Columns(50).Visible = False
            DataGridView1.Columns(51).Visible = False
            DataGridView1.Columns(52).Visible = False
            DataGridView1.Columns(53).Visible = False
            DataGridView1.Columns(54).Visible = False
            DataGridView1.Columns(55).Visible = False

        ElseIf Sortbox.Text = "Age" Then
            DataGridView1.Columns(1).Visible = True
            DataGridView1.Columns(2).Visible = True
            DataGridView1.Columns(3).Visible = True

            DataGridView1.Columns(4).Visible = False
            DataGridView1.Columns(5).Visible = False
            DataGridView1.Columns(6).Visible = False
            DataGridView1.Columns(7).Visible = False
            DataGridView1.Columns(8).Visible = False
            DataGridView1.Columns(9).Visible = False
            DataGridView1.Columns(10).Visible = False
            DataGridView1.Columns(11).Visible = False
            DataGridView1.Columns(12).Visible = False
            DataGridView1.Columns(13).Visible = False
            DataGridView1.Columns(14).Visible = False
            DataGridView1.Columns(15).Visible = False
            DataGridView1.Columns(16).Visible = False
            DataGridView1.Columns(17).Visible = True
            DataGridView1.Columns(18).Visible = False
            DataGridView1.Columns(19).Visible = False
            DataGridView1.Columns(20).Visible = False
            DataGridView1.Columns(21).Visible = False
            DataGridView1.Columns(22).Visible = False
            DataGridView1.Columns(23).Visible = False
            DataGridView1.Columns(24).Visible = False
            DataGridView1.Columns(25).Visible = False
            DataGridView1.Columns(26).Visible = False
            DataGridView1.Columns(27).Visible = False
            DataGridView1.Columns(28).Visible = False
            DataGridView1.Columns(29).Visible = False
            DataGridView1.Columns(30).Visible = False
            DataGridView1.Columns(31).Visible = False
            DataGridView1.Columns(32).Visible = False
            DataGridView1.Columns(33).Visible = False
            DataGridView1.Columns(34).Visible = False
            DataGridView1.Columns(35).Visible = False
            DataGridView1.Columns(36).Visible = False
            DataGridView1.Columns(37).Visible = False
            DataGridView1.Columns(38).Visible = False
            DataGridView1.Columns(39).Visible = False
            DataGridView1.Columns(40).Visible = False
            DataGridView1.Columns(41).Visible = False
            DataGridView1.Columns(42).Visible = False
            DataGridView1.Columns(43).Visible = False
            DataGridView1.Columns(44).Visible = False
            DataGridView1.Columns(45).Visible = False
            DataGridView1.Columns(46).Visible = False
            DataGridView1.Columns(47).Visible = False
            DataGridView1.Columns(48).Visible = False
            DataGridView1.Columns(49).Visible = False
            DataGridView1.Columns(50).Visible = False
            DataGridView1.Columns(51).Visible = False
            DataGridView1.Columns(52).Visible = False
            DataGridView1.Columns(53).Visible = False
            DataGridView1.Columns(54).Visible = False
            DataGridView1.Columns(55).Visible = False

        ElseIf Sortbox.Text = "Civil Status" Then
            DataGridView1.Columns(1).Visible = True
            DataGridView1.Columns(2).Visible = True
            DataGridView1.Columns(3).Visible = True

            DataGridView1.Columns(4).Visible = False
            DataGridView1.Columns(5).Visible = False
            DataGridView1.Columns(6).Visible = False
            DataGridView1.Columns(7).Visible = False
            DataGridView1.Columns(8).Visible = False
            DataGridView1.Columns(9).Visible = False
            DataGridView1.Columns(10).Visible = False
            DataGridView1.Columns(11).Visible = False
            DataGridView1.Columns(12).Visible = False
            DataGridView1.Columns(13).Visible = False
            DataGridView1.Columns(14).Visible = False
            DataGridView1.Columns(15).Visible = False
            DataGridView1.Columns(16).Visible = False
            DataGridView1.Columns(17).Visible = False
            DataGridView1.Columns(18).Visible = True
            DataGridView1.Columns(19).Visible = False
            DataGridView1.Columns(20).Visible = False
            DataGridView1.Columns(21).Visible = False
            DataGridView1.Columns(22).Visible = False
            DataGridView1.Columns(23).Visible = False
            DataGridView1.Columns(24).Visible = False
            DataGridView1.Columns(25).Visible = False
            DataGridView1.Columns(26).Visible = False
            DataGridView1.Columns(27).Visible = False
            DataGridView1.Columns(28).Visible = False
            DataGridView1.Columns(29).Visible = False
            DataGridView1.Columns(30).Visible = False
            DataGridView1.Columns(31).Visible = False
            DataGridView1.Columns(32).Visible = False
            DataGridView1.Columns(33).Visible = False
            DataGridView1.Columns(34).Visible = False
            DataGridView1.Columns(35).Visible = False
            DataGridView1.Columns(36).Visible = False
            DataGridView1.Columns(37).Visible = False
            DataGridView1.Columns(38).Visible = False
            DataGridView1.Columns(39).Visible = False
            DataGridView1.Columns(40).Visible = False
            DataGridView1.Columns(41).Visible = False
            DataGridView1.Columns(42).Visible = False
            DataGridView1.Columns(43).Visible = False
            DataGridView1.Columns(44).Visible = False
            DataGridView1.Columns(45).Visible = False
            DataGridView1.Columns(46).Visible = False
            DataGridView1.Columns(47).Visible = False
            DataGridView1.Columns(48).Visible = False
            DataGridView1.Columns(49).Visible = False
            DataGridView1.Columns(50).Visible = False
            DataGridView1.Columns(51).Visible = False
            DataGridView1.Columns(52).Visible = False
            DataGridView1.Columns(53).Visible = False
            DataGridView1.Columns(54).Visible = False
            DataGridView1.Columns(55).Visible = False


        ElseIf Sortbox.Text = "Birthday" Then
            DataGridView1.Columns(1).Visible = True
            DataGridView1.Columns(2).Visible = True
            DataGridView1.Columns(3).Visible = True

            DataGridView1.Columns(4).Visible = False
            DataGridView1.Columns(5).Visible = False
            DataGridView1.Columns(6).Visible = False
            DataGridView1.Columns(7).Visible = False
            DataGridView1.Columns(8).Visible = False
            DataGridView1.Columns(9).Visible = False
            DataGridView1.Columns(10).Visible = False
            DataGridView1.Columns(11).Visible = False
            DataGridView1.Columns(12).Visible = False
            DataGridView1.Columns(13).Visible = False
            DataGridView1.Columns(14).Visible = False
            DataGridView1.Columns(15).Visible = False
            DataGridView1.Columns(16).Visible = False
            DataGridView1.Columns(17).Visible = False
            DataGridView1.Columns(18).Visible = False
            DataGridView1.Columns(19).Visible = True
            DataGridView1.Columns(20).Visible = False
            DataGridView1.Columns(21).Visible = False
            DataGridView1.Columns(22).Visible = False
            DataGridView1.Columns(23).Visible = False
            DataGridView1.Columns(24).Visible = False
            DataGridView1.Columns(25).Visible = False
            DataGridView1.Columns(26).Visible = False
            DataGridView1.Columns(27).Visible = False
            DataGridView1.Columns(28).Visible = False
            DataGridView1.Columns(29).Visible = False
            DataGridView1.Columns(30).Visible = False
            DataGridView1.Columns(31).Visible = False
            DataGridView1.Columns(32).Visible = False
            DataGridView1.Columns(33).Visible = False
            DataGridView1.Columns(34).Visible = False
            DataGridView1.Columns(35).Visible = False
            DataGridView1.Columns(36).Visible = False
            DataGridView1.Columns(37).Visible = False
            DataGridView1.Columns(38).Visible = False
            DataGridView1.Columns(39).Visible = False
            DataGridView1.Columns(40).Visible = False
            DataGridView1.Columns(41).Visible = False
            DataGridView1.Columns(42).Visible = False
            DataGridView1.Columns(43).Visible = False
            DataGridView1.Columns(44).Visible = False
            DataGridView1.Columns(45).Visible = False
            DataGridView1.Columns(46).Visible = False
            DataGridView1.Columns(47).Visible = False
            DataGridView1.Columns(48).Visible = False
            DataGridView1.Columns(49).Visible = False
            DataGridView1.Columns(50).Visible = False
            DataGridView1.Columns(51).Visible = False
            DataGridView1.Columns(52).Visible = False
            DataGridView1.Columns(53).Visible = False
            DataGridView1.Columns(54).Visible = False
            DataGridView1.Columns(55).Visible = False


        ElseIf Sortbox.Text = "Email" Then
            DataGridView1.Columns(1).Visible = True
            DataGridView1.Columns(2).Visible = True
            DataGridView1.Columns(3).Visible = True

            DataGridView1.Columns(4).Visible = False
            DataGridView1.Columns(5).Visible = False
            DataGridView1.Columns(6).Visible = False
            DataGridView1.Columns(7).Visible = False
            DataGridView1.Columns(8).Visible = False
            DataGridView1.Columns(9).Visible = False
            DataGridView1.Columns(10).Visible = False
            DataGridView1.Columns(11).Visible = False
            DataGridView1.Columns(12).Visible = False
            DataGridView1.Columns(13).Visible = False
            DataGridView1.Columns(14).Visible = False
            DataGridView1.Columns(15).Visible = False
            DataGridView1.Columns(16).Visible = False
            DataGridView1.Columns(17).Visible = False
            DataGridView1.Columns(18).Visible = False
            DataGridView1.Columns(19).Visible = False
            DataGridView1.Columns(20).Visible = True
            DataGridView1.Columns(21).Visible = False
            DataGridView1.Columns(22).Visible = False
            DataGridView1.Columns(23).Visible = False
            DataGridView1.Columns(24).Visible = False
            DataGridView1.Columns(25).Visible = False
            DataGridView1.Columns(26).Visible = False
            DataGridView1.Columns(27).Visible = False
            DataGridView1.Columns(28).Visible = False
            DataGridView1.Columns(29).Visible = False
            DataGridView1.Columns(30).Visible = False
            DataGridView1.Columns(31).Visible = False
            DataGridView1.Columns(32).Visible = False
            DataGridView1.Columns(33).Visible = False
            DataGridView1.Columns(34).Visible = False
            DataGridView1.Columns(35).Visible = False
            DataGridView1.Columns(36).Visible = False
            DataGridView1.Columns(37).Visible = False
            DataGridView1.Columns(38).Visible = False
            DataGridView1.Columns(39).Visible = False
            DataGridView1.Columns(40).Visible = False
            DataGridView1.Columns(41).Visible = False
            DataGridView1.Columns(42).Visible = False
            DataGridView1.Columns(43).Visible = False
            DataGridView1.Columns(44).Visible = False
            DataGridView1.Columns(45).Visible = False
            DataGridView1.Columns(46).Visible = False
            DataGridView1.Columns(47).Visible = False
            DataGridView1.Columns(48).Visible = False
            DataGridView1.Columns(49).Visible = False
            DataGridView1.Columns(50).Visible = False
            DataGridView1.Columns(51).Visible = False
            DataGridView1.Columns(52).Visible = False
            DataGridView1.Columns(53).Visible = False
            DataGridView1.Columns(54).Visible = False
            DataGridView1.Columns(55).Visible = False



        ElseIf Sortbox.Text = "Contact Number" Then
            DataGridView1.Columns(1).Visible = True
            DataGridView1.Columns(2).Visible = True
            DataGridView1.Columns(3).Visible = True

            DataGridView1.Columns(4).Visible = False
            DataGridView1.Columns(5).Visible = False
            DataGridView1.Columns(6).Visible = False
            DataGridView1.Columns(7).Visible = False
            DataGridView1.Columns(8).Visible = False
            DataGridView1.Columns(9).Visible = False
            DataGridView1.Columns(10).Visible = False
            DataGridView1.Columns(11).Visible = False
            DataGridView1.Columns(12).Visible = False
            DataGridView1.Columns(13).Visible = False
            DataGridView1.Columns(14).Visible = False
            DataGridView1.Columns(15).Visible = False
            DataGridView1.Columns(16).Visible = False
            DataGridView1.Columns(17).Visible = False
            DataGridView1.Columns(18).Visible = False
            DataGridView1.Columns(19).Visible = False
            DataGridView1.Columns(20).Visible = False
            DataGridView1.Columns(21).Visible = True
            DataGridView1.Columns(22).Visible = False
            DataGridView1.Columns(23).Visible = False
            DataGridView1.Columns(24).Visible = False
            DataGridView1.Columns(25).Visible = False
            DataGridView1.Columns(26).Visible = False
            DataGridView1.Columns(27).Visible = False
            DataGridView1.Columns(28).Visible = False
            DataGridView1.Columns(29).Visible = False
            DataGridView1.Columns(30).Visible = False
            DataGridView1.Columns(31).Visible = False
            DataGridView1.Columns(32).Visible = False
            DataGridView1.Columns(33).Visible = False
            DataGridView1.Columns(34).Visible = False
            DataGridView1.Columns(35).Visible = False
            DataGridView1.Columns(36).Visible = False
            DataGridView1.Columns(37).Visible = False
            DataGridView1.Columns(38).Visible = False
            DataGridView1.Columns(39).Visible = False
            DataGridView1.Columns(40).Visible = False
            DataGridView1.Columns(41).Visible = False
            DataGridView1.Columns(42).Visible = False
            DataGridView1.Columns(43).Visible = False
            DataGridView1.Columns(44).Visible = False
            DataGridView1.Columns(45).Visible = False
            DataGridView1.Columns(46).Visible = False
            DataGridView1.Columns(47).Visible = False
            DataGridView1.Columns(48).Visible = False
            DataGridView1.Columns(49).Visible = False
            DataGridView1.Columns(50).Visible = False
            DataGridView1.Columns(51).Visible = False
            DataGridView1.Columns(52).Visible = False
            DataGridView1.Columns(53).Visible = False
            DataGridView1.Columns(54).Visible = False
            DataGridView1.Columns(55).Visible = False





        ElseIf Sortbox.Text = "Position" Then
            DataGridView1.Columns(1).Visible = True
            DataGridView1.Columns(2).Visible = True
            DataGridView1.Columns(3).Visible = True

            DataGridView1.Columns(4).Visible = False
            DataGridView1.Columns(5).Visible = False
            DataGridView1.Columns(6).Visible = False
            DataGridView1.Columns(7).Visible = False
            DataGridView1.Columns(8).Visible = False
            DataGridView1.Columns(9).Visible = False
            DataGridView1.Columns(10).Visible = False
            DataGridView1.Columns(11).Visible = False
            DataGridView1.Columns(12).Visible = False
            DataGridView1.Columns(13).Visible = False
            DataGridView1.Columns(14).Visible = False
            DataGridView1.Columns(15).Visible = False
            DataGridView1.Columns(16).Visible = False
            DataGridView1.Columns(17).Visible = False
            DataGridView1.Columns(18).Visible = False
            DataGridView1.Columns(19).Visible = False
            DataGridView1.Columns(20).Visible = False
            DataGridView1.Columns(21).Visible = False
            DataGridView1.Columns(22).Visible = True
            DataGridView1.Columns(23).Visible = False
            DataGridView1.Columns(24).Visible = False
            DataGridView1.Columns(25).Visible = False
            DataGridView1.Columns(26).Visible = False
            DataGridView1.Columns(27).Visible = False
            DataGridView1.Columns(28).Visible = False
            DataGridView1.Columns(29).Visible = False
            DataGridView1.Columns(30).Visible = False
            DataGridView1.Columns(31).Visible = False
            DataGridView1.Columns(32).Visible = False
            DataGridView1.Columns(33).Visible = False
            DataGridView1.Columns(34).Visible = False
            DataGridView1.Columns(35).Visible = False
            DataGridView1.Columns(36).Visible = False
            DataGridView1.Columns(37).Visible = False
            DataGridView1.Columns(38).Visible = False
            DataGridView1.Columns(39).Visible = False
            DataGridView1.Columns(40).Visible = False
            DataGridView1.Columns(41).Visible = False
            DataGridView1.Columns(42).Visible = False
            DataGridView1.Columns(43).Visible = False
            DataGridView1.Columns(44).Visible = False
            DataGridView1.Columns(45).Visible = False
            DataGridView1.Columns(46).Visible = False
            DataGridView1.Columns(47).Visible = False
            DataGridView1.Columns(48).Visible = False
            DataGridView1.Columns(49).Visible = False
            DataGridView1.Columns(50).Visible = False
            DataGridView1.Columns(51).Visible = False
            DataGridView1.Columns(52).Visible = False
            DataGridView1.Columns(53).Visible = False
            DataGridView1.Columns(54).Visible = False
            DataGridView1.Columns(55).Visible = False



        ElseIf Sortbox.Text = "Department" Then
            DataGridView1.Columns(1).Visible = True
            DataGridView1.Columns(2).Visible = True
            DataGridView1.Columns(3).Visible = True

            DataGridView1.Columns(4).Visible = False
            DataGridView1.Columns(5).Visible = False
            DataGridView1.Columns(6).Visible = False
            DataGridView1.Columns(7).Visible = False
            DataGridView1.Columns(8).Visible = False
            DataGridView1.Columns(9).Visible = False
            DataGridView1.Columns(10).Visible = False
            DataGridView1.Columns(11).Visible = False
            DataGridView1.Columns(12).Visible = False
            DataGridView1.Columns(13).Visible = False
            DataGridView1.Columns(14).Visible = False
            DataGridView1.Columns(15).Visible = False
            DataGridView1.Columns(16).Visible = False
            DataGridView1.Columns(17).Visible = False
            DataGridView1.Columns(18).Visible = False
            DataGridView1.Columns(19).Visible = False
            DataGridView1.Columns(20).Visible = False
            DataGridView1.Columns(21).Visible = False
            DataGridView1.Columns(22).Visible = False
            DataGridView1.Columns(23).Visible = True
            DataGridView1.Columns(24).Visible = False
            DataGridView1.Columns(25).Visible = False
            DataGridView1.Columns(26).Visible = False
            DataGridView1.Columns(27).Visible = False
            DataGridView1.Columns(28).Visible = False
            DataGridView1.Columns(29).Visible = False
            DataGridView1.Columns(30).Visible = False
            DataGridView1.Columns(31).Visible = False
            DataGridView1.Columns(32).Visible = False
            DataGridView1.Columns(33).Visible = False
            DataGridView1.Columns(34).Visible = False
            DataGridView1.Columns(35).Visible = False
            DataGridView1.Columns(36).Visible = False
            DataGridView1.Columns(37).Visible = False
            DataGridView1.Columns(38).Visible = False
            DataGridView1.Columns(39).Visible = False
            DataGridView1.Columns(40).Visible = False
            DataGridView1.Columns(41).Visible = False
            DataGridView1.Columns(42).Visible = False
            DataGridView1.Columns(43).Visible = False
            DataGridView1.Columns(44).Visible = False
            DataGridView1.Columns(45).Visible = False
            DataGridView1.Columns(46).Visible = False
            DataGridView1.Columns(47).Visible = False
            DataGridView1.Columns(48).Visible = False
            DataGridView1.Columns(49).Visible = False
            DataGridView1.Columns(50).Visible = False
            DataGridView1.Columns(51).Visible = False
            DataGridView1.Columns(52).Visible = False
            DataGridView1.Columns(53).Visible = False
            DataGridView1.Columns(54).Visible = False
            DataGridView1.Columns(55).Visible = False




        ElseIf Sortbox.Text = "Division" Then
            DataGridView1.Columns(1).Visible = True
            DataGridView1.Columns(2).Visible = True
            DataGridView1.Columns(3).Visible = True

            DataGridView1.Columns(4).Visible = False
            DataGridView1.Columns(5).Visible = False
            DataGridView1.Columns(6).Visible = False
            DataGridView1.Columns(7).Visible = False
            DataGridView1.Columns(8).Visible = False
            DataGridView1.Columns(9).Visible = False
            DataGridView1.Columns(10).Visible = False
            DataGridView1.Columns(11).Visible = False
            DataGridView1.Columns(12).Visible = False
            DataGridView1.Columns(13).Visible = False
            DataGridView1.Columns(14).Visible = False
            DataGridView1.Columns(15).Visible = False
            DataGridView1.Columns(16).Visible = False
            DataGridView1.Columns(17).Visible = False
            DataGridView1.Columns(18).Visible = False
            DataGridView1.Columns(19).Visible = False
            DataGridView1.Columns(20).Visible = False
            DataGridView1.Columns(21).Visible = False
            DataGridView1.Columns(22).Visible = False
            DataGridView1.Columns(23).Visible = False
            DataGridView1.Columns(24).Visible = True
            DataGridView1.Columns(25).Visible = False
            DataGridView1.Columns(26).Visible = False
            DataGridView1.Columns(27).Visible = False
            DataGridView1.Columns(28).Visible = False
            DataGridView1.Columns(29).Visible = False
            DataGridView1.Columns(30).Visible = False
            DataGridView1.Columns(31).Visible = False
            DataGridView1.Columns(32).Visible = False
            DataGridView1.Columns(33).Visible = False
            DataGridView1.Columns(34).Visible = False
            DataGridView1.Columns(35).Visible = False
            DataGridView1.Columns(36).Visible = False
            DataGridView1.Columns(37).Visible = False
            DataGridView1.Columns(38).Visible = False
            DataGridView1.Columns(39).Visible = False
            DataGridView1.Columns(40).Visible = False
            DataGridView1.Columns(41).Visible = False
            DataGridView1.Columns(42).Visible = False
            DataGridView1.Columns(43).Visible = False
            DataGridView1.Columns(44).Visible = False
            DataGridView1.Columns(45).Visible = False
            DataGridView1.Columns(46).Visible = False
            DataGridView1.Columns(47).Visible = False
            DataGridView1.Columns(48).Visible = False
            DataGridView1.Columns(49).Visible = False
            DataGridView1.Columns(50).Visible = False
            DataGridView1.Columns(51).Visible = False
            DataGridView1.Columns(52).Visible = False
            DataGridView1.Columns(53).Visible = False
            DataGridView1.Columns(54).Visible = False
            DataGridView1.Columns(55).Visible = False

        ElseIf Sortbox.Text = "Educational Attainment" Then
            DataGridView1.Columns(1).Visible = True
            DataGridView1.Columns(2).Visible = True
            DataGridView1.Columns(3).Visible = True

            DataGridView1.Columns(4).Visible = False
            DataGridView1.Columns(5).Visible = False
            DataGridView1.Columns(6).Visible = False
            DataGridView1.Columns(7).Visible = False
            DataGridView1.Columns(8).Visible = False
            DataGridView1.Columns(9).Visible = False
            DataGridView1.Columns(10).Visible = False
            DataGridView1.Columns(11).Visible = False
            DataGridView1.Columns(12).Visible = False
            DataGridView1.Columns(13).Visible = False
            DataGridView1.Columns(14).Visible = False
            DataGridView1.Columns(15).Visible = False
            DataGridView1.Columns(16).Visible = False
            DataGridView1.Columns(17).Visible = False
            DataGridView1.Columns(18).Visible = False
            DataGridView1.Columns(19).Visible = False
            DataGridView1.Columns(20).Visible = False
            DataGridView1.Columns(21).Visible = False
            DataGridView1.Columns(22).Visible = False
            DataGridView1.Columns(23).Visible = False
            DataGridView1.Columns(24).Visible = False
            DataGridView1.Columns(25).Visible = True
            DataGridView1.Columns(26).Visible = False
            DataGridView1.Columns(27).Visible = False
            DataGridView1.Columns(28).Visible = False
            DataGridView1.Columns(29).Visible = False
            DataGridView1.Columns(30).Visible = False
            DataGridView1.Columns(31).Visible = False
            DataGridView1.Columns(32).Visible = False
            DataGridView1.Columns(33).Visible = False
            DataGridView1.Columns(34).Visible = False
            DataGridView1.Columns(35).Visible = False
            DataGridView1.Columns(36).Visible = False
            DataGridView1.Columns(37).Visible = False
            DataGridView1.Columns(38).Visible = False
            DataGridView1.Columns(39).Visible = False
            DataGridView1.Columns(40).Visible = False
            DataGridView1.Columns(41).Visible = False
            DataGridView1.Columns(42).Visible = False
            DataGridView1.Columns(43).Visible = False
            DataGridView1.Columns(44).Visible = False
            DataGridView1.Columns(45).Visible = False
            DataGridView1.Columns(46).Visible = False
            DataGridView1.Columns(47).Visible = False
            DataGridView1.Columns(48).Visible = False
            DataGridView1.Columns(49).Visible = False
            DataGridView1.Columns(50).Visible = False
            DataGridView1.Columns(51).Visible = False
            DataGridView1.Columns(52).Visible = False
            DataGridView1.Columns(53).Visible = False
            DataGridView1.Columns(54).Visible = False
            DataGridView1.Columns(55).Visible = False


        ElseIf Sortbox.Text = "University / College" Then
            DataGridView1.Columns(1).Visible = True
            DataGridView1.Columns(2).Visible = True
            DataGridView1.Columns(3).Visible = True

            DataGridView1.Columns(4).Visible = False
            DataGridView1.Columns(5).Visible = False
            DataGridView1.Columns(6).Visible = False
            DataGridView1.Columns(7).Visible = False
            DataGridView1.Columns(8).Visible = False
            DataGridView1.Columns(9).Visible = False
            DataGridView1.Columns(10).Visible = False
            DataGridView1.Columns(11).Visible = False
            DataGridView1.Columns(12).Visible = False
            DataGridView1.Columns(13).Visible = False
            DataGridView1.Columns(14).Visible = False
            DataGridView1.Columns(15).Visible = False
            DataGridView1.Columns(16).Visible = False
            DataGridView1.Columns(17).Visible = False
            DataGridView1.Columns(18).Visible = False
            DataGridView1.Columns(19).Visible = False
            DataGridView1.Columns(20).Visible = False
            DataGridView1.Columns(21).Visible = False
            DataGridView1.Columns(22).Visible = False
            DataGridView1.Columns(23).Visible = False
            DataGridView1.Columns(24).Visible = False
            DataGridView1.Columns(25).Visible = False
            DataGridView1.Columns(26).Visible = True
            DataGridView1.Columns(27).Visible = False
            DataGridView1.Columns(28).Visible = False
            DataGridView1.Columns(29).Visible = False
            DataGridView1.Columns(30).Visible = False
            DataGridView1.Columns(31).Visible = False
            DataGridView1.Columns(32).Visible = False
            DataGridView1.Columns(33).Visible = False
            DataGridView1.Columns(34).Visible = False
            DataGridView1.Columns(35).Visible = False
            DataGridView1.Columns(36).Visible = False
            DataGridView1.Columns(37).Visible = False
            DataGridView1.Columns(38).Visible = False
            DataGridView1.Columns(39).Visible = False
            DataGridView1.Columns(40).Visible = False
            DataGridView1.Columns(41).Visible = False
            DataGridView1.Columns(42).Visible = False
            DataGridView1.Columns(43).Visible = False
            DataGridView1.Columns(44).Visible = False
            DataGridView1.Columns(45).Visible = False
            DataGridView1.Columns(46).Visible = False
            DataGridView1.Columns(47).Visible = False
            DataGridView1.Columns(48).Visible = False
            DataGridView1.Columns(49).Visible = False
            DataGridView1.Columns(50).Visible = False
            DataGridView1.Columns(51).Visible = False
            DataGridView1.Columns(52).Visible = False
            DataGridView1.Columns(53).Visible = False
            DataGridView1.Columns(54).Visible = False
            DataGridView1.Columns(55).Visible = False


        ElseIf Sortbox.Text = "Program" Then
            DataGridView1.Columns(1).Visible = True
            DataGridView1.Columns(2).Visible = True
            DataGridView1.Columns(3).Visible = True

            DataGridView1.Columns(4).Visible = False
            DataGridView1.Columns(5).Visible = False
            DataGridView1.Columns(6).Visible = False
            DataGridView1.Columns(7).Visible = False
            DataGridView1.Columns(8).Visible = False
            DataGridView1.Columns(9).Visible = False
            DataGridView1.Columns(10).Visible = False
            DataGridView1.Columns(11).Visible = False
            DataGridView1.Columns(12).Visible = False
            DataGridView1.Columns(13).Visible = False
            DataGridView1.Columns(14).Visible = False
            DataGridView1.Columns(15).Visible = False
            DataGridView1.Columns(16).Visible = False
            DataGridView1.Columns(17).Visible = False
            DataGridView1.Columns(18).Visible = False
            DataGridView1.Columns(19).Visible = False
            DataGridView1.Columns(20).Visible = False
            DataGridView1.Columns(21).Visible = False
            DataGridView1.Columns(22).Visible = False
            DataGridView1.Columns(23).Visible = False
            DataGridView1.Columns(24).Visible = False
            DataGridView1.Columns(25).Visible = False
            DataGridView1.Columns(26).Visible = False
            DataGridView1.Columns(27).Visible = True
            DataGridView1.Columns(28).Visible = False
            DataGridView1.Columns(29).Visible = False
            DataGridView1.Columns(30).Visible = False
            DataGridView1.Columns(31).Visible = False
            DataGridView1.Columns(32).Visible = False
            DataGridView1.Columns(33).Visible = False
            DataGridView1.Columns(34).Visible = False
            DataGridView1.Columns(35).Visible = False
            DataGridView1.Columns(36).Visible = False
            DataGridView1.Columns(37).Visible = False
            DataGridView1.Columns(38).Visible = False
            DataGridView1.Columns(39).Visible = False
            DataGridView1.Columns(40).Visible = False
            DataGridView1.Columns(41).Visible = False
            DataGridView1.Columns(42).Visible = False
            DataGridView1.Columns(43).Visible = False
            DataGridView1.Columns(44).Visible = False
            DataGridView1.Columns(45).Visible = False
            DataGridView1.Columns(46).Visible = False
            DataGridView1.Columns(47).Visible = False
            DataGridView1.Columns(48).Visible = False
            DataGridView1.Columns(49).Visible = False
            DataGridView1.Columns(50).Visible = False
            DataGridView1.Columns(51).Visible = False
            DataGridView1.Columns(52).Visible = False
            DataGridView1.Columns(53).Visible = False
            DataGridView1.Columns(54).Visible = False
            DataGridView1.Columns(55).Visible = False


        ElseIf Sortbox.Text = "Date Hired" Then
            DataGridView1.Columns(1).Visible = True
            DataGridView1.Columns(2).Visible = True
            DataGridView1.Columns(3).Visible = True

            DataGridView1.Columns(4).Visible = False
            DataGridView1.Columns(5).Visible = False
            DataGridView1.Columns(6).Visible = False
            DataGridView1.Columns(7).Visible = False
            DataGridView1.Columns(8).Visible = False
            DataGridView1.Columns(9).Visible = False
            DataGridView1.Columns(10).Visible = False
            DataGridView1.Columns(11).Visible = False
            DataGridView1.Columns(12).Visible = False
            DataGridView1.Columns(13).Visible = False
            DataGridView1.Columns(14).Visible = False
            DataGridView1.Columns(15).Visible = False
            DataGridView1.Columns(16).Visible = False
            DataGridView1.Columns(17).Visible = False
            DataGridView1.Columns(18).Visible = False
            DataGridView1.Columns(19).Visible = False
            DataGridView1.Columns(20).Visible = False
            DataGridView1.Columns(21).Visible = False
            DataGridView1.Columns(22).Visible = False
            DataGridView1.Columns(23).Visible = False
            DataGridView1.Columns(24).Visible = False
            DataGridView1.Columns(25).Visible = False
            DataGridView1.Columns(26).Visible = False
            DataGridView1.Columns(27).Visible = False
            DataGridView1.Columns(28).Visible = True
            DataGridView1.Columns(29).Visible = False
            DataGridView1.Columns(30).Visible = False
            DataGridView1.Columns(31).Visible = False
            DataGridView1.Columns(32).Visible = False
            DataGridView1.Columns(33).Visible = False
            DataGridView1.Columns(34).Visible = False
            DataGridView1.Columns(35).Visible = False
            DataGridView1.Columns(36).Visible = False
            DataGridView1.Columns(37).Visible = False
            DataGridView1.Columns(38).Visible = False
            DataGridView1.Columns(39).Visible = False
            DataGridView1.Columns(40).Visible = False
            DataGridView1.Columns(41).Visible = False
            DataGridView1.Columns(42).Visible = False
            DataGridView1.Columns(43).Visible = False
            DataGridView1.Columns(44).Visible = False
            DataGridView1.Columns(45).Visible = False
            DataGridView1.Columns(46).Visible = False
            DataGridView1.Columns(47).Visible = False
            DataGridView1.Columns(48).Visible = False
            DataGridView1.Columns(49).Visible = False
            DataGridView1.Columns(50).Visible = False
            DataGridView1.Columns(51).Visible = False
            DataGridView1.Columns(52).Visible = False
            DataGridView1.Columns(53).Visible = False
            DataGridView1.Columns(54).Visible = False
            DataGridView1.Columns(55).Visible = False


        ElseIf Sortbox.Text = "Status" Then
            DataGridView1.Columns(1).Visible = True
            DataGridView1.Columns(2).Visible = True
            DataGridView1.Columns(3).Visible = True

            DataGridView1.Columns(4).Visible = False
            DataGridView1.Columns(5).Visible = False
            DataGridView1.Columns(6).Visible = False
            DataGridView1.Columns(7).Visible = False
            DataGridView1.Columns(8).Visible = False
            DataGridView1.Columns(9).Visible = False
            DataGridView1.Columns(10).Visible = False
            DataGridView1.Columns(11).Visible = False
            DataGridView1.Columns(12).Visible = False
            DataGridView1.Columns(13).Visible = False
            DataGridView1.Columns(14).Visible = False
            DataGridView1.Columns(15).Visible = False
            DataGridView1.Columns(16).Visible = False
            DataGridView1.Columns(17).Visible = False
            DataGridView1.Columns(18).Visible = False
            DataGridView1.Columns(19).Visible = False
            DataGridView1.Columns(20).Visible = False
            DataGridView1.Columns(21).Visible = False
            DataGridView1.Columns(22).Visible = False
            DataGridView1.Columns(23).Visible = False
            DataGridView1.Columns(24).Visible = False
            DataGridView1.Columns(25).Visible = False
            DataGridView1.Columns(26).Visible = False
            DataGridView1.Columns(27).Visible = False
            DataGridView1.Columns(28).Visible = False
            DataGridView1.Columns(29).Visible = True
            DataGridView1.Columns(30).Visible = False
            DataGridView1.Columns(31).Visible = False
            DataGridView1.Columns(32).Visible = False
            DataGridView1.Columns(33).Visible = False
            DataGridView1.Columns(34).Visible = False
            DataGridView1.Columns(35).Visible = False
            DataGridView1.Columns(36).Visible = False
            DataGridView1.Columns(37).Visible = False
            DataGridView1.Columns(38).Visible = False
            DataGridView1.Columns(39).Visible = False
            DataGridView1.Columns(40).Visible = False
            DataGridView1.Columns(41).Visible = False
            DataGridView1.Columns(42).Visible = False
            DataGridView1.Columns(43).Visible = False
            DataGridView1.Columns(44).Visible = False
            DataGridView1.Columns(45).Visible = False
            DataGridView1.Columns(46).Visible = False
            DataGridView1.Columns(47).Visible = False
            DataGridView1.Columns(48).Visible = False
            DataGridView1.Columns(49).Visible = False
            DataGridView1.Columns(50).Visible = False
            DataGridView1.Columns(51).Visible = False
            DataGridView1.Columns(52).Visible = False
            DataGridView1.Columns(53).Visible = False
            DataGridView1.Columns(54).Visible = False
            DataGridView1.Columns(55).Visible = False


        ElseIf Sortbox.Text = "Permanency" Then
            DataGridView1.Columns(1).Visible = True
            DataGridView1.Columns(2).Visible = True
            DataGridView1.Columns(3).Visible = True

            DataGridView1.Columns(4).Visible = False
            DataGridView1.Columns(5).Visible = False
            DataGridView1.Columns(6).Visible = False
            DataGridView1.Columns(7).Visible = False
            DataGridView1.Columns(8).Visible = False
            DataGridView1.Columns(9).Visible = False
            DataGridView1.Columns(10).Visible = False
            DataGridView1.Columns(11).Visible = False
            DataGridView1.Columns(12).Visible = False
            DataGridView1.Columns(13).Visible = False
            DataGridView1.Columns(14).Visible = False
            DataGridView1.Columns(15).Visible = False
            DataGridView1.Columns(16).Visible = False
            DataGridView1.Columns(17).Visible = False
            DataGridView1.Columns(18).Visible = False
            DataGridView1.Columns(19).Visible = False
            DataGridView1.Columns(20).Visible = False
            DataGridView1.Columns(21).Visible = False
            DataGridView1.Columns(22).Visible = False
            DataGridView1.Columns(23).Visible = False
            DataGridView1.Columns(24).Visible = False
            DataGridView1.Columns(25).Visible = False
            DataGridView1.Columns(26).Visible = False
            DataGridView1.Columns(27).Visible = False
            DataGridView1.Columns(28).Visible = False
            DataGridView1.Columns(29).Visible = False
            DataGridView1.Columns(30).Visible = True
            DataGridView1.Columns(31).Visible = False
            DataGridView1.Columns(32).Visible = False
            DataGridView1.Columns(33).Visible = False
            DataGridView1.Columns(34).Visible = False
            DataGridView1.Columns(35).Visible = False
            DataGridView1.Columns(36).Visible = False
            DataGridView1.Columns(37).Visible = False
            DataGridView1.Columns(38).Visible = False
            DataGridView1.Columns(39).Visible = False
            DataGridView1.Columns(40).Visible = False
            DataGridView1.Columns(41).Visible = False
            DataGridView1.Columns(42).Visible = False
            DataGridView1.Columns(43).Visible = False
            DataGridView1.Columns(44).Visible = False
            DataGridView1.Columns(45).Visible = False
            DataGridView1.Columns(46).Visible = False
            DataGridView1.Columns(47).Visible = False
            DataGridView1.Columns(48).Visible = False
            DataGridView1.Columns(49).Visible = False
            DataGridView1.Columns(50).Visible = False
            DataGridView1.Columns(51).Visible = False
            DataGridView1.Columns(52).Visible = False
            DataGridView1.Columns(53).Visible = False
            DataGridView1.Columns(54).Visible = False
            DataGridView1.Columns(55).Visible = False



        ElseIf Sortbox.Text = "Last Day" Then
            DataGridView1.Columns(1).Visible = True
            DataGridView1.Columns(2).Visible = True
            DataGridView1.Columns(3).Visible = True

            DataGridView1.Columns(4).Visible = False
            DataGridView1.Columns(5).Visible = False
            DataGridView1.Columns(6).Visible = False
            DataGridView1.Columns(7).Visible = False
            DataGridView1.Columns(8).Visible = False
            DataGridView1.Columns(9).Visible = False
            DataGridView1.Columns(10).Visible = False
            DataGridView1.Columns(11).Visible = False
            DataGridView1.Columns(12).Visible = False
            DataGridView1.Columns(13).Visible = False
            DataGridView1.Columns(14).Visible = False
            DataGridView1.Columns(15).Visible = False
            DataGridView1.Columns(16).Visible = False
            DataGridView1.Columns(17).Visible = False
            DataGridView1.Columns(18).Visible = False
            DataGridView1.Columns(19).Visible = False
            DataGridView1.Columns(20).Visible = False
            DataGridView1.Columns(21).Visible = False
            DataGridView1.Columns(22).Visible = False
            DataGridView1.Columns(23).Visible = False
            DataGridView1.Columns(24).Visible = False
            DataGridView1.Columns(25).Visible = False
            DataGridView1.Columns(26).Visible = False
            DataGridView1.Columns(27).Visible = False
            DataGridView1.Columns(28).Visible = False
            DataGridView1.Columns(29).Visible = False
            DataGridView1.Columns(30).Visible = False
            DataGridView1.Columns(31).Visible = True
            DataGridView1.Columns(32).Visible = False
            DataGridView1.Columns(33).Visible = False
            DataGridView1.Columns(34).Visible = False
            DataGridView1.Columns(35).Visible = False
            DataGridView1.Columns(36).Visible = False
            DataGridView1.Columns(37).Visible = False
            DataGridView1.Columns(38).Visible = False
            DataGridView1.Columns(39).Visible = False
            DataGridView1.Columns(40).Visible = False
            DataGridView1.Columns(41).Visible = False
            DataGridView1.Columns(42).Visible = False
            DataGridView1.Columns(43).Visible = False
            DataGridView1.Columns(44).Visible = False
            DataGridView1.Columns(45).Visible = False
            DataGridView1.Columns(46).Visible = False
            DataGridView1.Columns(47).Visible = False
            DataGridView1.Columns(48).Visible = False
            DataGridView1.Columns(49).Visible = False
            DataGridView1.Columns(50).Visible = False
            DataGridView1.Columns(51).Visible = False
            DataGridView1.Columns(52).Visible = False
            DataGridView1.Columns(53).Visible = False
            DataGridView1.Columns(54).Visible = False
            DataGridView1.Columns(55).Visible = False





        ElseIf Sortbox.Text = "Reason For Leaving" Then
            DataGridView1.Columns(1).Visible = True
            DataGridView1.Columns(2).Visible = True
            DataGridView1.Columns(3).Visible = True

            DataGridView1.Columns(4).Visible = False
            DataGridView1.Columns(5).Visible = False
            DataGridView1.Columns(6).Visible = False
            DataGridView1.Columns(7).Visible = False
            DataGridView1.Columns(8).Visible = False
            DataGridView1.Columns(9).Visible = False
            DataGridView1.Columns(10).Visible = False
            DataGridView1.Columns(11).Visible = False
            DataGridView1.Columns(12).Visible = False
            DataGridView1.Columns(13).Visible = False
            DataGridView1.Columns(14).Visible = False
            DataGridView1.Columns(15).Visible = False
            DataGridView1.Columns(16).Visible = False
            DataGridView1.Columns(17).Visible = False
            DataGridView1.Columns(18).Visible = False
            DataGridView1.Columns(19).Visible = False
            DataGridView1.Columns(20).Visible = False
            DataGridView1.Columns(21).Visible = False
            DataGridView1.Columns(22).Visible = False
            DataGridView1.Columns(23).Visible = False
            DataGridView1.Columns(24).Visible = False
            DataGridView1.Columns(25).Visible = False
            DataGridView1.Columns(26).Visible = False
            DataGridView1.Columns(27).Visible = False
            DataGridView1.Columns(28).Visible = False
            DataGridView1.Columns(29).Visible = False
            DataGridView1.Columns(30).Visible = False
            DataGridView1.Columns(31).Visible = False
            DataGridView1.Columns(32).Visible = True
            DataGridView1.Columns(33).Visible = False
            DataGridView1.Columns(34).Visible = False
            DataGridView1.Columns(35).Visible = False
            DataGridView1.Columns(36).Visible = False
            DataGridView1.Columns(37).Visible = False
            DataGridView1.Columns(38).Visible = False
            DataGridView1.Columns(39).Visible = False
            DataGridView1.Columns(40).Visible = False
            DataGridView1.Columns(41).Visible = False
            DataGridView1.Columns(42).Visible = False
            DataGridView1.Columns(43).Visible = False
            DataGridView1.Columns(44).Visible = False
            DataGridView1.Columns(45).Visible = False
            DataGridView1.Columns(46).Visible = False
            DataGridView1.Columns(47).Visible = False
            DataGridView1.Columns(48).Visible = False
            DataGridView1.Columns(49).Visible = False
            DataGridView1.Columns(50).Visible = False
            DataGridView1.Columns(51).Visible = False
            DataGridView1.Columns(52).Visible = False
            DataGridView1.Columns(53).Visible = False
            DataGridView1.Columns(54).Visible = False
            DataGridView1.Columns(55).Visible = False




        ElseIf Sortbox.Text = "License Number" Then
            DataGridView1.Columns(1).Visible = True
            DataGridView1.Columns(2).Visible = True
            DataGridView1.Columns(3).Visible = True

            DataGridView1.Columns(4).Visible = False
            DataGridView1.Columns(5).Visible = False
            DataGridView1.Columns(6).Visible = False
            DataGridView1.Columns(7).Visible = False
            DataGridView1.Columns(8).Visible = False
            DataGridView1.Columns(9).Visible = False
            DataGridView1.Columns(10).Visible = False
            DataGridView1.Columns(11).Visible = False
            DataGridView1.Columns(12).Visible = False
            DataGridView1.Columns(13).Visible = False
            DataGridView1.Columns(14).Visible = False
            DataGridView1.Columns(15).Visible = False
            DataGridView1.Columns(16).Visible = False
            DataGridView1.Columns(17).Visible = False
            DataGridView1.Columns(18).Visible = False
            DataGridView1.Columns(19).Visible = False
            DataGridView1.Columns(20).Visible = False
            DataGridView1.Columns(21).Visible = False
            DataGridView1.Columns(22).Visible = False
            DataGridView1.Columns(23).Visible = False
            DataGridView1.Columns(24).Visible = False
            DataGridView1.Columns(25).Visible = False
            DataGridView1.Columns(26).Visible = False
            DataGridView1.Columns(27).Visible = False
            DataGridView1.Columns(28).Visible = False
            DataGridView1.Columns(29).Visible = False
            DataGridView1.Columns(30).Visible = False
            DataGridView1.Columns(31).Visible = False
            DataGridView1.Columns(32).Visible = False
            DataGridView1.Columns(33).Visible = True
            DataGridView1.Columns(34).Visible = False
            DataGridView1.Columns(35).Visible = False
            DataGridView1.Columns(36).Visible = False
            DataGridView1.Columns(37).Visible = False
            DataGridView1.Columns(38).Visible = False
            DataGridView1.Columns(39).Visible = False
            DataGridView1.Columns(40).Visible = False
            DataGridView1.Columns(41).Visible = False
            DataGridView1.Columns(42).Visible = False
            DataGridView1.Columns(43).Visible = False
            DataGridView1.Columns(44).Visible = False
            DataGridView1.Columns(45).Visible = False
            DataGridView1.Columns(46).Visible = False
            DataGridView1.Columns(47).Visible = False
            DataGridView1.Columns(48).Visible = False
            DataGridView1.Columns(49).Visible = False
            DataGridView1.Columns(50).Visible = False
            DataGridView1.Columns(51).Visible = False
            DataGridView1.Columns(52).Visible = False
            DataGridView1.Columns(53).Visible = False
            DataGridView1.Columns(54).Visible = False
            DataGridView1.Columns(55).Visible = False


        ElseIf Sortbox.Text = "Expiry" Then
            DataGridView1.Columns(1).Visible = True
            DataGridView1.Columns(2).Visible = True
            DataGridView1.Columns(3).Visible = True

            DataGridView1.Columns(4).Visible = False
            DataGridView1.Columns(5).Visible = False
            DataGridView1.Columns(6).Visible = False
            DataGridView1.Columns(7).Visible = False
            DataGridView1.Columns(8).Visible = False
            DataGridView1.Columns(9).Visible = False
            DataGridView1.Columns(10).Visible = False
            DataGridView1.Columns(11).Visible = False
            DataGridView1.Columns(12).Visible = False
            DataGridView1.Columns(13).Visible = False
            DataGridView1.Columns(14).Visible = False
            DataGridView1.Columns(15).Visible = False
            DataGridView1.Columns(16).Visible = False
            DataGridView1.Columns(17).Visible = False
            DataGridView1.Columns(18).Visible = False
            DataGridView1.Columns(19).Visible = False
            DataGridView1.Columns(20).Visible = False
            DataGridView1.Columns(21).Visible = False
            DataGridView1.Columns(22).Visible = False
            DataGridView1.Columns(23).Visible = False
            DataGridView1.Columns(24).Visible = False
            DataGridView1.Columns(25).Visible = False
            DataGridView1.Columns(26).Visible = False
            DataGridView1.Columns(27).Visible = False
            DataGridView1.Columns(28).Visible = False
            DataGridView1.Columns(29).Visible = False
            DataGridView1.Columns(30).Visible = False
            DataGridView1.Columns(31).Visible = False
            DataGridView1.Columns(32).Visible = False
            DataGridView1.Columns(33).Visible = False
            DataGridView1.Columns(34).Visible = True
            DataGridView1.Columns(35).Visible = False
            DataGridView1.Columns(36).Visible = False
            DataGridView1.Columns(37).Visible = False
            DataGridView1.Columns(38).Visible = False
            DataGridView1.Columns(39).Visible = False
            DataGridView1.Columns(40).Visible = False
            DataGridView1.Columns(41).Visible = False
            DataGridView1.Columns(42).Visible = False
            DataGridView1.Columns(43).Visible = False
            DataGridView1.Columns(44).Visible = False
            DataGridView1.Columns(45).Visible = False
            DataGridView1.Columns(46).Visible = False
            DataGridView1.Columns(47).Visible = False
            DataGridView1.Columns(48).Visible = False
            DataGridView1.Columns(49).Visible = False
            DataGridView1.Columns(50).Visible = False
            DataGridView1.Columns(51).Visible = False
            DataGridView1.Columns(52).Visible = False
            DataGridView1.Columns(53).Visible = False
            DataGridView1.Columns(54).Visible = False
            DataGridView1.Columns(55).Visible = False



        ElseIf Sortbox.Text = "Exam Taken" Then
            DataGridView1.Columns(1).Visible = True
            DataGridView1.Columns(2).Visible = True
            DataGridView1.Columns(3).Visible = True

            DataGridView1.Columns(4).Visible = False
            DataGridView1.Columns(5).Visible = False
            DataGridView1.Columns(6).Visible = False
            DataGridView1.Columns(7).Visible = False
            DataGridView1.Columns(8).Visible = False
            DataGridView1.Columns(9).Visible = False
            DataGridView1.Columns(10).Visible = False
            DataGridView1.Columns(11).Visible = False
            DataGridView1.Columns(12).Visible = False
            DataGridView1.Columns(13).Visible = False
            DataGridView1.Columns(14).Visible = False
            DataGridView1.Columns(15).Visible = False
            DataGridView1.Columns(16).Visible = False
            DataGridView1.Columns(17).Visible = False
            DataGridView1.Columns(18).Visible = False
            DataGridView1.Columns(19).Visible = False
            DataGridView1.Columns(20).Visible = False
            DataGridView1.Columns(21).Visible = False
            DataGridView1.Columns(22).Visible = False
            DataGridView1.Columns(23).Visible = False
            DataGridView1.Columns(24).Visible = False
            DataGridView1.Columns(25).Visible = False
            DataGridView1.Columns(26).Visible = False
            DataGridView1.Columns(27).Visible = False
            DataGridView1.Columns(28).Visible = False
            DataGridView1.Columns(29).Visible = False
            DataGridView1.Columns(30).Visible = False
            DataGridView1.Columns(31).Visible = False
            DataGridView1.Columns(32).Visible = False
            DataGridView1.Columns(33).Visible = False
            DataGridView1.Columns(34).Visible = False
            DataGridView1.Columns(35).Visible = True
            DataGridView1.Columns(36).Visible = False
            DataGridView1.Columns(37).Visible = False
            DataGridView1.Columns(38).Visible = False
            DataGridView1.Columns(39).Visible = False
            DataGridView1.Columns(40).Visible = False
            DataGridView1.Columns(41).Visible = False
            DataGridView1.Columns(42).Visible = False
            DataGridView1.Columns(43).Visible = False
            DataGridView1.Columns(44).Visible = False
            DataGridView1.Columns(45).Visible = False
            DataGridView1.Columns(46).Visible = False
            DataGridView1.Columns(47).Visible = False
            DataGridView1.Columns(48).Visible = False
            DataGridView1.Columns(49).Visible = False
            DataGridView1.Columns(50).Visible = False
            DataGridView1.Columns(51).Visible = False
            DataGridView1.Columns(52).Visible = False
            DataGridView1.Columns(53).Visible = False
            DataGridView1.Columns(54).Visible = False
            DataGridView1.Columns(55).Visible = False



        ElseIf Sortbox.Text = "Certificate Number" Then
            DataGridView1.Columns(1).Visible = True
            DataGridView1.Columns(2).Visible = True
            DataGridView1.Columns(3).Visible = True

            DataGridView1.Columns(4).Visible = False
            DataGridView1.Columns(5).Visible = False
            DataGridView1.Columns(6).Visible = False
            DataGridView1.Columns(7).Visible = False
            DataGridView1.Columns(8).Visible = False
            DataGridView1.Columns(9).Visible = False
            DataGridView1.Columns(10).Visible = False
            DataGridView1.Columns(11).Visible = False
            DataGridView1.Columns(12).Visible = False
            DataGridView1.Columns(13).Visible = False
            DataGridView1.Columns(14).Visible = False
            DataGridView1.Columns(15).Visible = False
            DataGridView1.Columns(16).Visible = False
            DataGridView1.Columns(17).Visible = False
            DataGridView1.Columns(18).Visible = False
            DataGridView1.Columns(19).Visible = False
            DataGridView1.Columns(20).Visible = False
            DataGridView1.Columns(21).Visible = False
            DataGridView1.Columns(22).Visible = False
            DataGridView1.Columns(23).Visible = False
            DataGridView1.Columns(24).Visible = False
            DataGridView1.Columns(25).Visible = False
            DataGridView1.Columns(26).Visible = False
            DataGridView1.Columns(27).Visible = False
            DataGridView1.Columns(28).Visible = False
            DataGridView1.Columns(29).Visible = False
            DataGridView1.Columns(30).Visible = False
            DataGridView1.Columns(31).Visible = False
            DataGridView1.Columns(32).Visible = False
            DataGridView1.Columns(33).Visible = False
            DataGridView1.Columns(34).Visible = False
            DataGridView1.Columns(35).Visible = False
            DataGridView1.Columns(36).Visible = True
            DataGridView1.Columns(37).Visible = False
            DataGridView1.Columns(38).Visible = False
            DataGridView1.Columns(39).Visible = False
            DataGridView1.Columns(40).Visible = False
            DataGridView1.Columns(41).Visible = False
            DataGridView1.Columns(42).Visible = False
            DataGridView1.Columns(43).Visible = False
            DataGridView1.Columns(44).Visible = False
            DataGridView1.Columns(45).Visible = False
            DataGridView1.Columns(46).Visible = False
            DataGridView1.Columns(47).Visible = False
            DataGridView1.Columns(48).Visible = False
            DataGridView1.Columns(49).Visible = False
            DataGridView1.Columns(50).Visible = False
            DataGridView1.Columns(51).Visible = False
            DataGridView1.Columns(52).Visible = False
            DataGridView1.Columns(53).Visible = False
            DataGridView1.Columns(54).Visible = False
            DataGridView1.Columns(55).Visible = False


        ElseIf Sortbox.Text = "UMID" Then
            DataGridView1.Columns(1).Visible = True
            DataGridView1.Columns(2).Visible = True
            DataGridView1.Columns(3).Visible = True

            DataGridView1.Columns(4).Visible = False
            DataGridView1.Columns(5).Visible = False
            DataGridView1.Columns(6).Visible = False
            DataGridView1.Columns(7).Visible = False
            DataGridView1.Columns(8).Visible = False
            DataGridView1.Columns(9).Visible = False
            DataGridView1.Columns(10).Visible = False
            DataGridView1.Columns(11).Visible = False
            DataGridView1.Columns(12).Visible = False
            DataGridView1.Columns(13).Visible = False
            DataGridView1.Columns(14).Visible = False
            DataGridView1.Columns(15).Visible = False
            DataGridView1.Columns(16).Visible = False
            DataGridView1.Columns(17).Visible = False
            DataGridView1.Columns(18).Visible = False
            DataGridView1.Columns(19).Visible = False
            DataGridView1.Columns(20).Visible = False
            DataGridView1.Columns(21).Visible = False
            DataGridView1.Columns(22).Visible = False
            DataGridView1.Columns(23).Visible = False
            DataGridView1.Columns(24).Visible = False
            DataGridView1.Columns(25).Visible = False
            DataGridView1.Columns(26).Visible = False
            DataGridView1.Columns(27).Visible = False
            DataGridView1.Columns(28).Visible = False
            DataGridView1.Columns(29).Visible = False
            DataGridView1.Columns(30).Visible = False
            DataGridView1.Columns(31).Visible = False
            DataGridView1.Columns(32).Visible = False
            DataGridView1.Columns(33).Visible = False
            DataGridView1.Columns(34).Visible = False
            DataGridView1.Columns(35).Visible = False
            DataGridView1.Columns(36).Visible = False
            DataGridView1.Columns(37).Visible = True
            DataGridView1.Columns(38).Visible = False
            DataGridView1.Columns(39).Visible = False
            DataGridView1.Columns(40).Visible = False
            DataGridView1.Columns(41).Visible = False
            DataGridView1.Columns(42).Visible = False
            DataGridView1.Columns(43).Visible = False
            DataGridView1.Columns(44).Visible = False
            DataGridView1.Columns(45).Visible = False
            DataGridView1.Columns(46).Visible = False
            DataGridView1.Columns(47).Visible = False
            DataGridView1.Columns(48).Visible = False
            DataGridView1.Columns(49).Visible = False
            DataGridView1.Columns(50).Visible = False
            DataGridView1.Columns(51).Visible = False
            DataGridView1.Columns(52).Visible = False
            DataGridView1.Columns(53).Visible = False
            DataGridView1.Columns(54).Visible = False
            DataGridView1.Columns(55).Visible = False



        ElseIf Sortbox.Text = "SSS" Then
            DataGridView1.Columns(1).Visible = True
            DataGridView1.Columns(2).Visible = True
            DataGridView1.Columns(3).Visible = True

            DataGridView1.Columns(4).Visible = False
            DataGridView1.Columns(5).Visible = False
            DataGridView1.Columns(6).Visible = False
            DataGridView1.Columns(7).Visible = False
            DataGridView1.Columns(8).Visible = False
            DataGridView1.Columns(9).Visible = False
            DataGridView1.Columns(10).Visible = False
            DataGridView1.Columns(11).Visible = False
            DataGridView1.Columns(12).Visible = False
            DataGridView1.Columns(13).Visible = False
            DataGridView1.Columns(14).Visible = False
            DataGridView1.Columns(15).Visible = False
            DataGridView1.Columns(16).Visible = False
            DataGridView1.Columns(17).Visible = False
            DataGridView1.Columns(18).Visible = False
            DataGridView1.Columns(19).Visible = False
            DataGridView1.Columns(20).Visible = False
            DataGridView1.Columns(21).Visible = False
            DataGridView1.Columns(22).Visible = False
            DataGridView1.Columns(23).Visible = False
            DataGridView1.Columns(24).Visible = False
            DataGridView1.Columns(25).Visible = False
            DataGridView1.Columns(26).Visible = False
            DataGridView1.Columns(27).Visible = False
            DataGridView1.Columns(28).Visible = False
            DataGridView1.Columns(29).Visible = False
            DataGridView1.Columns(30).Visible = False
            DataGridView1.Columns(31).Visible = False
            DataGridView1.Columns(32).Visible = False
            DataGridView1.Columns(33).Visible = False
            DataGridView1.Columns(34).Visible = False
            DataGridView1.Columns(35).Visible = False
            DataGridView1.Columns(36).Visible = False
            DataGridView1.Columns(37).Visible = False
            DataGridView1.Columns(38).Visible = True
            DataGridView1.Columns(39).Visible = False
            DataGridView1.Columns(40).Visible = False
            DataGridView1.Columns(41).Visible = False
            DataGridView1.Columns(42).Visible = False
            DataGridView1.Columns(43).Visible = False
            DataGridView1.Columns(44).Visible = False
            DataGridView1.Columns(45).Visible = False
            DataGridView1.Columns(46).Visible = False
            DataGridView1.Columns(47).Visible = False
            DataGridView1.Columns(48).Visible = False
            DataGridView1.Columns(49).Visible = False
            DataGridView1.Columns(50).Visible = False
            DataGridView1.Columns(51).Visible = False
            DataGridView1.Columns(52).Visible = False
            DataGridView1.Columns(53).Visible = False
            DataGridView1.Columns(54).Visible = False
            DataGridView1.Columns(55).Visible = False




        ElseIf Sortbox.Text = "PhilHealth" Then
            DataGridView1.Columns(1).Visible = True
            DataGridView1.Columns(2).Visible = True
            DataGridView1.Columns(3).Visible = True

            DataGridView1.Columns(4).Visible = False
            DataGridView1.Columns(5).Visible = False
            DataGridView1.Columns(6).Visible = False
            DataGridView1.Columns(7).Visible = False
            DataGridView1.Columns(8).Visible = False
            DataGridView1.Columns(9).Visible = False
            DataGridView1.Columns(10).Visible = False
            DataGridView1.Columns(11).Visible = False
            DataGridView1.Columns(12).Visible = False
            DataGridView1.Columns(13).Visible = False
            DataGridView1.Columns(14).Visible = False
            DataGridView1.Columns(15).Visible = False
            DataGridView1.Columns(16).Visible = False
            DataGridView1.Columns(17).Visible = False
            DataGridView1.Columns(18).Visible = False
            DataGridView1.Columns(19).Visible = False
            DataGridView1.Columns(20).Visible = False
            DataGridView1.Columns(21).Visible = False
            DataGridView1.Columns(22).Visible = False
            DataGridView1.Columns(23).Visible = False
            DataGridView1.Columns(24).Visible = False
            DataGridView1.Columns(25).Visible = False
            DataGridView1.Columns(26).Visible = False
            DataGridView1.Columns(27).Visible = False
            DataGridView1.Columns(28).Visible = False
            DataGridView1.Columns(29).Visible = False
            DataGridView1.Columns(30).Visible = False
            DataGridView1.Columns(31).Visible = False
            DataGridView1.Columns(32).Visible = False
            DataGridView1.Columns(33).Visible = False
            DataGridView1.Columns(34).Visible = False
            DataGridView1.Columns(35).Visible = False
            DataGridView1.Columns(36).Visible = False
            DataGridView1.Columns(37).Visible = False
            DataGridView1.Columns(38).Visible = False
            DataGridView1.Columns(39).Visible = True
            DataGridView1.Columns(40).Visible = False
            DataGridView1.Columns(41).Visible = False
            DataGridView1.Columns(42).Visible = False
            DataGridView1.Columns(43).Visible = False
            DataGridView1.Columns(44).Visible = False
            DataGridView1.Columns(45).Visible = False
            DataGridView1.Columns(46).Visible = False
            DataGridView1.Columns(47).Visible = False
            DataGridView1.Columns(48).Visible = False
            DataGridView1.Columns(49).Visible = False
            DataGridView1.Columns(50).Visible = False
            DataGridView1.Columns(51).Visible = False
            DataGridView1.Columns(52).Visible = False
            DataGridView1.Columns(53).Visible = False
            DataGridView1.Columns(54).Visible = False
            DataGridView1.Columns(55).Visible = False


        ElseIf Sortbox.Text = "TIN" Then
            DataGridView1.Columns(1).Visible = True
            DataGridView1.Columns(2).Visible = True
            DataGridView1.Columns(3).Visible = True

            DataGridView1.Columns(4).Visible = False
            DataGridView1.Columns(5).Visible = False
            DataGridView1.Columns(6).Visible = False
            DataGridView1.Columns(7).Visible = False
            DataGridView1.Columns(8).Visible = False
            DataGridView1.Columns(9).Visible = False
            DataGridView1.Columns(10).Visible = False
            DataGridView1.Columns(11).Visible = False
            DataGridView1.Columns(12).Visible = False
            DataGridView1.Columns(13).Visible = False
            DataGridView1.Columns(14).Visible = False
            DataGridView1.Columns(15).Visible = False
            DataGridView1.Columns(16).Visible = False
            DataGridView1.Columns(17).Visible = False
            DataGridView1.Columns(18).Visible = False
            DataGridView1.Columns(19).Visible = False
            DataGridView1.Columns(20).Visible = False
            DataGridView1.Columns(21).Visible = False
            DataGridView1.Columns(22).Visible = False
            DataGridView1.Columns(23).Visible = False
            DataGridView1.Columns(24).Visible = False
            DataGridView1.Columns(25).Visible = False
            DataGridView1.Columns(26).Visible = False
            DataGridView1.Columns(27).Visible = False
            DataGridView1.Columns(28).Visible = False
            DataGridView1.Columns(29).Visible = False
            DataGridView1.Columns(30).Visible = False
            DataGridView1.Columns(31).Visible = False
            DataGridView1.Columns(32).Visible = False
            DataGridView1.Columns(33).Visible = False
            DataGridView1.Columns(34).Visible = False
            DataGridView1.Columns(35).Visible = False
            DataGridView1.Columns(36).Visible = False
            DataGridView1.Columns(37).Visible = False
            DataGridView1.Columns(38).Visible = False
            DataGridView1.Columns(39).Visible = False
            DataGridView1.Columns(40).Visible = True
            DataGridView1.Columns(41).Visible = False
            DataGridView1.Columns(42).Visible = False
            DataGridView1.Columns(43).Visible = False
            DataGridView1.Columns(44).Visible = False
            DataGridView1.Columns(45).Visible = False
            DataGridView1.Columns(46).Visible = False
            DataGridView1.Columns(47).Visible = False
            DataGridView1.Columns(48).Visible = False
            DataGridView1.Columns(49).Visible = False
            DataGridView1.Columns(50).Visible = False
            DataGridView1.Columns(51).Visible = False
            DataGridView1.Columns(52).Visible = False
            DataGridView1.Columns(53).Visible = False
            DataGridView1.Columns(54).Visible = False
            DataGridView1.Columns(55).Visible = False




        ElseIf Sortbox.Text = "PAGIBIG" Then
            DataGridView1.Columns(1).Visible = True
            DataGridView1.Columns(2).Visible = True
            DataGridView1.Columns(3).Visible = True

            DataGridView1.Columns(4).Visible = False
            DataGridView1.Columns(5).Visible = False
            DataGridView1.Columns(6).Visible = False
            DataGridView1.Columns(7).Visible = False
            DataGridView1.Columns(8).Visible = False
            DataGridView1.Columns(9).Visible = False
            DataGridView1.Columns(10).Visible = False
            DataGridView1.Columns(11).Visible = False
            DataGridView1.Columns(12).Visible = False
            DataGridView1.Columns(13).Visible = False
            DataGridView1.Columns(14).Visible = False
            DataGridView1.Columns(15).Visible = False
            DataGridView1.Columns(16).Visible = False
            DataGridView1.Columns(17).Visible = False
            DataGridView1.Columns(18).Visible = False
            DataGridView1.Columns(19).Visible = False
            DataGridView1.Columns(20).Visible = False
            DataGridView1.Columns(21).Visible = False
            DataGridView1.Columns(22).Visible = False
            DataGridView1.Columns(23).Visible = False
            DataGridView1.Columns(24).Visible = False
            DataGridView1.Columns(25).Visible = False
            DataGridView1.Columns(26).Visible = False
            DataGridView1.Columns(27).Visible = False
            DataGridView1.Columns(28).Visible = False
            DataGridView1.Columns(29).Visible = False
            DataGridView1.Columns(30).Visible = False
            DataGridView1.Columns(31).Visible = False
            DataGridView1.Columns(32).Visible = False
            DataGridView1.Columns(33).Visible = False
            DataGridView1.Columns(34).Visible = False
            DataGridView1.Columns(35).Visible = False
            DataGridView1.Columns(36).Visible = False
            DataGridView1.Columns(37).Visible = False
            DataGridView1.Columns(38).Visible = False
            DataGridView1.Columns(39).Visible = False
            DataGridView1.Columns(40).Visible = False
            DataGridView1.Columns(41).Visible = True
            DataGridView1.Columns(42).Visible = False
            DataGridView1.Columns(43).Visible = False
            DataGridView1.Columns(44).Visible = False
            DataGridView1.Columns(45).Visible = False
            DataGridView1.Columns(46).Visible = False
            DataGridView1.Columns(47).Visible = False
            DataGridView1.Columns(48).Visible = False
            DataGridView1.Columns(49).Visible = False
            DataGridView1.Columns(50).Visible = False
            DataGridView1.Columns(51).Visible = False
            DataGridView1.Columns(52).Visible = False
            DataGridView1.Columns(53).Visible = False
            DataGridView1.Columns(54).Visible = False
            DataGridView1.Columns(55).Visible = False



        ElseIf Sortbox.Text = "Evaluation" Then
            DataGridView1.Columns(1).Visible = True
            DataGridView1.Columns(2).Visible = True
            DataGridView1.Columns(3).Visible = True

            DataGridView1.Columns(4).Visible = False
            DataGridView1.Columns(5).Visible = False
            DataGridView1.Columns(6).Visible = False
            DataGridView1.Columns(7).Visible = False
            DataGridView1.Columns(8).Visible = False
            DataGridView1.Columns(9).Visible = False
            DataGridView1.Columns(10).Visible = False
            DataGridView1.Columns(11).Visible = False
            DataGridView1.Columns(12).Visible = False
            DataGridView1.Columns(13).Visible = False
            DataGridView1.Columns(14).Visible = False
            DataGridView1.Columns(15).Visible = False
            DataGridView1.Columns(16).Visible = False
            DataGridView1.Columns(17).Visible = False
            DataGridView1.Columns(18).Visible = False
            DataGridView1.Columns(19).Visible = False
            DataGridView1.Columns(20).Visible = False
            DataGridView1.Columns(21).Visible = False
            DataGridView1.Columns(22).Visible = False
            DataGridView1.Columns(23).Visible = False
            DataGridView1.Columns(24).Visible = False
            DataGridView1.Columns(25).Visible = False
            DataGridView1.Columns(26).Visible = False
            DataGridView1.Columns(27).Visible = False
            DataGridView1.Columns(28).Visible = False
            DataGridView1.Columns(29).Visible = False
            DataGridView1.Columns(30).Visible = False
            DataGridView1.Columns(31).Visible = False
            DataGridView1.Columns(32).Visible = False
            DataGridView1.Columns(33).Visible = False
            DataGridView1.Columns(34).Visible = False
            DataGridView1.Columns(35).Visible = False
            DataGridView1.Columns(36).Visible = False
            DataGridView1.Columns(37).Visible = False
            DataGridView1.Columns(38).Visible = False
            DataGridView1.Columns(39).Visible = False
            DataGridView1.Columns(40).Visible = False
            DataGridView1.Columns(41).Visible = False
            DataGridView1.Columns(42).Visible = True
            DataGridView1.Columns(43).Visible = False
            DataGridView1.Columns(44).Visible = False
            DataGridView1.Columns(45).Visible = False
            DataGridView1.Columns(46).Visible = False
            DataGridView1.Columns(47).Visible = False
            DataGridView1.Columns(48).Visible = False
            DataGridView1.Columns(49).Visible = False
            DataGridView1.Columns(50).Visible = False
            DataGridView1.Columns(51).Visible = False
            DataGridView1.Columns(52).Visible = False
            DataGridView1.Columns(53).Visible = False
            DataGridView1.Columns(54).Visible = False
            DataGridView1.Columns(55).Visible = False


        ElseIf Sortbox.Text = "Maiden Surname" Then
            DataGridView1.Columns(1).Visible = True
            DataGridView1.Columns(2).Visible = True
            DataGridView1.Columns(3).Visible = True

            DataGridView1.Columns(4).Visible = False
            DataGridView1.Columns(5).Visible = False
            DataGridView1.Columns(6).Visible = False
            DataGridView1.Columns(7).Visible = False
            DataGridView1.Columns(8).Visible = False
            DataGridView1.Columns(9).Visible = False
            DataGridView1.Columns(10).Visible = False
            DataGridView1.Columns(11).Visible = False
            DataGridView1.Columns(12).Visible = False
            DataGridView1.Columns(13).Visible = False
            DataGridView1.Columns(14).Visible = False
            DataGridView1.Columns(15).Visible = False
            DataGridView1.Columns(16).Visible = False
            DataGridView1.Columns(17).Visible = False
            DataGridView1.Columns(18).Visible = False
            DataGridView1.Columns(19).Visible = False
            DataGridView1.Columns(20).Visible = False
            DataGridView1.Columns(21).Visible = False
            DataGridView1.Columns(22).Visible = False
            DataGridView1.Columns(23).Visible = False
            DataGridView1.Columns(24).Visible = False
            DataGridView1.Columns(25).Visible = False
            DataGridView1.Columns(26).Visible = False
            DataGridView1.Columns(27).Visible = False
            DataGridView1.Columns(28).Visible = False
            DataGridView1.Columns(29).Visible = False
            DataGridView1.Columns(30).Visible = False
            DataGridView1.Columns(31).Visible = False
            DataGridView1.Columns(32).Visible = False
            DataGridView1.Columns(33).Visible = False
            DataGridView1.Columns(34).Visible = False
            DataGridView1.Columns(35).Visible = False
            DataGridView1.Columns(36).Visible = False
            DataGridView1.Columns(37).Visible = False
            DataGridView1.Columns(38).Visible = False
            DataGridView1.Columns(39).Visible = False
            DataGridView1.Columns(40).Visible = False
            DataGridView1.Columns(41).Visible = False
            DataGridView1.Columns(42).Visible = False
            DataGridView1.Columns(43).Visible = False
            DataGridView1.Columns(44).Visible = True
            DataGridView1.Columns(45).Visible = False
            DataGridView1.Columns(46).Visible = False
            DataGridView1.Columns(47).Visible = False
            DataGridView1.Columns(48).Visible = False
            DataGridView1.Columns(49).Visible = False
            DataGridView1.Columns(50).Visible = False
            DataGridView1.Columns(51).Visible = False
            DataGridView1.Columns(52).Visible = False
            DataGridView1.Columns(53).Visible = False
            DataGridView1.Columns(54).Visible = False
            DataGridView1.Columns(55).Visible = False



        ElseIf Sortbox.Text = "Maiden Firstname" Then
            DataGridView1.Columns(1).Visible = True
            DataGridView1.Columns(2).Visible = True
            DataGridView1.Columns(3).Visible = True

            DataGridView1.Columns(4).Visible = False
            DataGridView1.Columns(5).Visible = False
            DataGridView1.Columns(6).Visible = False
            DataGridView1.Columns(7).Visible = False
            DataGridView1.Columns(8).Visible = False
            DataGridView1.Columns(9).Visible = False
            DataGridView1.Columns(10).Visible = False
            DataGridView1.Columns(11).Visible = False
            DataGridView1.Columns(12).Visible = False
            DataGridView1.Columns(13).Visible = False
            DataGridView1.Columns(14).Visible = False
            DataGridView1.Columns(15).Visible = False
            DataGridView1.Columns(16).Visible = False
            DataGridView1.Columns(17).Visible = False
            DataGridView1.Columns(18).Visible = False
            DataGridView1.Columns(19).Visible = False
            DataGridView1.Columns(20).Visible = False
            DataGridView1.Columns(21).Visible = False
            DataGridView1.Columns(22).Visible = False
            DataGridView1.Columns(23).Visible = False
            DataGridView1.Columns(24).Visible = False
            DataGridView1.Columns(25).Visible = False
            DataGridView1.Columns(26).Visible = False
            DataGridView1.Columns(27).Visible = False
            DataGridView1.Columns(28).Visible = False
            DataGridView1.Columns(29).Visible = False
            DataGridView1.Columns(30).Visible = False
            DataGridView1.Columns(31).Visible = False
            DataGridView1.Columns(32).Visible = False
            DataGridView1.Columns(33).Visible = False
            DataGridView1.Columns(34).Visible = False
            DataGridView1.Columns(35).Visible = False
            DataGridView1.Columns(36).Visible = False
            DataGridView1.Columns(37).Visible = False
            DataGridView1.Columns(38).Visible = False
            DataGridView1.Columns(39).Visible = False
            DataGridView1.Columns(40).Visible = False
            DataGridView1.Columns(41).Visible = False
            DataGridView1.Columns(42).Visible = False
            DataGridView1.Columns(43).Visible = False
            DataGridView1.Columns(44).Visible = False
            DataGridView1.Columns(45).Visible = True
            DataGridView1.Columns(46).Visible = False
            DataGridView1.Columns(47).Visible = False
            DataGridView1.Columns(48).Visible = False
            DataGridView1.Columns(49).Visible = False
            DataGridView1.Columns(50).Visible = False
            DataGridView1.Columns(51).Visible = False
            DataGridView1.Columns(52).Visible = False
            DataGridView1.Columns(53).Visible = False
            DataGridView1.Columns(54).Visible = False
            DataGridView1.Columns(55).Visible = False



        ElseIf Sortbox.Text = "Maiden Middlename" Then
            DataGridView1.Columns(1).Visible = True
            DataGridView1.Columns(2).Visible = True
            DataGridView1.Columns(3).Visible = True

            DataGridView1.Columns(4).Visible = False
            DataGridView1.Columns(5).Visible = False
            DataGridView1.Columns(6).Visible = False
            DataGridView1.Columns(7).Visible = False
            DataGridView1.Columns(8).Visible = False
            DataGridView1.Columns(9).Visible = False
            DataGridView1.Columns(10).Visible = False
            DataGridView1.Columns(11).Visible = False
            DataGridView1.Columns(12).Visible = False
            DataGridView1.Columns(13).Visible = False
            DataGridView1.Columns(14).Visible = False
            DataGridView1.Columns(15).Visible = False
            DataGridView1.Columns(16).Visible = False
            DataGridView1.Columns(17).Visible = False
            DataGridView1.Columns(18).Visible = False
            DataGridView1.Columns(19).Visible = False
            DataGridView1.Columns(20).Visible = False
            DataGridView1.Columns(21).Visible = False
            DataGridView1.Columns(22).Visible = False
            DataGridView1.Columns(23).Visible = False
            DataGridView1.Columns(24).Visible = False
            DataGridView1.Columns(25).Visible = False
            DataGridView1.Columns(26).Visible = False
            DataGridView1.Columns(27).Visible = False
            DataGridView1.Columns(28).Visible = False
            DataGridView1.Columns(29).Visible = False
            DataGridView1.Columns(30).Visible = False
            DataGridView1.Columns(31).Visible = False
            DataGridView1.Columns(32).Visible = False
            DataGridView1.Columns(33).Visible = False
            DataGridView1.Columns(34).Visible = False
            DataGridView1.Columns(35).Visible = False
            DataGridView1.Columns(36).Visible = False
            DataGridView1.Columns(37).Visible = False
            DataGridView1.Columns(38).Visible = False
            DataGridView1.Columns(39).Visible = False
            DataGridView1.Columns(40).Visible = False
            DataGridView1.Columns(41).Visible = False
            DataGridView1.Columns(42).Visible = False
            DataGridView1.Columns(43).Visible = False
            DataGridView1.Columns(44).Visible = False
            DataGridView1.Columns(45).Visible = False
            DataGridView1.Columns(46).Visible = True
            DataGridView1.Columns(47).Visible = False
            DataGridView1.Columns(48).Visible = False
            DataGridView1.Columns(49).Visible = False
            DataGridView1.Columns(50).Visible = False
            DataGridView1.Columns(51).Visible = False
            DataGridView1.Columns(52).Visible = False
            DataGridView1.Columns(53).Visible = False
            DataGridView1.Columns(54).Visible = False
            DataGridView1.Columns(55).Visible = False


        ElseIf Sortbox.Text = "Rating" Then
            DataGridView1.Columns(1).Visible = True
            DataGridView1.Columns(2).Visible = True
            DataGridView1.Columns(3).Visible = True

            DataGridView1.Columns(4).Visible = False
            DataGridView1.Columns(5).Visible = False
            DataGridView1.Columns(6).Visible = False
            DataGridView1.Columns(7).Visible = False
            DataGridView1.Columns(8).Visible = False
            DataGridView1.Columns(9).Visible = False
            DataGridView1.Columns(10).Visible = False
            DataGridView1.Columns(11).Visible = False
            DataGridView1.Columns(12).Visible = False
            DataGridView1.Columns(13).Visible = False
            DataGridView1.Columns(14).Visible = False
            DataGridView1.Columns(15).Visible = False
            DataGridView1.Columns(16).Visible = False
            DataGridView1.Columns(17).Visible = False
            DataGridView1.Columns(18).Visible = False
            DataGridView1.Columns(19).Visible = False
            DataGridView1.Columns(20).Visible = False
            DataGridView1.Columns(21).Visible = False
            DataGridView1.Columns(22).Visible = False
            DataGridView1.Columns(23).Visible = False
            DataGridView1.Columns(24).Visible = False
            DataGridView1.Columns(25).Visible = False
            DataGridView1.Columns(26).Visible = False
            DataGridView1.Columns(27).Visible = False
            DataGridView1.Columns(28).Visible = False
            DataGridView1.Columns(29).Visible = False
            DataGridView1.Columns(30).Visible = False
            DataGridView1.Columns(31).Visible = False
            DataGridView1.Columns(32).Visible = False
            DataGridView1.Columns(33).Visible = False
            DataGridView1.Columns(34).Visible = False
            DataGridView1.Columns(35).Visible = False
            DataGridView1.Columns(36).Visible = False
            DataGridView1.Columns(37).Visible = False
            DataGridView1.Columns(38).Visible = False
            DataGridView1.Columns(39).Visible = False
            DataGridView1.Columns(40).Visible = False
            DataGridView1.Columns(41).Visible = False
            DataGridView1.Columns(42).Visible = False
            DataGridView1.Columns(43).Visible = False
            DataGridView1.Columns(44).Visible = False
            DataGridView1.Columns(45).Visible = False
            DataGridView1.Columns(46).Visible = False
            DataGridView1.Columns(47).Visible = True
            DataGridView1.Columns(48).Visible = False
            DataGridView1.Columns(49).Visible = False
            DataGridView1.Columns(50).Visible = False
            DataGridView1.Columns(51).Visible = False
            DataGridView1.Columns(52).Visible = False
            DataGridView1.Columns(53).Visible = False
            DataGridView1.Columns(54).Visible = False
            DataGridView1.Columns(55).Visible = False


        ElseIf Sortbox.Text = "Evaluation Rating" Then
            DataGridView1.Columns(1).Visible = True
            DataGridView1.Columns(2).Visible = True
            DataGridView1.Columns(3).Visible = True

            DataGridView1.Columns(4).Visible = False
            DataGridView1.Columns(5).Visible = False
            DataGridView1.Columns(6).Visible = False
            DataGridView1.Columns(7).Visible = False
            DataGridView1.Columns(8).Visible = False
            DataGridView1.Columns(9).Visible = False
            DataGridView1.Columns(10).Visible = False
            DataGridView1.Columns(11).Visible = False
            DataGridView1.Columns(12).Visible = False
            DataGridView1.Columns(13).Visible = False
            DataGridView1.Columns(14).Visible = False
            DataGridView1.Columns(15).Visible = False
            DataGridView1.Columns(16).Visible = False
            DataGridView1.Columns(17).Visible = False
            DataGridView1.Columns(18).Visible = False
            DataGridView1.Columns(19).Visible = False
            DataGridView1.Columns(20).Visible = False
            DataGridView1.Columns(21).Visible = False
            DataGridView1.Columns(22).Visible = False
            DataGridView1.Columns(23).Visible = False
            DataGridView1.Columns(24).Visible = False
            DataGridView1.Columns(25).Visible = False
            DataGridView1.Columns(26).Visible = False
            DataGridView1.Columns(27).Visible = False
            DataGridView1.Columns(28).Visible = False
            DataGridView1.Columns(29).Visible = False
            DataGridView1.Columns(30).Visible = False
            DataGridView1.Columns(31).Visible = False
            DataGridView1.Columns(32).Visible = False
            DataGridView1.Columns(33).Visible = False
            DataGridView1.Columns(34).Visible = False
            DataGridView1.Columns(35).Visible = False
            DataGridView1.Columns(36).Visible = False
            DataGridView1.Columns(37).Visible = False
            DataGridView1.Columns(38).Visible = False
            DataGridView1.Columns(39).Visible = False
            DataGridView1.Columns(40).Visible = False
            DataGridView1.Columns(41).Visible = False
            DataGridView1.Columns(42).Visible = False
            DataGridView1.Columns(43).Visible = False
            DataGridView1.Columns(44).Visible = False
            DataGridView1.Columns(45).Visible = False
            DataGridView1.Columns(46).Visible = False
            DataGridView1.Columns(47).Visible = False
            DataGridView1.Columns(48).Visible = True
            DataGridView1.Columns(49).Visible = False
            DataGridView1.Columns(50).Visible = False
            DataGridView1.Columns(51).Visible = False
            DataGridView1.Columns(52).Visible = False
            DataGridView1.Columns(53).Visible = False
            DataGridView1.Columns(54).Visible = False
            DataGridView1.Columns(55).Visible = False

        ElseIf Sortbox.Text = "Sanctions" Then
            DataGridView1.Columns(1).Visible = True
            DataGridView1.Columns(2).Visible = True
            DataGridView1.Columns(3).Visible = True

            DataGridView1.Columns(4).Visible = False
            DataGridView1.Columns(5).Visible = False
            DataGridView1.Columns(6).Visible = False
            DataGridView1.Columns(7).Visible = False
            DataGridView1.Columns(8).Visible = False
            DataGridView1.Columns(9).Visible = False
            DataGridView1.Columns(10).Visible = False
            DataGridView1.Columns(11).Visible = False
            DataGridView1.Columns(12).Visible = False
            DataGridView1.Columns(13).Visible = False
            DataGridView1.Columns(14).Visible = False
            DataGridView1.Columns(15).Visible = False
            DataGridView1.Columns(16).Visible = False
            DataGridView1.Columns(17).Visible = False
            DataGridView1.Columns(18).Visible = False
            DataGridView1.Columns(19).Visible = False
            DataGridView1.Columns(20).Visible = False
            DataGridView1.Columns(21).Visible = False
            DataGridView1.Columns(22).Visible = False
            DataGridView1.Columns(23).Visible = False
            DataGridView1.Columns(24).Visible = False
            DataGridView1.Columns(25).Visible = False
            DataGridView1.Columns(26).Visible = False
            DataGridView1.Columns(27).Visible = False
            DataGridView1.Columns(28).Visible = False
            DataGridView1.Columns(29).Visible = False
            DataGridView1.Columns(30).Visible = False
            DataGridView1.Columns(31).Visible = False
            DataGridView1.Columns(32).Visible = False
            DataGridView1.Columns(33).Visible = False
            DataGridView1.Columns(34).Visible = False
            DataGridView1.Columns(35).Visible = False
            DataGridView1.Columns(36).Visible = False
            DataGridView1.Columns(37).Visible = False
            DataGridView1.Columns(38).Visible = False
            DataGridView1.Columns(39).Visible = False
            DataGridView1.Columns(40).Visible = False
            DataGridView1.Columns(41).Visible = False
            DataGridView1.Columns(42).Visible = False
            DataGridView1.Columns(43).Visible = False
            DataGridView1.Columns(44).Visible = False
            DataGridView1.Columns(45).Visible = False
            DataGridView1.Columns(46).Visible = False
            DataGridView1.Columns(47).Visible = False
            DataGridView1.Columns(48).Visible = False
            DataGridView1.Columns(49).Visible = True
            DataGridView1.Columns(50).Visible = False
            DataGridView1.Columns(51).Visible = False
            DataGridView1.Columns(52).Visible = False
            DataGridView1.Columns(53).Visible = False
            DataGridView1.Columns(54).Visible = False
            DataGridView1.Columns(55).Visible = False



        ElseIf Sortbox.Text = "Sanction Number" Then
            DataGridView1.Columns(1).Visible = True
            DataGridView1.Columns(2).Visible = True
            DataGridView1.Columns(3).Visible = True

            DataGridView1.Columns(4).Visible = False
            DataGridView1.Columns(5).Visible = False
            DataGridView1.Columns(6).Visible = False
            DataGridView1.Columns(7).Visible = False
            DataGridView1.Columns(8).Visible = False
            DataGridView1.Columns(9).Visible = False
            DataGridView1.Columns(10).Visible = False
            DataGridView1.Columns(11).Visible = False
            DataGridView1.Columns(12).Visible = False
            DataGridView1.Columns(13).Visible = False
            DataGridView1.Columns(14).Visible = False
            DataGridView1.Columns(15).Visible = False
            DataGridView1.Columns(16).Visible = False
            DataGridView1.Columns(17).Visible = False
            DataGridView1.Columns(18).Visible = False
            DataGridView1.Columns(19).Visible = False
            DataGridView1.Columns(20).Visible = False
            DataGridView1.Columns(21).Visible = False
            DataGridView1.Columns(22).Visible = False
            DataGridView1.Columns(23).Visible = False
            DataGridView1.Columns(24).Visible = False
            DataGridView1.Columns(25).Visible = False
            DataGridView1.Columns(26).Visible = False
            DataGridView1.Columns(27).Visible = False
            DataGridView1.Columns(28).Visible = False
            DataGridView1.Columns(29).Visible = False
            DataGridView1.Columns(30).Visible = False
            DataGridView1.Columns(31).Visible = False
            DataGridView1.Columns(32).Visible = False
            DataGridView1.Columns(33).Visible = False
            DataGridView1.Columns(34).Visible = False
            DataGridView1.Columns(35).Visible = False
            DataGridView1.Columns(36).Visible = False
            DataGridView1.Columns(37).Visible = False
            DataGridView1.Columns(38).Visible = False
            DataGridView1.Columns(39).Visible = False
            DataGridView1.Columns(40).Visible = False
            DataGridView1.Columns(41).Visible = False
            DataGridView1.Columns(42).Visible = False
            DataGridView1.Columns(43).Visible = False
            DataGridView1.Columns(44).Visible = False
            DataGridView1.Columns(45).Visible = False
            DataGridView1.Columns(46).Visible = False
            DataGridView1.Columns(47).Visible = False
            DataGridView1.Columns(48).Visible = False
            DataGridView1.Columns(49).Visible = False
            DataGridView1.Columns(50).Visible = True
            DataGridView1.Columns(51).Visible = False
            DataGridView1.Columns(52).Visible = False
            DataGridView1.Columns(53).Visible = False
            DataGridView1.Columns(54).Visible = False
            DataGridView1.Columns(55).Visible = False




        ElseIf Sortbox.Text = "Leave Credit" Then
            DataGridView1.Columns(1).Visible = True
            DataGridView1.Columns(2).Visible = True
            DataGridView1.Columns(3).Visible = True

            DataGridView1.Columns(4).Visible = False
            DataGridView1.Columns(5).Visible = False
            DataGridView1.Columns(6).Visible = False
            DataGridView1.Columns(7).Visible = False
            DataGridView1.Columns(8).Visible = False
            DataGridView1.Columns(9).Visible = False
            DataGridView1.Columns(10).Visible = False
            DataGridView1.Columns(11).Visible = False
            DataGridView1.Columns(12).Visible = False
            DataGridView1.Columns(13).Visible = False
            DataGridView1.Columns(14).Visible = False
            DataGridView1.Columns(15).Visible = False
            DataGridView1.Columns(16).Visible = False
            DataGridView1.Columns(17).Visible = False
            DataGridView1.Columns(18).Visible = False
            DataGridView1.Columns(19).Visible = False
            DataGridView1.Columns(20).Visible = False
            DataGridView1.Columns(21).Visible = False
            DataGridView1.Columns(22).Visible = False
            DataGridView1.Columns(23).Visible = False
            DataGridView1.Columns(24).Visible = False
            DataGridView1.Columns(25).Visible = False
            DataGridView1.Columns(26).Visible = False
            DataGridView1.Columns(27).Visible = False
            DataGridView1.Columns(28).Visible = False
            DataGridView1.Columns(29).Visible = False
            DataGridView1.Columns(30).Visible = False
            DataGridView1.Columns(31).Visible = False
            DataGridView1.Columns(32).Visible = False
            DataGridView1.Columns(33).Visible = False
            DataGridView1.Columns(34).Visible = False
            DataGridView1.Columns(35).Visible = False
            DataGridView1.Columns(36).Visible = False
            DataGridView1.Columns(37).Visible = False
            DataGridView1.Columns(38).Visible = False
            DataGridView1.Columns(39).Visible = False
            DataGridView1.Columns(40).Visible = False
            DataGridView1.Columns(41).Visible = False
            DataGridView1.Columns(42).Visible = False
            DataGridView1.Columns(43).Visible = False
            DataGridView1.Columns(44).Visible = False
            DataGridView1.Columns(45).Visible = False
            DataGridView1.Columns(46).Visible = False
            DataGridView1.Columns(47).Visible = False
            DataGridView1.Columns(48).Visible = False
            DataGridView1.Columns(49).Visible = False
            DataGridView1.Columns(50).Visible = False
            DataGridView1.Columns(51).Visible = True
            DataGridView1.Columns(52).Visible = False
            DataGridView1.Columns(53).Visible = False
            DataGridView1.Columns(54).Visible = False
            DataGridView1.Columns(55).Visible = False



        ElseIf Sortbox.Text = "Sick Leave" Then
            DataGridView1.Columns(1).Visible = True
            DataGridView1.Columns(2).Visible = True
            DataGridView1.Columns(3).Visible = True

            DataGridView1.Columns(4).Visible = False
            DataGridView1.Columns(5).Visible = False
            DataGridView1.Columns(6).Visible = False
            DataGridView1.Columns(7).Visible = False
            DataGridView1.Columns(8).Visible = False
            DataGridView1.Columns(9).Visible = False
            DataGridView1.Columns(10).Visible = False
            DataGridView1.Columns(11).Visible = False
            DataGridView1.Columns(12).Visible = False
            DataGridView1.Columns(13).Visible = False
            DataGridView1.Columns(14).Visible = False
            DataGridView1.Columns(15).Visible = False
            DataGridView1.Columns(16).Visible = False
            DataGridView1.Columns(17).Visible = False
            DataGridView1.Columns(18).Visible = False
            DataGridView1.Columns(19).Visible = False
            DataGridView1.Columns(20).Visible = False
            DataGridView1.Columns(21).Visible = False
            DataGridView1.Columns(22).Visible = False
            DataGridView1.Columns(23).Visible = False
            DataGridView1.Columns(24).Visible = False
            DataGridView1.Columns(25).Visible = False
            DataGridView1.Columns(26).Visible = False
            DataGridView1.Columns(27).Visible = False
            DataGridView1.Columns(28).Visible = False
            DataGridView1.Columns(29).Visible = False
            DataGridView1.Columns(30).Visible = False
            DataGridView1.Columns(31).Visible = False
            DataGridView1.Columns(32).Visible = False
            DataGridView1.Columns(33).Visible = False
            DataGridView1.Columns(34).Visible = False
            DataGridView1.Columns(35).Visible = False
            DataGridView1.Columns(36).Visible = False
            DataGridView1.Columns(37).Visible = False
            DataGridView1.Columns(38).Visible = False
            DataGridView1.Columns(39).Visible = False
            DataGridView1.Columns(40).Visible = False
            DataGridView1.Columns(41).Visible = False
            DataGridView1.Columns(42).Visible = False
            DataGridView1.Columns(43).Visible = False
            DataGridView1.Columns(44).Visible = False
            DataGridView1.Columns(45).Visible = False
            DataGridView1.Columns(46).Visible = False
            DataGridView1.Columns(47).Visible = False
            DataGridView1.Columns(48).Visible = False
            DataGridView1.Columns(49).Visible = False
            DataGridView1.Columns(50).Visible = False
            DataGridView1.Columns(51).Visible = False
            DataGridView1.Columns(52).Visible = True
            DataGridView1.Columns(53).Visible = False
            DataGridView1.Columns(54).Visible = False
            DataGridView1.Columns(55).Visible = False


        ElseIf Sortbox.Text = "Vacation Leave" Then
            DataGridView1.Columns(1).Visible = True
            DataGridView1.Columns(2).Visible = True
            DataGridView1.Columns(3).Visible = True

            DataGridView1.Columns(4).Visible = False
            DataGridView1.Columns(5).Visible = False
            DataGridView1.Columns(6).Visible = False
            DataGridView1.Columns(7).Visible = False
            DataGridView1.Columns(8).Visible = False
            DataGridView1.Columns(9).Visible = False
            DataGridView1.Columns(10).Visible = False
            DataGridView1.Columns(11).Visible = False
            DataGridView1.Columns(12).Visible = False
            DataGridView1.Columns(13).Visible = False
            DataGridView1.Columns(14).Visible = False
            DataGridView1.Columns(15).Visible = False
            DataGridView1.Columns(16).Visible = False
            DataGridView1.Columns(17).Visible = False
            DataGridView1.Columns(18).Visible = False
            DataGridView1.Columns(19).Visible = False
            DataGridView1.Columns(20).Visible = False
            DataGridView1.Columns(21).Visible = False
            DataGridView1.Columns(22).Visible = False
            DataGridView1.Columns(23).Visible = False
            DataGridView1.Columns(24).Visible = False
            DataGridView1.Columns(25).Visible = False
            DataGridView1.Columns(26).Visible = False
            DataGridView1.Columns(27).Visible = False
            DataGridView1.Columns(28).Visible = False
            DataGridView1.Columns(29).Visible = False
            DataGridView1.Columns(30).Visible = False
            DataGridView1.Columns(31).Visible = False
            DataGridView1.Columns(32).Visible = False
            DataGridView1.Columns(33).Visible = False
            DataGridView1.Columns(34).Visible = False
            DataGridView1.Columns(35).Visible = False
            DataGridView1.Columns(36).Visible = False
            DataGridView1.Columns(37).Visible = False
            DataGridView1.Columns(38).Visible = False
            DataGridView1.Columns(39).Visible = False
            DataGridView1.Columns(40).Visible = False
            DataGridView1.Columns(41).Visible = False
            DataGridView1.Columns(42).Visible = False
            DataGridView1.Columns(43).Visible = False
            DataGridView1.Columns(44).Visible = False
            DataGridView1.Columns(45).Visible = False
            DataGridView1.Columns(46).Visible = False
            DataGridView1.Columns(47).Visible = False
            DataGridView1.Columns(48).Visible = False
            DataGridView1.Columns(49).Visible = False
            DataGridView1.Columns(50).Visible = False
            DataGridView1.Columns(51).Visible = False
            DataGridView1.Columns(52).Visible = False
            DataGridView1.Columns(53).Visible = True
            DataGridView1.Columns(54).Visible = False
            DataGridView1.Columns(55).Visible = False





        ElseIf Sortbox.Text = "As Of" Then
            DataGridView1.Columns(1).Visible = True
            DataGridView1.Columns(2).Visible = True
            DataGridView1.Columns(3).Visible = True

            DataGridView1.Columns(4).Visible = False
            DataGridView1.Columns(5).Visible = False
            DataGridView1.Columns(6).Visible = False
            DataGridView1.Columns(7).Visible = False
            DataGridView1.Columns(8).Visible = False
            DataGridView1.Columns(9).Visible = False
            DataGridView1.Columns(10).Visible = False
            DataGridView1.Columns(11).Visible = False
            DataGridView1.Columns(12).Visible = False
            DataGridView1.Columns(13).Visible = False
            DataGridView1.Columns(14).Visible = False
            DataGridView1.Columns(15).Visible = False
            DataGridView1.Columns(16).Visible = False
            DataGridView1.Columns(17).Visible = False
            DataGridView1.Columns(18).Visible = False
            DataGridView1.Columns(19).Visible = False
            DataGridView1.Columns(20).Visible = False
            DataGridView1.Columns(21).Visible = False
            DataGridView1.Columns(22).Visible = False
            DataGridView1.Columns(23).Visible = False
            DataGridView1.Columns(24).Visible = False
            DataGridView1.Columns(25).Visible = False
            DataGridView1.Columns(26).Visible = False
            DataGridView1.Columns(27).Visible = False
            DataGridView1.Columns(28).Visible = False
            DataGridView1.Columns(29).Visible = False
            DataGridView1.Columns(30).Visible = False
            DataGridView1.Columns(31).Visible = False
            DataGridView1.Columns(32).Visible = False
            DataGridView1.Columns(33).Visible = False
            DataGridView1.Columns(34).Visible = False
            DataGridView1.Columns(35).Visible = False
            DataGridView1.Columns(36).Visible = False
            DataGridView1.Columns(37).Visible = False
            DataGridView1.Columns(38).Visible = False
            DataGridView1.Columns(39).Visible = False
            DataGridView1.Columns(40).Visible = False
            DataGridView1.Columns(41).Visible = False
            DataGridView1.Columns(42).Visible = False
            DataGridView1.Columns(43).Visible = False
            DataGridView1.Columns(44).Visible = False
            DataGridView1.Columns(45).Visible = False
            DataGridView1.Columns(46).Visible = False
            DataGridView1.Columns(47).Visible = False
            DataGridView1.Columns(48).Visible = False
            DataGridView1.Columns(49).Visible = False
            DataGridView1.Columns(50).Visible = False
            DataGridView1.Columns(51).Visible = False
            DataGridView1.Columns(52).Visible = False
            DataGridView1.Columns(53).Visible = False
            DataGridView1.Columns(54).Visible = True
            DataGridView1.Columns(55).Visible = False



        End If
    End Sub

    Private Sub Showdataview_Click(sender As Object, e As EventArgs) Handles Showdataview.Click
        DataGridView1.Columns(1).Visible = True
        DataGridView1.Columns(2).Visible = True
        DataGridView1.Columns(3).Visible = True

        DataGridView1.Columns(4).Visible = True
        DataGridView1.Columns(5).Visible = True
        DataGridView1.Columns(6).Visible = True
        DataGridView1.Columns(7).Visible = True
        DataGridView1.Columns(8).Visible = True
        DataGridView1.Columns(9).Visible = True
        DataGridView1.Columns(10).Visible = True
        DataGridView1.Columns(11).Visible = True
        DataGridView1.Columns(12).Visible = True
        DataGridView1.Columns(13).Visible = True
        DataGridView1.Columns(14).Visible = True
        DataGridView1.Columns(15).Visible = True
        DataGridView1.Columns(16).Visible = True
        DataGridView1.Columns(17).Visible = True
        DataGridView1.Columns(18).Visible = True
        DataGridView1.Columns(19).Visible = True
        DataGridView1.Columns(20).Visible = True
        DataGridView1.Columns(21).Visible = True
        DataGridView1.Columns(22).Visible = True
        DataGridView1.Columns(23).Visible = True
        DataGridView1.Columns(24).Visible = True
        DataGridView1.Columns(25).Visible = True
        DataGridView1.Columns(26).Visible = True
        DataGridView1.Columns(27).Visible = True
        DataGridView1.Columns(28).Visible = True
        DataGridView1.Columns(29).Visible = True
        DataGridView1.Columns(30).Visible = True
        DataGridView1.Columns(31).Visible = True
        DataGridView1.Columns(32).Visible = True
        DataGridView1.Columns(33).Visible = True
        DataGridView1.Columns(34).Visible = True
        DataGridView1.Columns(35).Visible = True
        DataGridView1.Columns(36).Visible = True
        DataGridView1.Columns(37).Visible = True
        DataGridView1.Columns(38).Visible = True
        DataGridView1.Columns(39).Visible = True
        DataGridView1.Columns(40).Visible = True
        DataGridView1.Columns(41).Visible = True
        DataGridView1.Columns(42).Visible = True
        DataGridView1.Columns(43).Visible = True
        DataGridView1.Columns(44).Visible = True
        DataGridView1.Columns(45).Visible = True
        DataGridView1.Columns(46).Visible = True
        DataGridView1.Columns(47).Visible = True
        DataGridView1.Columns(48).Visible = True
        DataGridView1.Columns(49).Visible = True
        DataGridView1.Columns(50).Visible = True
        DataGridView1.Columns(51).Visible = True
        DataGridView1.Columns(52).Visible = True
        DataGridView1.Columns(53).Visible = True
        DataGridView1.Columns(54).Visible = True
        DataGridView1.Columns(55).Visible = True

    End Sub

    Private Sub View1_Click(sender As Object, e As EventArgs) Handles View1.Click
        Dim word As Word.Application
        Dim doc As Word.Document
        word = CreateObject("Word.Application")
        Dim path As String = Application.StartupPath & ""
        doc = word.Documents.Open(path)
        word.Visible = True
    End Sub

    Private Sub View2_Click(sender As Object, e As EventArgs) Handles View2.Click
        'Dim word As Word.Application
        'Dim doc As Word.Document
        'word = CreateObject("Word.Application")
        'Dim path As String = Application.StartupPath & ""
        'doc = word.Documents.Open(path)
        'word.Visible = True
    End Sub

    Private Sub View3_Click(sender As Object, e As EventArgs) Handles View3.Click
        'Dim word As Word.Application
        'Dim doc As Word.Document
        'word = CreateObject("Word.Application")
        'Dim path As String  = Application.StartupPath & ""
        'doc = word.Documents.Open(path)
        'word.Visible = True
    End Sub
End Class