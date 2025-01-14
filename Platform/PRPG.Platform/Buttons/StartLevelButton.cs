using Godot;

using PRPG.Platform.Constants;
using PRPG.Platform.Singletons;

namespace PRPG.Platform.Buttons
{
	public partial class StartLevelButton : Button
	{
		private ScreenService _screenService;
		private OptionButton _languageInput;

		public override void _Ready()
		{
			_screenService = GetNode<ScreenService>(SingletonConstants.ScreenServicePath);
			_languageInput = GetNode<OptionButton>("LanguageInput");
		}

		public override void _Pressed()
		{
			PlayerService.SetPlayerLanguage(_languageInput.Selected - 1);
			_screenService.GotoScene(SceneConstants.DungeonScenePath);
		}
	}
}
