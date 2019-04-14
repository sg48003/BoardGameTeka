using BoardGameTeka.Model.Entities;

namespace BoardGameTeka.BaseLib.IView
{
    public interface IAddNewEmployeeView
    {
        bool ShowViewModal();

        string Username { get; }
        string Password { get; }
    }
}
