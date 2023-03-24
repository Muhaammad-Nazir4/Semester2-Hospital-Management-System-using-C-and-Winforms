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
    public partial class addPatientForm : Form
    {
        public addPatientForm()
        {
            InitializeComponent();
        }

        private void addPatientForm_Load(object sender, EventArgs e)
        {

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminMenuForm obj = new AdminMenuForm();
            obj.Show();
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            string patient_name, patientf_name, patient_gender, patient_date, patient_group, patient_disease;
            float patient_age;
            int patient_room;
            if (nameTextBox.Text == "" || fNameTextBox.Text == "" || comboBox1.Text == "" || ageTextBox.Text == "" ||
               dateTimePicker1.Text == "" || comboBox2.Text == "" || comboBox3.Text == "" || roomTextBox.Text == "")
            {
                MessageBox.Show("Not Submitted.Please fill all Credentials.");
            }
            else if (comboBox1.ForeColor == Color.Black && comboBox2.ForeColor == Color.Black && 
                ageTextBox.ForeColor == Color.Black && roomTextBox.ForeColor == Color.Black)
            {
                patient_name = nameTextBox.Text;
                patientf_name = fNameTextBox.Text;
                patient_group = comboBox1.Text;
                patient_gender = comboBox2.Text;
                patient_date = dateTimePicker1.Text;
                patient_disease = comboBox3.Text;
                patient_age = float.Parse(ageTextBox.Text);
                patient_room = int.Parse(roomTextBox.Text);
                patientBL data = new patientBL(patient_name, patientf_name, patient_gender, patient_age, patient_room,
                    patient_date, patient_group, patient_disease);
                patientDL.Data1.Add(data);
                patientDL.storeData(data);
                MessageBox.Show("All credentials are Submitted.");
                nameTextBox.Clear();
                fNameTextBox.Clear();
                comboBox1.Text = "";
                comboBox2.Text = "";
                dateTimePicker1.Text = "";
                comboBox3.Text = "";
                ageTextBox.Clear();
                roomTextBox.Clear();
            }           
            else
            {
                MessageBox.Show("Not Submitted.Please fill correct input.");
            }
        }

        private void dateTextBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void roomTextBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void ageTextBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void dateLabel_Click(object sender, EventArgs e)
        {

        }

        private void roomLabel_Click(object sender, EventArgs e)
        {

        }

        private void ageLabel_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void nameLabel_Click(object sender, EventArgs e)
        {

        }

        private void nameTextBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void MenuLabel_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void genderLabel_Click(object sender, EventArgs e)
        {

        }

        private void groupLabel_Click(object sender, EventArgs e)
        {

        }

        private void diseaseLabel_Click(object sender, EventArgs e)
        {

        }

        private void fnameLabel_Click(object sender, EventArgs e)
        {

        }

        private void diseaseTextBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void fNameTextBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void ApplicationLabel_Click(object sender, EventArgs e)
        {

        }

        private void nameTextBox_MaskInputRejected_1(object sender, MaskInputRejectedEventArgs e)
        {
            
        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void nameTextBox_MaskInputRejected_2(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void comboBox2_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void ageTextBox_TextChanged(object sender, EventArgs e)
        {
            Decimal a;

            bool isAValid = Decimal.TryParse(ageTextBox.Text, out a);

            if (isAValid)
            {
                ageTextBox.ForeColor = Color.Black;
               
            }

            else
                 ageTextBox.ForeColor = Color.Red;
        }

        private void ageTextBox_MaskInputRejected_1(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void roomTextBox_TextChanged(object sender, EventArgs e)
        {
            Decimal a;

            bool isAValid = Decimal.TryParse(roomTextBox.Text, out a);

            if (isAValid)
            {
                roomTextBox.ForeColor = Color.Black;
            }

            else
                roomTextBox.ForeColor = Color.Red;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
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

        private void fNameTextBox_MaskInputRejected_1(object sender, MaskInputRejectedEventArgs e)
        {
            
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


