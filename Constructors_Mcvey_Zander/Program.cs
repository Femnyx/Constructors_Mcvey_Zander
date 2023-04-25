using System;

namespace Constructors_Mcvey_Zander
{
    class Program
    {
        static void Main(string[] args)
        {
            //
            game myGame = new game("Legend of Zelda: WindWaker", "Adventure");
            
            //
            Console.WriteLine($"My favorite game is {myGame.title} and it is a {myGame.genre} game!");

            //
            game myOtherGame = new game();

            //
            Console.WriteLine($"My other favorite game is {myOtherGame.title} and it is a {myOtherGame.genre} game!");
        }
    }
}
