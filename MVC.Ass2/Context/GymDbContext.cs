using Microsoft.EntityFrameworkCore;
using MVC.Ass2.Entities;
using System.Reflection;

namespace MVC.Ass2.Context
{
    public class GymDbContext : DbContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = .; Database = GymDb02; Trusted_Connection = True; TrustServerCertificate = True");
        }

        public DbSet<Member> Members { get; set; }
        public DbSet<Trainer> Trainers { get; set; }
        public DbSet<Session> Sessions { get; set; }
        public DbSet<Plans> Plans { get; set; }
        public DbSet<MemberShip> Memberships { get; set; }
    }
}
