using System;
using System.Collections.Generic;
using System.Text;
using PopPopLib.UseModels;
using PopPopLib.PPAbstracts;

namespace PopPopLib.PPRepos
{
    class IssueRepository : IRepositoryIssue<Issue1>
    {
        public IssueRepository()
        {

        }



        public void CreateIssue(Issue1 Issue)
        {
            throw new NotImplementedException();
        }

        public void DeleteIssue(int Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Issue1> ReadInIssue()
        {
            throw new NotImplementedException();
        }

        public void UpdateIssue(Issue1 Issue)
        {
            throw new NotImplementedException();
        }
    }
}
