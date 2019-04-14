using BoardGameTeka.Model.Entities;
using FluentNHibernate.Mapping;

namespace BoardGameTeka.Model.Mappings
{
    public class MemberMap : ClassMap<Member>
    {
        public MemberMap()
        {
            Id(x => x.MemberId);

            Map(x => x.Name);
            Map(x => x.PhoneNumber);

            References(x => x.MembershipType).Not.LazyLoad();
        }
    }
}
