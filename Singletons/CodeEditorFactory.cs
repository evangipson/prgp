using Godot;

using PRPG.Constants;

namespace PRPG.Singletons
{
	public static class CodeEditorFactory
	{
		private static readonly Font _firaCodeFont = GD.Load<Font>("res://Font/FiraCode-Medium.ttf");

		public static CodeEdit CreateCodeEditor(string newTabName)
		{
			CodeEdit newCodeEditor = new()
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
				SyntaxHighlighter = CodeHighlightingConstants.LanguageCodeHighlighters[PlayerService.GetPlayerLanguage()],
				Name = newTabName,
				Text = LanguageConstants.LanguageExamples[PlayerService.GetPlayerLanguage()]
			};

			newCodeEditor.AddThemeFontOverride("font", _firaCodeFont);

			return newCodeEditor;
		}
	}
}
