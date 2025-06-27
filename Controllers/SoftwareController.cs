using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

[ApiController]
[Route("api/[controller]")]
public class SoftwareController : ControllerBase
{
    private readonly AppDbContext _context;

    public SoftwareController(AppDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<ActionResult<List<Software>>> GetSoftware()
    {
        var softwares = await _context.Softwares
            .ToListAsync();

        return Ok(softwares);
    }
}
