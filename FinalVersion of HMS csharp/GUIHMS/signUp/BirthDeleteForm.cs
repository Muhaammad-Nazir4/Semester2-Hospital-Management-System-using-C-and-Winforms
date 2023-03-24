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
    public partial class BirthDeleteForm : Form
    {
        public BirthDeleteForm()
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
            dataGridView1.DataSource = birthDL.Baby;
        }
        private void Databind()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = birthDL.Baby;
            dataGridView1.Refresh();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            birthBL data = (birthBL)dataGridView1.CurrentRow.DataBoundItem;
            if (dataGridView1.Columns["Delete"].Index == e.ColumnIndex)
            {
                birthDL.deleteBirthFromFile(data);
                birthDL.birthStoreDataForDelete();
                Databind();
            }
        }
    }
}
