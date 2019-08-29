using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public abstract class BllBase<T> : IRepository<T> where T : class, IEntity
    {
        protected Repository<T> dal;
        public void Delete(int id)
        {
            this.dal.Delete(id);
        }

        public virtual T GetById(int id)
        {
            return this.dal.GetById(id);
        }

        public virtual void Insert(T entity)
        {
            this.dal.Insert(entity);
        }

        public virtual IEnumerable<T> List()
        {
            return this.dal.List();
        }

        public virtual IEnumerable<T> List(Expression<Func<T, bool>> predicate)
        {
            return this.dal.List(predicate);
        }

        public virtual void Update(T entity)
        {
            this.dal.Update(entity);
        }
    }
}
