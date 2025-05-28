using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;

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
            .Where(q => q.Visivel == true)
            .Select(q => new {
                q.Id,
                q.Pergunta
            })
            .ToListAsync();

        return Ok(perguntas);
    }
}
