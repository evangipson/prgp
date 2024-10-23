using Godot;

using PRPG.Constants;
using PRPG.Singletons;

public partial class NewTabFileExtensionLabel : Label
{
	private PlayerService _playerService;

	public override void _Ready()
	{
		_playerService = GetNode<PlayerService>(SingletonConstants.PlayerServicePath);
		Text = $".{LanguageConstants.LanguageFileExtensions[_playerService.GetPlayerLanguage()]}";
	}
}
