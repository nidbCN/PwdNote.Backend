using Microsoft.EntityFrameworkCore;
using PwdNote.Backend.Models.Entities;

namespace PwdNote.Backend.Data
{
    public class ProjDbContext : DbContext
    {
        public ProjDbContext(DbContextOptions<ProjDbContext> options) : base(options)
        {
            // Ctor
        }

        public DbSet<PasswordEntity> Passwords { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var pwdEntity = modelBuilder.Entity<PasswordEntity>();
            pwdEntity.HasKey(it => it.Id);
            pwdEntity.HasIndex(it => it.Name);
            pwdEntity.HasIndex(it => it.Link);
        }
    }
}
