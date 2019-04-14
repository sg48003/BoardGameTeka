using BoardGameTeka.Model.Entities;
using FluentNHibernate.Mapping;

namespace BoardGameTeka.Model.Mappings
{
    public class GameTypeMap : ClassMap<GameType>
    {
        public GameTypeMap()
        {
            Id(x => x.GameTypeId);

            Map(x => x.Name);
        }
    }
}
