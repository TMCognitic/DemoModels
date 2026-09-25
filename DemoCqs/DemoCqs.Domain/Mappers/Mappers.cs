using DemoCqs.Domain.Entities;
using System.Data;

namespace DemoCqs.Domain.Mappers
{
    public static class Mappers
    {
        extension(IDataRecord record)
        {
            internal Personne ToPersonne()
            {
                return new Personne((int)record["Id"],
                    (string)record["Nom"],
                    (string)record["Prenom"],
                    (string)record["Email"],
                    (string)record["Adresse"],
                    (int)record["CodePostal"],
                    (string)record["Localite"]);
            }
        }
    }
}
