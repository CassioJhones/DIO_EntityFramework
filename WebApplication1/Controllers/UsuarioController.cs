using Microsoft.AspNetCore.Mvc;
namespace WebApplication1.Controllers;

[ApiController]
[Route("[controller]")]
public class UsuarioController : ControllerBase
{
    
    [HttpGet("ObterDataHoraAtual")]
    public IActionResult ObterDaraHora()
    {
        var obj = new { Data = DateTime.Now.ToLongDateString(),
                        Hora = DateTime.Now.ToShortDateString() };
        return Ok(obj);
    }

    [HttpGet("Apresentar/{nome}")]
    /// <summary>
    /// Descrição do método.
    /// </summary>
    /// <param name="parametro">Descrição do parâmetro.</param>
    /// <returns>Descrição do que o método retorna.</returns>
    public IActionResult Apresentar(string nome)
    {
        var Hora = DateTime.Now.ToShortDateString();
        var mensagem = $"Olá {nome} seja bem-vindo! agora é {Hora}";
        return Ok(new { mensagem });
    }
}
