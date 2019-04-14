using System.Collections;
using System.Collections.Generic;
using BoardGameTeka.Model.Entities;

namespace BoardGameTeka.BaseLib
{
    public interface IMainFormController
    {
        #region Member

        List<Member> GetAllMembers();
        void ShowMembers();
        void AddMember();
        void DeleteMember(int inId);

        #endregion

        #region Employee

        List<User> GetAllEmployees();
        void ShowEmployees();
        void AddEmployee();
        void DeleteEmployee(int inId);

        #endregion

        #region Board game

        List<BoardGame> GetAllBoardGames();
        void ShowBoardGames();
        void AddBoardGame();
        void DeleteBoardGame(int inId);

        #endregion

        #region Rental

        List<Rental> GetAllActiveRentals();
        void ShowRentalsByMember(int inMemberId);
        List<Rental> GetAllRentalsByMembers(Member inMember);
        void ShowActiveRentals();
        void AddRental();
        void DeleteRental(int inId);
        void ReturnRental(int inId);

        #endregion

        User CheckLogin(string username, string password);
        
    }
}
