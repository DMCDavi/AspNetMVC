using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AspNetMVC.Models;

namespace AspNetMVC.Data
{
    public class AspNetMVCContext : DbContext
    {
        public AspNetMVCContext (DbContextOptions<AspNetMVCContext> options)
            : base(options)
        {
            this.Database.EnsureCreated();
        }

        public DbSet<AspNetMVC.Models.Contact> Contact { get; set; }
    }
}
