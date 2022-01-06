using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace QuerySpecification.Domain.Interfaces
{
    public interface IRepo<T>
    {
        IEnumerable<T> All();
        T Find(Expression<Func<T, bool>> expression);
        T Get(int id);
        void Rollback(T entity);
    }
}
