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

namespace ChickenorEgg
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //user clicked on chicken
        private void RadChicken_CheckedChanged(object sender, EventArgs e)
        {
            picAnswer.Image = Image.FromFile("../../images/chicken.jpg");
            SoundPlayer player = new SoundPlayer("../../images/chicken.wav");
            player.Play();
        }
        //user clicked on egg
        private void RadEgg_CheckedChanged(object sender, EventArgs e)
        {
            picAnswer.Image = Image.FromFile("../../images/egg.jpg");
        }

    }
}
