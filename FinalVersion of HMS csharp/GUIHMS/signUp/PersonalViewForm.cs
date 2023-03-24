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
    public partial class PersonalViewForm : Form
    {
        public PersonalViewForm()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            

        }

        private void PersonalViewForm_Load(object sender, EventArgs e)
        {
            
            dataGridView1.DataSource = CredentialDL.SignUpdata[CredentialDL.idx].SeparateDataList;
        }

        private void BackButton_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            PatientMenuForm obj = new PatientMenuForm();
            obj.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ApplicationLabel_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
