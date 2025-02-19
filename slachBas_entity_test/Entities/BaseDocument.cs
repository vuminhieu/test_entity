namespace slachBas_entity_test.Entities;

using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

public class BaseDocument
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string Id { get; set; }
}