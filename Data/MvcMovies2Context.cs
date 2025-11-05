using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcMovie.Models;

namespace MvcMovies2.Data
{
    public class MvcMovies2Context : DbContext
    {

        public MvcMovies2Context(DbContextOptions<MvcMovies2Context> options)
               : base(options)
        {
        }

        // Add this line to register the Movie entity
        public DbSet<Movie> Movie { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=MvcMovies2.db");
        }
    }
}
