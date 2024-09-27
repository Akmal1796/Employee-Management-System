using System.Text.Json.Serialization;

namespace BaseLibrary.Entities
{
    public class Relationship
    {
        //Relationship one to many
        [JsonIgnore]
        public List<Employee>? Employees { get; set; }
    }
}
