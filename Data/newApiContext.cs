using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using newApi.Models;

namespace newApi.Data
{
    public class newApiContext : DbContext
    {
        public newApiContext (DbContextOptions<newApiContext> options)
            : base(options)
        {
        }

        public DbSet<newApi.Models.User> User { get; set; }
    }
}
