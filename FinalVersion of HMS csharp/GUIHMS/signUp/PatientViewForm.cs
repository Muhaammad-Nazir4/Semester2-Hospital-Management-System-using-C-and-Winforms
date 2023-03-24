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

namespace signUp
{
    public partial class PatientViewForm : Form
    {
        public PatientViewForm()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminMenuForm obj = new AdminMenuForm();
            obj.Show();
        }

        private void PatientViewForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = patientDL.Data1;
            patientDL.sorting();
        }

        private void BackButton_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            AdminMenuForm obj = new AdminMenuForm();
            obj.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
             dataGridView1.DataSource = patientDL.Data1;
            patientDL.sorting();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
