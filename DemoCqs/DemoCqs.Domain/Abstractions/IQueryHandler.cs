namespace DemoCqs.Domain.Abstractions
{
    public interface IQueryHandler<TQuery, TResult>
        where TQuery : IQueryDefinition<TResult>
    {
        TResult Execute(TQuery query);
    }
}
