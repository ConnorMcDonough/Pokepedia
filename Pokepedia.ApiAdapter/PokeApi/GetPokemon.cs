using Newtonsoft.Json;
using Pokepedia.ApiAdapter.Helpers;
using Pokepedia.ApiAdapter.Models;

namespace Pokepedia.ApiAdapter.PokeApi
{
    public class GetPokemon
    {
        public static async Task<PokemonModel> GetPokemonByNameAsync(string name)
        {
            var urlQuery = $"pokemon/{name}";

            var responseQuery = await GetPokiHelper.GetResponseQueryAsync(urlQuery);

            return CreatePokemonModel(responseQuery);
        }

        public static async Task<PokemonModel> GetPokemonByIdAsync(int id)
        {
            var urlQuery = $"pokemon/{id}";

            var responseQuery = await GetPokiHelper.GetResponseQueryAsync(urlQuery);

            return CreatePokemonModel(responseQuery);
        }

        private static PokemonModel CreatePokemonModel(string responseQuery) 
        {
            return JsonConvert.DeserializeObject<PokemonModel>(responseQuery) ?? throw new ArgumentNullException(nameof(responseQuery));
        }  
    }
}
