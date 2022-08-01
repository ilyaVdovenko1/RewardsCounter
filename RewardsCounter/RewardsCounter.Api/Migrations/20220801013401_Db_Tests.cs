using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RewardsCounter.Api.Migrations
{
    public partial class Db_Tests : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { new Guid("043fbb79-3560-4513-873d-1d2add5da8b4"), new Guid("b96c7e78-46bd-4057-8990-e3d2f82e0e8b"), 100m, new DateTime(2022, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("0b543c3c-6330-4c8b-953a-183d9879f96e"), new Guid("7203c9dd-6778-435e-8788-ce3532393fd0"), 100m, new DateTime(2022, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("10709443-1321-4d0c-9514-1492490af67c"), new Guid("b96c7e78-46bd-4057-8990-e3d2f82e0e8b"), 100m, new DateTime(2020, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("17e243a6-c450-4d2c-9115-06f793c8818b"), new Guid("7203c9dd-6778-435e-8788-ce3532393fd0"), 40m, new DateTime(2022, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("26d3b846-b2da-4868-87d1-23ed689d5be1"), new Guid("99135b8d-cda6-493a-8994-6faecd21bf48"), 12.3m, new DateTime(2022, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("362762c5-a5b0-422b-bc16-45d7ecfe4e8b"), new Guid("b96c7e78-46bd-4057-8990-e3d2f82e0e8b"), 100m, new DateTime(2022, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("3e4a82ef-8d95-4d46-b8c5-52a767513386"), new Guid("99135b8d-cda6-493a-8994-6faecd21bf48"), 100m, new DateTime(2022, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("46d5e8c1-bdcb-4f35-b8ea-508dc2dfe18a"), new Guid("3b217a1d-c7d9-40da-a4d4-14e4c3a2ae2b"), 12m, new DateTime(2021, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("520ab412-3b2e-4db5-9c52-3bdda7abcb19"), new Guid("fa05b53c-da5e-4a30-9751-744afdcc5198"), 12.3m, new DateTime(2022, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("60ab9b4f-84c6-4e35-bba4-24356ebb9d67"), new Guid("7203c9dd-6778-435e-8788-ce3532393fd0"), 12.3m, new DateTime(2022, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("6130c7f5-9cd2-4c3b-9e2b-455f38effff7"), new Guid("002f9c00-7523-44f1-ab9e-f906f368ab17"), 120m, new DateTime(2022, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("71e8c012-2e1c-4ab5-b4dd-53d7bbf1d1f0"), new Guid("99135b8d-cda6-493a-8994-6faecd21bf48"), 100m, new DateTime(2022, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("74b9fcf0-6deb-490f-907e-808f5513a076"), new Guid("b96c7e78-46bd-4057-8990-e3d2f82e0e8b"), 1.3m, new DateTime(2021, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("78c32232-07fc-4fc4-ade8-d95c9de211f2"), new Guid("b5280851-7383-49d0-8375-e98f84e1ce3b"), 12.3m, new DateTime(2022, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("81089cf3-1eeb-4477-afe6-4f7141854a56"), new Guid("b96c7e78-46bd-4057-8990-e3d2f82e0e8b"), 12.3m, new DateTime(2022, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("83931490-dda8-4abd-801d-de5db8bfbff6"), new Guid("de632b7e-627d-4bfe-9f96-edc290d32bbe"), 12.3m, new DateTime(2022, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("929fc6e8-223f-4d09-9e79-34a079f69a03"), new Guid("de632b7e-627d-4bfe-9f96-edc290d32bbe"), 50m, new DateTime(2022, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("943134af-7345-4e48-8d0b-7605bbd8f99c"), new Guid("3b217a1d-c7d9-40da-a4d4-14e4c3a2ae2b"), 130m, new DateTime(2021, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("9c9b540b-3464-4cbc-a500-9defd3f8b969"), new Guid("de632b7e-627d-4bfe-9f96-edc290d32bbe"), 50m, new DateTime(2022, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("b5dbfa05-8427-4a0c-9c11-48f96cfa3b0a"), new Guid("3b217a1d-c7d9-40da-a4d4-14e4c3a2ae2b"), 51m, new DateTime(2021, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("c2c976ae-e01a-4c7d-a0e8-00adadf3a768"), new Guid("de632b7e-627d-4bfe-9f96-edc290d32bbe"), 12.3m, new DateTime(2022, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("c4574704-626d-49bf-bc2f-9877331f1c2a"), new Guid("7203c9dd-6778-435e-8788-ce3532393fd0"), 50m, new DateTime(2022, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("c87e3ce6-61e7-454e-90d6-45e6143ed917"), new Guid("de632b7e-627d-4bfe-9f96-edc290d32bbe"), 100m, new DateTime(2022, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("dfa89f9b-47a4-4b33-8c8a-e8ec41a170d6"), new Guid("99135b8d-cda6-493a-8994-6faecd21bf48"), 50m, new DateTime(2022, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("dfde73ed-180d-45ae-9ff6-66a7dd39de70"), new Guid("b96c7e78-46bd-4057-8990-e3d2f82e0e8b"), 12.3m, new DateTime(2022, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("e5d17ba3-55a8-4a27-8881-97684409b31f"), new Guid("b96c7e78-46bd-4057-8990-e3d2f82e0e8b"), 100m, new DateTime(2022, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("043fbb79-3560-4513-873d-1d2add5da8b4"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("0b543c3c-6330-4c8b-953a-183d9879f96e"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("10709443-1321-4d0c-9514-1492490af67c"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("17e243a6-c450-4d2c-9115-06f793c8818b"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("26d3b846-b2da-4868-87d1-23ed689d5be1"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("362762c5-a5b0-422b-bc16-45d7ecfe4e8b"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("3e4a82ef-8d95-4d46-b8c5-52a767513386"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("46d5e8c1-bdcb-4f35-b8ea-508dc2dfe18a"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("520ab412-3b2e-4db5-9c52-3bdda7abcb19"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("60ab9b4f-84c6-4e35-bba4-24356ebb9d67"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("6130c7f5-9cd2-4c3b-9e2b-455f38effff7"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("71e8c012-2e1c-4ab5-b4dd-53d7bbf1d1f0"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("74b9fcf0-6deb-490f-907e-808f5513a076"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("78c32232-07fc-4fc4-ade8-d95c9de211f2"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("81089cf3-1eeb-4477-afe6-4f7141854a56"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("83931490-dda8-4abd-801d-de5db8bfbff6"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("929fc6e8-223f-4d09-9e79-34a079f69a03"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("943134af-7345-4e48-8d0b-7605bbd8f99c"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("9c9b540b-3464-4cbc-a500-9defd3f8b969"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("b5dbfa05-8427-4a0c-9c11-48f96cfa3b0a"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("c2c976ae-e01a-4c7d-a0e8-00adadf3a768"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("c4574704-626d-49bf-bc2f-9877331f1c2a"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("c87e3ce6-61e7-454e-90d6-45e6143ed917"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("dfa89f9b-47a4-4b33-8c8a-e8ec41a170d6"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("dfde73ed-180d-45ae-9ff6-66a7dd39de70"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("e5d17ba3-55a8-4a27-8881-97684409b31f"));

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
    }
}
