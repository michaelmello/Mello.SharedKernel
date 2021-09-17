using System.Linq.Expressions;
using Mello.SharedKernel.Interfaces;

namespace Mello.SharedKernel;

public abstract class Specification<T> : ISpecification<T>
{
    public Expression<Func<T, bool>>? Criteria { get; }

    public List<Expression<Func<T, object>>> Includes { get; } = new List<Expression<Func<T, object>>>();

    public List<string> IncludeStrings { get; } = new List<string>();

    public Expression<Func<T, object>>? OrderBy { get; }

    public Expression<Func<T, object>>? OrderByDescending { get; }

    public Specification(Expression<Func<T, bool>> criteria) => Criteria = criteria;
    public Specification(){}

    protected virtual void AddInclude(Expression<Func<T, object>> includeExpression) => Includes.Add(includeExpression);
    protected virtual void AddInclude(string includeString) => IncludeStrings.Add(includeString);
}