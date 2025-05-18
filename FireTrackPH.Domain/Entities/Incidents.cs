using System;
using FireTrackPH.Domain.Enums;

namespace FireTrackPH.Domain.Entities;

public abstract class Incident
{
    public string Id { get; set; } = default!;
    public string PhotoURL { get; set; } = default!;
    public int Severity { get; set; } // 1-3 (low to high)
    public string Description { get; set; } = default!;
    public IncidentType Type { get; set; }  
    public int LocationId{ get; set; }
    public Location Location { get; set; }
    public IncidentStatus Status { get; set; }
    public string ReportedBy { get; set; } = default!; // User ID
    public DateTime ReportedAt { get; set; }
    public DateTime UpdatedAt { get; set; }

    //Timestamp on Record Createion Auto.
    public DateTime CreatedAt{ get; set; }
}
