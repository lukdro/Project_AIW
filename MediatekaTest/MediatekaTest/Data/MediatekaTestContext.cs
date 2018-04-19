using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MediatekaTest.Models
{
    public class MediatekaTestContext : DbContext
    {
        public MediatekaTestContext (DbContextOptions<MediatekaTestContext> options)
            : base(options)
        {
        }

        public DbSet<MediatekaTest.Models.Book> Book { get; set; }
    }
}
