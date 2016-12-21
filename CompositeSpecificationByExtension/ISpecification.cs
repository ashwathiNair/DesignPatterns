namespace CompositeSpecificationByExtension
{
    public interface ISpecification<T>
    {
        bool IsSatisfiedBy(T obj);
    }
}
