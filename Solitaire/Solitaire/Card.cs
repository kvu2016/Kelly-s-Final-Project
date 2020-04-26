using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solitaire
{
    class Card
    {
        public Suit suit { get; set; }
        public Value value { get; set; }
        public enum Suit
        {
            clubs,
            spades,
            hearts,
            diamionds
        }
        public enum Value
        {
            TWO = 2, three, four, five, six, seven, eight, nine, ten, jace, queen,
             king, ace
        }
    
    }
}
