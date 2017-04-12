using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Cards.fmCards;

namespace Cards
{
    
    public class Deck
    {
        static Random gen = new Random();
        private List<Card> cards = new List<Card>();
        public Deck()
        {
            foreach (int suit in Enum.GetValues(typeof(Suits)))
            {
                foreach (int rank in Enum.GetValues(typeof(Ranks)))
                {
                    Card card = new Card(rank, suit);
                    cards.Add(card);
                }
            }
        }

        public List<string> showCards()
        {
            List<string> display = new List<string>();
            foreach(Card card in cards)
            {
                display.Add(card.ToString());
            }
            return display;
        }

        public void shuffle()
        {
            for(int n = cards.Count - 1; n > 0; --n)
            {
                int k = gen.Next(n + 1);
                Card temp = cards[n];
                cards[n] = cards[k];
                cards[k] = temp;
            }
        }
    }
}
