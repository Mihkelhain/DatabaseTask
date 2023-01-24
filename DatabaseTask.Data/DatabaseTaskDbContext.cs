using DatabaseTask.Core.Domain;
using Microsoft.EntityFrameworkCore;


namespace DatabaseTask.Data
{
    public class DatabaseTaskDbContext : DbContext
    {
        public DatabaseTaskDbContext(DbContextOptions<DatabaseTaskDbContext> options)
            : base(options) { }

        // näide, kuidas teha, kui lisate domaini alla ühe objekti
        // migratsioonid peavad tulema siia libary-sse e TARge20.Data alla.
        public DbSet<Employees> Employees { get; set; }
        public DbSet<Projects> Projects { get; set; }
        public DbSet<ConstructionCompany> ConstructionCompanies { get; set; }
        public DbSet<Worksites> WorkSites { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Worksites>().ToTable("WorkSites");
            

        }
    }
}
