using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Booking.Migrations
{
    public partial class FirstOne : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Continent = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Rooms",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BedNo = table.Column<int>(type: "int", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BedType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ResidentNo = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rooms", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Trips",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    From = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    To = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PricePerAdult = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PricePerChild = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IsRoundTrip = table.Column<bool>(type: "bit", nullable: false),
                    MaxNumberOfPassenger = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trips", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CountryId = table.Column<int>(type: "int", nullable: false),
                    FromTopTen = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cities_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserTrips",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TripId = table.Column<int>(type: "int", nullable: false),
                    DepartingDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NoOfAdults = table.Column<int>(type: "int", nullable: false),
                    NoOfChildern = table.Column<int>(type: "int", nullable: false),
                    NoOfInfant = table.Column<int>(type: "int", nullable: false),
                    ReturningDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserTrips", x => new { x.TripId, x.UserId, x.DepartingDate });
                    table.ForeignKey(
                        name: "FK_UserTrips_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserTrips_Trips_TripId",
                        column: x => x.TripId,
                        principalTable: "Trips",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Hotels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CityId = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StarsNo = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hotels", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Hotels_Cities_CityId",
                        column: x => x.CityId,
                        principalTable: "Cities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Bookedrooms",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    HotelId = table.Column<int>(type: "int", nullable: false),
                    RoomId = table.Column<int>(type: "int", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NoOfRooms = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bookedrooms", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Bookedrooms_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Bookedrooms_Hotels_HotelId",
                        column: x => x.HotelId,
                        principalTable: "Hotels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Bookedrooms_Rooms_RoomId",
                        column: x => x.RoomId,
                        principalTable: "Rooms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HotelRooms",
                columns: table => new
                {
                    HotelId = table.Column<int>(type: "int", nullable: false),
                    RoomId = table.Column<int>(type: "int", nullable: false),
                    TotalNoOfThisRoomPerHotel = table.Column<int>(type: "int", nullable: false),
                    PricePerNight = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HotelRooms", x => new { x.HotelId, x.RoomId });
                    table.ForeignKey(
                        name: "FK_HotelRooms_Hotels_HotelId",
                        column: x => x.HotelId,
                        principalTable: "Hotels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HotelRooms_Rooms_RoomId",
                        column: x => x.RoomId,
                        principalTable: "Rooms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Continent", "Name" },
                values: new object[,]
                {
                    { 1, "Europe", "France" },
                    { 2, "Europe", "England" },
                    { 3, "Europe", "Italy" },
                    { 4, "Europe", "Spain" },
                    { 5, "Europe", "netherlands" },
                    { 6, "Europe", "Switzerland" },
                    { 7, "Europe", "Portogal" },
                    { 8, "Europe", "Sweden" },
                    { 9, "Europe", "Austria" },
                    { 10, "Europe", "Germany" },
                    { 11, "Europe", "Greece" },
                    { 12, "Europe", "Türkiye" }
                });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "BedNo", "BedType", "ResidentNo", "Type" },
                values: new object[,]
                {
                    { 1, 1, "single bed", 1, "Single" },
                    { 2, 2, "single bed", 2, "Double" },
                    { 3, 1, "double bed", 2, "Double" },
                    { 4, 3, "twin bed", 3, "Triple" },
                    { 5, 2, "double bed", 3, "Triple" },
                    { 6, 4, "single bed", 4, "Quad" },
                    { 7, 2, "double bed", 4, "Quad" },
                    { 8, 2, "Queen bed", 2, "Queen" }
                });

            migrationBuilder.InsertData(
                table: "Trips",
                columns: new[] { "Id", "From", "IsRoundTrip", "MaxNumberOfPassenger", "PricePerAdult", "PricePerChild", "To" },
                values: new object[,]
                {
                    { 1, "Paris", false, 342, 50m, 40m, "London" },
                    { 2, "Paris", false, 362, 80m, 70m, "Bern" },
                    { 3, "Paris", false, 352, 75m, 70m, "Berlin" },
                    { 4, "Paris", false, 352, 85m, 77m, "Athens" },
                    { 5, "Paris", false, 352, 85m, 77m, "Amsterdam" },
                    { 6, "London", false, 342, 52m, 45m, "Paris" },
                    { 7, "London", false, 378, 60m, 49m, "Bern" },
                    { 8, "London", false, 368, 76m, 70m, "Bern" },
                    { 9, "London", false, 378, 80m, 70m, "Athens" },
                    { 10, "London", false, 378, 80m, 70m, "Amsterdam" },
                    { 11, "Bern", false, 376, 80m, 70m, "Paris" },
                    { 12, "Bern", false, 356, 86m, 79m, "London" },
                    { 13, "Bern", false, 366, 66m, 66m, "Berlin" },
                    { 14, "Bern", false, 353, 53m, 53m, "Athens" },
                    { 15, "Bern", false, 353, 60m, 53m, "Amsterdam" },
                    { 16, "Berlin", false, 376, 84m, 72m, "Paris" },
                    { 17, "Berlin", false, 356, 83m, 79m, "London" },
                    { 18, "Berlin", false, 366, 67m, 66m, "Bern" },
                    { 19, "Berlin", false, 353, 58m, 53m, "Athens" },
                    { 20, "Berlin", false, 353, 64m, 53m, "Amsterdam" },
                    { 21, "Athens", false, 356, 84m, 72m, "Paris" },
                    { 22, "Athens", false, 376, 83m, 79m, "London" }
                });

            migrationBuilder.InsertData(
                table: "Trips",
                columns: new[] { "Id", "From", "IsRoundTrip", "MaxNumberOfPassenger", "PricePerAdult", "PricePerChild", "To" },
                values: new object[,]
                {
                    { 23, "Athens", false, 387, 67m, 66m, "Bern" },
                    { 24, "Athens", false, 390, 58m, 53m, "Berlin" },
                    { 25, "Athens", false, 298, 64m, 53m, "Amsterdam" },
                    { 26, "Amsterdam", false, 346, 86m, 74m, "Paris" },
                    { 27, "Amsterdam", false, 366, 88m, 75m, "London" },
                    { 28, "Amsterdam", false, 377, 66m, 66m, "Bern" },
                    { 29, "Amsterdam", false, 398, 60m, 56m, "Berlin" },
                    { 30, "Amsterdam", false, 310, 59m, 57m, "Athens" },
                    { 31, "Paris", true, 342, 110m, 90m, "London" },
                    { 32, "Paris", true, 362, 190m, 170m, "Bern" },
                    { 33, "Paris", true, 352, 180m, 160m, "Berlin" },
                    { 34, "Paris", true, 352, 185m, 166m, "Athens" },
                    { 35, "Paris", true, 352, 186m, 170m, "Amsterdam" },
                    { 36, "London", true, 342, 120m, 112m, "Paris" },
                    { 37, "London", true, 378, 130m, 120m, "Bern" },
                    { 38, "London", true, 368, 133m, 120m, "Bern" },
                    { 39, "London", true, 378, 170m, 156m, "Athens" },
                    { 40, "London", true, 378, 175m, 160m, "Amsterdam" },
                    { 41, "Bern", true, 376, 180m, 166m, "Paris" },
                    { 42, "Bern", true, 356, 190m, 180m, "London" },
                    { 43, "Bern", true, 366, 175m, 160m, "Berlin" },
                    { 44, "Bern", true, 353, 115m, 100m, "Athens" },
                    { 45, "Bern", true, 353, 135m, 110m, "Amsterdam" },
                    { 46, "Berlin", true, 376, 170m, 160m, "Paris" },
                    { 47, "Berlin", true, 356, 173m, 160m, "London" },
                    { 48, "Berlin", true, 366, 156m, 130m, "Bern" },
                    { 49, "Berlin", true, 353, 130m, 120m, "Athens" },
                    { 50, "Berlin", true, 353, 123m, 113m, "Amsterdam" },
                    { 51, "Athens", true, 356, 176m, 164m, "Paris" },
                    { 52, "Athens", true, 376, 189m, 170m, "London" },
                    { 53, "Athens", true, 387, 190m, 170m, "Bern" },
                    { 54, "Athens", true, 390, 150m, 140m, "Berlin" },
                    { 55, "Athens", true, 298, 140m, 130m, "Amsterdam" },
                    { 56, "Amsterdam", true, 346, 180m, 170m, "Paris" },
                    { 57, "Amsterdam", true, 366, 200m, 170m, "London" },
                    { 58, "Amsterdam", true, 377, 180m, 170m, "Bern" },
                    { 59, "Amsterdam", true, 398, 155m, 135m, "Berlin" },
                    { 60, "Amsterdam", true, 310, 150m, 130m, "Athens" }
                });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "CountryId", "FromTopTen", "Image", "Name" },
                values: new object[,]
                {
                    { 1, 1, false, "paris.jpg", "Paris" },
                    { 2, 2, false, "london.png", "London" },
                    { 3, 2, false, "TrendingDestinations/Liverpool.png", "LiverPool" },
                    { 4, 3, false, "TrendingDestinations/Rome.png", "Rome" },
                    { 5, 3, false, "slide2.jpg", "Venice" },
                    { 6, 5, false, "Amsterdam.png", "Amsterdam" },
                    { 7, 6, false, "TrendingDestinations/Bern.png", "Bern" },
                    { 8, 7, false, "lisbon.png", "Lisbon" },
                    { 9, 8, false, "TrendingDestinations/Stockholm.png", "Stockholm" },
                    { 10, 9, false, "TrendingDestinations/london.png", "Vienna" },
                    { 11, 10, false, "berlin.png", "Berlin" },
                    { 12, 11, false, "TrendingDestinations/Athens.png", "Athens" }
                });

            migrationBuilder.InsertData(
                table: "Hotels",
                columns: new[] { "Id", "CityId", "Description", "Image", "Name", "StarsNo" },
                values: new object[,]
                {
                    { 1, 1, null, "CitiesHotels/ParisHotels/1.Hotel Malte - Astotel.4.jpg", "Hotel Malte - Astotel", 4 },
                    { 2, 1, null, "CitiesHotels/ParisHotels/2.Hotel Astoria - Astotel.3.jpg", "Hotel Astoria - Astotel", 3 },
                    { 3, 1, null, "CitiesHotels/ParisHotels/3.Novotel Paris Les Halles.4.jpg", "Novotel Paris Les Halles", 4 },
                    { 4, 1, null, "CitiesHotels/ParisHotels/4.La Maison Favart.4.jpg", "La Maison Favart", 4 },
                    { 5, 1, null, "CitiesHotels/ParisHotels/5.Hotel Maison Mere.4.jpg", "Hotel Maison Mere", 4 },
                    { 6, 1, null, "CitiesHotels/ParisHotels/6.Grand Hotel du Palais Royal.5.jpg", "Grand Hotel du Palais Royal", 5 },
                    { 7, 1, null, "CitiesHotels/ParisHotels/7.Hotel La Comtesse.4.jpg", "Hotel La Comtesse", 4 },
                    { 8, 1, null, "CitiesHotels/ParisHotels/8.Hotel Joke - Astotel.3.jpg", "Hotel Joke - Astotel", 3 },
                    { 9, 1, null, "CitiesHotels/ParisHotels/9.Generator Paris.5.jpg", "Generator Paris", 5 },
                    { 10, 1, null, "CitiesHotels/ParisHotels/10.Hotel des Arts - Montmartre.4.jpg", "Hotel des Arts - Montmartre", 4 },
                    { 11, 2, null, "CitiesHotels/LondonHotels/1.Shangri-La The Shard.5.webp", "Shangri-La The Shard", 5 },
                    { 12, 2, null, "CitiesHotels/LondonHotels/2.The Montcalm Royal.5.jpg", "The Montcalm Royal", 5 },
                    { 13, 2, null, "CitiesHotels/LondonHotels/3.Royal Lancaster.5.jpg", "Royal Lancaster", 5 },
                    { 14, 2, null, "CitiesHotels/LondonHotels/4.The Chesterfield Mayfair.4.jpg", "The Chesterfield Mayfair", 4 },
                    { 15, 2, null, "CitiesHotels/LondonHotels/5.St. Ermin's Hotel.4.jpg", "St. Ermin's Hotel", 4 },
                    { 16, 2, null, "CitiesHotels/LondonHotels/6.The Savoy.5.jpg", "The Savoy", 5 },
                    { 17, 2, null, "CitiesHotels/LondonHotels/7.The Bloomsbury.5.jpg", "The Bloomsbury", 5 },
                    { 18, 2, null, "CitiesHotels/LondonHotels/8.The Kensington.5.jpg", "The Kensington", 5 },
                    { 19, 2, null, "CitiesHotels/LondonHotels/9.The Montague on The Gardens.4.jpg", "The Montague on The Gardens", 4 },
                    { 20, 2, null, "CitiesHotels/LondonHotels/10.Conrad London St. James.5.jpg", "Conrad London St. James", 5 },
                    { 21, 7, null, "CitiesHotels/BernHotels/1.Hotel Schweizerhof Bern & Spa.5.jpg", "Hotel Schweizerhof Bern", 5 },
                    { 22, 7, null, "CitiesHotels/BernHotels/2.Hotel Jardin Bern.3.jpg", "Hotel Jardin Bern", 3 },
                    { 23, 7, null, "CitiesHotels/BernHotels/3.NH Bern The Bristol.4.jpg", "NH Bern The Bristol", 4 },
                    { 24, 7, null, "CitiesHotels/BernHotels/4.Bellevue Palace.5.jpg", "Bellevue Palace", 5 },
                    { 25, 7, null, "CitiesHotels/BernHotels/5.Hotel Savoy.4.jpg", "Hotel Savoy", 4 },
                    { 26, 7, null, "CitiesHotels/BernHotels/6.Swissotel Kursaal Bern.4.jpg", "Swissotel Kursaal Bern", 4 },
                    { 27, 7, null, "CitiesHotels/BernHotels/7.Hotel Baren am Bundesplatz.4.jpg", "Hotel Baren am Bundesplatz", 4 },
                    { 28, 7, null, "CitiesHotels/BernHotels/8.Best Western Plus Hotel Bern.4.jpg", "Best Western Plus Hotel", 4 },
                    { 29, 7, null, "CitiesHotels/BernHotels/9.Holiday Inn Bern - Westside, an IHG hotel.4.jpg", "Holiday Inn Bern", 4 },
                    { 30, 7, null, "CitiesHotels/BernHotels/10.Novotel Bern Expo.4.jpg", "Novotel Bern Expo", 4 },
                    { 31, 6, null, "CitiesHotels/AmsterdamHotels/1.Ambassade Hotel.4.jpg", "Ambassade Hotel", 4 },
                    { 32, 6, null, "CitiesHotels/AmsterdamHotels/2.Monet Garden Hotel Amsterdam.4.jpg", "Monet Garden Hotel Amsterdam", 4 },
                    { 33, 6, null, "CitiesHotels/AmsterdamHotels/3.Hotel Jakarta Amsterdam.4.jpg", "Hotel Jakarta Amsterdam", 4 },
                    { 34, 6, null, "CitiesHotels/AmsterdamHotels/4.Banks Mansion.4.jpg", "Banks Mansion", 4 },
                    { 35, 6, null, "CitiesHotels/AmsterdamHotels/5.Met Hotel.3.jpg", "Met Hotel", 3 },
                    { 36, 6, null, "CitiesHotels/AmsterdamHotels/6.The Toren.4.jpg", "The Toren", 4 },
                    { 37, 6, null, "CitiesHotels/AmsterdamHotels/7.Eden Hotel Amsterdam.4.jpg", "Eden Hotel Amsterdam", 4 },
                    { 38, 6, null, "CitiesHotels/AmsterdamHotels/8.NH City Centre Amsterdam.4.jpg", "NH City Centre Amsterdam", 4 },
                    { 39, 6, null, "CitiesHotels/AmsterdamHotels/9.Hotel Estherea.4.jpg", "Hotel Estherea", 4 },
                    { 40, 6, null, "CitiesHotels/AmsterdamHotels/10.The Manor Amsterdam.4.jpg", "The Manor Amsterdam", 4 },
                    { 41, 11, null, "CitiesHotels/BerlinHotels/1.The Mandala Hotel.5.jpg", "The Mandala Hotel", 5 },
                    { 42, 11, null, "CitiesHotels/BerlinHotels/2.Grand Hyatt Berlin.5.jpg", "Grand Hyatt Berlin", 5 }
                });

            migrationBuilder.InsertData(
                table: "Hotels",
                columns: new[] { "Id", "CityId", "Description", "Image", "Name", "StarsNo" },
                values: new object[,]
                {
                    { 43, 11, null, "CitiesHotels/BerlinHotels/3.Hotel Zoo Berlin.5.jpg", "Hotel Zoo Berlin", 5 },
                    { 44, 11, null, "CitiesHotels/BerlinHotels/4.Mercure Hotel MOA Berlin.4.jpg", "Mercure Hotel MOA Berlin", 4 },
                    { 45, 11, null, "CitiesHotels/BerlinHotels/5.Steigenberger Hotel Am Kanzleramt.5.jpg", "Steigenberger Hotel", 5 },
                    { 46, 11, null, "CitiesHotels/BerlinHotels/6.The Circus Hotel.3.jpg", "The Circus Hotel", 3 },
                    { 47, 11, null, "CitiesHotels/BerlinHotels/7.Ludwig Van Beethoven Hotel.3.jpg", "Ludwig Van Beethoven", 3 },
                    { 48, 11, null, "CitiesHotels/BerlinHotels/8.Park Inn by Radisson Berlin Alexanderplatz Hotel.4.jpg", "Park Inn by Radisson", 4 },
                    { 49, 11, null, "CitiesHotels/BerlinHotels/9.Meliá Berlin.4.jpg", "Meliá Berlin", 4 },
                    { 50, 11, null, "CitiesHotels/BerlinHotels/10.Hotel Palace Berlin.5.jpg", "Hotel Palace Berlin", 5 },
                    { 51, 12, null, "CitiesHotels/AthensHotels/1.The Social Athens Hotel.4.jpg", "The Social Athens Hotel", 4 },
                    { 52, 12, null, "CitiesHotels/AthensHotels/2.Electra Metropolis Athens.5.jpg", "Electra Metropolis Athens", 5 },
                    { 53, 12, null, "CitiesHotels/AthensHotels/3.Herodion Hotel.4.jpg", "Herodion Hotel", 4 },
                    { 54, 12, null, "CitiesHotels/AthensHotels/4.InnAthens.4.jpg", "InnAthens", 4 },
                    { 55, 12, null, "CitiesHotels/AthensHotels/5.The Athens Gate Hotel.4.jpg", "The Athens Gate Hotel", 4 },
                    { 56, 12, null, "CitiesHotels/AthensHotels/6.Electra Palace Athens.5.jpg", "Electra Palace Athens", 5 },
                    { 57, 12, null, "CitiesHotels/AthensHotels/7.Plaka Hotel.3.jpg", "Plaka Hotel", 3 },
                    { 58, 12, null, "CitiesHotels/AthensHotels/8.Ivis4 Boutique Hotel.4.jpg", "Ivis4 Boutique Hotel", 4 },
                    { 59, 12, null, "CitiesHotels/AthensHotels/9.Hotel Grande Bretagne.5.jpg", "Hotel Grande Bretagne", 5 },
                    { 60, 12, null, "CitiesHotels/AthensHotels/10.Brown Acropol.4.jpg", "Brown Acropol", 4 },
                    { 61, 5, null, "CitiesHotels/VeniceHotels/1.Palazzo Veneziano.4.jpg", "Palazzo Veneziano", 4 },
                    { 62, 5, null, "CitiesHotels/VeniceHotels/2.Hotel Saturnia & International Venezia.4.jpg", "Hotel Saturnia & International Venezia", 4 },
                    { 63, 5, null, "CitiesHotels/VeniceHotels/3.Hotel Antiche Figure.3.jpg", "Hotel Antiche Figure", 3 },
                    { 64, 5, null, "CitiesHotels/VeniceHotels/4.Hotel Moresco.4.jpg", "Hotel Moresco", 4 },
                    { 65, 5, null, "CitiesHotels/VeniceHotels/5.Rosa Salva.3.jpg", "Rosa Salva", 3 },
                    { 66, 5, null, "CitiesHotels/VeniceHotels/6.Hotel Palazzo Stern.4.jpg", "Hotel Palazzo Stern", 4 },
                    { 67, 5, null, "CitiesHotels/VeniceHotels/7.Ruzzini Palace.4.jpg", "Ruzzini Palace", 4 },
                    { 68, 5, null, "CitiesHotels/VeniceHotels/8.Hotel Bucintoro.4.jpg", "Hotel Bucintoro", 4 },
                    { 69, 5, null, "CitiesHotels/VeniceHotels/9.Hotel Savoia & Jolanda.4.jpg", "Hotel Savoia & Jolanda", 4 },
                    { 70, 5, null, "CitiesHotels/VeniceHotels/10.H10 Palazzo Canova.4.jpg ", "Palazzo Canova", 4 },
                    { 71, 10, null, "CitiesHotels/ViennaHotels/1.The Harmonie.4.jpeg", "The Harmonie", 4 },
                    { 72, 10, null, "CitiesHotels/ViennaHotels/2.Austria Classic.3.jpg", "Austria Classic", 3 },
                    { 73, 10, null, "CitiesHotels/ViennaHotels/3.hotel kaiserhof wien.4.jpg", "hotel kaiserhof wien", 4 },
                    { 74, 10, null, "CitiesHotels/ViennaHotels/4.Boutique Hotel am Stephansplatz.4.jpg", "Boutique Hotel am Stephansplatz", 4 },
                    { 75, 10, null, "CitiesHotels/ViennaHotels/5.BoutiqueHOTEL Donauwalzer.3.jpg", "BoutiqueHOTEL Donauwalzer", 3 },
                    { 76, 10, null, "CitiesHotels/ViennaHotels/6.Hotel Imperial Vienna.5.jpg", "Hotel Imperial Vienna", 5 },
                    { 77, 10, null, "CitiesHotels/ViennaHotels/7.Hotel Rathaus Wein & Design.4.jpg", " Hotel Rathaus Wein & Design", 4 },
                    { 78, 10, null, "CitiesHotels/ViennaHotels/8.Andaz Vienna Am Belvedere.5.jpg", "Andaz Vienna Am Belvedere", 5 },
                    { 79, 10, null, "CitiesHotels/ViennaHotels/9.Hollmann Beletage Design & Boutique.4.jpg", "Hollmann Beletage Design & Boutique", 4 },
                    { 80, 10, null, "CitiesHotels/ViennaHotels/10.Hilton Vienna Plaza.5.jpg", " Hilton Vienna Plaza", 5 },
                    { 81, 8, null, "CitiesHotels/LisbonHotels/1.Corpo Santo Historical.5.jpg", "Corpo Santo Historical", 5 },
                    { 82, 8, null, "CitiesHotels/LisbonHotels/2.Hotel Da Baixa.4.jpg", "Hotel Da Baixa", 4 },
                    { 83, 8, null, "CitiesHotels/LisbonHotels/3.Hotel Avenida Palace.5.jpg", "Hotel Avenida Palace", 5 },
                    { 84, 8, null, "CitiesHotels/LisbonHotels/4.Blue Liberdade.3.jpg", "Blue Liberdade", 3 }
                });

            migrationBuilder.InsertData(
                table: "Hotels",
                columns: new[] { "Id", "CityId", "Description", "Image", "Name", "StarsNo" },
                values: new object[,]
                {
                    { 85, 8, null, "CitiesHotels/LisbonHotels/5.Jupiter Lisboa.4.jpg", " Jupiter Lisboa ", 4 },
                    { 86, 8, null, "CitiesHotels/LisbonHotels/6.Hotel Santa Justa.4.jpg", "Hotel Santa Justa", 4 },
                    { 87, 8, null, "CitiesHotels/LisbonHotels/7.Republica Bed & Breakfast & Arts.3.jpg", "Republica Bed & Breakfast & Arts", 3 },
                    { 88, 8, null, "CitiesHotels/LisbonHotels/8.Hotel Britania Art Deco.4.jpg", "Hotel Britania Art Deco", 4 },
                    { 89, 8, null, "CitiesHotels/LisbonHotels/9.1908 Lisboa.4.jpg", "1908 Lisboa", 4 },
                    { 90, 8, null, "CitiesHotels/LisbonHotels/10.Brown's Central.4.jpg", "Brown's Central", 4 },
                    { 91, 3, null, "CitiesHotels/LiverpoolHotels/1.The Resident Liverpool.4.jpg", "The Resident Liverpool", 4 },
                    { 92, 3, null, "CitiesHotels/LiverpoolHotels/2.Hope Street Hotel.4.jpg", "Hope Street Hotel", 4 },
                    { 93, 3, null, "CitiesHotels/LiverpoolHotels/3.Pullman Liverpool.4.jpg", "Pullman Liverpool", 4 },
                    { 94, 3, null, "CitiesHotels/LiverpoolHotels/4.INNSiDE by Melia Liverpool.4.jpg", "INNSiDE by Melia Liverpool", 4 },
                    { 95, 3, null, "CitiesHotels/LiverpoolHotels/5.Titanic Hotel Liverpool.4.jpg", "Titanic Hotel Liverpool", 4 },
                    { 96, 3, null, "CitiesHotels/LiverpoolHotels/6.Quest Liverpool City Centre.4.jpg", "Quest Liverpool City Centre", 4 },
                    { 97, 3, null, "CitiesHotels/LiverpoolHotels/7.Novotel Liverpool Paddington Village.4.jpg", "Novotel Liverpool Paddington Village", 4 },
                    { 98, 3, null, "CitiesHotels/LiverpoolHotels/8.Hard Days Night Hotel.4.jpg", "Hard Days Night Hotel", 4 },
                    { 99, 3, null, "CitiesHotels/LiverpoolHotels/9.Malmaison Liverpool.4.jpg", "Malmaison Liverpool", 4 },
                    { 100, 3, null, "CitiesHotels/LiverpoolHotels/10.Travelodge Liverpool Central.3.jpg", "Travelodge Liverpool Central", 3 },
                    { 101, 4, null, "CitiesHotels/RomeHotels/1.Hotel Artemide.4.jpg", "Hotel Artemide", 4 },
                    { 102, 4, null, "CitiesHotels/RomeHotels/2.Hotel Colosseum.3.jpg", "Hotel Colosseum", 3 },
                    { 103, 4, null, "CitiesHotels/RomeHotels/3.Hotel Barocco.4.jpg", "Hotel Barocco", 4 },
                    { 104, 4, null, "CitiesHotels/RomeHotels/4.Hotel Santa Maria.3.jpg ", "Hotel Santa Maria", 3 },
                    { 105, 4, null, "CitiesHotels/RomeHotels/5.iQ Hotel Roma.4.jpg", "iQ Hotel Roma", 4 },
                    { 106, 4, null, "CitiesHotels/RomeHotels/6.Domidea Hotel.4.jpg", "Domidea Hotel", 4 },
                    { 107, 4, null, "CitiesHotels/RomeHotels/7.Dharma Boutique Hotel & Spa.4.jpg", "Dharma Boutique Hotel & Spa", 4 },
                    { 108, 4, null, "CitiesHotels/RomeHotels/8.Rome Life Hotel.4.jpg", "Rome Life Hotel", 4 },
                    { 109, 4, null, "CitiesHotels/RomeHotels/9.Hotel Savoy Roma.4.jpg", "Hotel Savoy Roma", 4 },
                    { 110, 4, null, "CitiesHotels/RomeHotels/10.Roma Palazzo Cinquecento.5.jpg", "Roma Palazzo Cinquecento", 5 },
                    { 111, 9, null, "CitiesHotels/StockholmHotels/1.Bank Hotel.5.jpg", "Bank Hotel", 5 },
                    { 112, 9, null, "CitiesHotels/StockholmHotels/2.Hotel Rival.4.jpg", "Hotel Rival", 4 },
                    { 113, 9, null, "CitiesHotels/StockholmHotels/3.Nordic Light Hotel.4.jpg", " Nordic Light Hotel ", 4 },
                    { 114, 9, null, "CitiesHotels/StockholmHotels/4.Grand Hotel.5.jpg", "Grand Hotel", 5 },
                    { 115, 9, null, "CitiesHotels/StockholmHotels/5.Downtown Camper by Scandic.4.jpg", "Downtown Camper by Scandic", 4 },
                    { 116, 9, null, "CitiesHotels/StockholmHotels/6.Freys Hotel.4.jpg", "Freys Hotel", 4 },
                    { 117, 9, null, "CitiesHotels/StockholmHotels/7.Radisson Blu Waterfront.4.jpg", "Radisson Blu Waterfront", 4 },
                    { 118, 9, null, "CitiesHotels/StockholmHotels/8.Berns Hotel.4.jpg", "Berns Hotel", 4 },
                    { 119, 9, null, "CitiesHotels/StockholmHotels/9.Motel L Hammarby Sjostad.3.jpg", "Motel L Hammarby Sjostad", 3 },
                    { 120, 9, null, "CitiesHotels/StockholmHotels/10.Haymarket by Scandic.4.jpg", "Haymarket by Scandic", 4 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Bookedrooms_HotelId",
                table: "Bookedrooms",
                column: "HotelId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Bookedrooms_RoomId",
                table: "Bookedrooms",
                column: "RoomId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Bookedrooms_UserId",
                table: "Bookedrooms",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Cities_CountryId",
                table: "Cities",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_HotelRooms_RoomId",
                table: "HotelRooms",
                column: "RoomId");

            migrationBuilder.CreateIndex(
                name: "IX_Hotels_CityId",
                table: "Hotels",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_UserTrips_UserId",
                table: "UserTrips",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Bookedrooms");

            migrationBuilder.DropTable(
                name: "HotelRooms");

            migrationBuilder.DropTable(
                name: "UserTrips");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Hotels");

            migrationBuilder.DropTable(
                name: "Rooms");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Trips");

            migrationBuilder.DropTable(
                name: "Cities");

            migrationBuilder.DropTable(
                name: "Countries");
        }
    }
}
