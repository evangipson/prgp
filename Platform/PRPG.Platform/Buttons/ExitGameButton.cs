using Godot;

namespace PRPG.Platform.Buttons
{
	public partial class ExitGameButton : Button
	{
		public override void _Pressed() => GetTree().Quit();
	}
}
