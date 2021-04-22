using System.Collections.Generic;

namespace CommandPattern
{
	/// <summary>
	/// It it the remote control that controles the light 
	/// When constructing it we pass to it the on and off commands
	/// </summary>
	public class Invoker
	{
		ICommand _on;
		ICommand _off;
		List<ICommand> _commandsList; // list of excuted commands, we keep track of them so we can reverse (Unexcute) them in order

		public Invoker(ICommand on, ICommand off)
		{
			_on = on;
			_off = off;
			_commandsList = new List<ICommand>();
		}

		public void OnPress()
		{
			_on.Excute();

			_commandsList.Add(_on);
		}
		public void OffPress()
		{
			_off.Excute();

			_commandsList.Add(_off);
		}

		public void RollBack()
		{
			_commandsList.Reverse();

			foreach (ICommand command in _commandsList)
			{
				command.UnExcute();
			}
		}
	}
}
