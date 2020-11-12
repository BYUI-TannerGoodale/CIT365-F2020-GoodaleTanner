using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcMovie.Data;
using System;
using System.Linq;

namespace MvcMovie.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcMovieContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcMovieContext>>()))
            {
                // Look for any movies.
                if (context.Movie.Any())
                {
                    return;   // DB has been seeded
                }

                context.Movie.AddRange(
                    new Movie
                    {
                        Title = "The RM",
                        ReleaseDate = DateTime.Parse("2003-1-31"),
                        Genre = "Comedy",
                        Rating = "PG",
                        ImgPath = "therm.jpg",
                        Price = 7.99M
                    },

                    new Movie
                    {
                        Title = "Other Side of Heaven",
                        ReleaseDate = DateTime.Parse("2002-4-12"),
                        Genre = "Drama",
                        Rating = "PG",
                        ImgPath = "othersideofheaven.jpg",
                        Price = 8.99M
                    },

                    new Movie
                    {
                        Title = "Meet The Mormons",
                        ReleaseDate = DateTime.Parse("2014-10-10"),
                        Genre = "Documentary",
                        Rating = "G",
                        ImgPath = "meetthemormons.jpg",
                        Price = 1.99M
                    },

                    new Movie
                    {
                        Title = "Ephraim's Rescue",
                        ReleaseDate = DateTime.Parse("2013-5-31"),
                        Genre = "Drama",
                        Rating = "PG",
                        ImgPath = "ephraimsrescue.jpg",
                        Price = 10.99M
                    },

                    new Movie
                    {
                        Title = "The Fighting Preacher",
                        ReleaseDate = DateTime.Parse("2019-6-24"),
                        Genre = "Comedy",
                        Rating = "PG",
                        ImgPath = "fightingpreacher.jpg",
                        Price = 12.99M
                    }
                );
                context.SaveChanges();
            }
        }
    }
}