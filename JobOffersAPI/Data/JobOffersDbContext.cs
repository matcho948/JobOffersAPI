using JobOffersAPI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobOffersAPI.Data
{
    public class JobOffersDbContext :DbContext
    {
        public JobOffersDbContext(DbContextOptions<JobOffersDbContext> options):base(options)
        {

        }
        public DbSet<JobOffer> Offers { get; set; }
    }
}
