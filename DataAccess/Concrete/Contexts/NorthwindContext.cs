
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;


namespace CoreLayer.DataAccess.Concrete.EntityFramework.Contexts
{
    public class NorthwindContext:DbContext
    {
       protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer(connectionString: @"Server=(localdb)\MSSQLLocalDB;initial catalog=Northwind;integrated security=true");
        }    
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        //Veritabanına eşleştirme yaptığımız Context klası içerisindeyiz
        //DbContext'i (Entity veri tabanı klası) veri tabanımıza implemente ettik. 
        //Veri tabanı alanlarımızı set yaptık (Kullanılan her tablo için ayrı ayrı)

    }
}
