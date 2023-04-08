using Pokepedia.Domain.Contenders.Pokemons;
using Pokepedia.Domain.Entities.Pokemons;
using Pokepedia.Domain.Entities.Pokemonss;
using Pokepedia.Domain.Services.Crud;

namespace Pokepedia.Domain.Services.Pokemons
{
    public class PokemonGetByIdService : IGetServiceId<PokemonId, Pokemon>
    {
        public async Task<Pokemon> GetPokemonByIdAsync(PokemonId pokemon)
        {
            var pokemonContender = new PokemonContender
            {
                Name = "test",
                Id = pokemon.Id,
                Weight = 96,
                SpriteImagePath = "www.imagepath.org"
            };

            return new Pokemon(pokemonContender);
        }
    }
}
