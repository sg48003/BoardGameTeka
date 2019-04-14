using System;
using System.Collections.Generic;
using BoardGameTeka.BaseLib;
using BoardGameTeka.Model.Entities;
using BoardGameTeka.Model.IRepository;

namespace BoardGameTeka.Controllers
{
    public class MainFormController : IMainFormController
    {
        private readonly IWindowFormsFactory FormsFactory;
        private readonly IBoardGameRepository BoardGameRepository;
        private readonly IMemberRepository MemberRepository;
        private readonly IUserRepository UserRepository;
        private readonly IRentalRepository RentalRepository;

        public MainFormController(IWindowFormsFactory inFormFactory, IBoardGameRepository inBoardGameRepository, IMemberRepository inMemberRepository, IUserRepository inUserRepository, IRentalRepository inRentalRepository)
        {
            FormsFactory = inFormFactory;
            BoardGameRepository = inBoardGameRepository;
            MemberRepository = inMemberRepository;
            UserRepository = inUserRepository;
            RentalRepository = inRentalRepository;
        }

        #region Members

        public List<Member> GetAllMembers()
        {
            var memberController = new MemberController();
            return memberController.GetAllMembers(MemberRepository);
        }

        public void ShowMembers()
        {
            var memberController = new MemberController();

            var newForm = FormsFactory.CreateShowMemberListView();

            memberController.ViewMembers(newForm, this);
        }

        public void AddMember()
        {
            var memberController = new MemberController();

            var newForm = FormsFactory.CreateAddNewMemberView(memberController.GetMembershipTypes());

            memberController.AddNewMember(newForm, MemberRepository);
        }

        public void DeleteMember(int inId)
        {
            var memberController = new MemberController();
            memberController.DeleteMember(inId, MemberRepository);
        }

        #endregion

        #region Employee

        public List<User> GetAllEmployees()
        {
            var employeeController = new EmployeeController();
            return employeeController.GetAllEmployees(UserRepository);
        }

        public void ShowEmployees()
        {
            var employeeController = new EmployeeController();

            var newForm = FormsFactory.CreateShowEmployeeListView();

            employeeController.ViewEmployees(newForm, this);
        }

        public void AddEmployee()
        {
            var employeeController = new EmployeeController();

            var newForm = FormsFactory.CreateAddNewEmployeeView();

            employeeController.AddNewEmployee(newForm, UserRepository);

        }

        public void DeleteEmployee(int inId)
        {
            var employeeController = new EmployeeController();
            employeeController.DeleteEmployee(inId, UserRepository);
        }

        #endregion

        #region Board games

        public List<BoardGame> GetAllBoardGames()
        {
            var boardGameController = new BoardGameController();
            return boardGameController.GetAllBoardGames(BoardGameRepository);
        }

        public void ShowBoardGames()
        {
            var boardGameController = new BoardGameController();

            var newForm = FormsFactory.CreateShowBoardGameListView();

            boardGameController.ViewBoardGames(newForm, this);
        }

        public void AddBoardGame()
        {
            var boardGameController = new BoardGameController();

            var newForm = FormsFactory.CreateAddNewBoardGameView(boardGameController.GetGameTypes());

            boardGameController.AddNewBoardGame(newForm, BoardGameRepository);

        }

        public void DeleteBoardGame(int inId)
        {
            var boardGameController = new BoardGameController();
            boardGameController.DeleteBoardGame(inId, BoardGameRepository);
        }

        #endregion

        #region Rental

        public List<Rental> GetAllActiveRentals()
        {
            var rentalController = new RentalController();
            return rentalController.GetAllActiveRentals(RentalRepository);
        }

        public List<Rental> GetAllRentalsByMembers(Member inMember)
        {
            var rentalController = new RentalController();
            return rentalController.GetAllRentalsByMember(RentalRepository, inMember);
        }
        public void ShowRentalsByMember(int inMemberId)
        {
            var rentalController = new RentalController();

            var newForm = FormsFactory.CreateShowRentalHistoryListView();

            rentalController.ViewRentalsByMember(newForm, inMemberId, MemberRepository, this);
        }

        public void ShowActiveRentals()
        {
            var rentalController = new RentalController();

            var newForm = FormsFactory.CreateShowActiveRentalListView();

            rentalController.ViewActiveRentals(newForm, this);
        }

        public void AddRental()
        {
            var rentalController = new RentalController();

            var newForm = FormsFactory.CreateAddNewRentalView(MemberRepository.GetAllMembers(), BoardGameRepository.GetAllAvailableBoardGames());

            rentalController.AddNewRental(newForm, RentalRepository, BoardGameRepository);
        }

        public void DeleteRental(int inId)
        {
            var rentalController = new RentalController();
            rentalController.DeleteRental(inId, RentalRepository);
        }

        public void ReturnRental(int inId)
        {
            var rentalController = new RentalController();
            rentalController.ReturnRental(inId, RentalRepository, BoardGameRepository);
        }

        #endregion

        public User CheckLogin(string username, string password)
        {
            var rentalController = new RentalController();
            var newForm = FormsFactory.CreateShowMainWidowView();

            return rentalController.CheckLogin(newForm,username, password, UserRepository, this);          
        }

    }
}
