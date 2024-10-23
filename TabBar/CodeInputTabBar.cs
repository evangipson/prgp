using Godot;

using PRPG.Constants;
using PRPG.Enums;
using PRPG.Singletons;

public partial class CodeInputTabBar : TabBar
{
	private PlayerService _playerService;
	private Language _playerLanguage;
	private string _languageFileExtension;

	public override void _Ready()
	{
		_playerService = GetNode<PlayerService>(SingletonConstants.PlayerServicePath);
		_playerLanguage = _playerService.GetPlayerLanguage();
		_languageFileExtension = LanguageConstants.LanguageFileExtensions[_playerLanguage];

		AddTab($"main.{_languageFileExtension}");
		CurrentTab = 0;
	}
}
