using System;
using System.Collections.Generic;
using System.Text;

namespace LINQ_Wixson_Hunter
{

    // Represents a video game with title, ESRB rating, and genre.
    public class Game
    {
        // Constructor to initialize game properties.
        public Game(string title, char esrb, string genre)
        {
            Title = title;
            Esrb = esrb;
            Genre = genre;
        }

        // Properties for game title, ESRB rating, and genre.
        public string Title { get; set; }
        public char Esrb { get; set; }
        public string Genre { get; set; }
    }

}
