using Pokepedia.ApiAdapter.PokeApi;
using Pokepedia.Domain.Contenders.Locations;
using Pokepedia.Domain.Entities.Locations;
using Pokepedia.Domain.Entities.Pokemons;
using Pokepedia.Domain.Services.Crud.Read;
using Pokepedia.Domain.Validation;

namespace Pokepedia.Domain.Services.Locations.Read
{
    public class LocationReadByPokemonNameService : IReadByNameServiceForLocation<PokemonName, Pokemon>
    {
        public async Task<Location> GetLocationByPokemonNameAsync(PokemonName pokemonName)
        {
            var locationModel = await GetLocation.GetLocationByPokemonNameAsync(pokemonName.ToString());
            var pokemonModel = await GetPokemon.GetPokemonByNameAsync(pokemonName.ToString());

            var locationContender = new LocationContender()
            {
                Name = pokemonModel.Name,
                Id = pokemonModel.Id,
                Weight = pokemonModel.Weight,
                Order = pokemonModel.Order,
                LocationArea = locationModel.LocationArea,
                LocationDetails = locationModel.LocationDetails,
            };

            return new Location(locationContender);

        }

    }
}
