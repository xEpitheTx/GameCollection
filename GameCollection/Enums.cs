using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCollection
{
    public class Enums
    {
        public enum Genre
        {
            RPG,
            Action,
            Adventure,
            Puzzle,
            Sports,
            Horror,
            FPS,
        }

        public enum Rating
        {
            Everyone,
            E10,
            Teen,
            Mature,
        }

        public static void GetGenres()
        {
            foreach (Enum genre in Enum.GetValues(typeof(Enums.Genre)))
            {
                
            }
        }
    }
}
