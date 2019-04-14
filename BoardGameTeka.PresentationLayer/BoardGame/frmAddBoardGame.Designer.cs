namespace BoardGameTeka.PresentationLayer.BoardGame
{
    partial class frmAddBoardGame
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
            this.textBoxComplexity = new System.Windows.Forms.TextBox();
            this.textBoxRating = new System.Windows.Forms.TextBox();
            this.textBoxMinPlayers = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelComplexity = new System.Windows.Forms.Label();
            this.labelRating = new System.Windows.Forms.Label();
            this.labelNumPlayers = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonAddEmployee = new System.Windows.Forms.Button();
            this.textBoxMaxPlayers = new System.Windows.Forms.TextBox();
            this.labelGameType = new System.Windows.Forms.Label();
            this.comboBoxGameType = new System.Windows.Forms.ComboBox();
            this.textBoxNumOfCopies = new System.Windows.Forms.TextBox();
            this.labelCopies = new System.Windows.Forms.Label();
            this.textBoxReleaseYear = new System.Windows.Forms.TextBox();
            this.labelReleaseYear = new System.Windows.Forms.Label();
            this.textBoxPlayingTime = new System.Windows.Forms.TextBox();
            this.labelPlayingTime = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxComplexity
            // 
            this.textBoxComplexity.Location = new System.Drawing.Point(149, 163);
            this.textBoxComplexity.Name = "textBoxComplexity";
            this.textBoxComplexity.Size = new System.Drawing.Size(85, 20);
            this.textBoxComplexity.TabIndex = 19;
            // 
            // textBoxRating
            // 
            this.textBoxRating.Location = new System.Drawing.Point(149, 137);
            this.textBoxRating.Name = "textBoxRating";
            this.textBoxRating.Size = new System.Drawing.Size(85, 20);
            this.textBoxRating.TabIndex = 18;
            // 
            // textBoxMinPlayers
            // 
            this.textBoxMinPlayers.Location = new System.Drawing.Point(149, 59);
            this.textBoxMinPlayers.Name = "textBoxMinPlayers";
            this.textBoxMinPlayers.Size = new System.Drawing.Size(85, 20);
            this.textBoxMinPlayers.TabIndex = 17;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(149, 6);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(283, 20);
            this.textBoxName.TabIndex = 16;
            // 
            // labelComplexity
            // 
            this.labelComplexity.AutoSize = true;
            this.labelComplexity.Location = new System.Drawing.Point(32, 166);
            this.labelComplexity.Name = "labelComplexity";
            this.labelComplexity.Size = new System.Drawing.Size(63, 13);
            this.labelComplexity.TabIndex = 15;
            this.labelComplexity.Text = "Complexity :";
            // 
            // labelRating
            // 
            this.labelRating.AutoSize = true;
            this.labelRating.Location = new System.Drawing.Point(32, 140);
            this.labelRating.Name = "labelRating";
            this.labelRating.Size = new System.Drawing.Size(44, 13);
            this.labelRating.TabIndex = 14;
            this.labelRating.Text = "Rating :";
            // 
            // labelNumPlayers
            // 
            this.labelNumPlayers.AutoSize = true;
            this.labelNumPlayers.Location = new System.Drawing.Point(32, 62);
            this.labelNumPlayers.Name = "labelNumPlayers";
            this.labelNumPlayers.Size = new System.Drawing.Size(98, 13);
            this.labelNumPlayers.TabIndex = 13;
            this.labelNumPlayers.Text = "Number of players :";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(32, 9);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(41, 13);
            this.labelName.TabIndex = 12;
            this.labelName.Text = "Name :";
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(357, 225);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 11;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonAddEmployee
            // 
            this.buttonAddEmployee.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonAddEmployee.Location = new System.Drawing.Point(149, 225);
            this.buttonAddEmployee.Name = "buttonAddEmployee";
            this.buttonAddEmployee.Size = new System.Drawing.Size(115, 23);
            this.buttonAddEmployee.TabIndex = 10;
            this.buttonAddEmployee.Text = "Add board game";
            this.buttonAddEmployee.UseVisualStyleBackColor = true;
            // 
            // textBoxMaxPlayers
            // 
            this.textBoxMaxPlayers.Location = new System.Drawing.Point(240, 59);
            this.textBoxMaxPlayers.Name = "textBoxMaxPlayers";
            this.textBoxMaxPlayers.Size = new System.Drawing.Size(85, 20);
            this.textBoxMaxPlayers.TabIndex = 20;
            // 
            // labelGameType
            // 
            this.labelGameType.AutoSize = true;
            this.labelGameType.Location = new System.Drawing.Point(32, 35);
            this.labelGameType.Name = "labelGameType";
            this.labelGameType.Size = new System.Drawing.Size(37, 13);
            this.labelGameType.TabIndex = 21;
            this.labelGameType.Text = "Type :";
            // 
            // comboBoxGameType
            // 
            this.comboBoxGameType.FormattingEnabled = true;
            this.comboBoxGameType.Location = new System.Drawing.Point(149, 32);
            this.comboBoxGameType.Name = "comboBoxGameType";
            this.comboBoxGameType.Size = new System.Drawing.Size(176, 21);
            this.comboBoxGameType.TabIndex = 22;
            // 
            // textBoxNumOfCopies
            // 
            this.textBoxNumOfCopies.Location = new System.Drawing.Point(149, 189);
            this.textBoxNumOfCopies.Name = "textBoxNumOfCopies";
            this.textBoxNumOfCopies.Size = new System.Drawing.Size(85, 20);
            this.textBoxNumOfCopies.TabIndex = 24;
            // 
            // labelCopies
            // 
            this.labelCopies.AutoSize = true;
            this.labelCopies.Location = new System.Drawing.Point(32, 192);
            this.labelCopies.Name = "labelCopies";
            this.labelCopies.Size = new System.Drawing.Size(96, 13);
            this.labelCopies.TabIndex = 23;
            this.labelCopies.Text = "Number of copies :";
            // 
            // textBoxReleaseYear
            // 
            this.textBoxReleaseYear.Location = new System.Drawing.Point(149, 111);
            this.textBoxReleaseYear.Name = "textBoxReleaseYear";
            this.textBoxReleaseYear.Size = new System.Drawing.Size(85, 20);
            this.textBoxReleaseYear.TabIndex = 26;
            // 
            // labelReleaseYear
            // 
            this.labelReleaseYear.AutoSize = true;
            this.labelReleaseYear.Location = new System.Drawing.Point(32, 114);
            this.labelReleaseYear.Name = "labelReleaseYear";
            this.labelReleaseYear.Size = new System.Drawing.Size(75, 13);
            this.labelReleaseYear.TabIndex = 25;
            this.labelReleaseYear.Text = "Release year :";
            // 
            // textBoxPlayingTime
            // 
            this.textBoxPlayingTime.Location = new System.Drawing.Point(149, 85);
            this.textBoxPlayingTime.Name = "textBoxPlayingTime";
            this.textBoxPlayingTime.Size = new System.Drawing.Size(85, 20);
            this.textBoxPlayingTime.TabIndex = 28;
            // 
            // labelPlayingTime
            // 
            this.labelPlayingTime.AutoSize = true;
            this.labelPlayingTime.Location = new System.Drawing.Point(32, 88);
            this.labelPlayingTime.Name = "labelPlayingTime";
            this.labelPlayingTime.Size = new System.Drawing.Size(69, 13);
            this.labelPlayingTime.TabIndex = 27;
            this.labelPlayingTime.Text = "Playing time :";
            // 
            // frmAddBoardGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 271);
            this.Controls.Add(this.textBoxPlayingTime);
            this.Controls.Add(this.labelPlayingTime);
            this.Controls.Add(this.textBoxReleaseYear);
            this.Controls.Add(this.labelReleaseYear);
            this.Controls.Add(this.textBoxNumOfCopies);
            this.Controls.Add(this.labelCopies);
            this.Controls.Add(this.comboBoxGameType);
            this.Controls.Add(this.labelGameType);
            this.Controls.Add(this.textBoxMaxPlayers);
            this.Controls.Add(this.textBoxComplexity);
            this.Controls.Add(this.textBoxRating);
            this.Controls.Add(this.textBoxMinPlayers);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelComplexity);
            this.Controls.Add(this.labelRating);
            this.Controls.Add(this.labelNumPlayers);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonAddEmployee);
            this.Name = "frmAddBoardGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmAddBoardGame";
            this.Load += new System.EventHandler(this.frmAddBoardGame_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxComplexity;
        private System.Windows.Forms.TextBox textBoxRating;
        private System.Windows.Forms.TextBox textBoxMinPlayers;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelComplexity;
        private System.Windows.Forms.Label labelRating;
        private System.Windows.Forms.Label labelNumPlayers;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonAddEmployee;
        private System.Windows.Forms.TextBox textBoxMaxPlayers;
        private System.Windows.Forms.Label labelGameType;
        private System.Windows.Forms.ComboBox comboBoxGameType;
        private System.Windows.Forms.TextBox textBoxNumOfCopies;
        private System.Windows.Forms.Label labelCopies;
        private System.Windows.Forms.TextBox textBoxReleaseYear;
        private System.Windows.Forms.Label labelReleaseYear;
        private System.Windows.Forms.TextBox textBoxPlayingTime;
        private System.Windows.Forms.Label labelPlayingTime;
    }
}