namespace CompositeSpecification
{
    public class OrSpecification<T> : Specification<T>
    {
        ISpecification<T> _left;
        ISpecification<T> _right;
        public OrSpecification(ISpecification<T> left, ISpecification<T> right)
        {
            _left = left;
            _right = right;
        }
        public override bool IsSatisfiedBy(T obj)
        {
            return _left.IsSatisfiedBy(obj) || _right.IsSatisfiedBy(obj);
        }
    }
}
