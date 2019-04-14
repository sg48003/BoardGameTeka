using System.Windows.Forms;
using BoardGameTeka.BaseLib;
using BoardGameTeka.BaseLib.IView;
using BoardGameTeka.Controllers;
using BoardGameTeka.Model.Enums_Dictionaries;

namespace BoardGameTeka.PresentationLayer
{
    public partial class frmMainWindow : Form, IShowMainWindowView
    {
        private IMainFormController MainController;
        public frmMainWindow()
        {
            InitializeComponent();
        }

        public void ShowModaless(IMainFormController inMainController)
        {
            MainController = inMainController;
            InitializeForm();
            this.Show();
        }

        private void InitializeForm()
        {
            if (GlobalVariables.CurrentUser.Role.RoleId == (int) Rolelist.RoleEnum.Employee)
            {
                employeesToolStripMenuItem.Visible = false;
                addBoardGameToolStripMenuItem.Visible = false;
            }
        }

        private void viewBoardGamesToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            MainController.ShowBoardGames();
        }

        private void addBoardGameToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            MainController.AddBoardGame();
        }

        private void viewMembersToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            MainController.ShowMembers();
        }

        private void addMemberToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            MainController.AddMember();
        }

        private void viewEmployeesToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            MainController.ShowEmployees();
        }

        private void addEmployeeToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            MainController.AddEmployee();
        }

        private void viewActiveRentalsToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            MainController.ShowActiveRentals();
        }

        private void addRentalToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            MainController.AddRental();
        }

        private void frmMainWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
