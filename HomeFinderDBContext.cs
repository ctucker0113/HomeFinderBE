using Microsoft.EntityFrameworkCore;
using HomeFinderBE.Models;
using HomeFinderBE.Data;
using System.Runtime.CompilerServices;

public class HomeFinderDbContext : DbContext
{

    public DbSet<Item> Items { get; set; }
    public DbSet<Room> Rooms { get; set; }
    public DbSet<Tag> Tags { get; set; }
    public DbSet<ItemTag> ItemTags { get; set; }
    public DbSet<User> Users { get; set; }

    public HomeFinderDbContext(DbContextOptions<HomeFinderDbContext> context) : base(context)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Item>().HasData(ItemSampleData.Items);
        modelBuilder.Entity<ItemTag>().HasData(ItemTagSampleData.ItemTags);
        modelBuilder.Entity<Room>().HasData(RoomSampleData.Rooms);
        modelBuilder.Entity<Tag>().HasData(TagSampleData.Tags);
        modelBuilder.Entity<User>().HasData(UserSampleData.Users);
    }
}


