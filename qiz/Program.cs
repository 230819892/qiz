using Qiz.App.Concrete;
using Qiz.App.Manager;
using System;
namespace Qiz
{
	class Program
	{
		static void Main(string[] args)
		{
			MenuActionService actionService = new MenuActionService();
			ItemService itemService = new ItemService();
			ItemManager itemManger = new ItemManager(actionService, itemService);

			Console.WriteLine("Welcome to warehouse app!");
			while (true)
			{
				Console.WriteLine("Please let me know what you want to do:");
				var mainMenu = actionService.GetMenuActionsByMenuName("Main");
				for (int i = 0; i < mainMenu.Count; i++)
				{
					Console.WriteLine($"{mainMenu[i].Id}. {mainMenu[i].Name}");
				}

				var operation = Console.ReadKey();

				switch (operation.KeyChar)
				{
					case '1':
						var newId = itemManger.AddNewItem();
						break;


					default:
						Console.WriteLine("Action you entered does not exist");
						break;
				}

			}
		}		
	}
}
