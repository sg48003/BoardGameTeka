using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BoardGameTeka.BaseLib;
using BoardGameTeka.BaseLib.IView;
using BoardGameTeka.Model.Entities;
using BoardGameTeka.Model.Factory;
using BoardGameTeka.Model.IRepository;

namespace BoardGameTeka.Controllers
{
    public class EmployeeController
    {

        public void ViewEmployees(IShowEmployeeListView inForm, IMainFormController mainController)
        {
            inForm.ShowModaless(mainController);
        }

        public List<User> GetAllEmployees(IUserRepository userRepository)
        {
            return userRepository.GetAllEmployees();
        }

        public void AddNewEmployee(IAddNewEmployeeView inForm, IUserRepository userRepository)
        {
            if (inForm.ShowViewModal())
            {
                try
                {
                    string username = inForm.Username;
                    string password = inForm.Password;

                    User newEmployee = UserFactory.CreateUser(username, password, userRepository.GetRoleByName("Employee"));

                    userRepository.AddEmployee(newEmployee);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("EXCEPTION: " + ex.Message);
                    throw;
                }
            }
        }

        public void DeleteEmployee(int inId, IUserRepository userRepository)
        {
            userRepository.DeleteEmployee(inId);
        }
    }
}
