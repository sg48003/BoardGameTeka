using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BoardGameTeka.BaseLib;
using BoardGameTeka.BaseLib.IView;

namespace BoardGameTeka.PresentationLayer.Member
{
    public partial class frmViewMembers : Form, IShowMemberListView
    {
        private IMainFormController MainController;
        public frmViewMembers()
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
            var memberList = new List<MemberView>();
            foreach (var item in MainController.GetAllMembers())
            {
                var member = new MemberView
                {
                    MemberId = item.MemberId,
                    Name = item.Name,
                    PhoneNumber = item.PhoneNumber,
                    MembershipType = item.MembershipType.Name
                };
                memberList.Add(member);
            }
            dataGridViewMembers.DataSource = memberList;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonDeleteMember_Click(object sender, EventArgs e)
        {
            MemberView selectedMember = (MemberView)dataGridViewMembers.CurrentRow?.DataBoundItem;
            if (selectedMember != null)
            {
                MainController.DeleteMember(selectedMember.MemberId);
                UpdateGrid();
            }
        }

        private void buttonAddMember_Click(object sender, EventArgs e)
        {
            MainController.AddMember();
            UpdateGrid();
        }

        private void buttonRentalHistory_Click(object sender, EventArgs e)
        {
            MemberView selectedMember = (MemberView)dataGridViewMembers.CurrentRow?.DataBoundItem;
            if (selectedMember != null)
            {
                MainController.ShowRentalsByMember(selectedMember.MemberId);
            }
        }
    }
}
