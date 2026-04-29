namespace MentorManagementSystem
{
    partial class AdminForm
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
            this.AdminMentorManagementLogo = new System.Windows.Forms.Label();
            this.AdminStudentsDataGridView = new System.Windows.Forms.DataGridView();
            this.sTUNUMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTUFNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTULNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTUPHONENUMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTUEMAILDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTUYEARDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cOURSECODEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aLLOCATIONSTATUSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTUDENTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mentorManagementDataSet = new MentorManagementSystem.MentorManagementDataSet();
            this.AdminStudentTabelLabel = new System.Windows.Forms.Label();
            this.AdminMentorsTableLabel = new System.Windows.Forms.Label();
            this.AdminMentorDataGridView = new System.Windows.Forms.DataGridView();
            this.mENTORIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mENTORFNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mENTORLNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mENTORPHONENODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mENTOREMAILDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mENTORSTATUSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sCHOOLIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mENTORBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.AdminStudentNumberInputBox = new System.Windows.Forms.TextBox();
            this.AdminMentorIDIInputBox = new System.Windows.Forms.TextBox();
            this.AdminActiveStatusComboBox = new System.Windows.Forms.ComboBox();
            this.AdminStudentNumberLabel = new System.Windows.Forms.Label();
            this.AdminMentorLabel = new System.Windows.Forms.Label();
            this.AdminStatusLabel = new System.Windows.Forms.Label();
            this.AdminAllocationButton = new System.Windows.Forms.Button();
            this.AdminSearchBarGroupBox = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AdminDeleteBtn = new System.Windows.Forms.Button();
            this.AdminSearchForLabel = new System.Windows.Forms.Label();
            this.AdminSearchByComboBox = new System.Windows.Forms.ComboBox();
            this.AdminSearchBtn = new System.Windows.Forms.Button();
            this.AdminSearchInputBox = new System.Windows.Forms.TextBox();
            this.AdminResultsTable = new System.Windows.Forms.DataGridView();
            this.sTUDENTTableAdapter = new MentorManagementSystem.MentorManagementDataSetTableAdapters.STUDENTTableAdapter();
            this.mENTORTableAdapter = new MentorManagementSystem.MentorManagementDataSetTableAdapters.MENTORTableAdapter();
            this.AdminLogOutBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AdminStudentsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTUDENTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mentorManagementDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AdminMentorDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mENTORBindingSource)).BeginInit();
            this.AdminSearchBarGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AdminResultsTable)).BeginInit();
            this.SuspendLayout();
            // 
            // AdminMentorManagementLogo
            // 
            this.AdminMentorManagementLogo.AutoSize = true;
            this.AdminMentorManagementLogo.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminMentorManagementLogo.Location = new System.Drawing.Point(2, 0);
            this.AdminMentorManagementLogo.Name = "AdminMentorManagementLogo";
            this.AdminMentorManagementLogo.Size = new System.Drawing.Size(496, 36);
            this.AdminMentorManagementLogo.TabIndex = 1;
            this.AdminMentorManagementLogo.Text = "Mentor Management System";
            this.AdminMentorManagementLogo.Click += new System.EventHandler(this.AdminMentorManagementLogo_Click);
            // 
            // AdminStudentsDataGridView
            // 
            this.AdminStudentsDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AdminStudentsDataGridView.AutoGenerateColumns = false;
            this.AdminStudentsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AdminStudentsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sTUNUMDataGridViewTextBoxColumn,
            this.sTUFNAMEDataGridViewTextBoxColumn,
            this.sTULNAMEDataGridViewTextBoxColumn,
            this.sTUPHONENUMDataGridViewTextBoxColumn,
            this.sTUEMAILDataGridViewTextBoxColumn,
            this.sTUYEARDataGridViewTextBoxColumn,
            this.cOURSECODEDataGridViewTextBoxColumn,
            this.aLLOCATIONSTATUSDataGridViewTextBoxColumn});
            this.AdminStudentsDataGridView.DataSource = this.sTUDENTBindingSource;
            this.AdminStudentsDataGridView.Location = new System.Drawing.Point(56, 294);
            this.AdminStudentsDataGridView.Name = "AdminStudentsDataGridView";
            this.AdminStudentsDataGridView.RowHeadersWidth = 51;
            this.AdminStudentsDataGridView.RowTemplate.Height = 24;
            this.AdminStudentsDataGridView.Size = new System.Drawing.Size(1076, 115);
            this.AdminStudentsDataGridView.TabIndex = 2;
            this.AdminStudentsDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AdminStudentsDataGridView_CellContentClick);
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
            this.sTUPHONENUMDataGridViewTextBoxColumn.Width = 120;
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
            this.sTUYEARDataGridViewTextBoxColumn.Width = 50;
            // 
            // cOURSECODEDataGridViewTextBoxColumn
            // 
            this.cOURSECODEDataGridViewTextBoxColumn.DataPropertyName = "COURSE_CODE";
            this.cOURSECODEDataGridViewTextBoxColumn.HeaderText = "Course Code";
            this.cOURSECODEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cOURSECODEDataGridViewTextBoxColumn.Name = "cOURSECODEDataGridViewTextBoxColumn";
            this.cOURSECODEDataGridViewTextBoxColumn.Width = 50;
            // 
            // aLLOCATIONSTATUSDataGridViewTextBoxColumn
            // 
            this.aLLOCATIONSTATUSDataGridViewTextBoxColumn.DataPropertyName = "ALLOCATION_STATUS";
            this.aLLOCATIONSTATUSDataGridViewTextBoxColumn.HeaderText = "Allocation Status";
            this.aLLOCATIONSTATUSDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.aLLOCATIONSTATUSDataGridViewTextBoxColumn.Name = "aLLOCATIONSTATUSDataGridViewTextBoxColumn";
            this.aLLOCATIONSTATUSDataGridViewTextBoxColumn.Width = 125;
            // 
            // sTUDENTBindingSource
            // 
            this.sTUDENTBindingSource.DataMember = "STUDENT";
            this.sTUDENTBindingSource.DataSource = this.mentorManagementDataSet;
            // 
            // mentorManagementDataSet
            // 
            this.mentorManagementDataSet.DataSetName = "MentorManagementDataSet";
            this.mentorManagementDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // AdminStudentTabelLabel
            // 
            this.AdminStudentTabelLabel.AutoSize = true;
            this.AdminStudentTabelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminStudentTabelLabel.Location = new System.Drawing.Point(51, 262);
            this.AdminStudentTabelLabel.Name = "AdminStudentTabelLabel";
            this.AdminStudentTabelLabel.Size = new System.Drawing.Size(115, 29);
            this.AdminStudentTabelLabel.TabIndex = 3;
            this.AdminStudentTabelLabel.Text = "Students";
            this.AdminStudentTabelLabel.Click += new System.EventHandler(this.AdminStudentTabelLabel_Click);
            // 
            // AdminMentorsTableLabel
            // 
            this.AdminMentorsTableLabel.AutoSize = true;
            this.AdminMentorsTableLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminMentorsTableLabel.Location = new System.Drawing.Point(59, 576);
            this.AdminMentorsTableLabel.Name = "AdminMentorsTableLabel";
            this.AdminMentorsTableLabel.Size = new System.Drawing.Size(107, 29);
            this.AdminMentorsTableLabel.TabIndex = 4;
            this.AdminMentorsTableLabel.Text = "Mentors";
            // 
            // AdminMentorDataGridView
            // 
            this.AdminMentorDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AdminMentorDataGridView.AutoGenerateColumns = false;
            this.AdminMentorDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AdminMentorDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mENTORIDDataGridViewTextBoxColumn,
            this.mENTORFNAMEDataGridViewTextBoxColumn,
            this.mENTORLNAMEDataGridViewTextBoxColumn,
            this.mENTORPHONENODataGridViewTextBoxColumn,
            this.mENTOREMAILDataGridViewTextBoxColumn,
            this.mENTORSTATUSDataGridViewTextBoxColumn,
            this.sCHOOLIDDataGridViewTextBoxColumn});
            this.AdminMentorDataGridView.DataSource = this.mENTORBindingSource;
            this.AdminMentorDataGridView.Location = new System.Drawing.Point(64, 608);
            this.AdminMentorDataGridView.Name = "AdminMentorDataGridView";
            this.AdminMentorDataGridView.RowHeadersWidth = 51;
            this.AdminMentorDataGridView.RowTemplate.Height = 24;
            this.AdminMentorDataGridView.Size = new System.Drawing.Size(906, 103);
            this.AdminMentorDataGridView.TabIndex = 5;
            // 
            // mENTORIDDataGridViewTextBoxColumn
            // 
            this.mENTORIDDataGridViewTextBoxColumn.DataPropertyName = "MENTOR_ID";
            this.mENTORIDDataGridViewTextBoxColumn.HeaderText = "Mentor ID";
            this.mENTORIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mENTORIDDataGridViewTextBoxColumn.Name = "mENTORIDDataGridViewTextBoxColumn";
            this.mENTORIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.mENTORIDDataGridViewTextBoxColumn.Width = 50;
            // 
            // mENTORFNAMEDataGridViewTextBoxColumn
            // 
            this.mENTORFNAMEDataGridViewTextBoxColumn.DataPropertyName = "MENTOR_FNAME";
            this.mENTORFNAMEDataGridViewTextBoxColumn.HeaderText = "First Name";
            this.mENTORFNAMEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mENTORFNAMEDataGridViewTextBoxColumn.Name = "mENTORFNAMEDataGridViewTextBoxColumn";
            this.mENTORFNAMEDataGridViewTextBoxColumn.Width = 200;
            // 
            // mENTORLNAMEDataGridViewTextBoxColumn
            // 
            this.mENTORLNAMEDataGridViewTextBoxColumn.DataPropertyName = "MENTOR_LNAME";
            this.mENTORLNAMEDataGridViewTextBoxColumn.HeaderText = "Last Name";
            this.mENTORLNAMEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mENTORLNAMEDataGridViewTextBoxColumn.Name = "mENTORLNAMEDataGridViewTextBoxColumn";
            this.mENTORLNAMEDataGridViewTextBoxColumn.Width = 200;
            // 
            // mENTORPHONENODataGridViewTextBoxColumn
            // 
            this.mENTORPHONENODataGridViewTextBoxColumn.DataPropertyName = "MENTOR_PHONE_NO";
            this.mENTORPHONENODataGridViewTextBoxColumn.HeaderText = "Phone Number";
            this.mENTORPHONENODataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mENTORPHONENODataGridViewTextBoxColumn.Name = "mENTORPHONENODataGridViewTextBoxColumn";
            this.mENTORPHONENODataGridViewTextBoxColumn.Width = 140;
            // 
            // mENTOREMAILDataGridViewTextBoxColumn
            // 
            this.mENTOREMAILDataGridViewTextBoxColumn.DataPropertyName = "MENTOR_EMAIL";
            this.mENTOREMAILDataGridViewTextBoxColumn.HeaderText = "Email";
            this.mENTOREMAILDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mENTOREMAILDataGridViewTextBoxColumn.Name = "mENTOREMAILDataGridViewTextBoxColumn";
            this.mENTOREMAILDataGridViewTextBoxColumn.Width = 200;
            // 
            // mENTORSTATUSDataGridViewTextBoxColumn
            // 
            this.mENTORSTATUSDataGridViewTextBoxColumn.DataPropertyName = "MENTOR_STATUS";
            this.mENTORSTATUSDataGridViewTextBoxColumn.HeaderText = "Allocation Status";
            this.mENTORSTATUSDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mENTORSTATUSDataGridViewTextBoxColumn.Name = "mENTORSTATUSDataGridViewTextBoxColumn";
            this.mENTORSTATUSDataGridViewTextBoxColumn.Width = 125;
            // 
            // sCHOOLIDDataGridViewTextBoxColumn
            // 
            this.sCHOOLIDDataGridViewTextBoxColumn.DataPropertyName = "SCHOOL_ID";
            this.sCHOOLIDDataGridViewTextBoxColumn.HeaderText = "School ID";
            this.sCHOOLIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sCHOOLIDDataGridViewTextBoxColumn.Name = "sCHOOLIDDataGridViewTextBoxColumn";
            this.sCHOOLIDDataGridViewTextBoxColumn.Width = 50;
            // 
            // mENTORBindingSource
            // 
            this.mENTORBindingSource.DataMember = "MENTOR";
            this.mENTORBindingSource.DataSource = this.mentorManagementDataSet;
            // 
            // AdminStudentNumberInputBox
            // 
            this.AdminStudentNumberInputBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminStudentNumberInputBox.Location = new System.Drawing.Point(80, 891);
            this.AdminStudentNumberInputBox.Name = "AdminStudentNumberInputBox";
            this.AdminStudentNumberInputBox.Size = new System.Drawing.Size(301, 30);
            this.AdminStudentNumberInputBox.TabIndex = 6;
            this.AdminStudentNumberInputBox.TextChanged += new System.EventHandler(this.AdminStudentNumberInputBox_TextChanged);
            // 
            // AdminMentorIDIInputBox
            // 
            this.AdminMentorIDIInputBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminMentorIDIInputBox.Location = new System.Drawing.Point(507, 890);
            this.AdminMentorIDIInputBox.Name = "AdminMentorIDIInputBox";
            this.AdminMentorIDIInputBox.Size = new System.Drawing.Size(160, 28);
            this.AdminMentorIDIInputBox.TabIndex = 7;
            this.AdminMentorIDIInputBox.TextChanged += new System.EventHandler(this.AdminMentorIDIInputBox_TextChanged);
            // 
            // AdminActiveStatusComboBox
            // 
            this.AdminActiveStatusComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminActiveStatusComboBox.FormattingEnabled = true;
            this.AdminActiveStatusComboBox.Items.AddRange(new object[] {
            "Unactive",
            "Active"});
            this.AdminActiveStatusComboBox.Location = new System.Drawing.Point(816, 892);
            this.AdminActiveStatusComboBox.Name = "AdminActiveStatusComboBox";
            this.AdminActiveStatusComboBox.Size = new System.Drawing.Size(121, 28);
            this.AdminActiveStatusComboBox.TabIndex = 8;
            this.AdminActiveStatusComboBox.Text = "Unactive";
            // 
            // AdminStudentNumberLabel
            // 
            this.AdminStudentNumberLabel.AutoSize = true;
            this.AdminStudentNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminStudentNumberLabel.Location = new System.Drawing.Point(76, 865);
            this.AdminStudentNumberLabel.Name = "AdminStudentNumberLabel";
            this.AdminStudentNumberLabel.Size = new System.Drawing.Size(140, 22);
            this.AdminStudentNumberLabel.TabIndex = 9;
            this.AdminStudentNumberLabel.Text = "Student Number";
            // 
            // AdminMentorLabel
            // 
            this.AdminMentorLabel.AutoSize = true;
            this.AdminMentorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminMentorLabel.Location = new System.Drawing.Point(503, 865);
            this.AdminMentorLabel.Name = "AdminMentorLabel";
            this.AdminMentorLabel.Size = new System.Drawing.Size(87, 22);
            this.AdminMentorLabel.TabIndex = 10;
            this.AdminMentorLabel.Text = "Mentor ID";
            // 
            // AdminStatusLabel
            // 
            this.AdminStatusLabel.AutoSize = true;
            this.AdminStatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminStatusLabel.Location = new System.Drawing.Point(812, 865);
            this.AdminStatusLabel.Name = "AdminStatusLabel";
            this.AdminStatusLabel.Size = new System.Drawing.Size(61, 22);
            this.AdminStatusLabel.TabIndex = 11;
            this.AdminStatusLabel.Text = "Status";
            // 
            // AdminAllocationButton
            // 
            this.AdminAllocationButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminAllocationButton.Location = new System.Drawing.Point(1339, 882);
            this.AdminAllocationButton.Name = "AdminAllocationButton";
            this.AdminAllocationButton.Size = new System.Drawing.Size(116, 46);
            this.AdminAllocationButton.TabIndex = 12;
            this.AdminAllocationButton.Text = "Allocate";
            this.AdminAllocationButton.UseVisualStyleBackColor = true;
            this.AdminAllocationButton.Click += new System.EventHandler(this.AdminAllocationButton_Click);
            // 
            // AdminSearchBarGroupBox
            // 
            this.AdminSearchBarGroupBox.BackColor = System.Drawing.Color.AliceBlue;
            this.AdminSearchBarGroupBox.Controls.Add(this.label1);
            this.AdminSearchBarGroupBox.Controls.Add(this.AdminDeleteBtn);
            this.AdminSearchBarGroupBox.Controls.Add(this.AdminSearchForLabel);
            this.AdminSearchBarGroupBox.Controls.Add(this.AdminSearchByComboBox);
            this.AdminSearchBarGroupBox.Controls.Add(this.AdminSearchBtn);
            this.AdminSearchBarGroupBox.Controls.Add(this.AdminSearchInputBox);
            this.AdminSearchBarGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminSearchBarGroupBox.Location = new System.Drawing.Point(8, 64);
            this.AdminSearchBarGroupBox.Name = "AdminSearchBarGroupBox";
            this.AdminSearchBarGroupBox.Size = new System.Drawing.Size(776, 154);
            this.AdminSearchBarGroupBox.TabIndex = 13;
            this.AdminSearchBarGroupBox.TabStop = false;
            this.AdminSearchBarGroupBox.Text = "Search Bar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "(i.e: search for student number or mentor_id)";
            // 
            // AdminDeleteBtn
            // 
            this.AdminDeleteBtn.ForeColor = System.Drawing.Color.Red;
            this.AdminDeleteBtn.Location = new System.Drawing.Point(636, 101);
            this.AdminDeleteBtn.Name = "AdminDeleteBtn";
            this.AdminDeleteBtn.Size = new System.Drawing.Size(122, 35);
            this.AdminDeleteBtn.TabIndex = 4;
            this.AdminDeleteBtn.Text = "Delete";
            this.AdminDeleteBtn.UseVisualStyleBackColor = true;
            this.AdminDeleteBtn.Click += new System.EventHandler(this.AdminDeleteBtn_Click);
            // 
            // AdminSearchForLabel
            // 
            this.AdminSearchForLabel.AutoSize = true;
            this.AdminSearchForLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminSearchForLabel.Location = new System.Drawing.Point(6, 52);
            this.AdminSearchForLabel.Name = "AdminSearchForLabel";
            this.AdminSearchForLabel.Size = new System.Drawing.Size(99, 22);
            this.AdminSearchForLabel.TabIndex = 3;
            this.AdminSearchForLabel.Text = "Search For";
            // 
            // AdminSearchByComboBox
            // 
            this.AdminSearchByComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminSearchByComboBox.FormattingEnabled = true;
            this.AdminSearchByComboBox.Items.AddRange(new object[] {
            "STUDENT",
            "MENTOR"});
            this.AdminSearchByComboBox.Location = new System.Drawing.Point(111, 52);
            this.AdminSearchByComboBox.Name = "AdminSearchByComboBox";
            this.AdminSearchByComboBox.Size = new System.Drawing.Size(202, 26);
            this.AdminSearchByComboBox.TabIndex = 2;
            this.AdminSearchByComboBox.Text = "STUDENT";
            // 
            // AdminSearchBtn
            // 
            this.AdminSearchBtn.ForeColor = System.Drawing.Color.Lime;
            this.AdminSearchBtn.Location = new System.Drawing.Point(487, 101);
            this.AdminSearchBtn.Name = "AdminSearchBtn";
            this.AdminSearchBtn.Size = new System.Drawing.Size(127, 35);
            this.AdminSearchBtn.TabIndex = 1;
            this.AdminSearchBtn.Text = "Search";
            this.AdminSearchBtn.UseVisualStyleBackColor = true;
            this.AdminSearchBtn.Click += new System.EventHandler(this.AdminSearchBtn_Click);
            // 
            // AdminSearchInputBox
            // 
            this.AdminSearchInputBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminSearchInputBox.Location = new System.Drawing.Point(10, 99);
            this.AdminSearchInputBox.Name = "AdminSearchInputBox";
            this.AdminSearchInputBox.Size = new System.Drawing.Size(449, 34);
            this.AdminSearchInputBox.TabIndex = 0;
            // 
            // AdminResultsTable
            // 
            this.AdminResultsTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AdminResultsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AdminResultsTable.Location = new System.Drawing.Point(816, 64);
            this.AdminResultsTable.Name = "AdminResultsTable";
            this.AdminResultsTable.RowHeadersWidth = 51;
            this.AdminResultsTable.RowTemplate.Height = 24;
            this.AdminResultsTable.Size = new System.Drawing.Size(621, 21);
            this.AdminResultsTable.TabIndex = 14;
            // 
            // sTUDENTTableAdapter
            // 
            this.sTUDENTTableAdapter.ClearBeforeFill = true;
            // 
            // mENTORTableAdapter
            // 
            this.mENTORTableAdapter.ClearBeforeFill = true;
            // 
            // AdminLogOutBtn
            // 
            this.AdminLogOutBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminLogOutBtn.ForeColor = System.Drawing.Color.Red;
            this.AdminLogOutBtn.Location = new System.Drawing.Point(1747, 879);
            this.AdminLogOutBtn.Name = "AdminLogOutBtn";
            this.AdminLogOutBtn.Size = new System.Drawing.Size(109, 49);
            this.AdminLogOutBtn.TabIndex = 15;
            this.AdminLogOutBtn.Text = "Log Out";
            this.AdminLogOutBtn.UseVisualStyleBackColor = true;
            this.AdminLogOutBtn.Click += new System.EventHandler(this.AdminLogOutBtn_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(1868, 1055);
            this.Controls.Add(this.AdminLogOutBtn);
            this.Controls.Add(this.AdminResultsTable);
            this.Controls.Add(this.AdminSearchBarGroupBox);
            this.Controls.Add(this.AdminAllocationButton);
            this.Controls.Add(this.AdminStatusLabel);
            this.Controls.Add(this.AdminMentorLabel);
            this.Controls.Add(this.AdminStudentNumberLabel);
            this.Controls.Add(this.AdminActiveStatusComboBox);
            this.Controls.Add(this.AdminMentorIDIInputBox);
            this.Controls.Add(this.AdminStudentNumberInputBox);
            this.Controls.Add(this.AdminMentorDataGridView);
            this.Controls.Add(this.AdminMentorsTableLabel);
            this.Controls.Add(this.AdminStudentTabelLabel);
            this.Controls.Add(this.AdminStudentsDataGridView);
            this.Controls.Add(this.AdminMentorManagementLogo);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "AdminForm";
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AdminStudentsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTUDENTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mentorManagementDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AdminMentorDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mENTORBindingSource)).EndInit();
            this.AdminSearchBarGroupBox.ResumeLayout(false);
            this.AdminSearchBarGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AdminResultsTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AdminMentorManagementLogo;
        private System.Windows.Forms.DataGridView AdminStudentsDataGridView;
        private MentorManagementDataSet mentorManagementDataSet;
        private System.Windows.Forms.BindingSource sTUDENTBindingSource;
        private MentorManagementDataSetTableAdapters.STUDENTTableAdapter sTUDENTTableAdapter;
        private System.Windows.Forms.Label AdminStudentTabelLabel;
        private System.Windows.Forms.Label AdminMentorsTableLabel;
        private System.Windows.Forms.DataGridView AdminMentorDataGridView;
        private System.Windows.Forms.BindingSource mENTORBindingSource;
        private MentorManagementDataSetTableAdapters.MENTORTableAdapter mENTORTableAdapter;
        private System.Windows.Forms.TextBox AdminStudentNumberInputBox;
        private System.Windows.Forms.TextBox AdminMentorIDIInputBox;
        private System.Windows.Forms.ComboBox AdminActiveStatusComboBox;
        private System.Windows.Forms.Label AdminStudentNumberLabel;
        private System.Windows.Forms.Label AdminMentorLabel;
        private System.Windows.Forms.Label AdminStatusLabel;
        private System.Windows.Forms.Button AdminAllocationButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTUNUMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTUFNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTULNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTUPHONENUMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTUEMAILDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTUYEARDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cOURSECODEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aLLOCATIONSTATUSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mENTORIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mENTORFNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mENTORLNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mENTORPHONENODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mENTOREMAILDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mENTORSTATUSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sCHOOLIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox AdminSearchBarGroupBox;
        private System.Windows.Forms.Button AdminSearchBtn;
        private System.Windows.Forms.TextBox AdminSearchInputBox;
        private System.Windows.Forms.ComboBox AdminSearchByComboBox;
        private System.Windows.Forms.Label AdminSearchForLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AdminDeleteBtn;
        private System.Windows.Forms.DataGridView AdminResultsTable;
        private System.Windows.Forms.Button AdminLogOutBtn;
    }
}