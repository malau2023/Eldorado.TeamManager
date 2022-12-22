using Eldorado.TeamManager.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Eldorado.TeamManager.DataAccess.Base
{
    public class TeamManagerDbContext : DbContext
    {
        public TeamManagerDbContext(DbContextOptions<TeamManagerDbContext> options) : base(options)
        {
            if (Database.ProviderName != "Microsoft.EntityFrameworkCore.InMemory")
                Database.Migrate();
        }

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(TeamManagerDbContext).Assembly);
        }
    }
}
