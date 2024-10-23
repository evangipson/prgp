using Godot;

using PRPG.Constants;
using PRPG.Singletons;

public partial class CreateHeroButton : Button
{
	private ScreenService ScreenService => GetNode<ScreenService>(SingletonConstants.ScreenServicePath);

	public override void _Pressed() => ScreenService.GotoScene(SceneConstants.CreateHeroScenePath);
}
