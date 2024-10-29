using Godot;

using PRPG.Constants;
using PRPG.Singletons;

namespace PRPG.Buttons
{
	public partial class StartGameButton : Button
	{
		private ScreenService _screenService;

		public override void _Ready() => _screenService = GetNode<ScreenService>(SingletonConstants.ScreenServicePath);

		public override void _Pressed() => _screenService.GotoScene(SceneConstants.IntroScenePath);
	}
}