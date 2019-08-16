﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment5_DollarComputers.Views
{
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
        }

        private void SplashForm_Load(object sender, EventArgs e)
        {
            SplashTimer.Enabled = true;
        }

        private void SplashTimer_Tick(object sender, EventArgs e)
        {
            //SplashTimer.Enabled = false;
            //Program.Views.StartForm.Show();
            //this.Hide();
            
            StartForm startForm = new StartForm();
            startForm.Show();
            SplashTimer.Enabled = false;
            this.Hide();
        }
    }
}
