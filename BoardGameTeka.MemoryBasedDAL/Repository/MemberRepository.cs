using System;
using System.Collections.Generic;
using System.Linq;
using BoardGameTeka.BaseLib;
using BoardGameTeka.Model;
using BoardGameTeka.Model.Entities;
using BoardGameTeka.Model.IRepository;
using BoardGameTeka.Model.NHibernate;
using NHibernate;

namespace BoardGameTeka.MemoryBasedDAL.Repository
{
    public class MemberRepository : Subject, IMemberRepository
    {
        private static MemberRepository Instance;
        private List<Member> MembersList = new List<Member>();

        private readonly ISessionFactory sessionFactory = Session.CreateSessionFactory();

        public static MemberRepository GetInstance()
        {
            return Instance ?? (Instance = new MemberRepository());
        }

        #region NHibernate napravljen

        public List<Member> GetAllMembers()
        {
            using (var session = sessionFactory.OpenSession())
            {
                using (session.BeginTransaction())
                {
                    MembersList = session
                        .CreateCriteria(typeof(Member))
                        .List<Member>()
                        .ToList();
                }
            }
            return MembersList;
        }

        public Member GetMemberById(int inMemberId)
        {
            using (var session = sessionFactory.OpenSession())
            {
                try
                {
                    Member member = session.QueryOver<Member>().Where(x => x.MemberId == inMemberId).List<Member>()[0];
                    return member;
                }
                catch (Exception)
                {
                    throw new MemberDoesntExistsException();
                }                            
            }
        }

        public Member GetMemberByName(string inMemberName)
        {
            using (var session = sessionFactory.OpenSession())
            {
                try
                {
                    Member member = session.QueryOver<Member>().Where(x => x.Name == inMemberName).List<Member>()[0];
                    return member;
                }
                catch (Exception)
                {
                    throw new MemberDoesntExistsException();
                }
            }
        }

        public void AddMember(Member inMember)
        {
            if (string.IsNullOrEmpty(inMember.Name))
            {
                throw new MemberInvalidNameException();
            }
            if (inMember.PhoneNumber == 0)
            {
                throw new MemberInvalidPhoneNumberException();
            }

            foreach (Member currentMember in MembersList)
            {
                if (currentMember.Name.Equals(inMember.Name))
                {
                    throw new MemberWithThatNameExistsException();
                }
                if (currentMember.PhoneNumber.Equals(inMember.PhoneNumber))
                {
                    throw new MemberWithThatPhoneNumberExistsException();
                }
            }

            using (var session = sessionFactory.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {

                    session.SaveOrUpdate(inMember);
                    transaction.Commit();
                }
            }

            MembersList.Add(inMember);
            NotifyObservers();
        }

        public void DeleteMember(Member inMember)
        {
            using (var session = sessionFactory.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    session.Delete(inMember);
                    transaction.Commit();
                }
            }

            MembersList.Remove(inMember);
            NotifyObservers();
        }

        public void DeleteMember(int inMemberId)
        {
            Member member = GetMemberById(inMemberId);
            using (var session = sessionFactory.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    session.Delete(member);
                    transaction.Commit();
                }
            }

            MembersList.Remove(member);
            NotifyObservers();
        }

        public MembershipType GetMembershipTypeByName(string inMembershipTypeName)
        {
            using (var session = sessionFactory.OpenSession())
            {
                MembershipType membershipType = session.QueryOver<MembershipType>().Where(x => x.Name == inMembershipTypeName).List<MembershipType>()[0];
                return membershipType;
            }
        }

        public bool DoesMemberExists(string inMemberName)
        {
            try
            {
                GetMemberByName(inMemberName);
                return true;
            }
            catch (MemberDoesntExistsException)
            {
                return false;
            }
        }

        #endregion

        //public int Count()
        //{
        //    return MembersList.Count;
        //}

        //public Member GetMemberByPhoneNumber(int inPhoneNumber)
        //{
        //    var member = MembersList.FirstOrDefault(x => x.PhoneNumber == inPhoneNumber);

        //    if (member == null)
        //    {
        //        throw new MemberDoesntExistsException();
        //    }

        //    return member;
        //}

        //public List<Member> GetAllMembersOfType(MembershipType inMembershipType)
        //{
        //    var memberList = MembersList.Where(x => x.MembershipType == inMembershipType).ToList();
        //    return memberList;
        //}
      
    }
}

