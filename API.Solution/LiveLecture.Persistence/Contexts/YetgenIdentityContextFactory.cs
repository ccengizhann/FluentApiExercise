using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveLecture.Persistence.Contexts
{
    public class YetgenIdentityContextFactory : IDesignTimeDbContextFactory<YetgenIdentityContext>
    {
        public YetgenIdentityContext CreateDbContext(string[] args)
        {
           IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

           var optionsBuilder = new DbContextOptionsBuilder<YetgenIdentityContext>();

            var connectionString = configuration.GetSection("YetgenPostgreSQLDB").Value;

            optionsBuilder.UseNpgsql(connectionString);

            return new YetgenIdentityContext(optionsBuilder.Options);
        }
    }
}
