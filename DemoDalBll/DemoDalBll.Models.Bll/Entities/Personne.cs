namespace DemoDalBll.Models.Bll.Entities
{
    public class Personne
    {
        internal Personne(int id, string nom, string prenom, string email, string adresse, int codePostal, string localite)
            : this (nom, prenom, email, adresse, codePostal, localite)
        {
            Id = id;
        }

        public Personne(string nom, string prenom, string email, string adresse, int codePostal, string localite)        
        {
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
        public string Email { get; set; }
        public string Adresse { get; set; }
        public int CodePostal { get; set; }
        public string Localite { get; set; }
    }
}
