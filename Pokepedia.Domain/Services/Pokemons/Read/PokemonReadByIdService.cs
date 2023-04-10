using Pokepedia.ApiAdapter.PokeApi;
using Pokepedia.Domain.Contenders.Pokemons;
using Pokepedia.Domain.Entities.Pokemons;
using Pokepedia.Domain.Services.Crud.Read;
using Pokepedia.Domain.Validation;

namespace Pokepedia.Domain.Services.Pokemons.Read
{
    public class PokemonReadByIdService : IReadByIdService<PokemonId, Pokemon>
    {
        public async Task<Pokemon> GetPokemonByIdAsync(PokemonId pokemonId)
        {
            var pokemonModel = await GetPokemon.GetPokemonByIdAsync(pokemonId.GetValue());

            var pokemonContender = new PokemonContender()
            {
                Name = pokemonModel.Name,
                Id = pokemonModel.Id,
                Weight = pokemonModel.Weight,
                Order = pokemonModel.Order,
            };

            return new Pokemon(pokemonContender);
        }
    }
}
