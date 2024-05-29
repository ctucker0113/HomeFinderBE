using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace HomeFinderBE.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ItemTags",
                columns: table => new
                {
                    ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    TagID = table.Column<int>(type: "integer", nullable: false),
                    ItemID = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemTags", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Image = table.Column<string>(type: "text", nullable: true),
                    RoomID = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Rooms",
                columns: table => new
                {
                    ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Image = table.Column<string>(type: "text", nullable: true),
                    UserID = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rooms", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Tags",
                columns: table => new
                {
                    ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tags", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    FirstName = table.Column<string>(type: "text", nullable: false),
                    LastName = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.ID);
                });

            migrationBuilder.InsertData(
                table: "ItemTags",
                columns: new[] { "ID", "ItemID", "TagID" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 2, 2 },
                    { 3, 3, 3 },
                    { 4, 4, 4 },
                    { 5, 5, 5 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "ID", "Image", "Name", "RoomID" },
                values: new object[,]
                {
                    { 1, "https://9to5mac.com/wp-content/uploads/sites/6/2023/11/macbook-pro-space-black0000.jpg?quality=82&strip=all&w=1600", "Laptop", 1 },
                    { 2, "https://cdn.hswstatic.com/gif/power-drill-1.jpg", "Electric Drill", 2 },
                    { 3, "https://images.thdstatic.com/productImages/889823b6-5f7d-426b-b00a-a7f187b7c276/svn/flexzilla-garden-hoses-hfzg550yw-e-64_600.jpg", "Garden Hose", 2 },
                    { 4, "https://www.cnet.com/a/img/resize/63f281d1fc4aabccc520b46df58a31c209a92b59/hub/2017/05/10/6dd6d29e-422f-4d71-8793-9bfc1e1ce758/kitchenaidblender-1.jpg?auto=webp&fit=crop&height=1200&width=1200", "Blender", 3 },
                    { 5, "https://assets.adidas.com/images/w_600,f_auto,q_auto/fa54b166335a427fad65af9c00a736f9_9366/TERREX_Soulstride_Flow_Trail_Running_Shoes_Black_GX1822_01_standard.jpg", "Running Shoes", 1 }
                });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "ID", "Image", "Name", "UserID" },
                values: new object[,]
                {
                    { 1, "https://hips.hearstapps.com/hmg-prod/images/ghk090123homefeature-005-655b97aee4cbc.jpg?crop=0.828xw:1.00xh;0,0&resize=980:*", "Bedroom", 1 },
                    { 2, "https://www.realsimple.com/thmb/VeovlLwOeeZUweFGCdPA97yrNzc=/1500x0/filters:no_upscale():max_bytes(150000):strip_icc()/what-not-to-store-in-a-garage-GettyImages-528094494-61fda36cad814a338fba3cda15073163.jpg", "Garage", 1 },
                    { 3, "https://www.ikea.com/ext/ingkadam/m/7d967a35b0d7f7fd/original/PH194740.jpg", "Kitchen", 1 },
                    { 4, "https://www.houselogic.com/wp-content/uploads/2023/08/easy-clean-modern-bathroom-hero.jpg?crop&resize=2048%2C1365&quality=80", "Bathroom", 1 },
                    { 5, "https://media.architecturaldigest.com/photos/62f3c04c5489dd66d1d538b9/16:9/w_2560%2Cc_limit/_Hall_St_0256_v2.jpeg", "Living Room", 1 }
                });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "ID", "Name" },
                values: new object[,]
                {
                    { 1, "Electronics" },
                    { 2, "Tools" },
                    { 3, "Garden" },
                    { 4, "Kitchen" },
                    { 5, "Sports" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "ID", "FirstName", "LastName" },
                values: new object[] { 1, "Cody", "Tucker" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ItemTags");

            migrationBuilder.DropTable(
                name: "Items");

            migrationBuilder.DropTable(
                name: "Rooms");

            migrationBuilder.DropTable(
                name: "Tags");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
