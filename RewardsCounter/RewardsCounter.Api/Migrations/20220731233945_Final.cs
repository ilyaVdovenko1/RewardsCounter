using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RewardsCounter.Api.Migrations
{
    public partial class Final : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("0f624842-ae96-4d33-bc20-cf9e8f81ccb2"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("139d6ce2-4a18-47d1-be65-8fa4687e5105"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("56fd430d-3e97-44f7-8980-e3931cc3e594"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("57be30b2-e028-46a1-a9c6-23558ee48a56"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("58d9f78b-2a1e-42a4-bc20-7b633f614492"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("7071edeb-cc2f-46bf-935a-29846ae10dd2"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("71eb1dd6-3b59-45ad-b815-59caa00b2f94"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("98870c62-5f0a-49ad-baff-40e619bc695e"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("a1b06b68-908d-405c-b3bf-2a7154ccdb90"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("a59e545f-6767-405c-980c-648ad3916457"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("b0b753d7-7f89-444f-b3ba-3f6d7be8a41a"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("c1c13ac6-fbfd-4d0e-afad-709370674699"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("e14171da-07b4-4057-be67-ef7529a3d574"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("f0be2169-0513-42e3-b41c-6d106221e15d"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("f8ec3b1a-5702-4fc0-94c2-b7bc97b4af5e"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("f8fd36bd-964c-4d95-9122-f967738a05c5"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("fbfeaec5-8261-43c6-9c51-38b8c6c323bc"));

            migrationBuilder.InsertData(
                table: "Transactions",
                columns: new[] { "Id", "ClientId", "Sum", "Timestamp" },
                values: new object[,]
                {
                    { new Guid("2de82f28-1a5a-4d7f-80e8-e51690c54cbf"), new Guid("b96c7e78-46bd-4057-8990-e3d2f82e0e8b"), 50m, new DateTime(2022, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("3c349570-1912-4040-b021-7e52b81c9acf"), new Guid("b96c7e78-46bd-4057-8990-e3d2f82e0e8b"), 12.3m, new DateTime(2022, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("417aeabc-471a-47e9-b8af-690a9ea6a22e"), new Guid("de632b7e-627d-4bfe-9f96-edc290d32bbe"), 12.3m, new DateTime(2022, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("568d2fd0-4508-4901-8c06-bcf923787d5a"), new Guid("b96c7e78-46bd-4057-8990-e3d2f82e0e8b"), 50m, new DateTime(2022, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("635085de-13be-41f3-a191-a20913d8ecb6"), new Guid("b96c7e78-46bd-4057-8990-e3d2f82e0e8b"), 100m, new DateTime(2022, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("6608c273-6504-45ab-aea6-7042110c1f7c"), new Guid("b96c7e78-46bd-4057-8990-e3d2f82e0e8b"), 40m, new DateTime(2022, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("6d7536ef-39d8-4bc6-bedf-8118fe6602e3"), new Guid("fa05b53c-da5e-4a30-9751-744afdcc5198"), 12.3m, new DateTime(2022, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("75e22538-0d68-4398-a2e5-79d15089143f"), new Guid("b96c7e78-46bd-4057-8990-e3d2f82e0e8b"), 12.3m, new DateTime(2022, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("76b6ef34-973a-436b-aa4d-c44e3e8acd33"), new Guid("de632b7e-627d-4bfe-9f96-edc290d32bbe"), 12.3m, new DateTime(2022, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("7b4db32e-6eeb-4e5e-852c-d97b43645167"), new Guid("b96c7e78-46bd-4057-8990-e3d2f82e0e8b"), 50m, new DateTime(2022, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("a2ec13f7-ba45-43a5-ba55-52568a5321ee"), new Guid("b96c7e78-46bd-4057-8990-e3d2f82e0e8b"), 100m, new DateTime(2022, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("a3c8441d-a6da-4cab-ac2d-eaa8389309d6"), new Guid("3b217a1d-c7d9-40da-a4d4-14e4c3a2ae2b"), 51m, new DateTime(2021, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("a6d58571-f8ed-4e5f-9322-5cb422ae3364"), new Guid("7203c9dd-6778-435e-8788-ce3532393fd0"), 12.3m, new DateTime(2022, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("aa5be972-f647-457c-b072-1884d5a47353"), new Guid("b96c7e78-46bd-4057-8990-e3d2f82e0e8b"), 100m, new DateTime(2022, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("b9cb7f7e-f152-4abf-8b5f-5d8fb64c301d"), new Guid("99135b8d-cda6-493a-8994-6faecd21bf48"), 12.3m, new DateTime(2022, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("bdb20564-9638-452d-9faa-f021be8024e6"), new Guid("002f9c00-7523-44f1-ab9e-f906f368ab17"), 120m, new DateTime(2022, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("c02ea405-d9cd-487e-9bfc-6e926b62edd6"), new Guid("3b217a1d-c7d9-40da-a4d4-14e4c3a2ae2b"), 130m, new DateTime(2021, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("c4d58431-fa38-4feb-a0fd-ef5d30601847"), new Guid("b96c7e78-46bd-4057-8990-e3d2f82e0e8b"), 50m, new DateTime(2022, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("d3973d00-5cf5-420d-9d78-18b69f373363"), new Guid("b96c7e78-46bd-4057-8990-e3d2f82e0e8b"), 100m, new DateTime(2022, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("d78e7672-7184-49c6-8fab-6caa28904115"), new Guid("3b217a1d-c7d9-40da-a4d4-14e4c3a2ae2b"), 12m, new DateTime(2021, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("dfb3acaf-72c8-48a6-b7df-1011e6e53e46"), new Guid("b5280851-7383-49d0-8375-e98f84e1ce3b"), 12.3m, new DateTime(2022, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("e10c1dc5-343a-4afe-ac90-b2a5353c2c11"), new Guid("b96c7e78-46bd-4057-8990-e3d2f82e0e8b"), 100m, new DateTime(2022, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("eb63d06e-3111-4e82-8a7c-10284e3691c4"), new Guid("b96c7e78-46bd-4057-8990-e3d2f82e0e8b"), 1.3m, new DateTime(2021, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ebc0449e-9b55-4fa2-b9a4-a9d4e910bad7"), new Guid("b96c7e78-46bd-4057-8990-e3d2f82e0e8b"), 100m, new DateTime(2022, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("f2b61f6a-9e6c-4314-acf3-2bce84b17d68"), new Guid("b96c7e78-46bd-4057-8990-e3d2f82e0e8b"), 100m, new DateTime(2022, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("fab7c092-3c78-4cd2-8766-4bd109ccde81"), new Guid("b96c7e78-46bd-4057-8990-e3d2f82e0e8b"), 100m, new DateTime(2020, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("2de82f28-1a5a-4d7f-80e8-e51690c54cbf"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("3c349570-1912-4040-b021-7e52b81c9acf"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("417aeabc-471a-47e9-b8af-690a9ea6a22e"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("568d2fd0-4508-4901-8c06-bcf923787d5a"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("635085de-13be-41f3-a191-a20913d8ecb6"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("6608c273-6504-45ab-aea6-7042110c1f7c"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("6d7536ef-39d8-4bc6-bedf-8118fe6602e3"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("75e22538-0d68-4398-a2e5-79d15089143f"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("76b6ef34-973a-436b-aa4d-c44e3e8acd33"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("7b4db32e-6eeb-4e5e-852c-d97b43645167"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("a2ec13f7-ba45-43a5-ba55-52568a5321ee"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("a3c8441d-a6da-4cab-ac2d-eaa8389309d6"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("a6d58571-f8ed-4e5f-9322-5cb422ae3364"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("aa5be972-f647-457c-b072-1884d5a47353"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("b9cb7f7e-f152-4abf-8b5f-5d8fb64c301d"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("bdb20564-9638-452d-9faa-f021be8024e6"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("c02ea405-d9cd-487e-9bfc-6e926b62edd6"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("c4d58431-fa38-4feb-a0fd-ef5d30601847"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("d3973d00-5cf5-420d-9d78-18b69f373363"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("d78e7672-7184-49c6-8fab-6caa28904115"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("dfb3acaf-72c8-48a6-b7df-1011e6e53e46"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("e10c1dc5-343a-4afe-ac90-b2a5353c2c11"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("eb63d06e-3111-4e82-8a7c-10284e3691c4"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("ebc0449e-9b55-4fa2-b9a4-a9d4e910bad7"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("f2b61f6a-9e6c-4314-acf3-2bce84b17d68"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("fab7c092-3c78-4cd2-8766-4bd109ccde81"));

            migrationBuilder.InsertData(
                table: "Transactions",
                columns: new[] { "Id", "ClientId", "Sum", "Timestamp" },
                values: new object[,]
                {
                    { new Guid("0f624842-ae96-4d33-bc20-cf9e8f81ccb2"), new Guid("002f9c00-7523-44f1-ab9e-f906f368ab17"), 120m, new DateTime(2022, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("139d6ce2-4a18-47d1-be65-8fa4687e5105"), new Guid("de632b7e-627d-4bfe-9f96-edc290d32bbe"), 12.3m, new DateTime(2022, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("56fd430d-3e97-44f7-8980-e3931cc3e594"), new Guid("3b217a1d-c7d9-40da-a4d4-14e4c3a2ae2b"), 130m, new DateTime(2021, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("57be30b2-e028-46a1-a9c6-23558ee48a56"), new Guid("b96c7e78-46bd-4057-8990-e3d2f82e0e8b"), 100m, new DateTime(2022, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("58d9f78b-2a1e-42a4-bc20-7b633f614492"), new Guid("b96c7e78-46bd-4057-8990-e3d2f82e0e8b"), 12.3m, new DateTime(2022, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("7071edeb-cc2f-46bf-935a-29846ae10dd2"), new Guid("b96c7e78-46bd-4057-8990-e3d2f82e0e8b"), 12.3m, new DateTime(2022, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("71eb1dd6-3b59-45ad-b815-59caa00b2f94"), new Guid("b5280851-7383-49d0-8375-e98f84e1ce3b"), 12.3m, new DateTime(2022, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("98870c62-5f0a-49ad-baff-40e619bc695e"), new Guid("b96c7e78-46bd-4057-8990-e3d2f82e0e8b"), 100m, new DateTime(2020, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("a1b06b68-908d-405c-b3bf-2a7154ccdb90"), new Guid("3b217a1d-c7d9-40da-a4d4-14e4c3a2ae2b"), 12m, new DateTime(2021, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("a59e545f-6767-405c-980c-648ad3916457"), new Guid("b96c7e78-46bd-4057-8990-e3d2f82e0e8b"), 100m, new DateTime(2022, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("b0b753d7-7f89-444f-b3ba-3f6d7be8a41a"), new Guid("b96c7e78-46bd-4057-8990-e3d2f82e0e8b"), 100m, new DateTime(2022, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("c1c13ac6-fbfd-4d0e-afad-709370674699"), new Guid("de632b7e-627d-4bfe-9f96-edc290d32bbe"), 12.3m, new DateTime(2022, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("e14171da-07b4-4057-be67-ef7529a3d574"), new Guid("fa05b53c-da5e-4a30-9751-744afdcc5198"), 12.3m, new DateTime(2022, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("f0be2169-0513-42e3-b41c-6d106221e15d"), new Guid("7203c9dd-6778-435e-8788-ce3532393fd0"), 12.3m, new DateTime(2022, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("f8ec3b1a-5702-4fc0-94c2-b7bc97b4af5e"), new Guid("b96c7e78-46bd-4057-8990-e3d2f82e0e8b"), 1.3m, new DateTime(2021, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("f8fd36bd-964c-4d95-9122-f967738a05c5"), new Guid("99135b8d-cda6-493a-8994-6faecd21bf48"), 12.3m, new DateTime(2022, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("fbfeaec5-8261-43c6-9c51-38b8c6c323bc"), new Guid("3b217a1d-c7d9-40da-a4d4-14e4c3a2ae2b"), 51m, new DateTime(2021, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }
    }
}
