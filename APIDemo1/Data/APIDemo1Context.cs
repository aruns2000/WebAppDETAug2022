using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using APIDemo1.Models;

namespace APIDemo1.Data
{
    public class APIDemo1Context : DbContext
    {
        public APIDemo1Context (DbContextOptions<APIDemo1Context> options)
            : base(options)
        {
        }

        public DbSet<APIDemo1.Models.User> User { get; set; } = default!;

        public DbSet<APIDemo1.Models.TodoItem>? TodoItem { get; set; }
    }
}
