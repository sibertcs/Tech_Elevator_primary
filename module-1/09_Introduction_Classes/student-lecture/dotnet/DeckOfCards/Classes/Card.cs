using System;
using System.Collections.Generic;
using System.Text;

namespace DeckOfCards.Classes
{
    class Card
    {
        public string Suit { get; }
        
        public int Value { get; } //J is 11...

        public bool isFaceUp { get; private set; }

        public void Flip()
        {
            if (isFaceUp)
                isFaceUp = false;
            else
                isFaceUp = true;
        }

        public Card(int value, string suit)
        {
            Value = value;
            Suit = suit;
            isFaceUp = false; 
        }

        public Card(int value, string suit, bool isFaceUp)
        {
            Value = value;
            Suit = suit;
            IsFaceUp = isFaceUp;
        }

       
    }
}
