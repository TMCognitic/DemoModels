using BStorm.Tools.Database;
using DemoDalBll.Models.Dal.Entities;
using DemoDalBll.Models.Dal.Mappers;
using DemoDalBll.Models.Dal.Repositories;
using System.Data.Common;

namespace DemoDalBll.Models.Dal.Services
{
    public class PersonneService : IPersonneRepository
    {
        private readonly DbConnection _connection;

        public PersonneService(DbConnection connection)
        {
            _connection = connection;
            _connection.Open();
        }

        public IEnumerable<Personne> Get()
        {
            return _connection.ExecuteReader("SELECT Id, Nom, Prenom, Email, Adresse, CodePostal, Localite FROM Personne", r => r.ToPersonne()).ToList();
        }

        public bool Insert(Personne personne)
        {
            return 1 == _connection.ExecuteNonQuery("INSERT INTO Personne (Nom, Prenom, Email, Adresse, CodePostal, Localite) VALUES (@Nom, @Prenom, @Email, @Adresse, @CodePostal, @Localite)", parameters: personne);
        }
    }
}
