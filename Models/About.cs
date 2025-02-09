using MongoDB.Bson.Serialization.Attributes;

namespace KSTrans.Shared.Models;

[BsonIgnoreExtraElements]
public class About
{
    [BsonElement("Title")]
    public string  Title { get; set; }

    [BsonElement("Description")]
    public string  Description  { get; set; }

    [BsonElement("YearsOfExperience")]
    public int YearsOfExperience { get; set; }

    [BsonElement("Features")]
    public string Features { get; set; }

    [BsonElement("Email")]
    public string Email { get; set; }

    [BsonElement("Phone")]
    public string Phone { get; set; }

    [BsonElement("TeamMembers")]
    public int TeamMembers { get; set; }

    [BsonElement("HappyClients")]
    public int HappyClients { get; set; }

    [BsonElement("ProjectDone")]
    public int ProjectDone { get; set; }

    [BsonElement("Baskı")]
    public string Baskı { get; set; }

    [BsonElement("Privacy")]
    public string Privacy { get; set; }

    [BsonElement("WorkHours")]
    public string WorkHours { get; set; }
}
