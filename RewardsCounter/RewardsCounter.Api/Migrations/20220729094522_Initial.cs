using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RewardsCounter.Api.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Transactions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Timestamp = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Sum = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ClientId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transactions", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "CreationDate", "Name" },
                values: new object[,]
                {
                    { new Guid("002f9c00-7523-44f1-ab9e-f906f368ab17"), new DateTime(2018, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Liam" },
                    { new Guid("3b217a1d-c7d9-40da-a4d4-14e4c3a2ae2b"), new DateTime(2020, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ann" },
                    { new Guid("7203c9dd-6778-435e-8788-ce3532393fd0"), new DateTime(2021, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Emma" },
                    { new Guid("99135b8d-cda6-493a-8994-6faecd21bf48"), new DateTime(2020, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ivan" },
                    { new Guid("b5280851-7383-49d0-8375-e98f84e1ce3b"), new DateTime(2022, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Amelia" },
                    { new Guid("b96c7e78-46bd-4057-8990-e3d2f82e0e8b"), new DateTime(2018, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ilya" },
                    { new Guid("de632b7e-627d-4bfe-9f96-edc290d32bbe"), new DateTime(2019, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "John" },
                    { new Guid("ee884543-1b4e-46f9-a652-575aa9570f01"), new DateTime(2018, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Olivia" },
                    { new Guid("fa05b53c-da5e-4a30-9751-744afdcc5198"), new DateTime(2022, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Oliver" }
                });

            migrationBuilder.InsertData(
                table: "Transactions",
                columns: new[] { "Id", "ClientId", "Sum", "Timestamp" },
                values: new object[,]
                {
                    { new Guid("10069a9a-2547-4237-8a86-3eb457707171"), new Guid("3b217a1d-c7d9-40da-a4d4-14e4c3a2ae2b"), 130m, new DateTime(2021, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("1231b58e-da52-4274-8fe4-6193f18edd89"), new Guid("002f9c00-7523-44f1-ab9e-f906f368ab17"), 120m, new DateTime(2022, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("238cd0b6-45ed-4502-a6af-d939489213b2"), new Guid("b96c7e78-46bd-4057-8990-e3d2f82e0e8b"), 100m, new DateTime(2020, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("23edcf61-361a-4083-9677-06d0b1fe8725"), new Guid("b96c7e78-46bd-4057-8990-e3d2f82e0e8b"), 12.3m, new DateTime(2022, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("3bd7f00e-077b-403a-b24f-5b3d4d2e5b26"), new Guid("b96c7e78-46bd-4057-8990-e3d2f82e0e8b"), 12.3m, new DateTime(2022, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("3c70c82d-6f5d-4652-b604-84615fe502dc"), new Guid("b96c7e78-46bd-4057-8990-e3d2f82e0e8b"), 12.3m, new DateTime(2022, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("5dd15517-693b-4af3-9df1-0e4db429e76a"), new Guid("b96c7e78-46bd-4057-8990-e3d2f82e0e8b"), 12.3m, new DateTime(2022, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("6883d3fd-d547-4694-b419-25c9600e9b00"), new Guid("b96c7e78-46bd-4057-8990-e3d2f82e0e8b"), 12.3m, new DateTime(2022, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("a0dba403-a8ec-49d1-abe7-e488ce54ac1e"), new Guid("b96c7e78-46bd-4057-8990-e3d2f82e0e8b"), 100m, new DateTime(2022, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("a2f55d68-ac21-4a00-a3c1-d8d961a495d6"), new Guid("b96c7e78-46bd-4057-8990-e3d2f82e0e8b"), 100m, new DateTime(2022, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("a52e033e-9d81-43e7-b293-7b85104f8355"), new Guid("3b217a1d-c7d9-40da-a4d4-14e4c3a2ae2b"), 51m, new DateTime(2021, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ad57135d-f1e8-42ed-8ca6-811b11b4ec89"), new Guid("b96c7e78-46bd-4057-8990-e3d2f82e0e8b"), 1.3m, new DateTime(2021, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("b03a986a-da34-422f-9f42-31330a5225c2"), new Guid("3b217a1d-c7d9-40da-a4d4-14e4c3a2ae2b"), 12m, new DateTime(2021, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("b25417e4-dfdf-473d-8f2d-dad400ef4c8e"), new Guid("b96c7e78-46bd-4057-8990-e3d2f82e0e8b"), 12.3m, new DateTime(2022, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ce4bedd7-9c76-429a-98b7-1915055972f7"), new Guid("b96c7e78-46bd-4057-8990-e3d2f82e0e8b"), 12.3m, new DateTime(2022, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ef330b77-5d98-4fe5-8eb4-013a617d02a8"), new Guid("99135b8d-cda6-493a-8994-6faecd21bf48"), 12.3m, new DateTime(2022, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("f88af966-cf72-489a-b560-66eb07a37633"), new Guid("b96c7e78-46bd-4057-8990-e3d2f82e0e8b"), 100m, new DateTime(2022, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Transactions");
        }
    }
}
