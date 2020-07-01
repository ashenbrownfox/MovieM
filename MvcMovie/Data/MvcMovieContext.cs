using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MvcMovie.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcMovie.Data
{
    public class MvcMovieContext : IdentityDbContext<StoreUser>
    {
        public MvcMovieContext(DbContextOptions<MvcMovieContext> options): 
            base(options)
        { 
        }

        public DbSet<Movie> Movie { get; set; }
        public DbSet<Book> Book { get; set; }
    }
}
