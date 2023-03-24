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
    public partial class AppointmentViewForm : Form
    {
        public AppointmentViewForm()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ReceptionistViewMenu obj = new ReceptionistViewMenu();
            obj.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
                    dataGridView1.DataSource = appointmentDL.AppointmentList;
        }
    }
}
