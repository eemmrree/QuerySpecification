using QuerySpecification.Domain.Interfaces;
using QuerySpecification.Domain.QuerySpecification;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace QuerySpecification.Data.Repositories
{
    public abstract class CrudRepo<T> : ICrudRepo<T>
    {

        public T Find(Specification<T> specification)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> FindAll(Specification<T> specification)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> FindAll(Expression<Func<T, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> FindAllAsEntity(Specification<T> specification)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> FindAllAsEntity(Expression<Func<T, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public T FindAsEntity(Specification<T> specification)
        {
            throw new NotImplementedException();
        }
    }
}
