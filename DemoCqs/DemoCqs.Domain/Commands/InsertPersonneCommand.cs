using DemoCqs.Domain.Abstractions;

namespace DemoCqs.Domain.Commands
{
    public record InsertPersonneCommand(string Nom, string Prenom, string Email, string Adresse, int CodePostal, string Localite) : ICommandDefinition;
}
