using System.Collections.Generic;
using System.Linq;

namespace AngularJS101.Models
{
    public class HeroManager
    {
        readonly List<DotaHero> _heroes = new List<DotaHero>() {
            new DotaHero { ID = 1, Name = "Bristleback", Type="Strength"},
            new DotaHero { ID = 2, Name ="Abbadon", Type="Strength"},
            new DotaHero { ID = 3, Name ="Spectre", Type="Agility"},
            new DotaHero { ID = 4, Name ="Juggernaut", Type="Agility"},
            new DotaHero { ID = 5, Name ="Lion", Type="Intelligence"},
            new DotaHero { ID = 6, Name ="Zeus", Type="Intelligence"},
            new DotaHero { ID = 7, Name ="Trent", Type="Strength"},
        };
        public IEnumerable<DotaHero> GetAll { get { return _heroes; } }

        public List<DotaHero> GetHeroesByType(string type)
        {
            return _heroes.Where(o => o.Type.ToLower().Equals(type.ToLower())).ToList();
        }

        public DotaHero GetHeroByID(int Id)
        {
            return _heroes.Find(o => o.ID == Id);
        }
    }
}