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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer(Properties.Resources.alert);
            player.Play();
            
            ReactorOne.BackColor = Color.Red;
            ReactorTwo.BackColor = Color.Red;
            Refresh();
            Thread.Sleep(200);
            EverythingIsAwesome.Text = "Everything is NOT Awesome!!!!";
            ReactorOne.BackColor = Color.Green;
            ReactorTwo.BackColor = Color.Green;
            Refresh();
            Thread.Sleep(200);
            ReactorOne.BackColor = Color.Red;
            ReactorTwo.BackColor = Color.Red;
            Refresh();
            Thread.Sleep(200);
            ReactorOne.BackColor = Color.Green;
            ReactorTwo.BackColor = Color.Green;
            Refresh();
            Thread.Sleep(200);
            ReactorOne.BackColor = Color.Red;
            ReactorTwo.BackColor = Color.Red;
            Refresh();
            Thread.Sleep(200);
            ReactorOne.BackColor = Color.Green;
            ReactorTwo.BackColor = Color.Green;
            Refresh();
            Thread.Sleep(200);
            ReactorOne.BackColor = Color.Red;
            ReactorTwo.BackColor = Color.Red;
            Refresh();
            Thread.Sleep(200);
            ReactorOne.BackColor = Color.White;
            ReactorTwo.BackColor = Color.White;
            Thread.Sleep(2500);
            Refresh();
            EverythingIsAwesome.Text = "Everything is Awesome!!!!";
            ReactorOne.BackColor = Color.Green;
            ReactorTwo.BackColor = Color.Green;
            Thread.Sleep(2500);
            Refresh();
        }

        private void ReactorOne_Click(object sender, EventArgs e)
        {

        }

        private void Background_Load(object sender, EventArgs e)
        {

        }
    }
}
