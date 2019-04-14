using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using BoardGameTeka.BaseLib;
using BoardGameTeka.BaseLib.IView;
using BoardGameTeka.Model.Entities;
using BoardGameTeka.Model.Enums_Dictionaries;
using BoardGameTeka.Model.Factory;
using BoardGameTeka.Model.IRepository;

namespace BoardGameTeka.Controllers
{
    public class MemberController
    {
        public List<string> GetMembershipTypes()
        {
            return MembershipTypeList.MembershipTypeDictionary.Select(x => x.Value).ToList();
        }

        public List<Member> GetAllMembers(IMemberRepository memberRepository)
        {
            return memberRepository.GetAllMembers();
        }

        public void ViewMembers(IShowMemberListView inForm, IMainFormController mainController)
        {
            inForm.ShowModaless(mainController);
        }

        public void AddNewMember(IAddNewMemberView inForm, IMemberRepository memberRepository)
        {
            if (inForm.ShowViewModal())
            {
                try
                {
                    string name = inForm.MemberName;
                    int phoneNumber = inForm.PhoneNumber;
                    MembershipType membershipType = memberRepository.GetMembershipTypeByName(inForm.MembershipType);

                    Member newMember = MemberFactory.CreateMember(name, phoneNumber, membershipType);
                    memberRepository.AddMember(newMember);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("EXCEPTION: " + ex.Message);
                    throw;
                }
            }
        }

        public void DeleteMember(int inId, IMemberRepository memberRepository)
        {
            memberRepository.DeleteMember(inId);
        }

    }
}
