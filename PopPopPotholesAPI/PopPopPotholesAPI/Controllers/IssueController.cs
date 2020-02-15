using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
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
        private readonly ILogger<IssueController> _logger;

        public IssueController(IRepositoryIssue<Issue1> issueRepo, ILogger<IssueController> logger)
        {
            _IssueRpo = issueRepo;
            _logger = logger;
        }

        // GET: api/Issue
        [HttpGet]
        public IEnumerable<Issue1> Get()
        {
            // log in behavior for adding in new City Admin
            _logger.LogInformation("\n 5001 Get all Issues from database {Time}\n", DateTime.UtcNow);

            return _IssueRpo.ReadInIssue().ToList();
            //return new string[] { "value1", "value2" };
        }

        // GET: api/Issue/5
        [HttpGet("{id}", Name = "GetIssue")]
        public IActionResult Get(int id)
        {
            var issue = _IssueRpo.ReadInIssue().FirstOrDefault(i => i.IssueId == id);
            if (issue != null)
            {
                // log in behavior for adding in new City Admin
                _logger.LogInformation("\n 5002 Get Issue By ID {Time}\n", DateTime.UtcNow);

                return Ok(issue);
            }
            else
            {
                // log in behavior for adding in new City Admin
                _logger.LogInformation("\n 5001 No Issue with ID: {0} found in database. {Time}\n", id, DateTime.UtcNow);

                return NotFound();
            }
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

            // log in behavior for adding in new City Admin
            _logger.LogInformation("\n{0} Post Issues to database {1} : {Time}\n", 5003, issue.IssueTimeStamp, DateTime.UtcNow);

            return CreatedAtRoute("Get", /*new { Id = newId },*/ issue);
        }

        // PUT: api/Issue/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Issue1 issue)
        {
            if(_IssueRpo.ReadInIssue().FirstOrDefault(i => i.IssueId == id) is Issue1 oldIssue)
            {
                _IssueRpo.UpdateIssue(oldIssue);

                // log in behavior for adding in new City Admin
                _logger.LogInformation("\n{0} Put Issue into database {Time}\n", 5004, DateTime.UtcNow);

                return NoContent();
            }

            // log in behavior for adding in new City Admin
            _logger.LogWarning("\n{0} Could not Put issue into Database {1} : {Time}\n",5201, issue.IssueTimeStamp, DateTime.UtcNow);

            return NotFound();
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _IssueRpo.DeleteIssue(id);

            // log in behavior for adding in new Issue
            _logger.LogInformation("\n {0} Deleted Issue from Database {Time}\n", 5005, DateTime.UtcNow);
        }
    }
}
