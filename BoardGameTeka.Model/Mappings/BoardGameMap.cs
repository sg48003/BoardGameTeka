using BoardGameTeka.Model.Entities;
using FluentNHibernate.Mapping;

namespace BoardGameTeka.Model.Mappings
{
    public class BoardGameMap : ClassMap<BoardGame>
    {
        public BoardGameMap()
        {
            Id(x => x.BoardGameId);
            Map(x => x.Name);
            Map(x => x.MinPlayers);
            Map(x => x.MaxPlayers);
            Map(x => x.PlayingTimeInMinutes);
            Map(x => x.Rating);
            Map(x => x.Complexity);
            Map(x => x.ReleaseYear);
            Map(x => x.AvailableCopies);

            References(x => x.GameType).Not.LazyLoad();

            HasManyToMany(x => x.InRentals)
                .Table("Rental_BoardGame")
                .Cascade.All()
                .Inverse().LazyLoad();
        }
    }
}
