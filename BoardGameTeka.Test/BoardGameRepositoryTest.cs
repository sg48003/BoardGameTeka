using System.Collections.Generic;
using BoardGameTeka.MemoryBasedDAL.Repository;
using BoardGameTeka.Model;
using BoardGameTeka.Model.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BoardGameTeka.Test
{
    [TestClass]
    public class BoardGameRepositoryTest
    {

        [TestMethod()]
        [ExpectedException(typeof(BoardGameInvalidNameException))]
        public void AddBoardGameInvalidNameExceptionTest()
        {
            BoardGameRepository repository = new BoardGameRepository();
            BoardGame boardGame = new BoardGame { Name = "" };
            repository.AddBoardGame(boardGame);
        }

        [TestMethod()]
        [ExpectedException(typeof(BoardGameInvalidAvailableCopiesException))]
        public void AddBoardGameInvalidAvailableCopiesExceptionTest()
        {
            BoardGameRepository repository = new BoardGameRepository();
            BoardGame boardGame = new BoardGame
            {
                Name = "Clank",
                AvailableCopies = 0,
                MinPlayers = 1,
                MaxPlayers = 4
            };
            repository.AddBoardGame(boardGame);
        }

        [TestMethod()]
        [ExpectedException(typeof(BoardGameMinPlayerGreaterOrEqualThanMaxPlayerException))]
        public void AddBoardGameMinPlayerGreaterOrEqualThanMaxPlayerExceptionTest()
        {
            BoardGameRepository repository = new BoardGameRepository();
            BoardGame boardGame = new BoardGame
            {
                Name = "Clank",
                AvailableCopies = 1,
                MinPlayers = 2,
                MaxPlayers = 2
            };
            repository.AddBoardGame(boardGame);
        }

        [TestMethod()]
        public void BoardGameExistsTest()
        {
            BoardGameRepository repository = new BoardGameRepository();
            string Name = "nepostojece";

            bool actual = repository.DoesBoardGameExists(Name);
            Assert.AreEqual(false, actual);
        }

        [TestMethod()]
        public void AddBoardGameTest()
        {
            BoardGameRepository boardGameRepository = new BoardGameRepository();
            BoardGame expectedBoardGame = new BoardGame
            {
                Name = "Test1",
                AvailableCopies = 2,
                MinPlayers = 1,
                MaxPlayers = 4
            };
            boardGameRepository.AddBoardGame(expectedBoardGame);
            var actualBoardGame = boardGameRepository.GetBoardGameByName(expectedBoardGame.Name);

            Assert.AreEqual(expectedBoardGame.Name, actualBoardGame.Name);
            Assert.AreEqual(expectedBoardGame.AvailableCopies, actualBoardGame.AvailableCopies);
            Assert.AreEqual(expectedBoardGame.MinPlayers, actualBoardGame.MinPlayers);
            Assert.AreEqual(expectedBoardGame.MaxPlayers, actualBoardGame.MaxPlayers);
            boardGameRepository.DeleteBoardGame(actualBoardGame);
        }

        [TestMethod()]
        public void RemoveBoardGameTest()
        {
            BoardGameRepository boardGameRepository = new BoardGameRepository();
            BoardGame boardGame = new BoardGame
            {
                Name = "Test2",
                AvailableCopies = 2,
                MinPlayers = 1,
                MaxPlayers = 4
            };

            boardGameRepository.AddBoardGame(boardGame);
            boardGameRepository.DeleteBoardGame(boardGame);

            bool actual = boardGameRepository.DoesBoardGameExists(boardGame.Name);
            Assert.AreEqual(false, actual);
        }

        [TestMethod()]
        public void BoardGameRentedReturnedTest()
        {
            BoardGameRepository boardGameRepository = new BoardGameRepository();
            BoardGame boardGame = new BoardGame
            {
                Name = "Proba",
                AvailableCopies = 2,
                MinPlayers = 1,
                MaxPlayers = 4
            };

            boardGameRepository.AddBoardGame(boardGame);
            BoardGame boardGameAdded = boardGameRepository.GetBoardGameByName(boardGame.Name);

            var list = new List<BoardGame> { boardGameAdded };

            boardGameRepository.BoardGamesRented(list);

            BoardGame boardGameRented = boardGameRepository.GetBoardGameByName(boardGameAdded.Name);
            Assert.AreEqual(boardGame.AvailableCopies - 1, boardGameRented.AvailableCopies);
            boardGameRepository.ReturnBoardGames(list);
            BoardGame boardGameReturned = boardGameRepository.GetBoardGameByName(boardGameAdded.Name);
            Assert.AreEqual(boardGame.AvailableCopies, boardGameReturned.AvailableCopies);
        }

    }
}
