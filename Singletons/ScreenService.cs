using System.IO;
using Godot;

namespace PRPG.Singletons
{
	public partial class ScreenService : Node
	{
		private Window Root => GetTree().Root;

		public Node CurrentScene { get; set; }

		public override void _Ready()
		{
			CurrentScene = Root.GetChild(Root.GetChildCount() - 1);
		}

		public void GotoScene(string scenePath)
		{
			CallDeferred(MethodName.DeferredGotoScene, scenePath);
		}

		public void DeferredGotoScene(string scenePath)
		{
			CurrentScene.Free();
			CurrentScene = GD.Load<PackedScene>(scenePath).Instantiate();
			Root.AddChild(CurrentScene);
			GetTree().CurrentScene = CurrentScene;
		}
	}
}
