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
            _board = new List<string>{};            
        }

        //---------------------------------------------------------------------
        // Member Functions
        //---------------------------------------------------------------------
        public List<string> getJumper()
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
        public void changeJumper()
        {
            // change graphic conditional upon if user input was correct or not
            int mistakesMade = _mistakesAllowed - _guyLife;
            for (int i = 0; i < mistakesMade; i++)
            {
                _parachute[i] = "";
            }
            if (mistakesMade == _mistakesAllowed)
            {
                _parachute[5] = " x ";
            }
        }
        public List<string> printBoard(string wordToGuess)
        {
            int count = wordToGuess.Length;
            // with worlf count is equal to 5
            // Console.WriteLine(count);

            for (int i = 0; i < count; i++)
            {
                _board.Add("_");
            }

            for (int i = 0; i < count; i++)
            {
                Console.Write($"{_board[i]} ");
            } 

            return _board;
            // maybe have this all in other method called createBoard
        }
        public void changeBoard()
        {
            // add letters to board if correct
        }
    }
}