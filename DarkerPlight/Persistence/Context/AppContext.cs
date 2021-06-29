using DarkerPlight.DataModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DarkerPlight.Persistence
{
    public class AppDbContext : DbContext
    {
        private readonly string connectionString;
        public AppDbContext(DbContextOptions<AppDbContext> dbContextOptions) 
            : base (dbContextOptions)
        {}

        public DbSet<User> Users { get; set; }
        public DbSet<Chat> Chat { get; set; }

    }
}
