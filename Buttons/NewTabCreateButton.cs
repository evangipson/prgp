using Godot;

using PRPG.Constants;
using PRPG.Singletons;

public partial class NewTabCreateButton : Button
{
	private Panel _newTabPanel;
	private Panel _newTabModalPanel;
	private Panel _codePanel;
	private TabContainer _codeEditor;
	private LineEdit _newTabNameInput;
	private PlayerService _playerService;
	private CodeEditorFactory _codeEditorFactory;

	public override void _Ready()
	{
		_newTabModalPanel = GetParent<Panel>();
		_newTabPanel = _newTabModalPanel.GetParent<Panel>();
		_codePanel = _newTabPanel.GetParent<Panel>();

		_codeEditor = _codePanel.GetNode<TabContainer>("CodeEditorTabContainer");
		_newTabNameInput = _newTabModalPanel.GetNode<LineEdit>("NewTabNameInput");

		_playerService = GetNode<PlayerService>(SingletonConstants.PlayerServicePath);
		_codeEditorFactory = GetNode<CodeEditorFactory>(SingletonConstants.CodeEditorFactoryPath);
	}

	public override void _Pressed()
	{
		if(string.IsNullOrEmpty(_newTabNameInput.Text))
		{
			return;
		}

		var newCodeTab = _codeEditorFactory.CreateCodeEditor();
		_codeEditor.AddChild(newCodeTab);
		_newTabPanel.Visible = false;
	}
}
