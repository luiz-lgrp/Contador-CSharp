using System;
using System.Threading;

namespace Stopwatch
{
	class Program
	{
		static void Main(string[] args)
		{
			Menu();
		}

		static void Menu()
        {
			Console.Clear();
			Console.WriteLine("10s = 10 segundos");
			Console.WriteLine("10m = 10 minutos");
			Console.WriteLine("0 = Sair");
			Console.WriteLine("Quanto tempo deseja contar?");

			string data = Console.ReadLine().ToLower();
			char type = char.Parse(data.Substring(data.Length - 1, 1));
			int time = int.Parse(data.Substring(0, data.Length - 1));
			
			int multiplier = 1;

			if (type == 'm')
            {
				multiplier = 60;
            }
			if (time == 0)
            {
				System.Environment.Exit(0);
            }

			PreStart(time * multiplier);
        }

		static void PreStart(int time)
        {
			Console.Clear();
			Console.WriteLine("Preparando...");
			Thread.Sleep(1500);
			Console.WriteLine("GO!");
			Thread.Sleep(2000);

			Start(time);

        }

		static void Start(int time)
		{
			
			int currentTime = 0;

			while (currentTime != time)
			{
				Console.Clear(); 
				currentTime++;
				Console.WriteLine(currentTime);
				Thread.Sleep(1000); 
			}

			Console.Clear();
			Console.WriteLine("Finalizando o Stopwatch");
			Thread.Sleep(2000);
			Menu();
		}

	}
}