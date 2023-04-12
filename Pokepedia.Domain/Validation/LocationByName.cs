namespace Pokepedia.Domain.Validation
{
    public class LocationByName
    {
        private readonly string _value;

        public LocationByName(string contender)
        {
            if (!IsValid(contender))
            {
                throw new InvalidOperationException(nameof(LocationByName));
            }
            _value = contender.Trim();
        }

        public static bool IsValid(string contender) => !string.IsNullOrWhiteSpace(contender);

        public override string ToString()
        {
            return _value.ToString();
        }
    }
}
