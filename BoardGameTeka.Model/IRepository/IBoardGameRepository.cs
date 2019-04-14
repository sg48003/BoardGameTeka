using System.Collections.Generic;
using BoardGameTeka.Model.Entities;

namespace BoardGameTeka.Model.IRepository
{
    public interface IBoardGameRepository
    {
        BoardGame GetBoardGameById(int inBoardGameId);
        BoardGame GetBoardGameByName(string inBoardGameName);
        List<BoardGame> GetAllBoardGames();
        //List<BoardGame> GetAllBoardGamesByGameType(GameType inGameType);
        //List<BoardGame> GetAllBoardGamesByNumberOfPlayers(int inNumOfPlayers);
        //List<BoardGame> GetAllBoardGamesByPlayingTime(int inPlayingTime);
        //List<BoardGame> GetAllBoardGamesByReleaseYear(int inYear);
        List<BoardGame> GetAllAvailableBoardGames();
        //int Count();
        bool DoesBoardGameExists(string inBoardGameName);
        void AddBoardGame(BoardGame inBoardGame);
        void DeleteBoardGame(BoardGame inBoardGame);
        void DeleteBoardGame(int inBoardGameId);
        void BoardGamesRented(List<BoardGame> boardGames);
        void ReturnBoardGames(List<BoardGame> boardGames);
        GameType GetGameTypeByName(string inGameTypeName);
    }
}
