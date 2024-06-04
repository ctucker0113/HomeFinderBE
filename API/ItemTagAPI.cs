using HomeFinderBE.API;
using HomeFinderBE.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace HomeFinderBE.API
{
    public static class ItemTagAPI
    {
        public static void Map(WebApplication app)
        {
            // Get All ItemTags for an Item
            app.MapGet("/api/getAllTagsForSingleItem/{itemID}", async (HomeFinderDbContext db, int itemID) =>
            {
                // Fetch ItemTags for the given itemID
                var itemTags = await db.ItemTags
                    .Where(it => it.ItemID == itemID)
                    .Select(it => it.TagID)
                    .ToListAsync();

                if (!itemTags.Any())
                {
                    return Results.NotFound("No Tags Found For This Item.");
                }

                // Fetch Tags based on the retrieved TagIDs
                var tags = await db.Tags
                    .Where(t => itemTags.Contains(t.ID))
                    .ToListAsync();

                return Results.Ok(tags);
            });

            // Create ItemTag (i.e. - Add a Tag to an Item)
            app.MapPost("/api/addTagToItem/{itemID}/{tagID}", (HomeFinderDbContext db, int itemID, int tagID) =>
            {
                var item = db.Items.Find(itemID);
                var tag = db.Tags.Find(tagID);

                // Check if the Item and the Tag both exist
                if (item == null || tag == null)
                {
                    return Results.NotFound("Item or Tag not found.");
                }

                // Check if the Item already contains the Tag
                var existingItemTag = db.ItemTags.FirstOrDefault(pp => pp.ItemID == itemID && pp.TagID == tagID);

                if (existingItemTag != null)
                {
                    return Results.BadRequest("Tag already exists on this item.");
                }

                // If all previous checks clear, create a new ItemTag entity
                var newItemTag = new ItemTag
                {
                    ItemID = itemID,
                    TagID = tagID,
                };

                db.ItemTags.Add(newItemTag);
                db.SaveChanges();

                return Results.Ok("Tag Successfully Added to Item.");
            });


            // Delete ItemTag (i.e. - Delete a Tag From an Item)
            app.MapDelete("/api/DeleteTagFromItem/{itemID}/{tagID}", (HomeFinderDbContext db, int itemID, int tagID) =>
            {
                var itemTagToDelete = db.ItemTags.SingleOrDefault(itemTag => itemTag.ItemID == itemID && itemTag.TagID == tagID);

                if (itemTagToDelete == null)
                {
                    return Results.NotFound("Tag not found on the item.");
                }

                db.ItemTags.Remove(itemTagToDelete);
                db.SaveChanges();

                return Results.Ok("Tag successfully deleted from item.");
            });
        }
    }
}


