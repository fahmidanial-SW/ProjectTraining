using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using ProjectTraining.Infrastructure.Data.Context;


namespace ProjectTraining.Data.Context
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<QUEDBContext>
    {
        public QUEDBContext CreateDbContext(string[] args)
        {
            var basePath = Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), "../ProjectTraining.API"));
            var configuration = new ConfigurationBuilder()
                .SetBasePath(basePath)
                .AddJsonFile("appsettings.json")
                .Build();

            var optionsBuilder = new DbContextOptionsBuilder<QUEDBContext>();
            optionsBuilder.UseSqlServer(configuration.GetConnectionString("QUEConnection"));

            return new QUEDBContext(optionsBuilder.Options);
        }
    }
}
