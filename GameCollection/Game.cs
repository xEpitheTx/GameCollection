using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCollection
{
    public class Game : Console
    {
        public Game(string title, Enums.Genre genre, Enums.Rating rating, float price)
        {
            Title = title;
            Genre = genre;
            Rating = rating;
            Price = price;
        }

        public string Title { get; private set; }

        public Enums.Genre Genre { get; private set; }

        public Enums.Rating Rating { get; private set; }

        public float Price { get; private set; }
    }
}
