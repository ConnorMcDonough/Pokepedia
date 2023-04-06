using Microsoft.AspNetCore.Mvc;
using Pokepedia.Api.Controllers.Pokepedia.Responses;

namespace Pokepedia.Api.Controllers.Pokepedia
{
    [ApiController]
    [Route("[controller]")]
    public class PokepediaController : ControllerBase
    {
        private readonly ILogger<PokepediaController> _logger;

        public PokepediaController(ILogger<PokepediaController> logger)
        {
            _logger = logger;
        }

        [HttpGet("getPokemon/{name}")] //TODO Add Api Versioning
        public async Task<ActionResult<GetPokemonByNameResponse>> HandleAsync(String name, CancellationToken cancellation = default)//TODO Add inject service for getting name
        {
            var response = new GetPokemonByNameResponse() { Name = name }; // TODO Make this not giving fake data

            return new OkObjectResult(response);
        }
    }
}