using System;

namespace unit03_jumper
{
    class Director
    {
        //---------------------------------------------------------------------
        // Member Variables
        //---------------------------------------------------------------------
        bool isPlaying;
        
        //---------------------------------------------------------------------
        // Constructors
        //---------------------------------------------------------------------
        public Director ()
        {
            isPlaying = true;
        }
        

        //---------------------------------------------------------------------
        // Member Functions
        //---------------------------------------------------------------------
        public void startGame()
        {
            Console.WriteLine("Starting game!");

            while (isPlaying)
            {
                GetInputs();
                DoUpdates();
                DoOutputs();    
            }
        }
        public void GetInputs()
        {
            Dictionary words = new Dictionary();
            string guessword = words.getRandomWord();
            Board first_one = new Board();
            Console.WriteLine(guessword);
            first_one.printBoard(guessword);
            isPlaying = false; // stopping it here because currently without other parts of the game it will continue to print the board in an endless loop.
        }
        public void DoUpdates()
        {
            //stuff
        }
        public void DoOutputs()
        {
            //really cool stuff
        }
        

    }
}
