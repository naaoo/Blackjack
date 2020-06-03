using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Blackjack.model
{
    class Player
    {
        /// <summary>
        /// score at a certain point in a game
        /// </summary>
        public int score { get; set; }

        public Player()
        {
            this.score = 0;
        }

        public int drawCard()
        {
            Thread.Sleep(1500);
            Card card = new Card();
            this.score = this.score + card.Value;
            return card.Value;
        }
    }

}
