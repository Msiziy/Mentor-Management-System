using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MentorManagementSystem
{

    public partial class MentorPage : Form
    {
        string connectionString = "Server=143.128.146.30\\istn2;Database=ist2jf;User Id=ist2jf;Password=hw272e;";
        private string studentEmail;
        public MentorPage(string stuNum)
        {
            InitializeComponent();
            this.studentEmail = stuNum + "@stu.ukzn.ac.za";

        }
  

        private void mENTORBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            //this.mENTORBindingSource.EndEdit();
            //this.tableAdapterManager.UpdateAll(this.mentorManagementDataSet);

        }

        private void MentorPage_Load(object sender, EventArgs e)
        {
            this.sTUDENTTableAdapter.Fill(this.mentorManagementDataSet.STUDENT);
            LoadMentorsDetails();
            LoadAllocatedStudents();
        }

        
        private void LoadAllocatedStudents()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string query = @"
            SELECT S.STU_NUM, S.STU_FNAME, S.STU_LNAME, S.STU_EMAIL, S.STU_PHONENUM, S.STU_YEAR
            FROM STUDENT S
            INNER JOIN MENTOR_ALLOCATION MA ON S.STU_NUM = MA.STU_NUM
            INNER JOIN MENTOR M ON MA.MENTOR_ID = M.MENTOR_ID
            WHERE M.MENTOR_EMAIL = @MentorEmail";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@MentorEmail", studentEmail);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        DataTable dt = new DataTable();
                        dt.Load(reader);

                        MentorStudentDataGridView.DataSource = dt;
                    }
                }
            }
        }

        private void mentorManagementDBMSBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void LoadMentorsDetails()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string query = @"SELECT MENTOR_FNAME, MENTOR_LNAME, MENTOR_EMAIL, MENTOR_PHONE_NO
                                 FROM MENTOR 
                                 WHERE MENTOR_EMAIL = @stuNum";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@stuNum", studentEmail);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string fname = reader["MENTOR_FNAME"].ToString();
                            string lname = reader["MENTOR_LNAME"].ToString();
                            string email = reader["MENTOR_EMAIL"].ToString();
                            string phone = reader["MENTOR_PHONE_NO"].ToString();

                            MentorFirstNameResults.Text = fname;
                            MentorLastNameResults.Text = lname;
                            MentorEmailResults.Text = email;
                            MentorPhoneNumberResults.Text = phone;
                        }
                        else
                        {
                            MentorFirstNameResults.Text = "Not Found";
                            MentorLastNameResults.Text = "Not Found";
                            MentorEmailResults.Text = "Not Found";
                            MentorPhoneNumberResults.Text = "Not Found";
                        }
                    }
                }
            }
        }
        
        private void MentorSaveChangesBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(MentorFirstNameUpdateInputBox.Text) ||
                string.IsNullOrWhiteSpace(MentorLastNameUpdateInputBox.Text) ||
                string.IsNullOrWhiteSpace(MentorPhoneNumberUpdateInputBox.Text) ||
                string.IsNullOrWhiteSpace(NewPasswordUpdateInputBox.Text) ||
                string.IsNullOrWhiteSpace(ConfirmPasswordUpdateInputBox.Text) ||
                (MentorCourseUpdateComboBox.Text).Equals("Select") ||
                (MentorCourseUpdateComboBox.Text).Equals(" "))
            {
                MessageBox.Show("Please fill in all required fields and select a role.",
                                "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //Phone number validation
            if (!Regex.IsMatch(MentorPhoneNumberUpdateInputBox.Text, @"^\d{10}$"))
            {
                MessageBox.Show("Phone Number must be 10 digits.",
                                "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //Password match check
            if (NewPasswordUpdateInputBox.Text != ConfirmPasswordUpdateInputBox.Text)
            {
                MessageBox.Show("Passwords do not match!",
                                "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Password length check
            if (NewPasswordUpdateInputBox.Text.Length < 6)
            {
                MessageBox.Show("Password must be at least 6 characters long.",
                                "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //Collect Values
            string firstName = MentorFirstNameUpdateInputBox.Text.Trim();
            string lastName = MentorLastNameUpdateInputBox.Text.Trim();
            string phoneNumber = MentorPhoneNumberUpdateInputBox.Text.Trim();
            string conPassword = ConfirmPasswordUpdateInputBox.Text.Trim();
            string courseName = MentorCourseUpdateComboBox.Text.Trim();
            string email = MentorEmailResults.Text.Trim();
            int stuNum = int.Parse(KeepOnlyNumbers(email));

            string connectionString = "Server=143.128.146.30\\istn2;Database=ist2jf;User Id=ist2jf;Password=hw272e;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                //Correct UPDATE query for Mentor
                string query = @"UPDATE MENTOR 
                                SET MENTOR_FNAME = @FirstName,
                                    MENTOR_LNAME = @LastName,
                                    MENTOR_PHONE_NO = @PhoneNumber,
                                    SCHOOL_ID = (SELECT SCHOOL_ID FROM COURSE WHERE COURSE_NAME = @CourseName)
                                WHERE MENTOR_EMAIL = @Email";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@FirstName", firstName);
                    cmd.Parameters.AddWithValue("@LastName", lastName);
                    cmd.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
                    cmd.Parameters.AddWithValue("@CourseName", courseName);
                    cmd.Parameters.AddWithValue("@Email", email);

                    cmd.ExecuteNonQuery();
                }

                //Update LOGIN_PASSWORD for Mentor
                string loginQuery = @"UPDATE LOGIN_PASSWORD
                                      SET USER_PASSWORD = @Password
                                      WHERE USER_NAME = @StuNum";

                using (SqlCommand loginCmd = new SqlCommand(loginQuery, conn))
                {
                    loginCmd.Parameters.AddWithValue("@Password", conPassword);
                    loginCmd.Parameters.AddWithValue("@StuNum", stuNum);

                    loginCmd.ExecuteNonQuery();
                }

                MessageBox.Show("Mentor details updated successfully!",
                                "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        static string KeepOnlyNumbers(string text)
        {
            return new string(text.Where(char.IsDigit).ToArray());
        }

        public string GetCourseId(string courseName)
        {
            switch (courseName.ToUpper().Trim())
            {
                case "B ADMIN":
                    return "BADMIN";

                case "BACHELOR OF AUDIOLOGY":
                    return "BAUDIO";

                case "B BUSINESS ADMINISTRATION":
                    return "BBA";

                case "B BUSINESS SCIENCE":
                    return "BBUSSCI";

                case "B COM":
                    return "BCOM";

                case "B COM ACCOUNTING":
                    return "BCOMACC";

                case "B COM EXTENDED CURRICULUM (ACCOUNTING)":
                    return "BCOMECA";

                case "B COM EXTENDED CURRICULUM (GENERAL)":
                    return "BCOMEGC";

                case "B DENTAL THERAPY":
                    return "BDENT";

                case "B MEDICAL SCIENCE: ANATOMY":
                    return "BMEDANA";

                case "B MEDICAL SCIENCE: PHYSIOLOGY":
                    return "BMEDPHY";

                case "B OPTOMETRY":
                    return "BOPT";

                case "B OCCUPATIONAL THERAPY":
                    return "BOT";

                case "B PHARMACY":
                    return "BPHARM";

                case "B PHYSIOTHERAPY":
                    return "BPHYSIO";

                case "B SC 4 AUGMENTED PROGRAMME":
                    return "BSC4AP";

                case "B SC APPLIED CHEMISTRY":
                    return "BSCAC";

                case "B SC BIOLOGICAL SCIENCE":
                    return "BSCBIO";

                case "B SC COMPUTER SCIENCE AND INFORMATION...":
                    return "BSCCSIT";

                case "B SC ENVIRONMENTAL EARTH SCIENCE":
                    return "BSCEES";

                case "B SC ENVIRONMENTAL SCIENCE":
                    return "BSCENV";

                case "B SC GEOLOGICAL SCIENCE":
                    return "BSCGEO";

                case "B SC STREAM LES (LIFE EARTH SCIENCES)":
                    return "BSCLES";

                case "B SC MARINE BIOLOGY":
                    return "BSCMAR";

                case "B SC STREAM M (MATHEMATICS)":
                    return "BSCMATH";

                case "BACHELOR OF SPEECH-LANGUAGE THERAPY":
                    return "BSLT";

                case "B SPORT SCIENCE":
                    return "BSPORT";

                default:
                    return "Course not found!";
            }
        }

        public int GetSchoolIdByCourseName(string courseName)
        {
            switch (courseName.ToUpper().Trim())
            {
                case "B ADMIN":
                    return 7;

                case "BACHELOR OF AUDIOLOGY":
                    return 5;

                case "B BUSINESS ADMINISTRATION":
                    return 7;

                case "B BUSINESS SCIENCE":
                    return 7;

                case "B COM":
                    return 6;

                case "B COM ACCOUNTING":
                    return 6;

                case "B COM EXTENDED CURRICULUM (ACCOUNTING)":
                    return 6;

                case "B COM EXTENDED CURRICULUM (GENERAL)":
                    return 6;

                case "B DENTAL THERAPY":
                    return 5;

                case "B MEDICAL SCIENCE: ANATOMY":
                    return 5;

                case "B MEDICAL SCIENCE: PHYSIOLOGY":
                    return 5;

                case "B OPTOMETRY":
                    return 5;

                case "B OCCUPATIONAL THERAPY":
                    return 5;

                case "B PHARMACY":
                    return 5;

                case "B PHYSIOTHERAPY":
                    return 5;

                case "B SC 4 AUGMENTED PROGRAMME":
                    return 4;

                case "B SC APPLIED CHEMISTRY":
                    return 2;

                case "B SC BIOLOGICAL SCIENCE":
                    return 3;

                case "B SC COMPUTER SCIENCE AND INFORMATION...":
                    return 4;

                case "B SC ENVIRONMENTAL EARTH SCIENCE":
                    return 1;

                case "B SC ENVIRONMENTAL SCIENCE":
                    return 1;

                case "B SC GEOLOGICAL SCIENCE":
                    return 1;

                case "B SC STREAM LES (LIFE EARTH SCIENCES)":
                    return 3;

                case "B SC MARINE BIOLOGY":
                    return 3;

                case "B SC STREAM M (MATHEMATICS)":
                    return 4;

                case "BACHELOR OF SPEECH-LANGUAGE THERAPY":
                    return 5;

                case "B SPORT SCIENCE":
                    return 5;

                default:
                    return -1;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                NewPasswordUpdateInputBox.UseSystemPasswordChar = false;
                ConfirmPasswordUpdateInputBox.UseSystemPasswordChar = false;
            }
            else
            {
                NewPasswordUpdateInputBox.UseSystemPasswordChar = true;
                ConfirmPasswordUpdateInputBox.UseSystemPasswordChar = true;
            }
          
        }

        private void MentorLogoutProfile_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void fillBy3ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.sTUDENTTableAdapter.FillBy3(this.mentorManagementDataSet.STUDENT);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
