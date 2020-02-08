using System;

namespace DN.Data
{
    public interface IUnitOfWork : IDisposable
    {
        void Commit();
    }
}
