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
        public long Id { get; set; }
        public string? Name { get; set; }
        public long Tax_id { get; set; }
        public string? City { get; set; }
        public string? Country { get; set; }
        public List<Software_house> Videogames { get; set; }
    }
}
