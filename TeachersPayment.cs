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
    public partial class TeachersPayment : Form
    {
        public TeachersPayment()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-GJFPPDJ;Initial Catalog=Teacher_Registration;Integrated Security=True");
        private void TeachersPayment_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

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
                MessageBox.Show("ENTER TEACHER ID","Message",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                SqlConnection conn = new SqlConnection("Data Source=DESKTOP-GJFPPDJ;Initial Catalog=Teacher_Registration;Integrated Security=True");
                conn.Open();
                SqlCommand cmd1 = new SqlCommand(@"SELECT NAME,SPECIALIST,SALARY FROM [Teacher_Registration].[dbo].[Teacher_Registration] WHERE [USER ID]  =@USER_ID", conn);
                cmd1.Parameters.AddWithValue("@USER_ID", USERNAMEtextBox.Text);
                SqlDataReader dr = cmd1.ExecuteReader();


                if (dr.Read())
                {
                    NameBox.Text = dr["NAME"].ToString();

                    SubjectcomboBox.Text = dr["SPECIALIST"].ToString();

                    SalaryBox.Text = dr["SALARY"].ToString();



                    conn.Close();

                }
                else
                {
                    MessageBox.Show("DATA NOT FOUND","INVALID",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
        }
        int dailyBase, totalAmount;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(richTextBox1.Text, new Font("Times New Roman", 14, FontStyle.Bold), Brushes.Black, new PointF(100, 100));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
                printDocument1.Print();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (SubjectcomboBox.Text == "")
            {
                MessageBox.Show("SELECT SUBJECT/ COURSE","Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textBox1.Text == "" || int.Parse(textBox1.Text) > 28)
            {
                MessageBox.Show("ENTER THE AMOUNT OF VALID DAYS", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (SubjectcomboBox.Text == "BASIC PROGRAMMING LANGUAGE ")
                {
                    dailyBase = 300;
                }
                else if (SubjectcomboBox.Text == "OBJECT ORIANTED PROGRAMMING  ")
                {
                    dailyBase = 400;
                }
                else if (SubjectcomboBox.Text == "SOFTTWARE DEVELOPMENT ")
                {
                    dailyBase = 500;
                }
                else if (SubjectcomboBox.Text == "WEB DEVELOPMENT")
                {
                    dailyBase = 600;
                }
                else if (SubjectcomboBox.Text == "DATA SCIENCE")
                {
                    dailyBase = 700;
                }
                else
                {
                    dailyBase = 200;
                }
                totalAmount = int.Parse(SalaryBox.Text) + (dailyBase * int.Parse(textBox1.Text));
                      richTextBox1.Text = "TEACHER'S ID        : " 
          + USERNAMEtextBox.Text + "\n" + "TEACHER'S NAME  : " 
                  + NameBox.Text + "\n" + "SUBJECT                 : " 
          + SubjectcomboBox.Text + "\n" + "DAILY FEE              : " 
              + dailyBase + " ৳" + "\n" + "TOTAL AMOUNT    : " + totalAmount + " ৳";
            }
        }
    }
}
