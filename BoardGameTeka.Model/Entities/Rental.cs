using System;
using System.Collections.Generic;

namespace BoardGameTeka.Model.Entities
{
    public class Rental
    {
        public virtual int RentalId { get; protected set; }
        public virtual Member Member { get; set; }
        public virtual IList<BoardGame> BoardGames { get; set; }
        public virtual User Employee { get; set; }
        public virtual DateTime DateRented { get; set; }
        public virtual DateTime? DateReturned { get; set; }

        public Rental()
        {
            BoardGames = new List<BoardGame>();
        }

        public virtual void AddBoardGame(BoardGame inBoardGame)
        {
            BoardGames.Add(inBoardGame);
        }

        public virtual void RemoveBoardGame(int boardGameId)
        {
            for (int i = 0; i < BoardGames.Count; i++)
            {
                if (BoardGames[i].BoardGameId == boardGameId)
                {
                    BoardGames.RemoveAt(i);
                }
            }
        }

    }
}
