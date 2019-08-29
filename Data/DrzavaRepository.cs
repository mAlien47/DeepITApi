using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class DrzavaRepository : Repository<Drzava>
    {
        public override IEnumerable<Drzava> List(Expression<Func<Drzava, bool>> predicate)
        {
            return base.List(predicate);
        }
    }
}
