using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class BibliotecarioController : ControllerBase
{
    private readonly IBibliotecarioRepository _repo;

    public BibliotecarioController(IBibliotecarioRepository repo)
    {
        _repo = repo;
    }

    [HttpPost]
    public IActionResult Cadastrar([FromBody] Bibliotecario novoBiblio)
    {
        _repo.Adicionar(novoBiblio);
        return Ok(novoBiblio);

    }

    [HttpGet]
    public IActionResult Listar()
    {
        var All = _repo.ObterTodos();
        return Ok(All);
    }

    [HttpDelete("{cpf}")]
    public IActionResult Remover(string cpf)
    {
       _repo.Remover(cpf);
        return Ok();
    }
}
