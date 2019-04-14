using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BoardGameTeka.BaseLib.IView;

namespace BoardGameTeka.PresentationLayer.Rental
{
    public partial class frmNewRental : Form, IAddNewRentalView
    {
        private readonly List<Model.Entities.BoardGame> boardGames;
        private readonly List<Model.Entities.BoardGame> boardGamesGrid = new List<Model.Entities.BoardGame>();
        private readonly List<Model.Entities.Member> members;
        public Model.Entities.Member Member => (Model.Entities.Member)memberBindingSource.Current;
        public List<Model.Entities.BoardGame> BoardGames => boardGamesGrid;

        public frmNewRental(List<Model.Entities.Member> inMembers, List<Model.Entities.BoardGame> inBoardGames)
        {
            boardGames = inBoardGames;
            members = inMembers;
            InitializeComponent();
        }

        public bool ShowViewModal()
        {
            return ShowDialog() == DialogResult.OK;
        }

        private void frmNewRental_Load(object sender, EventArgs e)
        {
            memberBindingSource.DataSource = members;
            boardGameBindingSource.DataSource = boardGames;
        }

        private void buttonAddBoardGame_Click(object sender, EventArgs e)
        {
            var selectedBoardGame = (Model.Entities.BoardGame)boardGameBindingSource.Current;

            boardGamesGrid.Add(selectedBoardGame);
            boardGames.Remove(selectedBoardGame);

            UpdateForm();
        }

        private void buttonRemoveBoardGame_Click(object sender, EventArgs e)
        {
            var selectedBoardGame = (Model.Entities.BoardGame)boardGamesGridBindingSource.Current;

            boardGamesGrid.Remove(selectedBoardGame);
            boardGames.Add(selectedBoardGame);

            UpdateForm();
        }

        private void UpdateForm()
        {
            boardGamesGridBindingSource.DataSource = null;
            boardGameBindingSource.DataSource = null;
            boardGamesGridBindingSource.DataSource = boardGamesGrid;
            boardGameBindingSource.DataSource = boardGames;
        }
    }
}
