using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using myLibrary.Data;
using System;
using System.Linq;

namespace myLibrary.Models
{
    public static class SeedData
    {
        public static void Initalize(IServiceProvider serviceProvider)
        {
            using (var context = new myLibraryContext(
                serviceProvider.GetRequiredService<
                DbContextOptions<myLibraryContext>>()))
            {
                if (context.Book.Any())
                {
                    return;
                }

                context.Book.AddRange(
                    new Book
                    {
                        Title = "All The Pretty Horses",
                        Author = "Cormac McCarthy",
                        ReleaseDate = DateTime.Parse("1992"),
                        Genre = "Fiction"
                    },

                    new Book
                    {
                        Title = "For Whom The Bell Tolls",
                        Author = "Ernest Hemingway",
                        ReleaseDate = DateTime.Parse("1940"),
                        Genre = "Fiction"
                    },

                    new Book
                    {
                        Title = "Tropic of Cancer",
                        Author = "Arthur Miller",
                        ReleaseDate = DateTime.Parse("1961"),
                        Genre = "Fiction"
                    },

                    new Book
                    {
                        Title = "Hitchhikers Guide To The Galaxy",
                        Author = "Douglas Adams",
                        ReleaseDate = DateTime.Parse("1979"),
                        Genre = "Fiction"
                    },

                    new Book
                    {
                        Title = "Fight Club",
                        Author = "Chuck Palanhniuk",
                        ReleaseDate = DateTime.Parse("1996"),
                        Genre = "Fiction"
                    },

                    new Book
                    {
                        Title = "A Peoples History of the United States, 1942 - Present",
                        Author = "Howard Zinn",
                        ReleaseDate = DateTime.Parse("1999"),
                        Genre = "Non-Fiction"
                    },
                    new Book
                    {
                        Title = "Guns, Germs, and Steel",
                        Author = "Jared Diamond",
                        ReleaseDate = DateTime.Parse("1997"),
                        Genre = "Non-Fiction"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
