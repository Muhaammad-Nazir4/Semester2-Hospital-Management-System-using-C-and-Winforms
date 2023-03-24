using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using signUp.BL;
using signUp.DL;

namespace signUp
{
    public partial class PersonalDetailForm : Form
    {

        public PersonalDetailForm()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
           

        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void submitBtn_Click_1(object sender, EventArgs e)
        {
            string patient_name, patientf_name, patient_gender;
            if (nameTextBox.Text == ""  || fNameTextBox.Text == "" || comboBox2.Text == "")
            {
                MessageBox.Show("Not Submitted.Please fill all Credentials.");
            }
            else if(comboBox2.ForeColor == Color.Black)
            {

                patient_name = nameTextBox.Text;
            patientf_name = fNameTextBox.Text;
            patient_gender = comboBox2.Text;
            personalBL data = new personalBL(patient_name, patientf_name, patient_gender);
                MessageBox.Show(" All Credentials are Submitted.");
               //for specific person specific data
                personalDL.addIntoList(data,CredentialDL.idx);
                personalDL.PersonalStoreData(data);
                //For receptionst view
                personalDL.P.Add(data);
                personalDL.AllPersonalStoreData(data);

                nameTextBox.Clear();
            fNameTextBox.Clear();
            comboBox2.Text = "";
        }
        else
            {
                MessageBox.Show("Not Submitted.");
            }
}

        private void BackButton_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            PatientMenuForm obj = new PatientMenuForm();
            obj.Show();

        }

        private void comboBox2_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void PersonalDetailForm_Load(object sender, EventArgs e)
        {

        }

        private void nameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                label1.Visible = true;
                errorProvider1.SetError(label1, "Invalid Input");
                label1.Text = "Invalid Input";
            }
            else
            {
                label1.Visible = false;
                errorProvider1.SetError(label1, "");
                label1.Text = "";
            }
        }

        private void fNameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                label2.Visible = true;
                errorProvider1.SetError(label2, "Invalid Input");
                label2.Text = "Invalid Input";
            }
            else
            {
                label2.Visible = false;
                errorProvider1.SetError(label2, "");
                label2.Text = "";
            }
        }
    }
}
