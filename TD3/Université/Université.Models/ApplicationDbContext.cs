using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using Université.Models.Entity;


namespace Université.Models
{
    public class ApplicationDbContext : IdentityDbContext
    {
        private readonly string _connectionString;
        public DbSet<Etudiant> Etudiant { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
    }
}
