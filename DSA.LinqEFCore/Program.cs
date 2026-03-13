using DSA.LinqEFCore.Data;
using DSA.LinqEFCore.Queries;
using DSA.LinqEFCore.Seed;
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

var context = scope.ServiceProvider.GetRequiredService<AppDBContext>();

// Apply migrations + seed data
context.Database.Migrate();
DataSeeder.SeedAll(context);

// Resolve query service
var queries = scope.ServiceProvider.GetRequiredService<CustomerQueries>();

// Execute queries
var allCustomers = queries.GetAll();

var islamabadCustomers = queries.GetByCity("Islamabad");

Console.WriteLine("All Customers:");
foreach (var c in allCustomers)
{
    Console.WriteLine($"{c.FirstName} {c.LastName} - {c.City}");
}

Console.WriteLine("\nIslamabad Customers:");
foreach (var c in islamabadCustomers)
{
    Console.WriteLine($"{c.FirstName} {c.LastName}");
}