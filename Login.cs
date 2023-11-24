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
    public partial class Login : Form
    {
        String sr1 = @"Data Source=DESKTOP-GJFPPDJ;Initial Catalog=Student_Registration;Integrated Security=True"; //student registration
        String sr2 = @"Data Source=DESKTOP-GJFPPDJ;Initial Catalog=Teacher_Registration;Integrated Security=True"; //teacherLogin
        String sr3 = @"Data Source=DESKTOP-GJFPPDJ;Initial Catalog=Admin;Integrated Security=True"; //adminLogin
        SqlConnection conn1 = new SqlConnection();
        SqlConnection conn2 = new SqlConnection();
        SqlConnection conn3 = new SqlConnection();
        SqlCommand cmd1 = new SqlCommand();
        SqlCommand cmd2 = new SqlCommand();
        SqlCommand cmd3 = new SqlCommand();
        SqlDataReader dr1;
        SqlDataReader dr2;
        SqlDataReader dr3;
        public Login()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                try
                {
                    conn1 = new SqlConnection(sr1);
                    conn2 = new SqlConnection(sr2);
                    conn3 = new SqlConnection(sr3);
                    conn1.Open();
                    conn2.Open();
                    conn3.Open();
                    cmd1 = new SqlCommand("SELECT * FROM [Student_Registration].[dbo].[Student_Registration] WHERE EMAIL= '" + textBox1.Text + "' AND PASSWORD = '" + textBox2.Text + "'", conn1);
                    cmd2 = new SqlCommand("SELECT * FROM [Teacher_Registration].[dbo].[Teacher_Registration] WHERE EMAIL= '" + textBox1.Text + "' AND PASSWORD = '" + textBox2.Text + "'", conn2);
                    cmd3 = new SqlCommand("SELECT * FROM [Admin].[dbo].[Admin] WHERE USER_ID = '" + textBox1.Text + "' AND PASSWORD = '" + textBox2.Text + "'", conn3);
                    dr1 = cmd1.ExecuteReader();
                    dr2 = cmd2.ExecuteReader();
                    dr3 = cmd3.ExecuteReader();
                    while (dr1.Read())
                    {
                        string email = textBox1.Text;
                        string password = textBox2.Text;
                        if (dr1["EMAIL"].ToString() == email && dr1["PASSWORD"].ToString() == password)
                        {

                            email = textBox1.Text;
                            password = textBox2.Text;

                            Courses courses = new Courses();
                            courses.Show();
                            this.Hide();

                        }
                        else
                        {
                            MessageBox.Show("The username or password you entered is incorrect!", "Logon Message!");
                            textBox1.Clear();
                            textBox2.Clear();
                        }
                        dr1.Close();
                    }
                    while (dr2.Read())
                    {
                        string temail = textBox1.Text;
                        string tpass = textBox2.Text;
                        if (dr2["EMAIL"].ToString() == temail && dr2["PASSWORD"].ToString() == tpass)
                        {
                            temail = textBox1.Text;
                            tpass = textBox2.Text;
                            TeacherClasses teacherClasses = new TeacherClasses();
                            teacherClasses.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("The username or password you entered is incorrect!", "Logon Message!");
                            textBox1.Clear();
                            textBox2.Clear();
                        }
                        dr2.Close();

                    }
                    while (dr3.Read())
                    {
                        string UserID = textBox1.Text;
                        string pass = textBox2.Text;
                        if (dr3["USER_ID"].ToString() == UserID && dr3["PASSWORD"].ToString() == pass)
                        {
                            UserID = textBox1.Text;
                            pass = textBox2.Text;
                            SystemAdmin admin = new SystemAdmin();
                            admin.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("The User ID or password you entered is incorrect!", "Logon Message!");
                            textBox1.Clear();
                            textBox2.Clear();
                        }
                        dr3.Close();

                    }
                    conn1.Close();
                    conn2.Close();
                    conn3.Close();

                }

                catch (Exception)
                {

                }
            }
        }


        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            StudentReg studentReg = new StudentReg();
            studentReg.Show();
            this.Hide();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            

        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox2.PasswordChar == '\0')
            {
                button2.BringToFront();
                textBox2.PasswordChar = '*';
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if(textBox2.PasswordChar =='*')
            {
                button3.BringToFront();
                textBox2.PasswordChar = '\0';
            }
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrEmpty(textBox1.Text))
            {
                e.Cancel = true;
                textBox1.Focus();
                errorProvider1.SetError(textBox1, "Please enter your E-mail or User ID !");
            }
            else
            {
                e.Cancel=false;
                errorProvider1.SetError(textBox1,null);
            }
        }

        private void textBox2_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                e.Cancel = true;
                textBox1.Focus();
                errorProvider2.SetError(textBox2, "Please enter your Password !");
            }
            else
            {
                e.Cancel = false;
                errorProvider2.SetError(textBox2, null);
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
