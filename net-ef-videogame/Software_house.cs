using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace net_ef_videogame
{
    [Table("Software_house")]
    public class Software_house
    {
        public Software_house(string? name, long taxId, string? city, string? country)
        {
            Name = name;
            TaxId = taxId;
            City = city;
            Country = country;
        }

        public long Id { get; set; }
        public string? Name { get; set; }
        public long TaxId { get; set; }
        public string? City { get; set; }
        public string? Country { get; set; }
        public IEnumerable<Software_house> Videogames { get; set; }= Enumerable.Empty<Software_house>();
    }
}
