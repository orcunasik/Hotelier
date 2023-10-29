using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hotelier.Repository.Migrations
{
    /// <inheritdoc />
    public partial class CreatedDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EmailSubscribes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmailSubscribes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HotelServices",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Icon = table.Column<string>(type: "nvarchar(300)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(300)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(20)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HotelServices", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Rooms",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CoverImage = table.Column<string>(type: "nvarchar(300)", nullable: false),
                    RoomNumber = table.Column<string>(type: "nvarchar(20)", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(300)", nullable: false),
                    BedCount = table.Column<string>(type: "nvarchar(20)", nullable: false),
                    BathCount = table.Column<string>(type: "nvarchar(20)", nullable: false),
                    Wifi = table.Column<string>(type: "nvarchar(20)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(20)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rooms", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Staffs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(30)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(30)", nullable: false),
                    SocialMedia1 = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    SocialMedia2 = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    SocialMedia3 = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(20)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Staffs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Testimonials",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(30)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(30)", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(300)", nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(300)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(20)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Testimonials", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmailSubscribes");

            migrationBuilder.DropTable(
                name: "HotelServices");

            migrationBuilder.DropTable(
                name: "Rooms");

            migrationBuilder.DropTable(
                name: "Staffs");

            migrationBuilder.DropTable(
                name: "Testimonials");
        }
    }
}
