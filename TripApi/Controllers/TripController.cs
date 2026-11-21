using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TripApi.Data;
using TripApi.Models;

namespace TripApi.Controllers;


[ApiController]
[Route("api/[controller]")]
public class TripsController : ControllerBase
{
    private readonly TripDbContext _context;

    public TripsController(TripDbContext context)
    {
        _context = context;
    }


   // GET: api/trips
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Trip>>> GetAll()
    {
        var trips = await _context.Trips.ToListAsync();

        return Ok(trips);
    }


    // GET: api/trips/1
    [HttpGet("{id}")]
    public async Task<ActionResult<Trip>> GetById(int id)
    {
        var trip = await _context.Trips.FindAsync(id);

        if (trip == null)
            return NotFound();

        return Ok(trip);
    }



    // POST: api/trips
    [HttpPost]
    public async Task<ActionResult<Trip>> Create(Trip trip)
    {
        _context.Trips.Add(trip);

        await _context.SaveChangesAsync();

        return CreatedAtAction(
            nameof(GetById),
            new { id = trip.Id },
            trip
        );
    }



    // PUT: api/trips/1
    [HttpPut("{id}")]
    public async Task<ActionResult<Trip>> Update(
        int id,
        Trip updatedTrip)
    {
        var trip = await _context.Trips.FindAsync(id);

        if (trip == null)
            return NotFound();

        trip.Destination = updatedTrip.Destination;
        trip.Description = updatedTrip.Description;
        trip.StartDate = updatedTrip.StartDate;
        trip.EndDate = updatedTrip.EndDate;
        trip.Budget = updatedTrip.Budget;
        trip.Status = updatedTrip.Status;

        await _context.SaveChangesAsync();

        return Ok(trip);
    }




    // DELETE: api/trips/1
    [HttpDelete("{id}")]
    public async Task<ActionResult<Trip>> Delete(int id)
    {
        var trip = await _context.Trips.FindAsync(id);

        if (trip == null)
            return NotFound();

        _context.Trips.Remove(trip);

        await _context.SaveChangesAsync();

        return NoContent();
    }
}