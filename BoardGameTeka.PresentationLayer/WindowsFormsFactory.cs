using BoardGameTeka.BaseLib;
using System.Collections.Generic;
using BoardGameTeka.BaseLib.IView;
using BoardGameTeka.PresentationLayer.BoardGame;
using BoardGameTeka.PresentationLayer.Employee;
using BoardGameTeka.PresentationLayer.Member;
using BoardGameTeka.PresentationLayer.Rental;

namespace BoardGameTeka.PresentationLayer
{
    public class WindowsFormsFactory : IWindowFormsFactory
    {
        public IShowMainWindowView CreateShowMainWidowView()
        {
            return new frmMainWindow();
        }

        public IAddNewBoardGameView CreateAddNewBoardGameView(List<string> inGameTypes)
        {
            return new frmAddBoardGame(inGameTypes);
        }

        public IShowBoardGameListView CreateShowBoardGameListView()
        {
            return new frmViewBoardGames();
        }

        public IAddNewEmployeeView CreateAddNewEmployeeView()
        {
            return new frmAddEmployee();
        }

        public IShowEmployeeListView CreateShowEmployeeListView()
        {
           return new frmViewEmployees();
        }

        public IAddNewMemberView CreateAddNewMemberView(List<string> inMembershipTypes)
        {
            return new frmAddMember(inMembershipTypes);
        }

        public IShowMemberListView CreateShowMemberListView()
        {
            return new frmViewMembers();
        }

        public IShowRentalHistoryView CreateShowRentalHistoryListView()
        {
            return new frmRentalHistory();
        }

        public IAddNewRentalView CreateAddNewRentalView(List<Model.Entities.Member> inMembers, List<Model.Entities.BoardGame> inBoardGames)
        {
            return new frmNewRental(inMembers, inBoardGames);
        }

        public IShowActiveRentalListView CreateShowActiveRentalListView()
        {
            return new frmViewActiveRentals();
        }
    }
}
