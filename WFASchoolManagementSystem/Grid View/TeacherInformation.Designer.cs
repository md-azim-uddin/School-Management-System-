namespace WFASchoolManagementSystem.Admin
{
    partial class FormTeacherInfo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSave = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.dgvTeacher = new System.Windows.Forms.DataGridView();
            this.userId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateofbirth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nationality = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.religion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bloodgroup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fathername = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mothername = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.joiningdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leftdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qualification = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.presentaddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parmanentaddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactnumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtContactNumber = new System.Windows.Forms.TextBox();
            this.txtParmanentAddress = new System.Windows.Forms.TextBox();
            this.txtPresentAddress = new System.Windows.Forms.TextBox();
            this.txtQualification = new System.Windows.Forms.TextBox();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.txtMotherName = new System.Windows.Forms.TextBox();
            this.txtFatherName = new System.Windows.Forms.TextBox();
            this.txtBloodGroup = new System.Windows.Forms.TextBox();
            this.txtReligion = new System.Windows.Forms.TextBox();
            this.txtNationality = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.txtTeacherId = new System.Windows.Forms.TextBox();
            this.labelContactNumber = new System.Windows.Forms.Label();
            this.labelParmanentAddress = new System.Windows.Forms.Label();
            this.labelPresentAddress = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.LabelSalary = new System.Windows.Forms.Label();
            this.labelLeftDate = new System.Windows.Forms.Label();
            this.labelJoinDate = new System.Windows.Forms.Label();
            this.labelMotherName = new System.Windows.Forms.Label();
            this.labelFatherName = new System.Windows.Forms.Label();
            this.labelBloodGroup = new System.Windows.Forms.Label();
            this.labelReligion = new System.Windows.Forms.Label();
            this.labelNationality = new System.Windows.Forms.Label();
            this.labelDateOfBirth = new System.Windows.Forms.Label();
            this.labelGender = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelTeacherId = new System.Windows.Forms.Label();
            this.labelFullName = new System.Windows.Forms.Label();
            this.labelSubject = new System.Windows.Forms.Label();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.dtpdob = new System.Windows.Forms.DateTimePicker();
            this.dtpJoingDate = new System.Windows.Forms.DateTimePicker();
            this.dtpLeftDate = new System.Windows.Forms.DateTimePicker();
            this.btnShow = new System.Windows.Forms.Button();
            this.txtAutoSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeacher)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(27, 27);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(104, 43);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(27, 328);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(104, 43);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // dgvTeacher
            // 
            this.dgvTeacher.AllowUserToAddRows = false;
            this.dgvTeacher.AllowUserToDeleteRows = false;
            this.dgvTeacher.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTeacher.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userId,
            this.fullname,
            this.email,
            this.gender,
            this.dateofbirth,
            this.nationality,
            this.religion,
            this.bloodgroup,
            this.fathername,
            this.mothername,
            this.joiningdate,
            this.leftdate,
            this.salary,
            this.qualification,
            this.subject,
            this.presentaddress,
            this.parmanentaddress,
            this.contactnumber});
            this.dgvTeacher.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvTeacher.Location = new System.Drawing.Point(0, 424);
            this.dgvTeacher.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvTeacher.Name = "dgvTeacher";
            this.dgvTeacher.ReadOnly = true;
            this.dgvTeacher.RowTemplate.Height = 24;
            this.dgvTeacher.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTeacher.Size = new System.Drawing.Size(1011, 293);
            this.dgvTeacher.TabIndex = 13;
            this.dgvTeacher.DoubleClick += new System.EventHandler(this.dgvTeacher_DoubleClick);
            // 
            // userId
            // 
            this.userId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.userId.DataPropertyName = "userId";
            this.userId.HeaderText = "Teacher ID";
            this.userId.Name = "userId";
            this.userId.ReadOnly = true;
            // 
            // fullname
            // 
            this.fullname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fullname.DataPropertyName = "fullname";
            this.fullname.HeaderText = "Name";
            this.fullname.Name = "fullname";
            this.fullname.ReadOnly = true;
            // 
            // email
            // 
            this.email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.email.DataPropertyName = "email";
            this.email.HeaderText = "Email";
            this.email.Name = "email";
            this.email.ReadOnly = true;
            // 
            // gender
            // 
            this.gender.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.gender.DataPropertyName = "gender";
            this.gender.HeaderText = "Gender";
            this.gender.Name = "gender";
            this.gender.ReadOnly = true;
            // 
            // dateofbirth
            // 
            this.dateofbirth.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dateofbirth.DataPropertyName = "dateofbirth";
            this.dateofbirth.HeaderText = "DOB";
            this.dateofbirth.Name = "dateofbirth";
            this.dateofbirth.ReadOnly = true;
            // 
            // nationality
            // 
            this.nationality.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nationality.DataPropertyName = "nationality";
            this.nationality.HeaderText = "Nationality";
            this.nationality.Name = "nationality";
            this.nationality.ReadOnly = true;
            // 
            // religion
            // 
            this.religion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.religion.DataPropertyName = "religion";
            this.religion.HeaderText = "Religion";
            this.religion.Name = "religion";
            this.religion.ReadOnly = true;
            // 
            // bloodgroup
            // 
            this.bloodgroup.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.bloodgroup.DataPropertyName = "bloodgroup";
            this.bloodgroup.HeaderText = "BloodGroup";
            this.bloodgroup.Name = "bloodgroup";
            this.bloodgroup.ReadOnly = true;
            // 
            // fathername
            // 
            this.fathername.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fathername.DataPropertyName = "fathername";
            this.fathername.HeaderText = "Father\'s Name";
            this.fathername.Name = "fathername";
            this.fathername.ReadOnly = true;
            // 
            // mothername
            // 
            this.mothername.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.mothername.DataPropertyName = "mothername";
            this.mothername.HeaderText = "Mother\'s Name";
            this.mothername.Name = "mothername";
            this.mothername.ReadOnly = true;
            // 
            // joiningdate
            // 
            this.joiningdate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.joiningdate.DataPropertyName = "joiningdate";
            this.joiningdate.HeaderText = "Joining Date";
            this.joiningdate.Name = "joiningdate";
            this.joiningdate.ReadOnly = true;
            // 
            // leftdate
            // 
            this.leftdate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.leftdate.DataPropertyName = "leftdate";
            this.leftdate.HeaderText = "Left Date";
            this.leftdate.Name = "leftdate";
            this.leftdate.ReadOnly = true;
            // 
            // salary
            // 
            this.salary.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.salary.DataPropertyName = "salary";
            this.salary.HeaderText = "Salary";
            this.salary.Name = "salary";
            this.salary.ReadOnly = true;
            // 
            // qualification
            // 
            this.qualification.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.qualification.DataPropertyName = "qualification";
            this.qualification.HeaderText = "Qualification";
            this.qualification.Name = "qualification";
            this.qualification.ReadOnly = true;
            // 
            // subject
            // 
            this.subject.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.subject.DataPropertyName = "subject";
            this.subject.HeaderText = "Subject";
            this.subject.Name = "subject";
            this.subject.ReadOnly = true;
            // 
            // presentaddress
            // 
            this.presentaddress.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.presentaddress.DataPropertyName = "presentaddress";
            this.presentaddress.HeaderText = "Present Address";
            this.presentaddress.Name = "presentaddress";
            this.presentaddress.ReadOnly = true;
            // 
            // parmanentaddress
            // 
            this.parmanentaddress.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.parmanentaddress.DataPropertyName = "parmanentaddress";
            this.parmanentaddress.HeaderText = "Parmanent Address";
            this.parmanentaddress.Name = "parmanentaddress";
            this.parmanentaddress.ReadOnly = true;
            // 
            // contactnumber
            // 
            this.contactnumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.contactnumber.DataPropertyName = "contactnumber";
            this.contactnumber.HeaderText = "Contact Number";
            this.contactnumber.Name = "contactnumber";
            this.contactnumber.ReadOnly = true;
            // 
            // txtContactNumber
            // 
            this.txtContactNumber.Location = new System.Drawing.Point(497, 334);
            this.txtContactNumber.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtContactNumber.Name = "txtContactNumber";
            this.txtContactNumber.Size = new System.Drawing.Size(159, 20);
            this.txtContactNumber.TabIndex = 80;
            // 
            // txtParmanentAddress
            // 
            this.txtParmanentAddress.Location = new System.Drawing.Point(497, 299);
            this.txtParmanentAddress.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtParmanentAddress.Name = "txtParmanentAddress";
            this.txtParmanentAddress.Size = new System.Drawing.Size(159, 20);
            this.txtParmanentAddress.TabIndex = 79;
            // 
            // txtPresentAddress
            // 
            this.txtPresentAddress.Location = new System.Drawing.Point(496, 262);
            this.txtPresentAddress.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPresentAddress.Name = "txtPresentAddress";
            this.txtPresentAddress.Size = new System.Drawing.Size(159, 20);
            this.txtPresentAddress.TabIndex = 78;
            // 
            // txtQualification
            // 
            this.txtQualification.Location = new System.Drawing.Point(497, 192);
            this.txtQualification.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtQualification.Name = "txtQualification";
            this.txtQualification.Size = new System.Drawing.Size(159, 20);
            this.txtQualification.TabIndex = 77;
            // 
            // txtSalary
            // 
            this.txtSalary.Location = new System.Drawing.Point(496, 157);
            this.txtSalary.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(159, 20);
            this.txtSalary.TabIndex = 76;
            // 
            // txtMotherName
            // 
            this.txtMotherName.Location = new System.Drawing.Point(496, 60);
            this.txtMotherName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMotherName.Name = "txtMotherName";
            this.txtMotherName.Size = new System.Drawing.Size(159, 20);
            this.txtMotherName.TabIndex = 73;
            // 
            // txtFatherName
            // 
            this.txtFatherName.Location = new System.Drawing.Point(496, 30);
            this.txtFatherName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtFatherName.Name = "txtFatherName";
            this.txtFatherName.Size = new System.Drawing.Size(159, 20);
            this.txtFatherName.TabIndex = 72;
            // 
            // txtBloodGroup
            // 
            this.txtBloodGroup.Location = new System.Drawing.Point(123, 259);
            this.txtBloodGroup.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBloodGroup.Name = "txtBloodGroup";
            this.txtBloodGroup.Size = new System.Drawing.Size(159, 20);
            this.txtBloodGroup.TabIndex = 71;
            // 
            // txtReligion
            // 
            this.txtReligion.Location = new System.Drawing.Point(122, 220);
            this.txtReligion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtReligion.Name = "txtReligion";
            this.txtReligion.Size = new System.Drawing.Size(159, 20);
            this.txtReligion.TabIndex = 70;
            // 
            // txtNationality
            // 
            this.txtNationality.Location = new System.Drawing.Point(123, 187);
            this.txtNationality.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNationality.Name = "txtNationality";
            this.txtNationality.Size = new System.Drawing.Size(159, 20);
            this.txtNationality.TabIndex = 69;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(123, 88);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(159, 20);
            this.txtEmail.TabIndex = 67;
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(123, 57);
            this.txtFullName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(159, 20);
            this.txtFullName.TabIndex = 66;
            // 
            // txtTeacherId
            // 
            this.txtTeacherId.Location = new System.Drawing.Point(123, 28);
            this.txtTeacherId.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTeacherId.Name = "txtTeacherId";
            this.txtTeacherId.ReadOnly = true;
            this.txtTeacherId.Size = new System.Drawing.Size(159, 20);
            this.txtTeacherId.TabIndex = 65;
            // 
            // labelContactNumber
            // 
            this.labelContactNumber.AllowDrop = true;
            this.labelContactNumber.AutoSize = true;
            this.labelContactNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContactNumber.Location = new System.Drawing.Point(365, 334);
            this.labelContactNumber.Name = "labelContactNumber";
            this.labelContactNumber.Size = new System.Drawing.Size(110, 17);
            this.labelContactNumber.TabIndex = 64;
            this.labelContactNumber.Text = "Contact Number";
            // 
            // labelParmanentAddress
            // 
            this.labelParmanentAddress.AllowDrop = true;
            this.labelParmanentAddress.AutoSize = true;
            this.labelParmanentAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelParmanentAddress.Location = new System.Drawing.Point(359, 299);
            this.labelParmanentAddress.Name = "labelParmanentAddress";
            this.labelParmanentAddress.Size = new System.Drawing.Size(133, 17);
            this.labelParmanentAddress.TabIndex = 63;
            this.labelParmanentAddress.Text = "Parmanent Address";
            // 
            // labelPresentAddress
            // 
            this.labelPresentAddress.AllowDrop = true;
            this.labelPresentAddress.AutoSize = true;
            this.labelPresentAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPresentAddress.Location = new System.Drawing.Point(364, 262);
            this.labelPresentAddress.Name = "labelPresentAddress";
            this.labelPresentAddress.Size = new System.Drawing.Size(113, 17);
            this.labelPresentAddress.TabIndex = 62;
            this.labelPresentAddress.Text = "Present Address";
            // 
            // label14
            // 
            this.label14.AllowDrop = true;
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(365, 190);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(86, 17);
            this.label14.TabIndex = 61;
            this.label14.Text = "Qualification";
            // 
            // LabelSalary
            // 
            this.LabelSalary.AllowDrop = true;
            this.LabelSalary.AutoSize = true;
            this.LabelSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelSalary.Location = new System.Drawing.Point(364, 157);
            this.LabelSalary.Name = "LabelSalary";
            this.LabelSalary.Size = new System.Drawing.Size(48, 17);
            this.LabelSalary.TabIndex = 60;
            this.LabelSalary.Text = "Salary";
            // 
            // labelLeftDate
            // 
            this.labelLeftDate.AllowDrop = true;
            this.labelLeftDate.AutoSize = true;
            this.labelLeftDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLeftDate.Location = new System.Drawing.Point(364, 125);
            this.labelLeftDate.Name = "labelLeftDate";
            this.labelLeftDate.Size = new System.Drawing.Size(66, 17);
            this.labelLeftDate.TabIndex = 59;
            this.labelLeftDate.Text = "Left Date";
            // 
            // labelJoinDate
            // 
            this.labelJoinDate.AllowDrop = true;
            this.labelJoinDate.AutoSize = true;
            this.labelJoinDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelJoinDate.Location = new System.Drawing.Point(364, 91);
            this.labelJoinDate.Name = "labelJoinDate";
            this.labelJoinDate.Size = new System.Drawing.Size(87, 17);
            this.labelJoinDate.TabIndex = 58;
            this.labelJoinDate.Text = "Joining Date";
            // 
            // labelMotherName
            // 
            this.labelMotherName.AllowDrop = true;
            this.labelMotherName.AutoSize = true;
            this.labelMotherName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMotherName.Location = new System.Drawing.Point(364, 60);
            this.labelMotherName.Name = "labelMotherName";
            this.labelMotherName.Size = new System.Drawing.Size(93, 17);
            this.labelMotherName.TabIndex = 57;
            this.labelMotherName.Text = "Mother Name";
            // 
            // labelFatherName
            // 
            this.labelFatherName.AllowDrop = true;
            this.labelFatherName.AutoSize = true;
            this.labelFatherName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFatherName.Location = new System.Drawing.Point(364, 30);
            this.labelFatherName.Name = "labelFatherName";
            this.labelFatherName.Size = new System.Drawing.Size(90, 17);
            this.labelFatherName.TabIndex = 56;
            this.labelFatherName.Text = "Father Name";
            // 
            // labelBloodGroup
            // 
            this.labelBloodGroup.AllowDrop = true;
            this.labelBloodGroup.AutoSize = true;
            this.labelBloodGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBloodGroup.Location = new System.Drawing.Point(26, 261);
            this.labelBloodGroup.Name = "labelBloodGroup";
            this.labelBloodGroup.Size = new System.Drawing.Size(88, 17);
            this.labelBloodGroup.TabIndex = 55;
            this.labelBloodGroup.Text = "Blood Group";
            // 
            // labelReligion
            // 
            this.labelReligion.AllowDrop = true;
            this.labelReligion.AutoSize = true;
            this.labelReligion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelReligion.Location = new System.Drawing.Point(26, 220);
            this.labelReligion.Name = "labelReligion";
            this.labelReligion.Size = new System.Drawing.Size(59, 17);
            this.labelReligion.TabIndex = 54;
            this.labelReligion.Text = "Religion";
            // 
            // labelNationality
            // 
            this.labelNationality.AllowDrop = true;
            this.labelNationality.AutoSize = true;
            this.labelNationality.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNationality.Location = new System.Drawing.Point(26, 187);
            this.labelNationality.Name = "labelNationality";
            this.labelNationality.Size = new System.Drawing.Size(74, 17);
            this.labelNationality.TabIndex = 53;
            this.labelNationality.Text = "Nationality";
            // 
            // labelDateOfBirth
            // 
            this.labelDateOfBirth.AllowDrop = true;
            this.labelDateOfBirth.AutoSize = true;
            this.labelDateOfBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDateOfBirth.Location = new System.Drawing.Point(26, 154);
            this.labelDateOfBirth.Name = "labelDateOfBirth";
            this.labelDateOfBirth.Size = new System.Drawing.Size(90, 17);
            this.labelDateOfBirth.TabIndex = 52;
            this.labelDateOfBirth.Text = "Date Of Birth";
            // 
            // labelGender
            // 
            this.labelGender.AllowDrop = true;
            this.labelGender.AutoSize = true;
            this.labelGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGender.Location = new System.Drawing.Point(26, 121);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(56, 17);
            this.labelGender.TabIndex = 50;
            this.labelGender.Text = "Gender";
            // 
            // labelEmail
            // 
            this.labelEmail.AllowDrop = true;
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.Location = new System.Drawing.Point(26, 88);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(42, 17);
            this.labelEmail.TabIndex = 49;
            this.labelEmail.Text = "Email";
            // 
            // labelTeacherId
            // 
            this.labelTeacherId.AllowDrop = true;
            this.labelTeacherId.AutoSize = true;
            this.labelTeacherId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTeacherId.Location = new System.Drawing.Point(26, 28);
            this.labelTeacherId.Name = "labelTeacherId";
            this.labelTeacherId.Size = new System.Drawing.Size(78, 17);
            this.labelTeacherId.TabIndex = 48;
            this.labelTeacherId.Text = "Teacher ID";
            // 
            // labelFullName
            // 
            this.labelFullName.AllowDrop = true;
            this.labelFullName.AutoSize = true;
            this.labelFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFullName.Location = new System.Drawing.Point(26, 57);
            this.labelFullName.Name = "labelFullName";
            this.labelFullName.Size = new System.Drawing.Size(71, 17);
            this.labelFullName.TabIndex = 47;
            this.labelFullName.Text = "Full Name";
            // 
            // labelSubject
            // 
            this.labelSubject.AutoSize = true;
            this.labelSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSubject.Location = new System.Drawing.Point(365, 223);
            this.labelSubject.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSubject.Name = "labelSubject";
            this.labelSubject.Size = new System.Drawing.Size(55, 17);
            this.labelSubject.TabIndex = 81;
            this.labelSubject.Text = "Subject";
            // 
            // txtSubject
            // 
            this.txtSubject.Location = new System.Drawing.Point(497, 223);
            this.txtSubject.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(159, 20);
            this.txtSubject.TabIndex = 82;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Location = new System.Drawing.Point(754, 30);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(150, 394);
            this.panel1.TabIndex = 83;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(27, 257);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(104, 43);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(27, 178);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(104, 43);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(27, 104);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(104, 43);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // cmbGender
            // 
            this.cmbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cmbGender.Location = new System.Drawing.Point(123, 121);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(159, 21);
            this.cmbGender.TabIndex = 87;
            // 
            // dtpdob
            // 
            this.dtpdob.CustomFormat = "yyyy-MM-dd";
            this.dtpdob.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpdob.Location = new System.Drawing.Point(122, 154);
            this.dtpdob.Name = "dtpdob";
            this.dtpdob.Size = new System.Drawing.Size(159, 20);
            this.dtpdob.TabIndex = 88;
            // 
            // dtpJoingDate
            // 
            this.dtpJoingDate.CustomFormat = "yyyy-MM-dd";
            this.dtpJoingDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpJoingDate.Location = new System.Drawing.Point(496, 91);
            this.dtpJoingDate.Name = "dtpJoingDate";
            this.dtpJoingDate.Size = new System.Drawing.Size(159, 20);
            this.dtpJoingDate.TabIndex = 89;
            // 
            // dtpLeftDate
            // 
            this.dtpLeftDate.CustomFormat = "yyyy-MM-dd";
            this.dtpLeftDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpLeftDate.Location = new System.Drawing.Point(496, 125);
            this.dtpLeftDate.Name = "dtpLeftDate";
            this.dtpLeftDate.Size = new System.Drawing.Size(159, 20);
            this.dtpLeftDate.TabIndex = 90;
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(637, 396);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(93, 23);
            this.btnShow.TabIndex = 91;
            this.btnShow.Text = "Show All Info";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // txtAutoSearch
            // 
            this.txtAutoSearch.Location = new System.Drawing.Point(12, 396);
            this.txtAutoSearch.Name = "txtAutoSearch";
            this.txtAutoSearch.Size = new System.Drawing.Size(100, 20);
            this.txtAutoSearch.TabIndex = 92;
            this.txtAutoSearch.TextChanged += new System.EventHandler(this.txtAutoSearch_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(121, 398);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 93;
            this.label1.Text = "Search By Name";
            // 
            // FormTeacherInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1028, 609);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAutoSearch);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.dtpLeftDate);
            this.Controls.Add(this.dtpJoingDate);
            this.Controls.Add(this.dtpdob);
            this.Controls.Add(this.cmbGender);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtSubject);
            this.Controls.Add(this.labelSubject);
            this.Controls.Add(this.txtContactNumber);
            this.Controls.Add(this.txtParmanentAddress);
            this.Controls.Add(this.txtPresentAddress);
            this.Controls.Add(this.txtQualification);
            this.Controls.Add(this.txtSalary);
            this.Controls.Add(this.txtMotherName);
            this.Controls.Add(this.txtFatherName);
            this.Controls.Add(this.txtBloodGroup);
            this.Controls.Add(this.txtReligion);
            this.Controls.Add(this.txtNationality);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.txtTeacherId);
            this.Controls.Add(this.labelContactNumber);
            this.Controls.Add(this.labelParmanentAddress);
            this.Controls.Add(this.labelPresentAddress);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.LabelSalary);
            this.Controls.Add(this.labelLeftDate);
            this.Controls.Add(this.labelJoinDate);
            this.Controls.Add(this.labelMotherName);
            this.Controls.Add(this.labelFatherName);
            this.Controls.Add(this.labelBloodGroup);
            this.Controls.Add(this.labelReligion);
            this.Controls.Add(this.labelNationality);
            this.Controls.Add(this.labelDateOfBirth);
            this.Controls.Add(this.labelGender);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelTeacherId);
            this.Controls.Add(this.labelFullName);
            this.Controls.Add(this.dgvTeacher);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormTeacherInfo";
            this.Text = "Insert Information";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormTeacherInfo_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeacher)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridView dgvTeacher;
        private System.Windows.Forms.TextBox txtContactNumber;
        private System.Windows.Forms.TextBox txtParmanentAddress;
        private System.Windows.Forms.TextBox txtPresentAddress;
        private System.Windows.Forms.TextBox txtQualification;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.TextBox txtMotherName;
        private System.Windows.Forms.TextBox txtFatherName;
        private System.Windows.Forms.TextBox txtBloodGroup;
        private System.Windows.Forms.TextBox txtReligion;
        private System.Windows.Forms.TextBox txtNationality;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.TextBox txtTeacherId;
        private System.Windows.Forms.Label labelContactNumber;
        private System.Windows.Forms.Label labelParmanentAddress;
        private System.Windows.Forms.Label labelPresentAddress;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label LabelSalary;
        private System.Windows.Forms.Label labelLeftDate;
        private System.Windows.Forms.Label labelJoinDate;
        private System.Windows.Forms.Label labelMotherName;
        private System.Windows.Forms.Label labelFatherName;
        private System.Windows.Forms.Label labelBloodGroup;
        private System.Windows.Forms.Label labelReligion;
        private System.Windows.Forms.Label labelNationality;
        private System.Windows.Forms.Label labelDateOfBirth;
        private System.Windows.Forms.Label labelGender;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelTeacherId;
        private System.Windows.Forms.Label labelFullName;
        private System.Windows.Forms.Label labelSubject;
        private System.Windows.Forms.TextBox txtSubject;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.DateTimePicker dtpdob;
        private System.Windows.Forms.DateTimePicker dtpJoingDate;
        private System.Windows.Forms.DateTimePicker dtpLeftDate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.TextBox txtAutoSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn userId;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullname;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateofbirth;
        private System.Windows.Forms.DataGridViewTextBoxColumn nationality;
        private System.Windows.Forms.DataGridViewTextBoxColumn religion;
        private System.Windows.Forms.DataGridViewTextBoxColumn bloodgroup;
        private System.Windows.Forms.DataGridViewTextBoxColumn fathername;
        private System.Windows.Forms.DataGridViewTextBoxColumn mothername;
        private System.Windows.Forms.DataGridViewTextBoxColumn joiningdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn leftdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn salary;
        private System.Windows.Forms.DataGridViewTextBoxColumn qualification;
        private System.Windows.Forms.DataGridViewTextBoxColumn subject;
        private System.Windows.Forms.DataGridViewTextBoxColumn presentaddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn parmanentaddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactnumber;
        private System.Windows.Forms.Label label1;
    }
}