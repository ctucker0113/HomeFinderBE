using System;
namespace HomeFinderBE.API
{
    public static class UserAPI
    {
        public static void Map(WebApplication app)
        {
            ////Check Users
            //app.MapGet("/checkUser/{uid}", (HomeFinderDbContext db, string uid) =>
            //{
            //    var user = db.Users.Where(x => x.UID == uid).ToList();

            //    if (uid == null)
            //    {
            //        return Results.NotFound();
            //    }
            //    else
            //    {
            //        return Results.Ok(user);
            //    }
            //});
        }

    }
}
