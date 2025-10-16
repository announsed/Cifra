using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp_Тема_34._Урок_2._Домашнее_задание_.Entities;
using Microsoft.EntityFrameworkCore;

namespace ConsoleApp_Тема_34._Урок_2._Домашнее_задание_
{
    internal class DataBaseCategories : DbContext
    {
        internal DataBaseCategories() 
        {
            Database.EnsureDeleted();
            Database.EnsureCreated();
        }

        internal DataBaseCategories(DbContextOptions<DataBaseCategories> options) : base(options)
        {

        }
        DbSet<Categories> Categories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
        {
            optionsBuilder.UseSqlite("Data Source=C:\\Users\\epifa\\Desktop\\CifraNoDz\\Задания\\Zaebal-Scaffold-DbContext\\ConsoleApp Тема 34. Урок 2. Домашнее задание\\Entities\\Categories.db");
        }
    }

    internal class DataBaseOrders : DbContext
    {
        internal DataBaseOrders()
        {
            Database.EnsureDeleted();
            Database.EnsureCreated();
        }

        internal DataBaseOrders(DbContextOptions<DataBaseOrders> options) : base(options)
        {

        }
        DbSet<Orders> Orders { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=C:\\Users\\epifa\\Desktop\\CifraNoDz\\Задания\\Zaebal-Scaffold-DbContext\\ConsoleApp Тема 34. Урок 2. Домашнее задание\\Entities\\Orders.db");
        }
    }


    internal class DataBaseProducts : DbContext
    {
        internal DataBaseProducts()
        {
            Database.EnsureDeleted();
            Database.EnsureCreated();
        }

        internal DataBaseProducts(DbContextOptions<DataBaseProducts> options) : base(options)
        {

        }
        DbSet<Products> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=C:\\Users\\epifa\\Desktop\\CifraNoDz\\Задания\\Zaebal-Scaffold-DbContext\\ConsoleApp Тема 34. Урок 2. Домашнее задание\\Entities\\Products.db");
        }
    }

    internal class DataBaseUsers : DbContext
    {
        internal DataBaseUsers()
        {
            Database.EnsureDeleted();
            Database.EnsureCreated();
        }

        internal DataBaseUsers(DbContextOptions<DataBaseUsers> options) : base(options)
        {

        }
        DbSet<Users> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=C:\\Users\\epifa\\Desktop\\CifraNoDz\\Задания\\Zaebal-Scaffold-DbContext\\ConsoleApp Тема 34. Урок 2. Домашнее задание\\Entities\\Users.db");
        }
    }
}
