namespace Pokepedia.Api.Controllers.Pokemons.LocationGet.Responses
{
    public class GetLocationByPokemonNameResponse
    {
        public string Name { get; set; } = string.Empty;
        public int Id { get; set; } = 0;
        public string LocationArea { get; set; } = string.Empty;
        public string LocationDetails { get; set; } = string.Empty;
    }
}
