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
            this.gameCollectionTextBox = new System.Windows.Forms.TextBox();
            this.addGameButton = new System.Windows.Forms.Button();
            this.gameCollectionBrowse = new System.Windows.Forms.DataGridView();
            this.gameTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rating = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gameCollectionBrowse)).BeginInit();
            this.SuspendLayout();
            // 
            // gameCollectionTextBox
            // 
            this.gameCollectionTextBox.Location = new System.Drawing.Point(109, 65);
            this.gameCollectionTextBox.Multiline = true;
            this.gameCollectionTextBox.Name = "gameCollectionTextBox";
            this.gameCollectionTextBox.Size = new System.Drawing.Size(255, 328);
            this.gameCollectionTextBox.TabIndex = 0;
            // 
            // addGameButton
            // 
            this.addGameButton.Location = new System.Drawing.Point(13, 13);
            this.addGameButton.Name = "addGameButton";
            this.addGameButton.Size = new System.Drawing.Size(75, 23);
            this.addGameButton.TabIndex = 1;
            this.addGameButton.Text = "Add Game";
            this.addGameButton.UseVisualStyleBackColor = true;
            this.addGameButton.Click += new System.EventHandler(this.addGameButton_Click);
            // 
            // gameCollectionBrowse
            // 
            this.gameCollectionBrowse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gameCollectionBrowse.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gameTitle,
            this.genre,
            this.rating,
            this.price});
            this.gameCollectionBrowse.Location = new System.Drawing.Point(13, 432);
            this.gameCollectionBrowse.Name = "gameCollectionBrowse";
            this.gameCollectionBrowse.Size = new System.Drawing.Size(445, 264);
            this.gameCollectionBrowse.TabIndex = 2;
            // 
            // gameTitle
            // 
            this.gameTitle.HeaderText = "Title";
            this.gameTitle.Name = "gameTitle";
            // 
            // genre
            // 
            this.genre.HeaderText = "Genre";
            this.genre.Name = "genre";
            // 
            // rating
            // 
            this.rating.HeaderText = "Rating";
            this.rating.Name = "rating";
            // 
            // price
            // 
            this.price.HeaderText = "Price";
            this.price.Name = "price";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 784);
            this.Controls.Add(this.gameCollectionBrowse);
            this.Controls.Add(this.addGameButton);
            this.Controls.Add(this.gameCollectionTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.gameCollectionBrowse)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox gameCollectionTextBox;
        private System.Windows.Forms.Button addGameButton;
        private System.Windows.Forms.DataGridView gameCollectionBrowse;
        private System.Windows.Forms.DataGridViewTextBoxColumn gameTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn genre;
        private System.Windows.Forms.DataGridViewTextBoxColumn rating;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
    }
}

