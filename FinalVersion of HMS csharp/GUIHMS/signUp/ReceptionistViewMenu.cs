using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace signUp
{
    public partial class ReceptionistViewMenu : Form
    {
        public ReceptionistViewMenu()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            
        }

        private void Pbtn2_Click(object sender, EventArgs e)
        {
           
        }

        private void Pbtn4_Click(object sender, EventArgs e)
        {
           
        }

        private void Pbtn8_Click(object sender, EventArgs e)
        {
           
        }

        private void BackButton_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form1 obj = new Form1();
            obj.Show();
        }

        private void Pbtn2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            viewPdetailInReceptionist obj = new viewPdetailInReceptionist();
            obj.Show();
        }

        private void Pbtn4_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            ReceptionistMedicalView obj = new ReceptionistMedicalView();
            obj.Show();
        }

        private void Pbtn8_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            feedbackViewForm obj = new feedbackViewForm();
            obj.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AppointmentViewForm obj = new AppointmentViewForm();
            obj.Show();
        }
    }
}
