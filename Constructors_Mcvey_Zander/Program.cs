using System;

namespace Constructors_Mcvey_Zander
{
    class Program
    {
        static void Main(string[] args)
        {
            //This states myGame saves the orange text under that name.
            game myGame = new game("Legend of Zelda: WindWaker", "Adventure");
            
            //This line prints out what their favorite game is with myGame.title and myGame.genre.
            Console.WriteLine($"My favorite game is {myGame.title} and it is a {myGame.genre} game!");

            //This makes another variable to list their other favorite game
            game myOtherGame = new game();

            //This line prints out what their other favorite game is with myOtherGame.title and myOtherGame.genre.
            Console.WriteLine($"My other favorite game is {myOtherGame.title} and it is a {myOtherGame.genre} game!");
        }
    }
}
