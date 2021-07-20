using Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace DataAccess
{
	public class InventaryContext : DbContext
	{
		public DbSet<ProductEntity> Products {get; set;}
		public DbSet<CategoryEntity> Categories {get; set;}
		public DbSet<InOutEntity> InOuts { get; set; }
		public DbSet<WarehouseEntity> Warehouses { get; set; }
		public DbSet<StorageEntity> Storages { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder options)
		{
			if (!options.IsConfigured)
			{
				options.UseSqlServer("Server=DESKTOP-1BAM59G; Database=InventoryBD; Trusted_Connection=True;");

			}
		}


		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);

			modelBuilder.Entity<CategoryEntity>().HasData(
					new CategoryEntity() {CategoryId="ASH", CategoryName="Aseo Hogar"},
					new CategoryEntity() {CategoryId="ASP", CategoryName="Aseo Personal"},
					new CategoryEntity() {CategoryId="HGR", CategoryName="Hogar"},
					new CategoryEntity() {CategoryId="PRF", CategoryName="Perfumeria"},
					new CategoryEntity() {CategoryId="SLD", CategoryName="Salud"},
					new CategoryEntity() {CategoryId="VDJ", CategoryName="Video juegos"}
				);

			modelBuilder.Entity<WarehouseEntity>().HasData(
					new WarehouseEntity() {WarehouseId=Guid.NewGuid().ToString(), 
										WarehouseName="Bodega Central",
										WarehouseAddress="Calle 8 #23" },

					new WarehouseEntity() {WarehouseId=Guid.NewGuid().ToString(), 
											WarehouseName="Bodega Norte", 
											WarehouseAddress="Calle Norte #21" },

					new WarehouseEntity() {WarehouseId=Guid.NewGuid().ToString(), 
											WarehouseName="Bodega sur", 
											WarehouseAddress="Calle Sur 18 #23-21" },

					new WarehouseEntity() {WarehouseId=Guid.NewGuid().ToString(), 
											WarehouseName="Bodega Occidental", 
											WarehouseAddress="Calle 8 #23" }
				);
		}


	}
}
