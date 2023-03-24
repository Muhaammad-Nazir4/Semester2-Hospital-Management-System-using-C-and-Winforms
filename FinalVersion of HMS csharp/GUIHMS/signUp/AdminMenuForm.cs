using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using signUp.Properties.DataSources;

namespace signUp
{
    public partial class AdminMenuForm : Form
    {
        public AdminMenuForm()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 obj = new Form1();
            obj.Show();
        }

        private void Abtn1_Click(object sender, EventArgs e)
        {
           
        }

        private void Abtn3_Click(object sender, EventArgs e)
        {
           

        }

        private void Abtn5_Click(object sender, EventArgs e)
        {
            
        }

        private void Abtn2_Click(object sender, EventArgs e)
        {
         
        }

        private void Abtn4_Click(object sender, EventArgs e)
        {
          
        }

        private void Abtn6_Click(object sender, EventArgs e)
        {
          
        }

        private void Abtn7_Click(object sender, EventArgs e)
        {
            this.Hide();
            roomForm obj = new roomForm();
            obj.Show();

        }

        private void Abtn1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            addPatientForm obj = new addPatientForm();
            obj.Show();
        }

        private void Abtn2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            PatientViewForm obj = new PatientViewForm();
            obj.Show();
        }

        private void Abtn3_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            birthDataForm obj = new birthDataForm();
            obj.Show();
        }

        private void Abtn4_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            birthViewForm obj = new birthViewForm();
            obj.Show();
        }

        private void Abtn5_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            deathdataForm obj = new deathdataForm();
            obj.Show();
        }

        private void Abtn6_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            deathViewForm obj = new deathViewForm();
            obj.Show();
        }

        private void Abtn7_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            roomForm obj = new roomForm();
            obj.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            DeletePatientForm obj = new DeletePatientForm();
            obj.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            BirthDeleteForm obj = new BirthDeleteForm();
            obj.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            deathDeleteForm obj = new deathDeleteForm();
            obj.Show();
        }
    }
}
