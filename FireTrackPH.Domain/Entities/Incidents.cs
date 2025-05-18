using System;
using FireTrackPH.Domain.Enums;

namespace FireTrackPH.Domain.Entities;

public abstract class Incident
{
    public int Id { get; set; } 
    public string PhotoURL { get; set; } = default!;
    public int Severity { get; set; }
    public string Description { get; set; } = default!;
    public IncidentType Type { get; set; }

    public IncidentStatus Status { get; set; }
    public string ReportedBy { get; set; } = default!;
    public DateTime ReportedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    public DateTime CreatedAt { get; set; }
}

