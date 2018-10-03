using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Threading;

namespace NuclearPower
{
    public partial class Background : Form
    {
        public Background()
        {
            InitializeComponent();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string userName;

            userName = textBox1.Text;

            outputLabel.Text = "Welcome " + textBox1.Text;

            const double SHIRT_PRICE = 12.3;
            const double HST = 0.13;
            double taxAmount, totalWithTax;

            taxAmount = SHIRT_PRICE * HST;

            totalWithTax = taxAmount + SHIRT_PRICE;

            outputLabel.Text += "\n";
            outputLabel.Text += "\nShirt       :" + SHIRT_PRICE.ToString("C");

            outputLabel.Text += "\nTax         :" + HST.ToString("C");
            outputLabel.Text += "\nTotal       :" + totalWithTax.ToString("C"); 

            outputLabel.Text = "Number One is: " + sum;
            outputLabel.Text += "\nNumber Two is: " + sum;

        }
    }
}
