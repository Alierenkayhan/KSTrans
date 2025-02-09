using MongoDB.Bson.Serialization.Attributes;

namespace KSTrans.Shared.Models;

[BsonIgnoreExtraElements]
public class Image 
{
    [BsonElement("Name")]
    public string Name { get; set; }

    [BsonElement("Path")]
    public string Path { get; set; }

}
