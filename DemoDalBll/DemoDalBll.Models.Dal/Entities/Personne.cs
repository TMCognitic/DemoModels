using System.Data;
using System.Data.Common;

namespace DemoDalBll.Models.Dal.Entities
{
    public class Personne
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Email { get; set; }
        public string Adresse { get; set; }
        public int CodePostal { get; set; }
        public string Localite { get; set; }
    }
}
