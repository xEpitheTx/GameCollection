using System;

namespace GameCollection
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gameCollectionBrowse = new System.Windows.Forms.DataGridView();
            this.gameTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genre = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.rating = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ratingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.saveButton = new System.Windows.Forms.Button();
            this.addGamesToDictionary = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gameCollectionBrowse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.genreBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ratingBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gameCollectionBrowse
            // 
            this.gameCollectionBrowse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gameCollectionBrowse.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gameTitle,
            this.genre,
            this.rating,
            this.price});
            this.gameCollectionBrowse.Location = new System.Drawing.Point(12, 12);
            this.gameCollectionBrowse.Name = "gameCollectionBrowse";
            this.gameCollectionBrowse.Size = new System.Drawing.Size(744, 449);
            this.gameCollectionBrowse.TabIndex = 2;
            // 
            // gameTitle
            // 
            this.gameTitle.HeaderText = "Title";
            this.gameTitle.Name = "gameTitle";
            // 
            // genre
            // 
            this.genre.ValueType = typeof(Enums.Genre);
            this.genre.DataSource = new GameCollection.Enums.Genre[] {
        GameCollection.Enums.Genre.RPG,
        GameCollection.Enums.Genre.Action,
        GameCollection.Enums.Genre.Adventure,
        GameCollection.Enums.Genre.Puzzle,
        GameCollection.Enums.Genre.Sports,
        GameCollection.Enums.Genre.Horror,
        GameCollection.Enums.Genre.FPS};
            this.genre.HeaderText = "Genre";
            this.genre.Name = "genre";
            this.genre.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.genre.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // rating
            // 
            this.rating.ValueType = typeof(Enums.Rating);
            this.rating.DataSource = new GameCollection.Enums.Rating[] {
        GameCollection.Enums.Rating.Everyone,
        GameCollection.Enums.Rating.E10,
        GameCollection.Enums.Rating.Teen,
        GameCollection.Enums.Rating.Mature};
            this.rating.HeaderText = "Rating";
            this.rating.Name = "rating";
            this.rating.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.rating.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // price
            // 
            this.price.HeaderText = "Price";
            this.price.Name = "price";
            // 
            // genreBindingSource
            // 
            this.genreBindingSource.DataSource = typeof(GameCollection.Enums.Genre);
            // 
            // ratingBindingSource
            // 
            this.ratingBindingSource.DataSource = typeof(GameCollection.Enums.Rating);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(12, 467);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 3;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // addGamesToDictionary
            // 
            this.addGamesToDictionary.Location = new System.Drawing.Point(93, 467);
            this.addGamesToDictionary.Name = "addGamesToDictionary";
            this.addGamesToDictionary.Size = new System.Drawing.Size(185, 23);
            this.addGamesToDictionary.TabIndex = 4;
            this.addGamesToDictionary.Text = "Add Games to Dictionary";
            this.addGamesToDictionary.UseVisualStyleBackColor = true;
            this.addGamesToDictionary.Click += new System.EventHandler(this.addGamesToDictionary_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 784);
            this.Controls.Add(this.addGamesToDictionary);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.gameCollectionBrowse);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.gameCollectionBrowse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.genreBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ratingBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView gameCollectionBrowse;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button addGamesToDictionary;
        private System.Windows.Forms.BindingSource genreBindingSource;
        private System.Windows.Forms.BindingSource ratingBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn gameTitle;
        private System.Windows.Forms.DataGridViewComboBoxColumn genre;
        private System.Windows.Forms.DataGridViewComboBoxColumn rating;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
    }
}

