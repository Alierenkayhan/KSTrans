namespace KSTrans.Services;

public interface IRepository<T>
{
    Task<List<T>> GetAsync();
    Task<T> GetAsync(Guid id);
}
