using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameCollection
{
    public partial class Form1 : Form
    {
        private AddGameForm addGameForm;
        private Dictionary<string, Game> gameDictionary;
        public Form1()
        {
            InitializeComponent();
            CreateObjects();
            DeserializeDictionary();
            UpdateGameCollectionText();
        }

        private void addGameButton_Click(object sender, EventArgs e)
        {
            addGameForm.Owner = this;
            addGameForm.ShowDialog();
            UpdateGameCollectionText();
            SaveDictionary();
        }
        public void AddGame(Game newGame)
        {
            gameDictionary.Add(newGame.Title, newGame);
        }

        private void CreateObjects()
        {
            addGameForm = new AddGameForm();
            gameDictionary = new Dictionary<string, Game>();
        }

        private void UpdateGameCollectionText()
        {
            gameCollectionTextBox.Clear();
            foreach (Game game in gameDictionary.Values)
            {
                gameCollectionTextBox.Text += $"{game.Title}, {Enum.GetName(typeof(Enums.Genre), game.Genre)}, " +
                    $"{Enum.GetName(typeof(Enums.Rating), game.Rating)}, ${game.Price} {Environment.NewLine}";
            }
        }

        private void SaveDictionary()
        {
            using (StreamWriter sw = new StreamWriter("gameCollection.dat"))
            {
                sw.WriteLine(SerializeDictionary());
            }
        }

        private string SerializeDictionary()
        {
            return JsonConvert.SerializeObject(gameDictionary);
        }

        private void DeserializeDictionary()
        {
            string json = File.ReadAllText("gameCollection.dat");
            gameDictionary = JsonConvert.DeserializeObject<Dictionary<string, Game>>(json);
        }
    }
}
