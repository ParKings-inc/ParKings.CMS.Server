namespace ParKings.CMS.Server.Core.Reservations;

public class Reservation {
    public DateTime ArrivalTime { get; set; }
    public DateTime DepartureTime { get; set; }
    public string Status { get; set; }
}
