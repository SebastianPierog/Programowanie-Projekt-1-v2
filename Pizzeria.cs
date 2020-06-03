using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_v2
{
    class Pizzeria : DbContext
    {
        public DbSet<Pizze> Pizzunie { get; set; }
    }
}
