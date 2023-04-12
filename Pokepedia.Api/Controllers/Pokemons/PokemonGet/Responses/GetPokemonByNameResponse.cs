namespace Pokepedia.Api.Controllers.Pokemons.PokemonGet.Responses
{
    public class GetPokemonByNameResponse
    {
        public string Name { get; set; } = string.Empty;
        public int Id { get; set; } = 0;
        public int Weight { get; set; } = 0;
        public int Order { get; set; } = 0;

    }
}
