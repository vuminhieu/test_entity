namespace slachBas_entity_test.Entities.services;

public interface IBaseDocumentService<T> where T : BaseDocument
{
    Task<T> FindByIdsAsync(string id);
}