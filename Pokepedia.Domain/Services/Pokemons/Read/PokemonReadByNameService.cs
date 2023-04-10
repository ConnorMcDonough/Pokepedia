using Pokepedia.ApiAdapter.PokeApi;
using Pokepedia.Domain.Contenders.Pokemons;
using Pokepedia.Domain.Entities.Pokemons;
using Pokepedia.Domain.Services.Crud.Read;
using Pokepedia.Domain.Validation;

namespace Pokepedia.Domain.Services.Pokemons.Read
{
    public class PokemonReadByNameService : IReadByNameService<PokemonName, Pokemon>
    {
        public async Task<Pokemon> GetPokemonByNameAsync(PokemonName pokemonName)
        {
            var pokemonModel = await GetPokemon.GetPokemonByNameAsync(pokemonName.ToString());

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
