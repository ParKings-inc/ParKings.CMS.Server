using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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

    [HttpGet(Name = "GetReservations")]
    public async Task<IEnumerable<ReservationEntry>> Get() {
        return await Context.Reservations.ToListAsync();
    }
}
