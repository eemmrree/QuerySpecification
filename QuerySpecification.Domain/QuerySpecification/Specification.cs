using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace QuerySpecification.Domain.QuerySpecification
{
    public abstract class Specification<T>
    {
        public abstract Expression<Func<T, bool>> ToExpression();

        internal Expression<Func<T, bool>> _expression;

        public Expression<Func<T, bool>> GetExpression()
        {
            if (this._expression == null)
                this._expression = this.ToExpression();
            return this._expression;
        }

        public List<Expression<Func<T, object>>> Includes { get; } = new List<Expression<Func<T, object>>>();

        public Specification<T> And(Specification<T> specification)
        {
            return null;
        }

        public Specification<T> Or(Specification<T> specification)
        {
            return null;
        }
    }

    public class AndSpecification<T> : Specification<T>
    {
        private readonly Specification<T> _left;
        private readonly Specification<T> _right;

        public AndSpecification(Specification<T> left, Specification<T> right)
        {
            _right = right;
            _left = left;
            _expression = left.GetExpression().And<T>(_right.GetExpression());
        }

        public override Expression<Func<T, bool>> ToExpression()
        {
            var leftexpression = _left.ToExpression();
            var rightexpression = _right.ToExpression();

            var paramExpression = Expression.Parameter(typeof(T));
            var expressionBody = Expression.AndAlso(leftexpression.Body, rightexpression.Body);
            expressionBody = (BinaryExpression)new ParameterReplacer(paramExpression).Visit(expressionBody);
            var finalExpression = Expression.Lambda<Func<T, bool>>(expressionBody, paramExpression);

            return finalExpression;
        }
    }

    public class OrSpecification<T> : Specification<T>
    {
        private readonly Specification<T> _left;
        private readonly Specification<T> _right;

        public OrSpecification(Specification<T> left, Specification<T> right)
        {
            _right = right;
            _left = left;
            _expression = left.GetExpression().Or<T>(_right.GetExpression());
        }

        public override Expression<Func<T, bool>> ToExpression()
        {
            var leftexpression = _left.ToExpression();
            var rightexpression = _right.ToExpression();

            var paramExpression = Expression.Parameter(typeof(T));
            var expressionBody = Expression.OrElse(leftexpression.Body, rightexpression.Body);
            expressionBody = (BinaryExpression)new ParameterReplacer(paramExpression).Visit(expressionBody);
            var finalExpression = Expression.Lambda<Func<T, bool>>(expressionBody, paramExpression);

            return finalExpression;
        }
    }
}