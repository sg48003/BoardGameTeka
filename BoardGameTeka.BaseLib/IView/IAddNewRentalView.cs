using System;
using System.Collections.Generic;
using BoardGameTeka.Model.Entities;

namespace BoardGameTeka.BaseLib.IView
{
    public interface IAddNewRentalView
    {
        bool ShowViewModal();

        Member Member { get; }
        List<BoardGame> BoardGames { get; }

    }
}
