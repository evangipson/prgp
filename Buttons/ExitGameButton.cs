using Godot;

namespace PRPG.Buttons
{
	public partial class ExitGameButton : Button
	{
		public override void _Pressed() => GetTree().Quit();
	}
}
