using Microsoft.AspNetCore.Mvc;
using Pokepedia.Api.Controllers.Pokemons.LocationGet.Requests;
using Pokepedia.Api.Controllers.Pokemons.LocationGet.Responses;
using Pokepedia.Domain.Entities.Pokemons;
using Pokepedia.Domain.Services.Crud.Read;
using Pokepedia.Domain.Validation;
using Pokepedia.Domain.Validation.LocationValidation;

namespace Pokepedia.Api.Controllers.Pokemons.LocationGet
{
    [ApiController]
    [Route("v1")]
    public class LocationByPokemonNameController : ControllerBase
    {
        private readonly ILogger<LocationByPokemonNameController> _logger;
        private readonly IReadByNameServiceForLocation<PokemonName, Pokemon> _locationGetByPokemonNameService;
    }

    [HttpGet("location/getByName")]
    public async Task<ActionResult<GetLocationByPokemonNameRequest>> HandleAsync([FromQuery] GetLocationByPokemonNameRequest getLocationByPokemonNameRequest, CancellationToken cancellation = default)
    {
        var locationToGet = new LocationByName(getLocationByPokemonNameRequest.Name);
        var getLocation = await _locationGetByPokemonNameService.GetLocationByPokemonNameAsync(locationToGet);

        var response = new GetLocationByPokemonNameResponse()
        {
            Name = getLocation.Name,
            Id = getLocation.Id,
            LocationArea = getLocation.LocationArea,
            LocationDetails = getLocation.LocationDetails,
        };

        return new OkObjectResult(response);
    }
}
