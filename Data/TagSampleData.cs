using HomeFinderBE.Models;
using static System.Net.Mime.MediaTypeNames;

namespace HomeFinderBE.Data
{
    public class TagSampleData
    {
        public static List<Tag> Tags = new List<Tag>
        {
            new Tag
            {
                ID = 1,
                Name = "Electronics"
            },

            new Tag
            {
                ID = 2,
                Name = "Tools"
            },

            new Tag
            {
                ID = 3,
                Name = "Garden"
            },

            new Tag
            {
                ID = 4,
                Name = "Kitchen"
            },
            new Tag
            {
                ID = 5,
                Name = "Sports"
            }
        };
    }
}
