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
    public partial class deathdataForm : Form
    {
        public deathdataForm()
        {
            InitializeComponent();
        }

        private void conlabel_Click(object sender, EventArgs e)
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
            string  name ,gdeath, fndeath, mndeath, nmbrdeath;
            if (nameTextBox.Text == "" || mNameTextBox.Text == "" || fNameTextBox.Text == "" ||
               phoneTextBox.Text == "" || comboBox2.Text == "")
            {
                MessageBox.Show("Not Submitted.Please fill all Credentials.");
            }
            else if (comboBox2.ForeColor == Color.Black) 
            {
            gdeath = comboBox2.Text;
            name = nameTextBox.Text;
            mndeath = mNameTextBox.Text;
            fndeath = fNameTextBox.Text;
            nmbrdeath = phoneTextBox.Text;
            deathBL deathData = new deathBL(name, fndeath, mndeath, gdeath, nmbrdeath);
                MessageBox.Show("All credentials are Submitted.");
            deathDL.Death.Add(deathData);
                deathDL.deathStoreData(deathData);
            comboBox2.Text = "";
            nameTextBox.Clear();
            mNameTextBox.Clear();
            phoneTextBox.Clear();
            fNameTextBox.Clear();
        }
            
            else
            {
                MessageBox.Show("Not Submitted.Please fill all Credentials.");
            }
}

        private void comboBox2_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void phoneTextBox_TextChanged(object sender, EventArgs e)
        {
            
            phoneTextBox.Mask = "00000000000";
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

        private void mNameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                label3.Visible = true;
                errorProvider1.SetError(label3, "Invalid Input");
                label3.Text = "Invalid Input";
            }
            else
            {
                label3.Visible = false;
                errorProvider1.SetError(label3, "");
                label3.Text = "";
            }
        }
    }
}
