namespace Pokepedia.Domain.Services.Crud.Read
{
    public interface IReadByIdService<T, TResult>
    {
        Task<TResult> GetPokemonByIdAsync(T type);
    }
}
