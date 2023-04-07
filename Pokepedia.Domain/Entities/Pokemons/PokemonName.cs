using Pokepedia.Domain.Contenders.Pokemons;

namespace Pokepedia.Domain.Entities.Pokemons
{
    public class PokemonName
    {
        public string Name { get; }

        public PokemonName(PokemonNameContender newPokemonContender)
        {
            Name = newPokemonContender.Name;
        }
    }
}
