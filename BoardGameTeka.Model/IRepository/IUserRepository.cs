using System.Collections.Generic;
using BoardGameTeka.Model.Entities;

namespace BoardGameTeka.Model.IRepository
{
    public interface IUserRepository
    {
        User GetEmployeeById(int inEmployeeId);
        User GetEmployeeByUserName(string inEmployeeUserName);
        User GetUserByUserName(string inUserUserName);
        List<User> GetAllEmployees();
        //int CountEmployees();
        bool DoesEmployeeExists(string inEmployeeUserName);
        void AddEmployee(User inEmployee);
        void DeleteEmployee(int inEmployeeId);
        void DeleteEmployee(User inEmployee);
        Role GetRoleByName(string inRoleName);
        User DoesUserExists(string username, string password);
    }
}
