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
    public partial class MyCourses : Form
    {
        public MyCourses()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(progressBar1.Value < 30)
            {
                progressBar1.Value += 5;

                label2.Text = progressBar1.Value.ToString() + "%";
            }
            if (progressBar2.Value < 70)
            {
                progressBar2.Value += 5;

                label3.Text = progressBar2.Value.ToString() + "%";
            }
            if (progressBar3.Value < 80)
            {
                progressBar3.Value += 5;

                label4.Text = progressBar3.Value.ToString() + "%";
            }
            else
            {
                timer1.Stop();
            }
            
        }


        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Courses courses = new Courses();
            courses.Show();

            this.Hide();
        }

        private void button15_MouseClick(object sender, MouseEventArgs e)
        {
           
        }

        private void button6_Click(object sender, EventArgs e)
        {
            EnterMyCourse enterMyCourse = new EnterMyCourse();
            enterMyCourse.Show();

            this.Hide();
        }

        private void button13_MouseClick(object sender, MouseEventArgs e)
        {
         
        }

        private void button13_Click(object sender, EventArgs e)
        {
            LiveCourses liveCourses = new LiveCourses();
            liveCourses.Show();

            this.Hide();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            BookStore bookStore = new BookStore();
            bookStore.Show();

            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Community community = new Community();
            community.Show();

            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            AboutUs aboutUs = new AboutUs();
            aboutUs.Show();

            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MyProfileStudent myProfileStudent = new MyProfileStudent();
            myProfileStudent.Show();

            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EnterMyCourse enterMyCourse = new EnterMyCourse();
            enterMyCourse.Show();

            this.Hide();
        }
    }
}
