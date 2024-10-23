using Godot;

using PRPG.Constants;
using PRPG.Enums;
using PRPG.Singletons;

public partial class CodeInput : CodeEdit
{
	private PlayerService _playerService;
	private Language _playerLanguage;

	public override void _Ready()
	{
		_playerService = GetNode<PlayerService>(SingletonConstants.PlayerServicePath);
		_playerLanguage = _playerService.GetPlayerLanguage();
		SyntaxHighlighter = CodeHighlightingConstants.LanguageCodeHighlighters[_playerLanguage];
	}

	public override void _Process(double delta)
	{
	}
}
