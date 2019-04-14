using BoardGameTeka.Model.Entities;
using FluentNHibernate.Mapping;

namespace BoardGameTeka.Model.Mappings
{
    public class UserMap : ClassMap<User>
    {
        public UserMap()
        {
            Id(x => x.UserId);

            Map(x => x.Username);
            Map(x => x.Password);

            References(x => x.Role);
        }
    }
}
