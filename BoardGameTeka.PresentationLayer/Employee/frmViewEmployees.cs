using System;
using System.Windows.Forms;
using BoardGameTeka.BaseLib;
using BoardGameTeka.BaseLib.IView;
using BoardGameTeka.Model.Entities;

namespace BoardGameTeka.PresentationLayer.Employee
{
    public partial class frmViewEmployees : Form, IShowEmployeeListView
    {
        private IMainFormController MainController;
        public frmViewEmployees()
        {
            InitializeComponent();
        }

        public void ShowModaless(IMainFormController inMainController)
        {
            MainController = inMainController;

            UpdateGrid();

            this.Show();
        }

        private void UpdateGrid()
        {
            dataGridViewEmployees.DataSource = MainController.GetAllEmployees();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonDeleteEmployee_Click(object sender, EventArgs e)
        {
            User selectedUser = (User) dataGridViewEmployees.CurrentRow?.DataBoundItem;
            if (selectedUser != null)
            {
                MainController.DeleteEmployee(selectedUser.UserId);
                UpdateGrid();
            }
        }

        private void buttonAddEmployee_Click(object sender, EventArgs e)
        {
            MainController.AddEmployee();
            UpdateGrid();
        }
    }
}
