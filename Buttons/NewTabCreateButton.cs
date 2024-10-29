using Godot;
using PRPG.Constants;
using PRPG.Singletons;

namespace PRPG.Buttons
{
	public partial class NewTabCreateButton : Button
	{
		private Panel _newTabModalBackdropPanel;
		private Panel _newTabModalPanel;
		private Panel _codePanel;
		private TabContainer _codeEditor;
		private LineEdit _newTabNameInput;
		private TabBar _tabBar;

		public override void _Ready()
		{
			_newTabModalPanel = GetParent<Panel>();
			_newTabNameInput = _newTabModalPanel.GetNode<LineEdit>("NewTabNameInput");
			_newTabModalBackdropPanel = _newTabModalPanel.GetParent<Panel>();
			_codePanel = _newTabModalBackdropPanel.GetParent<Panel>();
			_codeEditor = _codePanel.GetNode<TabContainer>("CodeEditorTabContainer");
			_tabBar = _codeEditor.GetTabBar();
		}

		public override void _Pressed()
		{
			if (string.IsNullOrEmpty(_newTabNameInput.Text))
			{
				return;
			}

			var newCodeTab = CodeEditorFactory.CreateCodeEditor(_newTabNameInput.Text);
			_codeEditor.AddChild(newCodeTab);
			_tabBar.SetTabTitle(_tabBar.TabCount - 1, $"{_newTabNameInput.Text}.{LanguageConstants.LanguageFileExtensions[PlayerService.GetPlayerLanguage()]}");
			_newTabModalBackdropPanel.Visible = false;
		}
	}
}
