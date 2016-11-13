using SWTest.Data.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWTest.Data.Repositories
{
    public class Repository<TEntity> : IDisposable where TEntity : class
    {
        private DbContext context;

        public Repository()
        {
            this.context = new EntityContext();
        }

        public IQueryable<TEntity> GetAll()
        {
            return this.context.Set<TEntity>();
        }

        public void Dispose()
        {
            this.context.Dispose();
        }
    }
}
