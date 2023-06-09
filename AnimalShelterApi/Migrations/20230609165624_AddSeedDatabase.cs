using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AnimalShelterApi.Migrations
{
    public partial class AddSeedDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "AnimalId", "Age", "Breed", "Name", "Species" },
                values: new object[,]
                {
                    { 1, 1, "Siamese", "Alice", "Cat" },
                    { 2, 3, "Ragdoll", "Barky", "Cat" },
                    { 3, 5, "Ocicat", "Wirey", "Cat" },
                    { 4, 7, "Chausie", "Bianca", "Cat" },
                    { 5, 5, "Abyssinian", "Flame", "Cat" },
                    { 6, 6, "Birman", "Georia", "Cat" },
                    { 7, 7, "Chartreux", "Frisky", "Cat" },
                    { 8, 3, "Himalayan", "Sleepy", "Cat" },
                    { 9, 3, "Lyoki", "Curly", "Cat" },
                    { 10, 11, "Chihuahua", "Bicker", "Dog" },
                    { 11, 4, "Pomeranian", "Snipper", "Dog" },
                    { 12, 4, "Havanese", "Wiley", "Dog" },
                    { 13, 8, "Dachshund", "Frank", "Dog" },
                    { 14, 11, "Bichon", "Charlie", "Dog" },
                    { 15, 9, "Terrier", "Rue", "Dog" },
                    { 16, 5, "Poodle", "Googlie", "Dog" },
                    { 17, 8, "Affenpinscher", "Mike", "Dog" },
                    { 18, 9, "Sarabi", "Wolfie", "Dog" },
                    { 19, 3, "Samoyed", "Chomper", "Dog" },
                    { 20, 15, "Maltipoo", "Sleepy", "Dog" }
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
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 20);
        }
    }
}
