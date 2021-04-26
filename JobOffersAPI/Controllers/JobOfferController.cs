using JobOffersAPI.Data;
using JobOffersAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobOffersAPI.Controllers
{
    [ApiController]
    [Route("api/joboffer")]
    public class JobOfferController : ControllerBase
    {
        private readonly IJobOffersRepo _repo;
        public JobOfferController(IJobOffersRepo repo)
        {
            _repo = repo;
        }
        [HttpGet]
        public ActionResult<IEnumerable<JobOffer>> GetAllJobOffers()
        {
            var AllJobOffers = _repo.GetAllJobOffers();
            return Ok(AllJobOffers);
        }
        [HttpGet("{id}", Name = "GetJobOffersById")]
        public ActionResult<JobOffer> GetJobOffersById(int id)
        {
            var JobOffer = _repo.GetJobOfferById(id);
            if (JobOffer != null)
            {
                return Ok(JobOffer);
            }
            return NotFound();
        }
        [HttpPost]
        public ActionResult CreateJobOffer(JobOffer NewJobOffer)
        {

            _repo.CreateJobOffer(NewJobOffer);
            return CreatedAtRoute(nameof(GetJobOffersById), new { Id = NewJobOffer.Id }, NewJobOffer);
        }
        [HttpDelete("{id}")]
        public ActionResult DeleteJobOffer(int id)
        {
            var offer = _repo.GetJobOfferById(id);
            if(offer==null)
            {
                return NotFound();
            }
            _repo.DeleteJobOffer(offer);
            return NoContent();
        }
        [HttpPut("{id}")]
        public ActionResult UpdateJobOffer(int id,JobOffer UpdatedJobOffer)
        {
            var offer = _repo.GetJobOfferById(id);
            if(offer==null)
            {
                return NotFound();
            }
            _repo.UpdateJobOffer(offer);
            return NoContent();

        }
    }
}
