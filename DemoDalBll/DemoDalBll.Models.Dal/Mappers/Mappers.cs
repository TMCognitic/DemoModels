using DemoDalBll.Models.Dal.Entities;
using System.Data;

namespace DemoDalBll.Models.Dal.Mappers
{
    internal static class Mappers
    {
        extension(IDataRecord record)
        {
            internal Personne ToPersonne()
            {
                return new Personne()
                {
                    Id = (int)record["Id"],
                    Nom = (string)record["Nom"],
                    Prenom = (string)record["Prenom"],
                    Email = (string)record["Email"],
                    Adresse = (string)record["Adresse"],
                    CodePostal = (int)record["CodePostal"],
                    Localite = (string)record["Localite"]
                };
            }
        }
    }
}
