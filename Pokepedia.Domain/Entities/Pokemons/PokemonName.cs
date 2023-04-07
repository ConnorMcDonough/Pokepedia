using Pokepedia.Domain.Contenders.Pokemon;

namespace Pokepedia.Domain.Entities.Pokemon
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
