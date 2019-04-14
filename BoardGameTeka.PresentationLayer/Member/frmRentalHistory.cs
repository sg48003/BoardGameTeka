using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BoardGameTeka.BaseLib;
using BoardGameTeka.BaseLib.IView;

namespace BoardGameTeka.PresentationLayer.Member
{
    public partial class frmRentalHistory : Form, IShowRentalHistoryView
    {
        private IMainFormController MainController;
        private Model.Entities.Member Member;

        public frmRentalHistory()
        {
            InitializeComponent();
        }

        public void ShowModaless(IMainFormController inMainController, Model.Entities.Member inMember)
        {
            MainController = inMainController;
            Member = inMember;
            UpdateGrid();

            this.Show();
        }

        private void UpdateGrid()
        {
            var rentalList = new List<RentalHistoryView>();
            foreach (var item in MainController.GetAllRentalsByMembers(Member))
            {
                string boardGames = "";
                foreach (var boardGame in item.BoardGames)
                {
                    boardGames += boardGame.Name + ",";
                }
                var rental = new RentalHistoryView
                {
                    RentalId = item.RentalId,
                    EmployeeUsername = item.Employee.Username,
                    BoardGames = boardGames.Remove(boardGames.Length - 1),
                    DateRented = item.DateRented,
                    DateReturned = item.DateReturned
                };
                rentalList.Add(rental);
            }
            dataGridViewRentalHistory.DataSource = rentalList;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
