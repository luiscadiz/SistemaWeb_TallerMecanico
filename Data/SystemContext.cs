using System;
using Microsoft.EntityFrameworkCore;
using Web_System.Models;

namespace Web_System.Data
{
    public class SystemContext : DbContext
    {
        public SystemContext(DbContextOptions<SystemContext> options) 
            : base(options) { }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlServer("Data Source=DESKTOP-E6E1U8H;Initial Catalog=DB_WebSystem;User ID=sa;Password=1969Arpanet");

        public DbSet<Admins> Admins {get; set;}

        // public DbSet<Clients> Clients {get; set;}

        // public DbSet<Vehicles> Vehicles {get; set;}

        // public DbSet<Parts> Parts {get; set;}
        // public DbSet<Suppliers> Suppliers {get; set;}

    }
}