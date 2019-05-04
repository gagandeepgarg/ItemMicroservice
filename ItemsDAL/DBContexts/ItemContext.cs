
using System;
using ItemsDAL.Entity;
using Microsoft.EntityFrameworkCore;

namespace ItemsDAL.DBContexts
{
    public class ItemContext : DbContext
    {
        public ItemContext() { }
        public ItemContext(DbContextOptions<ItemContext> options) : base(options)
        {
        }

        public DbSet<Item> Item { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Item>().HasData(
                new Item
                {
                    Id = 1,
                    CategoryId=1,
                    PricePerUnit=100,
                    MeasurementUnit= (int)MeasurementUnit.feet,
                    CreatedOn = DateTime.Now,
                    CreatedBy = 1,
                    UpdatedOn = null,
                    UpdatedBy = null
                });
        }
    }
}