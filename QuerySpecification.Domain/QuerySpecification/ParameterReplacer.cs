using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace QuerySpecification.Domain.QuerySpecification
{
    internal class ParameterReplacer : ExpressionVisitor
    {
        private readonly ParameterExpression _parameter;
        protected override Expression VisitParameter(ParameterExpression param) => base.VisitParameter(_parameter);
        internal ParameterReplacer(ParameterExpression param)
        {
            _parameter = param;
        }
    }    
}


