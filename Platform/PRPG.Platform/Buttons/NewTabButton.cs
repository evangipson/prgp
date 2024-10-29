using Godot;

namespace PRPG.Platform.Buttons
{
	public partial class NewTabButton : Button
	{
		private Panel _newTabModalBackdropPanel;

		public override void _Ready()
		{
			_newTabModalBackdropPanel = GetParent().GetNode<Panel>("NewTabModalBackdropPanel");
		}

		public override void _Pressed()
		{
			_newTabModalBackdropPanel.Visible = true;
		}
	}
}
