using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SeuNamespace.Data;           // ajuste para o seu namespace real

namespace SeuNamespace.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GuiaRequisitosController : ControllerBase
    {
        private readonly AppDbContext _ctx;

        public GuiaRequisitosController(AppDbContext ctx)
            => _ctx = ctx;

        // GET api/guiarequisitos/by-subrequisito/19
        [HttpGet("by-subrequisito/{subId:int}")]
        public async Task<IActionResult> GetBySubRequisito(int subId)
        {
            var guia = await _ctx.GuiaRequisitos
                .AsNoTracking()
                .FirstOrDefaultAsync(g => g.SubRequisitoId == subId);

            if (guia == null)
                return NotFound($"Não existe GuiaRequisito para o SubRequisitoId = {subId}");

            return Ok(new
            {
                guia.Id,
                guia.Significado,
                guia.Importancia,
                guia.Exemplo,
                guia.SubRequisitoId
            });
        }

        // GET api/guiarequisitos/19/termos
        [HttpGet("{guiaId:int}/termos")]
        public async Task<IActionResult> GetTermos(int guiaId)
        {
            var termos = await _ctx.TermosTecnicos
                .AsNoTracking()
                .Where(t => t.GuiaRequisitoId == guiaId)
                .Select(t => new
                {
                    t.Id,
                    t.Nome,
                    t.Texto
                })
                .ToListAsync();

            if (!termos.Any())
                return NotFound($"Nenhum TermoTecnico encontrado para GuiaRequisitoId = {guiaId}");

            return Ok(termos);
        }
    }
}
