using DN.Data.DataContext;

namespace DN.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private DNContext _context;

        public UnitOfWork(DNContext context)
            => _context = context;

        public void Commit()
            => _context.SaveChanges();

        public void Dispose()
            => Dispose(true);

        private void Dispose(bool disposing)
        {
            if (disposing)
            {
                if(_context != null)
                {
                    _context.Dispose();
                    _context = null;
                }
            }
        }
            

    }
}
