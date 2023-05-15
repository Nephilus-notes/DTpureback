﻿// <auto-generated />
using System;
using DTpureback.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace DTpureback.Migrations
{
    [DbContext(typeof(DragonsTailContext))]
    [Migration("20230513211116_MakingSureWeAreUpToDate")]
    partial class MakingSureWeAreUpToDate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("DTpureback.Models.PlayerCharacter", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("ID"));

                    b.Property<string>("Abilities")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Armor")
                        .HasColumnType("integer");

                    b.Property<int>("Constitution")
                        .HasColumnType("integer");

                    b.Property<int>("ConstitutionXP")
                        .HasColumnType("integer");

                    b.Property<int>("CurrentCurrency")
                        .HasColumnType("integer");

                    b.Property<int>("CurrentHP")
                        .HasColumnType("integer");

                    b.Property<string>("CurrentLocation")
                        .HasColumnType("text");

                    b.Property<int>("CurrentMP")
                        .HasColumnType("integer");

                    b.Property<DateTime>("DateAdded")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("DateUpdated")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("Dexterity")
                        .HasColumnType("integer");

                    b.Property<int>("DexterityXP")
                        .HasColumnType("integer");

                    b.Property<int>("DrippingDeathExplored")
                        .HasColumnType("integer");

                    b.Property<string>("EquippedItems")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("GraithQueensLairExplored")
                        .HasColumnType("integer");

                    b.Property<int>("GraithsGrottoExplored")
                        .HasColumnType("integer");

                    b.Property<int>("Intelligence")
                        .HasColumnType("integer");

                    b.Property<int>("IntelligenceXP")
                        .HasColumnType("integer");

                    b.Property<string>("Items")
                        .HasColumnType("text");

                    b.Property<int>("KratabsFollyExplored")
                        .HasColumnType("integer");

                    b.Property<int>("Level")
                        .HasColumnType("integer");

                    b.Property<int>("LifeTimeCurrency")
                        .HasColumnType("integer");

                    b.Property<int>("MaxHP")
                        .HasColumnType("integer");

                    b.Property<int>("MaxMP")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("PlayersRespiteExplored")
                        .HasColumnType("integer");

                    b.Property<int>("Resistance")
                        .HasColumnType("integer");

                    b.Property<int>("Strength")
                        .HasColumnType("integer");

                    b.Property<int>("StrengthXP")
                        .HasColumnType("integer");

                    b.Property<int>("TailOfTheDragonExplored")
                        .HasColumnType("integer");

                    b.Property<int>("ThagragsHopeExplored")
                        .HasColumnType("integer");

                    b.Property<int>("WebOfDepthsExplored")
                        .HasColumnType("integer");

                    b.HasKey("ID");

                    b.ToTable("PlayerCharacters");
                });

            modelBuilder.Entity("DTpureback.Models.Resources.Ability", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("ID"));

                    b.Property<string>("AffectedAttribute")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Cost")
                        .HasColumnType("integer");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Duration")
                        .HasColumnType("integer");

                    b.Property<string>("Effect")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Modifier")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("ID");

                    b.ToTable("Ability");
                });

            modelBuilder.Entity("DTpureback.Models.Resources.CharacterDefault", b =>
                {
                    b.Property<string>("ID")
                        .HasColumnType("text");

                    b.Property<int>("AbilityID")
                        .HasColumnType("integer");

                    b.Property<int>("Constitution")
                        .HasColumnType("integer");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<int>("Dexterity")
                        .HasColumnType("integer");

                    b.Property<int>("Intelligence")
                        .HasColumnType("integer");

                    b.Property<string>("Job")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Strength")
                        .HasColumnType("integer");

                    b.HasKey("ID");

                    b.ToTable("CharacterDefault");
                });

            modelBuilder.Entity("DTpureback.Models.Resources.Item", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("ID"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("ItemStat")
                        .HasColumnType("integer");

                    b.Property<int>("Price")
                        .HasColumnType("integer");

                    b.Property<string>("Slot")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("ID");

                    b.ToTable("Items");
                });

            modelBuilder.Entity("DTpureback.Models.Resources.Location", b =>
                {
                    b.Property<string>("ID")
                        .HasColumnType("text");

                    b.Property<int?>("CommonNPC")
                        .HasColumnType("integer");

                    b.Property<string>("EnterText")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("ExitText")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("MiddleText")
                        .HasColumnType("text");

                    b.Property<string>("MoveOptions")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Next")
                        .HasColumnType("text");

                    b.Property<string>("OtherList")
                        .HasColumnType("text");

                    b.Property<string>("OtherText")
                        .HasColumnType("text");

                    b.Property<int?>("RareNPC")
                        .HasColumnType("integer");

                    b.Property<int?>("SecretNPC")
                        .HasColumnType("integer");

                    b.Property<int?>("UncommonNPC")
                        .HasColumnType("integer");

                    b.HasKey("ID");

                    b.ToTable("Locations");
                });

            modelBuilder.Entity("DTpureback.Models.Resources.NPC", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("ID"));

                    b.Property<string>("Abilities")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Armor")
                        .HasColumnType("integer");

                    b.Property<int>("Constitution")
                        .HasColumnType("integer");

                    b.Property<int>("CurrentCurrency")
                        .HasColumnType("integer");

                    b.Property<DateTime>("DateAdded")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("DateUpdated")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("Dexterity")
                        .HasColumnType("integer");

                    b.Property<int>("Intelligence")
                        .HasColumnType("integer");

                    b.Property<string>("Items")
                        .HasColumnType("text");

                    b.Property<int>("Level")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Resistance")
                        .HasColumnType("integer");

                    b.Property<int>("Strength")
                        .HasColumnType("integer");

                    b.HasKey("ID");

                    b.ToTable("NPC");
                });

            modelBuilder.Entity("DTpureback.Models.SaveFile", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("ID"));

                    b.Property<string>("CharacterName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("DateAdded")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("DateUpdated")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("LocationID")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("PlayerCharacterID")
                        .HasColumnType("integer");

                    b.Property<string>("UserID")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("ID");

                    b.ToTable("SaveFiles");
                });
#pragma warning restore 612, 618
        }
    }
}