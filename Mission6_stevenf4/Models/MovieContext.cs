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

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<ApplicationResponse>().HasData(
                new ApplicationResponse
                {
                    MovieID = 1,
                    category = "Comedy",
                    title = "Nacho Libre",
                    year = 2006,
                    director = "Jared Hess",
                    rating = "PG"
                },
                new ApplicationResponse
                {
                    MovieID = 2,
                    category = "Adventure",
                    title = "Interstellar",
                    year = 2014,
                    director = "Christopher Nolan",
                    rating = "PG-13"
                },
                new ApplicationResponse
                {
                    MovieID = 3,
                    category = "Comedy",
                    title = "Puss in Boots: The Last Wish",
                    year = 2022,
                    director = "Joel Crawford",
                    rating = "PG"
                }

                );
        }
    }
}
