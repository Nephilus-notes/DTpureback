﻿// <auto-generated />
using System;
using DTpureback.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace DTpureback.Migrations
{
    [DbContext(typeof(DragonsTailContext))]
    partial class DragonsTailContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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

                    b.Property<int>("Armor")
                        .HasColumnType("integer");

                    b.Property<int>("ArmorValue")
                        .HasColumnType("integer");

                    b.Property<string>("BodyItem")
                        .HasColumnType("text");

                    b.Property<bool>("Burning")
                        .HasColumnType("boolean");

                    b.Property<bool>("BurningBlades")
                        .HasColumnType("boolean");

                    b.Property<int>("BurningBladesRounds")
                        .HasColumnType("integer");

                    b.Property<int>("BurningRounds")
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

                    b.Property<int>("DamageValue")
                        .HasColumnType("integer");

                    b.Property<DateTime>("DateAdded")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("DateUpdated")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool>("Defended")
                        .HasColumnType("boolean");

                    b.Property<int>("DefendingFounds")
                        .HasColumnType("integer");

                    b.Property<int>("Dexterity")
                        .HasColumnType("integer");

                    b.Property<int>("DexterityXP")
                        .HasColumnType("integer");

                    b.Property<bool>("DoubleArmed")
                        .HasColumnType("boolean");

                    b.Property<int>("DoubledArmedRounds")
                        .HasColumnType("integer");

                    b.Property<int>("DrippingDeathExplored")
                        .HasColumnType("integer");

                    b.Property<int>("EvadePercentage")
                        .HasColumnType("integer");

                    b.Property<bool>("Evading")
                        .HasColumnType("boolean");

                    b.Property<int>("EvadingRounds")
                        .HasColumnType("integer");

                    b.Property<bool>("Fleeing")
                        .HasColumnType("boolean");

                    b.Property<int>("FleeingRounds")
                        .HasColumnType("integer");

                    b.Property<bool>("Focusing")
                        .HasColumnType("boolean");

                    b.Property<int>("FocusingRounds")
                        .HasColumnType("integer");

                    b.Property<int>("GraithQueensLairExplored")
                        .HasColumnType("integer");

                    b.Property<int>("GraithsGrottoExplored")
                        .HasColumnType("integer");

                    b.Property<string>("HandItem")
                        .HasColumnType("text");

                    b.Property<string>("HeadItem")
                        .HasColumnType("text");

                    b.Property<bool>("HitByWind")
                        .HasColumnType("boolean");

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

                    b.Property<bool>("Poisoned")
                        .HasColumnType("boolean");

                    b.Property<int>("PoisonedRounds")
                        .HasColumnType("integer");

                    b.Property<int>("Resistance")
                        .HasColumnType("integer");

                    b.Property<bool>("Slowed")
                        .HasColumnType("boolean");

                    b.Property<int>("SlowedRounds")
                        .HasColumnType("integer");

                    b.Property<bool>("StoneArmored")
                        .HasColumnType("boolean");

                    b.Property<int>("StoneArmoredRounds")
                        .HasColumnType("integer");

                    b.Property<bool>("StoneFists")
                        .HasColumnType("boolean");

                    b.Property<int>("Strength")
                        .HasColumnType("integer");

                    b.Property<int>("StrengthXP")
                        .HasColumnType("integer");

                    b.Property<bool>("Stunned")
                        .HasColumnType("boolean");

                    b.Property<int>("TailOfTheDragonExplored")
                        .HasColumnType("integer");

                    b.Property<int>("ThagragsHopeExplored")
                        .HasColumnType("integer");

                    b.Property<bool>("Vulnerable")
                        .HasColumnType("boolean");

                    b.Property<int>("VulnerableRounds")
                        .HasColumnType("integer");

                    b.Property<int>("WebOfDepthsExplored")
                        .HasColumnType("integer");

                    b.HasKey("ID");

                    b.ToTable("PlayerCharacters");
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

                    b.Property<string>("MoveOptions")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Next")
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

                    b.Property<int>("Armor")
                        .HasColumnType("integer");

                    b.Property<int>("ArmorValue")
                        .HasColumnType("integer");

                    b.Property<bool>("Burning")
                        .HasColumnType("boolean");

                    b.Property<bool>("BurningBlades")
                        .HasColumnType("boolean");

                    b.Property<int>("BurningBladesRounds")
                        .HasColumnType("integer");

                    b.Property<int>("BurningRounds")
                        .HasColumnType("integer");

                    b.Property<int>("Constitution")
                        .HasColumnType("integer");

                    b.Property<int>("CurrentCurrency")
                        .HasColumnType("integer");

                    b.Property<int>("DamageValue")
                        .HasColumnType("integer");

                    b.Property<DateTime>("DateAdded")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("DateUpdated")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool>("Defended")
                        .HasColumnType("boolean");

                    b.Property<int>("DefendingFounds")
                        .HasColumnType("integer");

                    b.Property<int>("Dexterity")
                        .HasColumnType("integer");

                    b.Property<bool>("DoubleArmed")
                        .HasColumnType("boolean");

                    b.Property<int>("DoubledArmedRounds")
                        .HasColumnType("integer");

                    b.Property<int>("EvadePercentage")
                        .HasColumnType("integer");

                    b.Property<bool>("Evading")
                        .HasColumnType("boolean");

                    b.Property<int>("EvadingRounds")
                        .HasColumnType("integer");

                    b.Property<bool>("Fleeing")
                        .HasColumnType("boolean");

                    b.Property<int>("FleeingRounds")
                        .HasColumnType("integer");

                    b.Property<bool>("Focusing")
                        .HasColumnType("boolean");

                    b.Property<int>("FocusingRounds")
                        .HasColumnType("integer");

                    b.Property<bool>("HitByWind")
                        .HasColumnType("boolean");

                    b.Property<int>("Intelligence")
                        .HasColumnType("integer");

                    b.Property<int>("Level")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("Poisoned")
                        .HasColumnType("boolean");

                    b.Property<int>("PoisonedRounds")
                        .HasColumnType("integer");

                    b.Property<int>("Resistance")
                        .HasColumnType("integer");

                    b.Property<bool>("Slowed")
                        .HasColumnType("boolean");

                    b.Property<int>("SlowedRounds")
                        .HasColumnType("integer");

                    b.Property<bool>("StoneArmored")
                        .HasColumnType("boolean");

                    b.Property<int>("StoneArmoredRounds")
                        .HasColumnType("integer");

                    b.Property<bool>("StoneFists")
                        .HasColumnType("boolean");

                    b.Property<int>("Strength")
                        .HasColumnType("integer");

                    b.Property<bool>("Stunned")
                        .HasColumnType("boolean");

                    b.Property<bool>("Vulnerable")
                        .HasColumnType("boolean");

                    b.Property<int>("VulnerableRounds")
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

                    b.Property<DateTime>("DateAdded")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("DateUpdated")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("LocationID")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("PlayerCharacterID")
                        .HasColumnType("integer");

                    b.Property<int>("UserID")
                        .HasColumnType("integer");

                    b.HasKey("ID");

                    b.HasIndex("UserID");

                    b.ToTable("SaveFiles");
                });

            modelBuilder.Entity("DTpureback.Models.User", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("ID"));

                    b.Property<DateTime>("DateAdded")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("DateUpdated")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("ID");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("DTpureback.Models.SaveFile", b =>
                {
                    b.HasOne("DTpureback.Models.User", "User")
                        .WithMany("SaveFiles")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("DTpureback.Models.User", b =>
                {
                    b.Navigation("SaveFiles");
                });
#pragma warning restore 612, 618
        }
    }
}
