using Godot;

using PRPG.Constants;
using PRPG.Enums;
using PRPG.Singletons;

public partial class CodeEditorTabContainer : TabContainer
{
	private Language _playerLanguage;
	private string _languageFileExtension;
	private TabBar _tabBar;

	public override void _Ready()
	{
		_playerLanguage = PlayerService.GetPlayerLanguage();
		_languageFileExtension = LanguageConstants.LanguageFileExtensions[_playerLanguage];
		_tabBar = GetTabBar();

		_tabBar.TabCloseDisplayPolicy = TabBar.CloseButtonDisplayPolicy.ShowAlways;
		_tabBar.TabClosePressed += tabIndex => _tabBar.RemoveTab((int)tabIndex);

		CreateNewTabInCodeEditor();
	}

	private void CreateNewTabInCodeEditor()
	{
		var codeEditor = CodeEditorFactory.CreateCodeEditor("main");
		AddChild(codeEditor);
		SetNewTabTitle(codeEditor.Name);
	}

	private void SetNewTabTitle(string codeEditorTabName)
	{
		_tabBar.SetTabTitle(_tabBar.TabCount - 1, $"{codeEditorTabName}.{LanguageConstants.LanguageFileExtensions[_playerLanguage]}");
	}
}
