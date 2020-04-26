using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solitaire
{
    class Deck:Card
    {
        const int numberofcards = 52;//because there are 52 cards in a deck
        private Card[] deck;//array of cards


        public Deck()
        {
            deck = new Card[numberofcards];
        }

        public Card[] getcurrentdeck { get { return deck; } }
        //gets the current deck of cards

        public void setUpDeck()
        {
            int i = 0;
            foreach (Suit s in Enum.GetValues(typeof(Suit)))
            {
                foreach (Value v in Enum.GetValues(typeof(Value)))
                {
                    deck[i] = new Card { suit = s, value = v };
                    i++;
                }
            }

            ShuffleCards();//using shuffle method
        }

        //shuffle the deck
        public void ShuffleCards()
        {
            Random rand = new Random();
            Card temporary;//temporary card given

           
            for (int shuffleamount = 0; shuffleamount < 2000; shuffleamount++)//shuffle 2000 times
            {
                for (int i = 0; i < numberofcards; i++)
                {
                    //give out random cards
                    int card2 = rand.Next(13);
                    temporary = deck[i];
                    deck[i] = deck[card2];
                    deck[card2] = temporary;
                }
            }
        }
    }
}

