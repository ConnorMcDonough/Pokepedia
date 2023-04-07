
using Pokepedia.Domain.Contenders.Pokemon;
using Pokepedia.Domain.Entities.Pokemon;
using Pokepedia.Domain.Services.Crud;

namespace Pokepedia.Domain.Services.Pokemons
{
    public class PokemonGetByNameService : IGetService<PokemonName, Pokemon>
    {
        public async Task<Pokemon> GetPokemonByNameAsync(PokemonName pokemon)
        {
            var pokemonContender = new PokemonContender//go to pokiapi
            {
                Name = pokemon.Name,
                Id = 99,
                Weight = 66,
                SpriteImagePath = "www.imagepath.com"
            };

            return new Pokemon(pokemonContender);
        }
    }
}
