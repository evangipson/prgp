using Godot;

using PRPG.Platform.Constants;
using PRPG.Platform.Singletons;

namespace PRPG.Platform.Buttons
{
	public partial class CreateHeroButton : Button
	{
		private ScreenService _screenService;

		public override void _Ready() => _screenService = GetNode<ScreenService>(SingletonConstants.ScreenServicePath);

		public override void _Pressed() => _screenService.GotoScene(SceneConstants.CreateHeroScenePath);
	}
}