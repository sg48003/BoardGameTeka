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
    public class RentalRepository : Subject, IRentalRepository
    {
        private static RentalRepository Instance;
        private List<Rental> RentalsList = new List<Rental>();

        private readonly ISessionFactory sessionFactory = Session.CreateSessionFactory();

        public static RentalRepository GetInstance()
        {
            return Instance ?? (Instance = new RentalRepository());
        }

        #region NHibernate napravljen

        public List<Rental> GetAllRentals()
        {
            using (var session = sessionFactory.OpenSession())
            {
                using (session.BeginTransaction())
                {
                    RentalsList = session
                        .CreateCriteria(typeof(Rental))
                        .List<Rental>()
                        .ToList();
                }
            }
            return RentalsList;
        }

        public List<Rental> GetNotReturnedRentals()
        {
            List<Rental> rentalList;
            using (var session = sessionFactory.OpenSession())
            {
                using (session.BeginTransaction())
                {
                    rentalList = session.QueryOver<Rental>()
                        .Where(x => x.DateReturned == null)
                        .List<Rental>()
                        .ToList();
                }
            }
            return rentalList;
        }

        public List<Rental> GetNotReturnedRentalsByMember(Member inMember)
        {
            List<Rental> rentalList;
            using (var session = sessionFactory.OpenSession())
            {
                using (session.BeginTransaction())
                {
                    rentalList = session.QueryOver<Rental>()
                        .Where(x => x.DateReturned == null && x.Member == inMember)
                        .List<Rental>()
                        .ToList();
                }
            }
            return rentalList;
        }

        public Rental GetRentalById(int inRentalId)
        {
            using (var session = sessionFactory.OpenSession())
            {
                try
                {
                    Rental rental = session.QueryOver<Rental>().Where(x => x.RentalId == inRentalId).List<Rental>()[0];
                    return rental;
                }
                catch (Exception)
                {
                    throw new RentalDoesntExistsException();
                }
            }
        }

        public List<Rental> GetRentalsByMember(Member inMember)
        {
            List<Rental> rentalList;
            using (var session = sessionFactory.OpenSession())
            {
                using (session.BeginTransaction())
                {
                    rentalList = session.QueryOver<Rental>()
                        .Where(x => x.Member == inMember)
                        .List<Rental>()
                        .ToList();
                }
            }
            return rentalList;
        }

        public int AddRental(Rental inRental)
        {
            int result;
            List<Rental> rentals = GetNotReturnedRentalsByMember(inRental.Member);
            if (inRental.DateReturned != null)
            {
                throw new RentalDateReturnedExistsWhileAddingNewRentalException();
            }
            if (rentals.Count > 0)
            {
                throw new RentalMemberAlreadyHasARentalException();

            }
            inRental.BoardGames = inRental.BoardGames.Distinct().ToList();

            using (var session = sessionFactory.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    result = (int)session.Save(inRental);
                    transaction.Commit();
                    
                }
            }
            NotifyObservers();
            return result;
        }

        public void DeleteRental(int inRentalId)
        {
            Rental rental = GetRentalById(inRentalId);
            using (var session = sessionFactory.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    session.Delete(rental);
                    transaction.Commit();
                }
            }
            NotifyObservers();
        }

        public void DeleteRental(Rental inRental)
        {
            using (var session = sessionFactory.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    session.Delete(inRental);
                    transaction.Commit();
                }
            }
            NotifyObservers();
        }

        public void ReturnRental(int inRentalId)
        {
            var rental = GetRentalById(inRentalId);
            rental.DateReturned = DateTime.Now.Date;
            using (var session = sessionFactory.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    session.SaveOrUpdate(rental);
                    transaction.Commit();
                }
            }
            NotifyObservers();
        }

        #endregion

        //public List<Rental> GetRentalsByBoardGame(BoardGame inBoardGame)
        //{
        //    var rentalList = RentalsList.Where(x => x.BoardGames.Contains(inBoardGame)).ToList();
        //    return rentalList;
        //}

        //public List<Rental> GetRentalsByEmployee(User inEmployee)
        //{
        //    var rentalList = RentalsList.Where(x => x.Employee == inEmployee).ToList();
        //    return rentalList;
        //}

        //public List<Rental> GetRentalsByDateRented(DateTime inDateRented)
        //{
        //    var rentalList = RentalsList.Where(x => x.DateRented == inDateRented).ToList();
        //    return rentalList;
        //}

        //public int Count()
        //{
        //    return RentalsList.Count;
        //}


    }
}
