
using Microsoft.AspNetCore.Mvc;
using Pokepedia.Api.Controllers.Pokemons.GetPokemon.Requests;
using Pokepedia.Api.Controllers.Pokemons.GetPokemon.Responses;
using Pokepedia.Domain.Entities.Pokemons;
using Pokepedia.Domain.Services.Crud.Read;
using Pokepedia.Domain.Validation;

namespace Pokepedia.Api.Controllers.Pokemons.GetPokemon
{
    [ApiController]
    [Route("v1")]
    public class PokemonGetByIdController : ControllerBase
    {
        private readonly ILogger<PokemonGetByIdController> _logger;//todo add logger
        private readonly IReadByIdService<PokemonId, Pokemon> _pokemonGetServiceId;

        public PokemonGetByIdController(ILogger<PokemonGetByIdController> logger, IReadByIdService<PokemonId, Pokemon> readByIdService)
        {
            _logger = logger;
            _pokemonGetServiceId = readByIdService;
        }

        [HttpGet("pokemon/getById")]
        public async Task<ActionResult<GetPokemonByIdResponse>> HandleAsync([FromQuery] GetPokemonByIdRequest getPokemonByIdRequest, CancellationToken cancellation = default)
        {
            var pokemonToGet = new PokemonId(getPokemonByIdRequest.Id);
            var getPokemon = await _pokemonGetServiceId.GetPokemonByIdAsync(pokemonToGet);

            var response = new GetPokemonByIdResponse()
            {
                Name = getPokemon.Name,
                Id = getPokemonByIdRequest.Id,
                Weight = getPokemon.Weight,
                Order = getPokemon.Order
            };

            return new OkObjectResult(response);
        }
    }
}
