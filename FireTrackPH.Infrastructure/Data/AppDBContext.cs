using FireTrackPH.Application.Common.Interface.Base;
using FireTrackPH.Application.Entities;
using FireTrackPH.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace FireTrackPH.Infrastructure.Data
{
    public class AppDBContext : DbContext, IDBContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {
        }
        public DbSet<AppIncident> Incidents => Set<AppIncident>();

        public DbSet<AppLocation> Locations => Set<AppLocation>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<AppIncident>()
                .HasOne(i => i.Location)
                .WithOne()
                .HasForeignKey<AppLocation>(l => l.Id) // Optional if using shared PK pattern
                .OnDelete(DeleteBehavior.Cascade);
            // Add any additional configuration here
        }
    }
}
