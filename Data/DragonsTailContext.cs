using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DTpureback.Models;
using DTpureback.Models.Resources;
using DTpureback.Converters;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using DTpureback.Interfaces;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace DTpureback.Data
{
    public class DragonsTailContext: DbContext
    {
        protected readonly IConfiguration Configuration;
        public DragonsTailContext(IConfiguration configuration, DbContextOptions dbContextOptions) : base(dbContextOptions)
        {
          Configuration = configuration;
        }

        public DbSet<Item> Items { get;set; }
        public DbSet<PlayerCharacter> PlayerCharacters { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<SaveFile> SaveFiles { get; set; }
        public DbSet<NPC> NPC { get; set; }
        public DbSet<CharacterDefault> CharacterDefault { get; set; }

        public DbSet<Ability> Ability { get; set; }
        public DbSet<CharacterAbility> PlayerCharacterAbilities { get; set; }
        public DbSet<CharacterItem> PlayerCharacterItems { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var iCollectionValueComparer = new ValueComparer<ICollection<Item>>(
                (c1, c2) => c1.SequenceEqual(c2),
               c => c.Aggregate(0, (a, v) => HashCode.Combine(a, v.GetHashCode())),
                c => c.ToList());


            var intToStringIDComparer = new ValueComparer<IEnumerable<int>>(
            (c1, c2) => c1.SequenceEqual(c2),
            c => c.Aggregate(0, (a, v) => HashCode.Combine(a, v.GetHashCode())),
           c => c.ToList());


            var intToStringIDConverter = new IntToStringIDConverter();

            var equipmentConverter = new JsonEquippedItemsConverter();

            modelBuilder.Entity<Character>()
       .HasMany(c => c.Abilities)
       .WithMany() // Assumes many-to-many relationship
       .UsingEntity<CharacterAbility>(
           j => j.HasOne(ca => ca.Ability).WithMany().HasForeignKey(ca => ca.AbilityID),
           j => j.HasOne(ca => ca.Character).WithMany().HasForeignKey(ca => ca.CharacterID),
           j => {
               j.HasKey(ca => ca.ID);
               j.Property(ca => ca.ID).ValueGeneratedOnAdd();
           });

            modelBuilder.Entity<Character>()
        .HasMany(c => c.Items)
        .WithMany()
        .UsingEntity<CharacterItem>(
            j => j.HasOne(ci => ci.Item).WithMany().HasForeignKey(ci => ci.ItemID),
            j => j.HasOne(ci => ci.Character).WithMany().HasForeignKey(ci => ci.CharacterID),
            j =>
            {
                j.HasKey(ci => ci.ID);
                j.Property(ci => ci.ID).ValueGeneratedOnAdd();
            });


            modelBuilder.Entity<PlayerCharacter>()
                .Property(x => x.EquippedItems)
                .HasConversion(equipmentConverter);


            modelBuilder.Entity<Location>()
                .Property(l => l.OtherList)
                .HasConversion(intToStringIDConverter)
                .Metadata.SetValueComparer(intToStringIDComparer);

            modelBuilder.Entity<NPC>()
        .ToTable("NPCs");

            modelBuilder.Entity<PlayerCharacter>()
                .ToTable("PlayerCharacters");
        }

    }
}
