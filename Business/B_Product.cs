using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business
{
	public class B_Product
	{
		public static List<ProductEntity> GetListProduct()
		{
			using var db = new InventaryContext();
			return db.Products.ToList();
		}

		public static void CreateProduct(ProductEntity product)
		{
			using var db = new InventaryContext();
			db.Add(product);
			db.SaveChanges();
		}

		public static void UpdateProduct(ProductEntity product)
		{
			using var db = new InventaryContext();
			db.Products.Update(product);
			db.SaveChanges();
		}



	}
}
