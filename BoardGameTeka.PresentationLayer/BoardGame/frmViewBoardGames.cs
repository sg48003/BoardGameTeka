using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;
using BoardGameTeka.BaseLib;
using BoardGameTeka.BaseLib.IView;
using BoardGameTeka.Controllers;
using BoardGameTeka.Model.Enums_Dictionaries;

namespace BoardGameTeka.PresentationLayer.BoardGame
{
    public partial class frmViewBoardGames : Form, IShowBoardGameListView
    {
        private IMainFormController MainController;
        public frmViewBoardGames()
        {
            InitializeComponent();
        }

        public void ShowModaless(IMainFormController inMainController)
        {
            MainController = inMainController;

            UpdateGrid();
            if (GlobalVariables.CurrentUser.Role.RoleId == (int) Rolelist.RoleEnum.Employee)
            {
                buttonAddBoardGame.Visible = false;
            }

            this.Show();
        }

        private void UpdateGrid()
        {
            var boardGameList = new List<BoardGameView>();
            foreach (var item in MainController.GetAllBoardGames())
            {
                var member = new BoardGameView
                {
                    BoardGameId = item.BoardGameId,
                    Type = item.GameType.Name,
                    Name = item.Name,
                    PlayingTime = item.PlayingTimeInMinutes + " min",
                    Players = item.MinPlayers + " - " + item.MaxPlayers,
                    Rating = item.Rating.ToString(CultureInfo.InvariantCulture),
                    Complexity = item.Complexity.ToString(CultureInfo.InvariantCulture),
                    ReleaseYear = item.ReleaseYear,
                    AvailableCopies = item.AvailableCopies
                    
                };
                boardGameList.Add(member);
            }
            dataGridViewBoardGames.DataSource = boardGameList;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonDeleteBoardGame_Click(object sender, EventArgs e)
        {
            BoardGameView selectedBoardGame = (BoardGameView)dataGridViewBoardGames.CurrentRow?.DataBoundItem;
            if (selectedBoardGame != null)
            {
                MainController.DeleteBoardGame(selectedBoardGame.BoardGameId);
                UpdateGrid();
            }
        }

        private void buttonAddBoardGame_Click(object sender, EventArgs e)
        {
            MainController.AddBoardGame();
            UpdateGrid();
        }
    }
}
