using Microsoft.AspNetCore.Mvc;
using Pokepedia.Api.Controllers.Pokemons.LocationGet.Requests;
using Pokepedia.Api.Controllers.Pokemons.LocationGet.Responses;
using Pokepedia.Domain.Entities.Locations;
using Pokepedia.Domain.Services.Crud.Read;
using Pokepedia.Domain.Validation;

namespace Pokepedia.Api.Controllers.Pokemons.LocationGet
{
    [ApiController]
    [Route("v1")]
    public class LocationByNameController : ControllerBase
    {
        private readonly ILogger<LocationByNameController> _logger;
        private readonly IReadByNameForLocationService<PokemonName, Location> _locationGetByNameService;

        public LocationByNameController(ILogger<LocationByNameController> logger, IReadByNameForLocationService<PokemonName, Location> locationGetByNameService)
        {
            _logger = logger;
            _locationGetByNameService = locationGetByNameService;
        }
    
        
        [HttpGet("location/getByName")]
        public async Task<ActionResult<GetLocationByNameResponse>> HandleAsync([FromQuery] GetLocationByNameRequest getLocationByNameRequest, CancellationToken cancellation = default)
        {
            var locationToGet = new PokemonName(getLocationByNameRequest.Name);
            var getLocation = await _locationGetByNameService.GetLocationByNameAsync(locationToGet);

            var response = new GetLocationByNameResponse()
            {
                LocationArea = getLocation.LocationArea
            };

            return new OkObjectResult(response);
        }
    }
}
