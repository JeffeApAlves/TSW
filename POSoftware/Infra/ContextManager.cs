using POSoftware.Infra;
using System.Data.Entity;

namespace Tyco.Infra.Repositories
{
    public class ContextManager
    {
        /// <summary>
        /// gerencia a criacao do objeto(singleton) Context entities do DB
        /// </summary>

        private TycoDBEntities _context = null;

        public DbContext Context
        {
            get
            {
                if (_context == null)
                {
                    _context = new TycoDBEntities();
                }

                return _context;
            }
        }
    }
}
