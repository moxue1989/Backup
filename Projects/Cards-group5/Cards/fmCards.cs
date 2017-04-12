using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cards
{
    public partial class fmCards : Form
    {
        Deck deck1 = new Deck();
        public enum Suits
        {
            Spades,
            Hearts,
            Clubs,
            Diamonds
        }

        public enum Ranks
        {
            Ace = 1, Two, Three, Four, Five,
            Six, Seven, Eight, Nine, Ten, Jack, Queen, King
        }

        public fmCards()
        {
            InitializeComponent();
        }

        private void fmCards_Load(object sender, EventArgs e)
        {
            
        }

        private void btnShowCards_Click(object sender, EventArgs e)
        {
            deck1 = new Deck();
            DisplayCards();
        }

        private void DisplayCards()
        {
            List<string> display = deck1.showCards();
            lbDeck.Items.Clear();
            foreach (string card in display)
            {
                lbDeck.Items.Add(card);
            }
        }

        private void btnShuffle_Click(object sender, EventArgs e)
        {
            deck1.shuffle();
            DisplayCards();
        }
    }
}
