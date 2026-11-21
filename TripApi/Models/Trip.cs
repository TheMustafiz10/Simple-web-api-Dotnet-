
namespace TripApi.Models;

public class Trip
{
    public int Id { get; set; }

    public string Destination { get; set; } = string.Empty;

    public string Description { get; set; } = string.Empty;

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public decimal Budget { get; set; }

    public string Status { get; set; } = "Planned";
}