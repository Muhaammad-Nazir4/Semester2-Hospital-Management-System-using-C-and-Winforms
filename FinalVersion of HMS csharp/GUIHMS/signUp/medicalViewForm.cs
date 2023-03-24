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
    public partial class medicalViewForm : Form
    {
        public medicalViewForm()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            
        }

        private void medicalViewForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = CredentialDL.SignUpdata[CredentialDL.idx].SeparateDataListForMedical;
        }

        private void BackButton_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            PatientMenuForm obj = new PatientMenuForm();
            obj.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
