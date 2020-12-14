using System;
using System.Collections.Generic;
using System.Text;
using CRUDAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace Database.Contexts
{
    public class ApiContext : DbContext
    {
        public ApiContext(DbContextOptions<ApiContext> options) : base(options)
        {
        }

        public DbSet<Pessoa> Pessoas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pessoa>().ToTable("pessoas");
        }
    }
}
