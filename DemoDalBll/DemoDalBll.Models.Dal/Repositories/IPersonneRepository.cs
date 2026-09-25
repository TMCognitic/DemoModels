using DemoDalBll.Models.Dal.Entities;

namespace DemoDalBll.Models.Dal.Repositories
{
    public interface IPersonneRepository
    {
        IEnumerable<Personne> Get();
        bool Insert(Personne personne);
        bool Update(Personne personne);
    }
}
