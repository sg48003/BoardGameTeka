using System.Collections.Generic;
using System.Windows.Forms;
using BoardGameTeka.BaseLib;
using BoardGameTeka.BaseLib.IView;

namespace BoardGameTeka.PresentationLayer.Rental
{
    public partial class frmViewActiveRentals : Form, IShowActiveRentalListView
    {
        private IMainFormController MainController = null;

        public frmViewActiveRentals()
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
            var activeRentalsList = new List<ActiveRentalView>();
            foreach (var item in MainController.GetAllActiveRentals())
            {
                string boardGames = "";
                foreach (var boardGame in item.BoardGames)
                {
                    boardGames += boardGame.Name + ",";
                }

                var rental = new ActiveRentalView
                {
                    RentalId = item.RentalId,
                    MemberName = item.Member.Name,
                    BoardGames = boardGames.Remove(boardGames.Length-1),
                    EmployeeUsername = item.Employee?.Username,
                    DateRented = item.DateRented
                };
                activeRentalsList.Add(rental);
            }
            dataGridViewActiveRentals.DataSource = activeRentalsList;
        }

        private void buttonAddRental_Click(object sender, System.EventArgs e)
        {
            MainController.AddRental();
            UpdateGrid();
        }

        private void buttonClose_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void buttonReturnRental_Click(object sender, System.EventArgs e)
        {
            ActiveRentalView selectedRentalView = (ActiveRentalView)dataGridViewActiveRentals.CurrentRow?.DataBoundItem;
            if (selectedRentalView != null)
            {
                MainController.ReturnRental(selectedRentalView.RentalId);
                UpdateGrid();
            }
        }
    }
}
