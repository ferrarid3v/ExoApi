using Exo.WebApi.Models;
using Microsoft.EntityFrameworkCore;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;

namespace Exo.WebApi.Contexts
{
    public class ExoContext : DbContext
    {
        public ExoContext()
        {
        }
        public ExoContext(DbContextOptions<ExoContext> options) : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(
                    "User Id=sa;Password=12345;" +
                    "Server=localhost\\SQLEXPRESS;" +
                    "Database=ExoApi;" +
                    "Trusted_Connection=False;" +
                    "TrustServerCertificate=True;"
                );
            }
        }
        public DbSet<Projeto> Projetos { get; set; }
    }
}