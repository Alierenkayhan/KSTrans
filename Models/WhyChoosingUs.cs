using MongoDB.Bson.Serialization.Attributes;

namespace KSTrans.Shared.Models;

[BsonIgnoreExtraElements]
public class WhyChoosingUs
{
    [BsonElement("Title")]
    public string Title { get; set; }

    [BsonElement("Description")]
    public int Description { get; set; }

    [BsonElement("Points")]
    public string Points { get; set; }
}
