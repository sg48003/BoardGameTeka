using System.Collections.Generic;

namespace BoardGameTeka.Model.Enums_Dictionaries
{
    public static class Rolelist
    {
        public enum RoleEnum
        {
            Administrator = 1,
            Employee = 2
        }

        public static Dictionary<RoleEnum, string> RoleTypeDictionary = new Dictionary<RoleEnum, string>
        {
            { RoleEnum.Administrator, "Administrator"},
            { RoleEnum.Employee, "Employee"},
        };
    }

}
