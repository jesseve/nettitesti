using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class BoksiDB : DbContext
    {
        public DbSet<Tilaus> Tilaukset { get; set; }
    }
}
