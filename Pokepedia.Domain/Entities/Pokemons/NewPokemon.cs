using Pokepedia.Domain.Contenders.Pokemons;

namespace Pokepedia.Domain.Entities.Pokemons
{
    public class NewPokemon
    {
        public string Name { get; }

        public NewPokemon(NewPokemonContender newPokemonContender)
        {
            Name = newPokemonContender.Name;
        }
    }
}
