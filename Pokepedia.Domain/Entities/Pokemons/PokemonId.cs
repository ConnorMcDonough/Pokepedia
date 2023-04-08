using Pokepedia.Domain.Contenders.Pokemons;

namespace Pokepedia.Domain.Entities.Pokemonss
{
    public class PokemonId
    {
        public int Id { get; }
        
        public PokemonId(PokemonIdContender newPokemonContender)
        {
            Id = newPokemonContender.Id;
        }
    }
}
