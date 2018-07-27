using Microsoft.EntityFrameworkCore;
using SGS.app.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace SGS.infra.Data
{
    public class SaudeContext: DbContext
    {
        public SaudeContext(DbContextOptions<SaudeContext> options): base(options)
        {
                
        }

        public DbSet<Beneficiario> Beneficiarios { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Beneficiario>().ToTable("Beneficiario");
        }
        
    }
}
