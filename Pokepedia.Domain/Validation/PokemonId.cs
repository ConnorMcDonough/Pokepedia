namespace Pokepedia.Domain.Validation
{
    public class PokemonId
    {
        private readonly int _value;

        public PokemonId(int contender)
        {
            if (!IsValid(contender))
            {
                throw new InvalidOperationException(nameof(PokemonId));
            }

            _value = contender;
        }

        public static bool IsValid(int contender) => !(contender <= 0);

        public int GetValue()
        {
            return _value;
        }
    }
}
