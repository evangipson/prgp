using Godot;

using PRPG.Platform.Singletons;

namespace PRPG.Platform.Screens
{
	public partial class BackgroundColorRect : ColorRect
	{
		private int _ticks = 0;
		private float _elapsedLerpTime = 0.0f;
		private Color _baseColor;
		private Color _variantColor;

		[Export]
		private float _lerpSeconds = 3.0f;

		public override void _Ready()
		{
			SetNewColor();
		}

		public override void _Process(double delta)
		{
			_elapsedLerpTime += (float)delta;
			UpdateColorRect();
		}

		private void UpdateColorRect()
		{
			if (_elapsedLerpTime < _lerpSeconds)
			{
				Color = ColorService.Lerp(_baseColor, _variantColor, _elapsedLerpTime / _lerpSeconds);
				return;
			}

			_elapsedLerpTime = 0;
			SetNewColor();
		}

		private void SetNewColor()
		{
			_baseColor = Color;
			_variantColor = new()
			{
				R = ColorService.GetColorVariant(Color.R, 0.05f),
				G = ColorService.GetColorVariant(Color.G, 0.05f),
				B = ColorService.GetColorVariant(Color.B, 0.05f),
				A = 1
			};
		}
	}
}
