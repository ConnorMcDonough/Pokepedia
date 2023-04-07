namespace Pokepedia.Domain.Services.Crud
{
    public interface IGetService<T, TResult>
    {
        Task<TResult> GetPokemonAsync(T type);
    }
}
