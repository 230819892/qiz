using Qiz.App.Comon;
using Qiz.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Qiz.App.Concrete
{
   
    
		public class MenuActionService : BaseService<MenuAction>
	{
		public MenuActionService()
		{
			Initialize();
		}
		public List<MenuAction> GetMenuActionsByMenuName(string menuName)
		{
			List<MenuAction> result = new List<MenuAction>();
			foreach (var menuAction in Items)
			{
				if (menuAction.MenuName == menuName)
				{
					result.Add(menuAction);
				}
			}
			return result;
		}

		private void Initialize()
		{
			AddItem(new MenuAction(1, "Add item", "Main"));


			AddItem(new MenuAction(1, "Circle", "AddNewItemMenu"));
			AddItem(new MenuAction(2, "Cross", "AddNewItemMenu"));




		
		}
	}
}