using System;
using System.Collections.Generic;
using System.Text;

namespace DemoCqs.Domain.Entities
{
    public class Personne
    {
        internal Personne(int id, string nom, string prenom, string email, string adresse, int codePostal, string localite)
        {
            Id = id;
            Nom = nom;
            Prenom = prenom;
            Email = email;
            Adresse = adresse;
            CodePostal = codePostal;
            Localite = localite;
        }

        public int Id { get; }
        public string Nom { get; }
        public string Prenom { get; }
        public string NomComplet => $"{Prenom} {Nom}";
        public string Email { get; }
        public string Adresse { get; }
        public int CodePostal { get; }
        public string Localite { get; }
    }
}
