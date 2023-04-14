namespace Pokepedia.Domain.Contenders.Locations
{
    public class LocationContender
    {
        public int Id { get; set; } = 0;
        public string Name { get; set; } = string.Empty;
        public int Weight { get; set; } = 0;
        public int Order { get; set; } = 0;
        public string LocationArea { get; set; } = string.Empty;
        public string LocationDetails { get; set; } = string.Empty;
    }
}
