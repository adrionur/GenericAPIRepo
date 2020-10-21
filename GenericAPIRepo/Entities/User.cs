using System.Text.Json.Serialization;

namespace GenericAPIRepo.Entities
{
    public class User
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string UserName { get; set; }
        [JsonIgnore]
        public string Password { get; set; }
    }
}
