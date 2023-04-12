namespace Pokepedia.Domain.Services.Crud.Read
{
    public interface IReadByNameServiceForLocation<T, TResult>
    {
        Task<TResult> GetLocationByPokemonNameAsync(T type);
    }
}
