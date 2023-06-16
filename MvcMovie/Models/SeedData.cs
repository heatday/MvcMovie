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
                serviceProvider.GetRequiredService<DbContextOptions<MvcMovieContext>>()))
            {
                // Look for any movies.
                if (context.Movie.Any())
                {
                    return;   // DB has been seeded
                }
                context.Movie.AddRange(
                    new Movie
                    {
                        Title = "17 Miracles",
                        ReleaseDate = DateTime.Parse("2011-06-03"),
                        Genre = "Adventure-Drama",
                        Rating = "PG",
                        Price = 9.99M
                    },
                    new Movie
                    {
                        Title = "Ephraim's Rescue",
                        ReleaseDate = DateTime.Parse("2013-05-31"),
                        Genre = "Adventure-Drama",
                        Rating = "PG",
                        Price = 19.99M
                    },
                    new Movie
                    {
                        Title = "Gordon B. Hinckley: A Giant Among Men",
                        ReleaseDate = DateTime.Parse("2008-11-25"),
                        Genre = "Romance",
                        Rating = "PG",
                        Price = 3.99M
                    },
                    new Movie
                    {
                        Title = "Love, Kennedy",
                        ReleaseDate = DateTime.Parse("2017-06-02"),
                        Genre = "Drama",
                        Rating = "PG",
                        Price = 9.99M
                    },
                    new Movie
                    {
                        Title = "Meet the Mormons",
                        ReleaseDate = DateTime.Parse("2014-10-10"),
                        Genre = "Documentary",
                        Rating = "PG",
                        Price = 11.99M
                    },
                    new Movie
                    {
                        Title = "On the Lord's Errand: The Life of Thomas S. Monson",
                        ReleaseDate = DateTime.Parse("2009-09-01"),
                        Genre = "Documentary",
                        Rating = "PG",
                        Price = 0.00M
                    },
                    new Movie
                    {
                        Title = "The Best Two Years",
                        ReleaseDate = DateTime.Parse("2004-09-07"),
                        Genre = "Comedy-Drama",
                        Rating = "PG",
                        Price = 19.99M
                    },
                    new Movie
                    {
                        Title = "The Cokeville Miracle",
                        ReleaseDate = DateTime.Parse("2015-06-05"),
                        Genre = "Drama",
                        Rating = "PG-13",
                        Price = 0.00M
                    },
                    new Movie
                    {
                        Title = "The Fighting Preacher",
                        ReleaseDate = DateTime.Parse("2019-07-24"),
                        Genre = "Comedy-Drama",
                        Rating = "PG",
                        Price = 14.99M
                    },
                    new Movie
                    {
                        Title = "The Legend of Johnny Lingo",
                        ReleaseDate = DateTime.Parse("2003-08-29"),
                        Genre = "Adventure",
                        Rating = "G",
                        Price = 12.99M
                    },
                    new Movie
                    {
                        Title = "The Other Side of Heaven",
                        ReleaseDate = DateTime.Parse("2001-12-14"),
                        Genre = "Adventure-Drama",
                        Rating = "PG",
                        Price = 15.99M
                    },
                    new Movie
                    {
                        Title = "The Other Side of Heaven 2: Fire of Faith",
                        ReleaseDate = DateTime.Parse("2019-06-28"),
                        Genre = "Adventure-Drama",
                        Rating = "PG-13",
                        Price = 12.99M
                    },
                    new Movie
                    {
                        Title = "The RM",
                        ReleaseDate = DateTime.Parse("2003-01-31"),
                        Genre = "Comedy",
                        Rating = "PG",
                        Price = 15.99M
                    },
                    new Movie
                    {
                        Title = "The Saratov Approach",
                        ReleaseDate = DateTime.Parse("2013-10-09"),
                        Genre = "Drama",
                        Rating = "PG-13",
                        Price = 19.99M
                    },
                    new Movie
                    {
                        Title = "The Singles Ward",
                        ReleaseDate = DateTime.Parse("2002-01-30"),
                        Genre = "Comedy-Drama",
                        Rating = "PG",
                        Price = 19.99M
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
