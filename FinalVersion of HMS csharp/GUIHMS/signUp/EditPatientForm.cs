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
    public partial class EditPatientForm : Form
    {
        private patientBL previous;
        public EditPatientForm(patientBL previous)
        {
            InitializeComponent();
            this.previous = previous;
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            patientBL updated = new patientBL(nameTextBox.Text, fNameTextBox.Text, comboBox2.Text, float.Parse(ageTextBox.Text),
            int.Parse(roomTextBox.Text), dateTimePicker1.Text, comboBox1.Text, comboBox3.Text) ;
            patientDL.EditUserFromList(previous, updated);
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
           

        }

        private void EditPatientForm_Load(object sender, EventArgs e)
        {
            //nameTextBox.Text = previous.Patient_name;
            fNameTextBox.Text = previous.Patientf_name;
            comboBox3.Text = previous.Patient_disease;
            comboBox1.Text = previous.Patient_group;
            comboBox2.Text = previous.Patient_gender;
            ageTextBox.Text = previous.Patient_age.ToString();
            roomTextBox.Text = previous.Patient_room.ToString();
            dateTimePicker1.Text = previous.Patient_date;
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
