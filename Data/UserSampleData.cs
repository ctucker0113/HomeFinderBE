using HomeFinderBE.Models;
using static System.Net.Mime.MediaTypeNames;

namespace HomeFinderBE.Data
{
    public class UserSampleData
    {
        public static List<User> Users = new List<User>
        {
            new User
            {
                ID = 1,
                FirstName = "Cody",
                LastName = "Tucker"
            }
        };
    }
}

