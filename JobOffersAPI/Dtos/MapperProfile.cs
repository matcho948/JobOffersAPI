using AutoMapper;
using JobOffersAPI.Models;
using JobOffersAPI.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobOffersAPI.Dtos
{
    public class MapperProfile :Profile
    {
        public MapperProfile()
        {
            CreateMap<JobOffer, ReadOffer>();
            CreateMap<CreateOffer, JobOffer>();
            CreateMap<UpdateOffer, JobOffer>();
        }
    }
}
