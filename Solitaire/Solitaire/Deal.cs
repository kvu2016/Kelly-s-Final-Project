using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solitaire
{
    private Card[] playerHand;
    private Card[] computerHand;
    class Deal: Deck
    {
        public DealCards()
        {
            playerHand = new Card[5];
            sortedPlayerHand = new Card[5];
            computerHand = new Card[5];
            sortedComputerHand = new Card[5];
        }
    }
}
