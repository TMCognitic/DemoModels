using DemoCqs.Domain.Commands;
using DemoCqs.Domain.Entities;
using DemoCqs.Domain.Queries;
using DemoCqs.Domain.Repositories;
using DemoCqs.Domain.Services;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.DependencyInjection;
using System.Data.Common;

const string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DemoModels.Database;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";

#region Préparation de l'injection

IServiceCollection services = new ServiceCollection();
//En ASP MVC
services.AddScoped<DbConnection>(sp => new SqlConnection(connectionString));
services.AddScoped<IPersonneRepository, PersonneService>();

#endregion
IServiceProvider serviceProvider = services.BuildServiceProvider();

IPersonneRepository repository = serviceProvider.GetRequiredService<IPersonneRepository>();


if (repository.Execute(new InsertPersonneCommand("Ly", "Khun", "khun.ly@bstorm.be", "Rue du vieux port, 31", 9999, "Outsiplu les bains d'pi")))
{
    IEnumerable<Personne> personnes = repository.Execute(new GetPersonnesQuery()).ToList();
    foreach (Personne personne in personnes)
    {
        Console.WriteLine($"{personne.NomComplet}");
    }
}
