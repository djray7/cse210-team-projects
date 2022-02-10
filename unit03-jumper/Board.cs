using System;
using System.Collections.Generic;

namespace unit03_jumper
{
    class Board
    {
        //---------------------------------------------------------------------
        // Member Variables
        //---------------------------------------------------------------------        
        int _guyLife;
        List<string> _parachute;
        List<string> _dash;

        //---------------------------------------------------------------------
        // Constructors
        //---------------------------------------------------------------------
        public Board()
        {
            _parachute = new List<string>{" --- ", "/   \\ ", " --- ", "\\   /", " \\ / ", "  0  ", " /|\\ ", " / \\ "};            
            _guyLife = 5;
            _dash = new List<string>{};            
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
            int mistakesMade = 5 - _guyLife;
            if (mistakesMade >= 5)
            {
                _parachute[5] = " x ";
            }
            else
            {
                for (int i = 0; i < mistakesMade; i++)
                {
                    _parachute[i] = "";
                }
            }            
        }

        public void createDash(string wordToGuess)
        {
            int count = wordToGuess.Length;
            // with worlf count is equal to 5
            // Console.WriteLine(count);

            for (int i = 0; i < count; i++)
            {
                _dash.Add("_");
            }

            // for (int i = 0; i < count; i++)
            // {
            //     Console.Write($"{_board[i]} ");
            // } 

            //Console.WriteLine();
            //return _board;
            // maybe have this all in other method called createBoard
        }
        public List<string> getDash()
        {
            return _dash;
        }
        public void changeBoard(char guess, string word)
        {
            Console.WriteLine(guess);
            // add letters to board if correct
            foreach (char c in word){
                if (guess == c){
                    int position = word.IndexOf(c);
                }
            }
            
        }
    }
}