using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

[ApiController]
[Route("api/[controller]")]
public class RequisitosController : ControllerBase
{
    private readonly AppDbContext _context;

    public RequisitosController(AppDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<IActionResult> GetRequisitos()
    {
        var requisitos = await _context.Requisitos
            .Select(r => new
            {
                r.Id,
                Titulo = r.Nome
            })
            .ToListAsync();

        return Ok(requisitos);
    }
}
