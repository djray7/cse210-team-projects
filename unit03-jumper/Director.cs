using System;
using System.Collections.Generic;

namespace unit03_jumper
{
    class Director
    {
        //---------------------------------------------------------------------
        // Member Variables
        //---------------------------------------------------------------------
        bool _isPlaying;
        UI _ui;
        List<char> _userGuesses;
        
        //---------------------------------------------------------------------
        // Constructors
        //---------------------------------------------------------------------
        public Director ()
        {
            _isPlaying = true;
            _ui = new UI();
            _userGuesses = new List<char>();
        }

        //---------------------------------------------------------------------
        // Member Functions
        //---------------------------------------------------------------------
        public void startGame()
        {
            Console.WriteLine("Starting game!");

            while (_isPlaying)
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
            Board board = new Board(guessword);            
            // Draws the board            
            _ui.DrawBoard(board, guessword);
            
            // gets user input for guess
            char guess = _ui.UserGuess();
            // adds user input to list of guesses
            _userGuesses.Add(guess);
            // update board
            board.changeDash(guessword, _userGuesses);
            _ui.DrawBoard(board, guessword);
            
            // stopping it here because currently without other parts of the game it will continue to print the board in an endless loop.
            _isPlaying = false;
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
