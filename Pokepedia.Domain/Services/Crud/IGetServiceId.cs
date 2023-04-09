namespace Pokepedia.Domain.Services.Crud
{
    public interface IGetServiceId<T, TResult>
    {
        Task<TResult> GetPokemonByIdAsync(T type);
    }
}
