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
    public partial class DeletePatientForm : Form
    {
        public DeletePatientForm()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminMenuForm obj = new AdminMenuForm();
            obj.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            dataGridView1.DataSource = patientDL.Data1;
        }
        private void Databind()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = patientDL.Data1;
            dataGridView1.Refresh();

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            patientBL data = (patientBL)dataGridView1.CurrentRow.DataBoundItem;
            if(dataGridView1.Columns["Delete"].Index == e.ColumnIndex)
            {
                patientDL.deletePatientsFromFile(data);
                patientDL.storeDataForDelete();
                Databind();
            }
            else if (dataGridView1.Columns["Edit"].Index == e.ColumnIndex)
            {
                EditPatientForm myform = new EditPatientForm(data);
                myform.ShowDialog();
                patientDL.storeDataForDelete();
                Databind();
            }
        }
    }
}
