using System;
using System.Collections.Generic;
using System.Text;
using PopPopLib.UseModels;
using PopPopLib.PPAbstracts;
using PopPopPotholesAPI.Domain.Models;
using PopPopLib;
using System.Linq;
using Microsoft.Extensions.Logging;

namespace PopPopLib.PPRepos
{
    public class IssueRepository : IRepositoryIssue<Issue1>
    {
        PopPopPotholesDbContext _PPPDB;
        ILogger<IssueRepository> _logger;

        public IssueRepository(PopPopPotholesDbContext PPPDB, ILogger<IssueRepository> logger)
        {
             _PPPDB = PPPDB;
            _logger = logger;
        }



        public void CreateIssue(Issue1 Issue)
        {
            _PPPDB.Issue.Add(Mappings.MapIssue.Map(Issue));// this will generate insertMapper.Map(customer)

            _PPPDB.SaveChanges();// this will execute the above generate insert query

            // log in behavior for adding in new City Admin
            _logger.LogInformation(3001, "Added new Issue {0} to database", Issue.IssueId);
        }

        public void DeleteIssue(int Id)
        {
            var IX = _PPPDB.Issue.FirstOrDefault(ix => ix.Id == Id);
            if (IX.Id == Id)
            {
                _PPPDB.Remove(IX);
                _PPPDB.SaveChanges();

                // log in behavior for adding in new City Admin
                _logger.LogInformation(3002, "Deleted Issue {0} to database", Id);
            }
            else
            {
                Console.WriteLine($"Issue with id {Id} doesn't exist");

                // log in behavior for adding in new City Admin
                _logger.LogWarning(3201, "Issue {0} doesn't exists in the database", Id);

                return;
            }
        }

        public IEnumerable<Issue1> ReadInIssue()
        {
            var getIssue = from IX in _PPPDB.Issue
                           select Mappings.MapIssue.Map(IX);

            // log in behavior for adding in new City Admin
            _logger.LogInformation(3003, "Get all Issues from database");

            return getIssue;
        }

        public void UpdateIssue(Issue1 Issue)
        {
            if (_PPPDB.Issue.Any(IX=>IX.Id == Issue.IssueId))
            {
                var issue = _PPPDB.Issue.FirstOrDefault(IX =>
                            IX.Id == Issue.IssueId);
                issue.IssueUpvotes += 1;
                _PPPDB.Issue.Update(issue);
                _PPPDB.SaveChanges();
            }

            // log in behavior for adding in new City Admin
            _logger.LogInformation(3004, "Update Issue in database", Issue.IssueId);
        }
    }
}
