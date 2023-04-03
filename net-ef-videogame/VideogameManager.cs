using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace net_ef_videogame
{
    public static class VideogameManager
    {
        public static void InsertVideogame(Videogame videogame) 
        {
            using var db = new VideogameContext();

            db.Videogames.Add(videogame);
            db.SaveChanges();
        }

        public static Videogame? GetById(long id)
        {
            using var db = new VideogameContext();
            return db.Videogames.Find(id);
        }

        public static IEnumerable<Videogame> GetByName(string name)
        {
            using var db = new VideogameContext();
            return db.Videogames.Where(v => v.Name.Contains(name));
        }

        public static void DeleteVideogame(long id)
        {
            using var db = new VideogameContext();

            var vg = db.Videogames.Find(id);

            if (vg is null) return;

            db.Videogames.Remove(vg);
            db.SaveChanges();
        }

        public static void  InsertSoftwareHouse(Software_house software_House) 
        {
            using var db = new VideogameContext();

            db.Software_house.Add(software_House);
            db.SaveChanges();
        }
    }
}
