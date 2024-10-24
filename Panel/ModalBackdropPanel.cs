using Godot;

public partial class ModalBackdropPanel : Panel
{
	private LineEdit _newTabNameInput;

	public override void _Ready()
	{
		SetProcessInput(true);
		_newTabNameInput = GetNode<Panel>("NewTabModalPanel").GetNode<LineEdit>("NewTabNameInput");
	}

	public override void _Input(InputEvent @event)
	{
		if(Input.IsKeyPressed(Key.Escape))
		{
			_newTabNameInput.Clear();
			Visible = false;
		}
	}
}
