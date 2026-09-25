using DE = DemoDalBll.Models.Dal.Entities;
using DemoDalBll.Models.Bll.Entities;
using System.Data;

namespace DemoDalBll.Models.Bll.Mappers
{
    internal static class Mappers
    {
        internal static Personne ToBll(this DE.Personne personne)
        {
            return new Personne(personne.Id, personne.Nom, personne.Prenom, personne.Email, personne.Adresse, personne.CodePostal, personne.Localite);
        }

        internal static DE.Personne ToDal(this Personne personne)
        {
            return new DE.Personne()
            {
                Id = personne.Id,
                Nom = personne.Nom,
                Prenom = personne.Prenom,
                Email = personne.Email,
                Adresse = personne.Adresse,
                CodePostal = personne.CodePostal,
                Localite = personne.Localite
            };
        }
    }
}
