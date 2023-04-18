using Pokepedia.ApiAdapter.Models;
using Pokepedia.Domain.Contenders.Locations;

namespace Pokepedia.Domain.Entities.Locations
{
    public class Location
    {
        public LocationArea LocationArea { get; }

        public Location(LocationContender locationContender)
        {
            LocationArea = locationContender.LocationArea;
        }
    }
}
