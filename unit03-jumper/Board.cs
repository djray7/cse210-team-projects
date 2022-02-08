using System;
using System.Collections.Generic;

namespace unit03_jumper
{
    class Board
    {
        //---------------------------------------------------------------------
        // Member Variables
        //---------------------------------------------------------------------
        string _guy;
        List<string> _parachute;

        List<string> _board;


        //---------------------------------------------------------------------
        // Constructors
        //---------------------------------------------------------------------


        //---------------------------------------------------------------------
        // Member Functions
        //---------------------------------------------------------------------
        public string printGraphic()
        {
            _parachute = [" --- ", "/   \", " --- ", "\   /", " \ / ", "  0  ", " /|\ ", " / \ ", "     ", ",,,,,,,"];

            string pizza = "word";
            // print jumper guy graphic
            // Console.WriteLine(" --- ");
            // Console.WriteLine("/   \ ");
            // Console.WriteLine(" --- ");
            // Console.WriteLine("\   /");
            // Console.WriteLine(" \ / ");
            // Console.WriteLine("  0  ");
            // Console.WriteLine(" /|\ ");
            // Console.WriteLine(" / \ ");

            return pizza;
        }
        public void changeGraphic()
        {
            // change graphic conditional upon if user input was correct or not
        }
        public string printBoard()
        {
            // print _ _ _ _ _ this stuff according to length of word being used
            // get word
            // length word to know how many _ for the board
            return "";
        }
        public void changeBoard()
        {
            // add letters to board if correct
        }

    }
}