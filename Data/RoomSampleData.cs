using HomeFinderBE.Models;
using static System.Net.Mime.MediaTypeNames;

namespace HomeFinderBE.Data
{
    public class RoomSampleData
    {
        public static List<Room> Rooms = new List<Room>
        {
            new Room
            {
                ID = 1,
                Name = "Bedroom",
                Image = "https://hips.hearstapps.com/hmg-prod/images/ghk090123homefeature-005-655b97aee4cbc.jpg?crop=0.828xw:1.00xh;0,0&resize=980:*",
                UserID = 1
            },

            new Room
            {
                ID = 2,
                Name = "Garage",
                Image = "https://www.realsimple.com/thmb/VeovlLwOeeZUweFGCdPA97yrNzc=/1500x0/filters:no_upscale():max_bytes(150000):strip_icc()/what-not-to-store-in-a-garage-GettyImages-528094494-61fda36cad814a338fba3cda15073163.jpg",
                UserID = 1
            },

            new Room
            {
                ID = 3,
                Name = "Kitchen",
                Image = "https://www.ikea.com/ext/ingkadam/m/7d967a35b0d7f7fd/original/PH194740.jpg",
                UserID = 1
            },

            new Room
            {
                ID = 4,
                Name = "Bathroom",
                Image = "https://www.houselogic.com/wp-content/uploads/2023/08/easy-clean-modern-bathroom-hero.jpg?crop&resize=2048%2C1365&quality=80",
                UserID = 1
            },

            new Room
            {
                ID = 5,
                Name = "Living Room",
                Image = "https://media.architecturaldigest.com/photos/62f3c04c5489dd66d1d538b9/16:9/w_2560%2Cc_limit/_Hall_St_0256_v2.jpeg",
                UserID = 1
            }
        };
    }
}

