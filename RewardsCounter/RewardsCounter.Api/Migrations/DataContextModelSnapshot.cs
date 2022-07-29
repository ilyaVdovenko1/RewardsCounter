﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RewardsCounter.Api.Repositories.Data;

#nullable disable

namespace RewardsCounter.Api.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("RewardsCounter.Api.Repositories.Models.Customer", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Customers");

                    b.HasData(
                        new
                        {
                            Id = new Guid("b96c7e78-46bd-4057-8990-e3d2f82e0e8b"),
                            CreationDate = new DateTime(2018, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Ilya"
                        },
                        new
                        {
                            Id = new Guid("99135b8d-cda6-493a-8994-6faecd21bf48"),
                            CreationDate = new DateTime(2020, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Ivan"
                        },
                        new
                        {
                            Id = new Guid("3b217a1d-c7d9-40da-a4d4-14e4c3a2ae2b"),
                            CreationDate = new DateTime(2020, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Ann"
                        },
                        new
                        {
                            Id = new Guid("de632b7e-627d-4bfe-9f96-edc290d32bbe"),
                            CreationDate = new DateTime(2019, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "John"
                        },
                        new
                        {
                            Id = new Guid("002f9c00-7523-44f1-ab9e-f906f368ab17"),
                            CreationDate = new DateTime(2018, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Liam"
                        },
                        new
                        {
                            Id = new Guid("ee884543-1b4e-46f9-a652-575aa9570f01"),
                            CreationDate = new DateTime(2018, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Olivia"
                        },
                        new
                        {
                            Id = new Guid("fa05b53c-da5e-4a30-9751-744afdcc5198"),
                            CreationDate = new DateTime(2022, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Oliver"
                        },
                        new
                        {
                            Id = new Guid("b5280851-7383-49d0-8375-e98f84e1ce3b"),
                            CreationDate = new DateTime(2022, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Amelia"
                        },
                        new
                        {
                            Id = new Guid("7203c9dd-6778-435e-8788-ce3532393fd0"),
                            CreationDate = new DateTime(2021, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Emma"
                        });
                });

            modelBuilder.Entity("RewardsCounter.Api.Repositories.Models.Transaction", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ClientId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("Sum")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("Timestamp")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Transactions");

                    b.HasData(
                        new
                        {
                            Id = new Guid("23edcf61-361a-4083-9677-06d0b1fe8725"),
                            ClientId = new Guid("b96c7e78-46bd-4057-8990-e3d2f82e0e8b"),
                            Sum = 12.3m,
                            Timestamp = new DateTime(2022, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = new Guid("ad57135d-f1e8-42ed-8ca6-811b11b4ec89"),
                            ClientId = new Guid("b96c7e78-46bd-4057-8990-e3d2f82e0e8b"),
                            Sum = 1.3m,
                            Timestamp = new DateTime(2021, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = new Guid("238cd0b6-45ed-4502-a6af-d939489213b2"),
                            ClientId = new Guid("b96c7e78-46bd-4057-8990-e3d2f82e0e8b"),
                            Sum = 100m,
                            Timestamp = new DateTime(2020, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = new Guid("a2f55d68-ac21-4a00-a3c1-d8d961a495d6"),
                            ClientId = new Guid("b96c7e78-46bd-4057-8990-e3d2f82e0e8b"),
                            Sum = 100m,
                            Timestamp = new DateTime(2022, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = new Guid("a0dba403-a8ec-49d1-abe7-e488ce54ac1e"),
                            ClientId = new Guid("b96c7e78-46bd-4057-8990-e3d2f82e0e8b"),
                            Sum = 100m,
                            Timestamp = new DateTime(2022, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = new Guid("f88af966-cf72-489a-b560-66eb07a37633"),
                            ClientId = new Guid("b96c7e78-46bd-4057-8990-e3d2f82e0e8b"),
                            Sum = 100m,
                            Timestamp = new DateTime(2022, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = new Guid("ef330b77-5d98-4fe5-8eb4-013a617d02a8"),
                            ClientId = new Guid("99135b8d-cda6-493a-8994-6faecd21bf48"),
                            Sum = 12.3m,
                            Timestamp = new DateTime(2022, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = new Guid("10069a9a-2547-4237-8a86-3eb457707171"),
                            ClientId = new Guid("3b217a1d-c7d9-40da-a4d4-14e4c3a2ae2b"),
                            Sum = 130m,
                            Timestamp = new DateTime(2021, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = new Guid("b03a986a-da34-422f-9f42-31330a5225c2"),
                            ClientId = new Guid("3b217a1d-c7d9-40da-a4d4-14e4c3a2ae2b"),
                            Sum = 12m,
                            Timestamp = new DateTime(2021, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = new Guid("a52e033e-9d81-43e7-b293-7b85104f8355"),
                            ClientId = new Guid("3b217a1d-c7d9-40da-a4d4-14e4c3a2ae2b"),
                            Sum = 51m,
                            Timestamp = new DateTime(2021, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = new Guid("b25417e4-dfdf-473d-8f2d-dad400ef4c8e"),
                            ClientId = new Guid("b96c7e78-46bd-4057-8990-e3d2f82e0e8b"),
                            Sum = 12.3m,
                            Timestamp = new DateTime(2022, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = new Guid("3c70c82d-6f5d-4652-b604-84615fe502dc"),
                            ClientId = new Guid("b96c7e78-46bd-4057-8990-e3d2f82e0e8b"),
                            Sum = 12.3m,
                            Timestamp = new DateTime(2022, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = new Guid("1231b58e-da52-4274-8fe4-6193f18edd89"),
                            ClientId = new Guid("002f9c00-7523-44f1-ab9e-f906f368ab17"),
                            Sum = 120m,
                            Timestamp = new DateTime(2022, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = new Guid("6883d3fd-d547-4694-b419-25c9600e9b00"),
                            ClientId = new Guid("b96c7e78-46bd-4057-8990-e3d2f82e0e8b"),
                            Sum = 12.3m,
                            Timestamp = new DateTime(2022, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = new Guid("3bd7f00e-077b-403a-b24f-5b3d4d2e5b26"),
                            ClientId = new Guid("b96c7e78-46bd-4057-8990-e3d2f82e0e8b"),
                            Sum = 12.3m,
                            Timestamp = new DateTime(2022, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = new Guid("5dd15517-693b-4af3-9df1-0e4db429e76a"),
                            ClientId = new Guid("b96c7e78-46bd-4057-8990-e3d2f82e0e8b"),
                            Sum = 12.3m,
                            Timestamp = new DateTime(2022, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = new Guid("ce4bedd7-9c76-429a-98b7-1915055972f7"),
                            ClientId = new Guid("b96c7e78-46bd-4057-8990-e3d2f82e0e8b"),
                            Sum = 12.3m,
                            Timestamp = new DateTime(2022, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });
#pragma warning restore 612, 618
        }
    }
}