using MongoDB.Driver;

namespace slachBas_entity_test.Entities.services;

public class BaseDocumentService<T> : IBaseDocumentService<T> where T : BaseDocument
{
    private readonly IMongoCollection<T> _collection;

    public BaseDocumentService(IMongoDatabase database, string collectionName)
    {
        _collection = database.GetCollection<T>(collectionName);
    }

    public async Task<T> FindByIdsAsync(string id)
    {
        var filter = Builders<T>.Filter.Eq(doc => doc.Id, id);
        return await _collection.Find(filter).FirstOrDefaultAsync();
    }
}