using MongoDB.Bson.Serialization.Attributes;

namespace KSTrans.Shared.Models;

[BsonIgnoreExtraElements]
public class Testimonial
{
    [BsonElement("Name")]
    public string Name { get; set; }

    [BsonElement("Title")]
    public string Title { get; set; }

    [BsonElement("Comment")]
    public string Comment { get; set; }
}
