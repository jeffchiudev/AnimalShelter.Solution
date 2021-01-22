using Microsoft.EntityFrameworkCore.Migrations;

namespace AnimalShelter.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "AnimalId", "Age", "AnimalName", "Breed", "Gender", "Species" },
                values: new object[,]
                {
                    { 1, 2, "Bartleby", "Spitz", "Male", "Dog" },
                    { 2, 12, "Sushi", "Calico", "Female", "Cat" },
                    { 3, 6, "Lester", "American Shorthair", "Male", "Cat" },
                    { 4, 12, "Neville", "English Setter", "Male", "Dog" },
                    { 5, 1000, "Totoro", "Unknown", "NA", "Sprite" }
                });

            migrationBuilder.InsertData(
                table: "Fosters",
                columns: new[] { "FosterId", "FosterAvailability", "FosterEmail", "FosterName" },
                values: new object[,]
                {
                    { 1, true, "jeff@test.com", "Jeff" },
                    { 2, true, "sarah@test.com", "Sarah" },
                    { 3, false, "Doug@test.com", "Doug" },
                    { 4, true, "leon@test.com", "Leon" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Fosters",
                keyColumn: "FosterId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Fosters",
                keyColumn: "FosterId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Fosters",
                keyColumn: "FosterId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Fosters",
                keyColumn: "FosterId",
                keyValue: 4);
        }
    }
}
