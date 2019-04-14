using BoardGameTeka.MemoryBasedDAL.Repository;
using BoardGameTeka.Model;
using BoardGameTeka.Model.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BoardGameTeka.Test
{
    [TestClass]
    public class UserRepositoryTest
    {
        [TestMethod()]
        [ExpectedException(typeof(EmployeeInvalidUsernameException))]
        public void AddEmployeeInvalidNameExceptionTest()
        {
            UserRepository repository = new UserRepository();
            User employee = new User { Username = "" };
            repository.AddEmployee(employee);
        }

        [TestMethod()]
        [ExpectedException(typeof(UserDoesntExistsException))]
        public void UserExistsTest()
        {
            UserRepository repository = new UserRepository();
            string Username = "nepostojece";
            string Password = "nepostojece";

            repository.DoesUserExists(Username, Password);
        }

        [TestMethod()]
        public void AddEmployeeTest()
        {
            UserRepository repository = new UserRepository();
            Role role = repository.GetRoleByName("Employee");
            User expectedEmployee = new User
            {
                Username = "Test1",
                Password = "Test1",
                Role = role
            };
            repository.AddEmployee(expectedEmployee);
            var actualEmployee = repository.GetUserByUserName(expectedEmployee.Username);

            Assert.AreEqual(expectedEmployee.Username, actualEmployee.Username);
            Assert.AreEqual(expectedEmployee.Password, actualEmployee.Password);

            repository.DeleteEmployee(actualEmployee);
        }

        [TestMethod()]
        [ExpectedException(typeof(UserDoesntExistsException))]
        public void RemoveEmployeeTest()
        {
            UserRepository repository = new UserRepository();
            Role role = repository.GetRoleByName("Employee");
            User employee = new User
            {
                Username = "Test2",
                Password = "Test2",
                Role = role
            };

            repository.AddEmployee(employee);
            repository.DeleteEmployee(employee);

            repository.DoesUserExists(employee.Username, employee.Password);
        }

    }
}
