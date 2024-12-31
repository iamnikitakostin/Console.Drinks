﻿// <auto-generated />
using System;
using Drinks.iamnikitakostin.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Drinks.iamnikitakostin.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20241230201713_Init1")]
    partial class Init1
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Drinks.iamnikitakostin.Models.DrinkDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DateModified")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdInt")
                        .HasColumnType("int");

                    b.Property<string>("idDrink")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("strAlcoholic")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("strCategory")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("strCreativeCommonsConfirmed")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("strDrink")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("strDrinkAlternate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("strDrinkThumb")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("strGlass")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("strIBA")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("strImageAttribution")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("strImageSource")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("strIngredient1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("strIngredient10")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("strIngredient11")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("strIngredient12")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("strIngredient13")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("strIngredient14")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("strIngredient15")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("strIngredient2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("strIngredient3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("strIngredient4")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("strIngredient5")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("strIngredient6")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("strIngredient7")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("strIngredient8")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("strIngredient9")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("strInstructions")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("strInstructionsDE")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("strInstructionsES")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("strInstructionsFR")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("strInstructionsIT")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("strInstructionsZHHANS")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("strInstructionsZHHANT")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("strMeasure1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("strMeasure10")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("strMeasure11")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("strMeasure12")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("strMeasure13")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("strMeasure14")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("strMeasure15")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("strMeasure2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("strMeasure3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("strMeasure4")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("strMeasure5")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("strMeasure6")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("strMeasure7")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("strMeasure8")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("strMeasure9")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("strTags")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("strVideo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("FavoriteCocktails");
                });

            modelBuilder.Entity("Drinks.iamnikitakostin.Models.HistoryItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("DrinkId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("History");
                });
#pragma warning restore 612, 618
        }
    }
}
