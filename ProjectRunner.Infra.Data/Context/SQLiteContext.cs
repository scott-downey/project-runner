using Microsoft.EntityFrameworkCore;
using ProjectRunner.Entities;
using ProjectRunner.Infra.Data.Mapping;
using System.Reflection;

namespace ProjectRunner.Infra.Data.Context
{
    public class SQLiteContext : DbContext
    {
        public DbSet<Project> Projects { get; set; }

        public SQLiteContext() : base()
        {
            Database.EnsureCreated();
        }

        public SQLiteContext(DbContextOptions<SQLiteContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=ProjectRunner.db", options => {
                options.MigrationsAssembly(Assembly.GetExecutingAssembly().FullName);
            });
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Project>(new ProjectMapper().Configure);
            base.OnModelCreating(modelBuilder);
        }
    }
}
