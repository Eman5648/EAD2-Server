using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CA2_Server;

namespace CA2_Server.Data
{
    public class CA2_ServerContext : DbContext
    {
        public CA2_ServerContext (DbContextOptions<CA2_ServerContext> options)
            : base(options)
        {
        }
        public DbSet<CA2_Server.Books> Books { get; set; }
        public DbSet<CA2_Server.Authors> Authors { get; set; }

    }
}
