namespace ParKings.CMS.Server.Core.Reservations;

public class Reservation {
    public DateTime ArrivalTime { get; }
    public DateTime DepartureTime { get; }

    public Reservation(DateTime arrivalTime, DateTime departureTime) {
        ArrivalTime = arrivalTime;
        DepartureTime = departureTime;
    }
}
