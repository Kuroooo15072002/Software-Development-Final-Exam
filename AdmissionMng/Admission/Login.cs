﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Admission
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        private void loginbutton_Click_1(object sender, EventArgs e)
        {
            Home f = new Home();
            f.Show();
            this.Hide();
        }

        private void exitbutton_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}