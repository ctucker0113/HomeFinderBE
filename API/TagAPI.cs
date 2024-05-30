using HomeFinderBE.API;
using HomeFinderBE.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace HomeFinderBE.API
{
    public static class TagAPI
    {
        public static void Map(WebApplication app)
        {
            // Get All Tags
            app.MapGet("/api/getAllTags", (HomeFinderDbContext db) =>
            {
                return db.Tags.ToList();
            });

            // Get Single Tag
            app.MapGet("/api/getSingleTag/{id}", (HomeFinderDbContext db, int id) =>
            {
                var tag = db.Tags.FirstOrDefault(p => p.ID == id);

                if (tag == null)
                {
                    return Results.NotFound("Tag Not Found.");
                }

                return Results.Ok(tag);
            });

            // Create Tag
            app.MapPost("/api/createTag", (HomeFinderDbContext db, Tag newTag) =>
            {
                db.Tags.Add(newTag);
                db.SaveChanges();
                return Results.Created($"/api/createTag/{newTag.ID}", newTag);
            });


            // Delete Tag
            app.MapDelete("/api/deleteTag/{id}", (HomeFinderDbContext db, int id) =>
            {
                var tagToDelete = db.Tags.Find(id);
                if (tagToDelete == null)
                {
                    return Results.NotFound("Tag Not Found.");
                }

                db.Tags.Remove(tagToDelete);
                db.SaveChanges();
                return Results.NoContent();
            });


        }

    }
}


