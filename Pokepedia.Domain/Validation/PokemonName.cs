namespace Pokepedia.Domain.Validation
{
    public class PokemonName
    {
        private readonly string _value;

        public PokemonName(string contender)
        {
            if (!IsValid(contender))
            {
                throw new InvalidOperationException(nameof(PokemonName));
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
