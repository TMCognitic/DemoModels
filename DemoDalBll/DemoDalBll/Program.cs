using DR = DemoDalBll.Models.Dal.Repositories;
using DS = DemoDalBll.Models.Dal.Services;
using DE = DemoDalBll.Models.Dal.Entities;

using DemoDalBll.Models.Bll.Repositories;
using DemoDalBll.Models.Bll.Services;
using DemoDalBll.Models.Bll.Entities;

using Microsoft.Extensions.DependencyInjection;
using System.Data.Common;
using Microsoft.Data.SqlClient;

const string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DemoModels.Database;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";

#region Préparation de l'injection

IServiceCollection services = new ServiceCollection();
//En ASP MVC
services.AddScoped<DbConnection>(sp => new SqlConnection(connectionString));
services.AddScoped<DR.IPersonneRepository, DS.PersonneService>(); // --> Repo et Service de la Dal
services.AddScoped<IPersonneRepository, PersonneService>(); // --> Repo et Service de la Bll

#endregion
IServiceProvider serviceProvider = services.BuildServiceProvider();

IPersonneRepository repository = serviceProvider.GetRequiredService<IPersonneRepository>();


Personne p = new Personne("Doe", "John", "john.doe@test.be", "Rue du pavot, 85", 1000, "Bruxelles");

if(repository.Insert(p))
{
    IEnumerable<Personne> personnes = repository.Get();

    foreach (Personne personne in personnes)
    {
        Console.WriteLine($"{personne.NomComplet}");
    }
}


