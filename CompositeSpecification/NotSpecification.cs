namespace CompositeSpecification
{
    public class NotSpecification<T> : Specification<T>
    {
        ISpecification<T> _specification;
        public NotSpecification(ISpecification<T> specification)
        {   
            _specification = specification;
        }
        public override bool IsSatisfiedBy(T obj)
        {
            return !_specification.IsSatisfiedBy(obj);
        }
    }
}
