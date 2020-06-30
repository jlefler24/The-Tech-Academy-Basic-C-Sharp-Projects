using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class Card
    {
        public Card()
        {
            Suit = "Spades";
            Face = "";
        }
        public string Suit { get; internal set; }
        public string Face { get; internal set; }

    }
}
