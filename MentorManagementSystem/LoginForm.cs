using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace MentorManagementSystem
{
    public partial class LoginForm : Form
    {
        string connectionString = "Server=143.128.146.30\\istn2;Database=ist2jf;User Id=ist2jf;Password=hw272e;";
        public LoginForm()
        {
            InitializeComponent();
        }

        private void UsernameInputBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void LoginBox_Enter(object sender, EventArgs e)
        {

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void SignInBtn_Click(object sender, EventArgs e)
        {
            string username = UsernameInputBox.Text;
            string password = PasswordInputBox.Text;
            string role = "";

            if (string.IsNullOrWhiteSpace(UsernameInputBox.Text) ||
               string.IsNullOrWhiteSpace(PasswordInputBox.Text)
               )
            {
                MessageBox.Show("Please fill in all required fields and select a role.",
                                "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                if (!onlyDigits(username))
                {
                    MessageBox.Show("Username Must Contains Only Digits!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            




            if (MentorRadioBox.Checked)
            {
                role = "MENTOR";
            }
            else if (AdminRadioBtn.Checked)
            {
                role = "ADMIN";
            }
            else if (StudentRadioBtn.Checked)
            {
                role = "STUDENT";
            }

            

            if (string.IsNullOrEmpty(role))
            {
                MessageBox.Show("Please select a role before logging in.", "Role Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM LOGIN_PASSWORD WHERE USER_NAME = @Username AND USER_PASSWORD = @Password AND USER_ROLE = @Role";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@Password", password);
                    cmd.Parameters.AddWithValue("@Role", role);

                    int count = (int)cmd.ExecuteScalar();

                    if (count > 0)
                    {
                        //Correct role matched
                        if (role == "MENTOR")
                        {
                            MentorPage mentorPage = new MentorPage(username);
                            mentorPage.Show();
                            this.Hide();
                            MessageBox.Show("Login successful!");
                        }
                        else if (role == "ADMIN")
                        {
                            AdminForm adminForm = new AdminForm();
                            this.Hide();
                            adminForm.Show();
                            
                            MessageBox.Show("Login successful!");
                        }
                        else if (role == "STUDENT")
                        {
                            StudentForm studentForm = new StudentForm(username);
                            studentForm.Show();
                            this.Hide();
                            MessageBox.Show("Login successful!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid username, password or role!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }

        }

        private void ShowPasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowPasswordCheckBox.Checked)
            {
                PasswordInputBox.PasswordChar='\0';
            }
            else
            {
                PasswordInputBox.PasswordChar = '•';        
            }
        }

        private void SignUpBtn_Click(object sender, EventArgs e)
        {
            SignUpForm signUpForm = new SignUpForm();
            this.Hide();
            
            signUpForm.Show();
           
        }


        private bool onlyDigits(string username) 
        { 
            bool charCheck = false;
            for(int i = 0;i < username.Length;i++)
            {
                char c = username[i];
                if (char.IsDigit(c))
                {
                    charCheck = true;
                }
                else
                { 
                    charCheck = false;
                    break;
                }
            }
            return charCheck;
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

