using Microsoft.EntityFrameworkCore;
using PretzelFrontToBack.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PretzelFrontToBack.DAL
{
    public class AppDbContext:DbContext
    {
        private readonly AppDbContext _context;
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {

        }
        public DbSet<Slider> sliders { get; set; }
    }
}
