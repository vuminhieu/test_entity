using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.ComponentModel.DataAnnotations;
using slachBas_entity_test.Entities.definition;

namespace slachBas_entity_test.Entities;

public class Avatar : BaseDocumentWithAudit
{
    [BsonElement("full_name")]
    [Required]
    public string FullName { get; set; } = "";

    [BsonElement("birth_date")]
    public long? BirthDate { get; set; }

    [BsonElement("note")]
    public string? Note { get; set; }

    [BsonElement("status")]
    [Required]
    public AvatarStatus Status { get; set; }

    public override string ToString()
    {
        return $"Avatar(Id={Id}, FullName={FullName}, BirthDate={BirthDate}, Status={Status})";
    }
}