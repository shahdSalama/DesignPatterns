namespace CommandPattern
{
	public class OnCommand : ICommand
	{
		LightBulp _light;

		public OnCommand(LightBulp light)
		{
			this._light = light;
		}

		public void Excute()
		{
			_light.TurnOn();
		}

		public void UnExcute()
		{
			_light.TurnOff();
		}
	}
}
