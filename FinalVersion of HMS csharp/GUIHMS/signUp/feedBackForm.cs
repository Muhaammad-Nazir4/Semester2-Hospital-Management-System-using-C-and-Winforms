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
    public partial class feedBackForm : Form
    {
        public feedBackForm()
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
            if(feedbackTextBox.Text == "")
            {
                MessageBox.Show("Not Submitted.Please fill all Credentials.");
            }
            else
            {
                string Name, Comment;
                Name = nameTextBox.Text;
                Comment = feedbackTextBox.Text;
                feedback data = new feedback(Name, Comment);
                MessageBox.Show("Submitted.");
                feedbackDL.CommentList.Add(data);
                feedbackDL.FeedbackStoreData(data);
                nameTextBox.Clear();
                feedbackTextBox.Clear();
            }
            

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
    }
}
