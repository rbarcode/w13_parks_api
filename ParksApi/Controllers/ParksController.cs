using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;
using ParksApi.Models;

namespace ParksApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ParksController : ControllerBase
{
  private readonly ParksApiContext _db;

  public ParksController(ParksApiContext db)
  {
    _db = db;
  }

  // GET: api/parks
  [HttpGet]
  public async Task<ActionResult<IEnumerable<Park>>> Get(string location, string authority)
  {
    IQueryable<Park> query = _db.Parks.AsQueryable();

    if (location != null)
    {
      query = query.Where(entry => entry.Location == location);
    }

    if (authority != null)
    {
      query = query.Where(entry => entry.Authority == authority);
    }

    return await query.ToListAsync();
  }

  // GET: api/parks/{id}
  [HttpGet("{id}")]
  public async Task<ActionResult<Park>> GetPark(int id)
  {
    Park park = await _db.Parks.FindAsync(id);

    if (park == null)
    {
      return NotFound();
    }

    return park;
  }

  // POST: api/Parks
  [HttpPost]
  public async Task<ActionResult<Park>> Post(Park park)
  {
    _db.Parks.Add(park);
    await _db.SaveChangesAsync();
    return CreatedAtAction(nameof(GetPark), new { id = park.ParkId }, park);
  }

  // PUT: api/parks/{id}
  [HttpPut("{id}")]
  public async Task<IActionResult> Put(int id, Park park)
  {
    if (id != park.ParkId)
    {
      return BadRequest();
    }

    _db.Parks.Update(park);

    try
    {
      await _db.SaveChangesAsync();
    }
    catch (DbUpdateConcurrencyException)
    {
      if (!ParkExists(id))
      {
        return NotFound();
      }
      else
      {
        throw;
      }
    }
    return NoContent();
  }

  private bool ParkExists(int id)
  {
    return _db.Parks.Any(entry => entry.ParkId == id);
  }

  // DELETE: api/parks/{id}
  [HttpDelete("{id}")]
  public async Task<IActionResult> DeletePark(int id)
  {
    Park park = await _db.Parks.FindAsync(id);
    if (park == null)
    {
      return NotFound();
    }

    _db.Parks.Remove(park);
    await _db.SaveChangesAsync();

    return NoContent();
  }
}