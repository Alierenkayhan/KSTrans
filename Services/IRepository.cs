namespace KSTrans.Services;

public interface IRepository<T>
{
    Task<List<T>> GetListAsync();
    Task<T> GetAsync(Guid id);
}
