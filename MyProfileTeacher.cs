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
    public partial class MyProfileTeacher : Form
    {
        public MyProfileTeacher()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TeacherClasses teacherClasses = new TeacherClasses();
            teacherClasses.Show();

            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();

            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Saved", "Confirmation", MessageBoxButtons.OKCancel);
        }
    }
}
