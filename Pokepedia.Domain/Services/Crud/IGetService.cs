namespace Pokepedia.Domain.Services.Crud
{
    public interface IGetService<T, TResult>
    {
        Task<TResult> GetPokemonByNameAsync(T type);
      

    }
    public interface IGetServiceId<T, TResult>
    {
        Task<TResult> GetPokemonByIdAsync(T type);
    }
}
