using System;
using System.Threading.Tasks;
using SchoolApi.Data.Interfaces;

namespace SchoolApi.Data.Transactions
{
    public interface IUow : IDisposable
    {
        IStudentRepository Students { get; }

        Task Commit();
    }
}