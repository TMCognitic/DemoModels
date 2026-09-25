using DemoCqs.Domain.Abstractions;
using DemoCqs.Domain.Entities;

namespace DemoCqs.Domain.Queries
{
    public record GetPersonnesQuery() : IQueryDefinition<IEnumerable<Personne>>;
}
