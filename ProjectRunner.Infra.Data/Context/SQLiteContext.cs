using Microsoft.EntityFrameworkCore;
using ProjectRunner.Common.Entities;
using ProjectRunner.Common.Tools;
using ProjectRunner.Infra.Data.Mapping;
using System.IO;
using System.Reflection;

namespace ProjectRunner.Infra.Data.Context
{
    public class SQLiteContext : DbContext
    {
        public DbSet<Project> Projects { get; set; }

        public SQLiteContext() : base()
        {
            InitializeDatabase();
        }

        public SQLiteContext(DbContextOptions<SQLiteContext> options) : base(options)
        {
            InitializeDatabase();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string databasePath = Path.Combine(Utils.DatabaseInfo.Path, Utils.DatabaseInfo.Filename);
            string databaseSource = string.Format("Data Source={0}", databasePath);

            optionsBuilder.UseSqlite(databaseSource, options => {
                options.MigrationsAssembly(Assembly.GetExecutingAssembly().FullName);
            });
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Executable>(new ExecutableMapper().Configure);
            modelBuilder.Entity<Project>(new ProjectMapper().Configure);
            base.OnModelCreating(modelBuilder);
        }

        private void InitializeDatabase()
        {
            Directory.CreateDirectory(Utils.DatabaseInfo.Path);
            Database.EnsureCreated();
        }
    }
}
