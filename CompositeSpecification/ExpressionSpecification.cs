using System;

namespace CompositeSpecification
{
    public class ExpressionSpecification<T> : Specification<T>
    {
        public Func<T, bool> _expression;
        public ExpressionSpecification(Func<T, bool> expression)
        {
            if (expression == null)
                throw new ArgumentNullException("Expression should not be null");
            else
            _expression = expression;
        }
        public override bool IsSatisfiedBy(T obj)
        {
            return _expression(obj); 
        }
    }
}
