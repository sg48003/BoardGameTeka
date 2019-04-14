using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BoardGameTeka.BaseLib.IView;

namespace BoardGameTeka.PresentationLayer.Member
{
    public partial class frmAddMember : Form, IAddNewMemberView
    {
        private readonly List<string> membershipTypes;

        public string MemberName => textBoxName.Text;
        public int PhoneNumber
        {
            get
            {
                if (int.TryParse(textBoxPhoneNumber.Text, out var phoneNumberValue))
                {
                    return phoneNumberValue;
                }

                throw new ArgumentException();
            }
        }

        public string MembershipType => comboBoxMembershipType.SelectedItem.ToString();

        public frmAddMember(List<string> inMembershipTypes, Model.Entities.Member inMember = null)
        {
            membershipTypes = inMembershipTypes;

            InitializeComponent();
            if (inMember != null)
            {
                textBoxName.Text = inMember.Name;
                textBoxPhoneNumber.Text = inMember.PhoneNumber.ToString();
                comboBoxMembershipType.SelectedItem = inMember.MembershipType.MembershipTypeId;
            }
        }

        public bool ShowViewModal()
        {
            return ShowDialog() == DialogResult.OK;
        }


        private void frmAddMember_Load(object sender, EventArgs e)
        {
            foreach (string gameType in membershipTypes)
            {
                comboBoxMembershipType.Items.Add(gameType);
            }
        }

    }
}
