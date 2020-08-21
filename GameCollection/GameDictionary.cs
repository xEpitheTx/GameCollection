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

        public void AddGame(Game gameToAdd)
        {
            gameDictionary.Add(gameToAdd.Title, gameToAdd);
        }
    }
}
