﻿// <auto-generated />
using AjaxDefinex.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AjaxDefinex.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20250314165316_AddMoreProducts")]
    partial class AddMoreProducts
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("AjaxDefinex.Models.Entities.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Elektronik"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Mobilya"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Giyim"
                        });
                });

            modelBuilder.Entity("AjaxDefinex.Models.Entities.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            Name = "Laptop",
                            Price = 12000m
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 1,
                            Name = "Telefon",
                            Price = 8000m
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 1,
                            Name = "Kulaklık",
                            Price = 1500m
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 2,
                            Name = "Masa",
                            Price = 3000m
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 2,
                            Name = "Sandalye",
                            Price = 1200m
                        },
                        new
                        {
                            Id = 6,
                            CategoryId = 2,
                            Name = "Koltuk",
                            Price = 5000m
                        },
                        new
                        {
                            Id = 7,
                            CategoryId = 3,
                            Name = "Gömlek",
                            Price = 500m
                        },
                        new
                        {
                            Id = 8,
                            CategoryId = 3,
                            Name = "Pantolon",
                            Price = 600m
                        },
                        new
                        {
                            Id = 9,
                            CategoryId = 1,
                            Name = "Tablet",
                            Price = 4500m
                        },
                        new
                        {
                            Id = 10,
                            CategoryId = 1,
                            Name = "Monitör",
                            Price = 2500m
                        },
                        new
                        {
                            Id = 11,
                            CategoryId = 1,
                            Name = "Televizyon",
                            Price = 7000m
                        },
                        new
                        {
                            Id = 12,
                            CategoryId = 2,
                            Name = "Yatak",
                            Price = 2000m
                        },
                        new
                        {
                            Id = 13,
                            CategoryId = 2,
                            Name = "Kitaplık",
                            Price = 1500m
                        },
                        new
                        {
                            Id = 14,
                            CategoryId = 3,
                            Name = "Çanta",
                            Price = 700m
                        },
                        new
                        {
                            Id = 15,
                            CategoryId = 3,
                            Name = "Ayakkabı",
                            Price = 900m
                        },
                        new
                        {
                            Id = 16,
                            CategoryId = 3,
                            Name = "Ceket",
                            Price = 1000m
                        },
                        new
                        {
                            Id = 17,
                            CategoryId = 1,
                            Name = "Buzdolabı",
                            Price = 4500m
                        },
                        new
                        {
                            Id = 18,
                            CategoryId = 1,
                            Name = "Mikrodalga",
                            Price = 1500m
                        },
                        new
                        {
                            Id = 19,
                            CategoryId = 1,
                            Name = "Fırın",
                            Price = 2500m
                        },
                        new
                        {
                            Id = 20,
                            CategoryId = 1,
                            Name = "Kettle",
                            Price = 400m
                        });
                });

            modelBuilder.Entity("AjaxDefinex.Models.Entities.Product", b =>
                {
                    b.HasOne("AjaxDefinex.Models.Entities.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("AjaxDefinex.Models.Entities.Category", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
