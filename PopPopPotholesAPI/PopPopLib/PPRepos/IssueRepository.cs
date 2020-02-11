using System;
using System.Collections.Generic;
using System.Text;
using PopPopLib.UseModels;
using PopPopLib.PPAbstracts;
using PopPopPotholesAPI.Domain.Models;
using PopPopLib;
using System.Linq;

namespace PopPopLib.PPRepos
{
    class IssueRepository : IRepositoryIssue<Issue1>
    {
        PopPopPotholesDbContext _PPPDB;
        public IssueRepository(PopPopPotholesDbContext PPPDB)
        {
             _PPPDB = PPPDB;
        }



        public void CreateIssue(Issue1 Issue)
        {
            _PPPDB.Issue.Add(Mappings.MapIssue.Map(Issue));// this will generate insertMapper.Map(customer)
            _PPPDB.SaveChanges();// this will execute the above generate insert query
        }

        public void DeleteIssue(int Id)
        {
            var IX = _PPPDB.Issue.FirstOrDefault(ix => ix.Id == Id);
            if (IX.Id == Id)
            {
                _PPPDB.Remove(IX);
                _PPPDB.SaveChanges();
            }
            else
            {
                Console.WriteLine($"Issue with id {Id} doesn't exist");
                return;
            }
        }

        public IEnumerable<Issue1> ReadInIssue()
        {
            var getIssue = from IX in _PPPDB.Issue
                           select Mappings.MapIssue.Map(IX);
            return getIssue;
        }

        public void UpdateIssueCount(Issue1 Issue)
        {
            if (_PPPDB.Issue.Any(IX=>IX.Id == Issue.IssueId))
            {
                var issue = _PPPDB.Issue.FirstOrDefault(IX =>
                            IX.Id == Issue.IssueId);
                issue.Upvotes += 1;
                _PPPDB.Issue.Update(issue);
                _PPPDB.SaveChanges();
            }
        }
    }
}
