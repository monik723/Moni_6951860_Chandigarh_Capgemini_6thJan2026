using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
// using Microsoft.EntityFrameworkCore;
// using AutoMapper;

[ApiController]
[Route("api/bookings")]
public class BookingsController : ControllerBase
{
    private readonly AppDbContext _context;

    public BookingsController(AppDbContext context)
    {
        _context = context;
    }

    [Authorize]
    [HttpPost]
    public IActionResult Book(BookingDto dto)
    {
        var booking = new Booking
        {
            EventId = dto.EventId,
            SeatsBooked = dto.SeatsBooked,
            UserId = User.Identity.Name
        };
        var ev = _context.Events.Find(dto.EventId);

        if (ev == null)
            return NotFound();

        if (dto.SeatsBooked > ev.AvailableSeats)
            return BadRequest("Not enough seats");

        ev.AvailableSeats -= dto.SeatsBooked;

        _context.Bookings.Add(booking);
        _context.SaveChanges();

        return Ok(new { message = "Booking Successful" });
    }
    [Authorize]
[HttpGet]
public IActionResult GetBookings()
{
    var user = User.Identity.Name;

    var bookings = _context.Bookings
        .Where(b => b.UserId == user)
        .Select(b => new
        {
            b.Id,
            EventName = b.Event.Title,
            b.SeatsBooked
        })
        .ToList();

    return Ok(bookings);
}

    [Authorize]
    [HttpDelete("{id}")]
    public IActionResult Cancel(int id)
    {
        var booking = _context.Bookings.Find(id);
        if (booking == null) return NotFound();

        _context.Bookings.Remove(booking);
        _context.SaveChanges();

        return Ok("Cancelled");
    }
}