using System.Collections.Generic;
using BoardGameTeka.Model.Entities;

namespace BoardGameTeka.Model.IRepository
{
    public interface IMemberRepository
    {
        Member GetMemberById(int inMemberId);
        Member GetMemberByName(string inMemberName);
        //Member GetMemberByPhoneNumber(int inPhoneNumber);
        List<Member> GetAllMembers();
        //List<Member> GetAllMembersOfType(MembershipType inMembershipType);
        //int Count();
        bool DoesMemberExists(string inMemberName);
        void AddMember(Member inMember);
        void DeleteMember(int inMemberId);
        void DeleteMember(Member inMember);
        MembershipType GetMembershipTypeByName(string inMembershipTypeName);
    }
}
