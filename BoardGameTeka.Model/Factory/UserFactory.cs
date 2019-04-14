using BoardGameTeka.Model.Entities;

namespace BoardGameTeka.Model.Factory
{
    public class UserFactory
    {
        public static User CreateUser(string inUsername, string inPassword, Role inRole)
        {
            return new User
            {
                Username = inUsername,
                Password = inPassword,
                Role = inRole
            };
        }
    }
}
