using System;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace SeuNamespace.Controllers
{
    public class RespostaDto
    {
        public int PerguntaId { get; set; }
        public string Resposta { get; set; } = string.Empty;
    }

    [ApiController]
    [Route("api/[controller]")]
    public class QuestionarioController : ControllerBase
    {
        private readonly AppDbContext _context;

        public QuestionarioController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetQuestionario()
        {
            var perguntas = await _context.Questionario
                .Where(q => q.Visivel)
                .Select(q => new {
                    q.Id,
                    q.Pergunta
                })
                .ToListAsync();

            return Ok(perguntas);
        }

        [HttpPost("{id}/resposta")]
        public async Task<IActionResult> PostResposta(
            int id,
            [FromBody] RespostaDto dto)
        {
            if (dto.PerguntaId != id)
                return BadRequest(new { Message = "ID da rota e do corpo não conferem." });

            var pergunta = await _context.Questionario
                .FirstOrDefaultAsync(q => q.Id == id && q.Visivel);
            if (pergunta == null)
                return NotFound(new { Message = $"Pergunta {id} não encontrada ou não visível." });

            pergunta.Resposta = dto.Resposta;
            var respNorm = RemoveDiacritics(dto.Resposta).ToLowerInvariant();

            var regras = await _context.RegrasOcultacoes
                .Where(r => r.PerguntaGatilhoId == id)
                .ToListAsync();

            var regrasMatched = regras
                .Where(r => RemoveDiacritics(r.RespostaGatilho).ToLowerInvariant() == respNorm)
                .ToList();

            foreach (var regra in regrasMatched)
            {
                var alvo = await _context.Questionario
                    .FirstOrDefaultAsync(q => q.Id == regra.PerguntaAlvoId);
                if (alvo != null && alvo.Visivel)
                    alvo.Visivel = false;
            }

            await _context.SaveChangesAsync();
            return NoContent();
        }

        [HttpPost("reset")]
        public async Task<IActionResult> ResetQuestionario()
        {
            var todas = await _context.Questionario.ToListAsync();
            foreach (var q in todas)
            {
                q.Visivel = true;
            }
            await _context.SaveChangesAsync();
            return NoContent();
        }


        private static string RemoveDiacritics(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
                return text;

            var normalized = text.Normalize(NormalizationForm.FormD);
            var sb = new StringBuilder();

            foreach (var ch in normalized)
            {
                var uc = CharUnicodeInfo.GetUnicodeCategory(ch);
                if (uc != UnicodeCategory.NonSpacingMark)
                    sb.Append(ch);
            }

            return sb.ToString().Normalize(NormalizationForm.FormC);
        }
    }
}
