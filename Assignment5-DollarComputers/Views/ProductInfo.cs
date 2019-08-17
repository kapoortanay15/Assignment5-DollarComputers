using System;
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
/// Description: This is the Product Info form, It shows the Detailed Information of the selected Computer
///              It is the Fourth Page of the Program.                           
/// </summary>
namespace Assignment5_DollarComputers.Views
{
    public partial class ProductInfo : Form
    {
        public ProductInfo()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This is the event handler for Nextbutton click event 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void NextButton_Click(object sender, EventArgs e)
        {
            
            Program.orderForm.Show();
            this.Hide();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
