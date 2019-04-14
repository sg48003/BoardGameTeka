using System.Collections.Generic;

namespace BoardGameTeka.Model.Enums_Dictionaries
{
    public static class MembershipTypeList
    {
        public enum MembershipTypeEnum
        {
            PayAsYouGo = 1,
            Monthly = 2,
            Quarterly = 3,
            Annual = 4,
        }

        public static Dictionary<MembershipTypeEnum, string> MembershipTypeDictionary = new Dictionary<MembershipTypeEnum, string>
        {
            { MembershipTypeEnum.PayAsYouGo, "Pay as you go"},
            { MembershipTypeEnum.Monthly, "Monthly"},
            { MembershipTypeEnum.Quarterly, "Quarterly"},
            { MembershipTypeEnum.Annual, "Annual"},

        };
    }
}
