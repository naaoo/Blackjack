using System;
using System.Collections.Generic;
using System.Text;

namespace Blackjack.model
{
    class Card
    {
        /// <summary>
        /// value of a card
        /// </summary>
        public int Value { get; set; }

        public Card()
        {
            Random random = new Random();
            this.Value = random.Next(1, 12);
        }
    }
}
