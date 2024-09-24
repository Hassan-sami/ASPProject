using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Booking.Migrations
{
    public partial class Edit2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "From", "PricePerAdult", "PricePerChild", "To" },
                values: new object[] { "Paris", 50m, 40m, "Vienna" });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "From", "MaxNumberOfPassenger", "PricePerAdult", "PricePerChild", "To" },
                values: new object[] { "Paris", 362, 80m, 70m, "Venice" });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "From", "MaxNumberOfPassenger", "PricePerAdult", "To" },
                values: new object[] { "Paris", 352, 75m, "Stockholm" });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "From", "MaxNumberOfPassenger", "PricePerAdult", "PricePerChild", "To" },
                values: new object[] { "Paris", 352, 85m, 77m, "Rome" });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "From", "MaxNumberOfPassenger", "PricePerAdult", "PricePerChild", "To" },
                values: new object[] { "Paris", 352, 85m, 77m, "LiverPool" });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "From", "MaxNumberOfPassenger", "PricePerAdult", "PricePerChild", "To" },
                values: new object[] { "Paris", 352, 85m, 77m, "Lisbon" });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "From", "MaxNumberOfPassenger", "PricePerAdult", "PricePerChild", "To" },
                values: new object[] { "London", 342, 52m, 45m, "Paris" });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "From", "MaxNumberOfPassenger", "PricePerAdult", "PricePerChild", "To" },
                values: new object[] { "London", 378, 60m, 49m, "Bern" });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "From", "MaxNumberOfPassenger", "PricePerAdult", "PricePerChild", "To" },
                values: new object[] { "London", 368, 76m, 70m, "Berlin" });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "From", "MaxNumberOfPassenger", "PricePerAdult", "PricePerChild", "To" },
                values: new object[] { "London", 378, 80m, 70m, "Athens" });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "From", "MaxNumberOfPassenger", "PricePerAdult", "PricePerChild", "To" },
                values: new object[] { "London", 378, 80m, 70m, "Amsterdam" });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "From", "MaxNumberOfPassenger", "PricePerAdult", "PricePerChild", "To" },
                values: new object[] { "London", 342, 52m, 45m, "Vienna" });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "From", "MaxNumberOfPassenger", "PricePerAdult", "PricePerChild", "To" },
                values: new object[] { "London", 378, 60m, 49m, "Venice" });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "From", "MaxNumberOfPassenger", "PricePerAdult", "PricePerChild", "To" },
                values: new object[] { "London", 368, 76m, 70m, "Stockholm" });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "From", "MaxNumberOfPassenger", "PricePerAdult", "PricePerChild", "To" },
                values: new object[] { "London", 378, 80m, 70m, "Rome" });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "From", "MaxNumberOfPassenger", "PricePerAdult", "PricePerChild", "To" },
                values: new object[] { "London", 378, 80m, 70m, "LiverPool" });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "From", "MaxNumberOfPassenger", "PricePerAdult", "PricePerChild", "To" },
                values: new object[] { "London", 378, 80m, 70m, "Lisbon" });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "From", "MaxNumberOfPassenger", "PricePerAdult", "PricePerChild", "To" },
                values: new object[] { "Bern", 376, 80m, 70m, "Paris" });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "From", "MaxNumberOfPassenger", "PricePerAdult", "PricePerChild", "To" },
                values: new object[] { "Bern", 356, 86m, 79m, "London" });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "From", "MaxNumberOfPassenger", "PricePerAdult", "PricePerChild", "To" },
                values: new object[] { "Bern", 366, 66m, 66m, "Berlin" });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "From", "MaxNumberOfPassenger", "PricePerAdult", "PricePerChild", "To" },
                values: new object[] { "Bern", 353, 53m, 53m, "Athens" });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "From", "MaxNumberOfPassenger", "PricePerAdult", "PricePerChild", "To" },
                values: new object[] { "Bern", 353, 60m, 53m, "Amsterdam" });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "From", "MaxNumberOfPassenger", "PricePerAdult", "PricePerChild", "To" },
                values: new object[] { "Bern", 376, 80m, 70m, "Vienna" });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "From", "MaxNumberOfPassenger", "PricePerAdult", "PricePerChild", "To" },
                values: new object[] { "Bern", 356, 86m, 79m, "Venice" });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "From", "MaxNumberOfPassenger", "PricePerAdult", "PricePerChild", "To" },
                values: new object[] { "Bern", 366, 66m, 66m, "Stockholm" });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "From", "IsRoundTrip", "MaxNumberOfPassenger", "PricePerAdult", "PricePerChild", "To" },
                values: new object[] { "Bern", false, 353, 53m, 53m, "Rome" });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "From", "IsRoundTrip", "MaxNumberOfPassenger", "PricePerAdult", "PricePerChild", "To" },
                values: new object[] { "Bern", false, 353, 60m, 53m, "LiverPool" });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "From", "IsRoundTrip", "MaxNumberOfPassenger", "PricePerAdult", "PricePerChild", "To" },
                values: new object[] { "Bern", false, 353, 60m, 53m, "Lisbon" });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "From", "IsRoundTrip", "MaxNumberOfPassenger", "PricePerAdult", "PricePerChild", "To" },
                values: new object[] { "Berlin", false, 376, 84m, 72m, "Paris" });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "From", "IsRoundTrip", "MaxNumberOfPassenger", "PricePerAdult", "PricePerChild", "To" },
                values: new object[] { "Berlin", false, 356, 83m, 79m, "London" });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "From", "IsRoundTrip", "MaxNumberOfPassenger", "PricePerAdult", "PricePerChild", "To" },
                values: new object[] { "Berlin", false, 366, 67m, 66m, "Bern" });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "From", "IsRoundTrip", "MaxNumberOfPassenger", "PricePerAdult", "PricePerChild", "To" },
                values: new object[] { "Berlin", false, 353, 58m, 53m, "Athens" });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "From", "IsRoundTrip", "MaxNumberOfPassenger", "PricePerAdult", "PricePerChild", "To" },
                values: new object[] { "Berlin", false, 353, 64m, 53m, "Amsterdam" });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "From", "IsRoundTrip", "MaxNumberOfPassenger", "PricePerAdult", "PricePerChild", "To" },
                values: new object[] { "Berlin", false, 376, 84m, 72m, "Vienna" });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "From", "IsRoundTrip", "MaxNumberOfPassenger", "PricePerAdult", "PricePerChild", "To" },
                values: new object[] { "Berlin", false, 356, 83m, 79m, "Venice" });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "From", "IsRoundTrip", "MaxNumberOfPassenger", "PricePerAdult", "PricePerChild", "To" },
                values: new object[] { "Berlin", false, 366, 67m, 66m, "Stockholm" });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "From", "IsRoundTrip", "MaxNumberOfPassenger", "PricePerAdult", "PricePerChild", "To" },
                values: new object[] { "Berlin", false, 353, 58m, 53m, "Rome" });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "From", "IsRoundTrip", "MaxNumberOfPassenger", "PricePerAdult", "PricePerChild", "To" },
                values: new object[] { "Berlin", false, 353, 64m, 53m, "LiverPool" });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "From", "IsRoundTrip", "PricePerAdult", "PricePerChild", "To" },
                values: new object[] { "Berlin", false, 64m, 53m, "Lisbon" });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "From", "IsRoundTrip", "MaxNumberOfPassenger", "PricePerAdult", "PricePerChild", "To" },
                values: new object[] { "Athens", false, 356, 84m, 72m, "Paris" });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "From", "IsRoundTrip", "PricePerAdult", "PricePerChild", "To" },
                values: new object[] { "Athens", false, 83m, 79m, "London" });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "From", "IsRoundTrip", "MaxNumberOfPassenger", "PricePerAdult", "PricePerChild", "To" },
                values: new object[] { "Athens", false, 387, 67m, 66m, "Bern" });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "From", "IsRoundTrip", "MaxNumberOfPassenger", "PricePerAdult", "PricePerChild", "To" },
                values: new object[] { "Athens", false, 390, 58m, 53m, "Berlin" });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "From", "IsRoundTrip", "MaxNumberOfPassenger", "PricePerAdult", "PricePerChild", "To" },
                values: new object[] { "Athens", false, 298, 64m, 53m, "Amsterdam" });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "From", "IsRoundTrip", "MaxNumberOfPassenger", "PricePerAdult", "PricePerChild", "To" },
                values: new object[] { "Athens", false, 356, 84m, 72m, "Vienna" });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "IsRoundTrip", "MaxNumberOfPassenger", "PricePerAdult", "PricePerChild", "To" },
                values: new object[] { false, 376, 83m, 79m, "Venice" });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "IsRoundTrip", "MaxNumberOfPassenger", "PricePerAdult", "PricePerChild", "To" },
                values: new object[] { false, 387, 67m, 66m, "Stockholm" });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "IsRoundTrip", "MaxNumberOfPassenger", "PricePerAdult", "PricePerChild", "To" },
                values: new object[] { false, 390, 58m, 53m, "Rome" });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "IsRoundTrip", "MaxNumberOfPassenger", "PricePerAdult", "PricePerChild", "To" },
                values: new object[] { false, 298, 64m, 53m, "LiverPool" });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "IsRoundTrip", "PricePerAdult", "PricePerChild", "To" },
                values: new object[] { false, 64m, 53m, "Lisbon" });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "IsRoundTrip", "PricePerAdult", "PricePerChild" },
                values: new object[] { false, 86m, 74m });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "IsRoundTrip", "PricePerAdult", "PricePerChild" },
                values: new object[] { false, 88m, 75m });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "IsRoundTrip", "PricePerAdult", "PricePerChild" },
                values: new object[] { false, 66m, 66m });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "IsRoundTrip", "PricePerAdult", "PricePerChild" },
                values: new object[] { false, 60m, 56m });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "IsRoundTrip", "PricePerAdult", "PricePerChild" },
                values: new object[] { false, 59m, 57m });

            migrationBuilder.InsertData(
                table: "Trips",
                columns: new[] { "Id", "From", "IsRoundTrip", "MaxNumberOfPassenger", "PricePerAdult", "PricePerChild", "To" },
                values: new object[,]
                {
                    { 61, "Amsterdam", false, 346, 86m, 74m, "Vienna" },
                    { 62, "Amsterdam", false, 346, 86m, 74m, "Venice" },
                    { 63, "Amsterdam", false, 366, 88m, 75m, "Stockholm" },
                    { 64, "Amsterdam", false, 377, 66m, 66m, "Rome" },
                    { 65, "Amsterdam", false, 398, 60m, 56m, "LiverPool" },
                    { 66, "Amsterdam", false, 310, 59m, 57m, "Lisbon" },
                    { 67, "Vienna", false, 342, 50m, 40m, "London" },
                    { 68, "Vienna", false, 362, 80m, 70m, "Bern" },
                    { 69, "Vienna", false, 352, 75m, 70m, "Berlin" },
                    { 70, "Vienna", false, 352, 85m, 77m, "Athens" },
                    { 71, "Vienna", false, 352, 85m, 77m, "Amsterdam" },
                    { 72, "Vienna", false, 342, 50m, 40m, "Paris" },
                    { 73, "Vienna", false, 362, 80m, 70m, "Venice" },
                    { 74, "Vienna", false, 352, 75m, 70m, "Stockholm" },
                    { 75, "Vienna", false, 352, 85m, 77m, "Rome" },
                    { 76, "Vienna", false, 352, 85m, 77m, "LiverPool" },
                    { 77, "Vienna", false, 352, 85m, 77m, "Lisbon" },
                    { 78, "Venice", false, 342, 52m, 45m, "Paris" },
                    { 79, "Venice", false, 378, 60m, 49m, "Bern" },
                    { 80, "Venice", false, 368, 76m, 70m, "Berlin" },
                    { 81, "Venice", false, 378, 80m, 70m, "Athens" },
                    { 82, "Venice", false, 378, 80m, 70m, "Amsterdam" },
                    { 83, "Venice", false, 342, 52m, 45m, "Vienna" },
                    { 84, "Venice", false, 378, 60m, 49m, "London" },
                    { 85, "Venice", false, 368, 76m, 70m, "Stockholm" },
                    { 86, "Venice", false, 378, 80m, 70m, "Rome" },
                    { 87, "Venice", false, 378, 80m, 70m, "LiverPool" },
                    { 88, "Venice", false, 378, 80m, 70m, "Lisbon" },
                    { 89, "Stockholm", false, 376, 80m, 70m, "Paris" }
                });

            migrationBuilder.InsertData(
                table: "Trips",
                columns: new[] { "Id", "From", "IsRoundTrip", "MaxNumberOfPassenger", "PricePerAdult", "PricePerChild", "To" },
                values: new object[,]
                {
                    { 90, "Stockholm", false, 356, 86m, 79m, "London" },
                    { 91, "Stockholm", false, 366, 66m, 66m, "Berlin" },
                    { 92, "Stockholm", false, 353, 53m, 53m, "Athens" },
                    { 93, "Stockholm", false, 353, 60m, 53m, "Amsterdam" },
                    { 94, "Stockholm", false, 376, 80m, 70m, "Vienna" },
                    { 95, "Stockholm", false, 356, 86m, 79m, "Venice" },
                    { 96, "Stockholm", false, 366, 66m, 66m, "Bern" },
                    { 97, "Stockholm", false, 353, 53m, 53m, "Rome" },
                    { 98, "Stockholm", false, 353, 60m, 53m, "LiverPool" },
                    { 99, "Stockholm", false, 353, 60m, 53m, "Lisbon" },
                    { 100, "Rome", false, 376, 84m, 72m, "Paris" },
                    { 101, "Rome", false, 356, 83m, 79m, "London" },
                    { 102, "Rome", false, 366, 67m, 66m, "Bern" },
                    { 103, "Rome", false, 353, 58m, 53m, "Athens" },
                    { 104, "Rome", false, 353, 64m, 53m, "Amsterdam" },
                    { 105, "Rome", false, 376, 84m, 72m, "Vienna" },
                    { 106, "Rome", false, 356, 83m, 79m, "Venice" },
                    { 107, "Rome", false, 366, 67m, 66m, "Stockholm" },
                    { 108, "Rome", false, 353, 58m, 53m, "Berlin" },
                    { 109, "Rome", false, 353, 64m, 53m, "LiverPool" },
                    { 110, "Rome", false, 353, 64m, 53m, "Lisbon" },
                    { 111, "LiverPool", false, 356, 84m, 72m, "Paris" },
                    { 112, "LiverPool", false, 376, 83m, 79m, "London" },
                    { 113, "LiverPool", false, 387, 67m, 66m, "Bern" },
                    { 114, "LiverPool", false, 390, 58m, 53m, "Berlin" },
                    { 115, "LiverPool", false, 298, 64m, 53m, "Amsterdam" },
                    { 116, "LiverPool", false, 356, 84m, 72m, "Vienna" },
                    { 117, "LiverPool", false, 376, 83m, 79m, "Venice" },
                    { 118, "LiverPool", false, 387, 67m, 66m, "Stockholm" },
                    { 119, "LiverPool", false, 390, 58m, 53m, "Rome" },
                    { 120, "LiverPool", false, 298, 64m, 53m, "Athens" },
                    { 121, "LiverPool", false, 298, 64m, 53m, "Lisbon" },
                    { 122, "Lisbon", false, 346, 86m, 74m, "Paris" },
                    { 123, "Lisbon", false, 366, 88m, 75m, "London" },
                    { 124, "Lisbon", false, 377, 66m, 66m, "Bern" },
                    { 125, "Lisbon", false, 398, 60m, 56m, "Berlin" },
                    { 126, "Lisbon", false, 310, 59m, 57m, "Athens" },
                    { 127, "Lisbon", false, 346, 86m, 74m, "Vienna" },
                    { 128, "Lisbon", false, 346, 86m, 74m, "Venice" },
                    { 129, "Lisbon", false, 366, 88m, 75m, "Stockholm" },
                    { 130, "Lisbon", false, 377, 66m, 66m, "Rome" },
                    { 131, "Lisbon", false, 398, 60m, 56m, "LiverPool" }
                });

            migrationBuilder.InsertData(
                table: "Trips",
                columns: new[] { "Id", "From", "IsRoundTrip", "MaxNumberOfPassenger", "PricePerAdult", "PricePerChild", "To" },
                values: new object[,]
                {
                    { 132, "Lisbon", false, 310, 59m, 57m, "Amsterdam" },
                    { 133, "Paris", true, 342, 110m, 90m, "London" },
                    { 134, "Paris", true, 362, 190m, 170m, "Bern" },
                    { 135, "Paris", true, 352, 180m, 160m, "Berlin" },
                    { 136, "Paris", true, 352, 185m, 166m, "Athens" },
                    { 137, "Paris", true, 352, 186m, 170m, "Amsterdam" },
                    { 138, "Paris", true, 342, 110m, 90m, "Vienna" },
                    { 139, "Paris", true, 342, 110m, 90m, "Venice" },
                    { 140, "Paris", true, 362, 190m, 170m, "Stockholm" },
                    { 141, "Paris", true, 352, 180m, 160m, "Rome" },
                    { 142, "Paris", true, 352, 185m, 166m, "LiverPool" },
                    { 143, "Paris", true, 352, 186m, 170m, "Lisbon" },
                    { 144, "London", true, 342, 120m, 112m, "Paris" },
                    { 145, "London", true, 378, 130m, 120m, "Bern" },
                    { 146, "London", true, 368, 133m, 120m, "Berlin" },
                    { 147, "London", true, 378, 170m, 156m, "Athens" },
                    { 148, "London", true, 378, 175m, 160m, "Amsterdam" },
                    { 149, "London", true, 342, 120m, 112m, "Vienna" },
                    { 150, "London", true, 378, 130m, 120m, "Venice" },
                    { 151, "London", true, 368, 133m, 120m, "Stockholm" },
                    { 152, "London", true, 378, 170m, 156m, "Rome" },
                    { 153, "London", true, 378, 175m, 160m, "LiverPool" },
                    { 154, "London", true, 378, 175m, 160m, "Lisbon" },
                    { 155, "Bern", true, 376, 180m, 166m, "Paris" },
                    { 156, "Bern", true, 356, 190m, 180m, "London" },
                    { 157, "Bern", true, 366, 175m, 160m, "Berlin" },
                    { 158, "Bern", true, 353, 115m, 100m, "Athens" },
                    { 159, "Bern", true, 353, 135m, 110m, "Amsterdam" },
                    { 160, "Bern", true, 376, 180m, 166m, "Vienna" },
                    { 161, "Bern", true, 356, 190m, 180m, "Venice" },
                    { 162, "Bern", true, 366, 175m, 160m, "Stockholm" },
                    { 163, "Bern", true, 353, 115m, 100m, "Rome" },
                    { 164, "Bern", true, 353, 135m, 110m, "LiverPool" },
                    { 165, "Bern", true, 353, 135m, 110m, "Lisbon" },
                    { 166, "Berlin", true, 376, 170m, 160m, "Paris" },
                    { 167, "Berlin", true, 356, 173m, 160m, "London" },
                    { 168, "Berlin", true, 366, 156m, 130m, "Bern" },
                    { 169, "Berlin", true, 353, 130m, 120m, "Athens" },
                    { 170, "Berlin", true, 353, 123m, 113m, "Amsterdam" },
                    { 171, "Berlin", true, 376, 170m, 160m, "Vienna" },
                    { 172, "Berlin", true, 356, 173m, 160m, "Venice" },
                    { 173, "Berlin", true, 366, 156m, 130m, "Stockholm" }
                });

            migrationBuilder.InsertData(
                table: "Trips",
                columns: new[] { "Id", "From", "IsRoundTrip", "MaxNumberOfPassenger", "PricePerAdult", "PricePerChild", "To" },
                values: new object[,]
                {
                    { 174, "Berlin", true, 353, 130m, 120m, "Rome" },
                    { 175, "Berlin", true, 353, 123m, 113m, "LiverPool" },
                    { 176, "Berlin", true, 353, 123m, 113m, "Lisbon" },
                    { 177, "Athens", true, 356, 176m, 164m, "Paris" },
                    { 178, "Athens", true, 376, 189m, 170m, "London" },
                    { 179, "Athens", true, 387, 190m, 170m, "Bern" },
                    { 180, "Athens", true, 390, 150m, 140m, "Berlin" },
                    { 181, "Athens", true, 298, 140m, 130m, "Amsterdam" },
                    { 182, "Athens", true, 356, 176m, 164m, "Vienna" },
                    { 183, "Athens", true, 376, 189m, 170m, "Venice" },
                    { 184, "Athens", true, 387, 190m, 170m, "Stockholm" },
                    { 185, "Athens", true, 390, 150m, 140m, "Rome" },
                    { 186, "Athens", true, 298, 140m, 130m, "LiverPool" },
                    { 187, "Athens", true, 298, 140m, 130m, "Lisbon" },
                    { 188, "Amsterdam", true, 346, 180m, 170m, "Paris" },
                    { 189, "Amsterdam", true, 366, 200m, 170m, "London" },
                    { 190, "Amsterdam", true, 377, 180m, 170m, "Bern" },
                    { 191, "Amsterdam", true, 398, 155m, 135m, "Berlin" },
                    { 192, "Amsterdam", true, 310, 150m, 130m, "Athens" },
                    { 193, "Amsterdam", true, 346, 180m, 170m, "Vienna" },
                    { 194, "Amsterdam", true, 366, 200m, 170m, "Venice" },
                    { 195, "Amsterdam", true, 377, 180m, 170m, "Stockholm" },
                    { 196, "Amsterdam", true, 398, 155m, 135m, "Rome" },
                    { 197, "Amsterdam", true, 310, 150m, 130m, "LiverPool" },
                    { 198, "Amsterdam", true, 310, 150m, 130m, "Lisbon" },
                    { 199, "Vienna", true, 342, 110m, 90m, "London" },
                    { 200, "Vienna", true, 362, 190m, 170m, "Bern" },
                    { 201, "Vienna", true, 352, 180m, 160m, "Berlin" },
                    { 202, "Vienna", true, 352, 185m, 166m, "Athens" },
                    { 203, "Vienna", true, 352, 186m, 170m, "Amsterdam" },
                    { 204, "Vienna", true, 342, 110m, 90m, "Paris" },
                    { 205, "Vienna", true, 342, 110m, 90m, "Venice" },
                    { 206, "Vienna", true, 362, 190m, 170m, "Stockholm" },
                    { 207, "Vienna", true, 352, 180m, 160m, "Rome" },
                    { 208, "Vienna", true, 352, 185m, 166m, "LiverPool" },
                    { 209, "Vienna", true, 352, 186m, 170m, "Lisbon" },
                    { 210, "Venice", true, 342, 120m, 112m, "Paris" },
                    { 211, "Venice", true, 378, 130m, 120m, "Bern" },
                    { 212, "Venice", true, 368, 133m, 120m, "Berlin" },
                    { 213, "Venice", true, 378, 170m, 156m, "Athens" },
                    { 214, "Venice", true, 378, 175m, 160m, "Amsterdam" },
                    { 215, "Venice", true, 342, 120m, 112m, "Vienna" }
                });

            migrationBuilder.InsertData(
                table: "Trips",
                columns: new[] { "Id", "From", "IsRoundTrip", "MaxNumberOfPassenger", "PricePerAdult", "PricePerChild", "To" },
                values: new object[,]
                {
                    { 216, "Venice", true, 378, 130m, 120m, "London" },
                    { 217, "Venice", true, 368, 133m, 120m, "Stockholm" },
                    { 218, "Venice", true, 378, 170m, 156m, "Rome" },
                    { 219, "Venice", true, 378, 175m, 160m, "LiverPool" },
                    { 220, "Venice", true, 378, 175m, 160m, "Lisbon" },
                    { 221, "Stockholm", true, 376, 180m, 166m, "Paris" },
                    { 222, "Stockholm", true, 356, 190m, 180m, "London" },
                    { 223, "Stockholm", true, 366, 175m, 160m, "Berlin" },
                    { 224, "Stockholm", true, 353, 115m, 100m, "Athens" },
                    { 225, "Stockholm", true, 353, 135m, 110m, "Amsterdam" },
                    { 226, "Stockholm", true, 376, 180m, 166m, "Vienna" },
                    { 227, "Stockholm", true, 356, 190m, 180m, "Venice" },
                    { 228, "Stockholm", true, 366, 175m, 160m, "Bern" },
                    { 229, "Stockholm", true, 353, 115m, 100m, "Rome" },
                    { 230, "Stockholm", true, 353, 135m, 110m, "LiverPool" },
                    { 231, "Stockholm", true, 353, 135m, 110m, "Lisbon" },
                    { 232, "Rome", true, 376, 170m, 160m, "Paris" },
                    { 233, "Rome", true, 356, 173m, 160m, "London" },
                    { 234, "Rome", true, 366, 156m, 130m, "Bern" },
                    { 235, "Rome", true, 353, 130m, 120m, "Athens" },
                    { 236, "Rome", true, 353, 123m, 113m, "Amsterdam" },
                    { 237, "Rome", true, 376, 170m, 160m, "Vienna" },
                    { 238, "Rome", true, 356, 173m, 160m, "Venice" },
                    { 239, "Rome", true, 366, 156m, 130m, "Stockholm" },
                    { 240, "Rome", true, 353, 130m, 120m, "Berlin" },
                    { 241, "Rome", true, 353, 123m, 113m, "LiverPool" },
                    { 242, "Rome", true, 353, 123m, 113m, "Lisbon" },
                    { 243, "LiverPool", true, 356, 176m, 164m, "Paris" },
                    { 244, "LiverPool", true, 376, 189m, 170m, "London" },
                    { 245, "LiverPool", true, 387, 190m, 170m, "Bern" },
                    { 246, "LiverPool", true, 390, 150m, 140m, "Berlin" },
                    { 247, "LiverPool", true, 298, 140m, 130m, "Amsterdam" },
                    { 248, "LiverPool", true, 356, 176m, 164m, "Vienna" },
                    { 249, "LiverPool", true, 376, 189m, 170m, "Venice" },
                    { 250, "LiverPool", true, 387, 190m, 170m, "Stockholm" },
                    { 251, "LiverPool", true, 390, 150m, 140m, "Rome" },
                    { 252, "LiverPool", true, 298, 140m, 130m, "Athens" },
                    { 253, "LiverPool", true, 298, 140m, 130m, "Lisbon" },
                    { 254, "Lisbon", true, 346, 180m, 170m, "Paris" },
                    { 255, "Lisbon", true, 366, 200m, 170m, "London" },
                    { 256, "Lisbon", true, 377, 180m, 170m, "Bern" },
                    { 257, "Lisbon", true, 398, 155m, 135m, "Berlin" }
                });

            migrationBuilder.InsertData(
                table: "Trips",
                columns: new[] { "Id", "From", "IsRoundTrip", "MaxNumberOfPassenger", "PricePerAdult", "PricePerChild", "To" },
                values: new object[,]
                {
                    { 258, "Lisbon", true, 310, 150m, 130m, "Athens" },
                    { 259, "Lisbon", true, 346, 180m, 170m, "Vienna" },
                    { 260, "Lisbon", true, 366, 200m, 170m, "Venice" },
                    { 261, "Lisbon", true, 377, 180m, 170m, "Stockholm" },
                    { 262, "Lisbon", true, 398, 155m, 135m, "Rome" },
                    { 263, "Lisbon", true, 310, 150m, 130m, "LiverPool" },
                    { 264, "Lisbon", true, 310, 150m, 130m, "Amsterdam" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 198);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 199);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 203);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 204);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 205);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 206);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 207);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 208);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 209);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 210);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 211);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 212);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 213);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 214);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 215);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 216);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 217);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 218);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 219);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 220);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 221);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 222);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 223);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 224);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 225);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 226);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 227);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 228);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 229);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 230);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 231);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 232);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 233);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 234);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 235);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 236);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 237);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 238);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 239);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 240);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 241);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 242);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 243);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 244);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 245);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 246);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 247);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 248);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 249);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 250);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 251);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 252);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 253);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 254);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 255);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 256);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 257);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 258);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 259);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 260);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 261);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 262);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 263);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 264);

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "From", "PricePerAdult", "PricePerChild", "To" },
                values: new object[] { "London", 52m, 45m, "Paris" });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "From", "MaxNumberOfPassenger", "PricePerAdult", "PricePerChild", "To" },
                values: new object[] { "London", 378, 60m, 49m, "Bern" });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "From", "MaxNumberOfPassenger", "PricePerAdult", "To" },
                values: new object[] { "London", 368, 76m, "Bern" });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "From", "MaxNumberOfPassenger", "PricePerAdult", "PricePerChild", "To" },
                values: new object[] { "London", 378, 80m, 70m, "Athens" });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "From", "MaxNumberOfPassenger", "PricePerAdult", "PricePerChild", "To" },
                values: new object[] { "London", 378, 80m, 70m, "Amsterdam" });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "From", "MaxNumberOfPassenger", "PricePerAdult", "PricePerChild", "To" },
                values: new object[] { "Bern", 376, 80m, 70m, "Paris" });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "From", "MaxNumberOfPassenger", "PricePerAdult", "PricePerChild", "To" },
                values: new object[] { "Bern", 356, 86m, 79m, "London" });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "From", "MaxNumberOfPassenger", "PricePerAdult", "PricePerChild", "To" },
                values: new object[] { "Bern", 366, 66m, 66m, "Berlin" });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "From", "MaxNumberOfPassenger", "PricePerAdult", "PricePerChild", "To" },
                values: new object[] { "Bern", 353, 53m, 53m, "Athens" });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "From", "MaxNumberOfPassenger", "PricePerAdult", "PricePerChild", "To" },
                values: new object[] { "Bern", 353, 60m, 53m, "Amsterdam" });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "From", "MaxNumberOfPassenger", "PricePerAdult", "PricePerChild", "To" },
                values: new object[] { "Berlin", 376, 84m, 72m, "Paris" });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "From", "MaxNumberOfPassenger", "PricePerAdult", "PricePerChild", "To" },
                values: new object[] { "Berlin", 356, 83m, 79m, "London" });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "From", "MaxNumberOfPassenger", "PricePerAdult", "PricePerChild", "To" },
                values: new object[] { "Berlin", 366, 67m, 66m, "Bern" });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "From", "MaxNumberOfPassenger", "PricePerAdult", "PricePerChild", "To" },
                values: new object[] { "Berlin", 353, 58m, 53m, "Athens" });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "From", "MaxNumberOfPassenger", "PricePerAdult", "PricePerChild", "To" },
                values: new object[] { "Berlin", 353, 64m, 53m, "Amsterdam" });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "From", "MaxNumberOfPassenger", "PricePerAdult", "PricePerChild", "To" },
                values: new object[] { "Athens", 356, 84m, 72m, "Paris" });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "From", "MaxNumberOfPassenger", "PricePerAdult", "PricePerChild", "To" },
                values: new object[] { "Athens", 376, 83m, 79m, "London" });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "From", "MaxNumberOfPassenger", "PricePerAdult", "PricePerChild", "To" },
                values: new object[] { "Athens", 387, 67m, 66m, "Bern" });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "From", "MaxNumberOfPassenger", "PricePerAdult", "PricePerChild", "To" },
                values: new object[] { "Athens", 390, 58m, 53m, "Berlin" });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "From", "MaxNumberOfPassenger", "PricePerAdult", "PricePerChild", "To" },
                values: new object[] { "Athens", 298, 64m, 53m, "Amsterdam" });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "From", "MaxNumberOfPassenger", "PricePerAdult", "PricePerChild", "To" },
                values: new object[] { "Amsterdam", 346, 86m, 74m, "Paris" });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "From", "MaxNumberOfPassenger", "PricePerAdult", "PricePerChild", "To" },
                values: new object[] { "Amsterdam", 366, 88m, 75m, "London" });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "From", "MaxNumberOfPassenger", "PricePerAdult", "PricePerChild", "To" },
                values: new object[] { "Amsterdam", 377, 66m, 66m, "Bern" });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "From", "MaxNumberOfPassenger", "PricePerAdult", "PricePerChild", "To" },
                values: new object[] { "Amsterdam", 398, 60m, 56m, "Berlin" });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "From", "MaxNumberOfPassenger", "PricePerAdult", "PricePerChild", "To" },
                values: new object[] { "Amsterdam", 310, 59m, 57m, "Athens" });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "From", "IsRoundTrip", "MaxNumberOfPassenger", "PricePerAdult", "PricePerChild", "To" },
                values: new object[] { "Paris", true, 342, 110m, 90m, "London" });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "From", "IsRoundTrip", "MaxNumberOfPassenger", "PricePerAdult", "PricePerChild", "To" },
                values: new object[] { "Paris", true, 362, 190m, 170m, "Bern" });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "From", "IsRoundTrip", "MaxNumberOfPassenger", "PricePerAdult", "PricePerChild", "To" },
                values: new object[] { "Paris", true, 352, 180m, 160m, "Berlin" });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "From", "IsRoundTrip", "MaxNumberOfPassenger", "PricePerAdult", "PricePerChild", "To" },
                values: new object[] { "Paris", true, 352, 185m, 166m, "Athens" });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "From", "IsRoundTrip", "MaxNumberOfPassenger", "PricePerAdult", "PricePerChild", "To" },
                values: new object[] { "Paris", true, 352, 186m, 170m, "Amsterdam" });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "From", "IsRoundTrip", "MaxNumberOfPassenger", "PricePerAdult", "PricePerChild", "To" },
                values: new object[] { "London", true, 342, 120m, 112m, "Paris" });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "From", "IsRoundTrip", "MaxNumberOfPassenger", "PricePerAdult", "PricePerChild", "To" },
                values: new object[] { "London", true, 378, 130m, 120m, "Bern" });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "From", "IsRoundTrip", "MaxNumberOfPassenger", "PricePerAdult", "PricePerChild", "To" },
                values: new object[] { "London", true, 368, 133m, 120m, "Bern" });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "From", "IsRoundTrip", "MaxNumberOfPassenger", "PricePerAdult", "PricePerChild", "To" },
                values: new object[] { "London", true, 378, 170m, 156m, "Athens" });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "From", "IsRoundTrip", "MaxNumberOfPassenger", "PricePerAdult", "PricePerChild", "To" },
                values: new object[] { "London", true, 378, 175m, 160m, "Amsterdam" });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "From", "IsRoundTrip", "MaxNumberOfPassenger", "PricePerAdult", "PricePerChild", "To" },
                values: new object[] { "Bern", true, 376, 180m, 166m, "Paris" });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "From", "IsRoundTrip", "MaxNumberOfPassenger", "PricePerAdult", "PricePerChild", "To" },
                values: new object[] { "Bern", true, 356, 190m, 180m, "London" });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "From", "IsRoundTrip", "MaxNumberOfPassenger", "PricePerAdult", "PricePerChild", "To" },
                values: new object[] { "Bern", true, 366, 175m, 160m, "Berlin" });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "From", "IsRoundTrip", "PricePerAdult", "PricePerChild", "To" },
                values: new object[] { "Bern", true, 115m, 100m, "Athens" });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "From", "IsRoundTrip", "MaxNumberOfPassenger", "PricePerAdult", "PricePerChild", "To" },
                values: new object[] { "Bern", true, 353, 135m, 110m, "Amsterdam" });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "From", "IsRoundTrip", "PricePerAdult", "PricePerChild", "To" },
                values: new object[] { "Berlin", true, 170m, 160m, "Paris" });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "From", "IsRoundTrip", "MaxNumberOfPassenger", "PricePerAdult", "PricePerChild", "To" },
                values: new object[] { "Berlin", true, 356, 173m, 160m, "London" });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "From", "IsRoundTrip", "MaxNumberOfPassenger", "PricePerAdult", "PricePerChild", "To" },
                values: new object[] { "Berlin", true, 366, 156m, 130m, "Bern" });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "From", "IsRoundTrip", "MaxNumberOfPassenger", "PricePerAdult", "PricePerChild", "To" },
                values: new object[] { "Berlin", true, 353, 130m, 120m, "Athens" });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "From", "IsRoundTrip", "MaxNumberOfPassenger", "PricePerAdult", "PricePerChild", "To" },
                values: new object[] { "Berlin", true, 353, 123m, 113m, "Amsterdam" });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "IsRoundTrip", "MaxNumberOfPassenger", "PricePerAdult", "PricePerChild", "To" },
                values: new object[] { true, 356, 176m, 164m, "Paris" });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "IsRoundTrip", "MaxNumberOfPassenger", "PricePerAdult", "PricePerChild", "To" },
                values: new object[] { true, 376, 189m, 170m, "London" });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "IsRoundTrip", "MaxNumberOfPassenger", "PricePerAdult", "PricePerChild", "To" },
                values: new object[] { true, 387, 190m, 170m, "Bern" });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "IsRoundTrip", "MaxNumberOfPassenger", "PricePerAdult", "PricePerChild", "To" },
                values: new object[] { true, 390, 150m, 140m, "Berlin" });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "IsRoundTrip", "PricePerAdult", "PricePerChild", "To" },
                values: new object[] { true, 140m, 130m, "Amsterdam" });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "IsRoundTrip", "PricePerAdult", "PricePerChild" },
                values: new object[] { true, 180m, 170m });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "IsRoundTrip", "PricePerAdult", "PricePerChild" },
                values: new object[] { true, 200m, 170m });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "IsRoundTrip", "PricePerAdult", "PricePerChild" },
                values: new object[] { true, 180m, 170m });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "IsRoundTrip", "PricePerAdult", "PricePerChild" },
                values: new object[] { true, 155m, 135m });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "IsRoundTrip", "PricePerAdult", "PricePerChild" },
                values: new object[] { true, 150m, 130m });
        }
    }
}
