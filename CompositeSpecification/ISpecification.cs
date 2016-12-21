namespace CompositeSpecification
{
    public interface ISpecification <T>
    {
        bool IsSatisfiedBy(T obj);
        ISpecification<T> And(ISpecification<T> specification);
        ISpecification<T> Or(ISpecification<T> specification);
        ISpecification<T> Not();
    }
}
