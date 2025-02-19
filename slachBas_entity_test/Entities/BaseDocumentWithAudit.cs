namespace slachBas_entity_test.Entities;

using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.ComponentModel.DataAnnotations;



public class BaseDocumentWithAudit : BaseDocument
{
    [BsonElement("createdAt")]
    [BsonRepresentation(BsonType.DateTime)]
    [Required]
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    [BsonElement("createdBy")]
    [Required]
    public string CreatedBy { get; set; } = "System"; // Giá trị mặc định

    [BsonElement("updatedAt")]
    [BsonRepresentation(BsonType.DateTime)]
    public DateTime? UpdatedAt { get; set; }

    [BsonElement("updatedBy")]
    public string UpdatedBy { get; set; }
}