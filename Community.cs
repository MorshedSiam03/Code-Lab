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
    public partial class Community : Form
    {
        public Community()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Courses courses = new Courses();
            courses.Show();

            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MyCourses myCourses = new MyCourses();
            myCourses.Show();

            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            LiveCourses LiveCourses = new LiveCourses();
            LiveCourses.Show();

            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            BookStore bookStore = new BookStore();
            bookStore.Show();

            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AboutUs aboutUs = new AboutUs();
            aboutUs.Show();

            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MyProfileStudent myProfileStudent = new MyProfileStudent();
            myProfileStudent.Show();

            this.Hide();
        }
    }
}
