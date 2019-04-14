using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BoardGameTeka.BaseLib.IView;

namespace BoardGameTeka.PresentationLayer.BoardGame
{
    public partial class frmAddBoardGame : Form, IAddNewBoardGameView
    {
        private readonly List<string> gameTypes;

        public string BoardGameName => textBoxName.Text;

        public string GameType => comboBoxGameType.SelectedItem.ToString();

        public int MinPlayers
        {
            get
            {
                if (int.TryParse(textBoxMinPlayers.Text, out var minPlayerValue))
                {
                    return minPlayerValue;
                }

                throw new ArgumentException();
            }
        }

        public int MaxPlayers
        {
            get
            {
                if (int.TryParse(textBoxMaxPlayers.Text, out var maxPlayerValue))
                {
                    return maxPlayerValue;
                }

                throw new ArgumentException();
            }
        }

        public int PlayingTimeInMinutes
        {
            get
            {
                if (int.TryParse(textBoxPlayingTime.Text, out var playingTimeValue))
                {
                    return playingTimeValue;
                }

                throw new ArgumentException();
            }
        }

        public decimal Rating
        {
            get
            {
                if (decimal.TryParse(textBoxRating.Text, out var ratingValue))
                {
                    return ratingValue;
                }

                throw new ArgumentException();
            }
        }

        public decimal Complexity
        {
            get
            {
                if (decimal.TryParse(textBoxComplexity.Text, out var complexityValue))
                {
                    return complexityValue;
                }

                throw new ArgumentException();
            }
        }

        public int AvailableCopies
        {
            get
            {
                if (int.TryParse(textBoxNumOfCopies.Text, out var availableCopiesValue))
                {
                    return availableCopiesValue;
                }

                throw new ArgumentException();
            }
        }

        public int ReleaseYear
        {
            get
            {
                if (int.TryParse(textBoxReleaseYear.Text, out var releaseYearValue))
                {
                    return releaseYearValue;
                }

                throw new ArgumentException();
            }
        }

        public frmAddBoardGame(List<string> inGameTypes)
        {
            gameTypes = inGameTypes;

            InitializeComponent();
        }

        private void frmAddBoardGame_Load(object sender, EventArgs e)
        {
            foreach (string gameType in gameTypes)
            {
                comboBoxGameType.Items.Add(gameType);

            }
        }

        public bool ShowViewModal()
        {
            return ShowDialog() == DialogResult.OK;
        }

    }
}
