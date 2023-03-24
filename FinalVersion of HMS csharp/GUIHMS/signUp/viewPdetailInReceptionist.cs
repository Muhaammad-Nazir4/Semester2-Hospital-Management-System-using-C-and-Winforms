using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using signUp.DL;
using signUp.BL;

namespace signUp
{
    public partial class viewPdetailInReceptionist : Form
    {
        public viewPdetailInReceptionist()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            
        }

        private void viewPdetailInReceptionist_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = personalDL.P;
        }

        private void BackButton_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            ReceptionistViewMenu obj = new ReceptionistViewMenu();
            obj.Show();
        }
    }
}
