using AutoMapper;
using JobOffersAPI.Data;
using JobOffersAPI.Dtos;
using JobOffersAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobOffersAPI.Controllers
{
    [Route("api/joboffer")]
    [ApiController]
    public class JobOfferController : ControllerBase
    {
        private readonly IJobOffersRepo _repo;
        private readonly IMapper _mapper;
        public JobOfferController(IJobOffersRepo repo,IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }
        [HttpGet]
        public ActionResult<IEnumerable<ReadOffer>> GetAllJobOffers()
        {
            var AllJobOffers = _repo.GetAllJobOffers();

            return Ok(_mapper.Map<IEnumerable<ReadOffer>>(AllJobOffers));
        }
        [HttpGet("{id}", Name = "GetJobOffersById")]
        public ActionResult<ReadOffer> GetJobOffersById(int id)
        {
            var JobOffer = _repo.GetJobOfferById(id);
            if (JobOffer != null)
            {
                return Ok(_mapper.Map<ReadOffer>(JobOffer));
            }
            return NotFound();
        }
        [HttpPost]
        public ActionResult CreateJobOffer(CreateOffer NewJobOffer)
        {
            var COffer = _mapper.Map<JobOffer>(NewJobOffer);
            _repo.CreateJobOffer(COffer);
            var Offer = _mapper.Map<ReadOffer>(COffer);
            return CreatedAtRoute(nameof(GetJobOffersById), new { Id = Offer.Id }, Offer);
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
        public ActionResult UpdateJobOffer(int id,UpdateOffer UpdatedJobOffer)
        {
            var offer = _repo.GetJobOfferById(id);
            if(offer==null)
            {
                return NotFound();
            }

            offer = _mapper.Map<JobOffer>(UpdatedJobOffer);
            _repo.UpdateJobOffer(offer);
            return NoContent();

        }
    }
}
