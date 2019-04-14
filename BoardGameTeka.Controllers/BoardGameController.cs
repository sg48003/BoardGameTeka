using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using BoardGameTeka.BaseLib;
using BoardGameTeka.BaseLib.IView;
using BoardGameTeka.Model.Entities;
using BoardGameTeka.Model.Enums_Dictionaries;
using BoardGameTeka.Model.Factory;
using BoardGameTeka.Model.IRepository;

namespace BoardGameTeka.Controllers
{
    public class BoardGameController
    {
        public List<string> GetGameTypes()
        {
            return GameTypeList.GameTypeDictionary.Select(x => x.Value).ToList();
        }

        public List<BoardGame> GetAllBoardGames(IBoardGameRepository boardGameRepository)
        {
            return boardGameRepository.GetAllBoardGames();
        }

        public void ViewBoardGames(IShowBoardGameListView inForm, IMainFormController mainController)
        {
            inForm.ShowModaless(mainController);
        }

        public void AddNewBoardGame(IAddNewBoardGameView inForm, IBoardGameRepository boardGameRepository)
        {
            if (inForm.ShowViewModal())
            {
                try
                {
                    string name = inForm.BoardGameName;
                    int minPlayers = inForm.MinPlayers;
                    int maxPlayers = inForm.MaxPlayers;
                    int playingTimeInMinutes = inForm.PlayingTimeInMinutes;
                    decimal rating = inForm.Rating;
                    decimal complexity = inForm.Complexity;
                    int availableCopies = inForm.AvailableCopies;
                    int releaseYear = inForm.ReleaseYear;
                    GameType gameType = boardGameRepository.GetGameTypeByName(inForm.GameType);

                    BoardGame newBoardGame = BoardGameFactory
                                                .CreateBoardGame(name, minPlayers, maxPlayers, playingTimeInMinutes, rating, complexity, availableCopies, releaseYear, gameType);

                    boardGameRepository.AddBoardGame(newBoardGame);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("EXCEPTION: " + ex.Message);
                    throw;
                }
            }
        }

        public void DeleteBoardGame(int inId, IBoardGameRepository boardGameRepository)
        {
            boardGameRepository.DeleteBoardGame(inId);
        }
    }
}
