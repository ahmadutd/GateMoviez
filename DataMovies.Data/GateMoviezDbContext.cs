using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using GateMoviez.Domain;

namespace GateMoviez.Data
{
    public class GateMoviezDbContext:IdentityDbContext<AppUser,AppRole,int>
    {
        public GateMoviezDbContext(DbContextOptions<GateMoviezDbContext> options)
            :base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<AppUser>().HasMany(u => u.CreatedVideos).WithOne(v => v.CreatedUser).HasForeignKey(v => v.CreatedBy);
            builder.Entity<AppUser>().HasMany(u => u.UpdatedVideos).WithOne(v => v.UpdatedUser).HasForeignKey(v => v.UpdatedBy);

            /*builder.Entity<Artist>().HasOne(at => at.ArtistType).WithMany(a => a.Artists).HasForeignKey(a => a.ArtistTypeId);*/  //1 To Many realestion

            builder.Entity<Artist_ArtistTypes>().HasOne(x => x.Artist).WithMany(x => x.Artist_ArtistTypes).HasForeignKey(x => x.ArtistId );   // Many to Many realestion
            builder.Entity<Artist_ArtistTypes>().HasOne(x => x.ArtistType).WithMany(x => x.Artist_ArtistTypes).HasForeignKey(x => x.ArtistTypeId );  // Many to Many realestion

            builder.Entity<VideoTags>().HasOne(x => x.Video).WithMany(x => x.VideoTags).HasForeignKey(x => x.VideoId);
            builder.Entity<VideoTags>().HasOne(x => x.Tag).WithMany(x => x.VideoTags).HasForeignKey(x => x.TagId);

        }

        public virtual DbSet<Video> Video { get; set; }
        public virtual DbSet<Comment> Comments { get; set; }
        public virtual DbSet<Artist> Artists { get; set; }
        public virtual DbSet<ArtistType> ArtistTypes { get; set; }
        public virtual DbSet<Artist_ArtistTypes> Artist_ArtistTypes { get; set; }
        public virtual DbSet<Tag> Tag { get; set; }
        public virtual DbSet<VideoTags> VideoTags { get; set; }


    }
}
