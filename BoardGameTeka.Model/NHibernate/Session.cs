using System.IO;
using BoardGameTeka.Model.Entities;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Tool.hbm2ddl;

namespace BoardGameTeka.Model.NHibernate
{
    public class Session
    {
        private const string DbFile = "BoardGameTeka.db";

        public static ISessionFactory CreateSessionFactory()
        {
            return Fluently.Configure()
                .Database(SQLiteConfiguration.Standard.UsingFile(DbFile))
                .Mappings(m =>
                {
                    m.FluentMappings.AddFromAssemblyOf<BoardGame>();
                    m.FluentMappings.AddFromAssemblyOf<GameType>();
                    m.FluentMappings.AddFromAssemblyOf<Rental>();
                    m.FluentMappings.AddFromAssemblyOf<Role>();
                    m.FluentMappings.AddFromAssemblyOf<User>();
                    m.FluentMappings.AddFromAssemblyOf<MembershipType>();
                    m.FluentMappings.AddFromAssemblyOf<Member>();
                })
                .ExposeConfiguration(BuildSchema)
                .BuildSessionFactory();
        }

        public static void BuildSchema(Configuration config)
        {
            // this NHibernate tool takes a configuration (with mapping info in)
            // and exports a database schema from it
            if (File.Exists(DbFile) == false)
            {                
                new SchemaExport(config)
                    .Create(false, true);
                LoadInitialData(CreateSessionFactory());
            }
            else
            {
                new SchemaUpdate(config).Execute(false, true);
            }
        }

        private static void LoadInitialData(ISessionFactory sessionFactory)
        {      
            using (var session = sessionFactory.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {

                    session.Save(new GameType { Name = "Card game" });
                    session.Save(new GameType { Name = "Story telling" });
                    session.Save(new GameType { Name = "Dice rolling" });
                    session.Save(new GameType { Name = "Party game" });
                    session.Save(new GameType { Name = "Set collection" });
                    session.Save(new GameType { Name = "Role playing" });
                    session.Save(new GameType { Name = "Worker placement" });
                    session.Save(new GameType { Name = "Area control" });
                    session.Save(new GameType { Name = "Deckbuilding" });
                    session.Save(new GameType { Name = "Tile placement" });
                    session.Save(new GameType { Name = "Pattern recognition" });

                    var admin = new Role {Name = "Administrator"};
                    session.Save(admin);
                    session.Save(new Role { Name = "Employee" });

                    session.Save(new MembershipType { Name = "Pay as you go", DurationInMonths = 0});
                    session.Save(new MembershipType { Name = "Monthly", DurationInMonths = 1 });
                    session.Save(new MembershipType { Name = "Quarterly", DurationInMonths = 3 });
                    session.Save(new MembershipType { Name = "Annual", DurationInMonths = 12 });

                    session.Save(new User { Username = "admin", Password = "admin", Role = admin });

                    transaction.Commit();
                }
            }
        }
    }
}
