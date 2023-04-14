using Newtonsoft.Json;
using Pokepedia.ApiAdapter.Models;
using System.Net.Http.Headers;

namespace Pokepedia.ApiAdapter.PokeApi
{
    public class GetLocation
    {
        private const string Url = "https://pokeapi.co/api/v2/";

        public static async Task<LocationModel> GetLocationByPokemonNameAsync(string name)
        {
            var urlQuery = $"pokemon/{name}/encounters";
            return await GetLocationAsync(urlQuery);
        }

        private static async Task<LocationModel> GetLocationAsync(string urlQuery)
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

                    var locationModel = JsonConvert.DeserializeObject<LocationModel>(result) ?? throw new InvalidOperationException("Failed to deserialize object");

                    return locationModel;
                }
                else
                {
                    throw new InvalidOperationException($"Endpoint was not successfull with urlQuery: {urlQuery}");
                }
            }
        }
    }
}

