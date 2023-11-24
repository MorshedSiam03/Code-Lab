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
    public partial class StudentReg : Form
    {
        public StudentReg()
        {
            InitializeComponent();
        }

        private void NameBox_TextChanged(object sender, EventArgs e)
        {
            NameBox.BackColor = Color.White;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();

            this.Hide();
        }

        private void StudentReg_Load(object sender, EventArgs e)
        {

        }

        private void SignUpBotton_Click(object sender, EventArgs e)
        {
            int outPhone;
            if (NameBox.Text == "")
            {
                NameBox.BackColor = Color.LightCoral;
                MessageBox.Show("Name Failed is Required", "Validition Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                NameBox.Focus();
            }

            else if(EmailBox.Text == "")
            {
                EmailBox.BackColor = Color.LightCoral;
                MessageBox.Show("Email Failed is Required", "Validition Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                EmailBox.Focus();
            }

            else if (INSTITUTIONcomboBox1.Text == "")
            {
                INSTITUTIONcomboBox1.BackColor = Color.LightCoral;
                MessageBox.Show("INSTITUTION Failed is Required", "Validition Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                INSTITUTIONcomboBox1.Focus();
            }

            else if (AddressBox.Text == "")
            {
                AddressBox.BackColor = Color.LightCoral;
                MessageBox.Show("Address Failed is Required", "Validition Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                AddressBox.Focus();
            }

            else if (DateTime.Today.AddYears(-16) <   DOBdateTimePicker.Value.Date)
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

            else if (PasswordBox.Text != ConPasswordBox.Text)
            {
                PasswordBox.BackColor = Color.LightCoral;
                ConPasswordBox.BackColor = Color.LightCoral;
                MessageBox.Show("Check you Password Again","Invalid Password",MessageBoxButtons.OK,MessageBoxIcon.Error);
                ConPasswordBox.Focus();
            }

            else if (!checkBox1.Checked)
            {
                linkLabel1.BackColor = Color.LightCoral;
                MessageBox.Show("Please Read terms and condition and press Checkbox", "Validition Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                checkBox1.Focus();
            }

            else
            {
                SqlConnection conn = new SqlConnection("Data Source=DESKTOP-GJFPPDJ;Initial Catalog=Student_Registration;Integrated Security=True");
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO [dbo].[Student_Registration] VALUES (@NAME,@EMAIL,@INSTITUTION,@ADDRESS,@DOB,@MOBILE,@GENDER,@USERNAME,@PASSWORD)", conn);
                cmd.Parameters.AddWithValue("@NAME", NameBox.Text);
                cmd.Parameters.AddWithValue("@EMAIL", EmailBox.Text);
                cmd.Parameters.AddWithValue("@INSTITUTION", INSTITUTIONcomboBox1.Text);
                cmd.Parameters.AddWithValue("@ADDRESS", AddressBox.Text);
                cmd.Parameters.AddWithValue("@DOB", DOBdateTimePicker.Text);
                cmd.Parameters.AddWithValue("@MOBILE", PhoneBox.Text);
                cmd.Parameters.AddWithValue("@GENDER", GendercomboBox.Text);
                cmd.Parameters.AddWithValue("@USERNAME", USERNAMEtextBox.Text);
                cmd.Parameters.AddWithValue("@PASSWORD", PasswordBox.Text);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("DATA REGISTERED SUCCESSFULLY","Confirmation",MessageBoxButtons.OK,MessageBoxIcon.Information);
                Login login = new Login();
                login.Show();

                this.Hide();
            }


        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.BackColor = Color.White;
            MessageBox.Show("The words of which the initial letter is capitalized " +
                            "have meanings defined under the following conditions." +
                            "The following definitions shall have the same meaning " +
                            "regardless of whether they appear in singular or in plural" +
                            
                            "Definitions:" +
                            "For the purposes of these Terms and Conditions:" +
                            "Application means the software program provided by the Company" +
                            " downloaded by You on any electronic device, named Code lab " +
                            "Application Store means the digital distribution service " +
                            "operated and developed by Apple Inc. (Apple App Store) or Google " +
                            "Inc. (Google Play Store) in which the Application has been " +
                            "downloaded Affiliate means an entity that controls, is controlled " +
                            "by or is under common control with a party, where control means " +
                            "ownership of 50 % or more of the shares, equity interest or other " +
                            "securities entitled to vote for election of directors or other " +
                            "managing authority. Country refers to: Bangladesh Company(referred " +
                            "to as either the Company, We, Us or Our in this Agreement) refers to " +
                            "Code Lab, 58 / 1 North Jatrabari.Device means any device that can " +
                            "access the Service such as a computer, a cellphone or a digital tablet." +
                            "Service refers to the Application."+
                            "Terms and Conditions(also referred as Terms) mean these Terms and"+  
                           "Conditions that form the entire agreement between You and the Company" +
                           " regarding the use of the Service.This Terms and Conditions agreement" +
                           " has been created with the help of the TermsFeed Terms and Conditions " +
                           "Generator."+
                            "Third - party Social Media Service means any services or content(including " +
                            "data, information, products or services) provided by a third - party that may " +
                            "be displayed, included or made available by the Service","Terms and Conditions");
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void confirmPass_Click(object sender, EventArgs e)
        {

        }

        private void INSTITUTIONcomboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            INSTITUTIONcomboBox1.BackColor = Color.White;
        }

        private void GendercomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            GendercomboBox.BackColor = Color.White;
        }

        private void ConPasswordBox_TextChanged(object sender, EventArgs e)
        {
            PasswordBox.BackColor = Color.White;
            ConPasswordBox.BackColor = Color.White;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void password_Click(object sender, EventArgs e)
        {

        }

        private void PasswordBox_TextChanged(object sender, EventArgs e)
        {
            PasswordBox.BackColor = Color.White;
        }

        private void USERNAME_Click(object sender, EventArgs e)
        {

        }

        private void DOBdateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            DOBdateTimePicker.BackColor = Color.White;
        }

        private void GENDERlebel_Click(object sender, EventArgs e)
        {

        }

        private void USERNAMEtextBox_TextChanged(object sender, EventArgs e)
        {
            USERNAMEtextBox.BackColor = Color.White;
        }

        private void MOBILElebel_Click(object sender, EventArgs e)
        {

        }

        private void DOBlabel_Click(object sender, EventArgs e)
        {

        }

        private void Addresslabel_Click(object sender, EventArgs e)
        {

        }

        private void InstitutionLabel_Click(object sender, EventArgs e)
        {

        }

        private void EmailLabel_Click(object sender, EventArgs e)
        {

        }

        private void nameLebel_Click(object sender, EventArgs e)
        {

        }

        private void regLebel_Click(object sender, EventArgs e)
        {

        }

        private void EmailBox_TextChanged(object sender, EventArgs e)
        {
            EmailBox.BackColor = Color.White;
        }

        private void AddressBox_TextChanged(object sender, EventArgs e)
        {
            AddressBox.BackColor = Color.White;
        }

        private void PhoneBox_TextChanged(object sender, EventArgs e)
        {
            PhoneBox.BackColor = Color.White;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
