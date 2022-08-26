using Data.Context;
using Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository
{
    public class AnimalRepository : BaseRepository<Animal>
    {
        public override List<Animal> GetAll()
        {
            List<Animal> list = new List<Animal>();

            using (WarrenContext warrenContext = new WarrenContext())
            {
                list = warrenContext.Animal.ToList();
            }
            
            return list;
        }
    }
}
