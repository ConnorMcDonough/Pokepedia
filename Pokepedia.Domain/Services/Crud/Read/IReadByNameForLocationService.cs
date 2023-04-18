namespace Pokepedia.Domain.Services.Crud.Read
{
    public interface IReadByNameForLocationService<T, TResult>
    {
        Task<TResult> GetLocationByNameAsync(T type);
    }
}
