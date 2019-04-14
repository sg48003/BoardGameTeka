using System;
using System.Windows.Forms;
using BoardGameTeka.Controllers;
using BoardGameTeka.MemoryBasedDAL.Repository;
using BoardGameTeka.PresentationLayer;

namespace BoardGameTeka
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            WindowsFormsFactory formsFactory = new WindowsFormsFactory();

            MainFormController mainController = new MainFormController(formsFactory, 
                                                        BoardGameRepository.GetInstance(), 
                                                        MemberRepository.GetInstance(), 
                                                        UserRepository.GetInstance(), RentalRepository.GetInstance());

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmLogin(mainController));
        }
    }
}
