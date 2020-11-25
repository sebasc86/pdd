using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ClassLibrary1.Entidades;
using System;
using System.Collections.Generic;
using System.Text;


namespace WebApplication1.Data
{
    public class DataContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=Db.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>(u =>
            {
                u.ToTable("User");
                u.Property(p => p.Id).ValueGeneratedOnAdd().HasColumnName("Id");
                u.Property(p => p.Name).HasColumnName("Name").HasColumnType("varchar(50)");
                u.Property(p => p.LastName).HasColumnName("Lastname").HasColumnType("varchar(50)");
                u.Property(p => p.Password).HasColumnName("Password").HasColumnType("varchar(20)");

            });


            modelBuilder.Entity<Tasks>(t =>
            {
                t.ToTable("Task");
                t.Property(p => p.Id).ValueGeneratedOnAdd().HasColumnName("Id");
                t.Property(p => p.Title).HasColumnName("Name").HasColumnType("varchar(50)");
                t.Property(p => p.Expiration).HasColumnName("Expiration").HasColumnType("datetime");
                t.Property(p => p.Estimate).HasColumnName("Estimate").HasColumnType("varchar(50)");
                t.Property(p => p.State).HasColumnName("State").HasColumnType("varchar(20)");



            });

            modelBuilder.Entity<Resource>(r =>
            {
                r.ToTable("Resource");
                r.Property(p => p.Id).ValueGeneratedOnAdd().HasColumnName("Id");
                r.Property(p => p.Name).HasColumnName("Name").HasColumnType("varchar(50)");

            });

            modelBuilder.Entity<Detail>(r =>
            {
                r.ToTable("Detail");
                r.Property(p => p.Id).ValueGeneratedOnAdd().HasColumnName("Id");
                r.Property(p => p.Date).HasColumnName("Date").HasColumnType("datetime");
                r.Property(p => p.Time).HasColumnName("time").HasColumnType("integer");

            });



        }

        public DbSet<User> Users { get; set; }
        public DbSet<Tasks> Tasks { get; set; }
        public DbSet<Resource> Resources { get; set; }
        public DbSet<Detail> Details { get; set; }
    }
}

