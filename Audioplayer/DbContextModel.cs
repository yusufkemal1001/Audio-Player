using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Audioplayer
{
    public partial class DbContextModel : DbContext
    {
        public DbContextModel()
            : base("name=DbContextModel")
        {
        }

        public virtual DbSet<Nummers> Nummers { get; set; }
        public virtual DbSet<PlaylistInhoud> PlaylistInhoud { get; set; }
        public virtual DbSet<Playlists> Playlists { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Nummers>()
                .Property(e => e.Path)
                .IsUnicode(false);

            modelBuilder.Entity<Playlists>()
                .Property(e => e.Name)
                .IsUnicode(false);
        }
    }
}
