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
        public void DrawBoard(List<string> line)
        {
            Console.WriteLine(line);
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
