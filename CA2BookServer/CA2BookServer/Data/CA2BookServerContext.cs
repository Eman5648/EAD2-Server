#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CA2BookServer.Model;

namespace CA2BookServer.Data
{
    public class CA2BookServerContext : DbContext
    {
        public CA2BookServerContext (DbContextOptions<CA2BookServerContext> options)
            : base(options)
        {
        }

        public DbSet<CA2BookServer.Model.Books> Books { get; set; }

        public DbSet<CA2BookServer.Model.Authors> Authors { get; set; }
    }
}
