using BoardGameTeka.MemoryBasedDAL.Repository;
using BoardGameTeka.Model;
using BoardGameTeka.Model.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BoardGameTeka.Test
{
    [TestClass()]
    public class RentalRepositoryTest
    {

        [TestMethod()]
        [ExpectedException(typeof(RentalDoesntExistsException))]
        public void RentalExistsTest()
        {
            RentalRepository repository = new RentalRepository();
            int id = -1;

            repository.GetRentalById(id);
        }

        [TestMethod()]
        public void AddRentalTest()
        {
            MemberRepository memberRepository = new MemberRepository();
            Member member = new Member
            {
                Name = "Test1",
                PhoneNumber = 091220047
            };
            memberRepository.AddMember(member);

            RentalRepository rentalRepository = new RentalRepository();
            Rental expectedRental = new Rental
            {
                Member = member
            };

            var id = rentalRepository.AddRental(expectedRental);
            var actualRental = rentalRepository.GetRentalById(id);

            Assert.AreEqual(expectedRental.Member.Name, actualRental.Member.Name);
            Assert.AreEqual(expectedRental.Member.PhoneNumber, actualRental.Member.PhoneNumber);

            rentalRepository.DeleteRental(actualRental);
            var addedMember = memberRepository.GetMemberByName(member.Name);
            memberRepository.DeleteMember(addedMember);
        }

        [TestMethod()]
        [ExpectedException(typeof(RentalDoesntExistsException))]
        public void RemoveRentalTest()
        {
            MemberRepository memberRepository = new MemberRepository();
            Member member = new Member
            {
                Name = "Test2",
                PhoneNumber = 091220047
            };
            memberRepository.AddMember(member);

            RentalRepository rentalRepository = new RentalRepository();
            Rental expectedRental = new Rental
            {
                Member = member
            };

            var id = rentalRepository.AddRental(expectedRental);
            rentalRepository.DeleteRental(id);

            rentalRepository.GetRentalById(id);

        }

        [TestMethod()]
        public void ReturnRentalTest()
        {
            MemberRepository memberRepository = new MemberRepository();
            Member member = new Member
            {
                Name = "Test2",
                PhoneNumber = 091220047
            };
            memberRepository.AddMember(member);

            RentalRepository rentalRepository = new RentalRepository();
            Rental expectedRental = new Rental
            {
                Member = member
            };

            var id = rentalRepository.AddRental(expectedRental);
            rentalRepository.ReturnRental(id);

            var returnedRental = rentalRepository.GetRentalById(id);

            Assert.IsTrue(returnedRental.DateReturned != null);

        }

        [TestMethod()]
        [ExpectedException(typeof(RentalMemberAlreadyHasARentalException))]
        public void AddRentalMemberAlreadyHasARentalExceptionTest()
        {
            MemberRepository memberRepository = new MemberRepository();
            Member member = new Member
            {
                Name = "Test3",
                PhoneNumber = 091220047
            };
            memberRepository.AddMember(member);

            RentalRepository rentalRepository = new RentalRepository();
            Rental expectedRental = new Rental
            {
                Member = member
            };

            var id = rentalRepository.AddRental(expectedRental);
            rentalRepository.AddRental(expectedRental);

            rentalRepository.DeleteRental(id);
            var addedMember = memberRepository.GetMemberByName(member.Name);
            memberRepository.DeleteMember(addedMember);
        }

    }
}
