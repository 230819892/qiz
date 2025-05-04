
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Qiz.Domain.Entity;
using Newtonsoft.Json;
using DocumentFormat.OpenXml.Bibliography;
using (FileStream fs = File.Open(@"C:\Users\Lenovo\source\repos\qiz\items", FileMode.Open, FileAccess.Read)) ;
namespace Qiz

{
	class list_service
	{
		
		public void Method()
		{
			List<Item> list = new List<Item>();
			list.Add(new Item(1, "Circle,2"));
			list.Add(new Item(2, "Cross,2"));
			string output = JsonConvert.SerializeObject(list);
			using StreamWriter sw = new StreamWriter(@"C:\Users\Lenovo\source\repos\qiz.Text");
			JsonTextWriter jsonTextWriter = new(sw);
			using JsonWriter writer = jsonTextWriter;
			JsonSerializer serializer = new JsonSerializer();
			serializer.Serialize(writer, list);
		}
	}
}
