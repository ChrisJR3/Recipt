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
            string. 

            outputLabel.Text = "Number One is: " + sum;
            outputLabel.Text += "\nNumber Two is: " + sum;

            sum = numberOne + numberTwo;
            ouputlabel.Text += "\nThe sum of numberOne and numberTwo is: " + sum;

            taxAmount = SHIRT_Price * taxAmount;
            totalWithTax = taxAmount + SHIRT_PRICE

            outputLabel.Text += "\n";
            outputLabel.Text += "\nShirt   :" + SHIRT_PRICE.ToString ("C") ;
            outputLabel.Text += "\nTax   :" + taxAmount.ToString("C");
            outputLabel.Text += "\nTotal   :" + totalWithTax.ToString("C");
        }
    }
}
