using System;

namespace unit03_jumper
{
    class Program
    {
        Director _director;
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Director game = new Director();

            game.startGame();
            
        }
    }
}
