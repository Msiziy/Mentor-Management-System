namespace MentorManagementSystem
{
    partial class MentorPage
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
            this.components = new System.ComponentModel.Container();
            this.MentorTabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.MentorStudentDataGridView = new System.Windows.Forms.DataGridView();
            this.sTUNUMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTUFNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTULNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTUPHONENUMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTUEMAILDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTUYEARDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTUDENTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mentorManagementDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mentorManagementDataSet = new MentorManagementSystem.MentorManagementDataSet();
            this.Students = new System.Windows.Forms.Label();
            this.MentorManagementHeader = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.MentorSaveChangesBtn = new System.Windows.Forms.Button();
            this.MentorLogoutProfile = new System.Windows.Forms.Button();
            this.CourseListGroupBox = new System.Windows.Forms.GroupBox();
            this.MentorCourseUpdateComboBox = new System.Windows.Forms.ComboBox();
            this.PasswordGroupBox = new System.Windows.Forms.GroupBox();
            this.ConfirmPasswordUpdateInputBox = new System.Windows.Forms.TextBox();
            this.NewPasswordUpdateInputBox = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.ConfirmPasswordUpdateLabel = new System.Windows.Forms.Label();
            this.NewPasswordUpdateLabel = new System.Windows.Forms.Label();
            this.MentorUpdateGroupBox = new System.Windows.Forms.GroupBox();
            this.MentorPhoneNumberUpdateInputBox = new System.Windows.Forms.TextBox();
            this.MentorLastNameUpdateInputBox = new System.Windows.Forms.TextBox();
            this.MentorFirstNameUpdateInputBox = new System.Windows.Forms.TextBox();
            this.StudentPhoneNumberUpdateLabel = new System.Windows.Forms.Label();
            this.StudentLastNameUpdateLabel = new System.Windows.Forms.Label();
            this.StudentFirstNameUpdateLabel = new System.Windows.Forms.Label();
            this.MentorDetailsGroupBox = new System.Windows.Forms.GroupBox();
            this.MentorPhoneNumberResults = new System.Windows.Forms.Label();
            this.MentorEmailResults = new System.Windows.Forms.Label();
            this.MentorLastNameResults = new System.Windows.Forms.Label();
            this.MentorFirstNameResults = new System.Windows.Forms.Label();
            this.PhoneNumberMentorDetailsLabel = new System.Windows.Forms.Label();
            this.EmailDetailsMentorLabel = new System.Windows.Forms.Label();
            this.LastNameMentorDetails = new System.Windows.Forms.Label();
            this.FirstNameMentorDetails = new System.Windows.Forms.Label();
            this.sTUDENTTableAdapter = new MentorManagementSystem.MentorManagementDataSetTableAdapters.STUDENTTableAdapter();
            this.MentorTabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MentorStudentDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTUDENTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mentorManagementDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mentorManagementDataSet)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.CourseListGroupBox.SuspendLayout();
            this.PasswordGroupBox.SuspendLayout();
            this.MentorUpdateGroupBox.SuspendLayout();
            this.MentorDetailsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // MentorTabControl
            // 
            this.MentorTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MentorTabControl.Controls.Add(this.tabPage1);
            this.MentorTabControl.Controls.Add(this.tabPage2);
            this.MentorTabControl.Location = new System.Drawing.Point(0, 1);
            this.MentorTabControl.Name = "MentorTabControl";
            this.MentorTabControl.SelectedIndex = 0;
            this.MentorTabControl.Size = new System.Drawing.Size(1924, 1050);
            this.MentorTabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Lavender;
            this.tabPage1.Controls.Add(this.MentorStudentDataGridView);
            this.tabPage1.Controls.Add(this.Students);
            this.tabPage1.Controls.Add(this.MentorManagementHeader);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1916, 1021);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Home";
            // 
            // MentorStudentDataGridView
            // 
            this.MentorStudentDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.MentorStudentDataGridView.AutoGenerateColumns = false;
            this.MentorStudentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MentorStudentDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sTUNUMDataGridViewTextBoxColumn,
            this.sTUFNAMEDataGridViewTextBoxColumn,
            this.sTULNAMEDataGridViewTextBoxColumn,
            this.sTUPHONENUMDataGridViewTextBoxColumn,
            this.sTUEMAILDataGridViewTextBoxColumn,
            this.sTUYEARDataGridViewTextBoxColumn});
            this.MentorStudentDataGridView.DataSource = this.sTUDENTBindingSource;
            this.MentorStudentDataGridView.Location = new System.Drawing.Point(141, 192);
            this.MentorStudentDataGridView.Name = "MentorStudentDataGridView";
            this.MentorStudentDataGridView.RowHeadersWidth = 51;
            this.MentorStudentDataGridView.RowTemplate.Height = 24;
            this.MentorStudentDataGridView.Size = new System.Drawing.Size(1393, 80);
            this.MentorStudentDataGridView.TabIndex = 3;
            this.MentorStudentDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // sTUNUMDataGridViewTextBoxColumn
            // 
            this.sTUNUMDataGridViewTextBoxColumn.DataPropertyName = "STU_NUM";
            this.sTUNUMDataGridViewTextBoxColumn.HeaderText = "Student Number";
            this.sTUNUMDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sTUNUMDataGridViewTextBoxColumn.Name = "sTUNUMDataGridViewTextBoxColumn";
            this.sTUNUMDataGridViewTextBoxColumn.Width = 200;
            // 
            // sTUFNAMEDataGridViewTextBoxColumn
            // 
            this.sTUFNAMEDataGridViewTextBoxColumn.DataPropertyName = "STU_FNAME";
            this.sTUFNAMEDataGridViewTextBoxColumn.HeaderText = "First Name";
            this.sTUFNAMEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sTUFNAMEDataGridViewTextBoxColumn.Name = "sTUFNAMEDataGridViewTextBoxColumn";
            this.sTUFNAMEDataGridViewTextBoxColumn.Width = 200;
            // 
            // sTULNAMEDataGridViewTextBoxColumn
            // 
            this.sTULNAMEDataGridViewTextBoxColumn.DataPropertyName = "STU_LNAME";
            this.sTULNAMEDataGridViewTextBoxColumn.HeaderText = "Last Name";
            this.sTULNAMEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sTULNAMEDataGridViewTextBoxColumn.Name = "sTULNAMEDataGridViewTextBoxColumn";
            this.sTULNAMEDataGridViewTextBoxColumn.Width = 200;
            // 
            // sTUPHONENUMDataGridViewTextBoxColumn
            // 
            this.sTUPHONENUMDataGridViewTextBoxColumn.DataPropertyName = "STU_PHONENUM";
            this.sTUPHONENUMDataGridViewTextBoxColumn.HeaderText = "Phone Number";
            this.sTUPHONENUMDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sTUPHONENUMDataGridViewTextBoxColumn.Name = "sTUPHONENUMDataGridViewTextBoxColumn";
            this.sTUPHONENUMDataGridViewTextBoxColumn.Width = 130;
            // 
            // sTUEMAILDataGridViewTextBoxColumn
            // 
            this.sTUEMAILDataGridViewTextBoxColumn.DataPropertyName = "STU_EMAIL";
            this.sTUEMAILDataGridViewTextBoxColumn.HeaderText = "Email";
            this.sTUEMAILDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sTUEMAILDataGridViewTextBoxColumn.Name = "sTUEMAILDataGridViewTextBoxColumn";
            this.sTUEMAILDataGridViewTextBoxColumn.Width = 200;
            // 
            // sTUYEARDataGridViewTextBoxColumn
            // 
            this.sTUYEARDataGridViewTextBoxColumn.DataPropertyName = "STU_YEAR";
            this.sTUYEARDataGridViewTextBoxColumn.HeaderText = "Year Of Study";
            this.sTUYEARDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sTUYEARDataGridViewTextBoxColumn.Name = "sTUYEARDataGridViewTextBoxColumn";
            this.sTUYEARDataGridViewTextBoxColumn.Width = 60;
            // 
            // sTUDENTBindingSource
            // 
            this.sTUDENTBindingSource.DataMember = "STUDENT";
            this.sTUDENTBindingSource.DataSource = this.mentorManagementDataSetBindingSource;
            // 
            // mentorManagementDataSetBindingSource
            // 
            this.mentorManagementDataSetBindingSource.DataSource = this.mentorManagementDataSet;
            this.mentorManagementDataSetBindingSource.Position = 0;
            // 
            // mentorManagementDataSet
            // 
            this.mentorManagementDataSet.DataSetName = "MentorManagementDataSet";
            this.mentorManagementDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Students
            // 
            this.Students.AutoSize = true;
            this.Students.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Students.Location = new System.Drawing.Point(400, 164);
            this.Students.Name = "Students";
            this.Students.Size = new System.Drawing.Size(167, 25);
            this.Students.TabIndex = 1;
            this.Students.Text = "List Of Students";
            // 
            // MentorManagementHeader
            // 
            this.MentorManagementHeader.AutoSize = true;
            this.MentorManagementHeader.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MentorManagementHeader.Location = new System.Drawing.Point(3, 3);
            this.MentorManagementHeader.Name = "MentorManagementHeader";
            this.MentorManagementHeader.Size = new System.Drawing.Size(496, 36);
            this.MentorManagementHeader.TabIndex = 0;
            this.MentorManagementHeader.Text = "Mentor Management System";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Lavender;
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.MentorSaveChangesBtn);
            this.tabPage2.Controls.Add(this.MentorLogoutProfile);
            this.tabPage2.Controls.Add(this.CourseListGroupBox);
            this.tabPage2.Controls.Add(this.PasswordGroupBox);
            this.tabPage2.Controls.Add(this.MentorUpdateGroupBox);
            this.tabPage2.Controls.Add(this.MentorDetailsGroupBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1916, 1021);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Profile";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(496, 36);
            this.label1.TabIndex = 15;
            this.label1.Text = "Mentor Management System";
            // 
            // MentorSaveChangesBtn
            // 
            this.MentorSaveChangesBtn.BackColor = System.Drawing.Color.AliceBlue;
            this.MentorSaveChangesBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MentorSaveChangesBtn.ForeColor = System.Drawing.Color.Lime;
            this.MentorSaveChangesBtn.Location = new System.Drawing.Point(1311, 900);
            this.MentorSaveChangesBtn.Name = "MentorSaveChangesBtn";
            this.MentorSaveChangesBtn.Size = new System.Drawing.Size(154, 43);
            this.MentorSaveChangesBtn.TabIndex = 14;
            this.MentorSaveChangesBtn.Text = "Save";
            this.MentorSaveChangesBtn.UseVisualStyleBackColor = false;
            this.MentorSaveChangesBtn.Click += new System.EventHandler(this.MentorSaveChangesBtn_Click);
            // 
            // MentorLogoutProfile
            // 
            this.MentorLogoutProfile.BackColor = System.Drawing.Color.AliceBlue;
            this.MentorLogoutProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MentorLogoutProfile.ForeColor = System.Drawing.Color.Red;
            this.MentorLogoutProfile.Location = new System.Drawing.Point(1731, 41);
            this.MentorLogoutProfile.Name = "MentorLogoutProfile";
            this.MentorLogoutProfile.Size = new System.Drawing.Size(154, 43);
            this.MentorLogoutProfile.TabIndex = 13;
            this.MentorLogoutProfile.Text = "Log Out";
            this.MentorLogoutProfile.UseVisualStyleBackColor = false;
            this.MentorLogoutProfile.Click += new System.EventHandler(this.MentorLogoutProfile_Click);
            // 
            // CourseListGroupBox
            // 
            this.CourseListGroupBox.BackColor = System.Drawing.Color.AliceBlue;
            this.CourseListGroupBox.Controls.Add(this.MentorCourseUpdateComboBox);
            this.CourseListGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CourseListGroupBox.Location = new System.Drawing.Point(1029, 457);
            this.CourseListGroupBox.Name = "CourseListGroupBox";
            this.CourseListGroupBox.Size = new System.Drawing.Size(436, 413);
            this.CourseListGroupBox.TabIndex = 11;
            this.CourseListGroupBox.TabStop = false;
            this.CourseListGroupBox.Text = "Course List";
            // 
            // MentorCourseUpdateComboBox
            // 
            this.MentorCourseUpdateComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MentorCourseUpdateComboBox.FormattingEnabled = true;
            this.MentorCourseUpdateComboBox.Items.AddRange(new object[] {
            "B Sc Stream LES (Life Earth Sciences)",
            "B Sc Stream M (Mathematics)",
            "B Sc Applied Chemistry",
            "B Sc Biological Science",
            "B Sc Geological Science",
            "B Sc Marine Biology",
            "B Sc 4 Augmented Programme",
            "B Sc Computer Science and Information...",
            "B Sc Environmental Science",
            "B Sc Environmental Earth Science",
            "Bachelor of Audiology",
            "B Dental Therapy",
            "B Occupational Therapy",
            "B Optometry",
            "B Pharmacy",
            "B Physiotherapy",
            "B Medical Science: Anatomy",
            "B Medical Science: Physiology",
            "B Sport Science ",
            "B Business Administration",
            "B Com",
            "B Business Science",
            "B Com Accounting",
            "B Com Extended Curriculum (General)",
            "B Com Extended Curriculum (Accounting)"});
            this.MentorCourseUpdateComboBox.Location = new System.Drawing.Point(35, 106);
            this.MentorCourseUpdateComboBox.Name = "MentorCourseUpdateComboBox";
            this.MentorCourseUpdateComboBox.Size = new System.Drawing.Size(359, 28);
            this.MentorCourseUpdateComboBox.TabIndex = 0;
            this.MentorCourseUpdateComboBox.Text = "Select";
            // 
            // PasswordGroupBox
            // 
            this.PasswordGroupBox.BackColor = System.Drawing.Color.AliceBlue;
            this.PasswordGroupBox.Controls.Add(this.ConfirmPasswordUpdateInputBox);
            this.PasswordGroupBox.Controls.Add(this.NewPasswordUpdateInputBox);
            this.PasswordGroupBox.Controls.Add(this.checkBox1);
            this.PasswordGroupBox.Controls.Add(this.ConfirmPasswordUpdateLabel);
            this.PasswordGroupBox.Controls.Add(this.NewPasswordUpdateLabel);
            this.PasswordGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordGroupBox.Location = new System.Drawing.Point(55, 736);
            this.PasswordGroupBox.Name = "PasswordGroupBox";
            this.PasswordGroupBox.Size = new System.Drawing.Size(957, 134);
            this.PasswordGroupBox.TabIndex = 10;
            this.PasswordGroupBox.TabStop = false;
            this.PasswordGroupBox.Text = "Password";
            // 
            // ConfirmPasswordUpdateInputBox
            // 
            this.ConfirmPasswordUpdateInputBox.Location = new System.Drawing.Point(523, 65);
            this.ConfirmPasswordUpdateInputBox.Name = "ConfirmPasswordUpdateInputBox";
            this.ConfirmPasswordUpdateInputBox.Size = new System.Drawing.Size(315, 30);
            this.ConfirmPasswordUpdateInputBox.TabIndex = 4;
            // 
            // NewPasswordUpdateInputBox
            // 
            this.NewPasswordUpdateInputBox.Location = new System.Drawing.Point(37, 65);
            this.NewPasswordUpdateInputBox.Name = "NewPasswordUpdateInputBox";
            this.NewPasswordUpdateInputBox.Size = new System.Drawing.Size(315, 30);
            this.NewPasswordUpdateInputBox.TabIndex = 3;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(36, 101);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(125, 20);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "Show Password";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // ConfirmPasswordUpdateLabel
            // 
            this.ConfirmPasswordUpdateLabel.AutoSize = true;
            this.ConfirmPasswordUpdateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmPasswordUpdateLabel.Location = new System.Drawing.Point(519, 42);
            this.ConfirmPasswordUpdateLabel.Name = "ConfirmPasswordUpdateLabel";
            this.ConfirmPasswordUpdateLabel.Size = new System.Drawing.Size(147, 20);
            this.ConfirmPasswordUpdateLabel.TabIndex = 1;
            this.ConfirmPasswordUpdateLabel.Text = "Confirm Password";
            // 
            // NewPasswordUpdateLabel
            // 
            this.NewPasswordUpdateLabel.AutoSize = true;
            this.NewPasswordUpdateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewPasswordUpdateLabel.Location = new System.Drawing.Point(33, 42);
            this.NewPasswordUpdateLabel.Name = "NewPasswordUpdateLabel";
            this.NewPasswordUpdateLabel.Size = new System.Drawing.Size(121, 20);
            this.NewPasswordUpdateLabel.TabIndex = 0;
            this.NewPasswordUpdateLabel.Text = "New Password";
            // 
            // MentorUpdateGroupBox
            // 
            this.MentorUpdateGroupBox.BackColor = System.Drawing.Color.AliceBlue;
            this.MentorUpdateGroupBox.Controls.Add(this.MentorPhoneNumberUpdateInputBox);
            this.MentorUpdateGroupBox.Controls.Add(this.MentorLastNameUpdateInputBox);
            this.MentorUpdateGroupBox.Controls.Add(this.MentorFirstNameUpdateInputBox);
            this.MentorUpdateGroupBox.Controls.Add(this.StudentPhoneNumberUpdateLabel);
            this.MentorUpdateGroupBox.Controls.Add(this.StudentLastNameUpdateLabel);
            this.MentorUpdateGroupBox.Controls.Add(this.StudentFirstNameUpdateLabel);
            this.MentorUpdateGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MentorUpdateGroupBox.Location = new System.Drawing.Point(55, 466);
            this.MentorUpdateGroupBox.Name = "MentorUpdateGroupBox";
            this.MentorUpdateGroupBox.Size = new System.Drawing.Size(957, 247);
            this.MentorUpdateGroupBox.TabIndex = 7;
            this.MentorUpdateGroupBox.TabStop = false;
            this.MentorUpdateGroupBox.Text = "Mentor Update";
            // 
            // MentorPhoneNumberUpdateInputBox
            // 
            this.MentorPhoneNumberUpdateInputBox.Location = new System.Drawing.Point(592, 67);
            this.MentorPhoneNumberUpdateInputBox.Name = "MentorPhoneNumberUpdateInputBox";
            this.MentorPhoneNumberUpdateInputBox.Size = new System.Drawing.Size(326, 30);
            this.MentorPhoneNumberUpdateInputBox.TabIndex = 7;
            // 
            // MentorLastNameUpdateInputBox
            // 
            this.MentorLastNameUpdateInputBox.Location = new System.Drawing.Point(34, 142);
            this.MentorLastNameUpdateInputBox.Name = "MentorLastNameUpdateInputBox";
            this.MentorLastNameUpdateInputBox.Size = new System.Drawing.Size(385, 30);
            this.MentorLastNameUpdateInputBox.TabIndex = 5;
            // 
            // MentorFirstNameUpdateInputBox
            // 
            this.MentorFirstNameUpdateInputBox.Location = new System.Drawing.Point(34, 67);
            this.MentorFirstNameUpdateInputBox.Name = "MentorFirstNameUpdateInputBox";
            this.MentorFirstNameUpdateInputBox.Size = new System.Drawing.Size(385, 30);
            this.MentorFirstNameUpdateInputBox.TabIndex = 4;
            // 
            // StudentPhoneNumberUpdateLabel
            // 
            this.StudentPhoneNumberUpdateLabel.AutoSize = true;
            this.StudentPhoneNumberUpdateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentPhoneNumberUpdateLabel.Location = new System.Drawing.Point(594, 46);
            this.StudentPhoneNumberUpdateLabel.Name = "StudentPhoneNumberUpdateLabel";
            this.StudentPhoneNumberUpdateLabel.Size = new System.Drawing.Size(108, 18);
            this.StudentPhoneNumberUpdateLabel.TabIndex = 2;
            this.StudentPhoneNumberUpdateLabel.Text = "Phone Number";
            // 
            // StudentLastNameUpdateLabel
            // 
            this.StudentLastNameUpdateLabel.AutoSize = true;
            this.StudentLastNameUpdateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentLastNameUpdateLabel.Location = new System.Drawing.Point(34, 121);
            this.StudentLastNameUpdateLabel.Name = "StudentLastNameUpdateLabel";
            this.StudentLastNameUpdateLabel.Size = new System.Drawing.Size(80, 18);
            this.StudentLastNameUpdateLabel.TabIndex = 1;
            this.StudentLastNameUpdateLabel.Text = "Last Name";
            // 
            // StudentFirstNameUpdateLabel
            // 
            this.StudentFirstNameUpdateLabel.AutoSize = true;
            this.StudentFirstNameUpdateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentFirstNameUpdateLabel.Location = new System.Drawing.Point(33, 46);
            this.StudentFirstNameUpdateLabel.Name = "StudentFirstNameUpdateLabel";
            this.StudentFirstNameUpdateLabel.Size = new System.Drawing.Size(81, 18);
            this.StudentFirstNameUpdateLabel.TabIndex = 0;
            this.StudentFirstNameUpdateLabel.Text = "First Name";
            // 
            // MentorDetailsGroupBox
            // 
            this.MentorDetailsGroupBox.BackColor = System.Drawing.Color.AliceBlue;
            this.MentorDetailsGroupBox.Controls.Add(this.MentorPhoneNumberResults);
            this.MentorDetailsGroupBox.Controls.Add(this.MentorEmailResults);
            this.MentorDetailsGroupBox.Controls.Add(this.MentorLastNameResults);
            this.MentorDetailsGroupBox.Controls.Add(this.MentorFirstNameResults);
            this.MentorDetailsGroupBox.Controls.Add(this.PhoneNumberMentorDetailsLabel);
            this.MentorDetailsGroupBox.Controls.Add(this.EmailDetailsMentorLabel);
            this.MentorDetailsGroupBox.Controls.Add(this.LastNameMentorDetails);
            this.MentorDetailsGroupBox.Controls.Add(this.FirstNameMentorDetails);
            this.MentorDetailsGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MentorDetailsGroupBox.Location = new System.Drawing.Point(55, 172);
            this.MentorDetailsGroupBox.Name = "MentorDetailsGroupBox";
            this.MentorDetailsGroupBox.Size = new System.Drawing.Size(1410, 257);
            this.MentorDetailsGroupBox.TabIndex = 6;
            this.MentorDetailsGroupBox.TabStop = false;
            this.MentorDetailsGroupBox.Text = "Mentor Details";
            // 
            // MentorPhoneNumberResults
            // 
            this.MentorPhoneNumberResults.AutoSize = true;
            this.MentorPhoneNumberResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MentorPhoneNumberResults.Location = new System.Drawing.Point(1004, 197);
            this.MentorPhoneNumberResults.Name = "MentorPhoneNumberResults";
            this.MentorPhoneNumberResults.Size = new System.Drawing.Size(209, 25);
            this.MentorPhoneNumberResults.TabIndex = 8;
            this.MentorPhoneNumberResults.Text = "Mentor Phone Number";
            // 
            // MentorEmailResults
            // 
            this.MentorEmailResults.AutoSize = true;
            this.MentorEmailResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MentorEmailResults.Location = new System.Drawing.Point(1004, 147);
            this.MentorEmailResults.Name = "MentorEmailResults";
            this.MentorEmailResults.Size = new System.Drawing.Size(126, 25);
            this.MentorEmailResults.TabIndex = 7;
            this.MentorEmailResults.Text = "Mentor Email";
            // 
            // MentorLastNameResults
            // 
            this.MentorLastNameResults.AutoSize = true;
            this.MentorLastNameResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MentorLastNameResults.Location = new System.Drawing.Point(1004, 100);
            this.MentorLastNameResults.Name = "MentorLastNameResults";
            this.MentorLastNameResults.Size = new System.Drawing.Size(172, 25);
            this.MentorLastNameResults.TabIndex = 6;
            this.MentorLastNameResults.Text = "Mentor Last Name";
            // 
            // MentorFirstNameResults
            // 
            this.MentorFirstNameResults.AutoSize = true;
            this.MentorFirstNameResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MentorFirstNameResults.Location = new System.Drawing.Point(1004, 51);
            this.MentorFirstNameResults.Name = "MentorFirstNameResults";
            this.MentorFirstNameResults.Size = new System.Drawing.Size(172, 25);
            this.MentorFirstNameResults.TabIndex = 5;
            this.MentorFirstNameResults.Text = "Mentor First Name";
            // 
            // PhoneNumberMentorDetailsLabel
            // 
            this.PhoneNumberMentorDetailsLabel.AutoSize = true;
            this.PhoneNumberMentorDetailsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneNumberMentorDetailsLabel.Location = new System.Drawing.Point(35, 197);
            this.PhoneNumberMentorDetailsLabel.Name = "PhoneNumberMentorDetailsLabel";
            this.PhoneNumberMentorDetailsLabel.Size = new System.Drawing.Size(143, 25);
            this.PhoneNumberMentorDetailsLabel.TabIndex = 3;
            this.PhoneNumberMentorDetailsLabel.Text = "Phone Number";
            // 
            // EmailDetailsMentorLabel
            // 
            this.EmailDetailsMentorLabel.AutoSize = true;
            this.EmailDetailsMentorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailDetailsMentorLabel.Location = new System.Drawing.Point(35, 147);
            this.EmailDetailsMentorLabel.Name = "EmailDetailsMentorLabel";
            this.EmailDetailsMentorLabel.Size = new System.Drawing.Size(60, 25);
            this.EmailDetailsMentorLabel.TabIndex = 2;
            this.EmailDetailsMentorLabel.Text = "Email";
            // 
            // LastNameMentorDetails
            // 
            this.LastNameMentorDetails.AutoSize = true;
            this.LastNameMentorDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastNameMentorDetails.Location = new System.Drawing.Point(35, 100);
            this.LastNameMentorDetails.Name = "LastNameMentorDetails";
            this.LastNameMentorDetails.Size = new System.Drawing.Size(106, 25);
            this.LastNameMentorDetails.TabIndex = 1;
            this.LastNameMentorDetails.Text = "Last Name";
            // 
            // FirstNameMentorDetails
            // 
            this.FirstNameMentorDetails.AutoSize = true;
            this.FirstNameMentorDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstNameMentorDetails.Location = new System.Drawing.Point(35, 51);
            this.FirstNameMentorDetails.Name = "FirstNameMentorDetails";
            this.FirstNameMentorDetails.Size = new System.Drawing.Size(106, 25);
            this.FirstNameMentorDetails.TabIndex = 0;
            this.FirstNameMentorDetails.Text = "First Name";
            // 
            // sTUDENTTableAdapter
            // 
            this.sTUDENTTableAdapter.ClearBeforeFill = true;
            // 
            // MentorPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1924, 1051);
            this.Controls.Add(this.MentorTabControl);
            this.MinimizeBox = false;
            this.Name = "MentorPage";
            this.Text = "Mentor";
            this.Load += new System.EventHandler(this.MentorPage_Load);
            this.MentorTabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MentorStudentDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTUDENTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mentorManagementDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mentorManagementDataSet)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.CourseListGroupBox.ResumeLayout(false);
            this.PasswordGroupBox.ResumeLayout(false);
            this.PasswordGroupBox.PerformLayout();
            this.MentorUpdateGroupBox.ResumeLayout(false);
            this.MentorUpdateGroupBox.PerformLayout();
            this.MentorDetailsGroupBox.ResumeLayout(false);
            this.MentorDetailsGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl MentorTabControl;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox MentorDetailsGroupBox;
        private System.Windows.Forms.Label PhoneNumberMentorDetailsLabel;
        private System.Windows.Forms.Label EmailDetailsMentorLabel;
        private System.Windows.Forms.Label LastNameMentorDetails;
        private System.Windows.Forms.Label FirstNameMentorDetails;
        private System.Windows.Forms.GroupBox MentorUpdateGroupBox;
        private System.Windows.Forms.TextBox MentorPhoneNumberUpdateInputBox;
        private System.Windows.Forms.TextBox MentorLastNameUpdateInputBox;
        private System.Windows.Forms.TextBox MentorFirstNameUpdateInputBox;
        private System.Windows.Forms.Label StudentPhoneNumberUpdateLabel;
        private System.Windows.Forms.Label StudentLastNameUpdateLabel;
        private System.Windows.Forms.Label StudentFirstNameUpdateLabel;
        private System.Windows.Forms.GroupBox PasswordGroupBox;
        private System.Windows.Forms.TextBox ConfirmPasswordUpdateInputBox;
        private System.Windows.Forms.TextBox NewPasswordUpdateInputBox;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label ConfirmPasswordUpdateLabel;
        private System.Windows.Forms.Label NewPasswordUpdateLabel;
        private System.Windows.Forms.GroupBox CourseListGroupBox;
        private System.Windows.Forms.ComboBox MentorCourseUpdateComboBox;
        private System.Windows.Forms.Button MentorLogoutProfile;
        private System.Windows.Forms.Button MentorSaveChangesBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label MentorFirstNameResults;
        private System.Windows.Forms.Label MentorPhoneNumberResults;
        private System.Windows.Forms.Label MentorEmailResults;
        private System.Windows.Forms.Label MentorLastNameResults;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView MentorStudentDataGridView;
        private System.Windows.Forms.BindingSource mentorManagementDataSetBindingSource;
        private MentorManagementDataSet mentorManagementDataSet;
        private System.Windows.Forms.Label Students;
        private System.Windows.Forms.Label MentorManagementHeader;
        private System.Windows.Forms.BindingSource sTUDENTBindingSource;
        private MentorManagementDataSetTableAdapters.STUDENTTableAdapter sTUDENTTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTUNUMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTUFNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTULNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTUPHONENUMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTUEMAILDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTUYEARDataGridViewTextBoxColumn;
    }
}