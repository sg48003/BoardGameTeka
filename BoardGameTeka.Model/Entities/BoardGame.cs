using System.Collections.Generic;

namespace BoardGameTeka.Model.Entities
{
    public class BoardGame
    {
        public virtual int BoardGameId { get; protected set; }
        public virtual string Name { get; set; }
        public virtual int MinPlayers { get; set; }
        public virtual int MaxPlayers { get; set; }
        public virtual int PlayingTimeInMinutes { get; set; }
        public virtual decimal Rating { get; set; }
        public virtual decimal Complexity { get; set; }
        public virtual int AvailableCopies { get; set; }
        public virtual int ReleaseYear { get; set; }
        public virtual GameType GameType { get; set; }

        public virtual IList<Rental> InRentals { get; set; }

    }
}
