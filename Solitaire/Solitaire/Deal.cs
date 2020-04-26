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
        private Card[] computerHand;

        
        public void deal()
        {
            setUpDeck(); //create the deck of cards and shuffle them
            getHand();
         
        }
        public void getHand()
        {
            //5 cards for the player
            for (int i = 0; i < 7; i++)
                playerHand[i] = getcurrentdeck[i];

            //5 cards for the computer
            for (int i = 7; i < 10; i++)
                computerHand[i - 7] = getcurrentdeck[i];
        }
    }
}
