using System;

namespace FireTrackPH.Domain.Entities;

public abstract class Location
{
    public int Id { get; set; }
    public double Latitude { get; set; }
    public double Longitude { get; set; }
    public string Address { get; set; } = default!;

}