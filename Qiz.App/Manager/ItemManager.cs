using Qiz.App.Concrete;
using Qiz.Domain.Entity;
using Qiz.App.Abstract;
using Qiz.App.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using Qiz.App.Abstract;
using Qiz.App.Concrete;
using Qiz.Domain.Entity;



namespace Qiz.App.Manager
{
	public class ItemManager
	{
		private readonly MenuActionService _actionService;
		private Iservice.IService<Item> _itemService;
		private Iservice.IService<Item>? itemService;

		public ItemManager(MenuActionService actionService, ItemService itemService)
		{
			_itemService = itemService;
			_actionService = actionService;
			this.itemService=itemService;
		}
		public int AddNewItem()
		{
			var addNewItemMenu = _actionService.GetMenuActionsByMenuName("AddNewItemMenu");
			Console.WriteLine("Please select item type:");
			for (int i = 0; i < addNewItemMenu.Count; i++)
			{
				Console.WriteLine($"{addNewItemMenu[i].Id}. {addNewItemMenu[i].Name}");
			}

			var operation = Console.ReadKey();
			int typeId;
			Int32.TryParse(operation.KeyChar.ToString(), out typeId);
			Console.WriteLine("Please insert name for item:");
			var name = Console.ReadLine();
			var lastId = _itemService.GetLastId();
			Item item = new Item(lastId+1, name, typeId);
			_itemService.AddItem(item);
			return item.Id;
		}

		public void RemoveItemById(int id)
		{
			var item = _itemService.GetItemById(id);
			_itemService.RemoveItem(item);
		}

		public Item GetItemById(int id)
		{
			var item = _itemService.GetItemById(id);
			return item;
		}
	}
}

