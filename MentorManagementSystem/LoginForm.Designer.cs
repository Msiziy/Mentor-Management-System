namespace MentorManagementSystem
{
    partial class LoginForm
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LoginSlogan = new System.Windows.Forms.Label();
            this.MentorManagementHeader = new System.Windows.Forms.Label();
            this.LoginBox = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ShowPasswordCheckBox = new System.Windows.Forms.CheckBox();
            this.SignInBtn = new System.Windows.Forms.Button();
            this.SignUpBtn = new System.Windows.Forms.Button();
            this.PaswordLabel = new System.Windows.Forms.Label();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.LogAsGroupBox = new System.Windows.Forms.GroupBox();
            this.MentorRadioBox = new System.Windows.Forms.RadioButton();
            this.StudentRadioBtn = new System.Windows.Forms.RadioButton();
            this.AdminRadioBtn = new System.Windows.Forms.RadioButton();
            this.PasswordInputBox = new System.Windows.Forms.TextBox();
            this.UsernameInputBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.LoginBox.SuspendLayout();
            this.LogAsGroupBox.SuspendLayout();
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
            this.splitContainer1.Panel1.AutoScroll = true;
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.Lavender;
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox1);
            this.splitContainer1.Panel1.Controls.Add(this.LoginSlogan);
            this.splitContainer1.Panel1.Controls.Add(this.MentorManagementHeader);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.Lavender;
            this.splitContainer1.Panel2.Controls.Add(this.LoginBox);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(1924, 1055);
            this.splitContainer1.SplitterDistance = 710;
            this.splitContainer1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MentorManagementSystem.Properties.Resources.Login;
            this.pictureBox1.Location = new System.Drawing.Point(81, 228);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(518, 502);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // LoginSlogan
            // 
            this.LoginSlogan.AutoSize = true;
            this.LoginSlogan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginSlogan.Location = new System.Drawing.Point(24, 744);
            this.LoginSlogan.Name = "LoginSlogan";
            this.LoginSlogan.Size = new System.Drawing.Size(645, 25);
            this.LoginSlogan.TabIndex = 2;
            this.LoginSlogan.Text = "Where Guidance Meets Growth — simplifying student–mentor connections.";
            // 
            // MentorManagementHeader
            // 
            this.MentorManagementHeader.AutoSize = true;
            this.MentorManagementHeader.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MentorManagementHeader.Location = new System.Drawing.Point(-6, 0);
            this.MentorManagementHeader.Name = "MentorManagementHeader";
            this.MentorManagementHeader.Size = new System.Drawing.Size(496, 36);
            this.MentorManagementHeader.TabIndex = 0;
            this.MentorManagementHeader.Text = "Mentor Management System";
            // 
            // LoginBox
            // 
            this.LoginBox.BackColor = System.Drawing.Color.AliceBlue;
            this.LoginBox.Controls.Add(this.label2);
            this.LoginBox.Controls.Add(this.ShowPasswordCheckBox);
            this.LoginBox.Controls.Add(this.SignInBtn);
            this.LoginBox.Controls.Add(this.SignUpBtn);
            this.LoginBox.Controls.Add(this.PaswordLabel);
            this.LoginBox.Controls.Add(this.UsernameLabel);
            this.LoginBox.Controls.Add(this.LogAsGroupBox);
            this.LoginBox.Controls.Add(this.PasswordInputBox);
            this.LoginBox.Controls.Add(this.UsernameInputBox);
            this.LoginBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginBox.Location = new System.Drawing.Point(361, 228);
            this.LoginBox.Name = "LoginBox";
            this.LoginBox.Size = new System.Drawing.Size(693, 464);
            this.LoginBox.TabIndex = 0;
            this.LoginBox.TabStop = false;
            this.LoginBox.Text = "Login";
            this.LoginBox.Enter += new System.EventHandler(this.LoginBox_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(425, 349);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Don\'t Have Account?";
            // 
            // ShowPasswordCheckBox
            // 
            this.ShowPasswordCheckBox.AutoSize = true;
            this.ShowPasswordCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowPasswordCheckBox.Location = new System.Drawing.Point(196, 184);
            this.ShowPasswordCheckBox.Name = "ShowPasswordCheckBox";
            this.ShowPasswordCheckBox.Size = new System.Drawing.Size(125, 20);
            this.ShowPasswordCheckBox.TabIndex = 9;
            this.ShowPasswordCheckBox.Text = "Show Password";
            this.ShowPasswordCheckBox.UseVisualStyleBackColor = true;
            this.ShowPasswordCheckBox.CheckedChanged += new System.EventHandler(this.ShowPasswordCheckBox_CheckedChanged);
            // 
            // SignInBtn
            // 
            this.SignInBtn.BackColor = System.Drawing.Color.DodgerBlue;
            this.SignInBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SignInBtn.Location = new System.Drawing.Point(44, 372);
            this.SignInBtn.Name = "SignInBtn";
            this.SignInBtn.Size = new System.Drawing.Size(125, 51);
            this.SignInBtn.TabIndex = 8;
            this.SignInBtn.Text = "Log In";
            this.SignInBtn.UseVisualStyleBackColor = false;
            this.SignInBtn.Click += new System.EventHandler(this.SignInBtn_Click);
            // 
            // SignUpBtn
            // 
            this.SignUpBtn.BackColor = System.Drawing.Color.DodgerBlue;
            this.SignUpBtn.Location = new System.Drawing.Point(472, 372);
            this.SignUpBtn.Name = "SignUpBtn";
            this.SignUpBtn.Size = new System.Drawing.Size(125, 51);
            this.SignUpBtn.TabIndex = 1;
            this.SignUpBtn.Text = "Sign-Up";
            this.SignUpBtn.UseVisualStyleBackColor = false;
            this.SignUpBtn.Click += new System.EventHandler(this.SignUpBtn_Click);
            // 
            // PaswordLabel
            // 
            this.PaswordLabel.AutoSize = true;
            this.PaswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaswordLabel.Location = new System.Drawing.Point(43, 144);
            this.PaswordLabel.Name = "PaswordLabel";
            this.PaswordLabel.Size = new System.Drawing.Size(142, 29);
            this.PaswordLabel.TabIndex = 7;
            this.PaswordLabel.Text = "Password :";
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameLabel.Location = new System.Drawing.Point(39, 88);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(146, 29);
            this.UsernameLabel.TabIndex = 6;
            this.UsernameLabel.Text = "Username :";
            // 
            // LogAsGroupBox
            // 
            this.LogAsGroupBox.Controls.Add(this.MentorRadioBox);
            this.LogAsGroupBox.Controls.Add(this.StudentRadioBtn);
            this.LogAsGroupBox.Controls.Add(this.AdminRadioBtn);
            this.LogAsGroupBox.Location = new System.Drawing.Point(48, 227);
            this.LogAsGroupBox.Name = "LogAsGroupBox";
            this.LogAsGroupBox.Size = new System.Drawing.Size(549, 94);
            this.LogAsGroupBox.TabIndex = 5;
            this.LogAsGroupBox.TabStop = false;
            this.LogAsGroupBox.Text = "Sign In as";
            // 
            // MentorRadioBox
            // 
            this.MentorRadioBox.AutoSize = true;
            this.MentorRadioBox.Location = new System.Drawing.Point(25, 33);
            this.MentorRadioBox.Name = "MentorRadioBox";
            this.MentorRadioBox.Size = new System.Drawing.Size(109, 33);
            this.MentorRadioBox.TabIndex = 2;
            this.MentorRadioBox.TabStop = true;
            this.MentorRadioBox.Text = "Mentor";
            this.MentorRadioBox.UseVisualStyleBackColor = true;
            // 
            // StudentRadioBtn
            // 
            this.StudentRadioBtn.AutoSize = true;
            this.StudentRadioBtn.Location = new System.Drawing.Point(406, 35);
            this.StudentRadioBtn.Name = "StudentRadioBtn";
            this.StudentRadioBtn.Size = new System.Drawing.Size(116, 33);
            this.StudentRadioBtn.TabIndex = 4;
            this.StudentRadioBtn.TabStop = true;
            this.StudentRadioBtn.Text = "Student";
            this.StudentRadioBtn.UseVisualStyleBackColor = true;
            // 
            // AdminRadioBtn
            // 
            this.AdminRadioBtn.AutoSize = true;
            this.AdminRadioBtn.Location = new System.Drawing.Point(216, 35);
            this.AdminRadioBtn.Name = "AdminRadioBtn";
            this.AdminRadioBtn.Size = new System.Drawing.Size(102, 33);
            this.AdminRadioBtn.TabIndex = 3;
            this.AdminRadioBtn.TabStop = true;
            this.AdminRadioBtn.Text = "Admin";
            this.AdminRadioBtn.UseVisualStyleBackColor = true;
            // 
            // PasswordInputBox
            // 
            this.PasswordInputBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PasswordInputBox.Location = new System.Drawing.Point(196, 144);
            this.PasswordInputBox.Name = "PasswordInputBox";
            this.PasswordInputBox.PasswordChar = '•';
            this.PasswordInputBox.Size = new System.Drawing.Size(397, 34);
            this.PasswordInputBox.TabIndex = 1;
            // 
            // UsernameInputBox
            // 
            this.UsernameInputBox.Location = new System.Drawing.Point(196, 88);
            this.UsernameInputBox.Name = "UsernameInputBox";
            this.UsernameInputBox.Size = new System.Drawing.Size(393, 34);
            this.UsernameInputBox.TabIndex = 0;
            this.UsernameInputBox.TextChanged += new System.EventHandler(this.UsernameInputBox_TextChanged);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.splitContainer1);
            this.Name = "LoginForm";
            this.Text = "Log In";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.LoginBox.ResumeLayout(false);
            this.LoginBox.PerformLayout();
            this.LogAsGroupBox.ResumeLayout(false);
            this.LogAsGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label MentorManagementHeader;
        private System.Windows.Forms.GroupBox LoginBox;
        private System.Windows.Forms.GroupBox LogAsGroupBox;
        private System.Windows.Forms.RadioButton StudentRadioBtn;
        private System.Windows.Forms.RadioButton AdminRadioBtn;
        private System.Windows.Forms.RadioButton MentorRadioBox;
        private System.Windows.Forms.Button SignInBtn;
        private System.Windows.Forms.Button SignUpBtn;
        private System.Windows.Forms.CheckBox ShowPasswordCheckBox;
        private System.Windows.Forms.Label PaswordLabel;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.TextBox PasswordInputBox;
        private System.Windows.Forms.TextBox UsernameInputBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label LoginSlogan;
    }
}

