using System;
using System.Collections.Generic;

namespace unit03_jumper
{
    class Board
    {
        //---------------------------------------------------------------------
        // Member Variables
        //---------------------------------------------------------------------
        int _mistakesAllowed;
        int _guyLife;
        List<string> _parachute;
        List<string> _board;

        //---------------------------------------------------------------------
        // Constructors
        //---------------------------------------------------------------------
        public Board()
        {
            _parachute = new List<string>{" --- ", "/   \\ ", " --- ", "\\   /", " \\ / ", "  0  ", " /|\\ ", " / \\ ", "     ", ",,,,,,,"};
            _mistakesAllowed = 5;
            _guyLife = 5;            
        }

        //---------------------------------------------------------------------
        // Member Functions
        //---------------------------------------------------------------------
        public List<string> printGraphic()
        {            
            // print jumper guy graphic
            // Console.WriteLine(" --- ");
            // Console.WriteLine("/   \ ");
            // Console.WriteLine(" --- ");
            // Console.WriteLine("\   /");
            // Console.WriteLine(" \ / ");
            // Console.WriteLine("  0  ");
            // Console.WriteLine(" /|\ ");
            // Console.WriteLine(" / \ ");
            return _parachute;
        }
        public void changeGraphic()
        {
            // change graphic conditional upon if user input was correct or not
            int mistakesMade = _mistakesAllowed - _guyLife;
            for (int i = 0; i < mistakesMade; i++)
            {
                _parachute[i] = ""
            }
        }
        public string printBoard(string wordToGuess)
        {
            int count = wordToGuess.Length;
            
            string banana = "banana";
            return banana;
            // print _ _ _ _ _ this stuff according to length of word being used
            // get word
            // length word to know how many _ for the board
        }
        public void changeBoard()
        {
            // add letters to board if correct
        }
    }
}
// this is a conflict- Kavyn
// this is a conflict - Marcel