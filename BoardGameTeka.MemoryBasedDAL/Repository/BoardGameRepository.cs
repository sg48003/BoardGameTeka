using System;
using System.Collections.Generic;
using System.Linq;
using BoardGameTeka.BaseLib;
using BoardGameTeka.Model;
using BoardGameTeka.Model.Entities;
using BoardGameTeka.Model.IRepository;
using BoardGameTeka.Model.NHibernate;
using NHibernate;

namespace BoardGameTeka.MemoryBasedDAL.Repository
{
    public class BoardGameRepository : Subject, IBoardGameRepository 
    {
        private static BoardGameRepository Instance;
        private List<BoardGame> BoardGamesList = new List<BoardGame>();

        private readonly ISessionFactory sessionFactory = Session.CreateSessionFactory();

        public static BoardGameRepository GetInstance()
        {
            return Instance ?? (Instance = new BoardGameRepository());
        }

        #region NHibernate napravljen

        public virtual List<BoardGame> GetAllBoardGames()
        {
            using (var session = sessionFactory.OpenSession())
            {
                using (session.BeginTransaction())
                {
                    BoardGamesList = session
                        .CreateCriteria(typeof(BoardGame))
                        .List<BoardGame>()
                        .ToList();
                }
            }
            return BoardGamesList;
        }

        public List<BoardGame> GetAllAvailableBoardGames()
        {
            List<BoardGame> boardGameList;
            using (var session = sessionFactory.OpenSession())
            {
                using (session.BeginTransaction())
                {
                    boardGameList = session.QueryOver<BoardGame>()
                        .Where(x => x.AvailableCopies > 0)
                        .List<BoardGame>()
                        .ToList();
                }
            }
            return boardGameList;
        }

        public BoardGame GetBoardGameById(int inBoardGameId)
        {
            using (var session = sessionFactory.OpenSession())
            {
                BoardGame boardGame = session.QueryOver<BoardGame>().Where(x => x.BoardGameId == inBoardGameId).List<BoardGame>()[0];
                if (boardGame == null)
                {
                    throw new BoardGameDoesntExistsException();
                }
                return boardGame;
            }
        }

        public BoardGame GetBoardGameByName(string inBoardGameName)
        {
            using (var session = sessionFactory.OpenSession())
            {
                try
                {
                    BoardGame boardGame = session.QueryOver<BoardGame>().Where(x => x.Name == inBoardGameName).List<BoardGame>()[0];
                    return boardGame;
                }
                catch(Exception)
                {
                    throw new BoardGameDoesntExistsException();
                }
            }
        }

        public virtual void AddBoardGame(BoardGame inBoardGame)
        {
            if (string.IsNullOrEmpty(inBoardGame.Name))
            {
                throw new BoardGameInvalidNameException();
            }
            if (inBoardGame.AvailableCopies < 1)
            {
                throw new BoardGameInvalidAvailableCopiesException();
            }
            if (inBoardGame.MinPlayers >= inBoardGame.MaxPlayers)
            {
                throw new BoardGameMinPlayerGreaterOrEqualThanMaxPlayerException();
            }

            foreach (BoardGame currentBoardGame in BoardGamesList)
            {
                if (currentBoardGame.Name.Equals(inBoardGame.Name))
                {
                    throw new BoardGameWithThatNameAlreadyExistsException();
                }
            }

            using (var session = sessionFactory.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    session.SaveOrUpdate(inBoardGame);
                    transaction.Commit();
                }
            }

            NotifyObservers();
        }

        public void DeleteBoardGame(BoardGame inBoardGame)
        {
            using (var session = sessionFactory.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    session.Delete(inBoardGame);
                    transaction.Commit();
                }
            }
            NotifyObservers();
        }

        public void DeleteBoardGame(int inBoardGameId)
        {
            BoardGame boardGame = GetBoardGameById(inBoardGameId);

            using (var session = sessionFactory.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    session.Delete(boardGame);
                    transaction.Commit();
                }
            }

            NotifyObservers();
        }

        public void BoardGamesRented(List<BoardGame> boardGames)
        {
            using (var session = sessionFactory.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    foreach (var boardGame in boardGames)
                    {
                        boardGame.AvailableCopies -= 1; 
                        session.Update(boardGame);
                    }
                    transaction.Commit();
                }
            }
        }

        public void ReturnBoardGames(List<BoardGame> boardGames)
        {
            using (var session = sessionFactory.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    foreach (var boardGame in boardGames)
                    {
                        boardGame.AvailableCopies += 1;
                        session.Update(boardGame);
                    }
                    transaction.Commit();
                }
            }
        }

        public GameType GetGameTypeByName(string inGameTypeName)
        {
            using (var session = sessionFactory.OpenSession())
            {
                GameType gameType = session.QueryOver<GameType>().Where(x => x.Name == inGameTypeName).List<GameType>()[0];
                return gameType;
            }
        }

        public bool DoesBoardGameExists(string inBoardGameName)
        {
            try
            {
                GetBoardGameByName(inBoardGameName);
                return true;
            }
            catch (BoardGameDoesntExistsException)
            {
                return false;
            }
        }

        #endregion

        //public int Count()
        //{
        //    return BoardGamesList.Count;
        //}

        //public List<BoardGame> GetAllBoardGamesByGameType(GameType inGameType)
        //{
        //    var boardGame = BoardGamesList.Where(x => x.GameType == inGameType).ToList();
        //    return boardGame;
        //}

        //public List<BoardGame> GetAllBoardGamesByNumberOfPlayers(int inNumOfPlayers)
        //{
        //    var boardGame = BoardGamesList.Where(x => x.MinPlayers <= inNumOfPlayers && x.MaxPlayers >= inNumOfPlayers).ToList();
        //    return boardGame;
        //}

        //public List<BoardGame> GetAllBoardGamesByPlayingTime(int inPlayingTime)
        //{
        //    var boardGame = BoardGamesList.Where(x => x.PlayingTimeInMinutes <= inPlayingTime).ToList();
        //    return boardGame;
        //}

        //public List<BoardGame> GetAllBoardGamesByReleaseYear(int inYear)
        //{
        //    var boardGame = BoardGamesList.Where(x => x.ReleaseYear == inYear).ToList();
        //    return boardGame;
        //}

    }
}
