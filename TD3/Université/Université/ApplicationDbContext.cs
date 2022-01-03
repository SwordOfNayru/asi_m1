using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using Université.Entity;


namespace Université
{
    public class ApplicationDbContext : IdentityDbContext
    {
        private readonly string _connectionString;
        public DbSet<Etudiant> Etudiant { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<Université.Entity.Formation> Formation { get; set; }
        public DbSet<Université.Entity.UE> UE { get; set; }
        public DbSet<Université.Entity.Enseignant> Enseignant { get; set; }
        public DbSet<Université.Entity.Enseigner> Enseigner { get; set; }
    }
}
