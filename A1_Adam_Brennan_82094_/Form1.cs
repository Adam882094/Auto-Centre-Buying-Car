// Assignment 1, Auto Form
// Adam Brennan
// 0882094
// Created March 31st 2021
// This application is able to help people calculate the amount due on a car. 
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace A1_Adam_Brennan_82094_
{
    public partial class frmSharpAutoForm : Form
    {
        //global used to store money along the way
        private double Addit { get; set; }
        private double Addit2 { get; set; }

        public frmSharpAutoForm()
        {
            InitializeComponent();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close(); // closes program
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Used when user clicks about in menu
            MessageBox.Show("This program calculates the amount due on a New or Used Vehicle");
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        { // check if box checked then either adds or removes the required amount
            if (chkStereoSystem.Checked)
            {
                Addit = Addit + 425.76;
            }
            else
            {
                Addit = Addit - 425.76;
            }
            if (Addit < 345) // fixes a glitch when removing amounts that are suppose to end on 0
            {
                Addit = 0;
            }
            txtAdditionalOptions.Text = Addit.ToString();
        }

        private void chkLeatherInterior_CheckedChanged(object sender, EventArgs e)
        {
            if (chkLeatherInterior.Checked)
            {
                Addit = Addit + 987.41;
            }
            else
            {
                Addit = Addit - 987.41;
            }
            if (Addit < 345) // fixes a glitch when removing amounts that are suppose to end on 0
            {
                Addit = 0;
            }
            txtAdditionalOptions.Text = Addit.ToString();
        }

        private void chkCompNav_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCompNav.Checked)
            {
                Addit = Addit + 1741.23;
            }
            else
            {
                Addit = Addit - 1741.23;
            }
            if (Addit < 345) // fixes a glitch when removing amounts that are suppose to end on 0
            {
                Addit = 0;
            }
            txtAdditionalOptions.Text = Addit.ToString();
        }
   //********** rdo functions subtrack old press amount and adds new one
        private void rdoStandard_CheckedChanged(object sender, EventArgs e)
        {
            Addit = Addit - Addit2; // remove addit2 use to store previous press
            Addit2 = 0; // converts to value in this case 0
            txtAdditionalOptions.Text = Addit.ToString(); // adds to textbox
        }

        private void rdoPearlized_CheckedChanged(object sender, EventArgs e)
        {
            Addit = Addit - Addit2; // remove addit2 use to store previous press
            Addit2 = 345.72; // converts to value in this case 345.72
            Addit = Addit + Addit2; // adds new value
            txtAdditionalOptions.Text = Addit.ToString();
        }

        private void rdoCustom_CheckedChanged(object sender, EventArgs e)
        {
            Addit = Addit - Addit2; // remove addit2 use to store previous press
            Addit2 = 599.99; // converts to value in this case 599.99
            Addit = Addit + Addit2; // adds new value
            txtAdditionalOptions.Text = Addit.ToString(); // adds to textbox
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // checks if valid
            string ans = vali.check(txtBasePrice.Text);
            if (ans == "1")
            {
                MessageBox.Show("Error: There is a negative value");
            }
            else
            {
                // checks if valid
                string ans2 = vali.check(txtTradeInAllowance.Text);
                if(ans2 == "1")
                {
                    MessageBox.Show("Error: There is a negative value");
                }
                else
                { 
                    // adds amount for each well rounding to 2 decimal places
                    double subTotal = Math.Round(double.Parse(txtBasePrice.Text) + Addit, 2);
                    txtSubTotal.Text = subTotal.ToString();
                    double tax = Math.Round(subTotal * 0.13, 2);
                    txtSalesTax.Text = tax.ToString();
                    double total = Math.Round(subTotal + tax, 2);
                    txtTotal.Text = total.ToString();
                    double amountDue = Math.Round(total - double.Parse(txtTradeInAllowance.Text), 2);
                    txtAmountDue.Text = amountDue.ToString();
                }
            }
        }

        private void txtBasePrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        { // resets everything
            chkStereoSystem.Checked = false;
            chkLeatherInterior.Checked = false;
            chkCompNav.Checked = false;
            rdoStandard.Checked = true;
            rdoPearlized.Checked = false;
            rdoCustom.Checked = false;
            txtBasePrice.Text = "";
            txtAdditionalOptions.Text = "";
            txtSubTotal.Text = "";
            txtSalesTax.Text = "";
            txtTotal.Text = "";
            txtTradeInAllowance.Text = "0";
            txtAmountDue.Text = "";
            Addit = 0;
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // lblBasePrice.Text
        }
    }
}
