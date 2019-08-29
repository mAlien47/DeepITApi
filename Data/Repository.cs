
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class Repository<T> : IRepository<T> where T : class, IEntity
    {
        private readonly testEntities _dbContext;
        protected DbSet set;

        public Repository()
        {
            _dbContext = new testEntities();
            set = _dbContext.Set(typeof(T));
            _dbContext.Configuration.LazyLoadingEnabled = false;
        }

        public virtual void Insert(T entity)
        {
            set.Add(entity);
            _dbContext.SaveChanges();
        }

        public virtual void Delete(int id)
        {
            T entity = this.GetById(id);
            var propInfo = entity?.GetType().GetProperty("Active");

            if (propInfo != null)
                propInfo.SetValue(entity, false);
            else
                set.Remove(entity);

            _dbContext.SaveChanges();
        }

        public virtual void Update(T entity)
        {
            _dbContext.Entry(entity).State = EntityState.Modified;
            _dbContext.SaveChanges();
        }

        public virtual T GetById(int id)
        {
            return (T)set.Find(id);
        }

        public virtual IEnumerable<T> List()
        {
            return set.OfType<T>().AsEnumerable();
        }

        public virtual IEnumerable<T> List(Expression<Func<T, bool>> predicate)
        {
            return set.OfType<T>()
                 .Where(predicate)
                 .AsEnumerable();
        }
    }
}
