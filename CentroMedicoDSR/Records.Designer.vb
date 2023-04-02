<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Records
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Records))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.EmployeeDetailsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CentroMedicoDSRDataSet = New CentroMedicoDSR.CentroMedicoDSRDataSet()
        Me.ButtonBack = New System.Windows.Forms.Button()
        Me.EmployeeDetailsTableAdapter = New CentroMedicoDSR.CentroMedicoDSRDataSetTableAdapters.EmployeeDetailsTableAdapter()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.EmployeeIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SurnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FirstnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MiddlenameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HStreetDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HBarangayDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HTownDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HProvinceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HZipDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CStreetDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CBarangayDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CTownDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CProvinceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CZipDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SexDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AgeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CivilStatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BirthdayDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContactNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PositionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DepartmentDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DivisionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EducationalAttainmentDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UniversityCollegeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProgramDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateHiredDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PermanencyDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastDayDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReasonForLeavingDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LicenseNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ExpiryDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ExamTakenDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CertificateNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UMIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SSSDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PhilhealthDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TINDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PAGIBIGDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EvaluationDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PictureDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MSurnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MFirstnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MMiddlenameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RatingDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EvaluationRatingDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SanctionsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SanctionsNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LeaveCreditsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SickLeaveDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VacationLeaveDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AsOfDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AttachmentsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnprint = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.privno = New System.Windows.Forms.Label()
        Me.Searchbox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Showdataview = New System.Windows.Forms.Button()
        Me.Sortbox = New System.Windows.Forms.ComboBox()
        Me.Sortname = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmployeeDetailsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CentroMedicoDSRDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Location = New System.Drawing.Point(-8, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1352, 123)
        Me.PictureBox1.TabIndex = 31
        Me.PictureBox1.TabStop = False
        '
        'EmployeeDetailsBindingSource
        '
        Me.EmployeeDetailsBindingSource.DataMember = "EmployeeDetails"
        Me.EmployeeDetailsBindingSource.DataSource = Me.CentroMedicoDSRDataSet
        '
        'CentroMedicoDSRDataSet
        '
        Me.CentroMedicoDSRDataSet.DataSetName = "CentroMedicoDSRDataSet"
        Me.CentroMedicoDSRDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ButtonBack
        '
        Me.ButtonBack.BackColor = System.Drawing.Color.Azure
        Me.ButtonBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonBack.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ButtonBack.Image = CType(resources.GetObject("ButtonBack.Image"), System.Drawing.Image)
        Me.ButtonBack.Location = New System.Drawing.Point(96, 648)
        Me.ButtonBack.Name = "ButtonBack"
        Me.ButtonBack.Size = New System.Drawing.Size(208, 56)
        Me.ButtonBack.TabIndex = 115
        Me.ButtonBack.Text = "Back to Add Employee"
        Me.ButtonBack.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ButtonBack.UseVisualStyleBackColor = False
        '
        'EmployeeDetailsTableAdapter
        '
        Me.EmployeeDetailsTableAdapter.ClearBeforeFill = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.Azure
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.EmployeeIDDataGridViewTextBoxColumn, Me.SurnameDataGridViewTextBoxColumn, Me.FirstnameDataGridViewTextBoxColumn, Me.MiddlenameDataGridViewTextBoxColumn, Me.HNoDataGridViewTextBoxColumn, Me.HStreetDataGridViewTextBoxColumn, Me.HBarangayDataGridViewTextBoxColumn, Me.HTownDataGridViewTextBoxColumn, Me.HProvinceDataGridViewTextBoxColumn, Me.HZipDataGridViewTextBoxColumn, Me.CNoDataGridViewTextBoxColumn, Me.CStreetDataGridViewTextBoxColumn, Me.CBarangayDataGridViewTextBoxColumn, Me.CTownDataGridViewTextBoxColumn, Me.CProvinceDataGridViewTextBoxColumn, Me.CZipDataGridViewTextBoxColumn, Me.SexDataGridViewTextBoxColumn, Me.AgeDataGridViewTextBoxColumn, Me.CivilStatusDataGridViewTextBoxColumn, Me.BirthdayDataGridViewTextBoxColumn, Me.EmailDataGridViewTextBoxColumn, Me.ContactNumberDataGridViewTextBoxColumn, Me.PositionDataGridViewTextBoxColumn, Me.DepartmentDataGridViewTextBoxColumn, Me.DivisionDataGridViewTextBoxColumn, Me.EducationalAttainmentDataGridViewTextBoxColumn, Me.UniversityCollegeDataGridViewTextBoxColumn, Me.ProgramDataGridViewTextBoxColumn, Me.DateHiredDataGridViewTextBoxColumn, Me.StatusDataGridViewTextBoxColumn, Me.PermanencyDateDataGridViewTextBoxColumn, Me.LastDayDataGridViewTextBoxColumn, Me.ReasonForLeavingDataGridViewTextBoxColumn, Me.LicenseNumberDataGridViewTextBoxColumn, Me.ExpiryDataGridViewTextBoxColumn, Me.ExamTakenDataGridViewTextBoxColumn, Me.CertificateNumberDataGridViewTextBoxColumn, Me.UMIDDataGridViewTextBoxColumn, Me.SSSDataGridViewTextBoxColumn, Me.PhilhealthDataGridViewTextBoxColumn, Me.TINDataGridViewTextBoxColumn, Me.PAGIBIGDataGridViewTextBoxColumn, Me.EvaluationDataGridViewTextBoxColumn, Me.PictureDataGridViewTextBoxColumn, Me.MSurnameDataGridViewTextBoxColumn, Me.MFirstnameDataGridViewTextBoxColumn, Me.MMiddlenameDataGridViewTextBoxColumn, Me.RatingDataGridViewTextBoxColumn, Me.EvaluationRatingDataGridViewTextBoxColumn, Me.SanctionsDataGridViewTextBoxColumn, Me.SanctionsNoDataGridViewTextBoxColumn, Me.LeaveCreditsDataGridViewTextBoxColumn, Me.SickLeaveDataGridViewTextBoxColumn, Me.VacationLeaveDataGridViewTextBoxColumn, Me.AsOfDataGridViewTextBoxColumn, Me.AttachmentsDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.EmployeeDetailsBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(96, 224)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1168, 384)
        Me.DataGridView1.TabIndex = 116
        '
        'EmployeeIDDataGridViewTextBoxColumn
        '
        Me.EmployeeIDDataGridViewTextBoxColumn.DataPropertyName = "Employee_ID"
        Me.EmployeeIDDataGridViewTextBoxColumn.HeaderText = "Employee_ID"
        Me.EmployeeIDDataGridViewTextBoxColumn.Name = "EmployeeIDDataGridViewTextBoxColumn"
        '
        'SurnameDataGridViewTextBoxColumn
        '
        Me.SurnameDataGridViewTextBoxColumn.DataPropertyName = "Surname"
        Me.SurnameDataGridViewTextBoxColumn.HeaderText = "Surname"
        Me.SurnameDataGridViewTextBoxColumn.Name = "SurnameDataGridViewTextBoxColumn"
        '
        'FirstnameDataGridViewTextBoxColumn
        '
        Me.FirstnameDataGridViewTextBoxColumn.DataPropertyName = "Firstname"
        Me.FirstnameDataGridViewTextBoxColumn.HeaderText = "Firstname"
        Me.FirstnameDataGridViewTextBoxColumn.Name = "FirstnameDataGridViewTextBoxColumn"
        '
        'MiddlenameDataGridViewTextBoxColumn
        '
        Me.MiddlenameDataGridViewTextBoxColumn.DataPropertyName = "Middlename"
        Me.MiddlenameDataGridViewTextBoxColumn.HeaderText = "Middlename"
        Me.MiddlenameDataGridViewTextBoxColumn.Name = "MiddlenameDataGridViewTextBoxColumn"
        '
        'HNoDataGridViewTextBoxColumn
        '
        Me.HNoDataGridViewTextBoxColumn.DataPropertyName = "HNo"
        Me.HNoDataGridViewTextBoxColumn.HeaderText = "HNo"
        Me.HNoDataGridViewTextBoxColumn.Name = "HNoDataGridViewTextBoxColumn"
        '
        'HStreetDataGridViewTextBoxColumn
        '
        Me.HStreetDataGridViewTextBoxColumn.DataPropertyName = "HStreet"
        Me.HStreetDataGridViewTextBoxColumn.HeaderText = "HStreet"
        Me.HStreetDataGridViewTextBoxColumn.Name = "HStreetDataGridViewTextBoxColumn"
        '
        'HBarangayDataGridViewTextBoxColumn
        '
        Me.HBarangayDataGridViewTextBoxColumn.DataPropertyName = "HBarangay"
        Me.HBarangayDataGridViewTextBoxColumn.HeaderText = "HBarangay"
        Me.HBarangayDataGridViewTextBoxColumn.Name = "HBarangayDataGridViewTextBoxColumn"
        '
        'HTownDataGridViewTextBoxColumn
        '
        Me.HTownDataGridViewTextBoxColumn.DataPropertyName = "HTown"
        Me.HTownDataGridViewTextBoxColumn.HeaderText = "HTown"
        Me.HTownDataGridViewTextBoxColumn.Name = "HTownDataGridViewTextBoxColumn"
        '
        'HProvinceDataGridViewTextBoxColumn
        '
        Me.HProvinceDataGridViewTextBoxColumn.DataPropertyName = "HProvince"
        Me.HProvinceDataGridViewTextBoxColumn.HeaderText = "HProvince"
        Me.HProvinceDataGridViewTextBoxColumn.Name = "HProvinceDataGridViewTextBoxColumn"
        '
        'HZipDataGridViewTextBoxColumn
        '
        Me.HZipDataGridViewTextBoxColumn.DataPropertyName = "HZip"
        Me.HZipDataGridViewTextBoxColumn.HeaderText = "HZip"
        Me.HZipDataGridViewTextBoxColumn.Name = "HZipDataGridViewTextBoxColumn"
        '
        'CNoDataGridViewTextBoxColumn
        '
        Me.CNoDataGridViewTextBoxColumn.DataPropertyName = "CNo"
        Me.CNoDataGridViewTextBoxColumn.HeaderText = "CNo"
        Me.CNoDataGridViewTextBoxColumn.Name = "CNoDataGridViewTextBoxColumn"
        '
        'CStreetDataGridViewTextBoxColumn
        '
        Me.CStreetDataGridViewTextBoxColumn.DataPropertyName = "CStreet"
        Me.CStreetDataGridViewTextBoxColumn.HeaderText = "CStreet"
        Me.CStreetDataGridViewTextBoxColumn.Name = "CStreetDataGridViewTextBoxColumn"
        '
        'CBarangayDataGridViewTextBoxColumn
        '
        Me.CBarangayDataGridViewTextBoxColumn.DataPropertyName = "CBarangay"
        Me.CBarangayDataGridViewTextBoxColumn.HeaderText = "CBarangay"
        Me.CBarangayDataGridViewTextBoxColumn.Name = "CBarangayDataGridViewTextBoxColumn"
        '
        'CTownDataGridViewTextBoxColumn
        '
        Me.CTownDataGridViewTextBoxColumn.DataPropertyName = "CTown"
        Me.CTownDataGridViewTextBoxColumn.HeaderText = "CTown"
        Me.CTownDataGridViewTextBoxColumn.Name = "CTownDataGridViewTextBoxColumn"
        '
        'CProvinceDataGridViewTextBoxColumn
        '
        Me.CProvinceDataGridViewTextBoxColumn.DataPropertyName = "CProvince"
        Me.CProvinceDataGridViewTextBoxColumn.HeaderText = "CProvince"
        Me.CProvinceDataGridViewTextBoxColumn.Name = "CProvinceDataGridViewTextBoxColumn"
        '
        'CZipDataGridViewTextBoxColumn
        '
        Me.CZipDataGridViewTextBoxColumn.DataPropertyName = "CZip"
        Me.CZipDataGridViewTextBoxColumn.HeaderText = "CZip"
        Me.CZipDataGridViewTextBoxColumn.Name = "CZipDataGridViewTextBoxColumn"
        '
        'SexDataGridViewTextBoxColumn
        '
        Me.SexDataGridViewTextBoxColumn.DataPropertyName = "Sex"
        Me.SexDataGridViewTextBoxColumn.HeaderText = "Sex"
        Me.SexDataGridViewTextBoxColumn.Name = "SexDataGridViewTextBoxColumn"
        '
        'AgeDataGridViewTextBoxColumn
        '
        Me.AgeDataGridViewTextBoxColumn.DataPropertyName = "Age"
        Me.AgeDataGridViewTextBoxColumn.HeaderText = "Age"
        Me.AgeDataGridViewTextBoxColumn.Name = "AgeDataGridViewTextBoxColumn"
        '
        'CivilStatusDataGridViewTextBoxColumn
        '
        Me.CivilStatusDataGridViewTextBoxColumn.DataPropertyName = "CivilStatus"
        Me.CivilStatusDataGridViewTextBoxColumn.HeaderText = "CivilStatus"
        Me.CivilStatusDataGridViewTextBoxColumn.Name = "CivilStatusDataGridViewTextBoxColumn"
        '
        'BirthdayDataGridViewTextBoxColumn
        '
        Me.BirthdayDataGridViewTextBoxColumn.DataPropertyName = "Birthday"
        Me.BirthdayDataGridViewTextBoxColumn.HeaderText = "Birthday"
        Me.BirthdayDataGridViewTextBoxColumn.Name = "BirthdayDataGridViewTextBoxColumn"
        '
        'EmailDataGridViewTextBoxColumn
        '
        Me.EmailDataGridViewTextBoxColumn.DataPropertyName = "Email"
        Me.EmailDataGridViewTextBoxColumn.HeaderText = "Email"
        Me.EmailDataGridViewTextBoxColumn.Name = "EmailDataGridViewTextBoxColumn"
        '
        'ContactNumberDataGridViewTextBoxColumn
        '
        Me.ContactNumberDataGridViewTextBoxColumn.DataPropertyName = "ContactNumber"
        Me.ContactNumberDataGridViewTextBoxColumn.HeaderText = "ContactNumber"
        Me.ContactNumberDataGridViewTextBoxColumn.Name = "ContactNumberDataGridViewTextBoxColumn"
        '
        'PositionDataGridViewTextBoxColumn
        '
        Me.PositionDataGridViewTextBoxColumn.DataPropertyName = "Position"
        Me.PositionDataGridViewTextBoxColumn.HeaderText = "Position"
        Me.PositionDataGridViewTextBoxColumn.Name = "PositionDataGridViewTextBoxColumn"
        '
        'DepartmentDataGridViewTextBoxColumn
        '
        Me.DepartmentDataGridViewTextBoxColumn.DataPropertyName = "Department"
        Me.DepartmentDataGridViewTextBoxColumn.HeaderText = "Department"
        Me.DepartmentDataGridViewTextBoxColumn.Name = "DepartmentDataGridViewTextBoxColumn"
        '
        'DivisionDataGridViewTextBoxColumn
        '
        Me.DivisionDataGridViewTextBoxColumn.DataPropertyName = "Division"
        Me.DivisionDataGridViewTextBoxColumn.HeaderText = "Division"
        Me.DivisionDataGridViewTextBoxColumn.Name = "DivisionDataGridViewTextBoxColumn"
        '
        'EducationalAttainmentDataGridViewTextBoxColumn
        '
        Me.EducationalAttainmentDataGridViewTextBoxColumn.DataPropertyName = "EducationalAttainment"
        Me.EducationalAttainmentDataGridViewTextBoxColumn.HeaderText = "EducationalAttainment"
        Me.EducationalAttainmentDataGridViewTextBoxColumn.Name = "EducationalAttainmentDataGridViewTextBoxColumn"
        '
        'UniversityCollegeDataGridViewTextBoxColumn
        '
        Me.UniversityCollegeDataGridViewTextBoxColumn.DataPropertyName = "University_College"
        Me.UniversityCollegeDataGridViewTextBoxColumn.HeaderText = "University_College"
        Me.UniversityCollegeDataGridViewTextBoxColumn.Name = "UniversityCollegeDataGridViewTextBoxColumn"
        '
        'ProgramDataGridViewTextBoxColumn
        '
        Me.ProgramDataGridViewTextBoxColumn.DataPropertyName = "Program"
        Me.ProgramDataGridViewTextBoxColumn.HeaderText = "Program"
        Me.ProgramDataGridViewTextBoxColumn.Name = "ProgramDataGridViewTextBoxColumn"
        '
        'DateHiredDataGridViewTextBoxColumn
        '
        Me.DateHiredDataGridViewTextBoxColumn.DataPropertyName = "DateHired"
        Me.DateHiredDataGridViewTextBoxColumn.HeaderText = "DateHired"
        Me.DateHiredDataGridViewTextBoxColumn.Name = "DateHiredDataGridViewTextBoxColumn"
        '
        'StatusDataGridViewTextBoxColumn
        '
        Me.StatusDataGridViewTextBoxColumn.DataPropertyName = "Status"
        Me.StatusDataGridViewTextBoxColumn.HeaderText = "Status"
        Me.StatusDataGridViewTextBoxColumn.Name = "StatusDataGridViewTextBoxColumn"
        '
        'PermanencyDateDataGridViewTextBoxColumn
        '
        Me.PermanencyDateDataGridViewTextBoxColumn.DataPropertyName = "PermanencyDate"
        Me.PermanencyDateDataGridViewTextBoxColumn.HeaderText = "PermanencyDate"
        Me.PermanencyDateDataGridViewTextBoxColumn.Name = "PermanencyDateDataGridViewTextBoxColumn"
        '
        'LastDayDataGridViewTextBoxColumn
        '
        Me.LastDayDataGridViewTextBoxColumn.DataPropertyName = "LastDay"
        Me.LastDayDataGridViewTextBoxColumn.HeaderText = "LastDay"
        Me.LastDayDataGridViewTextBoxColumn.Name = "LastDayDataGridViewTextBoxColumn"
        '
        'ReasonForLeavingDataGridViewTextBoxColumn
        '
        Me.ReasonForLeavingDataGridViewTextBoxColumn.DataPropertyName = "ReasonForLeaving"
        Me.ReasonForLeavingDataGridViewTextBoxColumn.HeaderText = "ReasonForLeaving"
        Me.ReasonForLeavingDataGridViewTextBoxColumn.Name = "ReasonForLeavingDataGridViewTextBoxColumn"
        '
        'LicenseNumberDataGridViewTextBoxColumn
        '
        Me.LicenseNumberDataGridViewTextBoxColumn.DataPropertyName = "LicenseNumber"
        Me.LicenseNumberDataGridViewTextBoxColumn.HeaderText = "LicenseNumber"
        Me.LicenseNumberDataGridViewTextBoxColumn.Name = "LicenseNumberDataGridViewTextBoxColumn"
        '
        'ExpiryDataGridViewTextBoxColumn
        '
        Me.ExpiryDataGridViewTextBoxColumn.DataPropertyName = "Expiry"
        Me.ExpiryDataGridViewTextBoxColumn.HeaderText = "Expiry"
        Me.ExpiryDataGridViewTextBoxColumn.Name = "ExpiryDataGridViewTextBoxColumn"
        '
        'ExamTakenDataGridViewTextBoxColumn
        '
        Me.ExamTakenDataGridViewTextBoxColumn.DataPropertyName = "ExamTaken"
        Me.ExamTakenDataGridViewTextBoxColumn.HeaderText = "ExamTaken"
        Me.ExamTakenDataGridViewTextBoxColumn.Name = "ExamTakenDataGridViewTextBoxColumn"
        '
        'CertificateNumberDataGridViewTextBoxColumn
        '
        Me.CertificateNumberDataGridViewTextBoxColumn.DataPropertyName = "CertificateNumber"
        Me.CertificateNumberDataGridViewTextBoxColumn.HeaderText = "CertificateNumber"
        Me.CertificateNumberDataGridViewTextBoxColumn.Name = "CertificateNumberDataGridViewTextBoxColumn"
        '
        'UMIDDataGridViewTextBoxColumn
        '
        Me.UMIDDataGridViewTextBoxColumn.DataPropertyName = "UMID"
        Me.UMIDDataGridViewTextBoxColumn.HeaderText = "UMID"
        Me.UMIDDataGridViewTextBoxColumn.Name = "UMIDDataGridViewTextBoxColumn"
        '
        'SSSDataGridViewTextBoxColumn
        '
        Me.SSSDataGridViewTextBoxColumn.DataPropertyName = "SSS"
        Me.SSSDataGridViewTextBoxColumn.HeaderText = "SSS"
        Me.SSSDataGridViewTextBoxColumn.Name = "SSSDataGridViewTextBoxColumn"
        '
        'PhilhealthDataGridViewTextBoxColumn
        '
        Me.PhilhealthDataGridViewTextBoxColumn.DataPropertyName = "Philhealth"
        Me.PhilhealthDataGridViewTextBoxColumn.HeaderText = "Philhealth"
        Me.PhilhealthDataGridViewTextBoxColumn.Name = "PhilhealthDataGridViewTextBoxColumn"
        '
        'TINDataGridViewTextBoxColumn
        '
        Me.TINDataGridViewTextBoxColumn.DataPropertyName = "TIN"
        Me.TINDataGridViewTextBoxColumn.HeaderText = "TIN"
        Me.TINDataGridViewTextBoxColumn.Name = "TINDataGridViewTextBoxColumn"
        '
        'PAGIBIGDataGridViewTextBoxColumn
        '
        Me.PAGIBIGDataGridViewTextBoxColumn.DataPropertyName = "PAGIBIG"
        Me.PAGIBIGDataGridViewTextBoxColumn.HeaderText = "PAGIBIG"
        Me.PAGIBIGDataGridViewTextBoxColumn.Name = "PAGIBIGDataGridViewTextBoxColumn"
        '
        'EvaluationDataGridViewTextBoxColumn
        '
        Me.EvaluationDataGridViewTextBoxColumn.DataPropertyName = "Evaluation"
        Me.EvaluationDataGridViewTextBoxColumn.HeaderText = "Evaluation"
        Me.EvaluationDataGridViewTextBoxColumn.Name = "EvaluationDataGridViewTextBoxColumn"
        '
        'PictureDataGridViewTextBoxColumn
        '
        Me.PictureDataGridViewTextBoxColumn.DataPropertyName = "Picture"
        Me.PictureDataGridViewTextBoxColumn.HeaderText = "Picture"
        Me.PictureDataGridViewTextBoxColumn.Name = "PictureDataGridViewTextBoxColumn"
        '
        'MSurnameDataGridViewTextBoxColumn
        '
        Me.MSurnameDataGridViewTextBoxColumn.DataPropertyName = "MSurname"
        Me.MSurnameDataGridViewTextBoxColumn.HeaderText = "MSurname"
        Me.MSurnameDataGridViewTextBoxColumn.Name = "MSurnameDataGridViewTextBoxColumn"
        '
        'MFirstnameDataGridViewTextBoxColumn
        '
        Me.MFirstnameDataGridViewTextBoxColumn.DataPropertyName = "MFirstname"
        Me.MFirstnameDataGridViewTextBoxColumn.HeaderText = "MFirstname"
        Me.MFirstnameDataGridViewTextBoxColumn.Name = "MFirstnameDataGridViewTextBoxColumn"
        '
        'MMiddlenameDataGridViewTextBoxColumn
        '
        Me.MMiddlenameDataGridViewTextBoxColumn.DataPropertyName = "MMiddlename"
        Me.MMiddlenameDataGridViewTextBoxColumn.HeaderText = "MMiddlename"
        Me.MMiddlenameDataGridViewTextBoxColumn.Name = "MMiddlenameDataGridViewTextBoxColumn"
        '
        'RatingDataGridViewTextBoxColumn
        '
        Me.RatingDataGridViewTextBoxColumn.DataPropertyName = "Rating"
        Me.RatingDataGridViewTextBoxColumn.HeaderText = "Rating"
        Me.RatingDataGridViewTextBoxColumn.Name = "RatingDataGridViewTextBoxColumn"
        '
        'EvaluationRatingDataGridViewTextBoxColumn
        '
        Me.EvaluationRatingDataGridViewTextBoxColumn.DataPropertyName = "EvaluationRating"
        Me.EvaluationRatingDataGridViewTextBoxColumn.HeaderText = "EvaluationRating"
        Me.EvaluationRatingDataGridViewTextBoxColumn.Name = "EvaluationRatingDataGridViewTextBoxColumn"
        '
        'SanctionsDataGridViewTextBoxColumn
        '
        Me.SanctionsDataGridViewTextBoxColumn.DataPropertyName = "Sanctions"
        Me.SanctionsDataGridViewTextBoxColumn.HeaderText = "Sanctions"
        Me.SanctionsDataGridViewTextBoxColumn.Name = "SanctionsDataGridViewTextBoxColumn"
        '
        'SanctionsNoDataGridViewTextBoxColumn
        '
        Me.SanctionsNoDataGridViewTextBoxColumn.DataPropertyName = "SanctionsNo"
        Me.SanctionsNoDataGridViewTextBoxColumn.HeaderText = "SanctionsNo"
        Me.SanctionsNoDataGridViewTextBoxColumn.Name = "SanctionsNoDataGridViewTextBoxColumn"
        '
        'LeaveCreditsDataGridViewTextBoxColumn
        '
        Me.LeaveCreditsDataGridViewTextBoxColumn.DataPropertyName = "LeaveCredits"
        Me.LeaveCreditsDataGridViewTextBoxColumn.HeaderText = "LeaveCredits"
        Me.LeaveCreditsDataGridViewTextBoxColumn.Name = "LeaveCreditsDataGridViewTextBoxColumn"
        '
        'SickLeaveDataGridViewTextBoxColumn
        '
        Me.SickLeaveDataGridViewTextBoxColumn.DataPropertyName = "SickLeave"
        Me.SickLeaveDataGridViewTextBoxColumn.HeaderText = "SickLeave"
        Me.SickLeaveDataGridViewTextBoxColumn.Name = "SickLeaveDataGridViewTextBoxColumn"
        '
        'VacationLeaveDataGridViewTextBoxColumn
        '
        Me.VacationLeaveDataGridViewTextBoxColumn.DataPropertyName = "VacationLeave"
        Me.VacationLeaveDataGridViewTextBoxColumn.HeaderText = "VacationLeave"
        Me.VacationLeaveDataGridViewTextBoxColumn.Name = "VacationLeaveDataGridViewTextBoxColumn"
        '
        'AsOfDataGridViewTextBoxColumn
        '
        Me.AsOfDataGridViewTextBoxColumn.DataPropertyName = "AsOf"
        Me.AsOfDataGridViewTextBoxColumn.HeaderText = "AsOf"
        Me.AsOfDataGridViewTextBoxColumn.Name = "AsOfDataGridViewTextBoxColumn"
        '
        'AttachmentsDataGridViewTextBoxColumn
        '
        Me.AttachmentsDataGridViewTextBoxColumn.DataPropertyName = "Attachments"
        Me.AttachmentsDataGridViewTextBoxColumn.HeaderText = "Attachments"
        Me.AttachmentsDataGridViewTextBoxColumn.Name = "AttachmentsDataGridViewTextBoxColumn"
        '
        'btnprint
        '
        Me.btnprint.BackColor = System.Drawing.Color.Azure
        Me.btnprint.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnprint.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnprint.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnprint.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnprint.Image = CType(resources.GetObject("btnprint.Image"), System.Drawing.Image)
        Me.btnprint.Location = New System.Drawing.Point(1160, 152)
        Me.btnprint.Name = "btnprint"
        Me.btnprint.Size = New System.Drawing.Size(104, 48)
        Me.btnprint.TabIndex = 117
        Me.btnprint.Text = "Print"
        Me.btnprint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnprint.UseVisualStyleBackColor = False
        '
        'ComboBox1
        '
        Me.ComboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ComboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBox1.Font = New System.Drawing.Font("Georgia", 8.0!)
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"PAGIBIG", "TIN", "UMID", "SSS", "PhilHealth", "Department & Division"})
        Me.ComboBox1.Location = New System.Drawing.Point(864, 176)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(280, 22)
        Me.ComboBox1.TabIndex = 118
        '
        'privno
        '
        Me.privno.AutoSize = True
        Me.privno.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.privno.ForeColor = System.Drawing.Color.DarkGreen
        Me.privno.Location = New System.Drawing.Point(904, 152)
        Me.privno.Name = "privno"
        Me.privno.Size = New System.Drawing.Size(195, 18)
        Me.privno.TabIndex = 119
        Me.privno.Text = "SPECIFIED PRINTING"
        '
        'Searchbox
        '
        Me.Searchbox.Location = New System.Drawing.Point(200, 144)
        Me.Searchbox.Name = "Searchbox"
        Me.Searchbox.Size = New System.Drawing.Size(152, 20)
        Me.Searchbox.TabIndex = 120
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Azure
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(88, 128)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(104, 39)
        Me.Button1.TabIndex = 122
        Me.Button1.Text = "Search"
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Showdataview
        '
        Me.Showdataview.BackColor = System.Drawing.Color.Azure
        Me.Showdataview.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Showdataview.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Showdataview.Image = CType(resources.GetObject("Showdataview.Image"), System.Drawing.Image)
        Me.Showdataview.Location = New System.Drawing.Point(376, 128)
        Me.Showdataview.Name = "Showdataview"
        Me.Showdataview.Size = New System.Drawing.Size(128, 48)
        Me.Showdataview.TabIndex = 152
        Me.Showdataview.Text = "REFRESH DATAGRID"
        Me.Showdataview.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Showdataview.UseVisualStyleBackColor = False
        '
        'Sortbox
        '
        Me.Sortbox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.Sortbox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.Sortbox.FormattingEnabled = True
        Me.Sortbox.Items.AddRange(New Object() {"Name", "Home Number", "Street", "Home Barangay", "Home Town", "Home Province", "Home Zip Code", "Current Home Number", "Current Street", "Current Barangay", "Current Town", "Current Province", "Current Zip Code", "Sex", "Age", "Civil Status", "Birthday", "Email", "Contact Number", "Position", "Department", "Division", "Educational Attainment", "University / College", "Program", "Date Hired", "Status", "Permanency", "Last Day", "Reason For Leaving", "License Number", "Expiry", "Exam Taken", "Certificate Number", "UMID", "SSS", "PhilHealth", "TIN", "PAGIBIG", "Evaluation", "Maiden Surname", "Maiden Firstname", "Maiden Middlename", "Rating", "Evaluation Rating", "Sanctions", "Sanction Number", "Leave Credit", "Sick Leave", "Vacation Leave", "As Of"})
        Me.Sortbox.Location = New System.Drawing.Point(200, 192)
        Me.Sortbox.Name = "Sortbox"
        Me.Sortbox.Size = New System.Drawing.Size(152, 21)
        Me.Sortbox.TabIndex = 151
        '
        'Sortname
        '
        Me.Sortname.BackColor = System.Drawing.Color.Azure
        Me.Sortname.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Sortname.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Sortname.Image = CType(resources.GetObject("Sortname.Image"), System.Drawing.Image)
        Me.Sortname.Location = New System.Drawing.Point(88, 176)
        Me.Sortname.Name = "Sortname"
        Me.Sortname.Size = New System.Drawing.Size(104, 39)
        Me.Sortname.TabIndex = 150
        Me.Sortname.Text = "SORT"
        Me.Sortname.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Sortname.UseVisualStyleBackColor = False
        '
        'Records
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1364, 748)
        Me.Controls.Add(Me.Showdataview)
        Me.Controls.Add(Me.Sortbox)
        Me.Controls.Add(Me.Sortname)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Searchbox)
        Me.Controls.Add(Me.privno)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.btnprint)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.ButtonBack)
        Me.Controls.Add(Me.PictureBox1)
        Me.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeDetailsBindingSource, "Surname", True))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Records"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Records"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmployeeDetailsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CentroMedicoDSRDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ButtonBack As Button
    Friend WithEvents CentroMedicoDSRDataSet As CentroMedicoDSRDataSet
    Friend WithEvents EmployeeDetailsBindingSource As BindingSource
    Friend WithEvents EmployeeDetailsTableAdapter As CentroMedicoDSRDataSetTableAdapters.EmployeeDetailsTableAdapter
    Friend WithEvents RatingExpiryDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents WIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TIRDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents EmployeeIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SurnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FirstnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MiddlenameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HNoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HStreetDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HBarangayDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HTownDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HProvinceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HZipDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CNoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CStreetDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CBarangayDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CTownDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CProvinceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CZipDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SexDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AgeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CivilStatusDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BirthdayDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmailDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ContactNumberDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PositionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DepartmentDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DivisionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EducationalAttainmentDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UniversityCollegeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProgramDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DateHiredDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StatusDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PermanencyDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LastDayDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ReasonForLeavingDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LicenseNumberDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ExpiryDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ExamTakenDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CertificateNumberDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UMIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SSSDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PhilhealthDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TINDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PAGIBIGDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EvaluationDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PictureDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MSurnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MFirstnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MMiddlenameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RatingDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EvaluationRatingDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SanctionsDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SanctionsNoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LeaveCreditsDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SickLeaveDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents VacationLeaveDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AsOfDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AttachmentsDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents btnprint As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents privno As Label
    Friend WithEvents Searchbox As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Showdataview As Button
    Friend WithEvents Sortbox As ComboBox
    Friend WithEvents Sortname As Button
End Class
