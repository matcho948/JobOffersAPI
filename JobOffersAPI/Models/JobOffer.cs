using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace JobOffersAPI.Models
{
    public class JobOffer
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string CompanyName { get; set; }
        [Required]
        public int Salary { get; set; }
        [Required]
        public string Position { get; set; }
        [Required]
        [MaxLength(250)]
        public string Info { get; set; }
    }
}
