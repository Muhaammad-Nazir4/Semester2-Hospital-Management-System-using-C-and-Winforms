﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace signUp
{
    public partial class roomForm : Form
    {
        public roomForm()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
           
        }

        private void BackButton_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            AdminMenuForm obj = new AdminMenuForm();
            obj.Show();
        }
    }
}
