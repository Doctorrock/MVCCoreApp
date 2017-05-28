using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MVCCoreApp.Models
{
    public class MVCCoreAppContext : DbContext
    {
        public MVCCoreAppContext (DbContextOptions<MVCCoreAppContext> options)
            : base(options)
        {
        }

        public DbSet<MVCCoreApp.Models.Person> Person { get; set; }
    }
}
