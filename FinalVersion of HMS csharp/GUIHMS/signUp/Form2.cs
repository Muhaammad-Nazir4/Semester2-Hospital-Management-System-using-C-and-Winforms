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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
          

            
        }

        private void BackToSignUpButton_Click(object sender, EventArgs e)
        {
            

        }

        private void MessageLabel_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void EyeButton_Click(object sender, EventArgs e)
        {

            if (PasswordTextBox1.PasswordChar == '*')
            {
                EyeButton.BringToFront();
                PasswordTextBox1.PasswordChar = '\0';
            }
            else if (PasswordTextBox1.PasswordChar == '\0')
            {
                EyeButton.BringToFront();
                PasswordTextBox1.PasswordChar = '*';
            }
        }

        private void BackToSignUpButton_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form1 ob = new Form1();
            ob.Show();
        }
        public static string username = "";
        private void LoginButton_Click_1(object sender, EventArgs e)
        {
             
            username = UsernameTextBox.Text;
            string password = PasswordTextBox1.Text;
            string role = CredentialDL.SignIn(username, password);

            personalDL.PersonalReadData(CredentialDL.idx);
            medicalDL.medicalReadData(CredentialDL.idx);
            if (role == "admin")
            {
                MessageBox.Show("Congratulations, You have successfully loged In.");
                this.Hide();
                AdminMenuForm obj = new AdminMenuForm();
                obj.Show();
            }
            else if (role == "patient")
            {
                MessageBox.Show("Congratulations, You have successfully loged In.");
                this.Hide();
                PatientMenuForm obj = new PatientMenuForm();
                obj.Show();
            }
           else  if (role == "receptionist")
            {
                MessageBox.Show("Congratulations, You have successfully loged In.");
                this.Hide();
                ReceptionistViewMenu obj = new ReceptionistViewMenu();
                obj.Show();
            }
            else
            {
                MessageBox.Show("You are failed to login.");
            }
            
        }
    }
}
