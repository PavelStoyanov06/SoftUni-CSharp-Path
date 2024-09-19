using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaApp.Data
{
    using Microsoft.EntityFrameworkCore;

    using CinemaApp.Data.Models;
    using System.Reflection;

    public class CinemaDbContext : DbContext
    {
        public CinemaDbContext()
        {
            
        }

        public CinemaDbContext(DbContextOptions options) : base(options)
        {
            
        }

        public DbSet<Movie> Movies { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
