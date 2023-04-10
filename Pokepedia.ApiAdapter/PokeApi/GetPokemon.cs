using Newtonsoft.Json;
using Pokepedia.ApiAdapter.Models;
using System.Net.Http.Headers;

namespace Pokepedia.ApiAdapter.PokeApi
{
    public class GetPokemon
    {
        private const string Url = "https://pokeapi.co/api/v2/";

        public static async Task<PokemonModel> GetPokemonByNameAsync(string name)
        {
            var urlQuery = $"pokemon/{name}";

            return await GetPokemonAsync(urlQuery);
        }

        public static async Task<PokemonModel> GetPokemonByIdAsync(int id)
        {
            var urlQuery = $"pokemon/{id}";

            return await GetPokemonAsync(urlQuery);
        }

        private static async Task<PokemonModel> GetPokemonAsync(string urlQuery)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Url);

                client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = await client.GetAsync(urlQuery);

                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadAsStringAsync();

                    var pokemonModel = JsonConvert.DeserializeObject<PokemonModel>(result) ?? throw new InvalidOperationException("Failed to deserialize object");

                    return pokemonModel;
                }
                else
                {
                    throw new InvalidOperationException($"Endpoint was not successfull with urlQuery: {urlQuery}");
                }
            }
        }
    }
}
