
using Pokepedia.Domain.Contenders.Pokemons;
using Pokepedia.Domain.Entities.Pokemons;
using Pokepedia.Domain.Services.Crud;

namespace Pokepedia.Domain.Services.Pokemons
{
    public class PokemonGetService : ICreateService<NewPokemon, Pokemon>
    {
        public async Task<Pokemon> CreateAsync(NewPokemon pokemon)
        {
            var pokemonContender = new PokemonContender
            {
                Name = "Pikachu",
                Id = 99,
                Weight = 66,
                SpriteImagePath = "www.imagepath.com"
            };

            return new Pokemon(pokemonContender);
        }
    }
}
