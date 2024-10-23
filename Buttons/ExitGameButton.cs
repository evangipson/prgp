using Godot;

public partial class ExitGameButton : Button
{
	public override void _Pressed() => GetTree().Quit();
}
