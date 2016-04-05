using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using FreshVeggies.Models;
using FreshVeggies.Infrastructure;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace FreshVeggies.Controllers
{
    [Route("api/[controller]")]
    public class VeggiesController : Controller
    {
        private VeggieRepository _veggieRepo;
        public VeggiesController(VeggieRepository veggieRepo)
        {
            _veggieRepo = veggieRepo;
        }

        // GET: api/values
        [HttpGet]
        public IEnumerable<Veggie> Get()
        {
            return _veggieRepo.ListVeggies().ToList();
        }
    }
}
