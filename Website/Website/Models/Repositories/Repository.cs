using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Rae.Website.Models.Repositories
{
    public class Repository<T> where T : class
    {
        private PortfolioContext context;

        protected DbSet<T> dbSet { get; set; }

        public Repository()
        {
            context = new PortfolioContext();
            dbSet = context.Set<T>();
        }

        public Repository(PortfolioContext Context)
        {
            context = Context;
        }

        public virtual List<T> GetAll()
        {
            return dbSet.ToList();
        }

        public virtual T Get(int Id)
        {
            return dbSet.Find(Id);
        }

        public virtual void Add(T Entity)
        {
            dbSet.Add(Entity);
        }
    }
}