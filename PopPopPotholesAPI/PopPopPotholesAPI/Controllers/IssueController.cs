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
        public IEnumerable<Issue1> Get()
        {
            return _IssueRpo.ReadInIssue().ToList();
            //return new string[] { "value1", "value2" };
        }

        // GET: api/Issue/5
        [HttpGet("{id}", Name = "Get")]
        public Issue1 Get(int id)
        {
            var issue = _IssueRpo.ReadInIssue().ToList();
            return issue.FirstOrDefault(e=>e.IssueId == id);
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
            _IssueRpo.DeleteIssue(id);
        }
    }
}
