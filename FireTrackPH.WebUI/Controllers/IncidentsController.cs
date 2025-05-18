using FireTrackPH.Application.DTO;
using FireTrackPH.Application.Entities;
using FireTrackPH.Domain.Entities;
using FireTrackPH.Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FireTrackPH.WebUI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IncidentsController : ControllerBase
    {
        private readonly AppDBContext _dbContext;
        public IncidentsController(AppDBContext appDBContext)
        {
            _dbContext = appDBContext;
        }

        [HttpPost]
        public async Task<IActionResult> CreateIncident([FromBody] CreateIncidentDTO dto)
        {
            var incident = new AppIncident
            {
                PhotoURL = dto.PhotoURL,
                Severity = dto.Severity,
                Description = dto.Description,
                Type = dto.Type,
                Status = dto.Status,
                ReportedBy = dto.ReportedBy,
                ReportedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow,
                CreatedAt = DateTime.UtcNow,
                Location = new AppLocation
                {
                    Latitude = dto.Location.Latitude,
                    Longitude = dto.Location.Longitude,
                    Address = dto.Location.Address
                }
            };

            _dbContext.Incidents.Add(incident);
            await _dbContext.SaveChangesAsync();

            return Ok(new { incident.Id });
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> GetIncident(string id)
        {
            var incident = await _dbContext.Incidents.FindAsync(id);
            if (incident == null)
            {
                return NotFound();
            }
            return Ok(incident);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllIncidents()
        {
            var incidents = await _dbContext.Incidents.Include(l => l.Location).ToListAsync();
            return Ok(incidents);
        }
    }
}
