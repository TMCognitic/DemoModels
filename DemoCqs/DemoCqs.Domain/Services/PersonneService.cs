using BStorm.Tools.Database;
using DemoCqs.Domain.Commands;
using DemoCqs.Domain.Entities;
using DemoCqs.Domain.Mappers;
using DemoCqs.Domain.Queries;
using DemoCqs.Domain.Repositories;
using System.Data.Common;

namespace DemoCqs.Domain.Services
{
    public class PersonneService : IPersonneRepository
    {
        private readonly DbConnection _connection;

        public PersonneService(DbConnection connection)
        {
            _connection = connection;
            _connection.Open();
        }

        public IEnumerable<Personne> Execute(GetPersonnesQuery query)
        {
            return _connection.ExecuteReader("SELECT Id, Nom, Prenom, Email, Adresse, CodePostal, Localite FROM Personne", r => r.ToPersonne()).ToList();
        }

        public bool Execute(InsertPersonneCommand command)
        {
            return 1 == _connection.ExecuteNonQuery("INSERT INTO Personne (Nom, Prenom, Email, Adresse, CodePostal, Localite) VALUES (@Nom, @Prenom, @Email, @Adresse, @CodePostal, @Localite)", parameters: command);
        }
    }
}
