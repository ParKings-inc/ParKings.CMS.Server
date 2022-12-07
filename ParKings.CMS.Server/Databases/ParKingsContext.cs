using Microsoft.EntityFrameworkCore;
using ParKings.CMS.Server.Databases.Tables;

namespace ParKings.CMS.Server.Databases;

public class ParKingsContext : DbContext {
    public ParKingsContext(DbContextOptions options) : base(options) { }

    public DbSet<ReservationEntry> Reservations { get; set; }
}
