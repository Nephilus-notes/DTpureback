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

        //protected override void OnConfiguring(DbContextOptionsBuilder options)
        //{
        //    options.UseNpgsql(Configuration.GetConnectionString("ConnectionString"));
        //}
        public DbSet<User> Users { get; set; }
        public DbSet<Item> Items { get;set; }
        public DbSet<PlayerCharacter> PlayerCharacters { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<SaveFile> SaveFiles { get; set; }
        public DbSet<NPC> NPC { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var iCollectionValueComparer = new ValueComparer<ICollection<Item>>(
                (c1, c2) => c1.SequenceEqual(c2),
                c => c.Aggregate(0, (a, v) => HashCode.Combine(a, v.GetHashCode())),
                c => c.ToList());

            //var singleValueComparer = new ValueComparer<IEquipment>(
            //    (c1, c2) => c1.SequenceEqual(c2),
            //    c => c.Aggregate(0, (a, v) => HashCode.Combine(a, v.GetHashCode())),
            //   c => c.ToList());

            var equipmentConverter = new JsonEquippedItemsConverter();

            var ItemsConverter = new JsonICollectionConverter();

            var SingleItemConverter = new JsonItemConverter();

            modelBuilder.Entity<PlayerCharacter>()
                .Property(x => x.Items)
                .HasConversion(ItemsConverter)
                .Metadata.SetValueComparer(iCollectionValueComparer);

            modelBuilder.Entity<PlayerCharacter>()
                .Property(x => x.EquippedItems)
                .HasConversion(equipmentConverter);
                //.Metadata.SetValueComparer(iCollectionValueComparer);

            //modelBuilder.Entity<PlayerCharacter>()
            //    .Property(x => x.HeadItem).HasConversion(SingleItemConverter);
            //    //.Metadata.SetValueComparer(singleValueComparer)/*;*/

            //modelBuilder.Entity<PlayerCharacter>()
            //    .Property(x => x.HandItem).HasConversion(SingleItemConverter);
            //    //.Metadata.SetValueComparer(singleValueComparer);
            //modelBuilder.Entity<PlayerCharacter>()
            //    .Property(x => x.BodyItem).HasConversion(SingleItemConverter);
        }
    }
}
