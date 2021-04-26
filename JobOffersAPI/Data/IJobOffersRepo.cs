using JobOffersAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobOffersAPI.Data
{
    public interface IJobOffersRepo
    {
        public IEnumerable<JobOffer> GetAllJobOffers();
        public JobOffer GetJobOfferById(int id);
        public void CreateJobOffer(JobOffer offer);
        public void DeleteJobOffer(JobOffer offer);
        public void UpdateJobOffer(JobOffer offer);
    }
}
