using Desafio.Domain;
using Microsoft.AspNetCore.Mvc;

namespace Desafio.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FatorialController : ControllerBase
    {

        private readonly ILogger<FatorialController> _logger;

        private readonly FatorialResolver _fatorialResolver;

        public FatorialController(ILogger<FatorialController> logger, FatorialResolver fatorialResolver)
        {
            _logger = logger;
            _fatorialResolver = fatorialResolver;
        }

        [HttpPost("calcular")]
        public ActionResult<string> Calcular(int fatorial)
        {
            var resultado = _fatorialResolver.Resolve(fatorial);
            _logger.LogInformation(resultado);
            return Ok(resultado);
        }
    }
}