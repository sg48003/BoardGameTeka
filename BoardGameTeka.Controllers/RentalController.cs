using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BoardGameTeka.BaseLib.IView;
using BoardGameTeka.Model.Entities;
using BoardGameTeka.Model.Factory;
using BoardGameTeka.Model.IRepository;

namespace BoardGameTeka.Controllers
{
    class RentalController
    {
        public List<Rental> GetAllActiveRentals(IRentalRepository rentalRepository)
        {
            return rentalRepository.GetNotReturnedRentals();
        }

        public List<Rental> GetAllRentalsByMember(IRentalRepository rentalRepository, Member inMember)
        {
            return rentalRepository.GetRentalsByMember(inMember);
        }

        public void ViewActiveRentals(IShowActiveRentalListView inForm, MainFormController mainController)
        {
            inForm.ShowModaless(mainController);
        }

        public void AddNewRental(IAddNewRentalView inForm, IRentalRepository rentalRepository, IBoardGameRepository boardGameRepository)
        {
            if (inForm.ShowViewModal())
            {
                try
                {
                    Member member = inForm.Member;
                    List<BoardGame> boardGames = inForm.BoardGames;
                    User employee = GlobalVariables.CurrentUser;

                    Rental newRental = RentalFactory.CreateRental(member, boardGames, DateTime.Now.Date, null, employee);
                    rentalRepository.AddRental(newRental);
                    boardGameRepository.BoardGamesRented(boardGames);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("EXCEPTION: " + ex.Message);
                    throw;
                }
            }
        }

        public void DeleteRental(int inId, IRentalRepository rentalRepository)
        {
            rentalRepository.DeleteRental(inId);
        }

        public void ReturnRental(int inId, IRentalRepository rentalRepository, IBoardGameRepository boardGameRepository)
        {
            rentalRepository.ReturnRental(inId);
            var rental = rentalRepository.GetRentalById(inId);
            boardGameRepository.ReturnBoardGames(new List<BoardGame>(rental.BoardGames));
        }

        public User CheckLogin(IShowMainWindowView inForm, string username, string password, IUserRepository userRepository, MainFormController mainController)
        {

            var user = userRepository.DoesUserExists(username, password);
            if (user != null)
            {
                GlobalVariables.CurrentUser = user;
                inForm.ShowModaless(mainController);
            }
            return user;

        }

        public void ViewRentalsByMember(IShowRentalHistoryView inForm, int inMemberId, IMemberRepository memberRepository, MainFormController mainController)
        {
            var member = memberRepository.GetMemberById(inMemberId);
            inForm.ShowModaless(mainController, member);
        }
    }
}
