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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }
       
        private void AdmissionStudent_Click(object sender, EventArgs e)
        {
            AdS AdS = new AdS();
            AdS.ShowDialog();
        }
    }
}