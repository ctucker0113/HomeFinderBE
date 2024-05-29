using HomeFinderBE.Models;
using static System.Net.Mime.MediaTypeNames;

namespace HomeFinderBE.Data
{
    public class ItemTagSampleData
    {
        public static List<ItemTag> ItemTags = new List<ItemTag>
        {
            new ItemTag
            {
                ID = 1,
                ItemID = 1,
                TagID = 1
            },

            new ItemTag
            {
                ID = 2,
                ItemID = 2,
                TagID = 2
            },

            new ItemTag
            {
                ID = 3,
                ItemID = 3,
                TagID = 3
            },

            new ItemTag
            {
                ID = 4,
                ItemID = 4,
                TagID = 4
            },

            new ItemTag
            {
                ID = 5,
                ItemID = 5,
                TagID = 5
            }
        };
    }
}



