using Staging.Model;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace Staging.Context
{
    public class CodeFirstContext : DbContext
    {

        private static bool _created = false;

        //public CodeFirstContext() : base()
        //{
        //    if (!_created)
        //    {
        //        _created = true;
        //        Database.EnsureDeleted();
        //        Database.EnsureCreated();
        //    }
        //}
        //protected override void OnConfiguring(DbContextOptionsBuilder optionbuilder)
        //{
        //    optionbuilder.UseSqlite(@"Data Source=.\Sample.db");
        //}

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    //modelBuilder.Entity<OrderArticle>().HasNoKey();

        //    modelBuilder.Entity<OrderArticle>()
        //                .HasKey(pt => new { pt.OrderId, pt.ArticleId });

            //modelBuilder.Entity<OrderArticle>()
            //            .HasOne(pt => pt.Order)
            //            .WithMany(p => p.OrderArticles)
            //            .HasForeignKey(pt => pt.OrderId);

            //modelBuilder.Entity<OrderArticle>()
            //            .HasOne(pt => pt.Article)
            //            .WithMany(t => t.OrderArticles)
            //            .HasForeignKey(pt => pt.ArticleId);
        //}

    //public DbSet<Article> Articles { get; set; }
    //public DbSet<Order> Orders { get; set; }
    //public DbSet<Stock> Stocks { get; set; }
}
}
