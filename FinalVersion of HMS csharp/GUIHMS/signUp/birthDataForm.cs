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
    public partial class birthDataForm : Form
    {
        public birthDataForm()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
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
            string gbirth, fnbirth, conbirth, mnbirth, nmbrbirth;
            if (nameTextBox.Text == "" || mNameTextBox.Text == "" || comboBox1.Text == "" ||
               phoneTextBox.Text == "" || comboBox2.Text == "")
            {
                MessageBox.Show("Not Submitted.Please fill all Credentials.");
               
            }
            else if (comboBox1.ForeColor == Color.Black && comboBox2.ForeColor == Color.Black )
            {
                gbirth = comboBox2.Text;
                fnbirth = nameTextBox.Text;
                mnbirth = mNameTextBox.Text;
                conbirth = comboBox1.Text;
                nmbrbirth = phoneTextBox.Text;
                birthBL birthData = new birthBL(gbirth, fnbirth, conbirth, mnbirth, nmbrbirth);
                MessageBox.Show("All credentials are Submitted.");
                birthDL.Baby.Add(birthData);
                birthDL.birthStoreData(birthData);
                comboBox2.Text = "";
                nameTextBox.Clear();
                mNameTextBox.Clear();
                comboBox1.Text = "";
                phoneTextBox.Clear();
            }
            else
            {
                MessageBox.Show("Not Submitted.Please fill all Credentials.");
            }

        }

        private void comboBox2_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void phoneTextBox_TextChanged(object sender, EventArgs e)
        {
            phoneTextBox.Mask = "00000000000";
        }

        private void phoneTextBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
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

        private void mNameTextBox_KeyPress(object sender, KeyPressEventArgs e)
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
