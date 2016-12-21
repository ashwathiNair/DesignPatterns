using System;

namespace CompositeSpecificationByExtension
{
    public class Specification<T> : ISpecification<T>
    {

        private Func<T, bool> _expression;
        public Specification(Func<T, bool> expression)
        {
            if (expression == null)
                throw new ArgumentNullException("Expression should not be null");
            else
                _expression = expression;
        }
        public bool IsSatisfiedBy(T obj)
        {
            return _expression(obj);
        }
    }
}
