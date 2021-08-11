using GewichtIngave.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GewichtIngave.Data
{
    public class GewichtDbContext : DbContext
    {
        public GewichtDbContext(DbContextOptions<GewichtDbContext> options) : base(options)
        {

        }
        public DbSet<GewichtModel> Wegingen { get; set; }

    }
}
