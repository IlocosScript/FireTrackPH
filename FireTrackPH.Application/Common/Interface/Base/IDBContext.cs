using FireTrackPH.Application.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireTrackPH.Application.Common.Interface.Base
{
    public interface IDBContext
    {
        // Add your methods and properties here
        // For example:
        // DbSet<YourEntity> YourEntities { get; set; }
        // Task<int> SaveChangesAsync(CancellationToken cancellationToken);
        // Task<int> SaveChangesAsync();
        DbSet<AppIncident> Incidents { get; }
        DbSet<AppLocation> Locations { get; }
    }
}
