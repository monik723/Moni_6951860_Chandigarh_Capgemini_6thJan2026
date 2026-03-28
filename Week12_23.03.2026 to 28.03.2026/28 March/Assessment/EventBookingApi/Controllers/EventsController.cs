using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization; 
using AutoMapper;

[ApiController]
[Route("api/events")]
public class EventsController : ControllerBase
{
    private readonly AppDbContext _context;
    private readonly IMapper _mapper;

    public EventsController(AppDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    

    [Authorize]
    [HttpPost]
    public IActionResult CreateEvent(EventDto dto)
    {
        var ev = new Event
        {
            Title = dto.Title,
            Date = dto.Date,
            Location = dto.Location,
            AvailableSeats = 100,
            Description = "New Event"
        };

        _context.Events.Add(ev);
        _context.SaveChanges();

        return Ok("Event Created");
    }

    [HttpGet]
    public IActionResult GetEvents()
    {
        var events = _context.Events.ToList();
        return Ok(_mapper.Map<List<EventDto>>(events));
    }
}