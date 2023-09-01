using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Assign16.Models;
using Task = Assign16.Models.Task;

namespace Assign16.Data
{
    public class Assign16DBContext : DbContext
    {
        public Assign16DBContext (DbContextOptions<Assign16DBContext> options)
            : base(options)
        {
        }

        public DbSet<Task> Task { get; set; } = default!;
    }
}
