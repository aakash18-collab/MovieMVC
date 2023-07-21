using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MovieMVC.Models;

namespace MovieMVC.Data
{
    public class MovieMVCContext : DbContext
    {
        public MovieMVCContext (DbContextOptions<MovieMVCContext> options)
            : base(options)
        {
        }

        public DbSet<MovieMVC.Models.Movie> Movie { get; set; } = default!;

        public DbSet<MovieMVC.Models.Hall> Hall { get; set; } = default!;

        public DbSet<MovieMVC.Models.Shift> Shift { get; set; } = default!;
    }
}
