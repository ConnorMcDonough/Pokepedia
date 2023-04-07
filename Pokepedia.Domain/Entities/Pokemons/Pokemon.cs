using Pokepedia.Domain.Contenders.Pokemon;


namespace Pokepedia.Domain.Entities.Pokemon
{
    public class Pokemon
    {
        public int Id { get; }
        public string Name { get; }
        public int Weight { get; }
        public string SpriteImagePath { get; }

        public Pokemon(PokemonContender pokemonContender)
        {
            Id = pokemonContender.Id;
            Name = pokemonContender.Name;
            Weight = pokemonContender.Weight;
            SpriteImagePath = pokemonContender.SpriteImagePath;
        }
    }
}
