using System;

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
        public string UserGuess()
        {
            Console.WriteLine("Guess a letter [a-z]: ");
            return Console.ReadLine();
        }
        /// draws our guess board 
        public void DrawBoard(list<string> line)
        {
            Console.WriteLine(line);
        }


        ///draws our jumper dude
        public void DrawJumper(List<string> jumper)
        {
            Console.WriteLine(jumper);
        }




    }
}
