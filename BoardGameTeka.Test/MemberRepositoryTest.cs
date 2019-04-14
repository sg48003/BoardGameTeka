using BoardGameTeka.MemoryBasedDAL.Repository;
using BoardGameTeka.Model;
using BoardGameTeka.Model.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BoardGameTeka.Test
{
    [TestClass]
    public class MemberRepositoryTest
    {
        [TestMethod()]
        [ExpectedException(typeof(MemberInvalidNameException))]
        public void AddMemberInvalidNameExceptionTest()
        {
            MemberRepository repository = new MemberRepository();
            Member member = new Member { Name = "" };
            repository.AddMember(member);
        }

        [TestMethod()]
        public void MemberExistsTest()
        {
            MemberRepository repository = new MemberRepository();
            string Name = "nepostojece";

            bool actual = repository.DoesMemberExists(Name);
            Assert.AreEqual(false, actual);
        }

        [TestMethod()]
        public void AddMemberTest()
        {
            MemberRepository repository = new MemberRepository();
            Member expectedMember = new Member
            {
                Name = "Test1",
                PhoneNumber = 091220047
            };
            repository.AddMember(expectedMember);
            var actualMember = repository.GetMemberByName(expectedMember.Name);

            Assert.AreEqual(expectedMember.Name, actualMember.Name);
            Assert.AreEqual(expectedMember.PhoneNumber, actualMember.PhoneNumber);

            repository.DeleteMember(actualMember);
        }

        [TestMethod()]
        public void RemoveMemberTest()
        {
            MemberRepository repository = new MemberRepository();
            Member member = new Member
            {
                Name = "Test5",
                PhoneNumber = 091220047
            };

            repository.AddMember(member);
            repository.DeleteMember(member);

            bool actual = repository.DoesMemberExists(member.Name);
            Assert.AreEqual(false, actual);
        }

    }

    

}
