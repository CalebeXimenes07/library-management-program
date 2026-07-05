using Microsoft.AspNetCore.Mvc;
    
public record EmprestimoParams(string CpfBibliotecario, string IdExemplar, string CpfCliente);

[ApiController]
[Route("api/[controller]")]
public class EmprestimoController : ControllerBase
{
    private readonly IEmprestimoService _emprestimoService;
    private readonly IEmprestimoRepository _repo;


    public EmprestimoController(IEmprestimoService emprestimoService, IEmprestimoRepository repo)
    {
        _emprestimoService = emprestimoService;
        _repo = repo;
    }

    [HttpPost]
    public IActionResult Cadastrar([FromBody] EmprestimoParams dados)
    {
        var idNovoEmprestimo = _emprestimoService.ExecutarEmprestimo(
            dados.CpfBibliotecario,
            dados.IdExemplar,
            dados.CpfCliente
        );

        return Ok(new { id = idNovoEmprestimo });

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
