using Godot;

using PRPG.Constants;
using PRPG.Enums;

namespace PRPG.Singletons
{
	public partial class CodeEditorFactory : Node
	{
		private PlayerService _playerService;
		private Language _playerLanguage;

		public override void _Ready()
		{
			_playerService = GetNode<PlayerService>(SingletonConstants.PlayerServicePath);
			_playerLanguage = _playerService.GetPlayerLanguage();
		}

		public CodeEdit CreateCodeEditor() => new()
		{
			AutoBraceCompletionEnabled = true,
			IndentAutomatic = true,
			CaretBlink = true,
			CodeCompletionEnabled = true,
			DrawTabs = true,
			ContextMenuEnabled = true,
			Editable = true,
			HighlightCurrentLine = true,
			GuttersDrawLineNumbers = true,
			SyntaxHighlighter = CodeHighlightingConstants.LanguageCodeHighlighters[_playerLanguage],
			Name = $"main.{LanguageConstants.LanguageFileExtensions[_playerLanguage]}"
		};
	}
}
