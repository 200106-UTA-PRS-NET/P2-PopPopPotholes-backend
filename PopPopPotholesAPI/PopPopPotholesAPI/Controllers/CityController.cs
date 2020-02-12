using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PopPopLib.PPAbstracts;
using PopPopLib.UseModels;

namespace PopPopPotholesAPI.Controllers
{


    [Route("api/[controller]")]
    [ApiController]
    public class CityController : ControllerBase
    {

        private readonly IRepositoryCity<City1> _cityRpo;

        public CityController(IRepositoryCity<City1> cityRepo)
        {
            _cityRpo = cityRepo;
        }


        // GET: api/City
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/City/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/City
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/City/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
