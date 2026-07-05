using Microsoft.AspNetCore.Mvc;

public record AlunoParams(string Nome, string Cpf, string Matricula);
public record ProfessorParams(string Nome, string Cpf, string AreaAtuacao);

[ApiController]
[Route("api/[controller]")]
public class ClienteController : ControllerBase
{
    private readonly IClienteRepository _repo;

    public ClienteController(IClienteRepository repo)
    {
        _repo = repo;
    }

    [HttpPost("professor")]
    public IActionResult CadastrarProfessor([FromBody] ProfessorParams dados)
    {
        var novoProfessor = new Professor(dados.Nome, dados.Cpf, dados.AreaAtuacao);
        if (_repo.ObterTodos().Any(x => x.Cpf == novoProfessor.Cpf))
        {
            return BadRequest();
        }
        _repo.Adicionar(novoProfessor);
        return Ok(novoProfessor);
    } 

    [HttpPost("aluno")]
    public IActionResult CadastrarAluno([FromBody] AlunoParams dados)
    {
        var novoAluno = new Aluno(dados.Nome, dados.Cpf, dados.Matricula);

        if (_repo.ObterTodos().Any(x => x.Cpf == novoAluno.Cpf))
        {
            return BadRequest();
        }
        _repo.Adicionar(novoAluno);
        return Ok(novoAluno);
    }

    [HttpGet]
    public IActionResult Listar()
    {
        var All = _repo.ObterTodos();
        return Ok(All);
    }

    [HttpDelete("{cpfCliente}")]
    public IActionResult Remover(string cpfCliente)
    {
       _repo.Remover(cpfCliente);
        return Ok();
    }
}
