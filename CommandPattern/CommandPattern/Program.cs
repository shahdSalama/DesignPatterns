using System;
using System.Collections.Generic;

namespace CommandPattern
{
	class Program
	{
		static void Main(string[] args)
		{
			LightBulp l1 = new LightBulp("L1");
			LightBulp l2 = new LightBulp("L2");

			OnCommand onl1 = new OnCommand(l1);
			OnCommand onl2 = new OnCommand(l2);

			OffCommand off = new OffCommand(new List<LightBulp> { l1, l2 });

			Invoker i1 = new Invoker(onl1, off);
			Invoker i2 = new Invoker(onl2, off);

			i1.OnPress();
			i2.OnPress();




			i2.OffPress();

			Console.WriteLine("______________________");

			i2.RollBack();



			Console.Read();
		}
	}
}
