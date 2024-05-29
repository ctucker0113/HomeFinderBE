using Microsoft.EntityFrameworkCore;
using HomeFinderBE.Models;
using System.Runtime.CompilerServices;

public class HomeFinderDbContext : DbContext
{

    public DbSet<Item> Items { get; set; }
    public DbSet<Room> Rooms { get; set; }
    public DbSet<Tag> Tags { get; set; }
    public DbSet<ItemTag> ItemTags { get; set; }

    public HomeFinderDbContext(DbContextOptions<HomeFinderDbContext> context) : base(context)
    {

    }
}

