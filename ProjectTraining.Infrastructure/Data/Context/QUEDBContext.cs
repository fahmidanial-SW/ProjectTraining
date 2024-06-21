using Microsoft.EntityFrameworkCore;
using ProjectTraining.Domain.Entities;

namespace ProjectTraining.Infrastructure.Data.Context
{
    public class QUEDBContext(DbContextOptions<QUEDBContext> options) : DbContext(options)
    {
        public DbSet<TRAINING> TRAINING { get; set; }
    }
}
