using MongoDB.Bson.Serialization.Attributes;

namespace KSTrans.Shared.Models;

[BsonIgnoreExtraElements]
public class Files 
{
    [BsonElement("Name")]
    public string Name { get; set; }

    [BsonElement("Description")]
    public string Description { get; set; }

    [BsonElement("AddedTime")]
    public DateTime AddedTime { get; set; } = DateTime.Now;

}
