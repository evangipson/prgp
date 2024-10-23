using Godot;

public partial class NewTabButton : Button
{
	private Panel _newTabPanel;

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		_newTabPanel = GetParent().GetNode<Panel>("NewTabPanel");
	}

	public override void _Pressed()
	{
		_newTabPanel.Visible = true;
	}
}
