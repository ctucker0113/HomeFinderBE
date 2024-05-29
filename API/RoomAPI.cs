using HomeFinderBE.API;
using HomeFinderBE.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace HomeFinderBE.API
{
    public static class RoomAPI
    {
        public static void Map(WebApplication app)
        {
            // Get All Rooms
            app.MapGet("/api/getAllRooms", (HomeFinderDbContext db) =>
            {
                return db.Rooms.ToList();
            });

            // Get Single Room
            app.MapGet("/api/getSingleRoom/{id}", (HomeFinderDbContext db, int id) =>
            {
                var room = db.Rooms.FirstOrDefault(p => p.ID == id);

                if (room == null)
                {
                    return Results.NotFound("Room Not Found.");
                }

                return Results.Ok(room);
            });

            // Create Room
            app.MapPost("/api/createRoom", (HomeFinderDbContext db, Room newRoom) =>
            {
                db.Rooms.Add(newRoom);
                db.SaveChanges();
                return Results.Created($"/api/createRoom/{newRoom.ID}", newRoom);
            });


            // Delete Room
            app.MapDelete("/api/deleteRoom/{id}", (HomeFinderDbContext db, int id) =>
            {
                var roomToDelete = db.Rooms.Find(id);
                if (roomToDelete == null)
                {
                    return Results.NotFound("Room Not Found.");
                }

                db.Rooms.Remove(roomToDelete);
                db.SaveChanges();
                return Results.NoContent();
            });

            // Update Room
            app.MapPatch("/api/updateRoom/{id}", (HomeFinderDbContext db, int id, Room updateRoom) =>
            {
                Room roomToUpdate = db.Rooms.SingleOrDefault(Room => Room.ID == id);
                if (roomToUpdate == null)
                {
                    return Results.NotFound("Room Not Found.");
                }

                roomToUpdate.Name = updateRoom.Name;
                roomToUpdate.Image = updateRoom.Image;

                db.SaveChanges();
                return Results.NoContent();
            });
        }

    }
}
