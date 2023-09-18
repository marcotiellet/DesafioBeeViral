using Desafio.Domain;
using Desafio.Models;
using Microsoft.AspNetCore.Mvc;

namespace Desafio.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PessoaController : ControllerBase
    {

        private readonly ILogger<PessoaController> _logger;

        private readonly PessoaResolver _pessoaResolver;

        public PessoaController(ILogger<PessoaController> logger, PessoaResolver pessoaResolver)
        {
            _logger = logger;
            _pessoaResolver = pessoaResolver;
        }

        [HttpPost("filtrar")]
        public ActionResult<List<Pessoa>> FiltarPessoas(List<Pessoa> pessoas)
        {
            var resultado = _pessoaResolver.Resolve(pessoas);
            _logger.LogInformation(resultado.ToString());
            return Ok(resultado);
        }
    }
}