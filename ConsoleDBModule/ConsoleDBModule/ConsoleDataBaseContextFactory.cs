using System.Text.Json;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Configuration;

namespace ConsoleDBModule
{
    public sealed class ConsoleDataBaseContextFactory : IDesignTimeDbContextFactory<ConsoleDBModuleContext>
    {
        public ConsoleDBModuleContext CreateDbContext(string[] args)
        {
            var builder = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json");
            var configuration = builder.Build();
            var appsettings = new Appsettings();
            configuration.Bind(appsettings);

            // string connectionFile = File.ReadAllText("appsettings.json");
            // Appsettings connection = JsonSerializer.Deserialize<Appsettings>(connectionFile);
            // string connectionString = connection.GetConnectionString.CString;
            var optionsBuilder = new DbContextOptionsBuilder<ConsoleDBModuleContext>();
            var options = optionsBuilder
                .UseSqlServer(appsettings.GetConnectionString.CString)
                .LogTo(Console.WriteLine, LogLevel.Information)
                .UseLazyLoadingProxies(true)
                .Options;

            return new ConsoleDBModuleContext(options);
        }
    }
}