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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace MentorManagementSystem
{
    public partial class AdminForm : Form
    {
        string connectionString = "Server=143.128.146.30\\istn2;Database=ist2jf;User Id=ist2jf;Password=hw272e;";
        public AdminForm()
        {
            InitializeComponent();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mentorManagementDataSet.MENTOR' table. You can move, or remove it, as needed.
            this.mENTORTableAdapter.Fill(this.mentorManagementDataSet.MENTOR);
            // TODO: This line of code loads data into the 'mentorManagementDataSet.STUDENT' table. You can move, or remove it, as needed.
            this.sTUDENTTableAdapter.Fill(this.mentorManagementDataSet.STUDENT);
            // TODO: This line of code loads data into the 'mentorManagementDataSet.MENTOR' table. You can move, or remove it, as needed.

        }

        private void AdminStudentNumberInputBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void AdminAllocationButton_Click(object sender, EventArgs e)
        {
            //Get input values
            string studentNum = AdminStudentNumberInputBox.Text.Trim();
            string mentorId = AdminMentorIDIInputBox.Text.Trim();
            string status = AdminActiveStatusComboBox.Text.Trim();

            //Validate inputs
            if (string.IsNullOrEmpty(studentNum) || string.IsNullOrEmpty(mentorId))
            {
                MessageBox.Show("Please fill in all fields!", "Empty Field(s) Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                if (!onlyDigits(studentNum) && !onlyDigits(mentorId)) {
                    MessageBox.Show("Student Number or Mentor ID Must Contain Only Digit(s)!", "Invalid Input(s)", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlTransaction transaction = conn.BeginTransaction();

                    try
                    {
                        //Check if Student exists
                        string checkStudentQuery = "SELECT COUNT(*) FROM STUDENT WHERE STU_NUM = @stuNum";
                        using (SqlCommand cmd = new SqlCommand(checkStudentQuery, conn, transaction))
                        {
                            cmd.Parameters.AddWithValue("@stuNum", studentNum);
                            int studentExists = (int)cmd.ExecuteScalar();

                            if (studentExists == 0)
                            {
                                MessageBox.Show("Invalid Student Number! Student does not exist.", "Invalid User Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                transaction.Rollback();
                                return;
                            }
                        }
                        //Check if Mentor exists
                        string checkMentorQuery = "SELECT COUNT(*) FROM MENTOR WHERE MENTOR_ID = @mentorId";
                        using (SqlCommand cmd = new SqlCommand(checkMentorQuery, conn, transaction))
                        {
                            cmd.Parameters.AddWithValue("@mentorId", mentorId);
                            int mentorExists = (int)cmd.ExecuteScalar();

                            if (mentorExists == 0)
                            {
                                MessageBox.Show("Invalid Mentor ID! Mentor does not exist.", "Invalid User Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                transaction.Rollback();
                                return;
                            }
                        }

                        //Ensure Student has at most 3 Mentors
                        string countAllocQuery = "SELECT COUNT(*) FROM MENTOR_ALLOCATION WHERE STU_NUM = @stuNum";
                        using (SqlCommand cmd = new SqlCommand(countAllocQuery, conn, transaction))
                        {
                            cmd.Parameters.AddWithValue("@stuNum", studentNum);
                            int currentAllocations = (int)cmd.ExecuteScalar();

                            if (currentAllocations >= 3)
                            {
                                MessageBox.Show("This student already has 3 mentors allocated.", "Allocation ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                transaction.Rollback();
                                return;
                            }
                        }

                        //Insert into MENTOR_ALLOCATION
                        string insertQuery = @"INSERT INTO MENTOR_ALLOCATION (MENTOR_ID, STU_NUM, STU_FNAME, STU_LNAME, STU_PHONENUM, STU_EMAIL, COURSE_CODE)
                              SELECT @mentorId, s.STU_NUM, s.STU_FNAME, s.STU_LNAME, s.STU_PHONENUM, s.STU_EMAIL, c.COURSE_CODE
                              FROM STUDENT s
                              INNER JOIN COURSE c ON s.COURSE_CODE = c.COURSE_CODE
                              WHERE s.STU_NUM = @stuNum;";

                        using (SqlCommand cmd = new SqlCommand(insertQuery, conn, transaction))
                        {
                            cmd.Parameters.AddWithValue("@mentorId", mentorId);
                            cmd.Parameters.AddWithValue("@stuNum", studentNum);

                            int rowsAffected = cmd.ExecuteNonQuery();

                        }


                        //Update Mentor Status to Active
                        string updateMentorQuery = "UPDATE MENTOR SET MENTOR_STATUS = 'Active' WHERE MENTOR_ID = @mentorId";
                        using (SqlCommand cmd = new SqlCommand(updateMentorQuery, conn, transaction))
                        {
                            cmd.Parameters.AddWithValue("@mentorId", mentorId);
                            cmd.ExecuteNonQuery();
                        }

                        //Update Student Allocation Status
                        string updateStudentQuery = "UPDATE STUDENT SET ALLOCATION_STATUS = 'Allocated' WHERE STU_NUM = @stuNum";
                        using (SqlCommand cmd = new SqlCommand(updateStudentQuery, conn, transaction))
                        {
                            cmd.Parameters.AddWithValue("@stuNum", studentNum);
                            cmd.ExecuteNonQuery();
                        }

                        transaction.Commit();
                        MessageBox.Show("Mentor successfully allocated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            LoadMentors();
            LoadStudents();
        }

        private void LoadMentors()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM MENTOR ORDER BY CASE WHEN MENTOR_STATUS = 'Active' THEN 0 ELSE 1 END, Mentor_ID";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                AdminMentorDataGridView.DataSource = dt;
            }
        }

        private void LoadStudents()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"SELECT S.STU_NUM, S.STU_FNAME, S.STU_LNAME, S.STU_PHONE,S.STU_EMAIL,S.YEAR_OF_STUDY, S.COURSE_CODE, S.ALLOCATION_STATUS,ISNULL(COUNT(MA.MENTOR_ID), 0) AS AllocationCount,
                   CASE 
                        WHEN ISNULL(COUNT(MA.MENTOR_ID), 0) > 0 
                        THEN 'Allocated: ' + CAST(COUNT(MA.MENTOR_ID) AS VARCHAR)
                        ELSE 'Unallocated'
                   END AS AllocationDisplay
                   FROM STUDENT S
                   LEFT JOIN MENTOR_ALLOCATION MA ON S.STU_NUM = MA.STU_NUM
                   GROUP BY S.STU_NUM, S.STU_FNAME, S.STU_LNAME, S.STU_PHONE, 
                             S.STU_EMAIL, S.YEAR_OF_STUDY, S.COURSE_CODE, S.ALLOCATION_STATUS
                   ORDER BY COUNT(MA.MENTOR_ID) DESC, 
                             CASE WHEN S.ALLOCATION_STATUS = 'Allocated' THEN 0 ELSE 1 END, 
                             S.STU_NUM";

                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                AdminStudentsDataGridView.DataSource = dt;
            }
        }

        private void AdminSearchBtn_Click(object sender, EventArgs e)
        {
            string selectedOption = AdminSearchByComboBox.SelectedItem.ToString();
            string inputId = AdminSearchInputBox.Text.Trim();

            if (string.IsNullOrEmpty(inputId))
            {
                MessageBox.Show("Please enter an ID to search.", "Select ID Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string query = "";
                if (selectedOption == "STUDENT")
                {
                    query = @"SELECT STU_NUM AS [Student Number], 
                                     STU_FNAME AS [First Name], 
                                     STU_LNAME AS [Last Name], 
                                     STU_PHONENUM AS [Phone Number], 
                                     STU_EMAIL, 
                                     STU_YEAR AS [Year Of Study], 
                                     COURSE_CODE AS [Course Code], 
                                     ALLOCATION_STATUS AS [Allocation Status]
                              FROM STUDENT 
                              WHERE STU_NUM = @id";
                }
                else if (selectedOption == "MENTOR")
                {
                    query = @"SELECT MENTOR_ID AS [Mentor ID], 
                                     MENTOR_FNAME AS [First Name], 
                                     MENTOR_LNAME AS [Last Name], 
                                     MENTOR_PHONE_NO AS [Phone Number], 
                                     MENTOR_EMAIL, 
                                     MENTOR_STATUS AS [Allocation Status], 
                                     SCHOOL_ID
                              FROM MENTOR 
                              WHERE MENTOR_ID = @id";
                }

                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                da.SelectCommand.Parameters.AddWithValue("@id", inputId);

                DataTable dt = new DataTable();
                da.Fill(dt);

                AdminResultsTable.DataSource = dt;

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("No results found.", "Not Found Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void AdminDeleteBtn_Click(object sender, EventArgs e)
        {
            if (AdminResultsTable.Rows.Count == 0)
            {
                MessageBox.Show("No user selected to delete.", "Invalid User Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string selectedOption = AdminSearchByComboBox.SelectedItem.ToString();
            string userId = AdminSearchInputBox.Text.Trim();

            if (string.IsNullOrEmpty(userId))
            {
                MessageBox.Show("Please search for a user before deleting.","Search Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlTransaction transaction = conn.BeginTransaction();

                try
                {
                    //Get user details before deleting
                    string fetchQuery = "";
                    if (selectedOption == "STUDENT")
                    {
                        fetchQuery = @"SELECT STU_NUM, STU_FNAME AS FNAME, STU_LNAME AS LNAME, STU_PHONENUM AS PHONENUM, STU_EMAIL AS EMAIL, 
                                              STU_YEAR AS USER_YEAR, COURSE_CODE 
                                       FROM STUDENT 
                                       WHERE STU_NUM = @id";
                    }
                    else if (selectedOption == "MENTOR")
                    {
                        fetchQuery = @"SELECT MENTOR_ID AS STU_NUM, MENTOR_FNAME AS FNAME, MENTOR_LNAME  AS LNAME, MENTOR_PHONE_NO AS PHONENUM, MENTOR_EMAIL AS EMAIL,
                                        NULL AS USER_YEAR,NULL AS COURSE_CODE
                                       FROM MENTOR 
                                       WHERE MENTOR_ID = @id";
                    }

                    SqlCommand fetchCmd = new SqlCommand(fetchQuery, conn, transaction);
                    fetchCmd.Parameters.AddWithValue("@id", userId);

                    DataTable userData = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(fetchCmd);
                    da.Fill(userData);

                    if (userData.Rows.Count == 0)
                    {
                        MessageBox.Show("User not found.", "Invalid User Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        transaction.Rollback();
                        return;
                    }

                    DataRow row = userData.Rows[0];

                    //Insert into DELETE_USER
                    string insertDeleteQuery = @"INSERT INTO DELETE_USER 
                                                (USER_STUDENT_NUM, USER_FNAME, USER_LNAME, USER_PHONE_NUM, USER_EMAIL, USER_YEAR, COURSE_CODE) 
                                                VALUES (@id, @fname, @lname, @phone, @email, @year, @course)";

                    SqlCommand insertCmd = new SqlCommand(insertDeleteQuery, conn, transaction);
                    insertCmd.Parameters.AddWithValue("@id", row["STU_NUM"].ToString());
                    insertCmd.Parameters.AddWithValue("@fname", row["FNAME"].ToString());
                    insertCmd.Parameters.AddWithValue("@lname", row["LNAME"].ToString());
                    insertCmd.Parameters.AddWithValue("@phone", row["PHONENUM"].ToString());
                    insertCmd.Parameters.AddWithValue("@email", row["EMAIL"].ToString());
                    insertCmd.Parameters.AddWithValue("@year", row["USER_YEAR"].ToString());
                    insertCmd.Parameters.AddWithValue("@course", row["COURSE_CODE"].ToString());
                    insertCmd.ExecuteNonQuery();

                    //Delete from original table
                    string deleteQuery = selectedOption == "STUDENT"
                                         ? "DELETE FROM STUDENT WHERE STU_NUM = @id"
                                         : "DELETE FROM MENTOR WHERE MENTOR_ID = @id";

                    SqlCommand deleteCmd = new SqlCommand(deleteQuery, conn, transaction);
                    deleteCmd.Parameters.AddWithValue("@id", userId);
                    deleteCmd.ExecuteNonQuery();

                    //Commit transaction
                    transaction.Commit();
                    MessageBox.Show($"{selectedOption}  Successfully Deleted/Archived!!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //Refresh search results
                    AdminResultsTable.DataSource = null;
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void AdminStudentTabelLabel_Click(object sender, EventArgs e)
        {

        }

        private void AdminMentorManagementLogo_Click(object sender, EventArgs e)
        {

        }

        private void AdminStudentsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AdminMentorIDIInputBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void AdminLogOutBtn_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Close();
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
