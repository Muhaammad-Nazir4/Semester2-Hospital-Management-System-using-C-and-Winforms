using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using signUp.BL;
using signUp.DL;

namespace signUp
{
    public partial class birthViewForm : Form
    {
        public birthViewForm()
        {
            InitializeComponent();
            
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminMenuForm obj = new AdminMenuForm();
            obj.Show();
        }

        private void birthViewForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = birthDL.Baby;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ApplicationLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
