using Blackjack.controller;
using Blackjack.model;
using System;

namespace Blackjack
{
    class Program
    {
        static void Main(string[] args)
        {
            // Pulltest
            GameController gameController = new GameController();
            gameController.playGame();
        }
    }
}
