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
    public partial class EvaluateStudent : Form
    {
        public EvaluateStudent()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            TeacherClasses teacherClasses = new TeacherClasses();
            teacherClasses.Show();
            this.Hide();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            TeacherUploadClasses teacherUploadClasses = new TeacherUploadClasses(); 
            teacherUploadClasses.Show();
            this.Hide();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            GoLive goLive = new GoLive();
            goLive.Show();
            this.Hide();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            TakeQuiz takeQuiz = new TakeQuiz();
            takeQuiz.Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            UploadAssingment uploadAssingment = new UploadAssingment();
            uploadAssingment.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MyProfileTeacher myProfileTeacher = new MyProfileTeacher();
            myProfileTeacher.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (USERNAMEtextBox.Text == "")
            {
                MessageBox.Show("ENTER USER NAME", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SqlConnection conn = new SqlConnection("Data Source=DESKTOP-GJFPPDJ;Initial Catalog=Student_Registration;Integrated Security=True");
                conn.Open();
                SqlCommand cmd1 = new SqlCommand(@"SELECT NAME,EMAIL FROM [Student_Registration].[dbo].[Student_Registration] WHERE USERNAME  =@USERNAME", conn);
                cmd1.Parameters.AddWithValue("@USERNAME", USERNAMEtextBox.Text);
                SqlDataReader dr = cmd1.ExecuteReader();


                if (dr.Read())
                {
                    NameBox.Text = dr["NAME"].ToString();

                    EmailBox.Text = dr["EMAIL"].ToString();

                    



                    conn.Close();

                }
                else
                {
                    MessageBox.Show("DATA NOT FOUND", "INVALID", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
                printDocument1.Print();
        }
        int totalAmount;
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Enter Marks", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textBox2.Text == "" || int.Parse(textBox2.Text) > 100)
            {
                MessageBox.Show("Enter Marks", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textBox3.Text == "" || int.Parse(textBox3.Text) > 100)
            {
                MessageBox.Show("Enter Marks", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (textBox4.Text == "" || int.Parse(textBox4.Text) > 100)
            {
                MessageBox.Show("Enter Marks", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textBox5.Text == "" || int.Parse(textBox5.Text) > 100)
            {
                MessageBox.Show("Enter Marks", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                
                totalAmount = int.Parse(textBox1.Text) + int.Parse(textBox2.Text)+ int.Parse(textBox3.Text)+ int.Parse(textBox4.Text)+ int.Parse(textBox5.Text);
                richTextBox1.Text = "USER NAME         : "
    + USERNAMEtextBox.Text + "\n" + "STUDENT NAME  : "
            + NameBox.Text + "\n" + "PERFORMANCE                 : "
    + textBox1.Text + "\n" + "QUIZ              : "
        + textBox2.Text + "\n" + "ASSINGMENT    : "
        + textBox3.Text + "\n" + "lAB TASK    : "
        + textBox4.Text + "\n" + "PROJECT    : "
        + textBox5.Text + "\n" + "TOTAL    : "
        + totalAmount;
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            TeacherClasses teacherClasses = new TeacherClasses();
            teacherClasses.Show();

            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void EmailLabel_Click(object sender, EventArgs e)
        {

        }

        private void nameLebel_Click(object sender, EventArgs e)
        {

        }

        private void EmailBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void NameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void USERNAMEtextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void USERNAME_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(richTextBox1.Text, new Font("Times New Roman", 14, FontStyle.Bold), Brushes.Black, new PointF(100, 100));
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {
           
        }
    }
}
