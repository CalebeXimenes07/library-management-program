using Microsoft.AspNetCore.Mvc;

public record ExemplarParams(ObraLiteraria obraLiteraria);

[ApiController]
[Route("api/[controller]")]
public class ExemplarController : ControllerBase
{
    private readonly IExemplarRepository _repo;

    public ExemplarController(IExemplarRepository repo)
    {
        _repo = repo;
    }

    [HttpPost]
    public IActionResult Cadastrar([FromBody] ExemplarParams dados)
    {
        var novoExemplar = new Exemplar(dados.obraLiteraria);
        _repo.Adicionar(novoExemplar);
        return Ok(novoExemplar);

    }

    [HttpGet]
    public IActionResult Listar()
    {
        var All = _repo.ObterTodos();
        return Ok(All);
    }

    [HttpDelete("{idExemplar}")]
    public IActionResult Remover(string idExemplar)
    {
       _repo.Remover(idExemplar);
        return Ok();
    }
}
