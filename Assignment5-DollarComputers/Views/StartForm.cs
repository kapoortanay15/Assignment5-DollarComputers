﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/// <summary>
/// Student Name: Tanay
/// Student Number: 301044399
/// Description: This is the Start form, It shows the Options to start a new order or open a saved order
///              It is the second Page of the Program.                           
/// </summary>
namespace Assignment5_DollarComputers.Views
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// This is an event handler for Exit button Click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ExitButton_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
        /// <summary>
        /// This is an event handler for new order button click event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NewOrderButton_Click(object sender, EventArgs e)
        {
            
            
            Program.selectForm.Show();
            this.Hide();
        }
        /// <summary>
        /// This is an event handler for open order button click event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenOrderButton_Click(object sender, EventArgs e)
        {
            
            
            Program.productInfo.Show();
            this.Hide();
        }
    }
}
