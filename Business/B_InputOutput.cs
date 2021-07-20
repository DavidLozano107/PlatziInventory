using DataAccess;
using Entities;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Business
{
	public class B_InputOutput
	{
		public List<InOutEntity> GetListInOut()
		{
			using var db = new InventaryContext();
			return db.InOuts.ToList();
		}

		public void CreateInOut(InOutEntity inOut)
		{
			using var db = new InventaryContext();
			db.InOuts.Add(inOut);
			db.SaveChanges();
		}

		public void UpdateInOut(InOutEntity inOut)
		{
			using var db = new InventaryContext();
			db.InOuts.Update(inOut);
			db.SaveChanges(); 
		}


	}
}
