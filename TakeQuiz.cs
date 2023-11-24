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
    public partial class TakeQuiz : Form
    {
        public TakeQuiz()
        {
            InitializeComponent();
        }

        private void TakeQuiz_Load(object sender, EventArgs e)
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

        private void button14_Click_1(object sender, EventArgs e)
        {
            GoLive goLive = new GoLive();
            goLive.Show();
            this.Hide();
        }

        private void button13_Click_1(object sender, EventArgs e)
        {
            EvaluateStudent evaluateStudent = new EvaluateStudent();
            evaluateStudent.Show();
            this.Hide();
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            UploadAssingment uploadAssingment = new UploadAssingment();
            uploadAssingment.Show();
            this.Hide();
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            MyProfileTeacher myProfileTeacher = new MyProfileTeacher();
            myProfileTeacher.Show();
            this.Hide();
        }
    }
}
