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
using static System.Net.Mime.MediaTypeNames;

namespace MentorManagementSystem
{
    public partial class StudentForm : Form
    {

        private string studentNumber;
        private string connectionString = "Server=143.128.146.30\\istn2;Database=ist2jf;User Id=ist2jf;Password=hw272e;";

        public StudentForm(string stuNum)
        {
            InitializeComponent();
            this.studentNumber = stuNum;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void LoadStudentsDetails()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string query = @"
                                SELECT STU_FNAME, STU_LNAME, STU_EMAIL, STU_PHONENUM, STU_YEAR
                                FROM STUDENT 
                                WHERE STU_NUM = @stuNum";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@stuNum", studentNumber);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string fname = reader["STU_FNAME"].ToString();
                            string lname = reader["STU_LNAME"].ToString();
                            string email = reader["STU_EMAIL"].ToString();
                            string phone = reader["STU_PHONENUM"].ToString();
                            string year = reader["STU_YEAR"].ToString();

                            StudentFirstNameResults.Text = fname;
                            StudentLastNameResults.Text = lname;
                            StudentEmailResults.Text = email;
                            StudentPhoneNumberResult.Text = phone;
                            StudentYearOfStudyResult.Text = year;
                        }
                        else
                        {
                            StudentFirstNameResults.Text = "Not Found";
                            StudentLastNameResults.Text = "Not Found";
                            StudentEmailResults.Text = "Not Found";
                            StudentPhoneNumberResult.Text = "Not Found";
                            StudentYearOfStudyResult.Text = "Not Found";
                        }
                    }
                }
            }
        }

        private void StudentFirstNameUpdateInputBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void StudentForm_Load(object sender, EventArgs e)
        {
            LoadMentorsForStudent();
            LoadStudentsDetails();
        }

        private void LoadMentorsForStudent()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string query = @"
                                SELECT M.MENTOR_FNAME, M.MENTOR_EMAIL, M.MENTOR_PHONE_NO
                                FROM MENTOR M
                                INNER JOIN MENTOR_ALLOCATION MA ON M.MENTOR_ID = MA.MENTOR_ID
                                WHERE MA.STU_NUM = @stuNum";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@stuNum", studentNumber);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        int count = 0;

                        while (reader.Read() && count < 3)
                        {
                            string fname = reader["MENTOR_FNAME"].ToString();
                            string email = reader["MENTOR_EMAIL"].ToString();
                            string phone = reader["MENTOR_PHONE_NO"].ToString();

                            if (count == 0)
                            {
                                FirstMentorResulLabel.Text = fname;
                                FirstMentorEmailResulLabel.Text = email;
                                FirstMentorPhoneNumberResulLabel.Text = phone;
                            }
                            else if (count == 1)
                            {
                                SecondMentorNameLabel.Text = fname;
                                SecondMentorEmailResults.Text = email;
                                MentorPhoneNumberResult.Text = phone;
                            }
                            else if (count == 2)
                            {
                                ThirdMentorNameLabel.Text = fname;
                                ThirdMentorEmailLabel.Text = email;
                                ThirdMentorPhoneNumberLabel.Text = phone;
                            }

                            count++;
                        }
                    }
                }
            }
        }
        private void ProfileLogoStudent_Click(object sender, EventArgs e)
        {

        }

        private void SignOutButton_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Close();

        }

        private void StudentPhoneNumberResult_Click(object sender, EventArgs e)
        {

        }

        private void StudentSaveChangesBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(StudentFirstNameUpdateInputBox.Text) ||
                string.IsNullOrWhiteSpace(StudentLastNameUpdateInputBox.Text) ||
                string.IsNullOrWhiteSpace(StudentPhoneNumberUpdateInputBox.Text) ||
                string.IsNullOrWhiteSpace(NewPasswordUpdateInputBox.Text) ||
                string.IsNullOrWhiteSpace(ConfirmPasswordUpdateInputBox.Text) ||
                (CourseUpdateComboBox.Text).Equals("Select") ||
                (CourseUpdateComboBox.Text).Equals(" ")) {

                MessageBox.Show("Please fill in all required fields.",
                                "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            } 
            //Phone number validation
            if (!Regex.IsMatch(StudentPhoneNumberUpdateInputBox.Text, @"^\d{10}$"))
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
            string firstName = StudentFirstNameUpdateInputBox.Text.Trim();
            string lastName = StudentLastNameUpdateInputBox.Text.Trim();
            string phoneNumber = StudentPhoneNumberUpdateInputBox.Text.Trim();
            string newPassword = NewPasswordUpdateInputBox.Text.Trim();
            string conPassword = ConfirmPasswordUpdateInputBox.Text.Trim();
            string courseName = CourseUpdateComboBox.Text;
            int year = (int)StudentYearOfStudyUpdateDetails.Value;
            int stuNum = int.Parse(KeepOnlyNumbers(StudentEmailResults.Text.Trim()));
            string email = StudentEmailResults.Text.Trim();

            //Connection string
            string connectionString = "Server=143.128.146.30\\istn2;Database=ist2jf;User Id=ist2jf;Password=hw272e;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                //UPDATE query with parameters
                string query = @"UPDATE STUDENT 
                                SET STU_FNAME = @FirstName,
                                    STU_LNAME = @LastName,
                                    STU_PHONENUM = @PhoneNumber,
                                    COURSE_CODE = (SELECT COURSE_CODE FROM COURSE WHERE COURSE_NAME = @CourseName),
                                    STU_YEAR = @Year
                                WHERE STU_EMAIL = @Email";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@FirstName", firstName);
                    cmd.Parameters.AddWithValue("@LastName", lastName);
                    cmd.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
                    cmd.Parameters.AddWithValue("@CourseName", courseName);
                    cmd.Parameters.AddWithValue("@Year", year);
                    cmd.Parameters.AddWithValue("@Email", email);

                    cmd.ExecuteNonQuery();
                }

                //Update Login Password
                string loginQuery = @"UPDATE LOGIN_PASSWORD
                                      SET USER_PASSWORD = @Password
                                      WHERE USER_NAME = @StuNum";

                using (SqlCommand loginCmd = new SqlCommand(loginQuery, conn))
                {
                    loginCmd.Parameters.AddWithValue("@Password", conPassword);
                    loginCmd.Parameters.AddWithValue("@StuNum", stuNum);

                    loginCmd.ExecuteNonQuery();
                }

                MessageBox.Show("Student details updated successfully!",
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
                NewPasswordUpdateInputBox.PasswordChar = '\0';
                ConfirmPasswordUpdateInputBox.PasswordChar = '\0';
            }
            else
            {
                NewPasswordUpdateInputBox.PasswordChar = '•';
                ConfirmPasswordUpdateInputBox.PasswordChar = '•';
            }
        }
    }
}
