using FireTrackPH.Domain.Entities;
using FireTrackPH.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireTrackPH.Application.DTO
{
    public class IncidentsDTO
    {
        public string PhotoURL { get; set; } = default!;
        public int Severity { get; set; } // 1–3 (low to high)
        public string Description { get; set; } = default!;
        public IncidentType Type { get; set; }

        public int LocationId { get; set; }
        public Location Location { get; set; } = default!;

        public IncidentStatus Status { get; set; }
        public string ReportedBy { get; set; } = default!;
        public DateTime ReportedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public DateTime CreatedAt { get; set; }
    }

    public class CreateIncidentDTO
    {
        public string PhotoURL { get; set; } = default!;
        public int Severity { get; set; }
        public string Description { get; set; } = default!;
        public IncidentType Type { get; set; }
        public IncidentStatus Status { get; set; }
        public string ReportedBy { get; set; } = default!;
        public LocationDTO Location { get; set; } = default!;
    }

    public class LocationDTO
    {
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public string Address { get; set; } = default!;
    }
}
