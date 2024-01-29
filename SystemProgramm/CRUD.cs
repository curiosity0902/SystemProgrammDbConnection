
using MongoDB.Driver;
using System;

namespace SystemProgramm
{
    public class CRUD
    {
        public static void CreateUser(User user)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("BaseForTeam");
            var collection = database.GetCollection<User>("UserCollection");
            collection.InsertOne(user);
        }

        public static void GetUser(string name)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("BaseForTeam");
            var collection = database.GetCollection<User>("UserCollection");
            var user = collection.Find(x => x.Name == name).FirstOrDefault();
            if (user == null)
                Console.WriteLine("Not Found");
            else
                Console.WriteLine($"{user.Name} {user.Age}");
        }

        public static void CreateTestTeam(Team team)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("BaseForTeam");
            var collection = database.GetCollection<Team>("UsersTeam");
            collection.InsertOne(team);
        }
    }
}
