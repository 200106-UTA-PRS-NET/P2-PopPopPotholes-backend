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
    public class IssueController : ControllerBase
    {


        private readonly IRepositoryIssue<Issue1> _IssueRpo;

        public IssueController(IRepositoryIssue<Issue1> issueRepo)
        {
            _IssueRpo = issueRepo;
        }



        // GET: api/Issue
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Issue/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Issue
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Issue/5
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
