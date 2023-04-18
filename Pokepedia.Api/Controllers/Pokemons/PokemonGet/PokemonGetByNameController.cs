using Microsoft.AspNetCore.Mvc;
using Pokepedia.Api.Controllers.Pokemons.PokemonGet.Requests;
using Pokepedia.Api.Controllers.Pokemons.PokemonGet.Responses;
using Pokepedia.Domain.Entities.Pokemons;
using Pokepedia.Domain.Services.Crud.Read;
using Pokepedia.Domain.Validation;

namespace Pokepedia.Api.Controllers.Pokemons.PokemonGet
{
    [ApiController]
    [Route("v1")]
    public class PokemonGetByNameController : ControllerBase
    {
        private readonly ILogger<PokemonGetByNameController> _logger;//todo add logger
        private readonly IReadByNameService<PokemonName, Pokemon> _pokemonGetByNameService;

        public PokemonGetByNameController(ILogger<PokemonGetByNameController> logger, IReadByNameService<PokemonName, Pokemon> pokemonGetByNameService)
        {
            _logger = logger;
            _pokemonGetByNameService = pokemonGetByNameService;
        }

        [HttpGet("pokemon/getByName")] //TODO Add Api Versioning
        public async Task<ActionResult<GetPokemonByNameResponse>> HandleAsync([FromQuery] GetPokemonByNameRequest getPokemonByNameRequest, CancellationToken cancellation = default)
        {
            var pokemonToGet = new PokemonName(getPokemonByNameRequest.Name);
            var getPokemon = await _pokemonGetByNameService.GetPokemonByNameAsync(pokemonToGet);

            var response = new GetPokemonByNameResponse()
            {
                Name = getPokemon.Name,
                Id = getPokemon.Id,
                Weight = getPokemon.Weight,
                Order = getPokemon.Order
            };

            return new OkObjectResult(response);
        }
    }
}
