using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFRepository
{
    public class UnitOfWork : IDisposable
    {
        private Model.ScoolDBEntities context = new Model.ScoolDBEntities();
        private GenericRepository<Model.Student> _studentRepository;

        public GenericRepository<Model.Student> StudentRepository
        {
            get
            {
                if (this._studentRepository == null)
                {
                    this._studentRepository = new GenericRepository<Model.Student>(context);
                }
                return _studentRepository;
            }
        }
        public void Save()
        {
            context.SaveChanges();
        }

        private bool _disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this._disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this._disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);

        }
    }
}
