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
		public List<ProductEntity> GetListProduct()
		{
			using var db = new InventaryContext();
			return db.Products.ToList();
		}

		public void CreateProduct(ProductEntity product)
		{
			using var db = new InventaryContext();
			db.Products.Add(product);
			db.SaveChanges();
		}

		public void UpdateProduct(ProductEntity product)
		{
			using var db = new InventaryContext();
			db.Products.Update(product);
			db.SaveChanges();
		}



	}
}
