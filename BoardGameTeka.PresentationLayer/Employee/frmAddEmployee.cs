using System.Windows.Forms;
using BoardGameTeka.BaseLib.IView;

namespace BoardGameTeka.PresentationLayer
{
    public partial class frmAddEmployee : Form, IAddNewEmployeeView
    {
        public frmAddEmployee()
        {
            InitializeComponent();
        }

        public bool ShowViewModal()
        {
            return ShowDialog() == DialogResult.OK;
        }

        public string Username => textBoxUsername.Text;
        public string Password => textBoxPassword.Text;
    }
}
