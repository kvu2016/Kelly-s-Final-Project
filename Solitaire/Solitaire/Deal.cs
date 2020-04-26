using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solitaire
{
   
    class Deal:Deck
    {
        private Card[] playerHand;

        public void deal()
        {
            setUpDeck(); //create the deck of cards and shuffle them
            getHand();
        }
        public void getHand()
        {
            //7 cards dealed to player
            for (int i = 0; i < 7; i++)
                playerHand[i] = getcurrentdeck[i];
        }
    }
}
