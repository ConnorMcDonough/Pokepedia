namespace Pokepedia.Domain.Services.Crud.Read
{
    public interface IReadByNameService<T, TResult>
    {
        Task<TResult> GetPokemonByNameAsync(T type);


    }
}
