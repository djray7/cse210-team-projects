using System;

namespace unit03_jumper
{
    class Director
    {
        //---------------------------------------------------------------------
        // Member Variables
        //---------------------------------------------------------------------
        
        
        //---------------------------------------------------------------------
        // Constructors
        //---------------------------------------------------------------------


        //---------------------------------------------------------------------
        // Member Functions
        //---------------------------------------------------------------------
        public void startGame()
        {
            Console.WriteLine("Starting game!");
            Dictionary words = new Dictionary();
            string guessword = words.getRandomWord();
            Board first_one = new Board();
            first_one.printBoard(guessword);
        }
    }
}
