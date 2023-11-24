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
    public partial class FaqSupport : Form
    {
        public FaqSupport()
        {
            InitializeComponent();
        }

        private void FaqSupport_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Send_Click(object sender, EventArgs e)
        {
            SystemAdmin systemAdmin = new SystemAdmin();
            systemAdmin.Show();
            this.Hide();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
