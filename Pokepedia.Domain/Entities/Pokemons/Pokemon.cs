using Pokepedia.Domain.Contenders.Pokemons;


namespace Pokepedia.Domain.Entities.Pokemons
{
    public class Pokemon
    {
        public int Id { get;  } 
        public string Name { get;  }
        public int Weight { get;  }
        public string SpriteImagePath { get; } 

        public Pokemon(PokemonContender pokemonContender)
        {
            Id = pokemonContender.Id;
            Name = pokemonContender.Name;
            Weight = pokemonContender.Weight;
            SpriteImagePath= pokemonContender.SpriteImagePath;
        }
    }
}
