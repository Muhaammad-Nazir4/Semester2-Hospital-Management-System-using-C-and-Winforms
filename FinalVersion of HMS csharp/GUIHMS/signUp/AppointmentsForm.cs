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
    public partial class AppointmentsForm : Form
    {
        public AppointmentsForm()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            PatientMenuForm obj = new PatientMenuForm();
            obj.Show();
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            string name = Form2.username;
            string doctor, day;
            if (comboBox1.Text == "" || comboBox2.Text == "")
            {
                MessageBox.Show("Not Submitted.Please fill all Credentials.");
            }
            else
            {

                doctor = comboBox1.Text;
                day = comboBox2.Text;
                appointment data = new appointment(name,doctor, day);
                MessageBox.Show("Request has been sent");
                appointmentDL.AppointmentList.Add(data);
                appointmentDL.storeData(name,data);
                comboBox1.Text = "";
                comboBox2.Text = "";
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
           
        }
    }
}
