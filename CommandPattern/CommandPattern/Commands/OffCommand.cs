using System.Collections.Generic;

namespace CommandPattern
{
	public class OffCommand : ICommand
	{
		List<LightBulp> _lightList;

		public OffCommand(List<LightBulp> lightList)
		{
			this._lightList = lightList;
		}

		public void Excute()
		{
			foreach (LightBulp light in _lightList)
			{
				light.TurnOff();
			}

		}

		public void UnExcute()
		{
			foreach (LightBulp light in _lightList)
			{
				light.TurnOn();
			}
		}
	}
}

