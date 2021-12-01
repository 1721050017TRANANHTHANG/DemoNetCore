using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcMovie.Models;

public class MvcMovieContext : DbContext
{
    public MvcMovieContext(DbContextOptions<MvcMovieContext> options)
        : base(options)
    {
    }

    public DbSet<MvcMovie.Models.Movie> Movie { get; set; }

    public DbSet<MvcMovie.Models.Person> Person { get; set; }

    public DbSet<MvcMovie.Models.Student> Student { get; set; }

    public DbSet<MvcMovie.Models.Category> Category { get; set; }

    public DbSet<MvcMovie.Models.Product> Product { get; set; }


    public DbSet<MvcMovie.Models.sanpham> sanpham { get; set; }

    public DbSet<MvcMovie.Models.A> A { get; set; }

    public DbSet<MvcMovie.Models.B> B { get; set; }

    public DbSet<MvcMovie.Models.Loaisanpham> Loaisanpham { get; set; }
}
