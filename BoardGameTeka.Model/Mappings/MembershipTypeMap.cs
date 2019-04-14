using BoardGameTeka.Model.Entities;
using FluentNHibernate.Mapping;

namespace BoardGameTeka.Model.Mappings
{
    public class MembershipTypeMap : ClassMap<MembershipType>
    {
        public MembershipTypeMap()
        {
            Id(x => x.MembershipTypeId);

            Map(x => x.Name);
            Map(x => x.DurationInMonths);
        }
    }
}
