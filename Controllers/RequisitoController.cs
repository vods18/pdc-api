using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace SeuNamespace.Controllers
{
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

        [HttpPost("subrequisitos/{id}/check")]
        public async Task<IActionResult> CheckSubRequisito(int id, [FromBody] CheckSubRequisitoRequest request)
        {
            var sub = await _context.SubRequisitos.FindAsync(id);
            if (sub == null)
                return NotFound(new { Message = $"SubRequisito {id} não encontrado." });

            sub.Check = request.Checked;
            await _context.SaveChangesAsync();

            return Ok(new
            {
                sub.Id,
                Checked = sub.Check
            });
        }
    }

    public class CheckSubRequisitoRequest
    {
        public bool Checked { get; set; }
    }
}
