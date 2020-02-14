using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Common;
namespace ILoveCats.Models
{
    public class CatContext : DbContext
    {
        public DbSet<Cat> Cats { get; set; }

        public CatContext(DbContextOptions<CatContext> options)
            : base(options)
        {
        }
        

    }
}
