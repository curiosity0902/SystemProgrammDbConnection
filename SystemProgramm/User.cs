
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace SystemProgramm
{
    public class User
    {
        public User(string name, string email, int age)
        {
            Name = name;
            Email = email;
            Age = age;
        }

        [BsonIgnore]
        public ObjectId _id;
        public string Name { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }
       //[BsonIgnoreIfDefault]
       
    }
}

