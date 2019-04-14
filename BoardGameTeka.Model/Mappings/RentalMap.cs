using BoardGameTeka.Model.Entities;
using FluentNHibernate.Mapping;

namespace BoardGameTeka.Model.Mappings
{
    public class RentalMap : ClassMap<Rental>
    {
        public RentalMap()
        {
            Id(x => x.RentalId);

            Map(x => x.DateReturned);
            Map(x => x.DateRented);

            References(x => x.Member).Not.LazyLoad();
            References(x => x.Employee).Not.LazyLoad();

            HasManyToMany(x => x.BoardGames)
                .Table("Rental_BoardGame").Not.LazyLoad(); 
        }
    }
}
