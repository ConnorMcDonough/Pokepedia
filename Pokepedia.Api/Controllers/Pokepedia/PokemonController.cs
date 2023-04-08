using Microsoft.AspNetCore.Mvc;
using Pokepedia.Api.Controllers.Pokepedia.Requests;
using Pokepedia.Api.Controllers.Pokepedia.Responses;
using Pokepedia.Domain.Contenders.Pokemons;
using Pokepedia.Domain.Entities.Pokemons;
using Pokepedia.Domain.Entities.Pokemonss;
using Pokepedia.Domain.Services.Crud;

namespace Pokepedia.Api.Controllers.Pokepedia
{
    [ApiController]
    [Route("v1")]
    public class PokemonController : ControllerBase
    {
        private readonly ILogger<PokemonController> _logger;
        private readonly IGetService<PokemonName, Pokemon> _pokemonGetService;
        private readonly IGetServiceId<PokemonName, Pokemon> _pokemonGetServiceId;

        public PokemonController(ILogger<PokemonController> logger, IGetService<PokemonName, Pokemon> pokemonGetService, IGetServiceId<PokemonId, Pokemon> pokemonGetServiceId)
        {
            _logger = logger;
            _pokemonGetService = pokemonGetService;
            _pokemonGetServiceId = pokemonGetServiceId;
        }

        [HttpGet("pokemon/getByName")] //TODO Add Api Versioning
        public async Task<ActionResult<GetPokemonByNameResponse>> HandleAsync([FromQuery] GetPokemonByNameRequest getPokemonByNameRequest, CancellationToken cancellation = default)//TODO Add inject service for getting name
        {
            var pokemonToGet = new PokemonName(new PokemonNameContender() { Name = getPokemonByNameRequest.Name });
            var getPokemon = await _pokemonGetService.GetPokemonByNameAsync(pokemonToGet);

            var response = new GetPokemonByNameResponse()
            {
                Name = getPokemon.Name,
                Id = getPokemon.Id,
                Weight = getPokemon.Weight,
                SpriteImagePath = getPokemon.SpriteImagePath
            };

            return new OkObjectResult(response);
        }

        [HttpGet("pokemon/getById")]
        public async Task<ActionResult<GetPokemonByIdResponse>> HandleAsync([FromQuery] GetPokemonByIdRequest getPokemonByIdRequest, CancellationToken cancellation = default)
        {
            var pokemonToGet = new PokemonId(new PokemonIdContender() { Id= getPokemonByIdRequest.Id });
            var getPokemon = await _pokemonGetServiceId.GetPokemonByIdAsync(pokemonToGet);

            var response = new GetPokemonByIdResponse() 
            { 
                Name = getPokemon.Name,
                Id = getPokemonByIdRequest.Id,
                Weight = getPokemon.Weight,
                SpriteImagePath= getPokemon.SpriteImagePath
            };

            return new OkObjectResult(response);
        }
    }
}
