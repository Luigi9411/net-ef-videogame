using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace net_ef_videogame
{
    [Table("Videogame")]
    [Index(nameof(VideogameId), IsUnique = true)]
    public class Videogame
    {
        public long VideogameId { get; set; }
        public string? Name { get; set; }
        public string? Overview { get; set; }
        public DateTime ReleaseDate { get; set; }
        public long SoftwareHouseId { get; set; }
        public Software_house Software_house { get; set; }
    }
}
