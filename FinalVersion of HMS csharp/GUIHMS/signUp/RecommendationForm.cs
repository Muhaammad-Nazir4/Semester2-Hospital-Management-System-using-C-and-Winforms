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
    public partial class RecommendationForm : Form
    {
        public RecommendationForm()
        {
            InitializeComponent();
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
    
           

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
           
        }

        private void BackButton_Click_1(object sender, EventArgs e)
        {
            
        }

        private void submitBtn_Click_1(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Fever,Flue or Headache")
            {
                MessageBox.Show( "You are recommended to go to Dr.Ali in room 5");
            }
            else if (comboBox1.Text == "Viral Infections")
            {
                MessageBox.Show("You are recommended to go to Dr.Ali in room 5");
            }
            else if (comboBox1.Text == "Others")
            {
                MessageBox.Show("You are recommended to go to Dr.Hammad in room 5");
            }
            else if (comboBox1.Text == "Delivery Case")
            {
                MessageBox.Show("You are recommended to go to Dr.Ashraf in room 6 ");
            }
            else if (comboBox1.Text == "Eye Infections")
            {
                MessageBox.Show("You are recommended to go to Dr.Ayesha in room 4 ");
            }
            else if (comboBox1.Text == "Ear, Nose and Throat  infections")
            {
                MessageBox.Show("You are recommended to go to Dr.Hania in room 3 ");
            }
            else
            {
                MessageBox.Show("Please enter correct input. ");
            }
        }

        private void BackButton_Click_2(object sender, EventArgs e)
        {
            this.Hide();
            PatientMenuForm obj = new PatientMenuForm();
            obj.Show();
        }
    }
}
