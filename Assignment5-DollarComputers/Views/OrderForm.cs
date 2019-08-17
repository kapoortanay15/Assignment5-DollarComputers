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
/// Description: This is the Order form, It shows the price of the selected 
///              It is the Last Page of the Program.                           
/// </summary>
namespace Assignment5_DollarComputers.Views
{
    public partial class OrderForm : Form
    {
        public double Tax;
        public double Total;
        public double Cost;

        public OrderForm()
        {
            InitializeComponent();
        }

        private void Backbutton_Click(object sender, EventArgs e)
        {
            ProductInfo productInfoForm = new ProductInfo();
            productInfoForm.Show();
            this.Hide();
        }

        private void FinishButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank you for Shopping from Dollar Computers" +
               "Your Order will be processed in 7-10 business days", "Order Confirmed",
               MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        /// <summary>
        /// This the event handler for the about click event. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //This will show about dialog box.
            Program.aboutForm.ShowDialog();
            this.Hide();
        }

        /// <summary>
        /// This is an Event Handler for Order form load event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void OrderForm_Load(object sender, EventArgs e)
        {
            //Tax = Math.Round((double)Program.products.cost, 2);
            //Tax = Math.Round(Tax * 0.13, 2);
            //Cost = Math.Round((double)Program.products.cost, 2);
            //Total = Math.Round(Tax + Cost, 2);
        }
    }
}
