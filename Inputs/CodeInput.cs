using Godot;

using PRPG.Constants;
using PRPG.Enums;
using PRPG.Singletons;

namespace PRPG.Inputs
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
