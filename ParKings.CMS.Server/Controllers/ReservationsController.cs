using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ParKings.CMS.Server.Core.Reservations;
using ParKings.CMS.Server.Databases;
using ParKings.CMS.Server.Databases.Tables;

namespace ParKings.CMS.Server.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ReservationsController : Controller {
    private readonly ParKingsContext Context;

    public ReservationsController(ParKingsContext context) {
        Context = context;
    }

    [HttpGet("GetReservations")]
    public async Task<IEnumerable<ReservationEntry>> Get() {
        return await Context.Reservations.ToListAsync();
    }

    [HttpPut("UpdateStatus/{id}/{status}")]
    public async Task UpdateReservationStatus(int id, string status) {
        Console.WriteLine(status);
        await Context.Reservations.Where(i => i.Id == id).ForEachAsync(i => i.Status = status);
        await Context.SaveChangesAsync();
    }
}
