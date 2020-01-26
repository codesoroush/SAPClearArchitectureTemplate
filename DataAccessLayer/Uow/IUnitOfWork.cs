using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Uow
{
    public interface IUnitOfWork
    {
        void Dispose();
        Task CommitAsync();
        void Commit();
    }
}
