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
        public void AddGame()
        {
            foreach (DataGridViewRow gameCollection in gameCollectionBrowse.Rows)
            {
                if (gameCollection.Cells[0].Value != null)
                {
                    if (!gameDictionary.ContainsKey(gameCollection.Cells[1].ToString()))
                    {
                        gameDictionary.Add(gameCollection.Cells[0].ToString(), new Game(gameCollection.Cells[0].Value.ToString(),
                            (Enums.Genre)gameCollection.Cells[1].Value, (Enums.Rating)gameCollection.Cells[2].Value,
                            Convert.ToInt32(gameCollection.Cells[3].Value)));
                    }
                }

            }
        }

        private void CreateObjects()
        {
            addGameForm = new AddGameForm();
            gameDictionary = new Dictionary<string, Game>();
        }

        private void UpdateGameCollectionText()
        {
            int gameCount = 0;
            foreach (Game game in gameDictionary.Values)
            {
                gameCollectionBrowse.Rows.Add();
                gameCollectionBrowse[0, gameCount].Value = game.Title;
                gameCollectionBrowse[1, gameCount].Value = game.Genre;
                gameCollectionBrowse[2, gameCount].Value = game.Rating;
                gameCollectionBrowse[3, gameCount].Value = game.Price;
                gameCount++;
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

        private void saveButton_Click(object sender, EventArgs e)
        {
            SaveDictionary();
        }

        private void addGamesToDictionary_Click(object sender, EventArgs e)
        {
            AddGame();
        }
    }
}
