using MongoDB.Bson;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemProgramm
{
    public class Team
    {
        public Team(string team_name)
        {
            TeamName = team_name;
        }

        public string TeamName { get; set; }
        public ObjectId Id;
        //public List<User> TeamList;
    }
}
