using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TwitchPartnership2020.Models;

namespace TwitchPartnership2020.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<Advertiser> Advertisers { get; set; }
        public DbSet<Appeal> Appeals { get; set; }
        public DbSet<Auth> Auths { get; set; }
        public DbSet<Banner> Banners { get; set; }
        public DbSet<Content> Contents { get; set; }
        public DbSet<Operation> Operations { get; set; }
        public DbSet<Purse> Purses { get; set; }
        public DbSet<Stream> Streams { get; set; }
        public DbSet<Streamer> Streamers { get; set; }
        public DbSet<View> Views { get; set; }
        public DbSet<Thematics> Thematics { get; set; }
        public DbSet<Moderator> Moderators { get; set; }
        public DbSet<Redirect> Redirects { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Advertiser>().ToTable("Advertiser");
            modelBuilder.Entity<Appeal>().ToTable("Appeal");
            modelBuilder.Entity<Auth>().ToTable("Auth");
            modelBuilder.Entity<Banner>().ToTable("Banner");
            modelBuilder.Entity<Content>().ToTable("Content");
            modelBuilder.Entity<Operation>().ToTable("Operation");
            modelBuilder.Entity<Purse>().ToTable("Purse");
            modelBuilder.Entity<Stream>().ToTable("Stream");
            modelBuilder.Entity<View>().ToTable("View");
            modelBuilder.Entity<Thematics>().ToTable("Thematic");
            modelBuilder.Entity<Moderator>().ToTable("Moderator");
            modelBuilder.Entity<Redirect>().ToTable("Redirect");
        }
    }
}
