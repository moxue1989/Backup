using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloWorld
{
    /* 
     *  this is my first C# application 
     *  Author: Mo Xue
     *  Date: Nov. 21, 2016
     * 
     * 
     */
    public partial class Form1 : Form
    {
        public Form1() // constructor of the form
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        // display personalized greeting
        private void button1_Click(object sender, EventArgs e)
        {
            lblGreeting.Text = "Hello " + txtName.Text;
            SoundPlayer player = new SoundPlayer(@"C:\Users\750118\Documents\Visual Studio 2015\Projects\HelloWorld\HelloWorld\images\frog.wav");
            player.Play();
            btnreset.Enabled = true;
        }

        // Resets and focus on text field

        private void button2_Click(object sender, EventArgs e)
        {
            txtName.ResetText();
            lblGreeting.Text = "Hello World";
            btnreset.Enabled = false;
            txtName.Focus();

        }

        // close the form
        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
