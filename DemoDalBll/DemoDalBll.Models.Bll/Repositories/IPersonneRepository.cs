using DemoDalBll.Models.Bll.Entities;

namespace DemoDalBll.Models.Bll.Repositories
{
    public interface IPersonneRepository
    {
        IEnumerable<Personne> Get();
        bool Insert(Personne personne);
    }
}
