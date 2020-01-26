using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Uow
{
    public interface IUnitOfWork
    {
        void Dispose();
        Task CommitAsync();
        void Commit();
    }
}
