using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace WebApplication7.Models
{
 

    public class MyDbContextFactory : IDesignTimeDbContextFactory<MyDbContext>
    {
        public MyDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<MyDbContext>();

            // Aquí, obtén la configuración desde appsettings.json
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var connectionString = configuration.GetConnectionString("Connection");
            optionsBuilder.UseSqlServer(connectionString);

            return new MyDbContext(optionsBuilder.Options);
        }
    }
}
