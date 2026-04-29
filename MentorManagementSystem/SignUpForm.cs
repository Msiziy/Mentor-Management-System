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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace MentorManagementSystem
{
    public partial class SignUpForm : Form
    {
        public SignUpForm()
        {
            InitializeComponent();
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
                    return "Course not found!"; // Return not found for unknown course names
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
                    return -1; // Return -1 for unknown course names
            }
        }

        

        private void YearRollUpDown_ValueChanged(object sender, EventArgs e)
        {

        }

        private void MentorRoleBtn_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void StudentRadioBtn_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void conPassWordInputBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void newPasswordInputBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            //Validate required fields
            if (string.IsNullOrWhiteSpace(FNameInputBox.Text) ||
                string.IsNullOrWhiteSpace(LNameInputBox.Text) ||
                string.IsNullOrWhiteSpace(StudentNumberInputBox.Text) ||
                string.IsNullOrWhiteSpace(PhoneNumberInputBox.Text) ||
                string.IsNullOrWhiteSpace(newPasswordInputBox.Text) ||
                string.IsNullOrWhiteSpace(conPassWordInputBox.Text) ||
                (CourseSelectionbox.Text).Equals("Select") ||
                (CourseSelectionbox.Text).Equals(" ") ||
                (!StudentRadioBtn.Checked && !MentorRoleBtn.Checked))  // role must be selected
            {
                MessageBox.Show("Please fill in all required fields and select a role.",
                                "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //Student number validation
            if (!Regex.IsMatch(StudentNumberInputBox.Text, @"^\d+$"))
            {
                MessageBox.Show("Student Number must contain only digits.",
                                "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //Phone number validation
            if (!Regex.IsMatch(PhoneNumberInputBox.Text, @"^\d{10}$"))
            {
                MessageBox.Show("Phone Number must be 10 digits.",
                                "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //Password match check
            if (newPasswordInputBox.Text != conPassWordInputBox.Text)
            {
                MessageBox.Show("Passwords do not match!",
                                "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Password length check
            if (newPasswordInputBox.Text.Length < 6)
            {
                MessageBox.Show("Password must be at least 6 characters long.",
                                "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //Gather values
            long studentNumber;
            string email;
            string uncovertedStudentNo = StudentNumberInputBox.Text.Trim();
            if (!onlyDigits(uncovertedStudentNo))
            {
                MessageBox.Show("Student Number Must Contain Only Digits!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else {
                studentNumber = long.Parse(StudentNumberInputBox.Text.Trim());
                email = studentNumber.ToString() + "@stu.ukzn.ac.za";
            }
            string firstName = FNameInputBox.Text.Trim();
            string lastName = LNameInputBox.Text.Trim();
            string phoneNumber = PhoneNumberInputBox.Text.Trim();
            string newPassword = newPasswordInputBox.Text.Trim();
            string conPassword = conPassWordInputBox.Text.Trim();
            string courseName = CourseSelectionbox.Text;
             int year = (int)YearRollUpDown.Value;
            int schoolId = GetSchoolIdByCourseName(courseName);
            string courseCode = GetCourseId(courseName);
            string role = "";
            

            //Connection string
            string connectionString = "Server=143.128.146.30\\istn2;Database=ist2jf;User Id=ist2jf;Password=hw272e;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlCommand cmd;

                if (StudentRadioBtn.Checked)
                {
                    role = "STUDENT";
                    //Insert into STUDENT
                    string query = @"INSERT INTO STUDENT 
                     (STU_NUM, STU_FNAME, STU_LNAME, STU_PHONENUM, STU_EMAIL, STU_YEAR, COURSE_CODE) 
                     VALUES (@STU_NUM, @STU_FNAME, @STU_LNAME, @STU_PHONENUM, @STU_EMAIL, @STU_YEAR, @COURSE_CODE)";
                    cmd = new SqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@STU_NUM", studentNumber);
                    cmd.Parameters.AddWithValue("@STU_FNAME", firstName);
                    cmd.Parameters.AddWithValue("@STU_LNAME", lastName);
                    cmd.Parameters.AddWithValue("@STU_PHONENUM", phoneNumber);
                    cmd.Parameters.AddWithValue("@STU_EMAIL", email);
                    cmd.Parameters.AddWithValue("@STU_YEAR", year);
                    cmd.Parameters.AddWithValue("@COURSE_CODE", courseCode);

                    cmd.ExecuteNonQuery();
                }
                else
                {
                    role = "MENTOR";
                    //Insert into MENTOR
                    string query = @"INSERT INTO MENTOR 
                     (MENTOR_FNAME, MENTOR_LNAME, MENTOR_PHONE_NO, MENTOR_EMAIL, MENTOR_STATUS, SCHOOL_ID) 
                     VALUES (@MENTOR_FNAME, @MENTOR_LNAME, @MENTOR_PHONE_NO, @MENTOR_EMAIL, @MENTOR_STATUS, @SCHOOL_ID)";
                    cmd = new SqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@MENTOR_FNAME", firstName);
                    cmd.Parameters.AddWithValue("@MENTOR_LNAME", lastName);
                    cmd.Parameters.AddWithValue("@MENTOR_PHONE_NO", phoneNumber);
                    cmd.Parameters.AddWithValue("@MENTOR_EMAIL", email);
                    cmd.Parameters.AddWithValue("@MENTOR_STATUS", "Unactive");
                    cmd.Parameters.AddWithValue("@SCHOOL_ID", schoolId);

                    cmd.ExecuteNonQuery();
                }

                //Insert into LOGIN_PASSWORD for both Student and Mentor
                string loginQuery = @"INSERT INTO LOGIN_PASSWORD (USER_NAME, USER_PASSWORD,USER_ROLE) 
                              VALUES (@USER_NAME, @USER_PASSWORD,@USER_ROLE)";
                SqlCommand loginCmd = new SqlCommand(loginQuery, conn);
                loginCmd.Parameters.AddWithValue("@USER_NAME", studentNumber.ToString());
                loginCmd.Parameters.AddWithValue("@USER_PASSWORD", newPassword);
                loginCmd.Parameters.AddWithValue("@USER_ROLE", role);

                loginCmd.ExecuteNonQuery();

                MessageBox.Show("Account created successfully!");
                this.Hide();

            }
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        private void ShowPasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowPasswordCheckBox.Checked)
            {
                newPasswordInputBox.PasswordChar = '\0';
                conPassWordInputBox.PasswordChar = '\0';
            }
            else
            {
                newPasswordInputBox.PasswordChar = '•';
                conPassWordInputBox.PasswordChar = '•';
            }
        }

        private void SignInBtn_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        private void SignUpForm_Load(object sender, EventArgs e)
        {
            
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private bool onlyDigits(string username)
        {
            bool charCheck = false;
            for (int i = 0; i < username.Length; i++)
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
    }

}

