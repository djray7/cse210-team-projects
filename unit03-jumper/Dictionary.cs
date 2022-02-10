using System;
using System.Collections.Generic;

namespace unit03_jumper
{
    class Dictionary
    {
        //---------------------------------------------------------------------
        // Member Variables
        //---------------------------------------------------------------------
        


        //---------------------------------------------------------------------
        // Constructors
        //---------------------------------------------------------------------


        //---------------------------------------------------------------------
        // Member Functions
        //---------------------------------------------------------------------
        public string getRandomWord()
        {

            string[] words = {"big", "bald", "worlf", "supercalifragilisticexpialidocious"};
            List<string> _wordList = new List<string>();
            _wordList.AddRange(words);
            // Console.WriteLine(words[3]);
            string word = words[2];
            // return word;

            Random randomGen = new Random();
            string returnword = _wordList[randomGen.Next(0, _wordList.Count - 1)];
            return returnword;
        }
    }
}
