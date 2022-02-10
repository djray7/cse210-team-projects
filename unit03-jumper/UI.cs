using System;
using System.Collections.Generic;

namespace unit03_jumper
{
    /// <summary>
        /// get imput and prints all outputs
        /// </summary>
    class UI
    {

        //---------------------------------------------------------------------
        // Constructors
        //---------------------------------------------------------------------
        public UI()
        {

        }

        //---------------------------------------------------------------------
        // Member Functions
        //---------------------------------------------------------------------
        
        /// get input from the user 
        public char UserGuess()
        {
            Console.WriteLine("Guess a letter [a-z]: ");
            string guessedNumber = Console.ReadLine();
            return char.Parse(guessedNumber);
            
        }
        /// prints all the words we want 
        public void PrintWords(string words)
        {
            Console.WriteLine(words);

        }
        /// draws our guess board 
        public void DrawBoard(Board board, string guessword)
        {
            List<string> jumper = board.getJumper();
            List<string> dash = board.getDash();
            
            Console.WriteLine(",,,,,,,");
            Console.WriteLine("     ");
            DrawJumper(jumper);            
            Console.WriteLine("     ");
            Console.WriteLine(",,,,,,,");
            // Temporarily prints guessword so we know
            Console.WriteLine(guessword);
            foreach (string s in dash)
            {
                Console.Write($" {s} ");
            }
            Console.WriteLine();
        }


        ///draws our jumper dude
        public void DrawJumper(List<string> jumper)
        {
            foreach (string s in jumper)
            {
                Console.WriteLine(s);
            }            
        }

    }
}
