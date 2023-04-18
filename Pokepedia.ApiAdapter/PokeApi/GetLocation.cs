using Newtonsoft.Json;
using Pokepedia.ApiAdapter.Helpers;
using Pokepedia.ApiAdapter.Models;

namespace Pokepedia.ApiAdapter.PokeApi
{
    public class GetLocation
    {
        public static async Task<LocationModel> GetLocationByPokemonNameAsync(string name)
        {
            var urlQuery = $"pokemon/{name}/encounters";
            var responseQuery = await GetPokiHelper.GetResponseQueryAsync(urlQuery);

            return CreateLocationModel(responseQuery);
        }

        private static LocationModel CreateLocationModel(string responseQuery)
        {
            var jsonConversion = JsonConvert.DeserializeObject<List<string>>(responseQuery) ?? throw new ArgumentNullException(nameof(responseQuery));

            return new LocationModel();
            //var result = new LocationModel()
            //{
            //    LocationArea = new LocationArea()
            //    {
            //        Name = jsonConversion[0].Name
            //    }
            //}
        }
    }
}

