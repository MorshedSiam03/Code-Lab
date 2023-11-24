using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Code_Lab
{
    public partial class SystemAdmin : Form
    {
        public SystemAdmin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            TeachersPayment teachersPayment = new TeachersPayment();
            teachersPayment.Show();

            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            TeachersPayment teachersPayment = new TeachersPayment();
            teachersPayment.Show();

            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TecherRegistration techerRegistration = new TecherRegistration();
            techerRegistration.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TecherRegistration techerRegistration = new TecherRegistration();
            techerRegistration.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ManageTeacher manageTeacher = new ManageTeacher();
            manageTeacher.Show();

            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ManageTeacher manageTeacher = new ManageTeacher();
            manageTeacher.Show();

            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ManageStudent manageStudent = new ManageStudent();
            manageStudent.Show();

            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ManageStudent manageStudent = new ManageStudent();
            manageStudent.Show();

            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            SetEvent setEvent = new SetEvent();
            setEvent.Show();

            this.Hide();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            UploadCourses uploadCourses = new UploadCourses();
            uploadCourses.Show();

            this.Hide();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            FaqSupport faqSupport = new FaqSupport();
            faqSupport.Show();

            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            SetEvent setEvent = new SetEvent();
            setEvent.Show();

            this.Hide();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            UploadCourses uploadCourses = new UploadCourses();
            uploadCourses.Show();

            this.Hide();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            FaqSupport faqSupport = new FaqSupport();
            faqSupport.Show();

            this.Hide();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();


            this.Hide();
        }
    }
}
