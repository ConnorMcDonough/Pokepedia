using Pokepedia.Domain.Contenders.Locations;

namespace Pokepedia.Domain.Entities.Locations
{
    public class Location
    {
        public string LocationArea { get; }
        public string LocationDetails { get; }

        public Location(LocationContender locationContender)
        {
            LocationArea = locationContender.LocationArea;
            LocationDetails = locationContender.LocationDetails;
        }
    }
}
