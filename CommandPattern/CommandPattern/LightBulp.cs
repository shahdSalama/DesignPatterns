using System;

namespace CommandPattern
{
	public class LightBulp
	{
		readonly string name;

		public LightBulp(string name)
		{
			this.name = name;
		}

		public void TurnOn()
		{
			Console.WriteLine($"{name} Light turned on");
		}
		public void TurnOff()
		{
			Console.WriteLine($"{name} Light turned off");
		}
	}
}
