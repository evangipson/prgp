using Godot;

using PRPG.Constants;
using PRPG.Singletons;

public partial class NewTabCreateButton : Button
{
	private Panel _newTabPanel;
	private Panel _newTabModalPanel;
	private Panel _codePanel;
	private TabBar _codeInput;
	private LineEdit _newTabNameInput;
	private PlayerService _playerService;

	public override void _Ready()
	{
		_newTabModalPanel = GetParent<Panel>();
		_newTabPanel = _newTabModalPanel.GetParent<Panel>();
		_codePanel = _newTabPanel.GetParent<Panel>();

		_codeInput = _codePanel.GetNode<TabBar>("TabBar");
		_newTabNameInput = _newTabModalPanel.GetNode<LineEdit>("NewTabNameInput");

		_playerService = GetNode<PlayerService>(SingletonConstants.PlayerServicePath);
	}

	public override void _Pressed()
	{
		if(string.IsNullOrEmpty(_newTabNameInput.Text))
		{
			return;
		}

		_codeInput.AddTab($"{_newTabNameInput.Text}.{LanguageConstants.LanguageFileExtensions[_playerService.GetPlayerLanguage()]}");
		_codeInput.CurrentTab = _codeInput.TabCount;
		_newTabPanel.Visible = false;
	}
}
