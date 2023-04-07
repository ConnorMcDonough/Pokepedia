namespace Pokepedia.Domain.Services.Crud
{
    public interface ICreateService<T, TResult>
    {
        Task<TResult> CreateAsync(T type);
    }
}
