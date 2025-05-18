using System;

namespace FireTrackPH.Domain.Entities;

public abstract class IncidentReport
{
    public int Id { get; set; }
    public int IncidentId { get; set; }

    public string ReportedBy { get; set; }

    public string Details{ get; set; }
    public Incident Incident { get; set; }

    public DateTime CreatedAt{get; set; }
}
