﻿// <auto-generated />
using System;
using DTpureback.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DTpureback.Migrations
{
    [DbContext(typeof(DragonsTailContext))]
    [Migration("20230413184438_pcCurrentLocatin")]
    partial class pcCurrentLocatin
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DTpureback.Models.Character", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("Armor")
                        .HasColumnType("int");

                    b.Property<int>("ArmorValue")
                        .HasColumnType("int");

                    b.Property<bool>("Burning")
                        .HasColumnType("bit");

                    b.Property<bool>("BurningBlades")
                        .HasColumnType("bit");

                    b.Property<int>("BurningBladesRounds")
                        .HasColumnType("int");

                    b.Property<int>("BurningRounds")
                        .HasColumnType("int");

                    b.Property<int>("Constitution")
                        .HasColumnType("int");

                    b.Property<int>("CurrentCurrency")
                        .HasColumnType("int");

                    b.Property<int>("DamageValue")
                        .HasColumnType("int");

                    b.Property<bool>("Defended")
                        .HasColumnType("bit");

                    b.Property<int>("DefendingFounds")
                        .HasColumnType("int");

                    b.Property<int>("Dexterity")
                        .HasColumnType("int");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("DoubleArmed")
                        .HasColumnType("bit");

                    b.Property<int>("DoubledArmedRounds")
                        .HasColumnType("int");

                    b.Property<int>("EvadePercentage")
                        .HasColumnType("int");

                    b.Property<bool>("Evading")
                        .HasColumnType("bit");

                    b.Property<int>("EvadingRounds")
                        .HasColumnType("int");

                    b.Property<bool>("Fleeing")
                        .HasColumnType("bit");

                    b.Property<int>("FleeingRounds")
                        .HasColumnType("int");

                    b.Property<bool>("Focusing")
                        .HasColumnType("bit");

                    b.Property<int>("FocusingRounds")
                        .HasColumnType("int");

                    b.Property<bool>("HitByWind")
                        .HasColumnType("bit");

                    b.Property<int>("Intelligence")
                        .HasColumnType("int");

                    b.Property<int>("Level")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Poisoned")
                        .HasColumnType("bit");

                    b.Property<int>("PoisonedRounds")
                        .HasColumnType("int");

                    b.Property<int>("Resistance")
                        .HasColumnType("int");

                    b.Property<bool>("Slowed")
                        .HasColumnType("bit");

                    b.Property<int>("SlowedRounds")
                        .HasColumnType("int");

                    b.Property<bool>("StoneArmored")
                        .HasColumnType("bit");

                    b.Property<int>("StoneArmoredRounds")
                        .HasColumnType("int");

                    b.Property<bool>("StoneFists")
                        .HasColumnType("bit");

                    b.Property<int>("Strength")
                        .HasColumnType("int");

                    b.Property<bool>("Stunned")
                        .HasColumnType("bit");

                    b.Property<bool>("Vulnerable")
                        .HasColumnType("bit");

                    b.Property<int>("VulnerableRounds")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("Characters");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Character");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("DTpureback.Models.Item", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ItemStat")
                        .HasColumnType("int");

                    b.Property<int?>("PlayerCharacterID")
                        .HasColumnType("int");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<string>("Slot")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("PlayerCharacterID");

                    b.ToTable("Items");
                });

            modelBuilder.Entity("DTpureback.Models.Location", b =>
                {
                    b.Property<string>("ID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int?>("CommonNPC")
                        .HasColumnType("int");

                    b.Property<string>("EnterText")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ExitText")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MoveOptions")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Next")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("RareNPC")
                        .HasColumnType("int");

                    b.Property<int?>("SecretNPC")
                        .HasColumnType("int");

                    b.Property<int?>("UncommonNPC")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("Locations");
                });

            modelBuilder.Entity("DTpureback.Models.SaveFile", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("LocationID")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PlayerCharacterID")
                        .HasColumnType("int");

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("UserID");

                    b.ToTable("SaveFiles");
                });

            modelBuilder.Entity("DTpureback.Models.User", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("User", (string)null);
                });

            modelBuilder.Entity("DTpureback.Models.NPC", b =>
                {
                    b.HasBaseType("DTpureback.Models.Character");

                    b.HasDiscriminator().HasValue("NPC");
                });

            modelBuilder.Entity("DTpureback.Models.PlayerCharacter", b =>
                {
                    b.HasBaseType("DTpureback.Models.Character");

                    b.Property<int>("ConstitutionXP")
                        .HasColumnType("int");

                    b.Property<int>("CurrentHP")
                        .HasColumnType("int");

                    b.Property<int>("CurrentMP")
                        .HasColumnType("int");

                    b.Property<int>("DexterityXP")
                        .HasColumnType("int");

                    b.Property<int>("IntelligenceXP")
                        .HasColumnType("int");

                    b.Property<int>("LifeTimeCurrency")
                        .HasColumnType("int");

                    b.Property<int>("StrengthXP")
                        .HasColumnType("int");

                    b.Property<int?>("WeaponID")
                        .HasColumnType("int");

                    b.Property<string>("currentLocation")
                        .HasColumnType("nvarchar(max)");

                    b.HasIndex("WeaponID");

                    b.HasDiscriminator().HasValue("PlayerCharacter");
                });

            modelBuilder.Entity("DTpureback.Models.Item", b =>
                {
                    b.HasOne("DTpureback.Models.PlayerCharacter", null)
                        .WithMany("Backpack")
                        .HasForeignKey("PlayerCharacterID");
                });

            modelBuilder.Entity("DTpureback.Models.SaveFile", b =>
                {
                    b.HasOne("DTpureback.Models.User", null)
                        .WithMany("SaveFiles")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DTpureback.Models.PlayerCharacter", b =>
                {
                    b.HasOne("DTpureback.Models.Item", "Weapon")
                        .WithMany()
                        .HasForeignKey("WeaponID");

                    b.Navigation("Weapon");
                });

            modelBuilder.Entity("DTpureback.Models.User", b =>
                {
                    b.Navigation("SaveFiles");
                });

            modelBuilder.Entity("DTpureback.Models.PlayerCharacter", b =>
                {
                    b.Navigation("Backpack");
                });
#pragma warning restore 612, 618
        }
    }
}
