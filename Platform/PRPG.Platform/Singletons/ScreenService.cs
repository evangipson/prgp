using Godot;

namespace PRPG.Platform.Singletons
{
	public partial class ScreenService : Node
	{
		private Window _root;
		private Node _currentScene;

		public override void _Ready()
		{
			_root = GetTree().Root;
			_currentScene = _root.GetChild(_root.GetChildCount() - 1);
		}

		public void GotoScene(string scenePath)
		{
			CallDeferred(MethodName.DeferredGotoScene, scenePath);
		}

		public void DeferredGotoScene(string scenePath)
		{
			_currentScene.Free();
			_currentScene = GD.Load<PackedScene>(scenePath).Instantiate();
			_root.AddChild(_currentScene);
			GetTree().CurrentScene = _currentScene;
		}
	}
}
