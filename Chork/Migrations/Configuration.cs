namespace Chork.Migrations
{
    using Chork.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Chork.Models.MovieDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Chork.Models.MovieDBContext context)
        {
            context.Movies.AddOrUpdate(i => i.Title, 
                new Movie
                {
                Title = "The Wet Janitor",
                ReleaseDate = DateTime.Parse("2009-3-12"),
                Genre = "Action",
                Rating = "PG",
                Price = 2345.54M
                },

                new Movie
                {
                Title = "Janice's Foot",
                ReleaseDate = DateTime.Parse("2010-8-2"),
                Genre = "Horror",
                Rating = "M",
                Price = 3452.54M
                },

                new Movie
                {
                Title = "Harold and James",
                ReleaseDate = DateTime.Parse("2009-3-12"),
                Genre = "Comedy",
                Rating = "G",
                Price = 4523.54M
                }

             );
        }
    }
}
