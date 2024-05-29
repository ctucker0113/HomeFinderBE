﻿using HomeFinderBE.API;
using HomeFinderBE.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace HomeFinderBE.API
{
	public static class ItemAPI
	{
        public static void Map(WebApplication app)
        {
            // Get All Items
            app.MapGet("/api/getAllItems", (HomeFinderDbContext db) =>
            {
                return db.Items.ToList();
            });

            // Get Single Item
            app.MapGet("/api/getSingleItem/{id}", (HomeFinderDbContext db, int id) =>
            {
                var item = db.Items.FirstOrDefault(p => p.ID == id);

                if (item == null)
                {
                    return Results.NotFound("Item Not Found.");
                }

                return Results.Ok(item);
            });

            // Create Item
            app.MapPost("/api/createItem", (HomeFinderDbContext db, Item newItem) =>
            {
                db.Items.Add(newItem);
                db.SaveChanges();
                return Results.Created($"/api/createItem/{newItem.ID}", newItem);
            });


            // Delete Item
            app.MapDelete("/api/deleteItem/{id}", (HomeFinderDbContext db, int id) =>
            {
                var itemToDelete = db.Items.Find(id);
                if (itemToDelete == null) {
                    return Results.NotFound("Item Not Found."); }

                db.Items.Remove(itemToDelete);
                db.SaveChanges();
                return Results.NoContent();
            });

            // Update Item
            app.MapPatch("/api/updateItem/{id}", (HomeFinderDbContext db, int id, Item updateItem) =>
            {
                Item itemToUpdate = db.Items.SingleOrDefault(Item => Item.ID == id);
                if (itemToUpdate == null)
                {
                    return Results.NotFound("Item Not Found.");
                }
                itemToUpdate.Name = updateItem.Name;
                itemToUpdate.Image = updateItem.Image;
                itemToUpdate.RoomID = updateItem.RoomID;
                db.SaveChanges();
                return Results.NoContent();
            });
        }

    }
    }

