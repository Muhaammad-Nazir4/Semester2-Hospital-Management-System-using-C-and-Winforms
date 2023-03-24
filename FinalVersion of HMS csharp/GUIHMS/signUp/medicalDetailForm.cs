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
    public partial class medicalDetailForm : Form
    {
        public medicalDetailForm()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
           
        }
 
        private void submitBtn_Click_1(object sender, EventArgs e)
        {
            string patient_date, patient_group, patient_disease;

            if (comboBox1.Text == "" || dateTimePicker1.Text == "" ||  comboBox2.Text == "" )
            {
                MessageBox.Show("Not Submitted.Please fill all Credentials.");              
            }
            else if (comboBox1.ForeColor == Color.Black) {
                patient_group = comboBox1.Text;
                patient_date = dateTimePicker1.Text;
                patient_disease = comboBox2.Text;
                medicalBL data = new medicalBL(patient_date, patient_group,patient_disease );
                MessageBox.Show(" All Credentials are Submitted.");
                medicalDL.addIntoMedicalList(data,CredentialDL.idx);
                medicalDL.M.Add(data);
                medicalDL.medicalStoreData(data);
                medicalDL.AllmedicalStoreData(data);
                comboBox1.Text = "";
                dateTimePicker1.Text = "";
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

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "A+" || comboBox1.Text == "AB+" || comboBox1.Text == "B+" || comboBox1.Text == "O+" ||
               comboBox1.Text == "A-" || comboBox1.Text == "AB-" || comboBox1.Text == "B-" || comboBox1.Text == "O-")
            {
                comboBox1.ForeColor = Color.Black;
            }
            else
            {

                comboBox1.ForeColor = Color.Red;
            }
        }
    }
}
