using Pokepedia.ApiAdapter.PokeApi;
using Pokepedia.Domain.Contenders.Pokemons;
using Pokepedia.Domain.Entities.Pokemons;
using Pokepedia.Domain.Services.Crud.Read;
using Pokepedia.Domain.Validation;

namespace Pokepedia.Domain.Services.Pokemons.Read
{
    public class LocationReadByPokemonNameService : IReadByNameServiceForLocation<PokemonName, Pokemon>
    {
        public async Task<Pokemon> GetLocationByPokemonNameAsync(PokemonName pokemonName)
        {
            var pokemonModel = await GetPokemon.GetLocationByPokemonNameAsync(pokemonName.ToString());

            var pokemonContender = new PokemonContender()
            {
                Name = pokemonModel.Name,
                Id = pokemonModel.Id,
                Weight = pokemonModel.Weight,
                Order = pokemonModel.Order,
                LocationArea = pokemonModel.LocationArea,
                LocationDetails = pokemonModel.LocationDetails,
            };

            return new Pokemon(pokemonContender);

        }

    }
}
