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
        public string dictionary()
        {

            string[] words = {"big", "bad", "worlf", "supercalifragilisticexpialidocious"};
            List<string> _wordList = new List<string>();
            _wordList.AddRange(words);
            Console.WriteLine(words[3]);
            string word = words[2];
            return word;
            // string[] animals = { "Cow", "Camel", "Elephant" };
            // // Create a List and add a collection
            // List<string> animalsList = new List<string>();
            // animalsList.AddRange(animals);
            // foreach (string a in animalsList)
            // Console.WriteLine(a);
        }
    }
}
