using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Business
{
	public class B_Category
	{
		public List<CategoryEntity> CategoryList()
		{
			using var db = new InventaryContext();
			return db.Categories.ToList();
		} 

		public void CreateCategory(CategoryEntity category)
		{
			using var db = new InventaryContext();
			db.Add(category);
			db.SaveChanges();

		}

		public void UpdateCategory(CategoryEntity category)
		{
			using var db = new InventaryContext();
			db.Categories.Update(category);
			db.SaveChanges();
		}
		
	}
}
