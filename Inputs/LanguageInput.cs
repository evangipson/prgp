using System;
using Godot;

using PRPG.Constants;
using PRPG.Enums;

namespace PRPG.Inputs
{
	public partial class LanguageInput : OptionButton
	{
		private Label _languageInfoLabel;
		private CodeEdit _languageSample;
		private Button _startGameButton;
		private SyntaxHighlighter _syntaxHighlighter;

		public override void _Ready()
		{
			_languageInfoLabel = GetNode<Label>("LanguageInfoLabel");
			_languageSample = GetNode<CodeEdit>("LanguageSample");
			_startGameButton = GetParent<Button>();
			_syntaxHighlighter = _languageSample.SyntaxHighlighter;
			PopulateLanguageOptions();
		}

		public override void _Input(InputEvent @event)
		{
			if (Selected == 0)
			{
				return;
			}

			_languageInfoLabel.Text = Selected switch
			{
				> 0 => LanguageConstants.LanguagesWithDescriptions[(Language)Selected - 1],
				_ => "Information about your language selection will show up here, once you've made a choice."
			};

			_languageSample.Text = Selected switch
			{
				> 0 => LanguageConstants.LanguageExamples[(Language)Selected - 1],
				_ => string.Empty
			};

			_languageSample.SyntaxHighlighter = Selected switch
			{
				> 0 => CodeHighlightingConstants.LanguageCodeHighlighters[(Language)Selected - 1],
				_ => null
			};

			_languageSample.Visible = true;
			_startGameButton.Disabled = false;
		}

		private void PopulateLanguageOptions()
		{
			var _counter = 0;
			AddItem("Select language...", _counter);

			foreach (var language in LanguageConstants.LanguagesWithDescriptions.Keys)
			{
				AddItem(Enum.GetName(language), _counter++);
			}

			SetItemDisabled(0, true);
			Select(0);
		}
	}
}