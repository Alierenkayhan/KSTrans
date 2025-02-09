using KSTrans.DATA.DatabaseSettings;

namespace KSTrans.Services;

public class GenericRepository<T> : IRepository<T> where T : class
{
    private readonly IMongoCollection<T> _collection;

    public GenericRepository(IOptions<DatabaseSettings> settings)
    {
        var mongoClient = new MongoClient(settings.Value.Connection);
        var mongoDb = mongoClient.GetDatabase(settings.Value.DatabaseName);
        _collection = mongoDb.GetCollection<T>(typeof(T).Name);
    }

    public async Task<List<T>> GetAsync() => await _collection.Find(_ => true).ToListAsync();

    public async Task<T> GetAsync(Guid id) =>
        await _collection.Find(Builders<T>.Filter.Eq("_id", ObjectId.Parse(id.ToString()))).FirstOrDefaultAsync();
}
