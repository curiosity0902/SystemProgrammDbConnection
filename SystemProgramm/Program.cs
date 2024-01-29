using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB;

namespace SystemProgramm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CRUD.CreateUser(new User("Fedor", "fedot@gmail.com", 55));
            //CRUD.CreateUser(new User("Vovan", "vovan@gmail.com", 44));
            //CRUD.CreateUser(new User("Semen", "semen@gmail.com", 34));

            CRUD.CreateTestTeam(new Team("Team1"));
            CRUD.CreateTestTeam(new Team("Team2"));
            CRUD.CreateTestTeam(new Team("Team3"));

        }
    }
}
