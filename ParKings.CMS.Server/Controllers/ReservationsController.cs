using Microsoft.AspNetCore.Mvc;
using ParKings.CMS.Server.Core.Reservations;

namespace ParKings.CMS.Server.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ReservationsController : Controller {
    [HttpGet(Name = "GetReservations")]
    public IEnumerable<Reservation> Get() {
        return new List<Reservation>() {
            new Reservation(new DateTime(2022, 11, 15, 10, 0, 0), new DateTime(2022, 11, 15, 12, 0, 0)),
            new Reservation(new DateTime(2022, 11, 20, 14, 0, 0), new DateTime(2022, 11, 15, 17, 0, 0)),
            new Reservation(new DateTime(2022, 12, 1, 14, 0, 0), new DateTime(2022, 11, 15, 17, 0, 0))
        };
    }
}
