using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Как Вас зовут?");
			string name = Console.ReadLine();
			Console.Write($"Здравствуйте, {name} ! Сегодня  ");
			Console.WriteLine($"{DateTime.Today}");
			Console.ReadLine();
		}
	}
}
