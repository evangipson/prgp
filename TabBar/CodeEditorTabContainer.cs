using Godot;

using PRPG.Constants;
using PRPG.Enums;
using PRPG.Singletons;

public partial class CodeEditorTabContainer : TabContainer
{
	private PlayerService _playerService;
	private CodeEditorFactory _codeEditorFactory;
	private Language _playerLanguage;
	private string _languageFileExtension;

	public override void _Ready()
	{
		_playerService = GetNode<PlayerService>(SingletonConstants.PlayerServicePath);
		_codeEditorFactory = GetNode<CodeEditorFactory>(SingletonConstants.CodeEditorFactoryPath);
		_playerLanguage = _playerService.GetPlayerLanguage();
		_languageFileExtension = LanguageConstants.LanguageFileExtensions[_playerLanguage];

		var codeEditor = _codeEditorFactory.CreateCodeEditor();
		AddChild(codeEditor);
	}
}
