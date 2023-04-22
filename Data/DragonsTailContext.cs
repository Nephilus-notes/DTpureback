using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DTpureback.Models;
using DTpureback.Models.Resources;
using DTpureback.Converters;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace DTpureback.Data
{
    public class DragonsTailContext: DbContext
    {
        protected readonly IConfiguration Configuration;
        public DragonsTailContext(IConfiguration configuration)
        {
          Configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseNpgsql(Configuration.GetConnectionString("LocalDragonsTailContext"));
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Item> Items { get;set; }
        public DbSet<PlayerCharacter> PlayerCharacters { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<SaveFile> SaveFiles { get; set; }
        public DbSet<NPC> NPC { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    var valueComparer = new ValueComparer<ICollection<Item>>(
        //        (c1, c2) => c1.SequenceEqual(c2),
        //        c => c.Aggregate(0, (a, v) => HashCode.Combine(a, v.GetHashCode())),
        //        c => c.ToList());

        //    var ItemConverter = new JsonICollectionConverter();

            //modelBuilder.Entity<PlayerCharacter>()
            //    .Property(x => x.Items)
            //    .HasConversion(ItemConverter)
            //    .Metadata.SetValueComparer(valueComparer);



            //    .Property(x => x.Items)
            //.HasConversion(IntValueConverter);

        //}
    }
}
