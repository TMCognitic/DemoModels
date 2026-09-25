using BStorm.Tools.Database;
using DemoDalBll.Models.Bll.Entities;
using DemoDalBll.Models.Bll.Mappers;
using DemoDalBll.Models.Bll.Repositories;

using DR = DemoDalBll.Models.Dal.Repositories;
using DE = DemoDalBll.Models.Dal.Entities;


namespace DemoDalBll.Models.Bll.Services
{
    public class PersonneService : IPersonneRepository
    {
        private readonly DR.IPersonneRepository _dalRepository;

        public PersonneService(DR.IPersonneRepository dalRepository)
        {
            _dalRepository = dalRepository;
        }

        public IEnumerable<Personne> Get()
        {
            return _dalRepository.Get().Select(p => p.ToBll());
        }

        public bool Insert(Personne personne)
        {
            return _dalRepository.Insert(personne.ToDal());
        }

        public bool Update(int id, Personne personne)
        {
            DE.Personne p = personne.ToDal();
            p.Id = id;

            return _dalRepository.Update(p);            
        }
    }
}
