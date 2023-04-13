using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DTpureback.Models;

namespace DTpureback.Data
{
    public class DragonsTailContext: DbContext
    {
        public DragonsTailContext(DbContextOptions<DragonsTailContext> options)
           : base(options)
        {
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Item> Items { get;set; }
        public DbSet<Character> Characters { get; set; }
        public DbSet<PlayerCharacter> PlayerCharacters { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<SaveFile> SaveFiles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().ToTable(nameof(User))
                .HasMany(u => u.SaveFiles);
            //modelBuilder.Entity<Song>().ToTable(nameof(Song))
            //    .HasMany(s => s.Genres)
            //    .WithMany(g => g.Songs);
            //modelBuilder.Entity<User>().ToTable(nameof(User));
            //modelBuilder.Entity<Contributor>().ToTable(nameof(Contributor));
            //modelBuilder.Entity<Genre>().ToTable(nameof(Genre));
            //modelBuilder.Entity<Pedal>().ToTable(nameof(Pedal));
            //modelBuilder.Entity<SongContributor>().ToTable(nameof(SongContributor));
            //modelBuilder.Entity<SongPedal>().ToTable(nameof(SongPedal));
        }

        public DbSet<NPC>? NPC { get; set; }
    }
}
