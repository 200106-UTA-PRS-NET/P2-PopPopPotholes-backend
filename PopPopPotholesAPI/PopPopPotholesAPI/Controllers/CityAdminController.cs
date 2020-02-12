﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PopPopLib.UseModels;
using PopPopLib.PPRepos;
using PopPopLib.PPAbstracts;


namespace PopPopPotholesAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CityAdminController : ControllerBase
    {



        private readonly IRepositoryCityAdmin<CityAdmin1> _cityAdminRpo;

        public CityAdminController(IRepositoryCityAdmin<CityAdmin1> cityAdminRepo)
        {
            _cityAdminRpo = cityAdminRepo;
        }



        // GET: api/CityAdmin
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/CityAdmin/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/CityAdmin
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/CityAdmin/5
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
