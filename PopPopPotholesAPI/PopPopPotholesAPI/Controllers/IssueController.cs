using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PopPopLib.PPAbstracts;
using PopPopLib.UseModels;
using PopPopPotholesAPI.Domain.Models;

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
        [HttpGet("{id}", Name = "GetIssue")]
        public IActionResult Get(int id)
        {
            var issue = _IssueRpo.ReadInIssue().FirstOrDefault(i => i.IssueId == id);
            if (issue != null)
                return Ok(issue);
            else
                return NotFound();
        }

        // POST: api/Issue
        [HttpPost]
        public IActionResult Post([FromBody, Bind("IssueTimeStamp", "IssueType", "Severity", "CityId", "Latitude", "Longitude", "LinkImg", "IssueDescription", "IssueStatus",
            "IssueUpvotes")] Issue1 issue)
        {
            //var issues = _IssueRpo.ReadInIssue().ToList();

            //int newId = issues.Any() ? issues.Max(i => i.IssueId) + 1 : 1;

            //issue.IssueId = newId;
            _IssueRpo.CreateIssue(issue);

            return CreatedAtRoute("Get", /*new { Id = newId },*/ issue);
        }

        // PUT: api/Issue/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Issue1 issue)
        {
            if(_IssueRpo.ReadInIssue().FirstOrDefault(i => i.IssueId == id) is Issue1 oldIssue)
            {
                _IssueRpo.UpdateIssue(oldIssue);

                return NoContent();
            }

            return NotFound();
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _IssueRpo.DeleteIssue(id);
        }
    }
}
