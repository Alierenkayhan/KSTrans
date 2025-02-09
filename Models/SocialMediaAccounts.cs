using MongoDB.Bson.Serialization.Attributes;

namespace KSTrans.Shared.Models;

[BsonIgnoreExtraElements]
public class SocialMediaAccounts
{
    [BsonElement("Name")]
    public string Name { get; set; }

    [BsonElement("Link")]
    public string Link { get; set; }

    [BsonElement("IconClass")]
    public string IconClass { get; set; }
}
