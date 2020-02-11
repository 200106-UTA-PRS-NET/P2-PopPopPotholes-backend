using System;
using System.Collections.Generic;
using System.Text;

namespace PopPopLib.PPAbstracts
{
    public interface IRepositoryIssue<T>
    {
        IEnumerable<T> ReadInIssue();
        void CreateIssue(T Issue);
        void UpdateIssue(T Issue);
        void DeleteIssue(int Id);
    }
}
