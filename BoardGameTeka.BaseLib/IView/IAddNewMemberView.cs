using BoardGameTeka.Model.Entities;

namespace BoardGameTeka.BaseLib.IView
{
    public interface IAddNewMemberView
    {
        bool ShowViewModal();

        string MemberName { get; }
        int PhoneNumber { get; }
        string MembershipType { get; }
    }
}
