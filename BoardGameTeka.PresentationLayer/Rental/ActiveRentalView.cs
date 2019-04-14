using System;

namespace BoardGameTeka.PresentationLayer.Rental
{
    public class ActiveRentalView
    {
        public int RentalId { get; set; }
        public string MemberName { get; set; }
        public string BoardGames { get; set; }
        public string EmployeeUsername { get; set; }
        public DateTime DateRented { get; set; }

    }
}
