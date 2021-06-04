using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobOffersAPI.Dtos
{
    public class ReadOffer
    {
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public int Salary { get; set; }
        public string Position { get; set; }
        public string Info { get; set; }
    }
}
