using System;
using System.Collections.Generic;
using BoardGameTeka.Model.Entities;

namespace BoardGameTeka.Model.Factory
{
    public class RentalFactory
    {
        public static Rental CreateRental(Member inMember, List<BoardGame> inBoardGame, DateTime inDateRented, DateTime? inDateReturned, User inEmployee)
        {
            return new Rental
            {
                Member = inMember,
                BoardGames = inBoardGame,
                DateReturned = inDateReturned,
                DateRented = inDateRented,
                Employee = inEmployee
            };
        }
    }
}
