using MongoDB.Bson.Serialization.Attributes;

namespace KSTrans.Shared.Models;
[BsonIgnoreExtraElements]
public class Links
{
    [BsonElement("Name")]
    public string Name { get; set; }

    [BsonElement("Url")]
    public string Url { get; set; }
}
