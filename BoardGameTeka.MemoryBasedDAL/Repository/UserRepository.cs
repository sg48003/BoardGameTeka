using System;
using System.Collections.Generic;
using System.Linq;
using BoardGameTeka.BaseLib;
using BoardGameTeka.Model;
using BoardGameTeka.Model.Entities;
using BoardGameTeka.Model.Enums_Dictionaries;
using BoardGameTeka.Model.IRepository;
using BoardGameTeka.Model.NHibernate;
using NHibernate;

namespace BoardGameTeka.MemoryBasedDAL.Repository
{
    public class UserRepository : Subject, IUserRepository
    {
        private static UserRepository Instance;
        private List<User> UsersList = new List<User>();

        private readonly ISessionFactory sessionFactory = Session.CreateSessionFactory();

        public static UserRepository GetInstance()
        {
            return Instance ?? (Instance = new UserRepository());
        }

        #region NHibernate napravljen

        public List<User> GetAllEmployees()
        {
            List<User> employeeList;
            using (var session = sessionFactory.OpenSession())
            {
                using (session.BeginTransaction())
                {
                    employeeList = session.QueryOver<User>()
                        .Where(x => x.Role.RoleId == (int)Rolelist.RoleEnum.Employee)
                        .List<User>()
                        .ToList();
                }
            }
            return employeeList;
        }

        public User GetEmployeeById(int inEmployeeId)
        {
            using (var session = sessionFactory.OpenSession())
            {
                User employee = session.QueryOver<User>().Where(x => x.UserId == inEmployeeId).List<User>()[0];
                if (employee == null)
                {
                    throw new EmployeeDoesntExistsException();
                }
                return employee;
            }
        }

        public User GetEmployeeByUserName(string inEmployeeUserName)
        {
            using (var session = sessionFactory.OpenSession())
            {
                try
                {
                    User employee = session.QueryOver<User>().Where(x => x.Username == inEmployeeUserName && x.Role.RoleId == (int)Rolelist.RoleEnum.Employee).List<User>()[0];
                    return employee;
                }
                catch (Exception)
                {
                    throw new EmployeeDoesntExistsException();
                }
            }
        }

        public User GetUserByUserName(string inUserUserName)
        {
            using (var session = sessionFactory.OpenSession())
            {
                User employee = session.QueryOver<User>().Where(x => x.Username == inUserUserName).List<User>()[0];
                if (employee == null)
                {
                    throw new EmployeeDoesntExistsException();
                }
                return employee;
            }
        }

        public void AddEmployee(User inEmployee)
        {
            if (string.IsNullOrEmpty(inEmployee.Username))
            {
                throw new EmployeeInvalidUsernameException();
            }
            if (string.IsNullOrEmpty(inEmployee.Password))
            {
                throw new EmployeeInvalidPasswordException();
            }
            if (inEmployee.Role.RoleId != (int)Rolelist.RoleEnum.Employee)
            {
                throw new EmployeeRoleIsNotEmployeeException();
            }

            foreach (User currentUser in UsersList)
            {
                if (currentUser.Username.Equals(inEmployee.Username))
                {
                    throw new EmployeeWithThatUsernameAlreadyExistsException();
                }
            }
            using (var session = sessionFactory.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {

                    session.SaveOrUpdate(inEmployee);
                    transaction.Commit();
                }
            }
            UsersList.Add(inEmployee);
            NotifyObservers();
        }

        public void DeleteEmployee(int inEmployeeId)
        {
            User employee = GetEmployeeById(inEmployeeId);
            using (var session = sessionFactory.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    session.Delete(employee);
                    transaction.Commit();
                }
            }

            UsersList.Remove(employee);
            NotifyObservers();
        }

        public void DeleteEmployee(User inEmployee)
        {
            using (var session = sessionFactory.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    session.Delete(inEmployee);
                    transaction.Commit();
                }
            }

            UsersList.Remove(inEmployee);
            NotifyObservers();
        }

        public Role GetRoleByName(string inRoleName)
        {
            using (var session = sessionFactory.OpenSession())
            {
                Role role = session.QueryOver<Role>().Where(x => x.Name == inRoleName).List<Role>()[0];
                return role;
            }
        }

        public User DoesUserExists(string username, string password)
        {
            using (var session = sessionFactory.OpenSession())
            {
                try
                {
                    User employee = session.QueryOver<User>()
                        .Where(x => x.Username == username && x.Password == password).List<User>()[0];
                    return employee;
                }
                catch (Exception)
                {
                    throw new UserDoesntExistsException();
                }
            }
        }

        public bool DoesEmployeeExists(string inEmployeeUserName)
        {
            try
            {
                GetEmployeeByUserName(inEmployeeUserName);
                return true;
            }
            catch (EmployeeDoesntExistsException)
            {
                return false;
            }
        }

        #endregion

        //public int CountEmployees()
        //{
        //    return UsersList.Count(x => x.Role.RoleId == (int)Rolelist.RoleEnum.Employee);
        //}      
    }
}
