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
    public partial class TecherRegistration : Form
    {
        public TecherRegistration()
        {
            InitializeComponent();
        }

        private void USERNAME_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SystemAdmin systemAdmin = new SystemAdmin();
            systemAdmin.Show();

            this.Hide();
        }

        private void SignUpBotton_Click(object sender, EventArgs e)
        {
            int outPhone;
            int outSalary;
            if (NameBox.Text == "")
            {
                NameBox.BackColor = Color.LightCoral;
                MessageBox.Show("Name Failed is Required", "Validition Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                NameBox.Focus();
            }

            else if (EmailBox.Text == "")
            {
                EmailBox.BackColor = Color.LightCoral;
                MessageBox.Show("Email Failed is Required", "Validition Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                EmailBox.Focus();
            }
            else if (AddressBox5.Text == "")
            {
                AddressBox5.BackColor = Color.LightCoral;
                MessageBox.Show("Address Failed is Required", "Validition Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                AddressBox5.Focus();
            }

            else if (QualificationBox.Text == "")
            {
                QualificationBox.BackColor = Color.LightCoral;
                MessageBox.Show("Qualification Failed is Required", "Validition Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                QualificationBox.Focus();
            }

            else if (SubjectcomboBox.Text == "")
            {
                SubjectcomboBox.BackColor = Color.LightCoral;
                MessageBox.Show("Subject Failed is Required", "Validition Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                SubjectcomboBox.Focus();
            }

            else if (DateTime.Today.AddYears(-20) < DOBdateTimePicker.Value.Date)
            {
                DOBdateTimePicker.BackColor = Color.LightCoral;
                MessageBox.Show("You must be 16 years old", "Validition Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DOBdateTimePicker.Focus();
            }

            else if (PhoneBox.Text == "")
            {
                PhoneBox.BackColor = Color.LightCoral;
                MessageBox.Show("Phone Failed is Required", "Validition Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                PhoneBox.Focus();
            }

            else if (!int.TryParse(PhoneBox.Text, out outPhone))
            {
                PhoneBox.BackColor = Color.LightCoral;
                MessageBox.Show("Invalid Phone Number", "Validition Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                PhoneBox.Focus();
            }

            else if (GendercomboBox.Text == "")
            {
                GendercomboBox.BackColor = Color.LightCoral;
                MessageBox.Show("Gender Failed is Required", "Validition Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                GendercomboBox.Focus();
            }

            else if (USERNAMEtextBox.Text == "")
            {
                USERNAMEtextBox.BackColor = Color.LightCoral;
                MessageBox.Show("USERNAME Failed is Required", "Validition Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                USERNAMEtextBox.Focus();
            }

            else if (PasswordBox.Text == "")
            {
                PasswordBox.BackColor = Color.LightCoral;
                MessageBox.Show("Password Failed is Required", "Validition Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                PasswordBox.Focus();
            }
            else if (SalaryBox.Text == "")
            {
                SalaryBox.BackColor = Color.LightCoral;
                MessageBox.Show("Salary Failed is Required", "Validition Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                SalaryBox.Focus();
            }

            else if (!int.TryParse(SalaryBox.Text, out outSalary))
            {
                SalaryBox.BackColor = Color.LightCoral;
                MessageBox.Show("Invalid Phone Number", "Validition Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                SalaryBox.Focus();
            }

            

            else
            {
                SqlConnection conn = new SqlConnection("Data Source=DESKTOP-GJFPPDJ;Initial Catalog=Teacher_Registration;Integrated Security=True");
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO [dbo].[Teacher_Registration] VALUES (@NAME,@EMAIL,@ADDRESS,@QUALIFICATION,@SPECIALIST,@DOB,@MOBILE,@GENDER,@USER_ID,@PASSWORD,@SALARY)", conn);
                cmd.Parameters.AddWithValue("@NAME", NameBox.Text);
                cmd.Parameters.AddWithValue("@EMAIL", EmailBox.Text);
                cmd.Parameters.AddWithValue("@ADDRESS", AddressBox5.Text);
                cmd.Parameters.AddWithValue("@QUALIFICATION", QualificationBox.Text);
                cmd.Parameters.AddWithValue("@SPECIALIST", SubjectcomboBox.Text);
                cmd.Parameters.AddWithValue("@DOB", DOBdateTimePicker.Text);
                cmd.Parameters.AddWithValue("@MOBILE", PhoneBox.Text);
                cmd.Parameters.AddWithValue("@GENDER", GendercomboBox.Text);
                cmd.Parameters.AddWithValue("@USER_ID", USERNAMEtextBox.Text);
                cmd.Parameters.AddWithValue("@PASSWORD", PasswordBox.Text);
                cmd.Parameters.AddWithValue("@SALARY", SalaryBox.Text);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("DATA REGISTERED SUCCESSFULLY", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TeacherClasses teacherClasses = new TeacherClasses();
                teacherClasses.Show();
                this.Hide();
            }
            

        }

        private void NameBox_TextChanged(object sender, EventArgs e)
        {
            NameBox.BackColor = Color.White;
        }

        private void EmailBox_TextChanged(object sender, EventArgs e)
        {
            EmailBox.BackColor = Color.White;
        }

        private void AddressBox5_TextChanged(object sender, EventArgs e)
        {
            AddressBox5.BackColor = Color.White;
        }

        private void QualificationBox_TextChanged(object sender, EventArgs e)
        {
            QualificationBox.BackColor = Color.White;
        }

        private void SubjectcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SubjectcomboBox.BackColor = Color.White;
        }

        private void PhoneBox_TextChanged(object sender, EventArgs e)
        {
            PhoneBox.BackColor = Color.White;
        }

        private void DOBdateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            DOBdateTimePicker.BackColor = Color.White;
        }

        private void GendercomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            GendercomboBox.BackColor = Color.White;
        }

        private void USERNAMEtextBox_TextChanged(object sender, EventArgs e)
        {
            USERNAMEtextBox.BackColor = Color.White;
        }

        private void PasswordBox_TextChanged(object sender, EventArgs e)
        {
            PasswordBox.BackColor = Color.White;
        }

        private void SalaryBox_TextChanged(object sender, EventArgs e)
        {
            SalaryBox.BackColor = Color.White;
        }

        private void TecherRegistration_Load(object sender, EventArgs e)
        {

        }
    }
}
