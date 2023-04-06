using Microsoft.AspNetCore.Mvc;
using Pokepedia.Api.Controllers.Pokepedia.Requests;
using Pokepedia.Api.Controllers.Pokepedia.Responses;

namespace Pokepedia.Api.Controllers.Pokepedia
{
    [ApiController]
    [Route("v1")]
    public class PokepediaController : ControllerBase
    {
        private readonly ILogger<PokepediaController> _logger;

        public PokepediaController(ILogger<PokepediaController> logger)
        {
            _logger = logger;
        }

        [HttpGet("pokemon/getByName")] //TODO Add Api Versioning
        public async Task<ActionResult<GetPokemonByNameResponse>> HandleAsync([FromQuery]GetPokemonByNameRequest getPokemonByNameRequest, CancellationToken cancellation = default)//TODO Add inject service for getting name
        {
            var response = new GetPokemonByNameResponse() { Name = getPokemonByNameRequest.Name }; // TODO Make this not giving fake data

            return new OkObjectResult(response);
        }

        [HttpGet("pokemon/getById")]
        public async Task<ActionResult<GetPokemonByIdResponse>> HandleAsync([FromQuery]GetPokemonByIdRequest getPokemonByIdRequest, CancellationToken cancellation = default)
        {
            var response = new GetPokemonByIdResponse() { Id = getPokemonByIdRequest.Id };

            return new OkObjectResult(response);
        }
    }
}
