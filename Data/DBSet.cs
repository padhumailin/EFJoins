using EFJoins.Enity;
using API.Data;
using Microsoft.EntityFrameworkCore;

namespace EFJoins.Data
{
    public class DBSet : DbContext
    {
        public DbSet<Standard> Standard { get; set; }

        public DbSet<Student> Student { get; set; }


        public DBSet(DbContextOptions<DBSet> options)
              : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer(DatabaseConnections.ReadOnlyDBConnectionString);

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Add the models if modelBuilder object exists           
            if (modelBuilder != null)
            {
            }
        }
    }
}