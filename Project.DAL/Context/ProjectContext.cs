using System.Reflection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Project.Entity.Entity;

namespace Project.DAL.Context
{
    public class ProjectContext : IdentityDbContext
    {
        public ProjectContext(DbContextOptions<ProjectContext> options):base(options)
        {

        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
       

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    if (!optionsBuilder.IsConfigured)
        //    {
        //        optionsBuilder.UseSqlServer("server=FATIH\\SQLEXPRESS;database=Net5Project;uid=sa;pwd=123;");
        //    }
        //    base.OnConfiguring(optionsBuilder);
        //}
    }
}