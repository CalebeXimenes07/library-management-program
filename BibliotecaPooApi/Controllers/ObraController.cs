using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class ObrasController : ControllerBase
{
    private readonly IObraLiterariaRepository _repo;

    public ObrasController(IObraLiterariaRepository repo)
    {
        _repo = repo;
    }

    [HttpPost]
    public IActionResult Cadastrar([FromBody] ObraLiteraria novaObra)
    {
        _repo.Adicionar(novaObra);
        return Ok(novaObra);

    }

    [HttpGet]
    public IActionResult Listar()
    {
        var All = _repo.ObterTodos();
        return Ok(All);
    }

    [HttpDelete("{id}")]
    public IActionResult Remover(string id)
    {
       _repo.Remover(id);
        return Ok();
    }
}
