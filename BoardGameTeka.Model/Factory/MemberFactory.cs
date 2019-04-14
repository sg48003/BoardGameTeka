using BoardGameTeka.Model.Entities;

namespace BoardGameTeka.Model.Factory
{
    public class MemberFactory
    {
        public static Member CreateMember(string inName, int inPhoneNumber, MembershipType inMembershipType)
        {
            return new Member
            {
                Name = inName,
                PhoneNumber = inPhoneNumber,
                MembershipType = inMembershipType
            };
        }
    }
}
