using FreshVeggies.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FreshVeggies.Infrastructure
{
    public class VeggieRepository : GenericRepository<Veggie>
    {
        private ApplicationDbContext _db;

        public VeggieRepository(ApplicationDbContext db) : base(db) { }
        

        public IQueryable<Veggie> ListVeggies()
        {
            return _db.Veggies;
        }

    }
}
