namespace MentorManagementSystem
{
    partial class SignUpForm
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.AdminMentorManagementLogo = new System.Windows.Forms.Label();
            this.SignUpGroupBox = new System.Windows.Forms.GroupBox();
            this.AlreadyHaveAccLabel = new System.Windows.Forms.Label();
            this.SignInBtn = new System.Windows.Forms.Button();
            this.SignUpButton = new System.Windows.Forms.Button();
            this.RoleSelectionGroupBox = new System.Windows.Forms.GroupBox();
            this.StudentRadioBtn = new System.Windows.Forms.RadioButton();
            this.MentorRoleBtn = new System.Windows.Forms.RadioButton();
            this.CourseGroupBox = new System.Windows.Forms.GroupBox();
            this.CourseSelectionbox = new System.Windows.Forms.ComboBox();
            this.PasswordGroupBox = new System.Windows.Forms.GroupBox();
            this.ShowPasswordCheckBox = new System.Windows.Forms.CheckBox();
            this.ConPasswordLabel = new System.Windows.Forms.Label();
            this.newPasswordLabel = new System.Windows.Forms.Label();
            this.newPasswordInputBox = new System.Windows.Forms.TextBox();
            this.conPassWordInputBox = new System.Windows.Forms.TextBox();
            this.UserDetailsGroupBox = new System.Windows.Forms.GroupBox();
            this.YearOfStudyLabel = new System.Windows.Forms.Label();
            this.YearRollUpDown = new System.Windows.Forms.NumericUpDown();
            this.PhoneNoLabel = new System.Windows.Forms.Label();
            this.StudentNoEmailLabel = new System.Windows.Forms.Label();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.LNamelabel = new System.Windows.Forms.Label();
            this.FNameInputBox = new System.Windows.Forms.TextBox();
            this.PhoneNumberInputBox = new System.Windows.Forms.TextBox();
            this.StudentNumberInputBox = new System.Windows.Forms.TextBox();
            this.LNameInputBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SignUpGroupBox.SuspendLayout();
            this.RoleSelectionGroupBox.SuspendLayout();
            this.CourseGroupBox.SuspendLayout();
            this.PasswordGroupBox.SuspendLayout();
            this.UserDetailsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.YearRollUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.Lavender;
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox1);
            this.splitContainer1.Panel1.Controls.Add(this.AdminMentorManagementLogo);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.Lavender;
            this.splitContainer1.Panel2.Controls.Add(this.SignUpGroupBox);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(1924, 1055);
            this.splitContainer1.SplitterDistance = 727;
            this.splitContainer1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 783);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(645, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Where Guidance Meets Growth — simplifying student–mentor connections.";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MentorManagementSystem.Properties.Resources.Sign_Up;
            this.pictureBox1.Location = new System.Drawing.Point(75, 227);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(542, 528);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // AdminMentorManagementLogo
            // 
            this.AdminMentorManagementLogo.AutoSize = true;
            this.AdminMentorManagementLogo.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminMentorManagementLogo.Location = new System.Drawing.Point(3, 0);
            this.AdminMentorManagementLogo.Name = "AdminMentorManagementLogo";
            this.AdminMentorManagementLogo.Size = new System.Drawing.Size(496, 36);
            this.AdminMentorManagementLogo.TabIndex = 2;
            this.AdminMentorManagementLogo.Text = "Mentor Management System";
            // 
            // SignUpGroupBox
            // 
            this.SignUpGroupBox.BackColor = System.Drawing.Color.LightSkyBlue;
            this.SignUpGroupBox.Controls.Add(this.AlreadyHaveAccLabel);
            this.SignUpGroupBox.Controls.Add(this.SignInBtn);
            this.SignUpGroupBox.Controls.Add(this.SignUpButton);
            this.SignUpGroupBox.Controls.Add(this.RoleSelectionGroupBox);
            this.SignUpGroupBox.Controls.Add(this.CourseGroupBox);
            this.SignUpGroupBox.Controls.Add(this.PasswordGroupBox);
            this.SignUpGroupBox.Controls.Add(this.UserDetailsGroupBox);
            this.SignUpGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUpGroupBox.Location = new System.Drawing.Point(257, 122);
            this.SignUpGroupBox.Name = "SignUpGroupBox";
            this.SignUpGroupBox.Size = new System.Drawing.Size(763, 665);
            this.SignUpGroupBox.TabIndex = 0;
            this.SignUpGroupBox.TabStop = false;
            this.SignUpGroupBox.Text = "Sign Up";
            // 
            // AlreadyHaveAccLabel
            // 
            this.AlreadyHaveAccLabel.AutoSize = true;
            this.AlreadyHaveAccLabel.Location = new System.Drawing.Point(546, 579);
            this.AlreadyHaveAccLabel.Name = "AlreadyHaveAccLabel";
            this.AlreadyHaveAccLabel.Size = new System.Drawing.Size(184, 20);
            this.AlreadyHaveAccLabel.TabIndex = 6;
            this.AlreadyHaveAccLabel.Text = "Already Have Account?";
            // 
            // SignInBtn
            // 
            this.SignInBtn.BackColor = System.Drawing.Color.DodgerBlue;
            this.SignInBtn.Location = new System.Drawing.Point(610, 602);
            this.SignInBtn.Name = "SignInBtn";
            this.SignInBtn.Size = new System.Drawing.Size(120, 41);
            this.SignInBtn.TabIndex = 5;
            this.SignInBtn.Text = "Log In";
            this.SignInBtn.UseVisualStyleBackColor = false;
            this.SignInBtn.Click += new System.EventHandler(this.SignInBtn_Click);
            // 
            // SignUpButton
            // 
            this.SignUpButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.SignUpButton.Location = new System.Drawing.Point(16, 602);
            this.SignUpButton.Name = "SignUpButton";
            this.SignUpButton.Size = new System.Drawing.Size(120, 41);
            this.SignUpButton.TabIndex = 4;
            this.SignUpButton.Text = "Sign Up";
            this.SignUpButton.UseVisualStyleBackColor = false;
            this.SignUpButton.Click += new System.EventHandler(this.SignUpButton_Click);
            // 
            // RoleSelectionGroupBox
            // 
            this.RoleSelectionGroupBox.BackColor = System.Drawing.Color.AliceBlue;
            this.RoleSelectionGroupBox.Controls.Add(this.StudentRadioBtn);
            this.RoleSelectionGroupBox.Controls.Add(this.MentorRoleBtn);
            this.RoleSelectionGroupBox.Location = new System.Drawing.Point(436, 425);
            this.RoleSelectionGroupBox.Name = "RoleSelectionGroupBox";
            this.RoleSelectionGroupBox.Size = new System.Drawing.Size(294, 94);
            this.RoleSelectionGroupBox.TabIndex = 3;
            this.RoleSelectionGroupBox.TabStop = false;
            this.RoleSelectionGroupBox.Text = "Role";
            // 
            // StudentRadioBtn
            // 
            this.StudentRadioBtn.AutoSize = true;
            this.StudentRadioBtn.Location = new System.Drawing.Point(187, 39);
            this.StudentRadioBtn.Name = "StudentRadioBtn";
            this.StudentRadioBtn.Size = new System.Drawing.Size(87, 24);
            this.StudentRadioBtn.TabIndex = 1;
            this.StudentRadioBtn.TabStop = true;
            this.StudentRadioBtn.Text = "Student";
            this.StudentRadioBtn.UseVisualStyleBackColor = true;
            this.StudentRadioBtn.CheckedChanged += new System.EventHandler(this.StudentRadioBtn_CheckedChanged);
            // 
            // MentorRoleBtn
            // 
            this.MentorRoleBtn.AutoSize = true;
            this.MentorRoleBtn.Location = new System.Drawing.Point(14, 39);
            this.MentorRoleBtn.Name = "MentorRoleBtn";
            this.MentorRoleBtn.Size = new System.Drawing.Size(82, 24);
            this.MentorRoleBtn.TabIndex = 0;
            this.MentorRoleBtn.TabStop = true;
            this.MentorRoleBtn.Text = "Mentor";
            this.MentorRoleBtn.UseVisualStyleBackColor = true;
            this.MentorRoleBtn.CheckedChanged += new System.EventHandler(this.MentorRoleBtn_CheckedChanged);
            // 
            // CourseGroupBox
            // 
            this.CourseGroupBox.BackColor = System.Drawing.Color.AliceBlue;
            this.CourseGroupBox.Controls.Add(this.CourseSelectionbox);
            this.CourseGroupBox.Location = new System.Drawing.Point(16, 425);
            this.CourseGroupBox.Name = "CourseGroupBox";
            this.CourseGroupBox.Size = new System.Drawing.Size(392, 94);
            this.CourseGroupBox.TabIndex = 2;
            this.CourseGroupBox.TabStop = false;
            this.CourseGroupBox.Text = "Course";
            // 
            // CourseSelectionbox
            // 
            this.CourseSelectionbox.FormattingEnabled = true;
            this.CourseSelectionbox.Items.AddRange(new object[] {
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
            this.CourseSelectionbox.Location = new System.Drawing.Point(32, 35);
            this.CourseSelectionbox.MaxDropDownItems = 50;
            this.CourseSelectionbox.Name = "CourseSelectionbox";
            this.CourseSelectionbox.Size = new System.Drawing.Size(336, 28);
            this.CourseSelectionbox.TabIndex = 0;
            this.CourseSelectionbox.Text = "Select";
            // 
            // PasswordGroupBox
            // 
            this.PasswordGroupBox.BackColor = System.Drawing.Color.AliceBlue;
            this.PasswordGroupBox.Controls.Add(this.ShowPasswordCheckBox);
            this.PasswordGroupBox.Controls.Add(this.ConPasswordLabel);
            this.PasswordGroupBox.Controls.Add(this.newPasswordLabel);
            this.PasswordGroupBox.Controls.Add(this.newPasswordInputBox);
            this.PasswordGroupBox.Controls.Add(this.conPassWordInputBox);
            this.PasswordGroupBox.Location = new System.Drawing.Point(16, 283);
            this.PasswordGroupBox.Name = "PasswordGroupBox";
            this.PasswordGroupBox.Size = new System.Drawing.Size(714, 120);
            this.PasswordGroupBox.TabIndex = 1;
            this.PasswordGroupBox.TabStop = false;
            this.PasswordGroupBox.Text = "Password";
            // 
            // ShowPasswordCheckBox
            // 
            this.ShowPasswordCheckBox.AutoSize = true;
            this.ShowPasswordCheckBox.Location = new System.Drawing.Point(15, 89);
            this.ShowPasswordCheckBox.Name = "ShowPasswordCheckBox";
            this.ShowPasswordCheckBox.Size = new System.Drawing.Size(151, 24);
            this.ShowPasswordCheckBox.TabIndex = 6;
            this.ShowPasswordCheckBox.Text = "Show Password";
            this.ShowPasswordCheckBox.UseVisualStyleBackColor = true;
            this.ShowPasswordCheckBox.CheckedChanged += new System.EventHandler(this.ShowPasswordCheckBox_CheckedChanged);
            // 
            // ConPasswordLabel
            // 
            this.ConPasswordLabel.AutoSize = true;
            this.ConPasswordLabel.Location = new System.Drawing.Point(404, 33);
            this.ConPasswordLabel.Name = "ConPasswordLabel";
            this.ConPasswordLabel.Size = new System.Drawing.Size(147, 20);
            this.ConPasswordLabel.TabIndex = 5;
            this.ConPasswordLabel.Text = "Confirm Password";
            // 
            // newPasswordLabel
            // 
            this.newPasswordLabel.AutoSize = true;
            this.newPasswordLabel.Location = new System.Drawing.Point(11, 33);
            this.newPasswordLabel.Name = "newPasswordLabel";
            this.newPasswordLabel.Size = new System.Drawing.Size(121, 20);
            this.newPasswordLabel.TabIndex = 4;
            this.newPasswordLabel.Text = "New Password";
            // 
            // newPasswordInputBox
            // 
            this.newPasswordInputBox.Location = new System.Drawing.Point(11, 56);
            this.newPasswordInputBox.Name = "newPasswordInputBox";
            this.newPasswordInputBox.PasswordChar = '•';
            this.newPasswordInputBox.Size = new System.Drawing.Size(234, 27);
            this.newPasswordInputBox.TabIndex = 2;
            this.newPasswordInputBox.TextChanged += new System.EventHandler(this.newPasswordInputBox_TextChanged);
            // 
            // conPassWordInputBox
            // 
            this.conPassWordInputBox.Location = new System.Drawing.Point(404, 56);
            this.conPassWordInputBox.Name = "conPassWordInputBox";
            this.conPassWordInputBox.PasswordChar = '•';
            this.conPassWordInputBox.Size = new System.Drawing.Size(234, 27);
            this.conPassWordInputBox.TabIndex = 3;
            this.conPassWordInputBox.TextChanged += new System.EventHandler(this.conPassWordInputBox_TextChanged);
            // 
            // UserDetailsGroupBox
            // 
            this.UserDetailsGroupBox.BackColor = System.Drawing.Color.AliceBlue;
            this.UserDetailsGroupBox.Controls.Add(this.YearOfStudyLabel);
            this.UserDetailsGroupBox.Controls.Add(this.YearRollUpDown);
            this.UserDetailsGroupBox.Controls.Add(this.PhoneNoLabel);
            this.UserDetailsGroupBox.Controls.Add(this.StudentNoEmailLabel);
            this.UserDetailsGroupBox.Controls.Add(this.LastNameLabel);
            this.UserDetailsGroupBox.Controls.Add(this.LNamelabel);
            this.UserDetailsGroupBox.Controls.Add(this.FNameInputBox);
            this.UserDetailsGroupBox.Controls.Add(this.PhoneNumberInputBox);
            this.UserDetailsGroupBox.Controls.Add(this.StudentNumberInputBox);
            this.UserDetailsGroupBox.Controls.Add(this.LNameInputBox);
            this.UserDetailsGroupBox.Location = new System.Drawing.Point(16, 42);
            this.UserDetailsGroupBox.Name = "UserDetailsGroupBox";
            this.UserDetailsGroupBox.Size = new System.Drawing.Size(714, 222);
            this.UserDetailsGroupBox.TabIndex = 0;
            this.UserDetailsGroupBox.TabStop = false;
            this.UserDetailsGroupBox.Text = "User Details";
            // 
            // YearOfStudyLabel
            // 
            this.YearOfStudyLabel.AutoSize = true;
            this.YearOfStudyLabel.Location = new System.Drawing.Point(11, 155);
            this.YearOfStudyLabel.Name = "YearOfStudyLabel";
            this.YearOfStudyLabel.Size = new System.Drawing.Size(113, 20);
            this.YearOfStudyLabel.TabIndex = 7;
            this.YearOfStudyLabel.Text = "Year Of Study";
            // 
            // YearRollUpDown
            // 
            this.YearRollUpDown.AccessibleName = "YearRollUpDown";
            this.YearRollUpDown.Location = new System.Drawing.Point(15, 178);
            this.YearRollUpDown.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.YearRollUpDown.Name = "YearRollUpDown";
            this.YearRollUpDown.Size = new System.Drawing.Size(185, 27);
            this.YearRollUpDown.TabIndex = 6;
            this.YearRollUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.YearRollUpDown.ValueChanged += new System.EventHandler(this.YearRollUpDown_ValueChanged);
            // 
            // PhoneNoLabel
            // 
            this.PhoneNoLabel.AutoSize = true;
            this.PhoneNoLabel.Location = new System.Drawing.Point(420, 91);
            this.PhoneNoLabel.Name = "PhoneNoLabel";
            this.PhoneNoLabel.Size = new System.Drawing.Size(120, 20);
            this.PhoneNoLabel.TabIndex = 6;
            this.PhoneNoLabel.Text = "Phone Number";
            // 
            // StudentNoEmailLabel
            // 
            this.StudentNoEmailLabel.AutoSize = true;
            this.StudentNoEmailLabel.Location = new System.Drawing.Point(11, 88);
            this.StudentNoEmailLabel.Name = "StudentNoEmailLabel";
            this.StudentNoEmailLabel.Size = new System.Drawing.Size(130, 20);
            this.StudentNoEmailLabel.TabIndex = 5;
            this.StudentNoEmailLabel.Text = "Student Number";
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Location = new System.Drawing.Point(420, 25);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(96, 20);
            this.LastNameLabel.TabIndex = 2;
            this.LastNameLabel.Text = "Last Name ";
            // 
            // LNamelabel
            // 
            this.LNamelabel.AutoSize = true;
            this.LNamelabel.Location = new System.Drawing.Point(7, 22);
            this.LNamelabel.Name = "LNamelabel";
            this.LNamelabel.Size = new System.Drawing.Size(92, 20);
            this.LNamelabel.TabIndex = 1;
            this.LNamelabel.Text = "First Name";
            // 
            // FNameInputBox
            // 
            this.FNameInputBox.Location = new System.Drawing.Point(6, 44);
            this.FNameInputBox.Name = "FNameInputBox";
            this.FNameInputBox.Size = new System.Drawing.Size(278, 27);
            this.FNameInputBox.TabIndex = 0;
            // 
            // PhoneNumberInputBox
            // 
            this.PhoneNumberInputBox.Location = new System.Drawing.Point(420, 113);
            this.PhoneNumberInputBox.Name = "PhoneNumberInputBox";
            this.PhoneNumberInputBox.Size = new System.Drawing.Size(234, 27);
            this.PhoneNumberInputBox.TabIndex = 5;
            // 
            // StudentNumberInputBox
            // 
            this.StudentNumberInputBox.Location = new System.Drawing.Point(11, 110);
            this.StudentNumberInputBox.Name = "StudentNumberInputBox";
            this.StudentNumberInputBox.Size = new System.Drawing.Size(273, 27);
            this.StudentNumberInputBox.TabIndex = 4;
            // 
            // LNameInputBox
            // 
            this.LNameInputBox.Location = new System.Drawing.Point(420, 47);
            this.LNameInputBox.Name = "LNameInputBox";
            this.LNameInputBox.Size = new System.Drawing.Size(234, 27);
            this.LNameInputBox.TabIndex = 1;
            // 
            // SignUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.splitContainer1);
            this.Name = "SignUpForm";
            this.Text = "Sign Up";
            this.Load += new System.EventHandler(this.SignUpForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.SignUpGroupBox.ResumeLayout(false);
            this.SignUpGroupBox.PerformLayout();
            this.RoleSelectionGroupBox.ResumeLayout(false);
            this.RoleSelectionGroupBox.PerformLayout();
            this.CourseGroupBox.ResumeLayout(false);
            this.PasswordGroupBox.ResumeLayout(false);
            this.PasswordGroupBox.PerformLayout();
            this.UserDetailsGroupBox.ResumeLayout(false);
            this.UserDetailsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.YearRollUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox SignUpGroupBox;
        private System.Windows.Forms.TextBox newPasswordInputBox;
        private System.Windows.Forms.TextBox LNameInputBox;
        private System.Windows.Forms.TextBox FNameInputBox;
        private System.Windows.Forms.NumericUpDown YearRollUpDown;
        private System.Windows.Forms.TextBox PhoneNumberInputBox;
        private System.Windows.Forms.TextBox StudentNumberInputBox;
        private System.Windows.Forms.TextBox conPassWordInputBox;
        private System.Windows.Forms.GroupBox UserDetailsGroupBox;
        private System.Windows.Forms.Label LNamelabel;
        private System.Windows.Forms.GroupBox PasswordGroupBox;
        private System.Windows.Forms.Label newPasswordLabel;
        private System.Windows.Forms.Label PhoneNoLabel;
        private System.Windows.Forms.Label StudentNoEmailLabel;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.GroupBox RoleSelectionGroupBox;
        private System.Windows.Forms.RadioButton StudentRadioBtn;
        private System.Windows.Forms.RadioButton MentorRoleBtn;
        private System.Windows.Forms.GroupBox CourseGroupBox;
        private System.Windows.Forms.Label ConPasswordLabel;
        private System.Windows.Forms.Label AlreadyHaveAccLabel;
        private System.Windows.Forms.Button SignInBtn;
        private System.Windows.Forms.Button SignUpButton;
        private System.Windows.Forms.ComboBox CourseSelectionbox;
        private System.Windows.Forms.CheckBox ShowPasswordCheckBox;
        private System.Windows.Forms.Label YearOfStudyLabel;
        private System.Windows.Forms.Label AdminMentorManagementLogo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}