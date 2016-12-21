namespace CompositeSpecificationByExtension
{
    public static class SpecificationExtension
    {
        public static ISpecification<T> And<T>(this ISpecification<T> left, ISpecification<T> right)
        {
            return new Specification<T>(obj => left.IsSatisfiedBy(obj) && right.IsSatisfiedBy(obj));
        }
        public static ISpecification<T> Or<T>(this ISpecification<T> left, ISpecification<T> right)
        {
            return new Specification<T>(obj => left.IsSatisfiedBy(obj) || right.IsSatisfiedBy(obj));
        }
        public static ISpecification<T> Not<T>(this ISpecification<T> specification)
        {
            return new Specification<T>(obj => !specification.IsSatisfiedBy(obj));
        }
    }
}
