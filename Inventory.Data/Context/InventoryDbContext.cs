﻿using Inventory.Data.Data_Seeds;
using Inventory.Data.Models;
using KoalaInventoryManagement.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Inventory.Data.Context
{
    public class InventoryDbContext : IdentityDbContext<ApplicationUser>
    {
        #region Inventory Tables DbSets
        public DbSet<Category> Categories { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public virtual DbSet<WareHouse> WareHouses { get; set; }
        public virtual DbSet<WareHouseProduct> WareHousesProducts { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        #endregion


            public InventoryDbContext(DbContextOptions<InventoryDbContext> options) : base(options)
            { }

            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                #region Data Seeding
                modelBuilder.Entity<Category>()
                            .HasData(CategoriesSeed.categories);

                modelBuilder.Entity<Supplier>()
                            .HasData(SuppliersSeed.suppliers);

                modelBuilder.Entity<WareHouse>()
                            .HasData(WareHousesSeed.WareHouses);

                modelBuilder.Entity<Product>()
                            .HasData(ProductsSeed.Products);

                modelBuilder.Entity<WareHouseProduct>()
                            .HasData(WareHousesProductsSeed.WareHouseProducts);

                modelBuilder.Entity<IdentityRole>()
                            .HasData(RolesSeed.Roles);
            #endregion

                #region WareHouse and Product M:M Relationship
            //composite primary key
            modelBuilder.Entity<WareHouseProduct>()
                            .HasKey(whp => new { whp.ProductID, whp.WareHouseID });

                modelBuilder.Entity<WareHouse>()
                                .HasMany(w => w.WareHouseProducts)
                                .WithOne(whp => whp.WareHouse)
                                .OnDelete(DeleteBehavior.Restrict);

                modelBuilder.Entity<Product>()
                            .HasMany(p => p.WareHouseProducts)
                            .WithOne(whp => whp.Product)
                            .OnDelete(DeleteBehavior.Cascade);

                modelBuilder.Entity<Supplier>()
                            .HasMany(s => s.Products)
                            .WithOne(p => p.Supplier)
                            .OnDelete(DeleteBehavior.SetNull);

                modelBuilder.Entity<Category>()
                            .HasMany(c => c.Products)
                            .WithOne(p => p.Category)
                            .OnDelete(DeleteBehavior.SetNull);
                #endregion

                base.OnModelCreating(modelBuilder);
            }
    }
}
