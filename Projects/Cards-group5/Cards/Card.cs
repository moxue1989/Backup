using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Cards.fmCards;

namespace Cards
{
    public class Card
    {        
        public int Rank { get; set; }
        public int Suit { get; set; }

        public Card(int rank, int suit)
        {
            Rank = rank;
            Suit = suit;
        }
                
        public override string ToString()
        {
            return Enum.GetName(typeof(Ranks), Rank) + " of " + Enum.GetName(typeof(Suits), Suit);
        }


    }
}
