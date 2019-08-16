using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace SweetTreat.Models
{
    public class SweetTreatContextFactory : IDesignTimeDbContextFactory<SweetTreatContext>
    {
        SweetTreatContext IDesignTimeDbContextFactory<SweetTreatContext>.CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json")
            .Build();

            var builder = new DbContextOptionsBuilder<SweetTreatContext>();
      var connectionString = configuration.GetConnectionString("DefaultConnection");

      builder.UseMySql(connectionString);

      return new SweetTreatContext(builder.Options);
        }
    }
}