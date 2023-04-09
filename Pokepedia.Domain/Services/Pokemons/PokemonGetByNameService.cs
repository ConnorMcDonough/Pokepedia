
using Pokepedia.ApiAdapter.PokeApi;
using Pokepedia.Domain.Contenders.Pokemons;
using Pokepedia.Domain.Entities.Pokemons;
using Pokepedia.Domain.Services.Crud;

namespace Pokepedia.Domain.Services.Pokemons
{
    public class PokemonGetByNameService : IGetService<PokemonName, Pokemon>
    {
        public async Task<Pokemon> GetPokemonByNameAsync(PokemonName pokemonName)
        {
            var pokeAdapter = new GetPokemon();

            var pokemonModel = await pokeAdapter.GetPokemonByNameAsync(pokemonName.Name);

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
