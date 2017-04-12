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

namespace CoinMachine
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btnCalc_Click(object sender, EventArgs e)
        {
            progress.Value = 0;
            this.timer1.Start();
            decimal money = Convert.ToDecimal(txtMoney.Text);
            txtToonie.Text = ((int)(money / 2)).ToString();

            money = money % 2;
            txtLoonie.Text = ((int)(money / 1)).ToString();

            money = money % 1;
            txtQuarter.Text = ((int)(money / 0.25m)).ToString();

            money = money % 0.25m;
            txtDime.Text = ((int)(money / 0.1m)).ToString();

            money = money % 0.1m;
            txtNickel.Text = ((int)(money / 0.05m)).ToString();

            money = money % 0.05m;
            txtPenny.Text = ((int)(money / 0.01m)).ToString();

            txtPenny.Enabled = true;

            SoundPlayer player = new SoundPlayer("../../coins.wav");
            player.Play();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            progress.Value = 0;
            this.timer1.Start();
            decimal money = Convert.ToDecimal(txtMoney.Text);

            money = Math.Round(money / 0.05m) * 0.05m;
            txtToonie.Text = ((int)(money / 2)).ToString();

            money = money % 2;
            txtLoonie.Text = ((int)(money / 1)).ToString();

            money = money % 1;
            txtQuarter.Text = ((int)(money / 0.25m)).ToString();

            money = money % 0.25m;
            txtDime.Text = ((int)(money / 0.1m)).ToString();

            money = money % 0.1m;
            txtNickel.Text = ((int)(money / 0.05m)).ToString();

            txtPenny.Text = 0.ToString();

            txtPenny.Enabled = false;

            SoundPlayer player = new SoundPlayer("../../coins.wav");
            player.Play();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.progress.Increment(10);
        }
    }
}
