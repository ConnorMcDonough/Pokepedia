using System.Net.Http.Headers;

namespace Pokepedia.ApiAdapter.Helpers
{
    public static class GetPokiHelper
    {
        private const string Url = "https://pokeapi.co/api/v2/";

        public static async Task<string> GetResponseQueryAsync(string urlQuery)
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
                    return result;
                }
                else
                {
                    throw new InvalidOperationException($"Endpoint was not successfull with urlQuery: {urlQuery}");
                }
            }
        }

    }
}
