using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business
{
	public class B_Storage
	{
		public List<StorageEntity> GetListStorages()
		{
			using var db = new InventaryContext();
			return db.Storages.ToList();
		}

		public void CreateStorage(StorageEntity storage)
		{
			using var db = new InventaryContext();
			db.Storages.Add(storage);
			db.SaveChanges();
		}

		public void UpdateStorage(StorageEntity storage)
		{
			using var db = new InventaryContext();
			db.Storages.Update(storage);
			db.SaveChanges();
		}

	}
}
