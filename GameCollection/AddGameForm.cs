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
    public partial class AddGameForm : Form
    {
        public Game newGame;


        public AddGameForm()
        {
            InitializeComponent();
            UpdateForm();
        }

        private void addGameToDictionaryButton_Click(object sender, EventArgs e)
        {
            
            Form1 form1 = Owner as Form1;
            //form1.AddGame(AddGame());
            MessageBox.Show("Game saved");
            ClearForm();
        }

        private void UpdateForm()
        {
            foreach (Enum genre in Enum.GetValues(typeof(Enums.Genre)))
            {
                genreComboBox.Items.Add(genre);
            }

            foreach (Enum rating in Enum.GetValues(typeof(Enums.Rating)))
            {
                ratingComboBox.Items.Add(rating);
            }
        }

        public Game AddGame()
        {
            return new Game(titleText.Text, (Enums.Genre)genreComboBox.SelectedItem,
                (Enums.Rating)ratingComboBox.SelectedItem, (float)gamePrice.Value);
        }

        public void ClearForm()
        {
            titleText.Clear();
            genreComboBox.SelectedItem = null;
            ratingComboBox.SelectedItem = null;
            gamePrice.Value = 0;
        }
    }
}
