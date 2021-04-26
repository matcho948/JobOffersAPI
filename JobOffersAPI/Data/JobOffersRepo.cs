using JobOffersAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobOffersAPI.Data
{
    public class JobOffersRepo : IJobOffersRepo
    {
        private readonly JobOffersDbContext _context;
        public JobOffersRepo(JobOffersDbContext context)
        {
            _context = context;
        }
        public void CreateJobOffer(JobOffer offer)
        {
            if (offer == null)
            {
                throw new ArgumentNullException(nameof(offer));
            }
            _context.Offers.Add(offer);
            _context.SaveChanges();

        }

        public void DeleteJobOffer(JobOffer offer)
        {
           if(offer==null)
            {
                throw new ArgumentNullException(nameof(offer));
            }
            _context.Offers.Remove(offer);
            _context.SaveChanges();
        }

        public IEnumerable<JobOffer> GetAllJobOffers()
        {
            return _context.Offers.ToList();
        }

        public JobOffer GetJobOfferById(int id)
        {
            return _context.Offers.FirstOrDefault(p=>p.Id ==id);
        }

        public void UpdateJobOffer(JobOffer offer)
        {
            _context.SaveChanges();
        }
    }
}
