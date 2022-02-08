using System;

namespace unit03_jumper
{
    class Director
    {
        //---------------------------------------------------------------------
        // Member Variables
        //---------------------------------------------------------------------
        
        
        //---------------------------------------------------------------------
        // Constructors
        //---------------------------------------------------------------------
        private bool isPlaying = true;

        //---------------------------------------------------------------------
        // Member Functions
        //---------------------------------------------------------------------
        public void startGame()
        {
            Console.WriteLine("Starting game!");
            Dictionary words = new Dictionary();
            string guessword = words.dictionary();
            while(IsPlaying)
            {
                GetInputs();
                DoUpdates();
                DoOutputs();
            }
        }
        private void GetInputs()
        {

        }

        /// <summary>
        /// Keeps watch on where the seeker is moving.
        /// </summary>
        private void DoUpdates()
        {

        }

        /// <summary>
        /// 
        /// </summary>
        private void DoOutputs()
        {

        }
        


    }
}
