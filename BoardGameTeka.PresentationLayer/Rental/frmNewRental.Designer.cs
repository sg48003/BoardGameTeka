namespace BoardGameTeka.PresentationLayer.Rental
{
    partial class frmNewRental
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
            this.comboBoxMember = new System.Windows.Forms.ComboBox();
            this.memberBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelMember = new System.Windows.Forms.Label();
            this.labelBoardGames = new System.Windows.Forms.Label();
            this.buttonRemoveBoardGame = new System.Windows.Forms.Button();
            this.buttonAddBoardGame = new System.Windows.Forms.Button();
            this.buttonAddRental = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.boardGameBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBoxBoardGames = new System.Windows.Forms.ComboBox();
            this.labelBoardGame = new System.Windows.Forms.Label();
            this.dataGridViewBoardGames = new System.Windows.Forms.DataGridView();
            this.boardGameIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.boardGamesGridBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boardGameBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBoardGames)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boardGamesGridBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxMember
            // 
            this.comboBoxMember.DataSource = this.memberBindingSource;
            this.comboBoxMember.DisplayMember = "Name";
            this.comboBoxMember.FormattingEnabled = true;
            this.comboBoxMember.Location = new System.Drawing.Point(111, 21);
            this.comboBoxMember.Name = "comboBoxMember";
            this.comboBoxMember.Size = new System.Drawing.Size(224, 21);
            this.comboBoxMember.TabIndex = 43;
            this.comboBoxMember.ValueMember = "MemberId";
            // 
            // memberBindingSource
            // 
            this.memberBindingSource.DataSource = typeof(BoardGameTeka.Model.Entities.Member);
            // 
            // labelMember
            // 
            this.labelMember.AutoSize = true;
            this.labelMember.Location = new System.Drawing.Point(35, 24);
            this.labelMember.Name = "labelMember";
            this.labelMember.Size = new System.Drawing.Size(51, 13);
            this.labelMember.TabIndex = 42;
            this.labelMember.Text = "Member :";
            // 
            // labelBoardGames
            // 
            this.labelBoardGames.AutoSize = true;
            this.labelBoardGames.Location = new System.Drawing.Point(35, 95);
            this.labelBoardGames.Name = "labelBoardGames";
            this.labelBoardGames.Size = new System.Drawing.Size(105, 13);
            this.labelBoardGames.TabIndex = 44;
            this.labelBoardGames.Text = "List of board games :";
            // 
            // buttonRemoveBoardGame
            // 
            this.buttonRemoveBoardGame.Location = new System.Drawing.Point(225, 238);
            this.buttonRemoveBoardGame.Name = "buttonRemoveBoardGame";
            this.buttonRemoveBoardGame.Size = new System.Drawing.Size(110, 23);
            this.buttonRemoveBoardGame.TabIndex = 47;
            this.buttonRemoveBoardGame.Text = "Remove board game";
            this.buttonRemoveBoardGame.UseVisualStyleBackColor = true;
            this.buttonRemoveBoardGame.Click += new System.EventHandler(this.buttonRemoveBoardGame_Click);
            // 
            // buttonAddBoardGame
            // 
            this.buttonAddBoardGame.Location = new System.Drawing.Point(344, 61);
            this.buttonAddBoardGame.Name = "buttonAddBoardGame";
            this.buttonAddBoardGame.Size = new System.Drawing.Size(108, 23);
            this.buttonAddBoardGame.TabIndex = 46;
            this.buttonAddBoardGame.Text = "Add board game";
            this.buttonAddBoardGame.UseVisualStyleBackColor = true;
            this.buttonAddBoardGame.Click += new System.EventHandler(this.buttonAddBoardGame_Click);
            // 
            // buttonAddRental
            // 
            this.buttonAddRental.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonAddRental.Location = new System.Drawing.Point(344, 137);
            this.buttonAddRental.Name = "buttonAddRental";
            this.buttonAddRental.Size = new System.Drawing.Size(108, 23);
            this.buttonAddRental.TabIndex = 48;
            this.buttonAddRental.Text = "Add rental";
            this.buttonAddRental.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(344, 166);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(108, 23);
            this.buttonCancel.TabIndex = 49;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // boardGameBindingSource
            // 
            this.boardGameBindingSource.DataSource = typeof(BoardGameTeka.Model.Entities.BoardGame);
            // 
            // comboBoxBoardGames
            // 
            this.comboBoxBoardGames.DataSource = this.boardGameBindingSource;
            this.comboBoxBoardGames.DisplayMember = "Name";
            this.comboBoxBoardGames.FormattingEnabled = true;
            this.comboBoxBoardGames.Location = new System.Drawing.Point(111, 63);
            this.comboBoxBoardGames.Name = "comboBoxBoardGames";
            this.comboBoxBoardGames.Size = new System.Drawing.Size(224, 21);
            this.comboBoxBoardGames.TabIndex = 51;
            this.comboBoxBoardGames.ValueMember = "MemberId";
            // 
            // labelBoardGame
            // 
            this.labelBoardGame.AutoSize = true;
            this.labelBoardGame.Location = new System.Drawing.Point(35, 66);
            this.labelBoardGame.Name = "labelBoardGame";
            this.labelBoardGame.Size = new System.Drawing.Size(70, 13);
            this.labelBoardGame.TabIndex = 50;
            this.labelBoardGame.Text = "Board game :";
            // 
            // dataGridViewBoardGames
            // 
            this.dataGridViewBoardGames.AllowUserToAddRows = false;
            this.dataGridViewBoardGames.AllowUserToDeleteRows = false;
            this.dataGridViewBoardGames.AutoGenerateColumns = false;
            this.dataGridViewBoardGames.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewBoardGames.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBoardGames.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.boardGameIdDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn});
            this.dataGridViewBoardGames.DataSource = this.boardGamesGridBindingSource;
            this.dataGridViewBoardGames.Location = new System.Drawing.Point(38, 111);
            this.dataGridViewBoardGames.Name = "dataGridViewBoardGames";
            this.dataGridViewBoardGames.ReadOnly = true;
            this.dataGridViewBoardGames.Size = new System.Drawing.Size(297, 121);
            this.dataGridViewBoardGames.TabIndex = 52;
            // 
            // boardGameIdDataGridViewTextBoxColumn
            // 
            this.boardGameIdDataGridViewTextBoxColumn.DataPropertyName = "BoardGameId";
            this.boardGameIdDataGridViewTextBoxColumn.HeaderText = "BoardGameId";
            this.boardGameIdDataGridViewTextBoxColumn.Name = "boardGameIdDataGridViewTextBoxColumn";
            this.boardGameIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.boardGameIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // boardGamesGridBindingSource
            // 
            this.boardGamesGridBindingSource.DataSource = typeof(BoardGameTeka.Model.Entities.BoardGame);
            // 
            // frmNewRental
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 280);
            this.Controls.Add(this.dataGridViewBoardGames);
            this.Controls.Add(this.comboBoxBoardGames);
            this.Controls.Add(this.labelBoardGame);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonAddRental);
            this.Controls.Add(this.buttonRemoveBoardGame);
            this.Controls.Add(this.buttonAddBoardGame);
            this.Controls.Add(this.labelBoardGames);
            this.Controls.Add(this.comboBoxMember);
            this.Controls.Add(this.labelMember);
            this.Name = "frmNewRental";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmNewRental";
            this.Load += new System.EventHandler(this.frmNewRental_Load);
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boardGameBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBoardGames)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boardGamesGridBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxMember;
        private System.Windows.Forms.Label labelMember;
        private System.Windows.Forms.Label labelBoardGames;
        private System.Windows.Forms.Button buttonRemoveBoardGame;
        private System.Windows.Forms.Button buttonAddBoardGame;
        private System.Windows.Forms.Button buttonAddRental;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.BindingSource memberBindingSource;
        private System.Windows.Forms.BindingSource boardGameBindingSource;
        private System.Windows.Forms.ComboBox comboBoxBoardGames;
        private System.Windows.Forms.Label labelBoardGame;
        private System.Windows.Forms.DataGridView dataGridViewBoardGames;
        private System.Windows.Forms.BindingSource boardGamesGridBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn boardGameIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
    }
}