using MongoDB.Bson.Serialization.Attributes;

namespace KSTrans.Shared.Models;

[BsonIgnoreExtraElements]
public class OurServices 
{
    [BsonElement("Title")]
    public string Title { get; set; }

    [BsonElement("ShortDescription")]
    public string ShortDescription { get; set; }

    [BsonElement("Description")]
    public string Description { get; set; }
}
