Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports System.Configuration
Imports System.IO
Imports Microsoft.Office.Interop.Word
Imports Microsoft.Office.Interop

Public Class EmployeeAdd

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

    Private Sub EmployeeAdd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CentroMedicoDSRDataSet.EmployeeDetails' table. You can move, or remove it, as needed.
        ' Me.EmployeeDetailsTableAdapter.Fill(Me.CentroMedicoDSRDataSet.EmployeeDetails)
        'TODO: This line of code loads data into the 'CentroMedicoDSRDataSet1.EmployeeDetails' table. You can move, or remove it, as needed.
        'Me.EmployeeDetailsTableAdapter.Fill(Me.CentroMedicoDSRDataSet1.EmployeeDetails)
        'TODO: This line of code loads data into the 'CentroMedicoDSRDataSet.EmployeeDetails' table. You can move, or remove it, as needed.

        'Me.EmployeeDetailsTableAdapter.Fill(Me.CentroMedicoDSRDataSet.EmployeeDetails)
        'User.Text = Homepage.ToolStripStatusLabel1.Text
        'Place.Text = "Employee Adding"
        'Timer1.Start()

        Me.EmployeeDetailsTableAdapter.Fill(Me.CentroMedicoDSRDataSet.EmployeeDetails)
        Timer1.Start()
        If SuperAdminHomepage.ToolStripStatusLabelAdmin.Text = SuperAdminHomepage.User.Text Then
            User.Text = "SuperAdmin"
            Place.Text = "Employee Adding"
            ' Timer1.Start()
        ElseIf Homepage.User.Text = Homepage.ToolStripStatusLabel1.Text Then
            User.Text = "Admin"
            Place.Text = "Employee Adding"

        End If
    End Sub

    Private Sub ButtonNew_Click(sender As Object, e As EventArgs) Handles ButtonNew.Click
        EmployeeDetailsBindingSource.AddNew()
        Status.Text = "Added an employee info"

        SaveStus()
    End Sub


    Private Sub ButtonSave_Click(sender As Object, e As EventArgs) Handles ButtonSave.Click

        'SUBSTITUTE CODE FOR PREVENTING EMPTY TEXTBOXES

        Dim txt As Control '= MsgBox("FILL UP ALL DATA *", MessageBoxIcon.Error)


        For Each txt In GroupBox1.Controls

            If TypeOf txt Is TextBox Then
                If Lname.Text = "" Then
                    txt.Focus()

                ElseIf Fname.Text = "" Then
                    txt.Focus()
                ElseIf Mname.Text = "" Then
                    txt.Focus()
                ElseIf Sex.Text = "" Then
                    txt.Focus()
                ElseIf Contactno.Text = "" Then
                    txt.Focus()
                ElseIf PickerBirthday.Text = "" Then
                    txt.Focus()
                ElseIf CivilStat.Text = "" Then
                    txt.Focus()
                ElseIf Email.Text = "" Then
                    txt.Focus()
                ElseIf Hno.Text = "" Then
                    txt.Focus()
                ElseIf Hst.Text = "" Then
                    txt.Focus()
                ElseIf Hbar.Text = "" Then
                    txt.Focus()
                ElseIf Htown.Text = "" Then
                    txt.Focus()
                ElseIf Hprov.Text = "" Then
                    txt.Focus()
                ElseIf Hzip.Text = "" Then
                    txt.Focus()
                ElseIf Cno.Text = "" Then
                    txt.Focus()
                ElseIf Cst.Text = "" Then
                    txt.Focus()
                ElseIf Cbar.Text = "" Then
                    txt.Focus()
                ElseIf Ctown.Text = "" Then
                    txt.Focus()
                ElseIf Cprov.Text = "" Then
                    txt.Focus()
                ElseIf Czip.Text = "" Then
                    txt.Focus()
                ElseIf UMID.Text = "" Then
                    txt.Focus()
                ElseIf SSS.Text = "" Then
                    txt.Focus()
                ElseIf Philhealth.Text = "" Then
                    txt.Focus()
                ElseIf TIN.Text = "" Then
                    txt.Focus()
                ElseIf PAGIBIG.Text = "" Then
                    txt.Focus()
                ElseIf Position.Text = "" Then
                    txt.Focus()
                ElseIf Department.Text = "" Then
                    txt.Focus()
                ElseIf Division.Text = "" Then
                    txt.Focus()
                ElseIf Status.Text = "" Then
                    txt.Focus()
                ElseIf Licenseno.Text = "" Then
                    txt.Focus()
                ElseIf Certno.Text = "" Then
                    txt.Focus()
                ElseIf TextBox4.Text = "" Then
                    txt.Focus()
                ElseIf PickerHired.Text = "" Then
                    txt.Focus()
                ElseIf EducAttain.Text = "" Then
                    txt.Focus()
                ElseIf Univcol.Text = "" Then
                    txt.Focus()
                ElseIf Program.Text = "" Then
                    txt.Focus()


                ElseIf DialogResult.OK Then
                    EmployeeDetailsBindingSource.EndEdit()
                    EmployeeDetailsTableAdapter.Update(CentroMedicoDSRDataSet.EmployeeDetails)


                    Status.Text = "Saved an employee info"
                    SaveStus()

                    MsgBox("Record successfully saved.", MsgBoxStyle.OkOnly)
                    Exit Sub

                End If
            End If

            ' Else

            'EmployeeDetailsBindingSource.EndEdit()
            'EmployeeDetailsTableAdapter.Update(CentroMedicoDSRDataSet.EmployeeDetails)

            'Status.Text = "Admin saved employee info"
            'SaveStus()
            'End If

        Next

        'If Lname.Text & Fname.Text & Mname.Text & Sex.Text & Contactno.Text & CivilStat.Text & Email.Text & Hno.Text & Hst.Text & Hbar.Text & Htown.Text & Hprov.Text & Hzip.Text & Cno.Text & Cst.Text & Cbar.Text & Ctown.Text & Cprov.Text & Czip.Text & UMID.Text & SSS.Text & Philhealth.Text & PAGIBIG.Text & TIN.Text & Position.Text & Division.Text & Department.Text & ComboStatus.Text & Licenseno.Text & Certno.Text & TextBox4.Text & rat.Text & Age.Text = "" Then
        '    MsgBox("Fill all the textboxes!")

        'Else
        '    EmployeeDetailsBindingSource.EndEdit()
        '    EmployeeDetailsTableAdapter.Update(CentroMedicoDSRDataSet.EmployeeDetails)
        'End If


    End Sub

    Private Sub ButtonDelete_Click(sender As Object, e As EventArgs) Handles ButtonDelete.Click
        EmployeeDetailsBindingSource.RemoveCurrent()
        Status.Text = "Deleted an employee info"

        SaveStus()
    End Sub





    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Records.Show()
        Me.Hide()
    End Sub

    Private Sub Browse_Click(sender As Object, e As EventArgs) Handles Browse.Click
        OpenFileDialog1.Filter = "JPEG FILE | *.jpeg |PNG FILE |*.png|JPG FILE | *.JPG "
        OpenFileDialog1.ShowDialog()
        PictureBox.Text = OpenFileDialog1.FileName
    End Sub



    Private Sub PictureBox_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub PickerBirthday_ValueChanged(sender As Object, e As EventArgs)

    End Sub



    Private Sub ToolStripStatusLabel1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ToolStripLabel3_Click(sender As Object, e As EventArgs)
        Dim result As Integer = MsgBox("Are you sure you want to Log Out?", MsgBoxStyle.YesNo)
        If result = DialogResult.No Then
        ElseIf result = DialogResult.Yes Then

            LoginForm.Show()
            Me.Close()
        End If
    End Sub

    Private Sub ToolStripLabel1_Click(sender As Object, e As EventArgs)
        Records.Show()
        Me.Close()
    End Sub

    Private Sub SearchToolStripButton_Click(sender As Object, e As EventArgs)
        'Try
        '    Me.EmployeeDetailsTableAdapter.Search(Me.CentroMedicoDSRDataSet.EmployeeDetails, SurnameToolStripTextBox.Text)
        'Catch ex As System.Exception
        '    System.Windows.Forms.MessageBox.Show(ex.Message)
        'End Try

    End Sub

    Private Sub Search1ToolStripButton_Click(sender As Object, e As EventArgs)
        'Try
        '    Me.EmployeeDetailsTableAdapter.Search1(Me.CentroMedicoDSRDataSet.EmployeeDetails, FirstnameToolStripTextBox.Text)
        'Catch ex As System.Exception
        '    System.Windows.Forms.MessageBox.Show(ex.Message)
        'End Try

    End Sub

    Private Sub Search2ToolStripButton_Click(sender As Object, e As EventArgs)
        'Try
        '    Me.EmployeeDetailsTableAdapter.Search2(Me.CentroMedicoDSRDataSet.EmployeeDetails, SurnameToolStripTextBox.Text, FirstnameToolStripTextBox.Text, MiddlenameToolStripTextBox.Text)
        'Catch ex As System.Exception
        '    System.Windows.Forms.MessageBox.Show(ex.Message)
        'End Try

    End Sub

    Private Sub HScrollBar1_Scroll(sender As Object, e As ScrollEventArgs) Handles HScrollBar1.Scroll


        rat.Text = HScrollBar1.Value
    End Sub

    Private Sub HScrollBar2_Scroll(sender As Object, e As ScrollEventArgs) Handles HScrollBar2.Scroll
        evalrat.Text = HScrollBar2.Value
    End Sub

    Private Sub Hst_SelectedIndexChanged(sender As Object, e As EventArgs)
        Dim int As Integer
        Val(int)

        Hst.Text = Cst.Text
    End Sub

    Private Sub HBar_SelectedIndexChanged(sender As Object, e As EventArgs)
        Hbar.Text = Cbar.Text
    End Sub

    Private Sub HTown_SelectedIndexChanged(sender As Object, e As EventArgs)
        Htown.Text = Ctown.Text
    End Sub

    Private Sub HProv_SelectedIndexChanged(sender As Object, e As EventArgs)
        Hprov.Text = Cprov.Text
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

    Private Sub Cst_SelectedIndexChanged(sender As Object, e As EventArgs)
        'If Hst.Text = "Bataan" Then
        '    Cst.Text = "Balanga" Or "Limay"

        'End If
        ' Dim cn As New SqlClient.SqlConnection("Data Source=localhost;Initial Catalog=SRRY;Integrated Security=True")
    End Sub



    Private Sub EmployeeDetailsBindingSource_CurrentChanged(sender As Object, e As EventArgs)

    End Sub

    'Way to go to edit form


    'Private Sub DataGridView1_Click(sender As Object, e As EventArgs) Handles DataGridView1.Click
    '    Dim form As New EditEmployee

    '    form.Lname.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString()
    '    form.Fname.Text = DataGridView1.CurrentRow.Cells(2).Value.ToString()
    '    form.Mname.Text = DataGridView1.CurrentRow.Cells(3).Value.ToString()
    '    form.Hno.Text = DataGridView1.CurrentRow.Cells(4).Value.ToString()
    '    form.Hst.Text = DataGridView1.CurrentRow.Cells(5).Value.ToString()
    '    form.Hbar.Text = DataGridView1.CurrentRow.Cells(6).Value.ToString()
    '    form.Htown.Text = DataGridView1.CurrentRow.Cells(7).Value.ToString()
    '    form.Hprov.Text = DataGridView1.CurrentRow.Cells(8).Value.ToString()
    '    form.Hzip.Text = DataGridView1.CurrentRow.Cells(9).Value.ToString()
    '    form.Cno.Text = DataGridView1.CurrentRow.Cells(10).Value.ToString()
    '    form.Cst.Text = DataGridView1.CurrentRow.Cells(11).Value.ToString()
    '    form.Cbar.Text = DataGridView1.CurrentRow.Cells(12).Value.ToString()
    '    form.Ctown.Text = DataGridView1.CurrentRow.Cells(13).Value.ToString()
    '    form.Cprov.Text = DataGridView1.CurrentRow.Cells(14).Value.ToString()
    '    form.Czip.Text = DataGridView1.CurrentRow.Cells(15).Value.ToString()
    '    form.Sex.Text = DataGridView1.CurrentRow.Cells(16).Value.ToString()
    '    form.Age.Text = DataGridView1.CurrentRow.Cells(17).Value.ToString()
    '    form.CivilStat.Text = DataGridView1.CurrentRow.Cells(18).Value.ToString()
    '    form.PickerBirthday.Text = DataGridView1.CurrentRow.Cells(19).Value.ToString()
    '    form.Email.Text = DataGridView1.CurrentRow.Cells(20).Value.ToString()
    '    form.Contactno.Text = DataGridView1.CurrentRow.Cells(21).Value.ToString()
    '    form.Position.Text = DataGridView1.CurrentRow.Cells(22).Value.ToString()
    '    form.Department.Text = DataGridView1.CurrentRow.Cells(23).Value.ToString()
    '    form.Division.Text = DataGridView1.CurrentRow.Cells(24).Value.ToString()
    '    form.EducAttain.Text = DataGridView1.CurrentRow.Cells(25).Value.ToString()
    '    form.Univcol.Text = DataGridView1.CurrentRow.Cells(26).Value.ToString()
    '    form.Program.Text = DataGridView1.CurrentRow.Cells(27).Value.ToString()
    '    form.PickerHired.Text = DataGridView1.CurrentRow.Cells(28).Value.ToString()
    '    form.ComboStatus.Text = DataGridView1.CurrentRow.Cells(29).Value.ToString()
    '    form.PickerPermanency.Text = DataGridView1.CurrentRow.Cells(30).Value.ToString()
    '    form.PickerLast.Text = DataGridView1.CurrentRow.Cells(31).Value.ToString()
    '    form.Reason.Text = DataGridView1.CurrentRow.Cells(32).Value.ToString()
    '    form.Licenseno.Text = DataGridView1.CurrentRow.Cells(33).Value.ToString()
    '    form.exp.Text = DataGridView1.CurrentRow.Cells(34).Value.ToString()

    '    form.TextBox4.Text = DataGridView1.CurrentRow.Cells(35).Value.ToString()
    '    form.Certno.Text = DataGridView1.CurrentRow.Cells(36).Value.ToString()
    '    form.WID.Text = DataGridView1.CurrentRow.Cells(37).Value.ToString()
    '    form.SSS.Text = DataGridView1.CurrentRow.Cells(38).Value.ToString()
    '    form.Philhealth.Text = DataGridView1.CurrentRow.Cells(39).Value.ToString()
    '    form.TIR.Text = DataGridView1.CurrentRow.Cells(40).Value.ToString()
    '    form.PAGIBIG.Text = DataGridView1.CurrentRow.Cells(41).Value.ToString()
    '    form.Evaluation.Text = DataGridView1.CurrentRow.Cells(42).Value.ToString()
    '    form.PictureBox.Text = DataGridView1.CurrentRow.Cells(43).Value.ToString()
    '    form.Msname.Text = DataGridView1.CurrentRow.Cells(44).Value.ToString()
    '    form.Mfname.Text = DataGridView1.CurrentRow.Cells(45).Value.ToString()
    '    form.Mmname.Text = DataGridView1.CurrentRow.Cells(46).Value.ToString()
    '    form.rat.Text = DataGridView1.CurrentRow.Cells(47).Value.ToString()
    '    form.evalrat.Text = DataGridView1.CurrentRow.Cells(48).Value.ToString()
    '    form.sanclong.Text = DataGridView1.CurrentRow.Cells(49).Value.ToString()
    '    form.sanc.Text = DataGridView1.CurrentRow.Cells(50).Value.ToString()
    '    form.leavecred.Text = DataGridView1.CurrentRow.Cells(51).Value.ToString()
    '    form.sickleave.Text = DataGridView1.CurrentRow.Cells(52).Value.ToString()
    '    form.vacleave.Text = DataGridView1.CurrentRow.Cells(53).Value.ToString()
    '    form.asof.Text = DataGridView1.CurrentRow.Cells(54).Value.ToString()


    '    form.ShowDialog()
    '    Me.Hide()
    'End Sub

    Private Sub PictureBox_TextChanged_1(sender As Object, e As EventArgs) Handles PictureBox.TextChanged
        If (System.IO.File.Exists(PictureBox.Text)) Then
            PictureBox2.Image = Image.FromFile(PictureBox.Text)
        End If
        If PictureBox.Text = "" Then
            PictureBox2.Hide()
        Else
            PictureBox2.Show()
        End If
    End Sub

    Private Sub Editbtn_Click(sender As Object, e As EventArgs) Handles Editbtn.Click
        EditEmployee.Show()
        Me.Close()
    End Sub

    Private Sub PickerBirthday_ValueChanged_1(sender As Object, e As EventArgs) Handles PickerBirthday.ValueChanged
        Dim today, dob As Integer
        today = Date.Today.Year
        dob = PickerBirthday.Value.Year
        Age.Text = today - dob
    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk

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

        'Dim fd As FileDialog
        'Dim vrtSelectedItem As Variant
        'Dim ctl As Control

        'Set ctl = Me.Object 'this is the field name of your object
        'Set fd = Application.FileDialog(msoFileDialogFilePicker)

        'With fd
        '        If .Show = -1 Then
        '            For Each vrtSelectedItem In .SelectedItems
        '                Me.Location = vrtSelectedItem
        '            Next vrtSelectedItem
        '        Else
        '        End If
        '    End With
        '    With ctl
        '        .Enabled = True
        '        .Locked = False
        '        .OLETypeAllowed = acOLEEmbedded
        '        .SourceDoc = Me.Location
        '        .Action = acOLECreateEmbed
        '    End With

        'Set fd = Nothing
        'Me.Picture.SetFocus

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Time.Text = TimeString
    End Sub





    Private Sub Sortname_Click_1(sender As Object, e As EventArgs) Handles Sortname.Click

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

    Private Sub Showdataview_Click_1(sender As Object, e As EventArgs) Handles Showdataview.Click


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






    'Private Sub Sortage_Click(sender As Object, e As EventArgs) Handles Sortage.Click
    '    DataGridView1.Sort(DataGridView1.Columns(17), System.ComponentModel.ListSortDirection.Ascending)

    'End Sub
End Class