using Godot;

using PRPG.Constants;
using PRPG.Singletons;

public partial class StartLevelButton : Button
{
	private ScreenService _screenService;
	private PlayerService _playerService;
	private OptionButton _languageInput;

	public override void _Ready()
	{
		_screenService = GetNode<ScreenService>(SingletonConstants.ScreenServicePath);
		_playerService = GetNode<PlayerService>(SingletonConstants.PlayerServicePath);
		_languageInput = GetNode<OptionButton>("LanguageInput");
	}

	public override void _Pressed()
	{
		_playerService.SetPlayerLanguage(_languageInput.Selected);
		_screenService.GotoScene(SceneConstants.DungeonScenePath);
	}
}
