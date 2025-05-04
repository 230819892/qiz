using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qiz.App.Abstract
{
    class Iservice
    {
		public interface IService<T>
		{
			List<T> Items { get; set; }

			List<T> GetAllItems();
			int GetLastId();
			T GetItemById(int id);
			int AddItem(T item);
			int UpdateItem(T item);
			void RemoveItem(T item);
		}
	}
}
