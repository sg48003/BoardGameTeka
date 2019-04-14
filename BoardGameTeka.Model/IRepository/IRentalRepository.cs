using System;
using System.Collections.Generic;
using BoardGameTeka.Model.Entities;

namespace BoardGameTeka.Model.IRepository
{
    public interface IRentalRepository
    {
        Rental GetRentalById(int inRentalId);
        //List<Rental> GetRentalsByBoardGame(BoardGame inBoardGame);
        List<Rental> GetRentalsByMember(Member inMember);
        //List<Rental> GetRentalsByEmployee(User inEmployee);
        //List<Rental> GetRentalsByDateRented(DateTime inDateRented);
        List<Rental> GetNotReturnedRentals();
        List<Rental> GetNotReturnedRentalsByMember(Member inMember);
        List<Rental> GetAllRentals();
        void ReturnRental(int inRentalId);
        //int Count();
        int AddRental(Rental inRental);
        void DeleteRental(int inRentalId);
        void DeleteRental(Rental inRental);
    }
}
