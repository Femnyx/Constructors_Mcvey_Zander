using System;
using System.Collections.Generic;
using System.Text;

namespace Constructors_Mcvey_Zander
{
    class game
    {
        //This list out the public string of what the title of the game is and what genre it is.
        public string title, genre;

        //Lists out theOtherGame's title and genre and saves them as strings.
        public game(string titleParam = "Unknown Title", string genreParam = "Casual")
        {

            //Connects titleParam to the word "title" and genreParam to the world "genre".
            title = titleParam;
            genre = genreParam;

        }

        
    }
}
