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
    public partial class PatientMenuForm : Form
    {
        public PatientMenuForm()
        {
            InitializeComponent();
        }

        private void Pbtn1_Click(object sender, EventArgs e)
        {
            
        }

        private void Pbtn2_Click(object sender, EventArgs e)
        {
           
        }

        private void Pbtn3_Click(object sender, EventArgs e)
        {
           
        }

        private void Pbtn5_Click(object sender, EventArgs e)
        {
           
        }

        private void Pbtn6_Click(object sender, EventArgs e)
        {
           
        }

        private void Pbtn4_Click(object sender, EventArgs e)
        {
           
        }

        private void Pbtn8_Click(object sender, EventArgs e)
        {
           
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
           
        }

        private void BackButton_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form1 obj = new Form1();
            obj.Show();
        }

        private void Pbtn1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            PersonalDetailForm obj = new PersonalDetailForm();
            obj.Show();
        }

        private void Pbtn2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            PersonalViewForm obj = new PersonalViewForm();
            obj.Show();
        }

        private void Pbtn3_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            medicalDetailForm obj = new medicalDetailForm();
            obj.Show();
        }

        private void Pbtn4_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            medicalViewForm obj = new medicalViewForm();
            obj.Show();
        }

        private void Pbtn5_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            DoctorForm obj = new DoctorForm();
            obj.Show();
        }

        private void Pbtn6_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            RecommendationForm obj = new RecommendationForm();
            obj.Show();
        }

        private void Pbtn7_Click(object sender, EventArgs e)
        {
            this.Hide();
            AppointmentsForm obj = new AppointmentsForm();
            obj.Show();
        }

        private void Pbtn8_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            feedBackForm obj = new feedBackForm();
            obj.Show();
        }
    }
}
