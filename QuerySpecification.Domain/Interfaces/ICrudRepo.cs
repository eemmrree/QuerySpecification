using QuerySpecification.Domain.QuerySpecification;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace QuerySpecification.Domain.Interfaces
{
    public interface ICrudRepo<T>
    {
        T Find(Specification<T> specification);
        T FindAsEntity(Specification<T> specification);
        IEnumerable<T> FindAll(Specification<T> specification);
        IEnumerable<T> FindAllAsEntity(Specification<T> specification);
        IEnumerable<T> FindAll(Expression<Func<T,bool>> expression);
        IEnumerable<T> FindAllAsEntity(Expression<Func<T,bool>> expression);
    }
}
