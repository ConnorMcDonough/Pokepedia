using Newtonsoft.Json;
using Pokepedia.ApiAdapter.Models;
using System.Net.Http.Headers;
using System.Text.Json.Serialization;

namespace Pokepedia.ApiAdapter.PokeApi
{
    public class GetPokemon
    {
        private const string Url = "https://pokeapi.co/api/v2/";

        public async Task<PokemonModel> GetPokemonByNameAsync(string name)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Url);

                var urlQuery = $"pokemon/{name}";

                client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = await client.GetAsync(urlQuery);

                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadAsStringAsync();

                    var pokemonModel = JsonConvert.DeserializeObject<PokemonModel>(result);

                    return pokemonModel;
                }
                else
                {
                    throw new InvalidOperationException("Endpoint was not successfull");
                }
            }
        }
    }
}
