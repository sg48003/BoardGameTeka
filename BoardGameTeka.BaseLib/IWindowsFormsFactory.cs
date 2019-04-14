using System.Collections.Generic;
using BoardGameTeka.BaseLib.IView;
using BoardGameTeka.Model.Entities;

namespace BoardGameTeka.BaseLib
{
    public interface IWindowFormsFactory
    {
        IShowMainWindowView CreateShowMainWidowView();

        IAddNewBoardGameView CreateAddNewBoardGameView(List<string> inGameTypes);
        IShowBoardGameListView CreateShowBoardGameListView();

        IAddNewEmployeeView CreateAddNewEmployeeView();
        IShowEmployeeListView CreateShowEmployeeListView();

        IAddNewMemberView CreateAddNewMemberView(List<string> inMembershipTypes);
        IShowMemberListView CreateShowMemberListView();
        IShowRentalHistoryView CreateShowRentalHistoryListView();


        IAddNewRentalView CreateAddNewRentalView(List<Member> inMembers, List<BoardGame> inBoardGames);
        IShowActiveRentalListView CreateShowActiveRentalListView();

    }
}
