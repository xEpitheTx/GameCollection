using System.Collections.Generic;

namespace GameCollection
{
    class GameDictionary : Dictionary<string, Game>
    {
        private Dictionary<string, Game> gameDictionary;

        public GameDictionary()
        {
            gameDictionary = new Dictionary<string, Game>();
        }
    }
}
