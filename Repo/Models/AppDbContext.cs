using Microsoft.EntityFrameworkCore;
using Repo.Models.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repo.Models
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<BusySchedule> BusySchedule{set;get; }
        public DbSet<Post> Post { set;get; }
        public DbSet<History> History { set;get; }
        public DbSet<User> User { set;get; }
        public DbSet<Role> Role { set;get; }
        public DbSet<Booking> Booking { set;get; }
        public DbSet<UserRole> UserRole { set;get; }
        public DbSet<Repo.Models.Entities.Type> Type { set;get; }
        public DbSet<Category> Category { set;get; }
        public DbSet<Course> Course { set;get; }
    }
}
