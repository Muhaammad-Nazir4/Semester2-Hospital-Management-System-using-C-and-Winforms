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
    public partial class feedbackViewForm : Form
    {
        public feedbackViewForm()
        {
            InitializeComponent();
        }

        private void feedbackViewForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = feedbackDL.CommentList;
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ReceptionistViewMenu obj = new ReceptionistViewMenu();
            obj.Show();
        }
    }
}
