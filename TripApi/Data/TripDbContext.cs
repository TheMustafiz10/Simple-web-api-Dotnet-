using Microsoft.EntityFrameworkCore;
using TripApi.Models;

namespace TripApi.Data;

public class TripDbContext : DbContext
{
    public TripDbContext(DbContextOptions<TripDbContext> options)
        : base(options)
    {
    }

    public DbSet<Trip> Trips => Set<Trip>();
}
