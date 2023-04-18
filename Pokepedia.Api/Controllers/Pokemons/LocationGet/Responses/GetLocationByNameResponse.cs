using Pokepedia.ApiAdapter.Models;

namespace Pokepedia.Api.Controllers.Pokemons.LocationGet.Responses
{
    public class GetLocationByNameResponse
    {
        public LocationArea LocationArea{ get; set; } = new LocationArea();
    }
}
