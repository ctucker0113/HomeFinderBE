using HomeFinderBE.Models;
namespace HomeFinderBE.Data
{
	public class ItemSampleData
	{
		public static List<Item> Items = new List<Item>
		{
			new Item
			{
				ID = 1,
				Name = "Laptop",
				Image = "https://9to5mac.com/wp-content/uploads/sites/6/2023/11/macbook-pro-space-black0000.jpg?quality=82&strip=all&w=1600",
				RoomID = 1
            },

			new Item
			{
				ID = 2,
				Name = "Electric Drill",
				Image = "https://cdn.hswstatic.com/gif/power-drill-1.jpg",
				RoomID = 2
            },

			new Item
			{
				ID = 3,
				Name = "Garden Hose",
				Image = "https://images.thdstatic.com/productImages/889823b6-5f7d-426b-b00a-a7f187b7c276/svn/flexzilla-garden-hoses-hfzg550yw-e-64_600.jpg",
				RoomID = 2
            },

			new Item
			{
				ID = 4,
				Name = "Blender",
				Image = "https://www.cnet.com/a/img/resize/63f281d1fc4aabccc520b46df58a31c209a92b59/hub/2017/05/10/6dd6d29e-422f-4d71-8793-9bfc1e1ce758/kitchenaidblender-1.jpg?auto=webp&fit=crop&height=1200&width=1200",
				RoomID = 3
            },

			new Item
			{
				ID = 5,
				Name = "Running Shoes",
				Image = "https://assets.adidas.com/images/w_600,f_auto,q_auto/fa54b166335a427fad65af9c00a736f9_9366/TERREX_Soulstride_Flow_Trail_Running_Shoes_Black_GX1822_01_standard.jpg",
				RoomID = 1
            }
		};
	}
}


