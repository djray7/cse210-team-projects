using System;

namespace unit03_jumper
{
    class Director
    {
        //---------------------------------------------------------------------
        // Member Variables
        //---------------------------------------------------------------------
        bool isPlaying;
        UI _ui;
        
        //---------------------------------------------------------------------
        // Constructors
        //---------------------------------------------------------------------
        public Director ()
        {
            isPlaying = true;
            _ui = new UI();
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
            // Creates dictionary and get random word
            Dictionary words = new Dictionary();
            string guessword = words.getRandomWord();
            // Creates board object
            Board first_one = new Board();
            // Draws jumper
            _ui.DrawJumper(first_one.getJumper());
            // Temporarily prints guessword so we know
            Console.WriteLine(guessword);
            // Draws the board
            //first_one.printBoard(guessword);
            _ui.DrawBoard(first_one.printBoard(guessword));
            // gets user input for guess
            char guess = _ui.UserGuess();
            // Bringing in the user guess & board to manipulate TODO
            first_one.changeBoard(guess);
            // stopping it here because currently without other parts of the game it will continue to print the board in an endless loop.
            isPlaying = false;
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
