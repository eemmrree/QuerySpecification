using QuerySpecification.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace QuerySpecification.Domain.QuerySpecification
{
    public class AllProductSpec : Specification<Product>
    {
        public override Expression<Func<Product, bool>> ToExpression()
        {
            return entity => entity.ProductId > 0;
        }
    }
    public class FindIdProductSpec : Specification<Product>
    {
        private readonly int _productId;
        public FindIdProductSpec(int productId)
        {
            _productId = productId;
        }
        public override Expression<Func<Product, bool>> ToExpression()
        {
            return entity => entity.ProductId == _productId;
        }
    }
    public class InStockProductSpec : Specification<Product>
    {
        public override Expression<Func<Product, bool>> ToExpression()
        {
            return entity => entity.UnitsInStock>0;
        }
    }
    public class FreeProductSpec : Specification<Product>
    {
        public override Expression<Func<Product, bool>> ToExpression()
        {
            return entity => entity.UnitPrice == 0;
        }
    }
}
