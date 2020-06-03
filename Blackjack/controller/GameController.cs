using Blackjack.model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blackjack.controller
{
    class GameController
    {
        /// <summary>
        /// human player
        /// </summary>
        Player player = new Player();
        /// <summary>
        /// npc croupier 
        /// </summary>
        Player croupier = new Player();

        public void playGame()
        {
            // step 1: both player and croupier draw a card
            Step1();
            // step 2: player draws a second card and keeps drawing until he wants no more
            PlayerDrawCard();
            while (CheckScorePlayer() && AskCard())
            {
                PlayerDrawCard();
            }
            // step 3: croupier draws second card, if lower than 17 he draws another
            if (player.score < 22)
            {
                CroupierDrawCard();
                if (croupier.score > 21 )
                {
                    Console.WriteLine("You won! Croupier exceeded 21...");
                }
                else if (croupier.score < 17)
                {
                    CroupierDrawCard();
                }
                if (croupier.score > 21)
                {
                    Console.WriteLine("You won! Croupier exceeded 21...");
                }
                CheckWinner();
            }
        }

        public void Step1()
        {
            Console.WriteLine("Player draws a card...");
            Console.WriteLine("Value: " + player.drawCard() + "\nPlayer overall score: " + player.score + "\n");
            Console.WriteLine("Croupier draws a card...");
            Console.WriteLine("Value: " + croupier.drawCard() + "\nCroupier overall score: " + croupier.score + "\n");
           
        }

        public void PlayerDrawCard()
        {
            Console.WriteLine("Player draws another card...");
            Console.WriteLine("Value: " + player.drawCard() + "\nPlayer overall score: " + player.score);
        }

        public void CroupierDrawCard()
        {
            Console.WriteLine("Croupier draws a card ...");
            Console.WriteLine("Value: " + croupier.drawCard() + "\nCroupier overall score: " + croupier.score + "\n");
        }

        public Boolean AskCard()
        {
            Console.WriteLine("Another card? (y/n)");
            string card = "";
            Boolean correctInput = false;
            while (!correctInput)
            {
                card = Console.ReadLine();
                if (card != "y" || card != "n")
                {
                    correctInput = true;
                }
                else
                {
                    Console.WriteLine("Please enter 'y' or 'n");
                }
            }
            if (card == "y")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Boolean CheckScorePlayer()
        {
            if (player.score > 21)
            {
                Console.WriteLine("Your score (" + player.score + ") is higher than 21. Therfore you lost!");
                return false;
            }
            return true;
        }

        public void CheckWinner()
        {
            int diffPlayer = 21 - player.score;
            int diffCroupier = 21 - croupier.score;
            if (diffPlayer < diffCroupier)
            {
                if (diffPlayer == 0)
                {
                    Console.WriteLine("Black Jack! You won!");
                } 
                else
                {
                    Console.WriteLine("You won! (You're closer to 21)");
                }
            }
            else
            {
                if (croupier.score < 22)
                {
                    Console.WriteLine("House has won");
                }
                
            }
        }
    }
}
