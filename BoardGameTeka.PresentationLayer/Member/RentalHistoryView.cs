using System;

namespace BoardGameTeka.PresentationLayer.Member
{
    class RentalHistoryView
    {
        public int RentalId { get; set; }
        public string BoardGames { get; set; }
        public string EmployeeUsername { get; set; }
        public DateTime DateRented { get; set; }
        public DateTime? DateReturned { get; set; }
    }
}
