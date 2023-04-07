using Microsoft.AspNetCore.Mvc;
using Pokepedia.Api.Controllers.Pokepedia.Requests;
using Pokepedia.Api.Controllers.Pokepedia.Responses;
using Pokepedia.Domain.Contenders.Pokemons;
using Pokepedia.Domain.Entities.Pokemons;
using Pokepedia.Domain.Services.Crud;

namespace Pokepedia.Api.Controllers.Pokepedia
{
    [ApiController]
    [Route("v1")]
    public class PokepediaController : ControllerBase
    {
        private readonly ILogger<PokepediaController> _logger;
        private readonly ICreateService<NewPokemon, Pokemon> _pokemonGetService;

        public PokepediaController(ILogger<PokepediaController> logger, ICreateService<NewPokemon, Pokemon> pokemonGetService)
        {
            _logger = logger;
            _pokemonGetService = pokemonGetService;
        }

        [HttpGet("pokemon/getByName")] //TODO Add Api Versioning
        public async Task<ActionResult<GetPokemonByNameResponse>> HandleAsync([FromQuery] GetPokemonByNameRequest getPokemonByNameRequest, CancellationToken cancellation = default)//TODO Add inject service for getting name
        {
            var newPokemon = new NewPokemon(new NewPokemonContender() { Name = getPokemonByNameRequest.Name});
            var getPokemon = await _pokemonGetService.CreateAsync(newPokemon);

            var response = new GetPokemonByNameResponse()
            {
                Name = getPokemon.Name,
                Id = getPokemon.Id,
                Weight= getPokemon.Weight,
                SpriteImagePath = getPokemon.SpriteImagePath 
            };

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
