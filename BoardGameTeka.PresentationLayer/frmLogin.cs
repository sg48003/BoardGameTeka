using System;
using System.Windows.Forms;
using BoardGameTeka.BaseLib;
using BoardGameTeka.Controllers;

namespace BoardGameTeka.PresentationLayer
{
    public partial class frmLogin : Form
    {
        private readonly IMainFormController MainController;

        public frmLogin(IMainFormController inController)
        {
            MainController = inController;
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            var username = textBoxUsername.Text;
            var password = textBoxPassword.Text;

            var user = MainController.CheckLogin(username, password);

            if (user != null)
            {
                this.Hide();
            }
            else
            {
                MessageBox.Show("Login failed! Please check your username and password!");
            }
        }
    }
}
