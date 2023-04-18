using Pokepedia.ApiAdapter.PokeApi;
using Pokepedia.Domain.Contenders.Locations;
using Pokepedia.Domain.Entities.Locations;
using Pokepedia.Domain.Entities.Pokemons;
using Pokepedia.Domain.Services.Crud.Read;
using Pokepedia.Domain.Validation;

namespace Pokepedia.Domain.Services.Locations.Read
{
    public class LocationReadByNameService : IReadByNameForLocationService<PokemonName, Location>
    {
        public async Task<Location> GetLocationByNameAsync(PokemonName pokemonName)
        {
            var locationModel = await GetLocation.GetLocationByPokemonNameAsync(pokemonName.ToString());
            var pokemonModel = await GetPokemon.GetPokemonByNameAsync(pokemonName.ToString());

            var locationContender = new LocationContender()
            {
                LocationArea = locationModel.LocationArea,
            };

            return new Location(locationContender);
        }
    }
}
