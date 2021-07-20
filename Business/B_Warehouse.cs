using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business
{
	public class B_Warehouse
	{
		public List<WarehouseEntity> GetListWarehouse()
		{
			using var db = new InventaryContext();
			return db.Warehouses.ToList();
		}

		public void CreateWarehouse(WarehouseEntity warehouse)
		{
			using var db = new InventaryContext();
			db.Warehouses.Add(warehouse);
			db.SaveChanges();
		}

		public void UpdateWarehouse(WarehouseEntity warehouse)
		{
			using var db = new InventaryContext();
			db.Warehouses.Update(warehouse);
			db.SaveChanges();
		}

	}
}
