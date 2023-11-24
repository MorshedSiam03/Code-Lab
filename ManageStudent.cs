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
    public partial class ManageStudent : Form
    {
        public ManageStudent()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SystemAdmin systemAdmin = new SystemAdmin();
            systemAdmin.Show();

            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            if (USERNAMEtextBox.Text == "")
            {
                MessageBox.Show("Enter User ID", "Warnning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                SqlConnection conn = new SqlConnection("Data Source=DESKTOP-GJFPPDJ;Initial Catalog=Student_Registration;Integrated Security=True");
                conn.Open();
                SqlCommand cmd1 = new SqlCommand(@"SELECT NAME,EMAIL,INSTITUTION,ADDRESS,DOB,MOBILE,GENDER,PASSWORD  FROM [Student_Registration].[dbo].[Student_Registration] WHERE USERNAME  =@USERNAME", conn);
                cmd1.Parameters.AddWithValue("@USERNAME", USERNAMEtextBox.Text);
                SqlDataReader dr = cmd1.ExecuteReader();


                if (dr.Read())
                {
                    NameBox.Text = dr["NAME"].ToString();
                    EmailBox.Text = dr["EMAIL"].ToString();
                    INSTITUTIONcomboBox1.Text = dr["INSTITUTION"].ToString();
                    AddressBox5.Text = dr["ADDRESS"].ToString();
                    DOBdateTimePicker.Text = dr["DOB"].ToString();
                    PhoneBox.Text = dr["MOBILE"].ToString();
                    GendercomboBox.Text = dr["GENDER"].ToString();
                    PasswordBox.Text = dr["PASSWORD"].ToString();
                    conn.Close();

                    SqlDataAdapter da = new SqlDataAdapter(cmd1);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;

                }
                else
                {
                    MessageBox.Show("DATA NOT FOUND", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("DO YOU WANT TO UPDATE THE INFORMATION?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SqlConnection conn = new SqlConnection("Data Source=DESKTOP-GJFPPDJ;Initial Catalog=Student_Registration;Integrated Security=True");
                conn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE [Student_Registration].[dbo].[Student_Registration] SET PASSWORD = @PASSWORD,MOBILE = @MOBILE,NAME=@NAME,EMAIL=@EMAIL,ADDRESS=@ADDRESS,INSTITUTION=@INSTITUTION WHERE USERNAME  =@USERNAME", conn);
                cmd.Parameters.AddWithValue("@USERNAME", USERNAMEtextBox.Text);
                cmd.Parameters.AddWithValue("@PASSWORD", PasswordBox.Text);
                cmd.Parameters.AddWithValue("@MOBILE", PhoneBox.Text);
                cmd.Parameters.AddWithValue("@NAME", NameBox.Text);
                cmd.Parameters.AddWithValue("@EMAIL", EmailBox.Text);
                cmd.Parameters.AddWithValue("@ADDRESS", AddressBox5.Text);
                cmd.Parameters.AddWithValue("@INSTITUTION", INSTITUTIONcomboBox1.SelectedItem.ToString());


                cmd.ExecuteNonQuery();
                conn.Close();

                SqlConnection conn1 = new SqlConnection("Data Source=DESKTOP-GJFPPDJ;Initial Catalog=Student_Registration;Integrated Security=True");//source from student registration table
                conn.Open();
                SqlCommand cmd1 = new SqlCommand(@"SELECT *FROM [Student_Registration].[dbo].[Student_Registration] ", conn1);
                SqlDataAdapter da = new SqlDataAdapter(cmd1);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;

            }
            //MessageBox.Show("DATA UPDATED!!");
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("DO YOU WANT TO REMOVE THIS DATA?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SqlConnection conn = new SqlConnection("Data Source=DESKTOP-GJFPPDJ;Initial Catalog=Student_Registration;Integrated Security=True"); //remove from student reg. table
                conn.Open();
                SqlCommand cmd = new SqlCommand("DELETE [Student_Registration].[dbo].[Student_Registration] WHERE USERNAME=@USERNAME", conn);
                cmd.Parameters.AddWithValue("@USERNAME", USERNAMEtextBox.Text);
                cmd.ExecuteNonQuery();
                conn.Close();

                SqlConnection conn1 = new SqlConnection("Data Source=DESKTOP-GJFPPDJ;Initial Catalog=Student_Registration;Integrated Security=True");//source from student registration table
                conn.Open();
                SqlCommand cmd1 = new SqlCommand(@"SELECT *FROM [Student_Registration].[dbo].[Student_Registration] ", conn1);
                SqlDataAdapter da = new SqlDataAdapter(cmd1);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;

            }
            //MessageBox.Show("DATA REMOVED SUCCESSFULLY");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-GJFPPDJ;Initial Catalog=Student_Registration;Integrated Security=True");//source from student registration table
            conn.Open();
            SqlCommand cmd = new SqlCommand(@"SELECT *FROM [Student_Registration].[dbo].[Student_Registration] ", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ManageStudent_Load(object sender, EventArgs e)
        {

        }
    }
}
