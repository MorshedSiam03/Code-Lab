using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Code_Lab
{
    public partial class ManageTeacher : Form
    {
        public ManageTeacher()
        {
            InitializeComponent();
        }

        private void QualificationBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (USERNAMEtextBox.Text == "")
            {
                MessageBox.Show("Enter User ID", "Warnning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                SqlConnection conn = new SqlConnection("Data Source=DESKTOP-GJFPPDJ;Initial Catalog=Teacher_Registration;Integrated Security=True");
                conn.Open();
                SqlCommand cmd1 = new SqlCommand(@"SELECT NAME,EMAIL,ADDRESS,QUALIFICATION,SPECIALIST,GENDER,MOBILE,PASSWORD,SALARY  FROM [Teacher_Registration].[dbo].[Teacher_Registration] WHERE [USER ID]  =@USER_ID", conn);
                cmd1.Parameters.AddWithValue("@USER_ID", USERNAMEtextBox.Text);
                SqlDataReader dr = cmd1.ExecuteReader();


                if (dr.Read())
                {
                    NameBox.Text = dr["NAME"].ToString();
                    EmailBox.Text = dr["EMAIL"].ToString();
                    AddressBox5.Text = dr["ADDRESS"].ToString();
                    QualificationBox.Text = dr["QUALIFICATION"].ToString();
                    SubjectcomboBox.Text = dr["SPECIALIST"].ToString();
                    GendercomboBox.Text = dr["GENDER"].ToString();
                    PhoneBox.Text = dr["MOBILE"].ToString();
                    PasswordBox.Text = dr["PASSWORD"].ToString();
                    SalaryBox.Text = dr["SALARY"].ToString();
                    conn.Close();

                    //SqlConnection conn1 = new SqlConnection("Data Source=DESKTOP-HJBGACI\\SQLEXPRESS;Initial Catalog=Teacher_Registration;Integrated Security=True"); //source from teacher registration table
                    // conn1.Open();
                    //SqlCommand cmd = new SqlCommand(@"SELECT * FROM [Teacher_Registration].[dbo].[Teacher_Registration] [USER ID]=@USER_ID", conn1);
                    //cmd.Parameters.AddWithValue("@USER_ID", USERNAMEtextBox.Text);
                    SqlDataAdapter da = new SqlDataAdapter(cmd1);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;



                }
                else
                {
                    MessageBox.Show("DATA NOT FOUND", "INVALID", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void SalaryBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Qualifiction_Click(object sender, EventArgs e)
        {

        }

        private void InstitutionLabel_Click(object sender, EventArgs e)
        {

        }

        private void password_Click(object sender, EventArgs e)
        {

        }

        private void DOBdateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void PasswordBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void EmailBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void MOBILElebel_Click(object sender, EventArgs e)
        {

        }

        private void SubjectcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddressBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void USERNAME_Click(object sender, EventArgs e)
        {

        }

        private void DOBlabel_Click(object sender, EventArgs e)
        {

        }

        private void USERNAMEtextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Addresslabel_Click(object sender, EventArgs e)
        {

        }

        private void PhoneBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void NameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-GJFPPDJ;Initial Catalog=Teacher_Registration;Integrated Security=True"); //source from teacher registration table
            conn.Open();
            SqlCommand cmd = new SqlCommand(@"SELECT *FROM [Teacher_Registration].[dbo].[Teacher_Registration] ", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("DO YOU WANT TO REMOVE THIS DATA?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SqlConnection conn = new SqlConnection("Data Source=DESKTOP-GJFPPDJ;Initial Catalog=Teacher_Registration;Integrated Security=True"); //remove from teacherRegistration table
                conn.Open();
                SqlCommand cmd = new SqlCommand("DELETE  [Teacher_Registration].[dbo].[Teacher_Registration] WHERE [USER ID] =@USER_ID", conn);
                cmd.Parameters.AddWithValue("@USER_ID", USERNAMEtextBox.Text);
                cmd.ExecuteNonQuery();
                conn.Close();

                SqlConnection conn1 = new SqlConnection("Data Source=DESKTOP-GJFPPDJ;Initial Catalog=Teacher_Registration;Integrated Security=True"); //source from teacher registration table
                conn.Open();
                SqlCommand cmd1 = new SqlCommand(@"SELECT *FROM [Teacher_Registration].[dbo].[Teacher_Registration] ", conn1);
                SqlDataAdapter da = new SqlDataAdapter(cmd1);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            //MessageBox.Show("DATA REMOVED SUCCESSFULLY");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("DO YOU WANT TO UPDATE THE INFORMATION?","Confirmation Message",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                SqlConnection conn = new SqlConnection("Data Source=DESKTOP-GJFPPDJ;Initial Catalog=Teacher_Registration;Integrated Security=True");
                conn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE [Teacher_Registration].[dbo].[Teacher_Registration] SET [USER ID]=@USER_ID,NAME=@NAME,EMAIL=@EMAIL,ADDRESS=@ADDRESS,QUALIFICATION=@QUALIFICATION,PASSWORD=@PASSWORD,MOBILE=@MOBILE,SPECIALIST=@SPECIALIST,SALARY=@SALARY WHERE [USER ID] =@USER_ID", conn);
                cmd.Parameters.AddWithValue("@USER_ID", USERNAMEtextBox.Text);
                cmd.Parameters.AddWithValue("@NAME", NameBox.Text);
                cmd.Parameters.AddWithValue("@EMAIL", EmailBox.Text);
                cmd.Parameters.AddWithValue("@ADDRESS", AddressBox5.Text);
                cmd.Parameters.AddWithValue("@QUALIFICATION", QualificationBox.Text);
                cmd.Parameters.AddWithValue("@PASSWORD", PasswordBox.Text);
                cmd.Parameters.AddWithValue("@MOBILE", PhoneBox.Text);
                cmd.Parameters.AddWithValue("@SALARY", int.Parse(SalaryBox.Text));
                cmd.Parameters.AddWithValue("@SPECIALIST", SubjectcomboBox.SelectedItem.ToString());

                cmd.ExecuteNonQuery();
                conn.Close();


                SqlConnection conn1 = new SqlConnection("Data Source=DESKTOP-GJFPPDJ;Initial Catalog=Teacher_Registration;Integrated Security=True"); //source from teacher registration table
                conn.Open();
                SqlCommand cmd1 = new SqlCommand(@"SELECT *FROM [Teacher_Registration].[dbo].[Teacher_Registration] ", conn1);
                SqlDataAdapter da = new SqlDataAdapter(cmd1);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;


            }
            //MessageBox.Show("DATA UPDATED!!");
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void GENDERlebel_Click(object sender, EventArgs e)
        {

        }

        private void EmailLabel_Click(object sender, EventArgs e)
        {

        }

        private void GendercomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void confirmPass_Click(object sender, EventArgs e)
        {

        }

        private void nameLebel_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            SystemAdmin systemAdmin = new SystemAdmin();
            systemAdmin.Show();

            this.Hide();
        }
    }
}
