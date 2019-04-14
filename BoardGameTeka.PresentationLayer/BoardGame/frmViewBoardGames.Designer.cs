namespace BoardGameTeka.PresentationLayer.BoardGame
{
    partial class frmViewBoardGames
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
            this.buttonDeleteBoardGame = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.dataGridViewBoardGames = new System.Windows.Forms.DataGridView();
            this.boardGameIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.playingTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.playersDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ratingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.complexityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.releaseYearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.availableCopiesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.boardGameViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonAddBoardGame = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBoardGames)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boardGameViewBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonDeleteBoardGame
            // 
            this.buttonDeleteBoardGame.Location = new System.Drawing.Point(622, 229);
            this.buttonDeleteBoardGame.Name = "buttonDeleteBoardGame";
            this.buttonDeleteBoardGame.Size = new System.Drawing.Size(110, 23);
            this.buttonDeleteBoardGame.TabIndex = 2;
            this.buttonDeleteBoardGame.Text = "Delete board game";
            this.buttonDeleteBoardGame.UseVisualStyleBackColor = true;
            this.buttonDeleteBoardGame.Click += new System.EventHandler(this.buttonDeleteBoardGame_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(766, 229);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(86, 23);
            this.buttonClose.TabIndex = 3;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // dataGridViewBoardGames
            // 
            this.dataGridViewBoardGames.AutoGenerateColumns = false;
            this.dataGridViewBoardGames.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBoardGames.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.boardGameIdDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.playingTimeDataGridViewTextBoxColumn,
            this.playersDataGridViewTextBoxColumn,
            this.ratingDataGridViewTextBoxColumn,
            this.complexityDataGridViewTextBoxColumn,
            this.releaseYearDataGridViewTextBoxColumn,
            this.availableCopiesDataGridViewTextBoxColumn});
            this.dataGridViewBoardGames.DataSource = this.boardGameViewBindingSource;
            this.dataGridViewBoardGames.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewBoardGames.Name = "dataGridViewBoardGames";
            this.dataGridViewBoardGames.Size = new System.Drawing.Size(840, 211);
            this.dataGridViewBoardGames.TabIndex = 4;
            // 
            // boardGameIdDataGridViewTextBoxColumn
            // 
            this.boardGameIdDataGridViewTextBoxColumn.DataPropertyName = "BoardGameId";
            this.boardGameIdDataGridViewTextBoxColumn.HeaderText = "BoardGameId";
            this.boardGameIdDataGridViewTextBoxColumn.Name = "boardGameIdDataGridViewTextBoxColumn";
            this.boardGameIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Type";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            // 
            // playingTimeDataGridViewTextBoxColumn
            // 
            this.playingTimeDataGridViewTextBoxColumn.DataPropertyName = "PlayingTime";
            this.playingTimeDataGridViewTextBoxColumn.HeaderText = "Playing time";
            this.playingTimeDataGridViewTextBoxColumn.Name = "playingTimeDataGridViewTextBoxColumn";
            // 
            // playersDataGridViewTextBoxColumn
            // 
            this.playersDataGridViewTextBoxColumn.DataPropertyName = "Players";
            this.playersDataGridViewTextBoxColumn.HeaderText = "Players";
            this.playersDataGridViewTextBoxColumn.Name = "playersDataGridViewTextBoxColumn";
            // 
            // ratingDataGridViewTextBoxColumn
            // 
            this.ratingDataGridViewTextBoxColumn.DataPropertyName = "Rating";
            this.ratingDataGridViewTextBoxColumn.HeaderText = "Rating";
            this.ratingDataGridViewTextBoxColumn.Name = "ratingDataGridViewTextBoxColumn";
            // 
            // complexityDataGridViewTextBoxColumn
            // 
            this.complexityDataGridViewTextBoxColumn.DataPropertyName = "Complexity";
            this.complexityDataGridViewTextBoxColumn.HeaderText = "Complexity";
            this.complexityDataGridViewTextBoxColumn.Name = "complexityDataGridViewTextBoxColumn";
            // 
            // releaseYearDataGridViewTextBoxColumn
            // 
            this.releaseYearDataGridViewTextBoxColumn.DataPropertyName = "ReleaseYear";
            this.releaseYearDataGridViewTextBoxColumn.HeaderText = "Release year";
            this.releaseYearDataGridViewTextBoxColumn.Name = "releaseYearDataGridViewTextBoxColumn";
            // 
            // availableCopiesDataGridViewTextBoxColumn
            // 
            this.availableCopiesDataGridViewTextBoxColumn.DataPropertyName = "AvailableCopies";
            this.availableCopiesDataGridViewTextBoxColumn.HeaderText = "Available copies";
            this.availableCopiesDataGridViewTextBoxColumn.Name = "availableCopiesDataGridViewTextBoxColumn";
            // 
            // boardGameViewBindingSource
            // 
            this.boardGameViewBindingSource.DataSource = typeof(BoardGameTeka.PresentationLayer.BoardGame.BoardGameView);
            // 
            // buttonAddBoardGame
            // 
            this.buttonAddBoardGame.Location = new System.Drawing.Point(474, 229);
            this.buttonAddBoardGame.Name = "buttonAddBoardGame";
            this.buttonAddBoardGame.Size = new System.Drawing.Size(110, 23);
            this.buttonAddBoardGame.TabIndex = 5;
            this.buttonAddBoardGame.Text = "Add board game";
            this.buttonAddBoardGame.UseVisualStyleBackColor = true;
            this.buttonAddBoardGame.Click += new System.EventHandler(this.buttonAddBoardGame_Click);
            // 
            // frmViewBoardGames
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 264);
            this.Controls.Add(this.buttonAddBoardGame);
            this.Controls.Add(this.dataGridViewBoardGames);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonDeleteBoardGame);
            this.Name = "frmViewBoardGames";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmViewBoardGames";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBoardGames)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boardGameViewBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonDeleteBoardGame;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.DataGridView dataGridViewBoardGames;
        private System.Windows.Forms.DataGridViewTextBoxColumn boardGameIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn playingTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn playersDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ratingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn complexityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn releaseYearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn availableCopiesDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource boardGameViewBindingSource;
        private System.Windows.Forms.Button buttonAddBoardGame;
    }
}