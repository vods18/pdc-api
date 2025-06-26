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
            .Include(r => r.SubRequisitos)
            .Select(r => new
            {
                r.Id,
                Titulo = r.Nome,
                SubRequisitos = r.SubRequisitos.Select(s => new
                {
                    s.Id,
                    Titulo = s.Nome,
                    Explicacao = s.Descricao,
                    Checked = s.Check
                }).ToList()
            })
            .ToListAsync();

        return Ok(requisitos);
    }

}
