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


        //---------------------------------------------------------------------
        // Constructors
        //---------------------------------------------------------------------


        //---------------------------------------------------------------------
        // Member Functions
        //---------------------------------------------------------------------
        public string printGraphic()
        {
            _parachute = [" --- ", "/   \ ", " --- ", "\   /", " \ / ", "  0  ", " /|\ ", " / \ ", "     ", ",,,,,,,"]

            // print jumper guy graphic
            Console.WriteLine(" --- ");
            Console.WriteLine("/   \ ");
            Console.WriteLine(" --- ");
            Console.WriteLine("\   /");
            Console.WriteLine(" \ / ");
            Console.WriteLine("  0  ");
            Console.WriteLine(" /|\ ");
            Console.WriteLine(" / \ ");

        }
        public void changeGraphic()
        {
            // change graphic conditional upon if user input was correct or not
        }
        public string printBoard()
        {
            // print _ _ _ _ _ this stuff according to length of word being used
        }
        public void changeBoard()
        {
            // add letters to board if correct
        }
    }
}
