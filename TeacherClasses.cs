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
    public partial class TeacherClasses : Form
    {
        public TeacherClasses()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MyProfileTeacher myProfileTeacher = new MyProfileTeacher();
            myProfileTeacher.Show();

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

        private void button13_Click(object sender, EventArgs e)
        {
            EvaluateStudent student = new EvaluateStudent();
            student.Show();

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

        private void button1_Click(object sender, EventArgs e)
        {
            EnterClass enterClass = new EnterClass();
            enterClass.Show();

            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}
