using Qiz.Domain.Comon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qiz.Domain.Entity
{
	public class Item : BaseEntity
	{

		public string Name { get; set; }

		public int TypeId { get; set; }

		public int Quantity { get; set; }
		protected bool isLowInWarehouse;
		private int v1;
		private string v2;


		public Item(int id, string name, int typeId)
		{
			Name = name;
			TypeId = typeId;
			Id = id;
		}

		public Item(int v1, string v2)
		{
			this.v1=v1;
			this.v2=v2;
		}
	}
	}
