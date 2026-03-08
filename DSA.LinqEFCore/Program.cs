using DSA.LinqEFCore.Data;
using DSA.LinqEFCore.Queries;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

var configuration = new ConfigurationBuilder()
    .SetBasePath(Directory.GetCurrentDirectory())
    .AddJsonFile("appsettings.json")
    .Build();

var services = new ServiceCollection();

services.AddDbContext<AppDBContext>(options =>
    options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

services.AddScoped<CustomerQueries>();

var serviceProvider = services.BuildServiceProvider();

using var scope = serviceProvider.CreateScope();
var queries = scope.ServiceProvider.GetRequiredService<CustomerQueries>();

queries.GetAll();
queries.GetByCity("Islamabad");
