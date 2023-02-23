using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission6_stevenf4.Models
{
    public class MovieContext : DbContext
    {
        //Constructor
        public MovieContext (DbContextOptions<MovieContext> options) : base (options)
        {
            //leave blank for now
        }

        public DbSet<ApplicationResponse> Responses { get; set; }
        public DbSet<Category> Categories { get; set; }

        //seeding the data
        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Category>().HasData(
                new Category { categoryID=1, categoryName="Action"},
                new Category { categoryID =2, categoryName = "Adventure" },
                new Category { categoryID =3, categoryName = "Comedy" },
                new Category { categoryID =4, categoryName = "Drama" },
                new Category { categoryID =5, categoryName = "Fantasy" },
                new Category { categoryID =6, categoryName = "Horror" },
                new Category { categoryID =7, categoryName = "Mystery" },
                new Category { categoryID =8, categoryName = "Romance" },
                new Category { categoryID =9, categoryName = "Thriller" }
                
            );

            mb.Entity<ApplicationResponse>().HasData(
                new ApplicationResponse
                {
                    MovieID = 1,
                    categoryID = 3,
                    title = "Nacho Libre",
                    year = 2006,
                    director = "Jared Hess",
                    rating = "PG"
                },
                new ApplicationResponse
                {
                    MovieID = 2,
                    categoryID = 2,
                    title = "Interstellar",
                    year = 2014,
                    director = "Christopher Nolan",
                    rating = "PG-13"
                },
                new ApplicationResponse
                {
                    MovieID = 3,
                    categoryID = 3,
                    title = "Puss in Boots: The Last Wish",
                    year = 2022,
                    director = "Joel Crawford",
                    rating = "PG"
                }

                );
        }
    }
}
