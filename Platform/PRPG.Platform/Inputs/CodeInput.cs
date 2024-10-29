using Godot;

using PRPG.Platform.Constants;
using PRPG.Platform.Enums;
using PRPG.Platform.Singletons;

namespace PRPG.Platform.Inputs
{
	public partial class CodeInput : CodeEdit
	{
		private Language _playerLanguage;

		public override void _Ready()
		{
			_playerLanguage = PlayerService.GetPlayerLanguage();
			SyntaxHighlighter = CodeHighlightingConstants.LanguageCodeHighlighters[_playerLanguage];
		}
	}
}
