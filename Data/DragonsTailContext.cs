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
        public DbSet<NPC>? NPC { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var IntValueConverter = new PCItemIDConverter();

            modelBuilder.Entity<PlayerCharacter>()
                .Property(x => x.ItemIDs)
            .HasConversion(IntValueConverter)
                .Metadata.SetValueComparer();
        }




        //{
        //    modelBuilder.Entity<PlayerCharacter>(Character =>
        //    {
        //        Character.HasMany(i => i.Items)
        //        .WithMany(p => p.Character);
        //    });


            //modelBuilder.Entity<SaveFile>(entity =>
            //{
            //    entity.HasOne(u => u.User)
            //    .WithMany(s => s.SaveFiles)
            //    .HasForeignKey(x => x.UserID)
            //    .OnDelete(DeleteBehavior.Restrict)
            //    .HasConstraintName("FK_User_SaveFile");

            //entity.HasOne(pc => pc.Character)
            //    .WithOne(s => s.Save)
            //    .HasForeignKey<PlayerCharacter>(x => x.ID);
            //});
        

    }
}
