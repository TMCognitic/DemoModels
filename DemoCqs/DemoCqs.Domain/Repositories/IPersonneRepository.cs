using DemoCqs.Domain.Abstractions;
using DemoCqs.Domain.Commands;
using DemoCqs.Domain.Entities;
using DemoCqs.Domain.Queries;

namespace DemoCqs.Domain.Repositories
{
    public interface IPersonneRepository : 
        IQueryHandler<GetPersonnesQuery, IEnumerable<Personne>>,
        ICommandHandler<InsertPersonneCommand>
    {
    }
}
