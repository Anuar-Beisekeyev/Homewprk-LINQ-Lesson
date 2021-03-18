using HomeworkLINQlesson.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeworkLINQlesson.Data
{
    public class ShopContext : DbContext
    {
        public ShopContext()
        {
            Database.EnsureCreated();
        }
        public DbSet<Notebook> Notebooks { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-3S2N5VP; Database=HomeworkLINQlesson; Trusted_Connection = true;");
        }
    }
}
